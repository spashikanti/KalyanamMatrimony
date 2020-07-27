#pragma checksum "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Partials\_ProfilesView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "880a6182e958774d2bac1285242d40ceaf6c062f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Partials__ProfilesView), @"mvc.1.0.view", @"/Views/Partials/_ProfilesView.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Partials/_ProfilesView.cshtml", typeof(AspNetCore.Views_Partials__ProfilesView))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"880a6182e958774d2bac1285242d40ceaf6c062f", @"/Views/Partials/_ProfilesView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a03ba10572e288882e7287d98a23b4efe49e708", @"/Views/_ViewImports.cshtml")]
    public class Views_Partials__ProfilesView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<KalyanamMatrimony.Models.Profile>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "profile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "createprofile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Partials\_ProfilesView.cshtml"
  
    string dataTableName = (string)ViewData["DataTable"];

    bool isProfileLimitReached = ViewBag.isProfileLimitReached;

#line default
#line hidden
            BeginContext(189, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 9 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Partials\_ProfilesView.cshtml"
 if (isProfileLimitReached)
{

#line default
#line hidden
            BeginContext(223, 123, true);
            WriteLiteral("    <div class=\"text-danger\">\r\n        You cannot create a new Profile as you have reached the maximum limit.\r\n    </div>\r\n");
            EndContext();
#line 14 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Partials\_ProfilesView.cshtml"
}

#line default
#line hidden
            BeginContext(349, 296, true);
            WriteLiteral(@"<div class=""card shadow mb-4 border-primary"">
    <div class=""card-header bg-primary text-white"">
        <div class=""row"">
            <div class=""col-md-10"">
                <h5 class=""font-weight-bold text-white"">View Profiles</h5>
            </div>
            <div class=""col-md-2"">
");
            EndContext();
#line 22 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Partials\_ProfilesView.cshtml"
                 if (!isProfileLimitReached)
                {

#line default
#line hidden
            BeginContext(710, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(730, 162, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "04bd3b49373d4991ae6f867d40a38966", async() => {
                BeginContext(809, 79, true);
                WriteLiteral("\r\n                        <strong>Create Profile</strong>\r\n                    ");
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
            BeginContext(892, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 27 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Partials\_ProfilesView.cshtml"
                }

#line default
#line hidden
            BeginContext(913, 176, true);
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"card-body\">\r\n        <div class=\"table-responsive\">\r\n            <table class=\"table table-bordered border-dark\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1089, "\"", 1108, 1);
#line 33 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Partials\_ProfilesView.cshtml"
WriteAttributeValue("", 1094, dataTableName, 1094, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1109, 111, true);
            WriteLiteral(" width=\"100%\" cellspacing=\"0\">\r\n                <thead>\r\n                    <tr>\r\n                        <th>");
            EndContext();
            BeginContext(1221, 45, false);
#line 36 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Partials\_ProfilesView.cshtml"
                       Write(Html.DisplayNameFor(model => model.ProfileId));

#line default
#line hidden
            EndContext();
            BeginContext(1266, 79, true);
            WriteLiteral("</th>\r\n                        <th>Full Name</th>\r\n                        <th>");
            EndContext();
            BeginContext(1346, 42, false);
#line 38 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Partials\_ProfilesView.cshtml"
                       Write(Html.DisplayNameFor(model => model.Gender));

#line default
#line hidden
            EndContext();
            BeginContext(1388, 96, true);
            WriteLiteral("</th>\r\n                        <th>Phone</th>\r\n                        <th style=\"display:none\">");
            EndContext();
            BeginContext(1485, 47, false);
#line 40 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Partials\_ProfilesView.cshtml"
                                            Write(Html.DisplayNameFor(model => model.CreatedDate));

#line default
#line hidden
            EndContext();
            BeginContext(1532, 174, true);
            WriteLiteral("</th>\r\n                        <th></th>\r\n                    </tr>\r\n                </thead>\r\n                <tfoot>\r\n                    <tr>\r\n                        <th>");
            EndContext();
            BeginContext(1707, 45, false);
#line 46 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Partials\_ProfilesView.cshtml"
                       Write(Html.DisplayNameFor(model => model.ProfileId));

#line default
#line hidden
            EndContext();
            BeginContext(1752, 79, true);
            WriteLiteral("</th>\r\n                        <th>Full Name</th>\r\n                        <th>");
            EndContext();
            BeginContext(1832, 42, false);
#line 48 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Partials\_ProfilesView.cshtml"
                       Write(Html.DisplayNameFor(model => model.Gender));

#line default
#line hidden
            EndContext();
            BeginContext(1874, 96, true);
            WriteLiteral("</th>\r\n                        <th>Phone</th>\r\n                        <th style=\"display:none\">");
            EndContext();
            BeginContext(1971, 47, false);
#line 50 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Partials\_ProfilesView.cshtml"
                                            Write(Html.DisplayNameFor(model => model.CreatedDate));

#line default
#line hidden
            EndContext();
            BeginContext(2018, 120, true);
            WriteLiteral("</th>\r\n                        <th></th>\r\n                    </tr>\r\n                </tfoot>\r\n                <tbody>\r\n");
            EndContext();
#line 55 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Partials\_ProfilesView.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
            BeginContext(2211, 96, true);
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2308, 44, false);
#line 59 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Partials\_ProfilesView.cshtml"
                           Write(Html.DisplayFor(modelItem => item.ProfileId));

#line default
#line hidden
            EndContext();
            BeginContext(2352, 37, true);
            WriteLiteral("\r\n                            </td>\r\n");
            EndContext();
            BeginContext(2546, 66, true);
            WriteLiteral("                            <td>\r\n                                ");
            EndContext();
            BeginContext(2613, 44, false);
#line 65 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Partials\_ProfilesView.cshtml"
                           Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(2657, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(2659, 43, false);
#line 65 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Partials\_ProfilesView.cshtml"
                                                                         Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(2702, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2806, 41, false);
#line 68 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Partials\_ProfilesView.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Gender));

#line default
#line hidden
            EndContext();
            BeginContext(2847, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2951, 46, false);
#line 71 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Partials\_ProfilesView.cshtml"
                           Write(Html.DisplayFor(modelItem => item.PhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(2997, 124, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td style=\"display:none\">\r\n                                ");
            EndContext();
            BeginContext(3122, 46, false);
#line 74 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Partials\_ProfilesView.cshtml"
                           Write(Html.DisplayFor(modelItem => item.CreatedDate));

#line default
#line hidden
            EndContext();
            BeginContext(3168, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(3272, 67, false);
#line 77 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Partials\_ProfilesView.cshtml"
                           Write(Html.ActionLink("View", "ViewProfile", new { id = item.ProfileId }));

#line default
#line hidden
            EndContext();
            BeginContext(3339, 36, true);
            WriteLiteral(" |\r\n                                ");
            EndContext();
            BeginContext(3376, 67, false);
#line 78 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Partials\_ProfilesView.cshtml"
                           Write(Html.ActionLink("Edit", "EditProfile", new { id = item.ProfileId }));

#line default
#line hidden
            EndContext();
            BeginContext(3443, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 79 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Partials\_ProfilesView.cshtml"
                                 if (!User.IsInRole(Enum.GetName(typeof(CustomEnums.CustomRole), CustomEnums.CustomRole.AdminAssistant)))
                                {

#line default
#line hidden
            BeginContext(3619, 51, true);
            WriteLiteral("                                    <span>|</span> ");
            EndContext();
            BeginContext(3671, 91, false);
#line 81 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Partials\_ProfilesView.cshtml"
                                              Write(Html.ActionLink("Delete", "ViewProfile", new { id = item.ProfileId, userId = item.UserId }));

#line default
#line hidden
            EndContext();
#line 81 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Partials\_ProfilesView.cshtml"
                                                                                                                                               
                                }

#line default
#line hidden
            BeginContext(3799, 66, true);
            WriteLiteral("                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 85 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Partials\_ProfilesView.cshtml"
                    }

#line default
#line hidden
            BeginContext(3888, 86, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<KalyanamMatrimony.Models.Profile>> Html { get; private set; }
    }
}
#pragma warning restore 1591