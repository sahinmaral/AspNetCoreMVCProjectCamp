#pragma checksum "/home/sahinmaral/Desktop/Projects/AspNetCoreMVCProjectCamp/CoreDemo/Views/Blog/AddComment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1df1b323d95444e118b3c04989d9f85c0726c97"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_AddComment), @"mvc.1.0.view", @"/Views/Blog/AddComment.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1df1b323d95444e118b3c04989d9f85c0726c97", @"/Views/Blog/AddComment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca0be51d26d4a74b2a4dd4365d98ecd604a0fd5b", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_AddComment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CreateCommentViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n\n<h4>Yorum Bırak</h4>\n<div class=\"comment-bottom\">\n");
#nullable restore
#line 7 "/home/sahinmaral/Desktop/Projects/AspNetCoreMVCProjectCamp/CoreDemo/Views/Blog/AddComment.cshtml"
     using (Html.BeginForm("AddComment","Blog",FormMethod.Post))
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/sahinmaral/Desktop/Projects/AspNetCoreMVCProjectCamp/CoreDemo/Views/Blog/AddComment.cshtml"
   Write(Html.HiddenFor(x=>x.BlogId));

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/home/sahinmaral/Desktop/Projects/AspNetCoreMVCProjectCamp/CoreDemo/Views/Blog/AddComment.cshtml"
   Write(Html.TextAreaFor(x=>x.CommentAbout , new {@class="form-control" , placeholder="Mesaj..."}));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <button id=\"addCommentButton\" class=\"btn btn-primary\" type=\"submit\">Gönder</button>\n");
#nullable restore
#line 13 "/home/sahinmaral/Desktop/Projects/AspNetCoreMVCProjectCamp/CoreDemo/Views/Blog/AddComment.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n</div>\n\n<script>\n\n    $(\"addCommentButton\").click(function() {\n        $.ajax({\n            url: \'");
#nullable restore
#line 22 "/home/sahinmaral/Desktop/Projects/AspNetCoreMVCProjectCamp/CoreDemo/Views/Blog/AddComment.cshtml"
             Write(Url.Action("AddComment","Blog"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\n            type: \'POST\',\n            dataType: \'json\',\n            data: { ");
#nullable restore
#line 25 "/home/sahinmaral/Desktop/Projects/AspNetCoreMVCProjectCamp/CoreDemo/Views/Blog/AddComment.cshtml"
               Write(Model);

#line default
#line hidden
#nullable disable
            WriteLiteral(" }\n        });\n    })\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CreateCommentViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
