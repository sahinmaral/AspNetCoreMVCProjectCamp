#pragma checksum "C:\Users\sahin\Desktop\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Shared\Components\LatestThreePostsToWriter\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8411e3c8469e0752b2fd1ee042397be4b34102fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_LatestThreePostsToWriter_Default), @"mvc.1.0.view", @"/Views/Shared/Components/LatestThreePostsToWriter/Default.cshtml")]
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
#line 1 "C:\Users\sahin\Desktop\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sahin\Desktop\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8411e3c8469e0752b2fd1ee042397be4b34102fb", @"/Views/Shared/Components/LatestThreePostsToWriter/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f21d357d3a7a0ebdb24ebf4009b9f29dec35ea9", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_LatestThreePostsToWriter_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ReadBlogViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\sahin\Desktop\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Shared\Components\LatestThreePostsToWriter\Default.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h4>Yazarın Diğer Postları</h4>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\sahin\Desktop\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Shared\Components\LatestThreePostsToWriter\Default.cshtml"
 foreach (ReadBlogViewModel blog in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"blog-grids row mb-3\">\r\n        <div class=\"col-md-5 blog-grid-left\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 245, "\"", 278, 2);
            WriteAttributeValue("", 252, "/Blog/GetById/", 252, 14, true);
#nullable restore
#line 13 "C:\Users\sahin\Desktop\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Shared\Components\LatestThreePostsToWriter\Default.cshtml"
WriteAttributeValue("", 266, blog.BlogId, 266, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 302, "\"", 332, 1);
#nullable restore
#line 14 "C:\Users\sahin\Desktop\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Shared\Components\LatestThreePostsToWriter\Default.cshtml"
WriteAttributeValue("", 308, blog.BlogThumbnailImage, 308, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 364, "\"", 370, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            </a>\r\n        </div>\r\n        <div class=\"col-md-7 blog-grid-right\">\r\n            <h5>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 492, "\"", 525, 2);
            WriteAttributeValue("", 499, "/Blog/GetById/", 499, 14, true);
#nullable restore
#line 19 "C:\Users\sahin\Desktop\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Shared\Components\LatestThreePostsToWriter\Default.cshtml"
WriteAttributeValue("", 513, blog.BlogId, 513, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 19 "C:\Users\sahin\Desktop\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Shared\Components\LatestThreePostsToWriter\Default.cshtml"
                                                Write(blog.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n            </h5>\r\n            <div class=\"sub-meta\">\r\n                <span>\r\n                    <i class=\"far fa-clock\"></i> ");
#nullable restore
#line 23 "C:\Users\sahin\Desktop\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Shared\Components\LatestThreePostsToWriter\Default.cshtml"
                                            Write(blog.BlogCreateDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </span>\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n");
#nullable restore
#line 29 "C:\Users\sahin\Desktop\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Shared\Components\LatestThreePostsToWriter\Default.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ReadBlogViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
