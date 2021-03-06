#pragma checksum "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Admin\Views\Category\GetCategories.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "593950464d0fb69834384beea790bba15aa12b84"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Category_GetCategories), @"mvc.1.0.view", @"/Areas/Admin/Views/Category/GetCategories.cshtml")]
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
#line 1 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Admin\Views\Category\GetCategories.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Admin\Views\Category\GetCategories.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"593950464d0fb69834384beea790bba15aa12b84", @"/Areas/Admin/Views/Category/GetCategories.cshtml")]
    public class Areas_Admin_Views_Category_GetCategories : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<CoreDemo.Models.ReadCategoryViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Admin\Views\Category\GetCategories.cshtml"
  
    ViewBag.Title = "Kategoriler | ";
    Layout = "_AdminLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""row mt-5"">
    <div class=""col-12"">
        <div class=""ibox "">
            <div class=""ibox-content"">
                <table class=""table"">
                    <thead>
                        <tr>
                            <th>#</th>
                            <th>Kategori Ad??</th>
                            <th>Aktif Yap</th>
                            <th>Pasif Yap</th>
                            <th>D??zenle</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 26 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Admin\Views\Category\GetCategories.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 29 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Admin\Views\Category\GetCategories.cshtml"
                               Write(item.CategoryId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 30 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Admin\Views\Category\GetCategories.cshtml"
                               Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 31 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Admin\Views\Category\GetCategories.cshtml"
                                 if (item.CategoryStatus)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td><a class=\"btn btn-danger disabled text-white\">Aktif Yap</a></td>\r\n                                    <td><a class=\"btn btn-warning text-white\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1243, "\"", 1297, 3);
            WriteAttributeValue("", 1253, "confirmActiveDeactive(true,", 1253, 27, true);
#nullable restore
#line 34 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Admin\Views\Category\GetCategories.cshtml"
WriteAttributeValue("", 1280, item.CategoryId, 1280, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1296, ")", 1296, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Pasif Yap</a></td>\r\n");
#nullable restore
#line 35 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Admin\Views\Category\GetCategories.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td><a class=\"btn btn-danger text-white\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1503, "\"", 1558, 3);
            WriteAttributeValue("", 1513, "confirmActiveDeactive(false,", 1513, 28, true);
#nullable restore
#line 38 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Admin\Views\Category\GetCategories.cshtml"
WriteAttributeValue("", 1541, item.CategoryId, 1541, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1557, ")", 1557, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Aktif Yap</a></td>\r\n                                    <td><a class=\"btn btn-warning text-white disabled\">Pasif Yap</a></td>\r\n");
#nullable restore
#line 40 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Admin\Views\Category\GetCategories.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                <td><a");
            BeginWriteAttribute("href", " href=\"", 1762, "\"", 1816, 2);
            WriteAttributeValue("", 1769, "/Admin/Category/UpdateCategory/", 1769, 31, true);
#nullable restore
#line 42 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Admin\Views\Category\GetCategories.cshtml"
WriteAttributeValue("", 1800, item.CategoryId, 1800, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">D??zenle</a></td>\r\n\r\n                            </tr>\r\n");
#nullable restore
#line 45 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Admin\Views\Category\GetCategories.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<div style=\"margin: auto; width: 50%; margin-left: 40%;\">\r\n    ");
#nullable restore
#line 55 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Admin\Views\Category\GetCategories.cshtml"
Write(Html.PagedListPager(Model, pageNumber => Url.Action("GetCategories", new { page = pageNumber })));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
</div>

<script>

    function confirmActiveDeactive(status, id) {

        if (status === true) {
            swal({
                title: ""Uyar??"",
                text: ""Pasif hale getirmek istedi??inize emin misiniz ?"",
                icon: ""warning"",
                buttons: true,
                dangerMode: true
            })
                .then((willDelete) => {
                    if (willDelete) {
                        swal(""Kategori pasif hale getirildi"", { icon: ""success"" });
                            $.ajax({
                                url: ""/Admin/Category/DisableCategory/"" + id,
                                type: 'GET',
                                success: function () {
                                    window.location.href = ""/Admin/Category/GetCategories"";
                                }
                            });
                    }

                });
        }
        else {
            swal({
                    title: ""Uyar??"",");
            WriteLiteral(@"
                    text: ""Aktif hale getirmek istedi??inize emin misiniz ?"",
                    icon: ""warning"",
                    buttons: true,
                    dangerMode: true
                })
                .then((willDelete) => {
                    if (willDelete) {
                        swal(""Kategori aktif hale getirildi"", { icon: ""success"" });
                        $.ajax({
                            url: ""/Admin/Category/EnableCategory/"" + id,
                            type: 'GET',
                            success: function () {
                                window.location.href = ""/Admin/Category/GetCategories"";
                            }
                        });
                    }

                });
        }


    }
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList<CoreDemo.Models.ReadCategoryViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
