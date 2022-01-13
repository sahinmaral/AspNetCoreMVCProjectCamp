#pragma checksum "C:\Users\sahin\Desktop\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Shared\Components\WriterMessages\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23d559cf9acbb902d5837113f577c482efeb0deb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_WriterMessages_Default), @"mvc.1.0.view", @"/Views/Shared/Components/WriterMessages/Default.cshtml")]
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
#nullable restore
#line 1 "C:\Users\sahin\Desktop\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Shared\Components\WriterMessages\Default.cshtml"
using Entities.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23d559cf9acbb902d5837113f577c482efeb0deb", @"/Views/Shared/Components/WriterMessages/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca0be51d26d4a74b2a4dd4365d98ecd604a0fd5b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_WriterMessages_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<System.Collections.Generic.List<Entities.Concrete.Message>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("profile-pic"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "C:\Users\sahin\Desktop\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Shared\Components\WriterMessages\Default.cshtml"
  
    string messageNotificationText = "";
    if (Model.Count > 1)
        messageNotificationText = Model.Count + " yeni mesajlar";
    else
        messageNotificationText = Model.Count + " yeni mesaj";

    int totalSubstractNumber = 0;
    string totalSubstractText = "";

    void calculateSubstract(DateTime messageSentDate)
    {
        if (DateTime.Now.Subtract(messageSentDate).TotalSeconds < 60)
        {
            totalSubstractNumber = (int) DateTime.Now.Subtract(messageSentDate).TotalSeconds;
            totalSubstractText = totalSubstractNumber + " saniye önce";
        }
        else if (DateTime.Now.Subtract(messageSentDate).TotalMinutes < 60)
        {
            totalSubstractNumber = (int) DateTime.Now.Subtract(messageSentDate).TotalMinutes;
            totalSubstractText = totalSubstractNumber + " dakika önce";
        }
        else if (DateTime.Now.Subtract(messageSentDate).TotalHours < 60)
        {
            totalSubstractNumber = (int) DateTime.Now.Subtract(messageSentDate).TotalHours;
            totalSubstractText = totalSubstractNumber + " saat önce";
        }
        else
        {
            totalSubstractNumber = (int) DateTime.Now.Subtract(messageSentDate).TotalDays;
            totalSubstractText = totalSubstractNumber + " gün önce";
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<a class=\"nav-link count-indicator dropdown-toggle\" id=\"messageDropdown\" href=\"#\" data-toggle=\"dropdown\" aria-expanded=\"false\">\r\n    <i class=\"mdi mdi-email-outline\"></i>\r\n");
            WriteLiteral("</a>\r\n<div class=\"dropdown-menu dropdown-menu-right navbar-dropdown preview-list\" aria-labelledby=\"messageDropdown\">\r\n    <h6 class=\"p-3 mb-0\">Mesajlar</h6>\r\n");
#nullable restore
#line 44 "C:\Users\sahin\Desktop\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Shared\Components\WriterMessages\Default.cshtml"
     foreach (Message message in Model)
    {
    calculateSubstract(message.MessageDateTime);


#line default
#line hidden
#nullable disable
            WriteLiteral("    <a class=\"dropdown-item preview-item\">\r\n        <div class=\"preview-thumbnail\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "23d559cf9acbb902d5837113f577c482efeb0deb6669", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2033, "~/writerProfileImages/", 2033, 22, true);
#nullable restore
#line 50 "C:\Users\sahin\Desktop\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Shared\Components\WriterMessages\Default.cshtml"
AddHtmlAttributeValue("", 2055, message.Sender.WriterImage, 2055, 27, false);

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
            WriteLiteral("\r\n        </div>\r\n        <div class=\"preview-item-content d-flex align-items-start flex-column justify-content-center\">\r\n            <h6 class=\"preview-subject ellipsis mb-1 font-weight-normal\">");
#nullable restore
#line 53 "C:\Users\sahin\Desktop\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Shared\Components\WriterMessages\Default.cshtml"
                                                                    Write(message.Sender.WriterUsername);

#line default
#line hidden
#nullable disable
            WriteLiteral(" mesaj gönderdi</h6>\r\n            <p class=\"text-gray mb-0\">");
#nullable restore
#line 54 "C:\Users\sahin\Desktop\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Shared\Components\WriterMessages\Default.cshtml"
                                 Write(totalSubstractText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n    </a>\r\n");
#nullable restore
#line 57 "C:\Users\sahin\Desktop\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Shared\Components\WriterMessages\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"dropdown-divider\"></div>\r\n    <h6 class=\"p-3 mb-0 text-center\"> ");
#nullable restore
#line 59 "C:\Users\sahin\Desktop\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Shared\Components\WriterMessages\Default.cshtml"
                                 Write(messageNotificationText);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h6>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<System.Collections.Generic.List<Entities.Concrete.Message>> Html { get; private set; }
    }
}
#pragma warning restore 1591
