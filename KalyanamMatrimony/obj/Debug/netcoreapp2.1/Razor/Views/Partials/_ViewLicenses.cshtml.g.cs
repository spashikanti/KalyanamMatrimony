#pragma checksum "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Partials\_ViewLicenses.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1394ebbe68c9fce9a4972bc79baa125732d5a5ac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Partials__ViewLicenses), @"mvc.1.0.view", @"/Views/Partials/_ViewLicenses.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Partials/_ViewLicenses.cshtml", typeof(AspNetCore.Views_Partials__ViewLicenses))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1394ebbe68c9fce9a4972bc79baa125732d5a5ac", @"/Views/Partials/_ViewLicenses.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a03ba10572e288882e7287d98a23b4efe49e708", @"/Views/_ViewImports.cshtml")]
    public class Views_Partials__ViewLicenses : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<KalyanamMatrimony.Models.License>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "superadmin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "createlicense", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(54, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Partials\_ViewLicenses.cshtml"
  
    string dataTableName = (string)ViewData["DataTable"];

#line default
#line hidden
            BeginContext(122, 314, true);
            WriteLiteral(@"
<div class=""card shadow mb-4 border-primary"">
    <div class=""card-header bg-primary text-white"">
        <div class=""row"">
            <div class=""col-md-10"">
                <h5 class=""font-weight-bold text-white"">View Licenses</h5>
            </div>
            <div class=""col-md-2"">
                ");
            EndContext();
            BeginContext(436, 157, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a456c1e9686f4080886460f77d18b178", async() => {
                BeginContext(518, 71, true);
                WriteLiteral("\r\n                    <strong>Create License</strong>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(593, 178, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"card-body\">\r\n        <div class=\"table-responsive\">\r\n            <table class=\"table table-bordered border-dark\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 771, "\"", 790, 1);
#line 22 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Partials\_ViewLicenses.cshtml"
WriteAttributeValue("", 776, dataTableName, 776, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(791, 111, true);
            WriteLiteral(" width=\"100%\" cellspacing=\"0\">\r\n                <thead>\r\n                    <tr>\r\n                        <th>");
            EndContext();
            BeginContext(903, 45, false);
#line 25 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Partials\_ViewLicenses.cshtml"
                       Write(Html.DisplayNameFor(model => model.LicenseId));

#line default
#line hidden
            EndContext();
            BeginContext(948, 82, true);
            WriteLiteral("</th>\r\n                        <th>License Name</th>\r\n                        <th>");
            EndContext();
            BeginContext(1031, 47, false);
#line 27 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Partials\_ViewLicenses.cshtml"
                       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1078, 35, true);
            WriteLiteral("</th>\r\n                        <th>");
            EndContext();
            BeginContext(1114, 46, false);
#line 28 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Partials\_ViewLicenses.cshtml"
                       Write(Html.DisplayNameFor(model => model.UsersCount));

#line default
#line hidden
            EndContext();
            BeginContext(1160, 35, true);
            WriteLiteral("</th>\r\n                        <th>");
            EndContext();
            BeginContext(1196, 47, false);
#line 29 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Partials\_ViewLicenses.cshtml"
                       Write(Html.DisplayNameFor(model => model.MonthsCount));

#line default
#line hidden
            EndContext();
            BeginContext(1243, 35, true);
            WriteLiteral("</th>\r\n                        <th>");
            EndContext();
            BeginContext(1279, 47, false);
#line 30 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Partials\_ViewLicenses.cshtml"
                       Write(Html.DisplayNameFor(model => model.LicenseType));

#line default
#line hidden
            EndContext();
            BeginContext(1326, 35, true);
            WriteLiteral("</th>\r\n                        <th>");
            EndContext();
            BeginContext(1362, 41, false);
#line 31 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Partials\_ViewLicenses.cshtml"
                       Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1403, 174, true);
            WriteLiteral("</th>\r\n                        <th></th>\r\n                    </tr>\r\n                </thead>\r\n                <tfoot>\r\n                    <tr>\r\n                        <th>");
            EndContext();
            BeginContext(1578, 45, false);
#line 37 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Partials\_ViewLicenses.cshtml"
                       Write(Html.DisplayNameFor(model => model.LicenseId));

#line default
#line hidden
            EndContext();
            BeginContext(1623, 82, true);
            WriteLiteral("</th>\r\n                        <th>License Name</th>\r\n                        <th>");
            EndContext();
            BeginContext(1706, 47, false);
#line 39 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Partials\_ViewLicenses.cshtml"
                       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1753, 35, true);
            WriteLiteral("</th>\r\n                        <th>");
            EndContext();
            BeginContext(1789, 46, false);
