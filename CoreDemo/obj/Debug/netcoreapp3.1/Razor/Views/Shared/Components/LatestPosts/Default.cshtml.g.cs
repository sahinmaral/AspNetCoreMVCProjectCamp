#pragma checksum "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Shared\Components\LatestPosts\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc98c1c34754ec29b7001060cd942aedaa2b999e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_LatestPosts_Default), @"mvc.1.0.view", @"/Views/Shared/Components/LatestPosts/Default.cshtml")]
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
#line 1 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc98c1c34754ec29b7001060cd942aedaa2b999e", @"/Views/Shared/Components/LatestPosts/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca0be51d26d4a74b2a4dd4365d98ecd604a0fd5b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_LatestPosts_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ReadBlogViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Shared\Components\LatestPosts\Default.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h3>Son Postlar</h3>\n\n");
#nullable restore
#line 9 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Shared\Components\LatestPosts\Default.cshtml"
 foreach (ReadBlogViewModel blog in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"blog-grids row mb-3\">\n        <div class=\"col-md-5 blog-grid-left\">\n            <a");
            BeginWriteAttribute("href", " href=\"", 222, "\"", 255, 2);
            WriteAttributeValue("", 229, "/Blog/GetById/", 229, 14, true);
#nullable restore
#line 13 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Shared\Components\LatestPosts\Default.cshtml"
WriteAttributeValue("", 243, blog.BlogId, 243, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "cc98c1c34754ec29b7001060cd942aedaa2b999e5208", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 284, "~/images/", 284, 9, true);
#nullable restore
#line 14 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Shared\Components\LatestPosts\Default.cshtml"
AddHtmlAttributeValue("", 293, blog.BlogThumbnailImage, 293, 24, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            </a>\n        </div>\n        <div class=\"col-md-7 blog-grid-right\">\n            <h5>\n                <a");
            BeginWriteAttribute("href", " href=\"", 472, "\"", 505, 2);
            WriteAttributeValue("", 479, "/Blog/GetById/", 479, 14, true);
#nullable restore
#line 19 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Shared\Components\LatestPosts\Default.cshtml"
WriteAttributeValue("", 493, blog.BlogId, 493, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 19 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Shared\Components\LatestPosts\Default.cshtml"
                                                Write(blog.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n            </h5>\n            <div class=\"sub-meta\">\n                <span>\n                    <i class=\"far fa-clock\"></i> ");
#nullable restore
#line 23 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Shared\Components\LatestPosts\Default.cshtml"
                                            Write(blog.BlogCreateDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n            </div>\n        </div>\n\n    </div>\n");
#nullable restore
#line 28 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Shared\Components\LatestPosts\Default.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n");
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
