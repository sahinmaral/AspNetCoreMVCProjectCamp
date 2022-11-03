#pragma checksum "C:\Users\sahin\OneDrive\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Admin\Views\User\GetUsers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e2f45fee3dbcc4b500012e18cc2160670c861ca2"
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
#nullable restore
#line 1 "C:\Users\sahin\OneDrive\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Admin\Views\_ViewImports.cshtml"
using CoreDemo.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sahin\OneDrive\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Admin\Views\_ViewImports.cshtml"
using CoreDemo.Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\sahin\OneDrive\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\sahin\OneDrive\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\sahin\OneDrive\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Admin\Views\_ViewImports.cshtml"
using CoreDemo.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\sahin\OneDrive\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2f45fee3dbcc4b500012e18cc2160670c861ca2", @"/Areas/Admin/Views/User/GetUsers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3706e769433d4528e3068590047afccda24fe0f8", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_User_GetUsers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\sahin\OneDrive\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Admin\Views\User\GetUsers.cshtml"
  
    ViewBag.Title = @ViewLocalizer["Title"];
    Layout = "_AdminLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>");
#nullable restore
#line 6 "C:\Users\sahin\OneDrive\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Admin\Views\User\GetUsers.cshtml"
Write(ViewLocalizer["PageTitle"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<br />\r\n\r\n<button type=\"button\" id=\"btnGetUsers\" class=\"btn btn-primary\">");
#nullable restore
#line 9 "C:\Users\sahin\OneDrive\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Admin\Views\User\GetUsers.cshtml"
                                                          Write(ViewLocalizer["ListUsers"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n<button type=\"button\" id=\"btnShowUserIdText\"\r\n        class=\"btn btn-primary\">\r\n    ");
#nullable restore
#line 12 "C:\Users\sahin\OneDrive\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Admin\Views\User\GetUsers.cshtml"
Write(ViewLocalizer["ListUsersByUsername"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</button>\r\n<br />\r\n<br />\r\n\r\n<div id=\"userList\">\r\n    <label class=\"mt-2\">\r\n        ");
#nullable restore
#line 19 "C:\Users\sahin\OneDrive\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Admin\Views\User\GetUsers.cshtml"
   Write(ViewLocalizer["ListAreaInfoText"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </label>\r\n</div>\r\n\r\n<div id=\"userIdDiv\" style=\"display: none; \">\r\n    <input type=\"text\"\r\n           id=\"userUsernameText\"");
            BeginWriteAttribute("placeholder", "\r\n           placeholder=\"", 603, "\"", 660, 1);
#nullable restore
#line 26 "C:\Users\sahin\OneDrive\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Admin\Views\User\GetUsers.cshtml"
WriteAttributeValue("", 629, ViewLocalizer["EnterUsername"], 629, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n           class=\"form-control border border-dark mb-2\"\r\n           style=\"width: 200px\" />\r\n    <button type=\"button\" id=\"btnGetUser\"\r\n            class=\"btn btn-primary\">\r\n        ");
#nullable restore
#line 31 "C:\Users\sahin\OneDrive\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Admin\Views\User\GetUsers.cshtml"
   Write(ViewLocalizer["ListButtonText"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </button>\r\n</div>\r\n\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n\r\n        window.onload = function () {\r\n        ");
#nullable restore
#line 40 "C:\Users\sahin\OneDrive\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Admin\Views\User\GetUsers.cshtml"
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

        GetUsersByUsername = function (username) {
            var foundUser = {};

            $.ajax({
                async: false,
                contentType: ""application/json"",
                dataType: ""json"",
                type: ""GET"",
                url: ""/Admin/User/GetUsersByUsernameJson?username="" + username,
                success: function (data) {
                    foundUser = jQuery.parseJSO");
                WriteLiteral(@"N(data);
                }
            });

            return foundUser;
        }

        LoadToTableGetUsers = function () {

            var users = GetUsers();

            var tableHTML =
                ""<table class='table table-bordered'>"" +
                ""<tr> "" +
                ""<th> ");
#nullable restore
#line 87 "C:\Users\sahin\OneDrive\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Admin\Views\User\GetUsers.cshtml"
                 Write(ViewLocalizer["UserNameSurname"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </td>\" +\r\n                \"<th> ");
#nullable restore
#line 88 "C:\Users\sahin\OneDrive\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Admin\Views\User\GetUsers.cshtml"
                 Write(ViewLocalizer["UserUsername"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </td>\" +\r\n                \"<th> ");
#nullable restore
#line 89 "C:\Users\sahin\OneDrive\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Admin\Views\User\GetUsers.cshtml"
                 Write(ViewLocalizer["UserState"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </td>\" +\r\n                \"<th> ");
#nullable restore
#line 90 "C:\Users\sahin\OneDrive\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Admin\Views\User\GetUsers.cshtml"
                 Write(ViewLocalizer["UserProcesses"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" </td>"" +

                ""</tr>"";
            for (var i = 0; i < users.length; i++) {
                tableHTML += ""<tr>"";
                tableHTML += ""<td>"" + users[i].NameSurname + ""</td>"";
                tableHTML += ""<td>"" + users[i].Username + ""</td>"";
                if (users[i].LockoutEnabled) {
                    tableHTML += ""<td><span class='badge badge-danger'>");
#nullable restore
#line 98 "C:\Users\sahin\OneDrive\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Admin\Views\User\GetUsers.cshtml"
                                                                  Write(ViewLocalizer["Banned"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></td>\";\r\n                }\r\n\r\n                else {\r\n                    tableHTML += \"<td><span class=\'badge badge-success\'>");
#nullable restore
#line 102 "C:\Users\sahin\OneDrive\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Admin\Views\User\GetUsers.cshtml"
                                                                   Write(ViewLocalizer["Clear"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></td>\";\r\n                }\r\n                tableHTML += \"<td>\";\r\n                tableHTML += \"<a href=\'/Admin/User/UpdateRolesToUser/\" + users[i].Id + \"\' class=\'btn btn-success\'>");
#nullable restore
#line 105 "C:\Users\sahin\OneDrive\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Admin\Views\User\GetUsers.cshtml"
                                                                                                             Write(ViewLocalizer["GetRolesToUser"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\";\r\n                if (users[i].LockoutEnabled) {\r\n                    \r\n                    tableHTML += \"<a onClick=RemoveBanFromUser(\" + users[i].Id + \") class=\'btn btn-success text-white ml-2\'>");
#nullable restore
#line 108 "C:\Users\sahin\OneDrive\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Admin\Views\User\GetUsers.cshtml"
                                                                                                                       Write(ViewLocalizer["RemoveBanFromUser"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\";\r\n                }\r\n\r\n                else {\r\n                    \r\n                    tableHTML += \"<a href=/Admin/User/BanUser/\" + users[i].Id + \" class=\'btn btn-danger ml-2\'> ");
#nullable restore
#line 113 "C:\Users\sahin\OneDrive\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Admin\Views\User\GetUsers.cshtml"
                                                                                                          Write(ViewLocalizer["BanUser"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</a>"";
                }

                tableHTML += ""</td> "";


                tableHTML += ""</tr>"";
            }

            tableHTML += ""</table>"";

            $(""#userList"").html(tableHTML);
        }

        LoadToTableGetUsersByUsername = function () {

            var username = $(""#userUsernameText"").val();

            if (username === """")
                toastr.error(""");
#nullable restore
#line 132 "C:\Users\sahin\OneDrive\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Admin\Views\User\GetUsers.cshtml"
                         Write(ViewLocalizer["EnterUsername"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\");\r\n            else {\r\n\r\n                var users = GetUsersByUsername(username);\r\n\r\n                if (users.length == 0) {\r\n                    var emptyList = \"<div class=\'alert alert-warning font-weight-bold\'> ");
#nullable restore
#line 138 "C:\Users\sahin\OneDrive\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Admin\Views\User\GetUsers.cshtml"
                                                                                   Write(ViewLocalizer["NoUserHasBeenFoundByThisUsername"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" </div>""
                    $(""#userList"").html(emptyList);
                }

                else {
                    var tableHTML =
                        ""<table class='table table-bordered'>"" +
                        ""<tr> "" +
                        ""<th> ");
#nullable restore
#line 146 "C:\Users\sahin\OneDrive\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Admin\Views\User\GetUsers.cshtml"
                         Write(ViewLocalizer["UserNameSurname"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </td>\" +\r\n                        \"<th> ");
#nullable restore
#line 147 "C:\Users\sahin\OneDrive\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Admin\Views\User\GetUsers.cshtml"
                         Write(ViewLocalizer["UserUsername"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </td>\" +\r\n                        \"<th> ");
#nullable restore
#line 148 "C:\Users\sahin\OneDrive\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Admin\Views\User\GetUsers.cshtml"
                         Write(ViewLocalizer["UserState"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </td>\" +\r\n                        \"<th> ");
#nullable restore
#line 149 "C:\Users\sahin\OneDrive\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Admin\Views\User\GetUsers.cshtml"
                         Write(ViewLocalizer["UserProcesses"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" </td>"" +
                        ""</tr>"";
                    for (var i = 0; i < users.length; i++) {
                        tableHTML += ""<tr>"";
                        tableHTML += ""<td>"" + users[i].NameSurname + ""</td>"";
                        tableHTML += ""<td>"" + users[i].Username + ""</td>"";
                        if (users[i].LockoutEnabled) {
                            tableHTML += ""<td><span class='badge badge-danger'>");
#nullable restore
#line 156 "C:\Users\sahin\OneDrive\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Admin\Views\User\GetUsers.cshtml"
                                                                          Write(ViewLocalizer["Banned"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></td>\";\r\n                        }\r\n\r\n                        else {\r\n                            tableHTML += \"<td><span class=\'badge badge-success\'>");
#nullable restore
#line 160 "C:\Users\sahin\OneDrive\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Admin\Views\User\GetUsers.cshtml"
                                                                           Write(ViewLocalizer["Clear"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></td>\";\r\n                        }\r\n                        tableHTML += \"<td>\";\r\n                        tableHTML += \"<a href=\'/Admin/User/UpdateRolesToUser/\" + users[i].Id + \"\' class=\'btn btn-success\'>");
#nullable restore
#line 163 "C:\Users\sahin\OneDrive\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Admin\Views\User\GetUsers.cshtml"
                                                                                                                     Write(ViewLocalizer["GetRolesToUser"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\";\r\n                        if (users[i].LockoutEnabled) {\r\n\r\n                            tableHTML += \"<a onClick=RemoveBanFromUser(\" + users[i].Id + \") class=\'btn btn-success text-white ml-2\'>");
#nullable restore
#line 166 "C:\Users\sahin\OneDrive\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Admin\Views\User\GetUsers.cshtml"
                                                                                                                               Write(ViewLocalizer["RemoveBanFromUser"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\";\r\n                        }\r\n\r\n                        else {\r\n\r\n                            tableHTML += \"<a href=/Admin/User/BanUser/\" + users[i].Id + \" class=\'btn btn-danger ml-2\'> ");
#nullable restore
#line 171 "C:\Users\sahin\OneDrive\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Admin\Views\User\GetUsers.cshtml"
                                                                                                                  Write(ViewLocalizer["BanUser"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</a>"";
                        }


                        tableHTML += ""</tr>"";
                    }

                    tableHTML += ""</table>"";

                    $(""#userList"").html(tableHTML);
                }



            }


        }


        function RemoveBanFromUser(id) {
            swal(""");
#nullable restore
#line 192 "C:\Users\sahin\OneDrive\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Admin\Views\User\GetUsers.cshtml"
             Write(ViewLocalizer["VerifyRemovingBanFromUser"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\", {\r\n                buttons: {\r\n                    yes: {\r\n                        text: \"");
#nullable restore
#line 195 "C:\Users\sahin\OneDrive\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Admin\Views\User\GetUsers.cshtml"
                          Write(ViewLocalizer["Yes"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\",\r\n                        value: \"true\",\r\n                    },\r\n                    no: {\r\n                        text: \"");
#nullable restore
#line 199 "C:\Users\sahin\OneDrive\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Admin\Views\User\GetUsers.cshtml"
                          Write(ViewLocalizer["No"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@""",
                        value: ""false"",
                    },
                },
            })
                .then(async (value) => {

                    switch (value) {
                        case ""true"":
                            toastr.success(""");
#nullable restore
#line 208 "C:\Users\sahin\OneDrive\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Admin\Views\User\GetUsers.cshtml"
                                       Write(ViewLocalizer["UserBanSuccessfullyRemoved"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@""", """", {
                                ""positionClass"": ""toast-bottom-right""
                            });
                            //Just like Thread.Sleep
                            await new Promise(resolve => setTimeout(resolve, 3000));
                            window.location.href = ""/Admin/User/RemoveBanFromUser?id="" + id
                            break;
                        case ""false"":
                            break;
                    }
                });
        }

        $(""#btnShowUserIdText"").click(function () {


            document.getElementById(""userList"").innerHTML = ""<label class='mt-2'>");
#nullable restore
#line 224 "C:\Users\sahin\OneDrive\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Admin\Views\User\GetUsers.cshtml"
                                                                            Write(ViewLocalizer["ListAreaInfoText"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</label>"";

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
            LoadToTableGetUsersByUsername();
        });


    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591