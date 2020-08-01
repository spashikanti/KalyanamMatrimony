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
using InstaSharp;
using System.IO;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Net;
using NLog;
using Microsoft.Extensions.Logging;

namespace KalyanamMatrimony.Controllers
{
    public class LicenseController : BaseController
    {
        private readonly IMatrimonyRepository matrimonyRepository;
        private readonly ILogger<LicenseController> logger;

        public LicenseController(IMatrimonyRepository matrimonyRepository, ILogger<LicenseController> logger)
        {
            this.matrimonyRepository = matrimonyRepository;
            this.logger = logger;
        }

        [HttpGet]
        [Authorize(Roles = "SuperAdmin, Admin")]
        public IActionResult UpdateLicense()
        {
            PaymentViewModel paymentViewModel = GetSessionPaymentDetails();
            return View(paymentViewModel);
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
        public async Task<IActionResult> ChooseLicense(int licenseId, PaymentViewModel model)
        {
            if (ModelState.IsValid)
            {
                License license = matrimonyRepository.GetLicenseById(licenseId);
                if (license != null)
                {
                    model.Description = license.Description;
                    model.Amount = license.Price;

                    if(license.LicenseType == LicenseType.Free)
                    {
                        //Update org Table
                        Organisation org = GetSessionOrgDetails();
                        org.LicenseId = licenseId;
                        matrimonyRepository.UpdateOrganisation(org);
                        //Add data to payment history table
                        AddPaymentHistory(model);
                        return RedirectToAction("AcknowledgeLicense", "License", new { licenseType = "free" });
                    }

                    model.RedirectURL = Constants.InstamojoConstants.INSTA_AFTER_PAYMENT_REDIRECT_URL;
                    
                    InstaSharp.Interface.IInstamojo objClass = GetInstamojoObj();
                    bool result = await CreatePaymentOrder(objClass, model, ModelState);

                    if(result && string.IsNullOrEmpty(model.PaymentURL))
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
        public async Task<IActionResult> AcknowledgeLicense()
        {
            //Get Transaction Details by OrderId
            PaymentViewModel paymentViewModel = GetSessionPaymentDetails();

            //string payment_id, string payment_status, string id, string transaction_id
            //Query strings
            Microsoft.Extensions.Primitives.StringValues queryVal;
            string status;
            if (HttpContext.Request.Query.TryGetValue("licenseType", out queryVal) &&
        queryVal.FirstOrDefault() == "free")
            {
                status = Constants.InstamojoConstants.INSTA_STATUS_COMPLETED;
            }
            else
            {
                HttpContext.Request.Query.TryGetValue("payment_status", out queryVal);
                status = queryVal.FirstOrDefault();
                status = await GetPaymentDetailsByOrderId(paymentViewModel.OrderId);
            }

            paymentViewModel.Status = status;
            //whatever the status, update the paymenthistory table with status
            PaymentHistory paymentHistory = matrimonyRepository.GetPaymentHistoryById(paymentViewModel.PaymentHistoryId);
            paymentHistory.Status = paymentViewModel.Status;
            matrimonyRepository.UpdatePaymentHistory(paymentHistory);
            //if status is success (completed/credit) update license for the org
            if(status == Constants.InstamojoConstants.INSTA_STATUS_CREDIT ||
                status == Constants.InstamojoConstants.INSTA_STATUS_COMPLETED)
            {
                Organisation org = GetSessionOrgDetails();
                org.LicenseId = paymentViewModel.LicenseId;
                //update org
                org = matrimonyRepository.UpdateOrganisation(org);
                SetSessionOrgDetails(org);
            }
            //url
            //AcknowledgeLicense?payment_id=MOJO0801V05N70158777&payment_status=Credit&id=30d7ec3b5f4b46e9947dc6b084efbaf0&transaction_id=pari_gjnvrrc2eaw

            return View(paymentViewModel);
        }

        public async Task<bool> CreatePaymentOrder(InstaSharp.Interface.IInstamojo objClass, PaymentViewModel model, ModelStateDictionary ModelState)
        {
            bool result = false;
            InstaSharp.Model.PaymentOrder objPaymentRequest = new InstaSharp.Model.PaymentOrder();
            //PaymentOrder objPaymentRequest = new PaymentOrder();
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

            objPaymentRequest.redirect_url = Constants.InstamojoConstants.INSTA_AFTER_PAYMENT_REDIRECT_URL;
            objPaymentRequest.webhook_url = Constants.InstamojoConstants.INSTA_AFTER_PAYMENT_WEBHOOK_URL;
            //Extra POST parameters 

            try
            {
                InstaSharp.Response.CreatePaymentOrderResponse objPaymentResponse = objClass.CreateNewPaymentRequest(objPaymentRequest);
                model.TransactionId = objPaymentRequest.transaction_id;
                model.PaymentURL = objPaymentResponse.payment_options.payment_url;
                model.Status = objPaymentResponse.order.status;
                model.OrderId = objPaymentResponse.order.id;
                result = true;
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
            catch (InstaSharp.Exceptions.InvalidPaymentOrderException ex)
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
            catch (InstaSharp.Exceptions.ConnectionException ex)
            {
                ModelState.AddModelError("", ex.Message);
            }
            catch (InstaSharp.Exceptions.BaseException ex)
            {
                ModelState.AddModelError("", ex.Message);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
            }
            return result;
        }

        public async Task<string> GetPaymentDetailsByOrderId(string orderId)
        {
            /***** Get Details of Payment order using OrderId. *******/
            try
            {
                //string Insta_client_id = Constants.InstamojoConstants.INSTA_CLIENT_ID_TEST,
                //           Insta_client_secret = Constants.InstamojoConstants.INSTA_CLIENT_SECRET_TEST,
                //           Insta_Endpoint = Constants.InstamojoConstants.INSTAMOJO_API_ENDPOINT_TEST,
                //           Insta_Auth_Endpoint = Constants.InstamojoConstants.INSTAMOJO_AUTH_ENDPOINT_TEST;
                //PaymentGatewayAPI.Instamojo objClass = PaymentGatewayAPI.InstamojoImplementation.getApi(Insta_client_id, Insta_client_secret, Insta_Endpoint, Insta_Auth_Endpoint);
                //PaymentGatewayAPI.PaymentOrderDetailsResponse objPaymentRequestDetailsResponse = objClass.getPaymentOrderDetails(orderId);
                //return objPaymentRequestDetailsResponse.status;

                InstaSharp.Interface.IInstamojo objClass = GetInstamojoObj();
                InstaSharp.Response.PaymentOrderDetailsResponse objPaymentRequestDetailsResponse = objClass.GetPaymentOrderDetails(orderId);
                return objPaymentRequestDetailsResponse.status;
            }
            catch (Exception ex)
            {
                logger.Log(Microsoft.Extensions.Logging.LogLevel.Error, $"Transaction orderid: {orderId}. Error: {ex.Message}");
                return "Failed";
            }
        }

        public InstaSharp.Interface.IInstamojo GetInstamojoObj()
        {
            string Insta_client_id = Constants.InstamojoConstants.INSTA_CLIENT_ID_TEST,
                           Insta_client_secret = Constants.InstamojoConstants.INSTA_CLIENT_SECRET_TEST,
                           Insta_Endpoint = Constants.InstamojoConstants.INSTAMOJO_API_ENDPOINT_TEST,
                           Insta_Auth_Endpoint = Constants.InstamojoConstants.INSTAMOJO_AUTH_ENDPOINT_TEST;
            return InstaSharp.InstamojoImplementation.getApi(Insta_client_id, Insta_client_secret, Insta_Endpoint, Insta_Auth_Endpoint);
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
