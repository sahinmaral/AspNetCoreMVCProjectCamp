#pragma checksum "C:\Users\sahin\OneDrive\Desktop\​‏       \GithubProjects\AspNetCoreMVCProjectCamp\CoreDemo\Views\Blog\GetById.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "15e5be10c12a6de0942ff454bb0074dbc4984edf"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15e5be10c12a6de0942ff454bb0074dbc4984edf", @"/Views/Blog/GetById.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f21d357d3a7a0ebdb24ebf4009b9f29dec35ea9", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_GetById : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ReadBlogViewModel>
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
                    <a");
            BeginWriteAttribute("href", " href=\"", 367, "\"", 374, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 406, "\"", 432, 1);
#nullable restore
#line 16 "C:\Users\sahin\OneDrive\Desktop\​‏       \GithubProjects\AspNetCoreMVCProjectCamp\CoreDemo\Views\Blog\GetById.cshtml"
WriteAttributeValue("", 412, Model.BlogMainImage, 412, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 451, "\"", 457, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </a>\r\n                </div>\r\n                <div class=\"blog-info-middle\">\r\n                    <ul>\r\n                        <li>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 645, "\"", 652, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <i class=\"far fa-calendar-alt\"></i> ");
#nullable restore
#line 23 "C:\Users\sahin\OneDrive\Desktop\​‏       \GithubProjects\AspNetCoreMVCProjectCamp\CoreDemo\Views\Blog\GetById.cshtml"
                                                               Write(Model.BlogCreateDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </a>\r\n                        </li>\r\n                        <li class=\"mx-2\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 885, "\"", 892, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <i class=\"far fa-thumbs-up\"></i> 0 Beğenme\r\n                            </a>\r\n                        </li>\r\n                        <li>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1097, "\"", 1104, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <i class=\"far fa-comment\"></i> ");
#nullable restore
#line 33 "C:\Users\sahin\OneDrive\Desktop\​‏       \GithubProjects\AspNetCoreMVCProjectCamp\CoreDemo\Views\Blog\GetById.cshtml"
                                                          Write(Model.CommentViewModels.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Yorum\r\n                            </a>\r\n                        </li>\r\n\r\n                    </ul>\r\n                </div>\r\n            </div>\r\n\r\n            <h3>\r\n                ");
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
            WriteLiteral("\r\n\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n        <div class=\"comment-top\">\r\n            ");
#nullable restore
#line 62 "C:\Users\sahin\OneDrive\Desktop\​‏       \GithubProjects\AspNetCoreMVCProjectCamp\CoreDemo\Views\Blog\GetById.cshtml"
       Write(await Html.PartialAsync("../Blog/AddComment" , new CreateCommentViewModel()
            {
                BlogId = Model.BlogId
            }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <!--//left-->\r\n    <!--right-->\r\n    <aside class=\"col-lg-4 agileits-w3ls-right-blog-con text-right\">\r\n        <div class=\"right-blog-info text-left\">\r\n\r\n\r\n");
            WriteLiteral("\r\n            \r\n            ");
#nullable restore
#line 100 "C:\Users\sahin\OneDrive\Desktop\​‏       \GithubProjects\AspNetCoreMVCProjectCamp\CoreDemo\Views\Blog\GetById.cshtml"
       Write(await Component.InvokeAsync("SubscribeEmailAtBlog"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            <div class=\"tech-btm\">\r\n                ");
#nullable restore
#line 103 "C:\Users\sahin\OneDrive\Desktop\​‏       \GithubProjects\AspNetCoreMVCProjectCamp\CoreDemo\Views\Blog\GetById.cshtml"
           Write(await Component.InvokeAsync("LatestPostsToWriter" , new {writerId = @Model.WriterViewModel.WriterId}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n");
            WriteLiteral("            <div class=\"single-gd tech-btm\">\r\n                <h4>Bir Önceki Bloglar</h4>\r\n");
            WriteLiteral("            </div>\r\n        </div>\r\n\r\n    </aside>\r\n    <!--//right-->\r\n</div>\r\n\r\n<script>\r\n\r\n    window.onload = function () {\r\n        ");
#nullable restore
#line 154 "C:\Users\sahin\OneDrive\Desktop\​‏       \GithubProjects\AspNetCoreMVCProjectCamp\CoreDemo\Views\Blog\GetById.cshtml"
   Write(Html.Raw(TempData["Message"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    }\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ReadBlogViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591