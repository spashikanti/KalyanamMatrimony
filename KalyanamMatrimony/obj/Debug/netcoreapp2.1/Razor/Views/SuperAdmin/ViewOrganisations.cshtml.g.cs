#pragma checksum "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\SuperAdmin\ViewOrganisations.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a7ae2439e279b537330e193b8ab2150ddeac3839"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SuperAdmin_ViewOrganisations), @"mvc.1.0.view", @"/Views/SuperAdmin/ViewOrganisations.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/SuperAdmin/ViewOrganisations.cshtml", typeof(AspNetCore.Views_SuperAdmin_ViewOrganisations))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7ae2439e279b537330e193b8ab2150ddeac3839", @"/Views/SuperAdmin/ViewOrganisations.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a03ba10572e288882e7287d98a23b4efe49e708", @"/Views/_ViewImports.cshtml")]
    public class Views_SuperAdmin_ViewOrganisations : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OrgLicenseViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/datatables/dataTables.bootstrap4.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "~/Views/Partials/_ViewOrganisations.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/datatables/jquery.dataTables.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/datatables/dataTables.bootstrap4.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/CustomScript.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(28, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\SuperAdmin\ViewOrganisations.cshtml"
  
    ViewData["Title"] = "View Organisations";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
            BeginContext(136, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(138, 78, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8cb47fa3605646a589ed3582ea7419ae", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(216, 695, true);
            WriteLiteral(@"

<ul class=""nav nav-pills mb-3"" id=""pills-tab"" role=""tablist"">
    <li class=""nav-item"">
        <a class=""nav-link active"" id=""pills-Active-tab"" data-toggle=""pill"" href=""#pills-Active"" role=""tab"" aria-controls=""pills-Active"" aria-selected=""true"">Active Organisations</a>
    </li>
    <li class=""nav-item"">
        <a class=""nav-link"" id=""pills-DeActivated-tab"" data-toggle=""pill"" href=""#pills-DeActivated"" role=""tab"" aria-controls=""pills-DeActivated"" aria-selected=""false"">InActivated Organisations</a>
    </li>
</ul>
<div class=""tab-content"" id=""pills-tabContent"">
    <div class=""tab-pane fade show active"" id=""pills-Active"" role=""tabpanel"" aria-labelledby=""pills-Active-tab"">
");
            EndContext();
#line 20 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\SuperAdmin\ViewOrganisations.cshtml"
          
            ViewData["DataTable"] = "DataTableActive";
        

#line default
#line hidden
            BeginContext(990, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(998, 115, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b85f53ad8df049a2a750d525f9e69546", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 23 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\SuperAdmin\ViewOrganisations.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model.ActiveOrganisation;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 23 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\SuperAdmin\ViewOrganisations.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.ViewData = ViewData;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("view-data", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.ViewData, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1113, 126, true);
            WriteLiteral("\r\n    </div>\r\n    <div class=\"tab-pane fade\" id=\"pills-DeActivated\" role=\"tabpanel\" aria-labelledby=\"pills-DeActivated-tab\">\r\n");
            EndContext();
#line 26 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\SuperAdmin\ViewOrganisations.cshtml"
          
            ViewData["DataTable"] = "DataTableDeActived";
        

#line default
#line hidden
            BeginContext(1321, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(1329, 117, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "87600af8f2204a9993e611f6ce6fd968", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 29 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\SuperAdmin\ViewOrganisations.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model.InActiveOrganisation;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 29 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\SuperAdmin\ViewOrganisations.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.ViewData = ViewData;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("view-data", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.ViewData, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1446, 24, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1488, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1494, 64, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "418d898f364a44adb2e6f28451616ef1", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1558, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1564, 68, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "866aa00a188b4c51aa0aa3ad41edcebb", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1632, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1638, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7878e41c24ab4f2ba76b67af9b1090f9", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1682, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(1703, 638, true);
                WriteLiteral(@"    <link href=""/lib/toastr/toastr.min.css"" rel=""stylesheet"" />
    <script src=""/lib/toastr/toastr.min.js""></script>

    <script>
        $(document).ready(function () {
            $('.table').DataTable({
                //""lengthMenu"": [[5, 10, 25, 50, -1], [5, 10, 25, 50, ""All""]]
            });

            var qs = location.pathname.substring(location.pathname.lastIndexOf(""/"") + 1);
            if (qs != ""index"") {
                if (qs == ""2"") {
                    $('.nav-pills a[href=""#pills-DeActivated""]').tab('show');
                }
            }
        });

        //For toast
        var msg = ");
                EndContext();
                BeginContext(2342, 41, false);
#line 56 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\SuperAdmin\ViewOrganisations.cshtml"
             Write(Html.Raw(Json.Serialize(ViewBag.Message)));

#line default
#line hidden
                EndContext();
                BeginContext(2383, 91, true);
                WriteLiteral(";\r\n        if (msg != null) {\r\n            displayToast(msg);\r\n        }\r\n\r\n    </script>\r\n");
                EndContext();
            }
            );
            BeginContext(2477, 2, true);
            WriteLiteral("\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OrgLicenseViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
