#pragma checksum "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Admin\Views\Comment\UpdateComment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d91082dd3729e7f45c9515e50006144c0e755239"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Comment_UpdateComment), @"mvc.1.0.view", @"/Areas/Admin/Views/Comment/UpdateComment.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d91082dd3729e7f45c9515e50006144c0e755239", @"/Areas/Admin/Views/Comment/UpdateComment.cshtml")]
    public class Areas_Admin_Views_Comment_UpdateComment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CoreDemo.Areas.Admin.Models.UpdateCommentViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Admin\Views\Comment\UpdateComment.cshtml"
  
    ViewBag.Title = "Yorum Duzenleme ";
    Layout = "_AdminLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"col-12 grid-margin stretch-card\">\r\n    <div class=\"card\">\r\n        <div class=\"card-body\">\r\n            <h3 class=\"card-title\" style=\"margin-bottom:3em\">Yorum Duzenleme</h3>\r\n");
#nullable restore
#line 12 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Admin\Views\Comment\UpdateComment.cshtml"
             using (Html.BeginForm("UpdateComment", "Comment", FormMethod.Post))
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Admin\Views\Comment\UpdateComment.cshtml"
           Write(Html.HiddenFor(x => x.CommentId));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Admin\Views\Comment\UpdateComment.cshtml"
           Write(Html.HiddenFor(x => x.BlogId));

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"form-group\">\r\n                    <label>Baslik</label>\r\n                    ");
#nullable restore
#line 19 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Admin\Views\Comment\UpdateComment.cshtml"
               Write(Html.TextBoxFor(x => x.BlogTitle, new { @class = "form-control", style = "border:1px solid black", disabled = true }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n");
            WriteLiteral("                <div class=\"form-group\">\r\n                    <label>Yorum</label>\r\n                    ");
#nullable restore
#line 24 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Admin\Views\Comment\UpdateComment.cshtml"
               Write(Html.TextAreaFor(x => x.CommentAbout, new { @class = "form-control", style = "border:1px solid black", placeholder = "Yorum", rows = "4" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 25 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Admin\Views\Comment\UpdateComment.cshtml"
               Write(Html.ValidationMessageFor(x => x.CommentAbout, "", new { style = "color:darkred" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n");
            WriteLiteral("                <button type=\"submit\" class=\"btn btn-gradient-primary mr-2 w-100\" style=\"height:50px\">Guncelle</button>\r\n");
#nullable restore
#line 29 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Admin\Views\Comment\UpdateComment.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CoreDemo.Areas.Admin.Models.UpdateCommentViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
