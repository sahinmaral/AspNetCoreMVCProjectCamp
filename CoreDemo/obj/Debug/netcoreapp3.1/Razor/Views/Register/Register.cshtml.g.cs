#pragma checksum "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Register\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7c5b6af67c4c7afe9bd23dd61d03d76952945de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Register_Register), @"mvc.1.0.view", @"/Views/Register/Register.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7c5b6af67c4c7afe9bd23dd61d03d76952945de", @"/Views/Register/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca0be51d26d4a74b2a4dd4365d98ecd604a0fd5b", @"/Views/_ViewImports.cshtml")]
    public class Views_Register_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CoreDemo.Models.UserSignUpViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Register\Register.cshtml"
  
    ViewData["Title"] = "Kayıt Ol";
    Layout = "_UserLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<section class=\"main-content-w3layouts-agileits\">\r\n        <div class=\"container\">\r\n            <h3 class=\"tittle\">Yazar Kayit Sayfasi</h3>\r\n            <div class=\"inner-sec\">\r\n                <div class=\"login p-5 bg-light mx-auto mw-100\">\r\n");
#nullable restore
#line 14 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Register\Register.cshtml"
                     using (Html.BeginForm("Register", "Register", FormMethod.Post , new {enctype="multipart/form-data"}))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"form-row\">\r\n                            <div class=\"form-group col-md-6 mb-3\">\r\n                                ");
#nullable restore
#line 18 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Register\Register.cshtml"
                           Write(Html.LabelFor(x=>x.NameSurname,"Ad Soyad"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                ");
#nullable restore
#line 19 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Register\Register.cshtml"
                           Write(Html.TextBoxFor(x=>x.NameSurname , new {@class="form-control mb-2" , placeholder="Ad Soyad"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                ");
#nullable restore
#line 20 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Register\Register.cshtml"
                           Write(Html.ValidationMessageFor(x => x.NameSurname, "", new { @style = "font-weight: bold; color: darkred;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                            \r\n                            <div class=\"form-group col-md-6 mb-3\">\r\n                                ");
#nullable restore
#line 24 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Register\Register.cshtml"
                           Write(Html.LabelFor(x=>x.Username,"Kullanici adi"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                ");
#nullable restore
#line 25 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Register\Register.cshtml"
                           Write(Html.TextBoxFor(x=>x.Username , new {@class="form-control mb-2" , placeholder="Kullanici adi"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                ");
#nullable restore
#line 26 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Register\Register.cshtml"
                           Write(Html.ValidationMessageFor(x => x.Username, "", new { @style = "font-weight: bold; color: darkred;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n");
            WriteLiteral("                        <div class=\"form-row\">\r\n                            <div class=\"col-md-6 mb-3\">\r\n                                ");
#nullable restore
#line 32 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Register\Register.cshtml"
                           Write(Html.LabelFor(x=>x.Mail,"E-mail"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                ");
#nullable restore
#line 33 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Register\Register.cshtml"
                           Write(Html.TextBoxFor(x=>x.Mail , new {@class="form-control mb-2" , placeholder="E-mail"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                ");
#nullable restore
#line 34 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Register\Register.cshtml"
                           Write(Html.ValidationMessageFor(x => x.Mail, "", new { @style = "font-weight: bold; color: darkred;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                            \r\n                            <div class=\"col-md-6 mb-3\">\r\n                                ");
#nullable restore
#line 38 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Register\Register.cshtml"
                           Write(Html.LabelFor(x=>x.ProfileImage,"Profil Fotografi"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                ");
#nullable restore
#line 39 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Register\Register.cshtml"
                           Write(Html.TextBoxFor(x=>x.ProfileImage , new {@class="form-control mb-2" , placeholder="Profil Fotografi" , type="file"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                ");
#nullable restore
#line 40 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Register\Register.cshtml"
                           Write(Html.ValidationMessageFor(x => x.ProfileImage, "", new { @style = "font-weight: bold; color: darkred;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n");
            WriteLiteral("                        <div class=\"form-row\">\r\n                            <div class=\"form-group col-md-6\">\r\n                                ");
#nullable restore
#line 46 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Register\Register.cshtml"
                           Write(Html.LabelFor(x=>x.Password,"Sifre"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                ");
#nullable restore
#line 47 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Register\Register.cshtml"
                           Write(Html.PasswordFor(x=>x.Password , new {@class="form-control" , placeholder="Sifre"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"form-group col-md-6\">\r\n                                ");
#nullable restore
#line 50 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Register\Register.cshtml"
                           Write(Html.LabelFor(x=>x.ConfirmPassword,"Sifre Tekrar"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                ");
#nullable restore
#line 51 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Register\Register.cshtml"
                           Write(Html.PasswordFor(x=>x.ConfirmPassword , new {@class="form-control mb-2" , placeholder="Sifre Tekrar"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                ");
#nullable restore
#line 52 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Register\Register.cshtml"
                           Write(Html.ValidationMessageFor(x => x.ConfirmPassword, "", new { @style = "font-weight: bold; color: darkred;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n");
            WriteLiteral("                        <div class=\"form-row mb-2\">\r\n                            <div class=\"form-check mb-2 ml-1\">\r\n                                ");
#nullable restore
#line 58 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Register\Register.cshtml"
                           Write(Html.CheckBoxFor(x=>x.IsPoliciesAccepted,new {@class="form-check-input"}));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                <p style=""color: blue; cursor: pointer;"" onclick=""ShowAllPoliciesAlert()"">
                                    <b>Tüm şartları okudum , kabul ediyorum.</b>
                                </p>
                                ");
#nullable restore
#line 62 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Register\Register.cshtml"
                           Write(Html.ValidationMessageFor(x => x.IsPoliciesAccepted, "", new { @style = "font-weight: bold; color: darkred;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n");
            WriteLiteral("                        <button type=\"submit\" id=\"submit-button\" class=\"btn btn-primary submit mb-5\">Kayit ol</button>\r\n");
#nullable restore
#line 68 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Register\Register.cshtml"
                   Write(Html.ValidationSummary(false, "", new { @style = "font-weight: bold; color: darkred;" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 68 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Views\Register\Register.cshtml"
                                                                                                                 

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                </div>
            </div>
        </div>
    </section>

<script>
    function ShowAllPoliciesAlert() {
        swal(""Site Kabul Şartları"", ""Sitemizde verdiğiniz mail adresi üzerinden bilgi ve haber e-postaları spam ölçüsüne varmadan gönderilmeye devam edilecektir. Eğer e-posta bülteninden çıkmak isterseniz mail ileti dizisini durdurabilirsiniz, şifre ve mail adresleriniz şifrelenmiş formatta ve herhangi bir kullanıcının görmeyeceği şekilde veritabanlarımızda saklanmaktadır."");
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CoreDemo.Models.UserSignUpViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591