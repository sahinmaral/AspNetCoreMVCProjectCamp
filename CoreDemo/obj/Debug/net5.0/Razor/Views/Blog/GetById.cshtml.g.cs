#pragma checksum "C:\Users\sahin\OneDrive\Desktop\​‏       \GithubProjects\AspNetCoreMVCProjectCamp\CoreDemo\Views\Blog\GetById.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9841d6d1e667fd98829ac984f44f048eea3afbf3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_GetById), @"mvc.1.0.view", @"/Views/Blog/GetById.cshtml")]
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
#nullable restore
#line 1 "C:\Users\sahin\OneDrive\Desktop\​‏       \GithubProjects\AspNetCoreMVCProjectCamp\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sahin\OneDrive\Desktop\​‏       \GithubProjects\AspNetCoreMVCProjectCamp\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9841d6d1e667fd98829ac984f44f048eea3afbf3", @"/Views/Blog/GetById.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f21d357d3a7a0ebdb24ebf4009b9f29dec35ea9", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_GetById : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlogViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\sahin\OneDrive\Desktop\​‏       \GithubProjects\AspNetCoreMVCProjectCamp\CoreDemo\Views\Blog\GetById.cshtml"
  
    ViewData["Title"] = @Model.BlogTitle;
    Layout = "_UserLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""row"">
    <!--left-->
    <div class=""col-lg-8 left-blog-info-w3layouts-agileits text-left"">
        <div class=""blog-grid-top"">
            <div class=""b-grid-top"">
                <div class=""blog_info_left_grid"">
                    <a href=""single.html"">
                        <img");
            BeginWriteAttribute("src", " src=\"", 413, "\"", 439, 1);
#nullable restore
#line 16 "C:\Users\sahin\OneDrive\Desktop\​‏       \GithubProjects\AspNetCoreMVCProjectCamp\CoreDemo\Views\Blog\GetById.cshtml"
WriteAttributeValue("", 419, Model.BlogMainImage, 419, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 458, "\"", 464, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </a>
                </div>
                <div class=""blog-info-middle"">
                    <ul>
                        <li>
                            <a href=""#"">
                                <i class=""far fa-calendar-alt""></i> ");
#nullable restore
#line 23 "C:\Users\sahin\OneDrive\Desktop\​‏       \GithubProjects\AspNetCoreMVCProjectCamp\CoreDemo\Views\Blog\GetById.cshtml"
                                                               Write(Model.BlogCreateDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </a>
                        </li>
                        <li class=""mx-2"">
                            <a href=""#"">
                                <i class=""far fa-thumbs-up""></i> 0 Beğenme
                            </a>
                        </li>
                        <li>
                            <a href=""#"">
                                <i class=""far fa-comment""></i> 0 Yorum
                            </a>
                        </li>

                    </ul>
                </div>
            </div>

            <h3>
                ");
#nullable restore
#line 42 "C:\Users\sahin\OneDrive\Desktop\​‏       \GithubProjects\AspNetCoreMVCProjectCamp\CoreDemo\Views\Blog\GetById.cshtml"
           Write(Model.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </h3>\r\n            <p>\r\n                ");
#nullable restore
#line 45 "C:\Users\sahin\OneDrive\Desktop\​‏       \GithubProjects\AspNetCoreMVCProjectCamp\CoreDemo\Views\Blog\GetById.cshtml"
           Write(Model.BlogContent);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </p>\r\n        </div>\r\n\r\n        <div class=\"comment-top\">\r\n\r\n            <h4>Yorumlar</h4>\r\n            <div class=\"media\">\r\n                <div class=\"media-body\">\r\n\r\n                    ");
#nullable restore
#line 55 "C:\Users\sahin\OneDrive\Desktop\​‏       \GithubProjects\AspNetCoreMVCProjectCamp\CoreDemo\Views\Blog\GetById.cshtml"
               Write(await Component.InvokeAsync("CommentListByBlogId",new {id=Model.BlogId}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </div>\r\n            </div>\r\n\r\n");
            WriteLiteral("        </div>\r\n        <div class=\"comment-top\">\r\n            ");
#nullable restore
#line 63 "C:\Users\sahin\OneDrive\Desktop\​‏       \GithubProjects\AspNetCoreMVCProjectCamp\CoreDemo\Views\Blog\GetById.cshtml"
       Write(await Html.PartialAsync("../Blog/AddComment"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>
    </div>

    <!--//left-->
    <!--right-->
    <aside class=""col-lg-4 agileits-w3ls-right-blog-con text-right"">
        <div class=""right-blog-info text-left"">
            <div class=""tech-btm"">
                <img src=""images/banner1.jpg"" class=""img-fluid""");
            BeginWriteAttribute("alt", " alt=\"", 2271, "\"", 2277, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            </div>\r\n            \r\n\r\n");
            WriteLiteral(@"            <div class=""tech-btm"">
                <h4>Haftanın Blogları</h4>

                <div class=""blog-grids row mb-3"">
                    <div class=""col-md-5 blog-grid-left"">
                        <a href=""single.html"">
                            <img src=""images/1.jpg"" class=""img-fluid""");
            BeginWriteAttribute("alt", " alt=\"", 3630, "\"", 3636, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </a>
                    </div>
                    <div class=""col-md-7 blog-grid-right"">

                        <h5>
                            <a href=""single.html"">Pellentesque dui, non felis. Maecenas male non felis </a>
                        </h5>
                        <div class=""sub-meta"">
                            <span>
                                <i class=""far fa-clock""></i> 20 Jan, 2018
                            </span>
                        </div>
                    </div>

                </div>
                <div class=""blog-grids row mb-3"">
                    <div class=""col-md-5 blog-grid-left"">
                        <a href=""single.html"">
                            <img src=""images/6.jpg"" class=""img-fluid""");
            BeginWriteAttribute("alt", " alt=\"", 4439, "\"", 4445, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </a>
                    </div>
                    <div class=""col-md-7 blog-grid-right"">
                        <h5>
                            <a href=""single.html"">Pellentesque dui, non felis. Maecenas male non felis </a>
                        </h5>
                        <div class=""sub-meta"">
                            <span>
                                <i class=""far fa-clock""></i> 20 Feb, 2018
                            </span>
                        </div>
                    </div>

                </div>
            </div>
");
            WriteLiteral(@"            <div class=""single-gd tech-btm"">
                <h4>Bir Önceki Bloglar</h4>
                <div class=""blog-grids"">
                    <div class=""blog-grid-left"">
                        <a href=""single.html"">
                            <img src=""images/b1.jpg"" class=""img-fluid""");
            BeginWriteAttribute("alt", " alt=\"", 6832, "\"", 6838, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </a>
                    </div>
                    <div class=""blog-grid-right"">

                        <h5>
                            <a href=""single.html"">Pellentesque dui, non felis. Maecenas male</a>
                        </h5>
                    </div>
                    <div class=""clearfix""> </div>
                </div>
            </div>
        </div>

    </aside>
    <!--//right-->
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlogViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
