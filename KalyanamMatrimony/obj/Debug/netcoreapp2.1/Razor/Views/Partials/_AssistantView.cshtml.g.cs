#pragma checksum "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Partials\_AssistantView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f842351f6f40fda23108ddec7b4ae37cbd140ba5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Partials__AssistantView), @"mvc.1.0.view", @"/Views/Partials/_AssistantView.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Partials/_AssistantView.cshtml", typeof(AspNetCore.Views_Partials__AssistantView))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f842351f6f40fda23108ddec7b4ae37cbd140ba5", @"/Views/Partials/_AssistantView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a03ba10572e288882e7287d98a23b4efe49e708", @"/Views/_ViewImports.cshtml")]
    public class Views_Partials__AssistantView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<KalyanamMatrimony.ViewModels.AssistantViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateAssistant", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(69, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Partials\_AssistantView.cshtml"
  
    ViewData["Title"] = "View Admin Assitants";
    string dataTableName = (string)ViewData["DataTable"];

#line default
#line hidden
            BeginContext(186, 222, true);
            WriteLiteral("\r\n<div class=\"card shadow mb-4 border-primary\">\r\n    <div class=\"card-header bg-primary text-white\">\r\n        <div class=\"row\">\r\n            <div class=\"col-md-10\">\r\n                <h5 class=\"font-weight-bold text-white\">");
            EndContext();
            BeginContext(409, 17, false);
#line 12 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Partials\_AssistantView.cshtml"
                                                   Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(426, 79, true);
            WriteLiteral("</h5>\r\n            </div>\r\n            <div class=\"col-md-2\">\r\n                ");
            EndContext();
            BeginContext(505, 158, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "06f92e1c13bc43c799abf1d779c904e1", async() => {
                BeginContext(586, 73, true);
                WriteLiteral("\r\n                    <strong>Create Assistant</strong>\r\n                ");
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
            BeginContext(663, 178, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"card-body\">\r\n        <div class=\"table-responsive\">\r\n            <table class=\"table table-bordered border-dark\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 841, "\"", 860, 1);
#line 23 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Partials\_AssistantView.cshtml"
WriteAttributeValue("", 846, dataTableName, 846, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(861, 111, true);
            WriteLiteral(" width=\"100%\" cellspacing=\"0\">\r\n                <thead>\r\n                    <tr>\r\n                        <th>");
            EndContext();
            BeginContext(973, 41, false);
#line 26 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Partials\_AssistantView.cshtml"
                       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1014, 35, true);
            WriteLiteral("</th>\r\n                        <th>");
            EndContext();
            BeginContext(1050, 47, false);
#line 27 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Partials\_AssistantView.cshtml"
                       Write(Html.DisplayNameFor(model => model.CreatedDate));

#line default
#line hidden
            EndContext();
            BeginContext(1097, 35, true);
            WriteLiteral("</th>\r\n                        <th>");
            EndContext();
            BeginContext(1133, 43, false);
#line 28 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Partials\_AssistantView.cshtml"
                       Write(Html.DisplayNameFor(model => model.EndDate));

#line default
#line hidden
            EndContext();
            BeginContext(1176, 174, true);
            WriteLiteral("</th>\r\n                        <th></th>\r\n                    </tr>\r\n                </thead>\r\n                <tfoot>\r\n                    <tr>\r\n                        <th>");
            EndContext();
            BeginContext(1351, 41, false);
#line 34 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Partials\_AssistantView.cshtml"
                       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1392, 35, true);
            WriteLiteral("</th>\r\n                        <th>");
            EndContext();
            BeginContext(1428, 47, false);
#line 35 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Partials\_AssistantView.cshtml"
                       Write(Html.DisplayNameFor(model => model.CreatedDate));

#line default
#line hidden
            EndContext();
            BeginContext(1475, 35, true);
            WriteLiteral("</th>\r\n                        <th>");
            EndContext();
            BeginContext(1511, 43, false);
#line 36 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Partials\_AssistantView.cshtml"
                       Write(Html.DisplayNameFor(model => model.EndDate));

#line default
#line hidden
            EndContext();
            BeginContext(1554, 120, true);
            WriteLiteral("</th>\r\n                        <th></th>\r\n                    </tr>\r\n                </tfoot>\r\n                <tbody>\r\n");
            EndContext();
#line 41 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Partials\_AssistantView.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
            BeginContext(1747, 84, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1832, 40, false);
#line 45 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Partials\_AssistantView.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1872, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1964, 46, false);
#line 48 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Partials\_AssistantView.cshtml"
                       Write(Html.DisplayFor(modelItem => item.CreatedDate));

#line default
#line hidden
            EndContext();
            BeginContext(2010, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2102, 42, false);
#line 51 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Partials\_AssistantView.cshtml"
                       Write(Html.DisplayFor(modelItem => item.EndDate));

#line default
#line hidden
            EndContext();
            BeginContext(2144, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2236, 83, false);
#line 54 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Partials\_AssistantView.cshtml"
                       Write(Html.ActionLink("View", "CreateAssistant", new { id = item.UserId, mode = "view" }));

#line default
#line hidden
            EndContext();
            BeginContext(2319, 32, true);
            WriteLiteral(" |\r\n                            ");
            EndContext();
            BeginContext(2352, 68, false);
#line 55 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Partials\_AssistantView.cshtml"
                       Write(Html.ActionLink("Edit", "CreateAssistant", new { id = item.UserId }));

#line default
#line hidden
            EndContext();
            BeginContext(2420, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 58 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Partials\_AssistantView.cshtml"
                    }

#line default
#line hidden
            BeginContext(2503, 82, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<KalyanamMatrimony.ViewModels.AssistantViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
