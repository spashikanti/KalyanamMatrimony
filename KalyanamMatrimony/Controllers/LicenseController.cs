using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KalyanamMatrimony.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static KalyanamMatrimony.Models.CustomEnums;
using Microsoft.AspNetCore.Http;
using KalyanamMatrimony.ViewModels;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.AspNetCore.Mvc.Rendering;
using InstamojoAPI;
using System.IO;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Net;

namespace KalyanamMatrimony.Controllers
{
    public class LicenseController : BaseController
    {
        private readonly IMatrimonyRepository matrimonyRepository;

        public LicenseController(IMatrimonyRepository matrimonyRepository)
        {
            this.matrimonyRepository = matrimonyRepository;
        }

        [HttpGet]
        [Authorize(Roles = "SuperAdmin, Admin")]
        public IActionResult UpdateLicense()
        {
            int licenseId = GetSessionLicenseId();
            IEnumerable<License> licenses = null;
            if (licenseId == 0)
            {
                licenses = matrimonyRepository.GetAllActiveLicenses();
                ViewBag.UsersCount = matrimonyRepository.GetAllActiveLicenses()
                                .Select(n => new SelectListItem
                                {
                                    Value = n.UsersCount.ToString(),
                                    Text = n.Description
                                })
                                .Distinct()
                                .ToList();
            }
            else
            {
                Organisation org = GetSessionOrgDetails();
                if (org.EndDate < DateTime.Now)
                {
                    ViewBag.Message = "Your license is expired, please renew";
                }
                licenses = matrimonyRepository.GetAllActiveLicenses().Where(x => x.LicenseType != LicenseType.Free);

                ViewBag.UsersCount = matrimonyRepository.GetAllActiveLicenses()
                                .Where(x => x.LicenseType != LicenseType.Free)
                                .Select(n => new SelectListItem
                                {
                                    Value = n.UsersCount.ToString(),
                                    Text = n.Description
                                })
                                .Distinct()
                                .ToList();
            }

            //ViewBag.UsersCount = matrimonyRepository.GetAllActiveLicenses()
            //                    .Select(uc => uc.UsersCount)
            //                    .Distinct();

            return View(licenses);
        }

        [HttpPost]
        [Authorize(Roles = "SuperAdmin, Admin")]
        public IActionResult UpdateLicense(int licenseId, float monthsCount)
        {
            if (licenseId > 0)
            {
                int orgId = GetSessionOrgId();
                Organisation org = matrimonyRepository.GetOrganisationById(orgId);
                org.LicenseId = licenseId;
                //Update org end date
                float numOfDays = 31 * monthsCount;
                org.EndDate = DateTime.Now.AddDays(numOfDays);
                org = matrimonyRepository.UpdateOrganisation(org);
                SetSessionOrgDetails(org);
                //Update PaymentHistory Table for Org
                //Navigate to acknowledge page for successful license update
                return View("AcknowledgeLicense");
            }

            //GetLicenses
            ViewBag.UsersCount = matrimonyRepository.GetAllActiveLicenses()
                                .Select(uc => uc.UsersCount)
                                .Distinct();
            IEnumerable<License> licenses = matrimonyRepository.GetAllActiveLicenses();
            return View(licenses);

        }

        [HttpGet]
        [Authorize(Roles = "SuperAdmin, Admin")]
        public IActionResult ChooseLicense()
        {
            PaymentViewModel paymentViewModel = new PaymentViewModel();
            int licenseId = GetSessionLicenseId();
            if (licenseId == 0)
            {
                paymentViewModel.Licenses = matrimonyRepository.GetAllActiveLicenses();
                ViewBag.UsersCount = matrimonyRepository.GetAllActiveLicenses()
                                .Select(x => x.UsersCount)
                                .Distinct()
                                .Select(n => new SelectListItem
                                {
                                    Value = n.ToString(),
                                    Text = n.ToString() + " Users"
                                })
                                .ToList();
            }
            else
            {
                Organisation org = GetSessionOrgDetails();
                if (org.EndDate < DateTime.Now)
                {
                    ViewBag.Message = "Your license is expired, please renew";
                }
                paymentViewModel.Licenses = matrimonyRepository.GetAllActiveLicenses().Where(x => x.LicenseType != LicenseType.Free);

                ViewBag.UsersCount = matrimonyRepository.GetAllActiveLicenses()
                                .Where(x => x.LicenseType != LicenseType.Free)
                                .Select(x => x.UsersCount)
                                .Distinct()
                                .Select(n => new SelectListItem
                                {
                                    Value = n.ToString(),
                                    Text = n.ToString() + " Users"
                                })
                                .ToList();
            }

            Organisation organisation = GetSessionOrgDetails();
            paymentViewModel.OrgId = organisation.OrgId;
            paymentViewModel.Name = organisation.FullName;
            paymentViewModel.Phone = organisation.Phone;
            paymentViewModel.UserId = GetSessionUserId();
            paymentViewModel.Email = User.Identity.Name;
            SetSessionPaymentDetails(paymentViewModel);
            return View(paymentViewModel);
        }

