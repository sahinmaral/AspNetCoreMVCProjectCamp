#pragma checksum "C:\Users\sahin\OneDrive\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Writer\Views\Home\ChangePassword.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70686b8539f14913cc31dbbfa249090cce7591fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Writer_Views_Home_ChangePassword), @"mvc.1.0.view", @"/Areas/Writer/Views/Home/ChangePassword.cshtml")]
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
#line 1 "C:\Users\sahin\OneDrive\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Writer\Views\_ViewImports.cshtml"
using CoreDemo.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sahin\OneDrive\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Writer\Views\_ViewImports.cshtml"
using CoreDemo.Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\sahin\OneDrive\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Writer\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\sahin\OneDrive\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Writer\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\sahin\OneDrive\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Writer\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\sahin\OneDrive\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Writer\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.TagHelpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\sahin\OneDrive\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Writer\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\sahin\OneDrive\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Writer\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Builder;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70686b8539f14913cc31dbbfa249090cce7591fe", @"/Areas/Writer/Views/Home/ChangePassword.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb47e5b91ffd5a4f6f8f61d80a76c412e8535e09", @"/Areas/Writer/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Writer_Views_Home_ChangePassword : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserPasswordViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\sahin\OneDrive\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Writer\Views\Home\ChangePassword.cshtml"
  
    ViewBag.Title = ViewLocalizer["Title"];
    Layout = "_WriterLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2 class=\"ml-5\">");
#nullable restore
#line 8 "C:\Users\sahin\OneDrive\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Writer\Views\Home\ChangePassword.cshtml"
            Write(ViewLocalizer["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n<div class=\"col-12 grid-margin stretch-card\">\r\n    <div class=\"card\">\r\n        <div class=\"card-body\">\r\n");
#nullable restore
#line 13 "C:\Users\sahin\OneDrive\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Writer\Views\Home\ChangePassword.cshtml"
             using (Html.BeginForm("ChangePassword", "Home", FormMethod.Post))
            {
                

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"form-group\">\r\n                    <label for=\"exampleTextarea1\">");
#nullable restore
#line 21 "C:\Users\sahin\OneDrive\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Writer\Views\Home\ChangePassword.cshtml"
                                             Write(ViewLocalizer["NewPassword"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                    ");
#nullable restore
#line 22 "C:\Users\sahin\OneDrive\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Writer\Views\Home\ChangePassword.cshtml"
               Write(Html.PasswordFor(x => x.NewPassword, new { @class = "form-control", style = "border:1px solid black", placeholder = "", rows = "4" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 23 "C:\Users\sahin\OneDrive\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Writer\Views\Home\ChangePassword.cshtml"
               Write(Html.ValidationMessageFor(x => x.NewPassword, "", new { style = "color:darkred" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label for=\"exampleTextarea1\">");
#nullable restore
#line 26 "C:\Users\sahin\OneDrive\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Writer\Views\Home\ChangePassword.cshtml"
                                             Write(ViewLocalizer["ConfirmNewPassword"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                    ");
#nullable restore
#line 27 "C:\Users\sahin\OneDrive\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Writer\Views\Home\ChangePassword.cshtml"
               Write(Html.PasswordFor(x => x.ConfirmPassword, new { @class = "form-control", style = "border:1px solid black", placeholder = "", rows = "4" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 28 "C:\Users\sahin\OneDrive\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Writer\Views\Home\ChangePassword.cshtml"
               Write(Html.ValidationMessageFor(x => x.ConfirmPassword, "", new { style = "color:darkred" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <button type=\"submit\" class=\"btn btn-gradient-primary mr-2\">");
#nullable restore
#line 30 "C:\Users\sahin\OneDrive\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Writer\Views\Home\ChangePassword.cshtml"
                                                                       Write(ViewLocalizer["Submit"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n");
#nullable restore
#line 31 "C:\Users\sahin\OneDrive\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Writer\Views\Home\ChangePassword.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer ViewLocalizer { get; private set; } = default!;
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserPasswordViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
