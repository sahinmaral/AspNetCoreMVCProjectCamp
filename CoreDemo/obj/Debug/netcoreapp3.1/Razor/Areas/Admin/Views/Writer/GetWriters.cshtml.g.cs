#pragma checksum "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Admin\Views\Writer\GetWriters.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b4bded9db63f068989d07475eddbd44fb8e06a77"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Writer_GetWriters), @"mvc.1.0.view", @"/Areas/Admin/Views/Writer/GetWriters.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4bded9db63f068989d07475eddbd44fb8e06a77", @"/Areas/Admin/Views/Writer/GetWriters.cshtml")]
    public class Areas_Admin_Views_Writer_GetWriters : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\sahin\Desktop\Files\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Admin\Views\Writer\GetWriters.cshtml"
  
    ViewBag.Title = "Yazarlar ";
    Layout = "_AdminLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h2>Yazar Ajax İşlemleri</h2>
<br />

<button type=""button"" id=""btnGetWriters"" class=""btn btn-primary"">Yazarları Listele</button>
<button type=""button"" id=""btnShowWriterIdText""
        class=""btn btn-primary"">
    Yazarı ID'ye göre Listele
</button>
<br />
<br />

<div id=""writerList"">
    <label class=""mt-2"">
        Buraya yazarlar veya yazar gelecek
    </label>
</div>

<div id=""writerIdDiv"" style=""display: none; "">
    <input type=""text""
           id=""writerIdText""
           placeholder=""Yazarın ID'sini giriniz""
           class=""form-control border border-dark mb-2""
           style=""width: 200px"" />
    <button type=""button"" id=""btnGetWriter""
            class=""btn btn-primary"">
        Listele
    </button>
</div>

");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>

        toastr.options.progressBar = true;
        toastr.options.positionClass = ""toast-bottom-right"";

        GetWriters = function() {
            var writers = {};

            $.ajax({
                async: false,
                contentType: ""application/json"",
                dataType: ""json"",
                type: ""GET"",
                url: ""/Admin/Writer/GetWritersJson"",
                success: function(data) {
                    writers = jQuery.parseJSON(data);
                }
            });

            return writers;
        }

        GetWriter = function (id) {
            var foundWriter = {};

            $.ajax({
                async: false,
                contentType: ""application/json"",
                dataType: ""json"",
                type: ""GET"",
                url: ""/Admin/Writer/GetWriterByIdJson?id="" + id,
                success: function (data) {
                    foundWriter = jQuery.parseJSON(data);
                }
");
                WriteLiteral(@"            });

            return foundWriter;
        }

        LoadToTableGetWriters = function () {

            var writers = GetWriters();

            var tableHTML =
                ""<table class='table table-bordered'>"" +
                    ""<tr> "" +
                    ""<th> Yazar Id </td>"" +
                    ""<th> Yazar Adı </td>"" +
                    ""<th> Yazar Soyadı </td>"" +
                    ""<th> Yazar Kullanıcı Adı </td>"" +
                    ""<th> Yazarın Durumu </td>"" +
                    ""<th> Yazarı Banla / Banını Kaldır </td>"" +
                    ""</tr>"";
            for (var i = 0; i < writers.length; i++) {
                tableHTML += ""<tr>"";
                tableHTML += ""<td>"" + writers[i].WriterId + ""</td>"";
                tableHTML += ""<td>"" + writers[i].UserViewModel.UserFirstName + ""</td>"";
                tableHTML += ""<td>"" + writers[i].UserViewModel.UserLastName + ""</td>"";
                tableHTML += ""<td>"" + writers[i].UserViewModel.Use");
                WriteLiteral(@"rname + ""</td>"";

                if (writers[i].UserViewModel.Status)
                    tableHTML += ""<td>Temiz</td>"";
                else
                    tableHTML += ""<td>Banlı</td>"";

                tableHTML += ""<td> <button type=button onClick=EnableOrDisableWriter("" + writers[i].UserViewModel.UserId + "") class='btn btn-warning' > Yazarı Banla / Banını Kaldır</button > </td > "";
                tableHTML += ""</tr>"";
            }

            tableHTML += ""</table>"";

            $(""#writerList"").html(tableHTML);
        }

        LoadToTableGetWriter = function() {

            var id = $(""#writerIdText"").val();

            if (id === """")
                toastr.error('Yazar Id kısmını doldurunuz');
            else{
                var foundWriter = GetWriter(id);

                var tableHTML =
                    ""<table class='table table-bordered'>"" +
                        ""<tr> "" +
                        ""<th> Yazar Id </td>"" +
                        ""<t");
                WriteLiteral(@"h> Yazar Adı </td>"" +
                        ""<th> Yazar Soyadı </td>"" +
                        ""<th> Yazar Kullanıcı Adı </td>"" +
                        ""<th> Yazarın Durumu </td>"" +
                        ""<th> Yazarı Banla / Banını Kaldır </td>"" +
                        ""</tr>"";
                tableHTML += ""<tr>"";
                tableHTML += ""<td>"" + foundWriter.WriterId + ""</td>"";
                tableHTML += ""<td>"" + foundWriter.UserViewModel.UserFirstName + ""</td>"";
                tableHTML += ""<td>"" + foundWriter.UserViewModel.UserLastName + ""</td>"";
                tableHTML += ""<td>"" + foundWriter.UserViewModel.Username + ""</td>"";
                if (foundWriter.UserViewModel.Status)
                    tableHTML += ""<td>Temiz</td>"";
                else
                    tableHTML += ""<td>Banlı</td>"";
                tableHTML += ""<td> <button type=button onClick=EnableOrDisableWriter("" + foundWriter.UserViewModel.UserId + "") class='btn btn-warning' > Yazarı Banla / Banını K");
                WriteLiteral(@"aldır</button > </td > "";
                tableHTML += ""</tr>"";
                tableHTML += ""</table>"";

                $(""#writerList"").html(tableHTML);
            }

            
        }

        EnableOrDisableWriter = function(id) {
            $.ajax({
                async: false,
                contentType: ""application/json"",
                dataType: ""json"",
                type: ""POST"",
                url: ""/Admin/Writer/EnableOrDisableWriter?id="" + id,
            }).then(
                toastr.success('Yazar banlama / ban kaldırma işlemi başarılı')
            );

            var element = document.getElementById(""writerIdDiv"");

            if (element.style.display === ""none"")
                LoadToTableGetWriters();
            else
                LoadToTableGetWriter();
        }

        $(""#btnShowWriterIdText"").click(function() {


            document.getElementById(""writerList"").innerHTML = ""<label class='mt-2'>Buraya yazarlar veya yazar gelecek</l");
                WriteLiteral(@"abel>"";

            var div = document.getElementById(""writerIdDiv"");

            if (div.style.display === ""block"") {

                div.style.display = ""none"";
            } else {

                div.style.display = ""block"";
            }


        });

        $(""#btnGetWriters"").click(function() {

            document.getElementById(""writerList"").innerHTML = """";

            var element = document.getElementById(""writerIdDiv"");
            element.style.display = ""none"";
            LoadToTableGetWriters();
        });

        $(""#btnGetWriter"").click(function () {

            LoadToTableGetWriter();
        });


    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591