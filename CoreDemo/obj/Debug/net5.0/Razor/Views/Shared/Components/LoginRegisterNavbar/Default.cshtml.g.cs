#pragma checksum "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Shared\Components\LoginRegisterNavbar\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8eef3c537527ecce4ae4ca70ee90fc7c2da8ab5a"
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
#line 1 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo.Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.TagHelpers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8eef3c537527ecce4ae4ca70ee90fc7c2da8ab5a", @"/Views/Shared/Components/LoginRegisterNavbar/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fec89d864263bed1da14e8e82b9178d3bc8aca74", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_LoginRegisterNavbar_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CoreDemo.Models.ReadUserViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div class=\"col-md-4 top-forms mt-lg-3 mt-md-1 mt-0 d-flex\">\r\n    <span>");
#nullable restore
#line 6 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Shared\Components\LoginRegisterNavbar\Default.cshtml"
     Write(Localizer["Welcome"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span>\r\n    <div class=\"mx-lg-4 mx-md-2 mx-1\">\r\n");
#nullable restore
#line 8 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Shared\Components\LoginRegisterNavbar\Default.cshtml"
         if (Model.Username == null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a href=\"/Login/Login\" style=\"color:gray\">\r\n                <i class=\"fas fa-lock\"></i> ");
#nullable restore
#line 11 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Shared\Components\LoginRegisterNavbar\Default.cshtml"
                                       Write(Localizer["Login"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </a>\r\n");
#nullable restore
#line 13 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Shared\Components\LoginRegisterNavbar\Default.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <ul class=""blog-icons"">
                <li class=""nav-item dropdown"">
                    <a class=""dropdown-toggle"" href=""#"" id=""navbarDropdown"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                        <i class=""fas fa-user""></i>");
#nullable restore
#line 19 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Shared\Components\LoginRegisterNavbar\Default.cshtml"
                                              Write(Model.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </a>\r\n                    <div class=\"dropdown-menu\" aria-labelledby=\"navbarDropdown\">\r\n");
#nullable restore
#line 22 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Shared\Components\LoginRegisterNavbar\Default.cshtml"
                         if (User.IsInRole("Admin"))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a class=\"dropdown-item\" href=\"/Admin/Category/GetCategories\">");
#nullable restore
#line 24 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Shared\Components\LoginRegisterNavbar\Default.cshtml"
                                                                                     Write(Localizer["AdminPanel"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 25 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Shared\Components\LoginRegisterNavbar\Default.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 27 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Shared\Components\LoginRegisterNavbar\Default.cshtml"
                         if (User.IsInRole("Writer"))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a class=\"dropdown-item\" href=\"/Writer/Home/Homepage\">");
#nullable restore
#line 29 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Shared\Components\LoginRegisterNavbar\Default.cshtml"
                                                                             Write(Localizer["WriterPanel"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 30 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Shared\Components\LoginRegisterNavbar\Default.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </li>\r\n            </ul>\r\n");
#nullable restore
#line 35 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Shared\Components\LoginRegisterNavbar\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    <span>\r\n");
#nullable restore
#line 38 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Shared\Components\LoginRegisterNavbar\Default.cshtml"
         if (Model.Username == null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a href=\"/Register/Register\">\r\n                <i class=\"far fa-user\"></i> ");
#nullable restore
#line 41 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Shared\Components\LoginRegisterNavbar\Default.cshtml"
                                       Write(Localizer["Signup"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </a>\r\n");
#nullable restore
#line 43 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Shared\Components\LoginRegisterNavbar\Default.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a href=\"/Login/LogOut\">\r\n                <i class=\"fas fa-sign-out-alt\"></i> ");
#nullable restore
#line 47 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Shared\Components\LoginRegisterNavbar\Default.cshtml"
                                               Write(Localizer["Logout"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </a>\r\n");
#nullable restore
#line 49 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Shared\Components\LoginRegisterNavbar\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </span>\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IStringLocalizer<UserLayoutController> Localizer { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CoreDemo.Models.ReadUserViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591