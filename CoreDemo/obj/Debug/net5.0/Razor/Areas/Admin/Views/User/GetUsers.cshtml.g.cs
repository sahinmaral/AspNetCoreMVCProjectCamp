#pragma checksum "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Admin\Views\User\GetUsers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b7ac484bd6153e83956b12ab646d23d2b1fff06f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_User_GetUsers), @"mvc.1.0.view", @"/Areas/Admin/Views/User/GetUsers.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7ac484bd6153e83956b12ab646d23d2b1fff06f", @"/Areas/Admin/Views/User/GetUsers.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_User_GetUsers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Admin\Views\User\GetUsers.cshtml"
  
    ViewBag.Title = "Kullanicilar ";
    Layout = "_AdminLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h2>Kullanici Ajax İşlemleri</h2>
<br />

<button type=""button"" id=""btnGetUsers"" class=""btn btn-primary"">Kullanicilari Listele</button>
<button type=""button"" id=""btnShowUserIdText""
        class=""btn btn-primary"">
    Kullanicinin ID'ye göre Listele
</button>
<br />
<br />

<div id=""userList"">
    <label class=""mt-2"">
        Buraya kullanicilar veya kullanici gelecek
    </label>
</div>

<div id=""userIdDiv"" style=""display: none; "">
    <input type=""text""
           id=""userIdText""
           placeholder=""Kullanicinin ID'sini giriniz""
           class=""form-control border border-dark mb-2""
           style=""width: 200px"" />
    <button type=""button"" id=""btnGetUser""
            class=""btn btn-primary"">
        Listele
    </button>
</div>


");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n\r\n        window.onload = function () {\r\n            ");
#nullable restore
#line 41 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Admin\Views\User\GetUsers.cshtml"
       Write(Html.Raw(TempData["Message"]));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
        }

        toastr.options.progressBar = true;
        toastr.options.positionClass = ""toast-bottom-right"";

        GetUsers = function () {
            var users = {};

            $.ajax({
                async: false,
                contentType: ""application/json"",
                dataType: ""json"",
                type: ""GET"",
                url: ""/Admin/User/GetUsersJson"",
                success: function (data) {
                    users = jQuery.parseJSON(data);
                }
            });

            return users;
        }

        GetUser = function (id) {
            var foundUser = {};

            $.ajax({
                async: false,
                contentType: ""application/json"",
                dataType: ""json"",
                type: ""GET"",
                url: ""/Admin/User/GetUserByIdJson?id="" + id,
                success: function (data) {
                    foundUser = jQuery.parseJSON(data);
                }
            });

    ");
                WriteLiteral(@"        return foundUser;
        }

        LoadToTableGetUsers = function () {

            var users = GetUsers();

            var tableHTML =
                ""<table class='table table-bordered'>"" +
                ""<tr> "" +
                ""<th> # </td>"" +
                ""<th> Kullanici Adı Soyadi</td>"" +
                ""<th> Kullanici Kullanıcı Adı </td>"" +
                ""<th> Kullanici Islemleri </td>"" +
                //""<th> Yazarın Durumu </td>"" +
                //""<th> Yazarı Banla / Banını Kaldır </td>"" +
                ""</tr>"";
            for (var i = 0; i < users.length; i++) {
                tableHTML += ""<tr>"";
                tableHTML += ""<td>"" + users[i].UserId + ""</td>"";
                tableHTML += ""<td>"" + users[i].NameSurname + ""</td>"";
                tableHTML += ""<td>"" + users[i].Username + ""</td>"";
                tableHTML += ""<td>"";
                tableHTML += ""<a href='/Admin/User/UpdateRolesToUser/"" + users[i].UserId + ""' class='btn btn-success'");
                WriteLiteral(@">Kullanicinin Rollerini Getir</a>"";
                tableHTML += ""</td> "";
                //if (!writers[i].LockoutEnabled)
                //    tableHTML += ""<td>Temiz</td>"";
                //else
                //    tableHTML += ""<td>Banlı</td>"";

                //tableHTML += ""<td> <button type=button onClick=EnableOrDisableWriter("" + writers[i].UserId + "") class='btn btn-warning' > Yazarı Banla / Banını Kaldır</button > </td > "";
                tableHTML += ""</tr>"";
            }

            tableHTML += ""</table>"";

            $(""#userList"").html(tableHTML);
        }

        LoadToTableGetUser = function () {

            var id = $(""#userIdText"").val();

            if (id === """")
                toastr.error('Kullanici Id kısmını doldurunuz');
            else {
                var user = GetUser(id);

                var tableHTML =
                    ""<table class='table table-bordered'>"" +
                    ""<tr> "" +
                    ""<th> # </td>"" +
   ");
                WriteLiteral(@"                 ""<th> Kullanici Adı Soyadi</td>"" +
                    ""<th> Kullanici Kullanıcı Adı </td>"" +
                    ""<th> Kullanici Islemleri </td>"" +
                    //""<th> Yazarın Durumu </td>"" +
                    //""<th> Yazarı Banla / Banını Kaldır </td>"" +
                    ""</tr>"";
                tableHTML += ""<tr>"";
                tableHTML += ""<td>"" + user.UserId + ""</td>"";
                tableHTML += ""<td>"" + user.NameSurname + ""</td>"";
                tableHTML += ""<td>"" + user.Username + ""</td>"";
                tableHTML += ""<td>"";
                tableHTML += ""<a href='/Admin/User/UpdateRolesToUser/"" + user.UserId + ""' class='btn btn-success'>Kullanicinin Rollerini Getir</a>"";
                tableHTML += ""</td> "";
                //if (!foundWriter.LockoutEnabled)
                //    tableHTML += ""<td>Temiz</td>"";
                //else
                //    tableHTML += ""<td>Banlı</td>"";
                //tableHTML += ""<td> <button type=button onCli");
                WriteLiteral(@"ck=EnableOrDisableWriter("" + foundWriter.UserId + "") class='btn btn-warning' > Yazarı Banla / Banını Kaldır</button > </td > "";
                tableHTML += ""</tr>"";
                tableHTML += ""</table>"";

                $(""#userList"").html(tableHTML);
            }


        }

        EnableOrDisableUser = function (id) {
            $.ajax({
                async: false,
                contentType: ""application/json"",
                dataType: ""json"",
                type: ""POST"",
                url: ""/Admin/User/EnableOrDisableUser?id="" + id,
            }).then(
                toastr.success('Kullanici banlama / ban kaldırma işlemi başarılı')
            );

            var element = document.getElementById(""userIdDiv"");

            if (element.style.display === ""none"")
                LoadToTableGetUsers();
            else
                LoadToTableGetUser();
        }

        $(""#btnShowUserIdText"").click(function () {


            document.getElementById(""use");
                WriteLiteral(@"rList"").innerHTML = ""<label class='mt-2'>Buraya kullanicilar veya kullanici gelecek</label>"";

            var div = document.getElementById(""userIdDiv"");

            if (div.style.display === ""block"") {
                div.style.display = ""none"";
            } else {

                div.style.display = ""block"";
            }


        });

        $(""#btnGetUsers"").click(function () {

            document.getElementById(""userList"").innerHTML = """";

            var element = document.getElementById(""userIdDiv"");
            element.style.display = ""none"";
            LoadToTableGetUsers();
        });

        $(""#btnGetUser"").click(function () {
            LoadToTableGetUser();
        });


    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591