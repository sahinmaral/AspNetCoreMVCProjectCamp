#pragma checksum "C:\Users\sahin\OneDrive\Desktop\​‏       \GithubProjects\AspNetCoreMVCProjectCamp\CoreDemo\Views\Blog\GetAll.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d58c8a45c3638abca955324ebafe4669641600a2"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d58c8a45c3638abca955324ebafe4669641600a2", @"/Views/Blog/GetAll.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f21d357d3a7a0ebdb24ebf4009b9f29dec35ea9", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_GetAll : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BlogViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\sahin\OneDrive\Desktop\​‏       \GithubProjects\AspNetCoreMVCProjectCamp\CoreDemo\Views\Blog\GetAll.cshtml"
  
    ViewData["Title"] = "Bloglar";
    Layout = "_UserLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\sahin\OneDrive\Desktop\​‏       \GithubProjects\AspNetCoreMVCProjectCamp\CoreDemo\Views\Blog\GetAll.cshtml"
  
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
            WriteLiteral("\r\n<h3 class=\"tittle\">Blog Posts</h3>\r\n\t\t\t<div class=\"inner-sec\">\r\n\t\t\t\t<div class=\"left-blog-info-w3layouts-agileits text-left\">\r\n\t\t\t\t\t<div class=\"row\">\r\n");
#nullable restore
#line 24 "C:\Users\sahin\OneDrive\Desktop\​‏       \GithubProjects\AspNetCoreMVCProjectCamp\CoreDemo\Views\Blog\GetAll.cshtml"
                         foreach (BlogViewModel blog in Model)
						{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t<div class=\"col-lg-4 card\">\r\n\t\t\t\t\t\t\t\t<a href=\"single.html\">\r\n\t\t\t\t\t\t\t\t\t<img");
            BeginWriteAttribute("src", " src=\"", 574, "\"", 604, 1);
#nullable restore
#line 28 "C:\Users\sahin\OneDrive\Desktop\​‏       \GithubProjects\AspNetCoreMVCProjectCamp\CoreDemo\Views\Blog\GetAll.cshtml"
WriteAttributeValue("", 580, blog.BlogThumbnailImage, 580, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 636, "\"", 642, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n\t\t\t\t\t\t\t\t</a>\r\n\t\t\t\t\t\t\t\t<div class=\"card-body\">\r\n\t\t\t\t\t\t\t\t\t<ul class=\"blog-icons my-4\">\r\n\t\t\t\t\t\t\t\t\t\t<li>\r\n\t\t\t\t\t\t\t\t\t\t\t<a href=\"#\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t<i class=\"far fa-calendar-alt\"></i>");
#nullable restore
#line 34 "C:\Users\sahin\OneDrive\Desktop\​‏       \GithubProjects\AspNetCoreMVCProjectCamp\CoreDemo\Views\Blog\GetAll.cshtml"
                                                                              Write(blog.BlogCreateDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\t\t\t\t\t\t\t\t\t\t</li>\r\n\t\t\t\t\t\t\t\t\t\t<li class=\"mx-2\">\r\n\t\t\t\t\t\t\t\t\t\t\t<a href=\"#\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t<i class=\"far fa-comment\"></i>0</a>\r\n\t\t\t\t\t\t\t\t\t\t</li>\r\n\t\t\t\t\t\t\t\t\t\t<li>\r\n\t\t\t\t\t\t\t\t\t\t\t<a href=\"#\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t<i class=\"fas fa-eye\"></i>");
#nullable restore
#line 42 "C:\Users\sahin\OneDrive\Desktop\​‏       \GithubProjects\AspNetCoreMVCProjectCamp\CoreDemo\Views\Blog\GetAll.cshtml"
                                                                     Write(blog.CategoryViewModel.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\t\t\t\t\t\t\t\t\t\t</li>\r\n\r\n\t\t\t\t\t\t\t\t\t</ul>\r\n\t\t\t\t\t\t\t\t\t<h5 class=\"card-title\">\r\n\t\t\t\t\t\t\t\t\t\t<a href=\"single.html\">");
#nullable restore
#line 47 "C:\Users\sahin\OneDrive\Desktop\​‏       \GithubProjects\AspNetCoreMVCProjectCamp\CoreDemo\Views\Blog\GetAll.cshtml"
                                                         Write(blog.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\t\t\t\t\t\t\t\t\t</h5>\r\n\t\t\t\t\t\t\t\t\t<p class=\"card-text mb-3\">\r\n\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 50 "C:\Users\sahin\OneDrive\Desktop\​‏       \GithubProjects\AspNetCoreMVCProjectCamp\CoreDemo\Views\Blog\GetAll.cshtml"
                                   Write(CheckBlogContent(blog.BlogContent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t</p>\r\n\t\t\t\t\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 1352, "\"", 1379, 2);
            WriteAttributeValue("", 1359, "GetById/", 1359, 8, true);
#nullable restore
#line 52 "C:\Users\sahin\OneDrive\Desktop\​‏       \GithubProjects\AspNetCoreMVCProjectCamp\CoreDemo\Views\Blog\GetAll.cshtml"
WriteAttributeValue("", 1367, blog.BlogId, 1367, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary read-m\">Daha Fazlası </a>\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t</div>\r\n");
#nullable restore
#line 55 "C:\Users\sahin\OneDrive\Desktop\​‏       \GithubProjects\AspNetCoreMVCProjectCamp\CoreDemo\Views\Blog\GetAll.cshtml"
						}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t</div>\r\n\t\t\t\t\t<!--//left-->\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<BlogViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
