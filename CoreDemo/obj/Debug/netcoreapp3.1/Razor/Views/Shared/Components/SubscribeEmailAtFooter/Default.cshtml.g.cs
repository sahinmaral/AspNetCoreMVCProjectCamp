#pragma checksum "C:\Users\sahin\Desktop\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Shared\Components\SubscribeEmailAtFooter\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff7ae0e2dabd9cb6a31c23612940cbd77d17b121"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_SubscribeEmailAtFooter_Default), @"mvc.1.0.view", @"/Views/Shared/Components/SubscribeEmailAtFooter/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff7ae0e2dabd9cb6a31c23612940cbd77d17b121", @"/Views/Shared/Components/SubscribeEmailAtFooter/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca0be51d26d4a74b2a4dd4365d98ecd604a0fd5b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_SubscribeEmailAtFooter_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CoreDemo.Models.CreateNewsLetterViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""col-lg-4 subscribe-main footer-grid-agileits-w3ls text-left"">
    <h2>Mail Bültenine Abone Olun</h2>
    <p>Bloglarımızı takip etmek için abone olunuz.</p>
    <div class=""subscribe-main text-left"">
        
        <div class=""subscribe-form"">
");
#nullable restore
#line 9 "C:\Users\sahin\Desktop\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Shared\Components\SubscribeEmailAtFooter\Default.cshtml"
              using (Html.BeginForm("SubscribeEmailAtFooter", "NewsLetter"))
             {

#line default
#line hidden
#nullable disable
            WriteLiteral("                 <input class=\"form-control\" type=\"email\" placeholder=\"Enter your email...\"");
            BeginWriteAttribute("required", " required=\"", 490, "\"", 501, 0);
            EndWriteAttribute();
            WriteLiteral(" name=\"Email\">\n                 <button type=\"submit\" class=\"btn btn-primary submit\">Submit</button>\n");
#nullable restore
#line 13 "C:\Users\sahin\Desktop\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Shared\Components\SubscribeEmailAtFooter\Default.cshtml"
             }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"clearfix\"> </div>\n        </div>\n    </div>\n            \n\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CoreDemo.Models.CreateNewsLetterViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
