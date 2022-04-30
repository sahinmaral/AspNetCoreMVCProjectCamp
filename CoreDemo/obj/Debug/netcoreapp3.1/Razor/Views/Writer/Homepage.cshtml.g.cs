#pragma checksum "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Writer\Homepage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d1ab935921ccea056eae3c5f092c9295d5c38e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Writer_Homepage), @"mvc.1.0.view", @"/Views/Writer/Homepage.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d1ab935921ccea056eae3c5f092c9295d5c38e5", @"/Views/Writer/Homepage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca0be51d26d4a74b2a4dd4365d98ecd604a0fd5b", @"/Views/_ViewImports.cshtml")]
    public class Views_Writer_Homepage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ReadUserViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-sm rounded-circle mr-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Writer\Homepage.cshtml"
  
    ViewData["Title"] = "Anasayfa";
    Layout = "_WriterLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n<div class=\"main-panel\">\n    <div class=\"content-wrapper\">\n    \n        <div class=\"row\">\n            \n            ");
#nullable restore
#line 14 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Writer\Homepage.cshtml"
       Write(await Component.InvokeAsync("WriterStatistics",new {currentWriterId = @Model.UserId}));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" 
           
        </div>
        <div class=""row"">
            <div class=""col-12 grid-margin"">
                <div class=""card"">
                    <div class=""card-body"">
                        <h4 class=""card-title"">Son yazılan on bloglarınız</h4>
                        <div class=""table-responsive"">
                            <table class=""table"">
                                <thead>
                                <tr>
                                    <th> # </th>
                                    <th> Başlık resmi </th>
                                    <th> Başlık adı </th>
                                    <th> Kategori </th>
                                    <th> Yayınlandığı tarih </th>
                                    <th> Detaylar </th>
                                </tr>
                                </thead>
                                <tbody>
                                ");
#nullable restore
#line 35 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Writer\Homepage.cshtml"
                           Write(await Component.InvokeAsync("LatestTenPostsToWriter", new { writerId = @Model.UserId }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        
        <div class=""row"">
            <div class=""col-12 grid-margin stretch-card"">
                <div class=""card"">
                    <h4 class=""card-title mt-5 ml-5"">Hakkınızda</h4>
                    <div class=""card-body"">
                        <div class=""d-flex"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4d1ab935921ccea056eae3c5f092c9295d5c38e56131", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1843, "~/images/", 1843, 9, true);
#nullable restore
#line 50 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Writer\Homepage.cshtml"
AddHtmlAttributeValue("", 1852, Model.ImageUrl, 1852, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                            <div class=\"mb-0 flex-grow\">\n                                <h5 class=\"mr-2 mb-2\">");
#nullable restore
#line 52 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Writer\Homepage.cshtml"
                                                 Write(Model.NameSurname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 52 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Writer\Homepage.cshtml"
                                                                      Write(Model.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                                <p class=\"mb-0 font-weight-light\">\n                                    ");
#nullable restore
#line 54 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Writer\Homepage.cshtml"
                               Write(Model.UserAbout);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </p>
                            </div>
                            <div class=""ml-auto"">
                                <a href=""/Writer/ChangeProfile"">
                                    <i class=""mdi mdi-settings-outline text-muted"">
                                    </i>
                                </a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    

    <!-- content-wrapper ends -->
    <!-- partial:partials/_footer.html -->
    <!--<footer class=""footer"">
        <div class=""container-fluid clearfix"">
            <span class=""text-muted d-block text-center text-sm-left d-sm-inline-block"">Copyright © bootstrapdash.com 2020</span>
            <span class=""float-none float-sm-right d-block mt-1 mt-sm-0 text-center""> Free <a href=""https://www.bootstrapdash.com/bootstrap-admin-template/"" target=""_blank"">Bootstrap admin templates </a> from Bootstrapdas");
            WriteLiteral("h.com</span>\n        </div>\n    </footer>-->\n    <!-- partial -->\n    \n\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ReadUserViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
