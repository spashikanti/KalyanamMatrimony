#pragma checksum "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Partials\_LicensesView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28ab259ff3b2c72fefc56f657d51baaafc1ed330"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Partials__LicensesView), @"mvc.1.0.view", @"/Views/Partials/_LicensesView.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Partials/_LicensesView.cshtml", typeof(AspNetCore.Views_Partials__LicensesView))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28ab259ff3b2c72fefc56f657d51baaafc1ed330", @"/Views/Partials/_LicensesView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a03ba10572e288882e7287d98a23b4efe49e708", @"/Views/_ViewImports.cshtml")]
    public class Views_Partials__LicensesView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<KalyanamMatrimony.Models.License>>
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
#line 3 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Partials\_LicensesView.cshtml"
  
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "102bcdd2656c47259222f2688382b554", async() => {
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
#line 22 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Partials\_LicensesView.cshtml"
WriteAttributeValue("", 776, dataTableName, 776, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(791, 195, true);
            WriteLiteral(" width=\"100%\" cellspacing=\"0\">\r\n                <thead>\r\n                    <tr>\r\n                        <th>Id</th>\r\n                        <th>License Name</th>\r\n                        <th>");
            EndContext();
            BeginContext(987, 47, false);
#line 27 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Partials\_LicensesView.cshtml"
                       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1034, 35, true);
            WriteLiteral("</th>\r\n                        <th>");
            EndContext();
            BeginContext(1070, 46, false);
#line 28 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Partials\_LicensesView.cshtml"
                       Write(Html.DisplayNameFor(model => model.UsersCount));

#line default
#line hidden
            EndContext();
            BeginContext(1116, 35, true);
            WriteLiteral("</th>\r\n                        <th>");
            EndContext();
            BeginContext(1152, 50, false);
#line 29 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Partials\_LicensesView.cshtml"
                       Write(Html.DisplayNameFor(model => model.AssistantCount));

#line default
#line hidden
            EndContext();
            BeginContext(1202, 35, true);
            WriteLiteral("</th>\r\n                        <th>");
            EndContext();
            BeginContext(1238, 47, false);
#line 30 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Partials\_LicensesView.cshtml"
                       Write(Html.DisplayNameFor(model => model.MonthsCount));

#line default
#line hidden
            EndContext();
            BeginContext(1285, 35, true);
            WriteLiteral("</th>\r\n                        <th>");
            EndContext();
            BeginContext(1321, 47, false);
#line 31 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Partials\_LicensesView.cshtml"
                       Write(Html.DisplayNameFor(model => model.LicenseType));

#line default
#line hidden
            EndContext();
            BeginContext(1368, 35, true);
            WriteLiteral("</th>\r\n                        <th>");
            EndContext();
            BeginContext(1404, 41, false);
#line 32 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Partials\_LicensesView.cshtml"
                       Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1445, 35, true);
            WriteLiteral("</th>\r\n                        <th>");
            EndContext();
            BeginContext(1481, 43, false);
#line 33 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Partials\_LicensesView.cshtml"
                       Write(Html.DisplayNameFor(model => model.PayLink));

#line default
#line hidden
            EndContext();
            BeginContext(1524, 258, true);
            WriteLiteral(@"</th>
                        <th></th>
                    </tr>
                </thead>
                <tfoot>
                    <tr>
                        <th>Id</th>
                        <th>License Name</th>
                        <th>");
            EndContext();
            BeginContext(1783, 47, false);
#line 41 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Partials\_LicensesView.cshtml"
                       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1830, 35, true);
            WriteLiteral("</th>\r\n                        <th>");
            EndContext();
            BeginContext(1866, 46, false);
#line 42 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Partials\_LicensesView.cshtml"
                       Write(Html.DisplayNameFor(model => model.UsersCount));

#line default
#line hidden
            EndContext();
            BeginContext(1912, 35, true);
            WriteLiteral("</th>\r\n                        <th>");
            EndContext();
            BeginContext(1948, 50, false);
#line 43 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Partials\_LicensesView.cshtml"
                       Write(Html.DisplayNameFor(model => model.AssistantCount));

