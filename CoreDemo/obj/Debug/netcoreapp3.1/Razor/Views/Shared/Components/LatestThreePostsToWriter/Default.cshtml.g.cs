#pragma checksum "C:\Users\sahin\Desktop\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Shared\Components\LatestThreePostsToWriter\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef2d2c67567fb18d6711ec852af84fb0ca283272"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef2d2c67567fb18d6711ec852af84fb0ca283272", @"/Views/Shared/Components/LatestThreePostsToWriter/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca0be51d26d4a74b2a4dd4365d98ecd604a0fd5b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_LatestThreePostsToWriter_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ReadBlogViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\sahin\Desktop\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Shared\Components\LatestThreePostsToWriter\Default.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h4>Yazarın Diğer Postları</h4>\n\n");
#nullable restore
#line 9 "C:\Users\sahin\Desktop\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Shared\Components\LatestThreePostsToWriter\Default.cshtml"
 foreach (ReadBlogViewModel blog in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"blog-grids row mb-3\">\n        <div class=\"col-md-5 blog-grid-left\">\n            <a");
            BeginWriteAttribute("href", " href=\"", 233, "\"", 266, 2);
            WriteAttributeValue("", 240, "/Blog/GetById/", 240, 14, true);
#nullable restore
#line 13 "C:\Users\sahin\Desktop\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Shared\Components\LatestThreePostsToWriter\Default.cshtml"
WriteAttributeValue("", 254, blog.BlogId, 254, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                <img");
            BeginWriteAttribute("src", " src=\"", 289, "\"", 319, 1);
#nullable restore
#line 14 "C:\Users\sahin\Desktop\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Shared\Components\LatestThreePostsToWriter\Default.cshtml"
WriteAttributeValue("", 295, blog.BlogThumbnailImage, 295, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 351, "\"", 357, 0);
            EndWriteAttribute();
            WriteLiteral(">\n            </a>\n        </div>\n        <div class=\"col-md-7 blog-grid-right\">\n            <h5>\n                <a");
            BeginWriteAttribute("href", " href=\"", 474, "\"", 507, 2);
            WriteAttributeValue("", 481, "/Blog/GetById/", 481, 14, true);
#nullable restore
#line 19 "C:\Users\sahin\Desktop\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Shared\Components\LatestThreePostsToWriter\Default.cshtml"
WriteAttributeValue("", 495, blog.BlogId, 495, 12, false);

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
            WriteLiteral("</a>\n            </h5>\n            <div class=\"sub-meta\">\n                <span>\n                    <i class=\"far fa-clock\"></i> ");
#nullable restore
#line 23 "C:\Users\sahin\Desktop\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Shared\Components\LatestThreePostsToWriter\Default.cshtml"
                                            Write(blog.BlogCreateDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </span>\n            </div>\n        </div>\n\n    </div>\n");
#nullable restore
#line 29 "C:\Users\sahin\Desktop\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Shared\Components\LatestThreePostsToWriter\Default.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
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
