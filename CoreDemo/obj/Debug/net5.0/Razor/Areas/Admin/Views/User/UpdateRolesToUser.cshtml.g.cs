#pragma checksum "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Admin\Views\User\UpdateRolesToUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "027ee17216d8c11d463623ec6ebb6ba613dcf7f5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_User_UpdateRolesToUser), @"mvc.1.0.view", @"/Areas/Admin/Views/User/UpdateRolesToUser.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"027ee17216d8c11d463623ec6ebb6ba613dcf7f5", @"/Areas/Admin/Views/User/UpdateRolesToUser.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_User_UpdateRolesToUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CoreDemo.Areas.Admin.Models.UserRoleViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Admin\Views\User\UpdateRolesToUser.cshtml"
  
    ViewBag.Title = @Model.UserViewModel.Username + " kullanici adli kullacinin rollerini duzenleme";
    Layout = "_AdminLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Admin\Views\User\UpdateRolesToUser.cshtml"
 using (Html.BeginForm("UpdateRolesToUser", "User", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Admin\Views\User\UpdateRolesToUser.cshtml"
Write(Html.HiddenFor(x => x.UserViewModel.UserId));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-12 grid-margin stretch-card\">\r\n        <div class=\"card\">\r\n            <div class=\"card-body\">\r\n                <h2 class=\"card-title\">");
#nullable restore
#line 15 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Admin\Views\User\UpdateRolesToUser.cshtml"
                                  Write(Model.UserViewModel.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral(" kullanici adli kullacinin rollerini duzenleme</h2>\r\n");
#nullable restore
#line 16 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Admin\Views\User\UpdateRolesToUser.cshtml"
                 for (int i = 0; i < Model.RoleViewModels.Count; i++)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"form-check\">\r\n                        ");
#nullable restore
#line 19 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Admin\Views\User\UpdateRolesToUser.cshtml"
                   Write(Html.HiddenFor(x => x.RoleViewModels[i].RoleName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 20 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Admin\Views\User\UpdateRolesToUser.cshtml"
                   Write(Html.CheckBoxFor(x => x.RoleViewModels[i].IsInRole, new { @class = "form-check-input", style = "width: 20px; height: 20px;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <span style=\"font-size:20px\">\r\n                            ");
#nullable restore
#line 22 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Admin\Views\User\UpdateRolesToUser.cshtml"
                       Write(Html.DisplayFor(x => x.RoleViewModels[i].RoleName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </span>\r\n                    </div>\r\n");
#nullable restore
#line 25 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Admin\Views\User\UpdateRolesToUser.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <button type=\"submit\" class=\"btn btn-gradient-primary mr-2 w-100 mt-3\" style=\"height:40px\">Guncelle</button>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 32 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Admin\Views\User\UpdateRolesToUser.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CoreDemo.Areas.Admin.Models.UserRoleViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591