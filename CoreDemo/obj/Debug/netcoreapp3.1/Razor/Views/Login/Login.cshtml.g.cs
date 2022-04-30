#pragma checksum "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Login\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d1c9edb84f36ef891eb8a277b090bc9bee35931"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_Login), @"mvc.1.0.view", @"/Views/Login/Login.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d1c9edb84f36ef891eb8a277b090bc9bee35931", @"/Views/Login/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca0be51d26d4a74b2a4dd4365d98ecd604a0fd5b", @"/Views/_ViewImports.cshtml")]
    public class Views_Login_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserSignInViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Login\Login.cshtml"
  
    Layout = "_UserLayout";
    ViewData["Title"] = "Giriş Yap";


#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n<section class=\"main-content-w3layouts-agileits\">\n    <div class=\"container\">\n        <h3 class=\"tittle\">Giriş Yap</h3>\n        <div class=\"row inner-sec\">\n            <div class=\"login p-5 bg-light mx-auto mw-100\">\n");
#nullable restore
#line 15 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Login\Login.cshtml"
                 using (Html.BeginForm("Login", "Login", FormMethod.Post))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"form-group\">\n                        ");
#nullable restore
#line 18 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Login\Login.cshtml"
                   Write(Html.LabelFor(x=>x.Username , "Kullanici adi"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        ");
#nullable restore
#line 19 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Login\Login.cshtml"
                   Write(Html.TextBoxFor(x => x.Username, new { @class = "form-control", placeholder = "Kullanıcı adı" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </div>\n                    <div class=\"form-group\">\n                        ");
#nullable restore
#line 22 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Login\Login.cshtml"
                   Write(Html.LabelFor(x=>x.Password , "Sifre"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        ");
#nullable restore
#line 23 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Login\Login.cshtml"
                   Write(Html.PasswordFor(x => x.Password, new { @class = "form-control", placeholder = "Şifre" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </div>\n");
            WriteLiteral("                    <button type=\"submit\" class=\"btn btn-primary submit mb-4\">Giriş Yap</button>\n                    <p><a href=\"/Register/RegisterUser\"> Hesabınız yok mu?</a></p>\n");
#nullable restore
#line 28 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Login\Login.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n        </div>\n    </div>\n</section>\n\n<script>\n\n    window.onload = function() {\n        var message = \"");
#nullable restore
#line 38 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Login\Login.cshtml"
                   Write((string)ViewData["LoginError"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\n        if (message !== \"\" && message !== null) {\n            swal(\"Uyarı\",message);\n        }\n    }\n\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserSignInViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
