#pragma checksum "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Admin\Views\Blog\GetBlogs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44311810c797638fb2aed19e25291a576f5cc854"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Blog_GetBlogs), @"mvc.1.0.view", @"/Areas/Admin/Views/Blog/GetBlogs.cshtml")]
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
#line 1 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Admin\Views\Blog\GetBlogs.cshtml"
using CoreDemo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44311810c797638fb2aed19e25291a576f5cc854", @"/Areas/Admin/Views/Blog/GetBlogs.cshtml")]
    public class Areas_Admin_Views_Blog_GetBlogs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CoreDemo.Models.ReadBlogViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("blog-image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Admin\Views\Blog\GetBlogs.cshtml"
  
    ViewBag.Title = "Bloglar ";
    Layout = "_AdminLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n");
#nullable restore
#line 10 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Admin\Views\Blog\GetBlogs.cshtml"
     foreach (ReadBlogViewModel blog in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-md-3\">\r\n            <div class=\"ibox\">\r\n                <div class=\"ibox-content product-box\">\r\n\r\n                    <div class=\"product-imitation\" style=\"height:400px\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "44311810c797638fb2aed19e25291a576f5cc8544469", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 468, "~/images/", 468, 9, true);
#nullable restore
#line 17 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Admin\Views\Blog\GetBlogs.cshtml"
AddHtmlAttributeValue("", 477, blog.BlogThumbnailImage, 477, 24, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"product-desc\">\r\n                        <span class=\"product-price\">\r\n                            Yazar : ");
#nullable restore
#line 21 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Admin\Views\Blog\GetBlogs.cshtml"
                               Write(blog.UserViewModel.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </span>\r\n                        <small class=\"text-muted\">");
#nullable restore
#line 23 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Admin\Views\Blog\GetBlogs.cshtml"
                                             Write(blog.CategoryViewModel.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                        <a href=\"#\" class=\"product-name\"> ");
#nullable restore
#line 24 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Admin\Views\Blog\GetBlogs.cshtml"
                                                     Write(blog.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\r\n                        <div class=\"small m-t-xs\">\r\n                            ");
#nullable restore
#line 27 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Admin\Views\Blog\GetBlogs.cshtml"
                       Write(blog.CommentViewModels.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Yorum\r\n                            ");
#nullable restore
#line 28 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Admin\Views\Blog\GetBlogs.cshtml"
                       Write(blog.CommentViewModels.Count(x => x.LikeOrDislikeStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral(" Begenme\r\n                        </div>\r\n                        <div class=\"m-t text-right\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1258, "\"", 1310, 2);
            WriteAttributeValue("", 1265, "/Admin/Comment/GetCommentsByBlog/", 1265, 33, true);
#nullable restore
#line 31 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Admin\Views\Blog\GetBlogs.cshtml"
WriteAttributeValue("", 1298, blog.BlogId, 1298, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-xs btn text-white btn-warning\">Yorumlari Goster</a>\r\n                            <a");
            BeginWriteAttribute("onclick", " onclick=\"", 1410, "\"", 1452, 3);
            WriteAttributeValue("", 1420, "sendToastrQuestion(", 1420, 19, true);
#nullable restore
#line 32 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Admin\Views\Blog\GetBlogs.cshtml"
WriteAttributeValue("", 1439, blog.BlogId, 1439, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1451, ")", 1451, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-xs btn text-white btn-danger\">Blogu Sil </a>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1545, "\"", 1591, 2);
            WriteAttributeValue("", 1552, "/Admin/Blog/GetBlogDetails/", 1552, 27, true);
#nullable restore
#line 33 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Admin\Views\Blog\GetBlogs.cshtml"
WriteAttributeValue("", 1579, blog.BlogId, 1579, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-xs btn-outline btn-primary\">Detaya Git <i class=\"fa fa-long-arrow-right\"></i> </a>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 39 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Admin\Views\Blog\GetBlogs.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>

<script>


    function sendToastrQuestion(id) {
        swal(""Blogu silmek istediğinize emin misiniz"", {
            buttons: {
                yes: {
                    text: ""Evet"",
                    value: ""true"",
                },
                no: {
                    text: ""Hayır"",
                    value: ""false"",
                },
            },
        })
            .then(async (value) => {

                switch (value) {
                    case ""true"":
                        toastr.success(""Seçtiğiniz blog silinmiştir"", """", {
                            ""positionClass"": ""toast-bottom-right""
                        });
                        //Just like Thread.Sleep
                        await new Promise(resolve => setTimeout(resolve, 3000));
                        window.location.href = ""/Admin/Blog/DeleteBlog/"" + id
                        break;
                    case ""false"":
                        break;
                }
          ");
            WriteLiteral("  });\r\n    }\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CoreDemo.Models.ReadBlogViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
