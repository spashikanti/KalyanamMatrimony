#pragma checksum "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a022916b5afa74e833c33fbcab7b9629340e8f7a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a022916b5afa74e833c33fbcab7b9629340e8f7a", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a03ba10572e288882e7287d98a23b4efe49e708", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Profile>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-lg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "profile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(32, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(114, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Home\Index.cshtml"
  
    ViewBag.Title = "Home";
    Layout = "~/Views/Shared/_LayoutProfile.cshtml";

#line default
#line hidden
            BeginContext(1122, 65, true);
            WriteLiteral("\r\n<div class=\"jumbotron\">\r\n    <h1 class=\"display-4\">Hello, </h1>");
            EndContext();
            BeginContext(1188, 18, false);
#line 35 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Home\Index.cshtml"
                                 Write(User.Identity.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1206, 125, true);
            WriteLiteral("!\r\n    <p class=\"lead\">Welcome back home. Click the below button to search profiles</p>\r\n    <hr class=\"my-4\">\r\n        <div>");
            EndContext();
            BeginContext(1331, 113, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "168e12b6192541e2a497dd28daafc77d", async() => {
                BeginContext(1425, 15, true);
                WriteLiteral("Search Profiles");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1444, 16, true);
            WriteLiteral("</div>\r\n</div>\r\n");
            EndContext();
#line 40 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Home\Index.cshtml"
 if (Model.Any())
{

#line default
#line hidden
            BeginContext(1482, 305, true);
            WriteLiteral(@"    <div class=""container text-center my-3"">
        <h2 class=""font-weight-light"">Latest Profiles</h2>
        <div class=""row mx-auto my-auto"">
            <div id=""recipeCarousel"" class=""carousel slide w-100"" data-ride=""carousel"">
                <div class=""carousel-inner w-100"" role=""listbox"">
");
            EndContext();
#line 47 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Home\Index.cshtml"
                      
                        var loopCount = 0;
                    

#line default
#line hidden
            BeginContext(1878, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 50 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Home\Index.cshtml"
                     foreach (var profile in Model)
                    {
                        var photoPath1 = "/images/" + (profile.Photo1 ?? "noimageThumb400.jpg");
                        var className = "carousel-item";
                        if (loopCount == 0)
                        {
                            className = "carousel-item active";

                        }

#line default
#line hidden
            BeginContext(2276, 28, true);
            WriteLiteral("                        <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 2304, "\"", 2322, 1);
#line 59 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Home\Index.cshtml"
WriteAttributeValue("", 2312, className, 2312, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2323, 164, true);
            WriteLiteral(">\r\n                            <div class=\"col-md-4\">\r\n                                <div class=\"card card-body text-white\">\r\n                                    ");
            EndContext();
            BeginContext(2487, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ba47d3b8a97a487ab6395e223a2bad18", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            BeginWriteTagHelperAttribute();
#line 62 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Home\Index.cshtml"
                                                    WriteLiteral(photoPath1);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 62 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2554, 186, true);
            WriteLiteral("\r\n                                    <div class=\"card-img-overlay\" style=\"-webkit-text-stroke: 0.5px Red; opacity:1.0\">\r\n                                        <h4 class=\"card-title\" >");
            EndContext();
            BeginContext(2741, 17, false);
#line 64 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Home\Index.cshtml"
                                                           Write(profile.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(2758, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(2760, 16, false);
#line 64 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Home\Index.cshtml"
                                                                              Write(profile.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(2776, 74, true);
            WriteLiteral("</h4>\r\n                                        <p class=\"card-text\" >Age: ");
            EndContext();
            BeginContext(2851, 11, false);
#line 65 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Home\Index.cshtml"
                                                              Write(profile.Age);

#line default
#line hidden
            EndContext();
            BeginContext(2862, 15, true);
            WriteLiteral(" | Profession: ");
            EndContext();
            BeginContext(2878, 18, false);
#line 65 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Home\Index.cshtml"
                                                                                         Write(profile.Profession);

#line default
#line hidden
            EndContext();
            BeginContext(2896, 158, true);
            WriteLiteral("</p>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
            EndContext();
#line 70 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Home\Index.cshtml"
                        loopCount++;
                    }

#line default
#line hidden
            BeginContext(3115, 720, true);
            WriteLiteral(@"
                </div>
                <a class=""carousel-control-prev w-auto"" href=""#recipeCarousel"" role=""button"" data-slide=""prev"">
                    <span class=""carousel-control-prev-icon bg-dark border border-dark rounded-circle"" aria-hidden=""true""></span>
                    <span class=""sr-only"">Previous</span>
                </a>
                <a class=""carousel-control-next w-auto"" href=""#recipeCarousel"" role=""button"" data-slide=""next"">
                    <span class=""carousel-control-next-icon bg-dark border border-dark rounded-circle"" aria-hidden=""true""></span>
                    <span class=""sr-only"">Next</span>
                </a>
            </div>
        </div>
    </div>
");
            EndContext();
#line 85 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Home\Index.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(3847, 35, true);
            WriteLiteral("    <div>No Latest Profiles</div>\r\n");
            EndContext();
#line 89 "F:\Sunil\Development\AspNetCore\Branch\KalyanamMatrimony\KalyanamMatrimony\Views\Home\Index.cshtml"
}

#line default
#line hidden
            BeginContext(3885, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(3908, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(3918, 47, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9e8cd939771d4a33b5ce0ed8cd94cdf0", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3965, 813, true);
                WriteLiteral(@"
        <script>
            $('#recipeCarousel').carousel({
                interval: 10000
            })

            $('.carousel .carousel-item').each(function () {
                var minPerSlide = 3;
                var next = $(this).next();
                if (!next.length) {
                    next = $(this).siblings(':first');
                }
                next.children(':first-child').clone().appendTo($(this));

                for (var i = 0; i < minPerSlide; i++) {
                    next = next.next();
                    if (!next.length) {
                        next = $(this).siblings(':first');
                    }

                    next.children(':first-child').clone().appendTo($(this));
                }
            });

        </script>

    ");
                EndContext();
            }
            );
            BeginContext(4781, 167, true);
            WriteLiteral("\r\n    <style>\r\n        .card-img-overlay {\r\n            top: 65% !important;\r\n        }\r\n        .btn{\r\n            width: 200px !important;\r\n        }\r\n    </style>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ApplicationUser> userManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Profile>> Html { get; private set; }
    }
}
#pragma warning restore 1591