#line 40 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Partials\_ViewLicenses.cshtml"
                       Write(Html.DisplayNameFor(model => model.UsersCount));

#line default
#line hidden
            EndContext();
            BeginContext(1835, 35, true);
            WriteLiteral("</th>\r\n                        <th>");
            EndContext();
            BeginContext(1871, 47, false);
#line 41 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Partials\_ViewLicenses.cshtml"
                       Write(Html.DisplayNameFor(model => model.MonthsCount));

#line default
#line hidden
            EndContext();
            BeginContext(1918, 35, true);
            WriteLiteral("</th>\r\n                        <th>");
            EndContext();
            BeginContext(1954, 47, false);
#line 42 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Partials\_ViewLicenses.cshtml"
                       Write(Html.DisplayNameFor(model => model.LicenseType));

#line default
#line hidden
            EndContext();
            BeginContext(2001, 35, true);
            WriteLiteral("</th>\r\n                        <th>");
            EndContext();
            BeginContext(2037, 41, false);
#line 43 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Partials\_ViewLicenses.cshtml"
                       Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(2078, 120, true);
            WriteLiteral("</th>\r\n                        <th></th>\r\n                    </tr>\r\n                </tfoot>\r\n                <tbody>\r\n");
            EndContext();
#line 48 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Partials\_ViewLicenses.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
            BeginContext(2271, 84, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2356, 44, false);
#line 52 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Partials\_ViewLicenses.cshtml"
                       Write(Html.DisplayFor(modelItem => item.LicenseId));

#line default
#line hidden
            EndContext();
            BeginContext(2400, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2492, 46, false);
#line 55 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Partials\_ViewLicenses.cshtml"
                       Write(Html.DisplayFor(modelItem => item.LicenseName));

#line default
#line hidden
            EndContext();
            BeginContext(2538, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2630, 46, false);
#line 58 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Partials\_ViewLicenses.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(2676, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2768, 45, false);
#line 61 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Partials\_ViewLicenses.cshtml"
                       Write(Html.DisplayFor(modelItem => item.UsersCount));

#line default
#line hidden
            EndContext();
            BeginContext(2813, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2905, 46, false);
#line 64 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Partials\_ViewLicenses.cshtml"
                       Write(Html.DisplayFor(modelItem => item.MonthsCount));

#line default
#line hidden
            EndContext();
            BeginContext(2951, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(3043, 46, false);
#line 67 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Partials\_ViewLicenses.cshtml"
                       Write(Html.DisplayFor(modelItem => item.LicenseType));

#line default
#line hidden
            EndContext();
            BeginContext(3089, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(3181, 40, false);
#line 70 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Partials\_ViewLicenses.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
            EndContext();
            BeginContext(3221, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(3313, 67, false);
#line 73 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Partials\_ViewLicenses.cshtml"
                       Write(Html.ActionLink("Edit", "EditLicense", new { id = item.LicenseId }));

#line default
#line hidden
            EndContext();
            BeginContext(3380, 32, true);
            WriteLiteral(" |\r\n                            ");
            EndContext();
            BeginContext(3413, 82, false);
#line 74 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Partials\_ViewLicenses.cshtml"
                       Write(Html.ActionLink("View", "EditLicense", new { id = item.LicenseId, mode = "view" }));

#line default
#line hidden
            EndContext();
            BeginContext(3495, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 77 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Partials\_ViewLicenses.cshtml"
                    }

#line default
#line hidden
            BeginContext(3578, 82, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<KalyanamMatrimony.Models.License>> Html { get; private set; }
    }
}
#pragma warning restore 1591
