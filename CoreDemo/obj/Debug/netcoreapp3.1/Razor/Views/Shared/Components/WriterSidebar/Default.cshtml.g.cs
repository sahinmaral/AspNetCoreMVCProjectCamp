#pragma checksum "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Shared\Components\WriterSidebar\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "79ce3e1aac4b30f5922b70d71a4c269ad45e0c01"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_WriterSidebar_Default), @"mvc.1.0.view", @"/Views/Shared/Components/WriterSidebar/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79ce3e1aac4b30f5922b70d71a4c269ad45e0c01", @"/Views/Shared/Components/WriterSidebar/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca0be51d26d4a74b2a4dd4365d98ecd604a0fd5b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_WriterSidebar_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/writerTemplate/pages/tables/basic-table.html"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<nav class=""sidebar sidebar-offcanvas"" id=""sidebar"">
    <ul class=""nav"">
        <li class=""nav-item"">
            <a class=""nav-link"" href=""/Writer/Homepage"">
                <span class=""menu-title"">Arayüz</span>
                <i class=""mdi mdi-home menu-icon""></i>
            </a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" data-toggle=""collapse"" href=""#my-profile"" aria-expanded=""false"" aria-controls=""ui-basic"">
                <span class=""menu-title"">Profilim</span>
                <i class=""menu-arrow""></i>
                <i class=""mdi mdi-account-settings menu-icon""></i>
            </a>
            <div class=""collapse"" id=""my-profile"">
                <ul class=""nav flex-column sub-menu"">
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""/Writer/ChangeProfile"">
                            <span class=""menu-title"">Profil Bilgilerini Degistir</span>
                        </a>
                    </li>
                    <l");
            WriteLiteral(@"i class=""nav-item"">
                        <a class=""nav-link"" href=""/Writer/ChangePassword"">
                            <span class=""menu-title"">Sifre Degistir</span>
                        </a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""/Writer/ChangeThumbnailImage"">
                            <span class=""menu-title"">Kapak Fotografini Degistir</span>
                        </a>
                    </li>
                </ul>
            </div>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" data-toggle=""collapse"" href=""#blog-processes"" aria-expanded=""false"" aria-controls=""general-pages"">
                <span class=""menu-title"">Blog Islemleri</span>
                <i class=""menu-arrow""></i>
                <i class=""mdi mdi-format-list-bulleted menu-icon""></i>
            </a>
            <div class=""collapse"" id=""blog-processes"">
                <ul class=""nav flex-column sub-menu"">
               ");
            WriteLiteral(@"     <li class=""nav-item"">
                        <a class=""nav-link"" href=""/Writer/MyBlog"">
                            <span class=""menu-title"">Bloglarım</span>
                        </a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""/Writer/AddBlog"">
                            <span class=""menu-title"">Yeni Blog</span>
                        </a>
                    </li>
                </ul>
            </div>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" href=""/Message/ViewInbox"">
                <span class=""menu-title"">Mesajlar</span>
                <i class=""mdi mdi-message menu-icon""></i>
            </a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" href=""/Blog/GetAll"">
                <span class=""menu-title"">Siteye Git</span>
                <i class=""mdi mdi-table-large menu-icon""></i>
            </a>
        </li>
        <li class=""nav-item"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "79ce3e1aac4b30f5922b70d71a4c269ad45e0c017301", async() => {
                WriteLiteral("\n                <span class=\"menu-title\">Ayarlar</span>\n                <i class=\"mdi mdi-settings menu-icon\"></i>\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" href=""/Login/LogOut"">
                <span class=""menu-title"">Çıkış Yap</span>
                <i class=""mdi mdi-power-settings menu-icon""></i>
            </a>
        </li>
    </ul>
</nav>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
