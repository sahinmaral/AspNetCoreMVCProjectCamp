#pragma checksum "/home/sahinmaral/Desktop/Projects/AspNetCoreMVCProjectCamp/CoreDemo/Views/Blog/GetCommentsByBlog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "50211f7af8dc9e824883b1c33ab6b833ca47ea14"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_GetCommentsByBlog), @"mvc.1.0.view", @"/Views/Blog/GetCommentsByBlog.cshtml")]
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
#line 1 "/home/sahinmaral/Desktop/Projects/AspNetCoreMVCProjectCamp/CoreDemo/Views/_ViewImports.cshtml"
using CoreDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/sahinmaral/Desktop/Projects/AspNetCoreMVCProjectCamp/CoreDemo/Views/_ViewImports.cshtml"
using CoreDemo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50211f7af8dc9e824883b1c33ab6b833ca47ea14", @"/Views/Blog/GetCommentsByBlog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca0be51d26d4a74b2a4dd4365d98ecd604a0fd5b", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_GetCommentsByBlog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ReadCommentViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<h4>Yorumlar</h4>\n<div class=\"media\">\n    <div class=\"media-body\">\n                    \n");
#nullable restore
#line 7 "/home/sahinmaral/Desktop/Projects/AspNetCoreMVCProjectCamp/CoreDemo/Views/Blog/GetCommentsByBlog.cshtml"
         foreach (ReadCommentViewModel comment in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"media mt-3\">\n");
            WriteLiteral("                <div class=\"media-body\">\n                    <h5 class=\"mt-0\">");
#nullable restore
#line 14 "/home/sahinmaral/Desktop/Projects/AspNetCoreMVCProjectCamp/CoreDemo/Views/Blog/GetCommentsByBlog.cshtml"
                                Write(comment.WriterViewModel.WriterUsername);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                    <p>\n                        ");
#nullable restore
#line 16 "/home/sahinmaral/Desktop/Projects/AspNetCoreMVCProjectCamp/CoreDemo/Views/Blog/GetCommentsByBlog.cshtml"
                   Write(comment.CommentAbout);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </p>\n                </div>\n            </div>\n");
#nullable restore
#line 20 "/home/sahinmaral/Desktop/Projects/AspNetCoreMVCProjectCamp/CoreDemo/Views/Blog/GetCommentsByBlog.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    \n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ReadCommentViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591