        [HttpPost]
        [Authorize(Roles = "SuperAdmin, Admin")]
        public IActionResult ChooseLicense(int licenseId, PaymentViewModel model)
        {
            if (ModelState.IsValid)
            {
                License license = matrimonyRepository.GetLicenseById(licenseId);
                if (license != null)
                {
                    model.Description = license.Description;
                    model.Amount = license.Price;
                    //Mojo Api, create payment order
                    string Insta_client_id = "test_HB3puOS8s0eYFJKLUzCudIrM2BAGQTW4Tnp",
                           Insta_client_secret = "test_BPW8BQCLzhdZ0ECSbFjtWVj97bgcvmDfVtdt6n5XA6yx1ZGAdqq90dc7uIaGay8DeXhQHbUzSBM52t0vb6E3UP2DajG0euygoaAJGw5CLObsTEWsbecY7sVbsNF",
                           Insta_Endpoint = InstamojoConstants.INSTAMOJO_API_ENDPOINT,
                           Insta_Auth_Endpoint = InstamojoConstants.INSTAMOJO_AUTH_ENDPOINT;
                    Instamojo objClass = InstamojoImplementation.getApi(Insta_client_id, Insta_client_secret, Insta_Endpoint, Insta_Auth_Endpoint);
                    CreatePaymentOrder(objClass, model, ModelState);

                    if(string.IsNullOrEmpty(model.PaymentURL))
                    {
                        return View(model);
                    }
                    else
                    {
                        //Add data to session
                        SetSessionPaymentDetails(model);
                        //Add data to payment history table
                        AddPaymentHistory(model);
                        //Redirect to UpdateLicense
                        return RedirectToAction("UpdateLicense", "License");
                    }
                }
            }

            return View(model);
        }




        [HttpGet]
        [Authorize(Roles = "SuperAdmin, Admin")]
        public IActionResult AcknowledgeLicense()
        {
            return View();
        }

        public void CreatePaymentOrder(Instamojo objClass, PaymentViewModel model, ModelStateDictionary ModelState)
        {
            PaymentOrder objPaymentRequest = new PaymentOrder();
            //Required POST parameters
            objPaymentRequest.name = model.Name;
            objPaymentRequest.email = model.Email;
            objPaymentRequest.phone = model.Phone;
            objPaymentRequest.description = model.Description;
            objPaymentRequest.amount = model.Amount;
            objPaymentRequest.currency = "INR";

            string randomName = Path.GetRandomFileName();
            randomName = randomName.Replace(".", string.Empty);
            objPaymentRequest.transaction_id = "pari_" + randomName;

            objPaymentRequest.redirect_url = "http://localhost:49831/License/UpdateLicense";
            //objPaymentRequest.webhook_url = "https://your.server.com/webhook";
            //Extra POST parameters 

            try
            {
                CreatePaymentOrderResponse objPaymentResponse = objClass.createNewPaymentRequest(objPaymentRequest);
                model.TransactionId = objPaymentRequest.transaction_id;
                model.PaymentURL = objPaymentResponse.payment_options.payment_url;
                model.Status = objPaymentResponse.order.status;
                model.OrderId = objPaymentResponse.order.id;
            }
            catch (ArgumentNullException ex)
            {
                ModelState.AddModelError("", ex.Message);
            }
            catch (WebException ex)
            {
                ModelState.AddModelError("", ex.Message);
            }
            catch (IOException ex)
            {
                ModelState.AddModelError("", ex.Message);
            }
            catch (InvalidPaymentOrderException ex)
            {
                if (!ex.IsWebhookValid())
                {
                    ModelState.AddModelError("", "Webhook is invalid");
                }

                if (!ex.IsCurrencyValid())
                {
                    ModelState.AddModelError("", "Currency is Invalid");
                }

                if (!ex.IsTransactionIDValid())
                {
                    ModelState.AddModelError("", "Transaction ID is Inavlid");
                }
            }
            catch (ConnectionException ex)
            {
                ModelState.AddModelError("", ex.Message);
            }
            catch (BaseException ex)
            {
                ModelState.AddModelError("", ex.Message);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
            }
        }

        public void AddPaymentHistory(PaymentViewModel model)
        {
            PaymentHistory paymentHistory = new PaymentHistory();
            paymentHistory.Amount = model.Amount;
            paymentHistory.Description = model.Description;
            paymentHistory.Email = model.Email;
            paymentHistory.LicenseId = model.LicenseId;
            paymentHistory.Name = model.Name;
            paymentHistory.OrderId = model.OrderId;
            paymentHistory.OrgId = model.OrgId;
            paymentHistory.PaymentURL = model.PaymentURL;
            paymentHistory.Phone = model.Phone;
            paymentHistory.Status = model.Status;
            paymentHistory.TransactionId = model.TransactionId;
            paymentHistory.UserId = model.UserId;
            matrimonyRepository.AddPaymentHistory(paymentHistory);
        }
    }
}
