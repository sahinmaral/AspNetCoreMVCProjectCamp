#pragma checksum "C:\Users\sahin\OneDrive\Desktop\​‏       \GithubProjects\AspNetCoreMVCProjectCamp\CoreDemo\Views\Login\LoginWriter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e5c3a56967f87c6175504f63586e410b419d9ea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_LoginWriter), @"mvc.1.0.view", @"/Views/Login/LoginWriter.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e5c3a56967f87c6175504f63586e410b419d9ea", @"/Views/Login/LoginWriter.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f21d357d3a7a0ebdb24ebf4009b9f29dec35ea9", @"/Views/_ViewImports.cshtml")]
    public class Views_Login_LoginWriter : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LoginWriterViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\sahin\OneDrive\Desktop\​‏       \GithubProjects\AspNetCoreMVCProjectCamp\CoreDemo\Views\Login\LoginWriter.cshtml"
  
    Layout = "_UserLayout";
    ViewData["Title"] = "Giriş Yap";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<section class=\"main-content-w3layouts-agileits\">\r\n    <div class=\"container\">\r\n        <h3 class=\"tittle\">Giriş Yap</h3>\r\n        <div class=\"row inner-sec\">\r\n            <div class=\"login p-5 bg-light mx-auto mw-100\">\r\n");
#nullable restore
#line 15 "C:\Users\sahin\OneDrive\Desktop\​‏       \GithubProjects\AspNetCoreMVCProjectCamp\CoreDemo\Views\Login\LoginWriter.cshtml"
                 using (Html.BeginForm("LoginWriter", "Login", FormMethod.Post))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"form-group\">\r\n                        <label>Kullanıcı Adı</label>\r\n                        ");
#nullable restore
#line 19 "C:\Users\sahin\OneDrive\Desktop\​‏       \GithubProjects\AspNetCoreMVCProjectCamp\CoreDemo\Views\Login\LoginWriter.cshtml"
                   Write(Html.TextBoxFor(x => x.WriterUsername, new { @class = "form-control", placeholder = "Kullanıcı adı" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <label>Şifre</label>\r\n                        ");
#nullable restore
#line 23 "C:\Users\sahin\OneDrive\Desktop\​‏       \GithubProjects\AspNetCoreMVCProjectCamp\CoreDemo\Views\Login\LoginWriter.cshtml"
                   Write(Html.PasswordFor(x => x.WriterPassword, new { @class = "form-control", placeholder = "Şifre" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n");
            WriteLiteral("                    <button type=\"submit\" class=\"btn btn-primary submit mb-4\">Giriş Yap</button>\r\n                    <p><a href=\"/Register/RegisterWriter\"> Hesabınız yok mu?</a></p>\r\n");
#nullable restore
#line 31 "C:\Users\sahin\OneDrive\Desktop\​‏       \GithubProjects\AspNetCoreMVCProjectCamp\CoreDemo\Views\Login\LoginWriter.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <button class=\"btn btn-primary submit mb-4\" onclick=\"Test()\">Giriş Yap</button>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n<script>\r\n\r\n    window.onload = function() {\r\n        var message = \"");
#nullable restore
#line 43 "C:\Users\sahin\OneDrive\Desktop\​‏       \GithubProjects\AspNetCoreMVCProjectCamp\CoreDemo\Views\Login\LoginWriter.cshtml"
                   Write((string)ViewData["LoginError"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n        if (message !== \"\" && message !== null) {\r\n            swal(message);\r\n        }\r\n    }\r\n\r\n    \r\n\r\n\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LoginWriterViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
