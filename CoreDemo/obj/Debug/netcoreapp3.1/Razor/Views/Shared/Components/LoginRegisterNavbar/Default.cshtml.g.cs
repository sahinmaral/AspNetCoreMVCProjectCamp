#pragma checksum "C:\Users\sahin\Desktop\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Shared\Components\LoginRegisterNavbar\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "017d8620d93fe0f86c70fe5d631f8bcbb70de0ed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_LoginRegisterNavbar_Default), @"mvc.1.0.view", @"/Views/Shared/Components/LoginRegisterNavbar/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"017d8620d93fe0f86c70fe5d631f8bcbb70de0ed", @"/Views/Shared/Components/LoginRegisterNavbar/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca0be51d26d4a74b2a4dd4365d98ecd604a0fd5b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_LoginRegisterNavbar_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CoreDemo.Models.ReadWriterViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"col-md-4 top-forms text-center mt-lg-3 mt-md-1 mt-0\">\r\n    <span>Hoşgeldiniz </span>\r\n    <span class=\"mx-lg-4 mx-md-2  mx-1\">\r\n");
#nullable restore
#line 6 "C:\Users\sahin\Desktop\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Shared\Components\LoginRegisterNavbar\Default.cshtml"
         if (Model.WriterUsername == null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a href=\"/Login/LoginWriter\">\r\n                <i class=\"fas fa-lock\"></i> Giriş yap\r\n            </a>\r\n");
#nullable restore
#line 11 "C:\Users\sahin\Desktop\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Shared\Components\LoginRegisterNavbar\Default.cshtml"
        }
        else
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\sahin\Desktop\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Shared\Components\LoginRegisterNavbar\Default.cshtml"
       Write(Model.WriterUsername);

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\sahin\Desktop\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Shared\Components\LoginRegisterNavbar\Default.cshtml"
                                 
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </span>\r\n    <span>\r\n");
#nullable restore
#line 19 "C:\Users\sahin\Desktop\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Shared\Components\LoginRegisterNavbar\Default.cshtml"
         if (Model.WriterUsername == null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a href=\"/Register/RegisterWriter\">\r\n                <i class=\"far fa-user\"></i> Kayıt ol\r\n            </a>\r\n");
#nullable restore
#line 24 "C:\Users\sahin\Desktop\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Shared\Components\LoginRegisterNavbar\Default.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a href=\"/Login/LogOutWriter\">\r\n                <i class=\"fas fa-sign-out-alt\"></i> Çıkış Yap\r\n            </a>\r\n");
#nullable restore
#line 30 "C:\Users\sahin\Desktop\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Shared\Components\LoginRegisterNavbar\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </span>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CoreDemo.Models.ReadWriterViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