#line default
#line hidden
            EndContext();
            BeginContext(1998, 35, true);
            WriteLiteral("</th>\r\n                        <th>");
            EndContext();
            BeginContext(2034, 47, false);
#line 44 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Partials\_LicensesView.cshtml"
                       Write(Html.DisplayNameFor(model => model.MonthsCount));

#line default
#line hidden
            EndContext();
            BeginContext(2081, 35, true);
            WriteLiteral("</th>\r\n                        <th>");
            EndContext();
            BeginContext(2117, 47, false);
#line 45 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Partials\_LicensesView.cshtml"
                       Write(Html.DisplayNameFor(model => model.LicenseType));

#line default
#line hidden
            EndContext();
            BeginContext(2164, 35, true);
            WriteLiteral("</th>\r\n                        <th>");
            EndContext();
            BeginContext(2200, 41, false);
#line 46 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Partials\_LicensesView.cshtml"
                       Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(2241, 35, true);
            WriteLiteral("</th>\r\n                        <th>");
            EndContext();
            BeginContext(2277, 43, false);
#line 47 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Partials\_LicensesView.cshtml"
                       Write(Html.DisplayNameFor(model => model.PayLink));

#line default
#line hidden
            EndContext();
            BeginContext(2320, 120, true);
            WriteLiteral("</th>\r\n                        <th></th>\r\n                    </tr>\r\n                </tfoot>\r\n                <tbody>\r\n");
            EndContext();
#line 52 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Partials\_LicensesView.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
            BeginContext(2513, 84, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2598, 44, false);
#line 56 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Partials\_LicensesView.cshtml"
                       Write(Html.DisplayFor(modelItem => item.LicenseId));

#line default
#line hidden
            EndContext();
            BeginContext(2642, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2734, 46, false);
#line 59 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Partials\_LicensesView.cshtml"
                       Write(Html.DisplayFor(modelItem => item.LicenseName));

#line default
#line hidden
            EndContext();
            BeginContext(2780, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2872, 46, false);
#line 62 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Partials\_LicensesView.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(2918, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(3010, 45, false);
#line 65 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Partials\_LicensesView.cshtml"
                       Write(Html.DisplayFor(modelItem => item.UsersCount));

#line default
#line hidden
            EndContext();
            BeginContext(3055, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(3147, 49, false);
#line 68 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Partials\_LicensesView.cshtml"
                       Write(Html.DisplayFor(modelItem => item.AssistantCount));

#line default
#line hidden
            EndContext();
            BeginContext(3196, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(3288, 46, false);
#line 71 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Partials\_LicensesView.cshtml"
                       Write(Html.DisplayFor(modelItem => item.MonthsCount));

#line default
#line hidden
            EndContext();
            BeginContext(3334, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(3426, 46, false);
#line 74 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Partials\_LicensesView.cshtml"
                       Write(Html.DisplayFor(modelItem => item.LicenseType));

#line default
#line hidden
            EndContext();
            BeginContext(3472, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(3564, 40, false);
#line 77 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Partials\_LicensesView.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
            EndContext();
            BeginContext(3604, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(3696, 42, false);
#line 80 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Partials\_LicensesView.cshtml"
                       Write(Html.DisplayFor(modelItem => item.PayLink));

#line default
#line hidden
            EndContext();
            BeginContext(3738, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(3830, 67, false);
#line 83 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Partials\_LicensesView.cshtml"
                       Write(Html.ActionLink("Edit", "EditLicense", new { id = item.LicenseId }));

#line default
#line hidden
            EndContext();
            BeginContext(3897, 32, true);
            WriteLiteral(" |\r\n                            ");
            EndContext();
            BeginContext(3930, 82, false);
#line 84 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Partials\_LicensesView.cshtml"
                       Write(Html.ActionLink("View", "EditLicense", new { id = item.LicenseId, mode = "view" }));

#line default
#line hidden
            EndContext();
            BeginContext(4012, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 87 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Partials\_LicensesView.cshtml"
                    }

#line default
#line hidden
            BeginContext(4095, 82, true);
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
