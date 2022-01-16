#pragma checksum "C:\Users\sahin\Desktop\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Blog\GetAll.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42de6dd1d5628ec804aa519afc7ece021edf509f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_GetAll), @"mvc.1.0.view", @"/Views/Blog/GetAll.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42de6dd1d5628ec804aa519afc7ece021edf509f", @"/Views/Blog/GetAll.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca0be51d26d4a74b2a4dd4365d98ecd604a0fd5b", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_GetAll : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ReadBlogViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\sahin\Desktop\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Blog\GetAll.cshtml"
  
    ViewData["Title"] = "Bloglar";
    Layout = "_UserLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 8 "C:\Users\sahin\Desktop\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Blog\GetAll.cshtml"
  
	string CheckBlogContent(string content)
	{
		if (content != null && content.Length > 50)
		{
			return content.Substring(0, 50) + " ...";
		}

		return content;
	}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h3 class=\"tittle\">Blog Postları</h3>\n\t\t\t<div class=\"inner-sec\">\n\t\t\t\t<div class=\"left-blog-info-w3layouts-agileits text-left\">\n\t\t\t\t\t<div class=\"row\">\n");
#nullable restore
#line 24 "C:\Users\sahin\Desktop\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Blog\GetAll.cshtml"
                         foreach (ReadBlogViewModel blog in Model)
						{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t<div class=\"col-lg-4 card\">\n\t\t\t\t\t\t\t\t<a href=\"single.html\">\n\t\t\t\t\t\t\t\t\t<img");
            BeginWriteAttribute("src", " src=\"", 558, "\"", 588, 1);
#nullable restore
#line 28 "C:\Users\sahin\Desktop\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Blog\GetAll.cshtml"
WriteAttributeValue("", 564, blog.BlogThumbnailImage, 564, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 620, "\"", 626, 0);
            EndWriteAttribute();
            WriteLiteral(">\n\t\t\t\t\t\t\t\t</a>\n\t\t\t\t\t\t\t\t<div class=\"card-body\">\n\t\t\t\t\t\t\t\t\t<ul class=\"blog-icons my-4\">\n\t\t\t\t\t\t\t\t\t\t<li>\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 773, "\"", 800, 2);
            WriteAttributeValue("", 780, "GetById/", 780, 8, true);
#nullable restore
#line 33 "C:\Users\sahin\Desktop\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Blog\GetAll.cshtml"
WriteAttributeValue("", 788, blog.BlogId, 788, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n\t\t\t\t\t\t\t\t\t\t\t\t<i class=\"far fa-calendar-alt\"></i>");
#nullable restore
#line 34 "C:\Users\sahin\Desktop\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Blog\GetAll.cshtml"
                                                                              Write(blog.BlogCreateDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n\t\t\t\t\t\t\t\t\t\t</li>\n\t\t\t\t\t\t\t\t\t\t<li class=\"mx-2\">\n\t\t\t\t\t\t\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 932, "\"", 959, 2);
            WriteAttributeValue("", 939, "GetById/", 939, 8, true);
#nullable restore
#line 37 "C:\Users\sahin\Desktop\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Blog\GetAll.cshtml"
WriteAttributeValue("", 947, blog.BlogId, 947, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                                                <i class=\"far fa-comment\"></i>");
#nullable restore
#line 38 "C:\Users\sahin\Desktop\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Blog\GetAll.cshtml"
                                                                         Write(blog.CommentViewModels.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n\t\t\t\t\t\t\t\t\t\t</li>\n\t\t\t\t\t\t\t\t\t\t<li>\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 1151, "\"", 1178, 2);
            WriteAttributeValue("", 1158, "GetById/", 1158, 8, true);
#nullable restore
#line 41 "C:\Users\sahin\Desktop\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Blog\GetAll.cshtml"
WriteAttributeValue("", 1166, blog.BlogId, 1166, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n\t\t\t\t\t\t\t\t\t\t\t\t<i class=\"fas fa-eye\"></i>");
#nullable restore
#line 42 "C:\Users\sahin\Desktop\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Blog\GetAll.cshtml"
                                                                     Write(blog.CategoryViewModel.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n\t\t\t\t\t\t\t\t\t\t</li>\n\n\t\t\t\t\t\t\t\t\t</ul>\n\t\t\t\t\t\t\t\t\t<h5 class=\"card-title\">\n\t\t\t\t\t\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 1337, "\"", 1364, 2);
            WriteAttributeValue("", 1344, "GetById/", 1344, 8, true);
#nullable restore
#line 47 "C:\Users\sahin\Desktop\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Blog\GetAll.cshtml"
WriteAttributeValue("", 1352, blog.BlogId, 1352, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 47 "C:\Users\sahin\Desktop\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Blog\GetAll.cshtml"
                                                                  Write(blog.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n\t\t\t\t\t\t\t\t\t</h5>\n\t\t\t\t\t\t\t\t\t<p class=\"card-text mb-3\">\n\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 50 "C:\Users\sahin\Desktop\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Blog\GetAll.cshtml"
                                   Write(CheckBlogContent(blog.BlogContent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\t\t\t\t\t\t\t\t\t</p>\n\t\t\t\t\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 1508, "\"", 1541, 2);
            WriteAttributeValue("", 1515, "/Blog/GetById/", 1515, 14, true);
#nullable restore
#line 52 "C:\Users\sahin\Desktop\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Blog\GetAll.cshtml"
WriteAttributeValue("", 1529, blog.BlogId, 1529, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary read-m\">Daha Fazlası </a>\n\t\t\t\t\t\t\t\t</div>\n\t\t\t\t\t\t\t</div>\n");
#nullable restore
#line 55 "C:\Users\sahin\Desktop\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Blog\GetAll.cshtml"
						}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t</div>\n\t\t\t\t\t<!--//left-->\n\t\t\t\t</div>\n\t\t\t</div>\n\n");
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
