#pragma checksum "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Writer\Views\Blog\MyBlog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5fff8a4b6965c2b794562c772a756af995b616ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Writer_Views_Blog_MyBlog), @"mvc.1.0.view", @"/Areas/Writer/Views/Blog/MyBlog.cshtml")]
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
#line 1 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Writer\Views\_ViewImports.cshtml"
using CoreDemo.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Writer\Views\_ViewImports.cshtml"
using CoreDemo.Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Writer\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Writer\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Writer\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Writer\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.TagHelpers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5fff8a4b6965c2b794562c772a756af995b616ff", @"/Areas/Writer/Views/Blog/MyBlog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33f78ae299ead77344fd22d07d634a9b1b616d06", @"/Areas/Writer/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Writer_Views_Blog_MyBlog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ReadBlogViewModel>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Writer\Views\Blog\MyBlog.cshtml"
  
    ViewData["Title"] = ViewLocalizer["Title"];
    Layout = "_WriterLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 8 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Writer\Views\Blog\MyBlog.cshtml"
  
    string SubStringBlogContent(string content)
    {
        if (content.Length < 15)
        {
            return content;
        }

        return content.Substring(15) + "...";
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n<div class=\"col-lg-12 grid-margin stretch-card\">\n    <div class=\"card\">\n        <div class=\"card-body\">\n            <h4 class=\"card-title\">");
#nullable restore
#line 24 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Writer\Views\Blog\MyBlog.cshtml"
                              Write(ViewLocalizer["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n            <table class=\"table table-bordered\">\n                <thead>\n                    <tr>\n                        <th> # </th>\n                        <th> ");
#nullable restore
#line 29 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Writer\Views\Blog\MyBlog.cshtml"
                        Write(ViewLocalizer["BlogTitle"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\n                        <th> ");
#nullable restore
#line 30 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Writer\Views\Blog\MyBlog.cshtml"
                        Write(ViewLocalizer["Category"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\n                        <th> ");
#nullable restore
#line 31 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Writer\Views\Blog\MyBlog.cshtml"
                        Write(ViewLocalizer["BlogContent"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\n                        <th> ");
#nullable restore
#line 32 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Writer\Views\Blog\MyBlog.cshtml"
                        Write(ViewLocalizer["PublishedDate"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\n                        <th> ");
#nullable restore
#line 33 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Writer\Views\Blog\MyBlog.cshtml"
                        Write(ViewLocalizer["State"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\n                        <th> ");
#nullable restore
#line 34 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Writer\Views\Blog\MyBlog.cshtml"
                        Write(ViewLocalizer["Processes"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\n                    </tr>\n                </thead>\n                <tbody>\n");
#nullable restore
#line 38 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Writer\Views\Blog\MyBlog.cshtml"
                     foreach (ReadBlogViewModel blog in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\n                            <td> ");
#nullable restore
#line 41 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Writer\Views\Blog\MyBlog.cshtml"
                            Write(blog.BlogId);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\n                            <td> ");
#nullable restore
#line 42 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Writer\Views\Blog\MyBlog.cshtml"
                            Write(blog.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\n                            <td> ");
#nullable restore
#line 43 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Writer\Views\Blog\MyBlog.cshtml"
                            Write(blog.CategoryViewModel.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\n                            <td> ");
#nullable restore
#line 44 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Writer\Views\Blog\MyBlog.cshtml"
                            Write(SubStringBlogContent(blog.BlogContent));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\n                            <td> ");
#nullable restore
#line 45 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Writer\Views\Blog\MyBlog.cshtml"
                            Write(blog.BlogCreateDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\n                            <td>\n");
#nullable restore
#line 47 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Writer\Views\Blog\MyBlog.cshtml"
                                 if (blog.BlogStatus)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span class=\"badge badge-success\">");
#nullable restore
#line 49 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Writer\Views\Blog\MyBlog.cshtml"
                                                                 Write(ViewLocalizer["Active"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n");
#nullable restore
#line 50 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Writer\Views\Blog\MyBlog.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span class=\"badge badge-danger\">");
#nullable restore
#line 53 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Writer\Views\Blog\MyBlog.cshtml"
                                                                Write(ViewLocalizer["Passive"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n");
#nullable restore
#line 54 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Writer\Views\Blog\MyBlog.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n                            </td>\n                            <td>\n                                <a");
            BeginWriteAttribute("onclick", " onclick=\"", 2084, "\"", 2126, 3);
            WriteAttributeValue("", 2094, "sendToastrQuestion(", 2094, 19, true);
#nullable restore
#line 59 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Writer\Views\Blog\MyBlog.cshtml"
WriteAttributeValue("", 2113, blog.BlogId, 2113, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2125, ")", 2125, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">");
#nullable restore
#line 59 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Writer\Views\Blog\MyBlog.cshtml"
                                                                                                Write(ViewLocalizer["Delete"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n                                <a");
            BeginWriteAttribute("href", " href=\"", 2214, "\"", 2252, 2);
            WriteAttributeValue("", 2221, "/Writer/UpdateBlog/", 2221, 19, true);
#nullable restore
#line 60 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Writer\Views\Blog\MyBlog.cshtml"
WriteAttributeValue("", 2240, blog.BlogId, 2240, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\">");
#nullable restore
#line 60 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Writer\Views\Blog\MyBlog.cshtml"
                                                                                             Write(ViewLocalizer["Edit"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n                            </td>\n                        </tr>\n");
#nullable restore
#line 63 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Writer\Views\Blog\MyBlog.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\n            </table>\n        </div>\n    </div>\n</div>\n\n<script>\n\n\n    function sendToastrQuestion(id) {\n        swal(\"");
#nullable restore
#line 74 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Writer\Views\Blog\MyBlog.cshtml"
         Write(ViewLocalizer["ConfirmDeletingBlog"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\", {\n            buttons: {\n                yes: {\n                    text: \"");
#nullable restore
#line 77 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Writer\Views\Blog\MyBlog.cshtml"
                      Write(ViewLocalizer["Yes"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\",\n                    value: \"true\",\n                },\n                no: {\n                    text: \"");
#nullable restore
#line 81 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Writer\Views\Blog\MyBlog.cshtml"
                      Write(ViewLocalizer["No"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\",\n                    value: \"false\",\n                },\n            },\n        })\n            .then(async (value) => {\n\n                switch (value) {\n                    case \"true\":\n                        toastr.success(\"");
#nullable restore
#line 90 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Writer\Views\Blog\MyBlog.cshtml"
                                   Write(ViewLocalizer["SuccessfullyDeletedBlog"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""", """", {
                            ""positionClass"": ""toast-bottom-right""
                        });
                        //Just like Thread.Sleep
                        await new Promise(resolve => setTimeout(resolve, 3000));
                        window.location.href = ""/Writer/DeleteBlog/"" + id
                        break;
                    case ""false"":
                        break;
                }
            });
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ReadBlogViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591