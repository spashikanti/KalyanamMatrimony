#pragma checksum "C:\Development\AspNetWebCore\KalyanamMatrimony\Views\Shared\_LayoutProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5fb1c4550758c5173cab432797a9f896b61723cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__LayoutProfile), @"mvc.1.0.view", @"/Views/Shared/_LayoutProfile.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_LayoutProfile.cshtml", typeof(AspNetCore.Views_Shared__LayoutProfile))]
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
#line 1 "C:\Development\AspNetWebCore\KalyanamMatrimony\Views\_ViewImports.cshtml"
using KalyanamMatrimony.ViewModels;

#line default
#line hidden
#line 2 "C:\Development\AspNetWebCore\KalyanamMatrimony\Views\_ViewImports.cshtml"
using KalyanamMatrimony.Models;

#line default
#line hidden
#line 3 "C:\Development\AspNetWebCore\KalyanamMatrimony\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5fb1c4550758c5173cab432797a9f896b61723cb", @"/Views/Shared/_LayoutProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a03ba10572e288882e7287d98a23b4efe49e708", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__LayoutProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dropdown-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline my-2 my-lg-0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(101, 10, true);
            WriteLiteral("\r\n<html>\r\n");
            EndContext();
            BeginContext(111, 989, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b1e0ba6190ca47dfb7cbd2d710dfb71b", async() => {
                BeginContext(117, 72, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>");
                EndContext();
                BeginContext(190, 13, false);
#line 7 "C:\Development\AspNetWebCore\KalyanamMatrimony\Views\Shared\_LayoutProfile.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
                EndContext();
                BeginContext(203, 890, true);
                WriteLiteral(@"</title>
    <!-- CSS only -->
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css"" integrity=""sha384-9aIt2nRpC12Uk9gS9baDl411NQApFmC26EwAOH8WgZl5MYYxFfc+NcPb1dKGj7Sk"" crossorigin=""anonymous"">
    <!-- JS, Popper.js, and jQuery -->
    <script src=""https://code.jquery.com/jquery-3.5.1.slim.min.js"" integrity=""sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj"" crossorigin=""anonymous""></script>
    <script src=""https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js"" integrity=""sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo"" crossorigin=""anonymous""></script>
    <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/js/bootstrap.min.js"" integrity=""sha384-OgVRvuATP1z7JjHLkuOU7Xw704+h835Lr+6QL9UvYjZE3Ipu6Tp75j7Bh/kR0JKI"" crossorigin=""anonymous""></script>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1100, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1102, 7595, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5715872f20e14963a3d9a9395e4fb518", async() => {
                BeginContext(1108, 31, true);
                WriteLiteral("\r\n    <div class=\"container\">\r\n");
                EndContext();
                BeginContext(1163, 1581, true);
                WriteLiteral(@"        <nav class=""navbar navbar-expand-lg navbar-dark bg-primary"">
            <a class=""navbar-brand"" href=""#"">Kalyanam Matrimony</a>
            <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarSupportedContent"" aria-controls=""navbarSupportedContent"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                <span class=""navbar-toggler-icon""></span>
            </button>
            <div class=""collapse navbar-collapse"" id=""navbarSupportedContent"">
                <ul class=""navbar-nav mr-auto"">
                    <li class=""nav-item active"">
                        <a class=""nav-link"" href=""#"">Home </a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""#"">Link</a>
                    </li>
                    <li class=""nav-item dropdown"">
                        <a class=""nav-link dropdown-toggle"" href=""#"" id=""navbarDropdown"" role=""button"" data-toggle=""dropdown"" aria-haspo");
                WriteLiteral(@"pup=""true"" aria-expanded=""false"">
                            Dropdown
                        </a>
                        <div class=""dropdown-menu"" aria-labelledby=""navbarDropdown"">
                            <a class=""dropdown-item"" href=""#"">Action</a>
                            <a class=""dropdown-item"" href=""#"">Another action</a>
                            <div class=""dropdown-divider""></div>
                            <a class=""dropdown-item"" href=""#"">Something else here</a>
                        </div>
                    </li>
");
                EndContext();
                BeginContext(2937, 23, true);
                WriteLiteral("                </ul>\r\n");
                EndContext();
                BeginContext(3275, 60, true);
                WriteLiteral("            <ul class=\"navbar-nav ml-auto nav-flex-icons\">\r\n");
                EndContext();
#line 51 "C:\Development\AspNetWebCore\KalyanamMatrimony\Views\Shared\_LayoutProfile.cshtml"
                 if (signInManager.IsSignedIn(User))
                {

#line default
#line hidden
                BeginContext(3408, 129, true);
                WriteLiteral("                    <li class=\"nav-item\">\r\n                        <a class=\"navbar-brand\">\r\n                            Welcome ");
                EndContext();
                BeginContext(3538, 18, false);
#line 55 "C:\Development\AspNetWebCore\KalyanamMatrimony\Views\Shared\_LayoutProfile.cshtml"
                               Write(User.Identity.Name);

#line default
#line hidden
                EndContext();
                BeginContext(3556, 662, true);
                WriteLiteral(@"
                        </a>
                    </li>
                    <li class=""nav-item dropdown"">
                        <a class=""nav-link dropdown-toggle"" id=""navbarDropdownMenuLink-333"" data-toggle=""dropdown""
                           aria-haspopup=""true"" aria-expanded=""false"">
                            <i class=""bi bi-alarm-fill""></i>
                        </a>
                        <div class=""dropdown-menu dropdown-menu-right dropdown-default""
                             aria-labelledby=""navbarDropdownMenuLink-333"">
                            <a class=""dropdown-item"" href=""#"">My Profile</a>
                            ");
                EndContext();
                BeginContext(4218, 144, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "98d137a37fbe425382b77a75cfa93c36", async() => {
                    BeginContext(4285, 73, true);
                    WriteLiteral("\r\n                                Dashboard\r\n                            ");
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
                BeginContext(4362, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(4392, 342, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b86e62be08174ef197b62ef0a790a41d", async() => {
                    BeginContext(4490, 237, true);
                    WriteLiteral("\r\n                                <button type=\"submit\" style=\"width:auto\" class=\"btn btn-outline-success my-2 my-sm-0\">\r\n                                    Logout\r\n                                </button>\r\n                            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4734, 61, true);
                WriteLiteral("\r\n                        </div>\r\n                    </li>\r\n");
                EndContext();
#line 76 "C:\Development\AspNetWebCore\KalyanamMatrimony\Views\Shared\_LayoutProfile.cshtml"
                    }
                    else
                    {

#line default
#line hidden
                BeginContext(4867, 75, true);
                WriteLiteral("                        <li class=\"nav-item\">\r\n                            ");
                EndContext();
                BeginContext(4942, 137, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69a92f03c1eb49a6bb2dfc880f8da7ae", async() => {
                    BeginContext(5006, 69, true);
                    WriteLiteral("\r\n                                Login\r\n                            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5079, 33, true);
                WriteLiteral("\r\n                        </li>\r\n");
                EndContext();
#line 84 "C:\Development\AspNetWebCore\KalyanamMatrimony\Views\Shared\_LayoutProfile.cshtml"
                    }

#line default
#line hidden
                BeginContext(5135, 59, true);
                WriteLiteral("                </ul>\r\n            </div>\r\n        </nav>\r\n");
                EndContext();
                BeginContext(5218, 14, true);
                WriteLiteral("\r\n\r\n\r\n        ");
                EndContext();
                BeginContext(5233, 12, false);
#line 92 "C:\Development\AspNetWebCore\KalyanamMatrimony\Views\Shared\_LayoutProfile.cshtml"
   Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(5245, 3355, true);
                WriteLiteral(@"
    </div>

    <!-- footer -->
    <footer>
        <div class=""footer"">
            <div class=""container"">
                <div class=""footer-info w3-agileits-info"">
                    <div class=""col-md-4 address-left agileinfo"">
                        <div class=""footer-logo header-logo"">
                            <h6>Get in Touch.</h6>
                        </div>
                        <ul>
                            <li><i class=""fa fa-map-marker""></i> 123 San Sebastian, New York City USA.</li>
                            <li><i class=""fa fa-mobile""></i> 333 222 3333 </li>
                            <li><i class=""fa fa-phone""></i> +222 11 4444 </li>
                            <li>
                                <i class=""fa fa-envelope-o""></i> <a href=""mailto:example@mail.com""> mail@example.com</a>
                            </li>
                        </ul>
                    </div>
                    <div class=""col-md-8 address-right"">
                        ");
                WriteLiteral(@"<div class=""col-md-4 footer-grids"">
                            <h3>Company</h3>
                            <ul>
                                <li><a href=""about.html"">About Us</a></li>
                                <li><a href=""feedback.html"">Feedback</a></li>
                                <li><a href=""help.html"">Help</a></li>
                                <li><a href=""tips.html"">Safety Tips</a></li>
                                <li><a href=""typo.html"">Typography</a></li>
                                <li><a href=""icons.html"">Icons Page</a></li>
                            </ul>
                        </div>
                        <div class=""col-md-4 footer-grids"">
                            <h3>Quick links</h3>
                            <ul>
                                <li><a href=""terms.html"">Terms of use</a></li>
                                <li><a href=""privacy_policy.html"">Privacy Policy</a></li>
                                <li><a href=""contact.html"">Contac");
                WriteLiteral(@"t Us</a></li>
                                <li><a href=""faq.html"">FAQ</a></li>
                                <li><a href=""sitemap.html"">Sitemap</a></li>
                            </ul>
                        </div>
                        <div class=""col-md-4 footer-grids"">
                            <h3>Follow Us on</h3>
                            <section class=""social"">
                                <ul>
                                    <li><a class=""icon fb"" href=""#""><i class=""fa fa-facebook""></i></a></li>
                                    <li><a class=""icon tw"" href=""#""><i class=""fa fa-twitter""></i></a></li>
                                    <li><a class=""icon gp"" href=""#""><i class=""fa fa-google-plus""></i></a></li>
                                </ul>
                            </section>
                        </div>
                        <div class=""clearfix""></div>
                    </div>
                    <div class=""clearfix""></div>
                </di");
                WriteLiteral(@"v>
            </div>
        </div>
        <div class=""copy-right"">
            <div class=""container"">
                <p>© 2017 Match. All rights reserved | Design by <a href=""http://w3layouts.com""> W3layouts.</a></p>
            </div>
        </div>
    </footer>


");
                EndContext();
#line 159 "C:\Development\AspNetWebCore\KalyanamMatrimony\Views\Shared\_LayoutProfile.cshtml"
 if (IsSectionDefined("Scripts"))
{
    

#line default
#line hidden
                BeginContext(8643, 40, false);
#line 161 "C:\Development\AspNetWebCore\KalyanamMatrimony\Views\Shared\_LayoutProfile.cshtml"
Write(RenderSection("Scripts", required: true));

#line default
#line hidden
                EndContext();
#line 161 "C:\Development\AspNetWebCore\KalyanamMatrimony\Views\Shared\_LayoutProfile.cshtml"
                                             
}

#line default
#line hidden
                BeginContext(8688, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(8697, 11, true);
            WriteLiteral("\r\n</html>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public RoleManager<IdentityRole> roleManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ApplicationUser> signInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
