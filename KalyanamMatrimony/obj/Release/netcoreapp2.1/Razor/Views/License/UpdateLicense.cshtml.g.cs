#pragma checksum "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\License\UpdateLicense.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d2125a4bf15dc44182c4ae6580bf472178c2001"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_License_UpdateLicense), @"mvc.1.0.view", @"/Views/License/UpdateLicense.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/License/UpdateLicense.cshtml", typeof(AspNetCore.Views_License_UpdateLicense))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\_ViewImports.cshtml"
using KalyanamMatrimony.ViewModels;

#line default
#line hidden
#line 2 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\_ViewImports.cshtml"
using KalyanamMatrimony.Models;

#line default
#line hidden
#line 3 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d2125a4bf15dc44182c4ae6580bf472178c2001", @"/Views/License/UpdateLicense.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a03ba10572e288882e7287d98a23b4efe49e708", @"/Views/_ViewImports.cshtml")]
    public class Views_License_UpdateLicense : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<License>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("selected", new global::Microsoft.AspNetCore.Html.HtmlString("selected"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("UsersCount"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("btnCreateLicense"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateLicense", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "License", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(29, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\License\UpdateLicense.cshtml"
  
    ViewBag.Title = "Update License";
    Layout = "~/Views/Shared/_LayoutLicense.cshtml";

#line default
#line hidden
            BeginContext(131, 40, true);
            WriteLiteral("\r\n    <h3 class=\"text-danger\">\r\n        ");
            EndContext();
            BeginContext(172, 15, false);
#line 9 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\License\UpdateLicense.cshtml"
   Write(ViewBag.Message);

#line default
#line hidden
            EndContext();
            BeginContext(187, 1190, true);
            WriteLiteral(@"
    </h3>
<ul class=""nav nav-pills mb-3"" id=""pills-tab"" role=""tablist"">
    <li class=""nav-item"">
        <a class=""nav-link active"" id=""pills-Active-tab"" data-toggle=""pill"" href=""#pills-Active"" role=""tab"" aria-controls=""pills-Active"" aria-selected=""true"">License</a>
    </li>
    <li class=""nav-item"">
        <a class=""nav-link"" id=""pills-DeActivated-tab"" data-toggle=""pill"" href=""#pills-DeActivated"" role=""tab"" aria-controls=""pills-DeActivated"" aria-selected=""false"">Payment</a>
    </li>
</ul>
<div class=""tab-content"" id=""pills-tabContent"">
    <div class=""tab-pane fade show active"" id=""pills-Active"" role=""tabpanel"" aria-labelledby=""pills-Active-tab"">
        <div class=""card shadow mb-4 border-primary"">
            <div class=""card-header bg-primary text-white"">
                <div class=""row"">
                    <div class=""col-md-12"">
                        <h5 class=""font-weight-bold text-white"">License</h5>
                    </div>
                </div>
            </div>
     ");
            WriteLiteral("       <div class=\"card-body\">\r\n                <div class=\"form-row\">\r\n                    <div class=\"col-md-6\">\r\n                        <div class=\"form-group\">\r\n");
            EndContext();
            BeginContext(1791, 3039, true);
            WriteLiteral(@"                        </div>
                    </div>
                    <div class=""col-md-6"">
                        <div class=""form-group"">
                            <div class=""card"">
                                <div class=""card-header"">
                                    <strong>Order Summary</strong>
                                </div>
                                <div class=""card-body"">
                                    <div class=""form-row"">
                                        <div class=""col-md-7"">
                                            <div class=""form-group"">
                                                <div id=""purpose""></div>
                                            </div>
                                        </div>
                                        <div class=""col-md-3"">
                                            <div class=""form-group"">
                                                <div id=""lblPrice""></div>
                     ");
            WriteLiteral(@"                       </div>
                                        </div>
                                    </div>
                                    <hr />
                                    <div class=""form-row"">
                                        <div class=""col-md-7"">
                                            <div class=""form-group"">
                                                <strong>Total</strong>
                                            </div>
                                        </div>
                                        <div class=""col-md-3"">
                                            <div class=""form-group"">
                                                <div id=""amount""></div>
                                            </div>
                                        </div>
                                    </div>
                                    Subtotal does not include applicable taxes.
                                </div>
                   ");
            WriteLiteral(@"         </div>
                        </div>
                        <div class=""form-group text-lg-right"">
                            <button type=""button"" class=""btn btn-primary"" onclick=""nextTab();"">Next</button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""tab-pane fade"" id=""pills-DeActivated"" role=""tabpanel"" aria-labelledby=""pills-DeActivated-tab"">
        <div class=""card shadow mb-4 border-primary"">
            <div class=""card-header bg-primary text-white"">
                <div class=""row"">
                    <div class=""col-md-12"">
                        <h5 class=""font-weight-bold text-white"">Update License</h5>
                    </div>
                </div>
            </div>
            <div class=""card-body"">
                <div class=""form-row"">
                    <div class=""col-md-6"">
                        <div class=""form-group"">
");
            EndContext();
            BeginContext(5519, 107, true);
            WriteLiteral("                            <label class=\"small mb-1\">Filter Licenses</label>\r\n                            ");
            EndContext();
            BeginContext(5626, 252, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2b903bb46cb4681bb62d6e5ed764c61", async() => {
                BeginContext(5765, 34, true);
                WriteLiteral("\r\n                                ");
                EndContext();
                BeginContext(5799, 40, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69ad9e818c1d4beda8646538fa361c1f", async() => {
                    BeginContext(5827, 3, true);
                    WriteLiteral("All");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5839, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#line 109 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\License\UpdateLicense.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ((List<SelectListItem>)@ViewBag.UsersCount);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5878, 269, true);
            WriteLiteral(@"
                        </div>
                    </div>
                </div>
                <div class=""form-row"" id=""divUserCount10"">
                    <div class=""col-md-12"">
                        <div class=""form-group"">
                            ");
            EndContext();
            BeginContext(6147, 2929, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "794a37ec58d547b88531032aeb5ba75a", async() => {
                BeginContext(6197, 58, true);
                WriteLiteral("\r\n                                <div class=\"form-row\">\r\n");
                EndContext();
#line 120 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\License\UpdateLicense.cshtml"
                                     if (Model != null && Model.Count() > 0)
                                    {
                                        var loopCount = 1;
                                        

#line default
#line hidden
#line 123 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\License\UpdateLicense.cshtml"
                                         foreach (var item in Model)
                                        {
                                            var newDivId = @item.UsersCount + "_" + @loopCount;
                                            

#line default
#line hidden
                BeginContext(6686, 4, true);
                WriteLiteral("<div");
                EndContext();
                BeginWriteAttribute("class", " class=\"", 6690, "\"", 6732, 3);
                WriteAttributeValue("", 6698, "col-md-3", 6698, 8, true);
#line 126 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\License\UpdateLicense.cshtml"
WriteAttributeValue(" ", 6706, item.UsersCount, 6707, 16, false);

#line default
#line hidden
                WriteAttributeValue(" ", 6723, "licenses", 6724, 9, true);
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 6733, "\"", 6747, 1);
#line 126 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\License\UpdateLicense.cshtml"
WriteAttributeValue("", 6738, newDivId, 6738, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(6748, 330, true);
                WriteLiteral(@" style=""display:none"">
                                                <div class=""card shadow mb-4 border-primary mb-3"" style=""max-width: 18rem;"">
                                                    <div class=""card-header bg-primary text-white"">
                                                        <h5 class=""card-title"">");
                EndContext();
                BeginContext(7079, 16, false);
#line 129 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\License\UpdateLicense.cshtml"
                                                                          Write(item.LicenseName);

#line default
#line hidden
                EndContext();
                BeginContext(7095, 221, true);
                WriteLiteral("</h5>\r\n                                                    </div>\r\n                                                    <div class=\"card-body\">\r\n                                                        <p class=\"card-text\">");
                EndContext();
                BeginContext(7317, 16, false);
#line 132 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\License\UpdateLicense.cshtml"
                                                                        Write(item.Description);

#line default
#line hidden
                EndContext();
                BeginContext(7333, 91, true);
                WriteLiteral("</p>\r\n                                                        <p class=\"card-text\">Price: ₹");
                EndContext();
                BeginContext(7425, 10, false);
#line 133 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\License\UpdateLicense.cshtml"
                                                                                Write(item.Price);

#line default
#line hidden
                EndContext();
                BeginContext(7435, 145, true);
                WriteLiteral("</p>\r\n                                                    </div>\r\n                                                    <div class=\"card-footer\">\r\n");
                EndContext();
#line 136 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\License\UpdateLicense.cshtml"
                                                         if (!string.IsNullOrEmpty(item.PayLink))
                                                        {

#line default
#line hidden
                BeginContext(7738, 60, true);
                WriteLiteral("                                                            ");
                EndContext();
                BeginContext(7798, 494, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5fda498194424a6690544dfc74f7c0ee", async() => {
                    BeginContext(8132, 151, true);
                    WriteLiteral("\r\n                                                                <strong>Update</strong>\r\n                                                            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-licenseId", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 140 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\License\UpdateLicense.cshtml"
                                                                     WriteLiteral(item.LicenseId);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["licenseId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-licenseId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["licenseId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#line 140 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\License\UpdateLicense.cshtml"
                                                                                                             WriteLiteral(item.MonthsCount);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["monthsCount"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-monthsCount", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["monthsCount"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(8292, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 145 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\License\UpdateLicense.cshtml"
                                                                           
                                                        }

#line default
#line hidden
                BeginContext(8751, 168, true);
                WriteLiteral("                                                    </div>\r\n                                                </div>\r\n                                            </div>\r\n");
                EndContext();
#line 150 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\License\UpdateLicense.cshtml"
                                        }

#line default
#line hidden
#line 150 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\License\UpdateLicense.cshtml"
                                         
                                    }

#line default
#line hidden
                BeginContext(9001, 68, true);
                WriteLiteral("                                </div>\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(9076, 144, true);
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(9237, 1353, true);
                WriteLiteral(@"
<style>
    .im-checkout {
        max-width: 300px;
        margin-bottom: 0px !important;
    }
</style>
    <script>
        $(document).ready(function () {
            debugger;

            $(""#LicenseId"").on(""change"", function (e) {
                debugger;
                console.log(e);
                var optionSelected = $(""option:selected"", this);
                $(""#lblPrice"").text(""₹"" + this.value);// + this.value selected value
                $(""#amount"").text(""₹"" + this.value);// + this.value selected value
                $(""#purpose"").text(optionSelected[0].text);//selected text
            });

            $(""#LicenseId"").trigger(""change"");

            $(""#UsersCount"").on(""change"", function (e) {
                hideLicenses(this.value);
                var optionSelected = $(""option:selected"", this);
                $("".""+this.value).show();
            });

            $(""#UsersCount"").trigger(""change"");
        });

        function hideLicenses(val) {
");
                WriteLiteral(@"            if (val != ""All"") {
                $("".licenses"").hide();
            }
            else {
                $("".licenses"").show();
            }
        }

        function nextTab() {
            $('.nav-pills a[href=""#pills-DeActivated""]').tab('show');
        }

        //For toast
        var msg = ");
                EndContext();
                BeginContext(10591, 41, false);
#line 207 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\License\UpdateLicense.cshtml"
             Write(Html.Raw(Json.Serialize(ViewBag.Message)));

#line default
#line hidden
                EndContext();
                BeginContext(10632, 91, true);
                WriteLiteral(";\r\n        if (msg != null) {\r\n            displayToast(msg);\r\n        }\r\n\r\n    </script>\r\n");
                EndContext();
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<License>> Html { get; private set; }
    }
}
#pragma warning restore 1591
