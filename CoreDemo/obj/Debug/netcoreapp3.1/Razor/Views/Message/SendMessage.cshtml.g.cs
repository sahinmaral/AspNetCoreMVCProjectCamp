#pragma checksum "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Message\SendMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d46060fd56a4e1b661eaab75e6558a8ee0329df"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Message_SendMessage), @"mvc.1.0.view", @"/Views/Message/SendMessage.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d46060fd56a4e1b661eaab75e6558a8ee0329df", @"/Views/Message/SendMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca0be51d26d4a74b2a4dd4365d98ecd604a0fd5b", @"/Views/_ViewImports.cshtml")]
    public class Views_Message_SendMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CreateMessageViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Message\SendMessage.cshtml"
  
    ViewData["Title"] = "Mesaj Gonderme";
    Layout = "_WriterLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"col-12 grid-margin stretch-card\">\r\n    <div class=\"card\">\r\n        <div class=\"card-body\">\r\n            <h3 class=\"card-title\" style=\"margin-bottom:3em\">");
#nullable restore
#line 11 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Message\SendMessage.cshtml"
                                                        Write(Model.Receiver.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral(" kullanici adli kisiye mesaj gonderme</h3>\r\n");
#nullable restore
#line 12 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Message\SendMessage.cshtml"
             using (Html.BeginForm("SendMessage", "Message", FormMethod.Post))
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Message\SendMessage.cshtml"
           Write(Html.HiddenFor(x => x.Receiver.UserId));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Message\SendMessage.cshtml"
           Write(Html.HiddenFor(x => x.Sender.UserId));

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"form-group\">\r\n                    <label>Gonderilen kisinin kullanici adi</label>\r\n                    ");
#nullable restore
#line 19 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Message\SendMessage.cshtml"
               Write(Html.TextBoxFor(x => x.Receiver.Username, new { @class = "form-control", style = "border:1px solid black", disabled = "true" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n");
            WriteLiteral("                <div class=\"form-group\">\r\n                    <label>Baslik</label>\r\n                    ");
#nullable restore
#line 24 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Message\SendMessage.cshtml"
               Write(Html.TextBoxFor(x => x.MessageSubject, new { @class = "form-control", style = "border:1px solid black", placeholder = "Baslik", rows = "4" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 25 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Message\SendMessage.cshtml"
               Write(Html.ValidationMessageFor(x => x.MessageSubject, "", new { style = "color:darkred" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label>Icerik</label>\r\n                    ");
#nullable restore
#line 29 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Message\SendMessage.cshtml"
               Write(Html.TextAreaFor(x => x.MessageDetail, new { @class = "form-control", style = "border:1px solid black", placeholder = "Icerik", rows = "4" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <button type=\"submit\" class=\"btn btn-gradient-primary mr-2\">Gonder</button>\r\n");
#nullable restore
#line 32 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Message\SendMessage.cshtml"
                //TODO : Emin misiniz seklinde alert gonderebiliriz.

#line default
#line hidden
#nullable disable
            WriteLiteral("                <button class=\"btn btn-light\">İptal Et</button>\r\n");
#nullable restore
#line 34 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Message\SendMessage.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CreateMessageViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
