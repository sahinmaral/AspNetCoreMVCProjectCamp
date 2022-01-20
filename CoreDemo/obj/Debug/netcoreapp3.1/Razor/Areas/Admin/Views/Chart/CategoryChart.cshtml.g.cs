#pragma checksum "C:\Users\sahin\Desktop\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Admin\Views\Chart\CategoryChart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21031936038d7485fa31845f9936b981b5de603e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Chart_CategoryChart), @"mvc.1.0.view", @"/Areas/Admin/Views/Chart/CategoryChart.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21031936038d7485fa31845f9936b981b5de603e", @"/Areas/Admin/Views/Chart/CategoryChart.cshtml")]
    public class Areas_Admin_Views_Chart_CategoryChart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\sahin\Desktop\GithubRepositories\AspNetCoreMVCProjectCamp\CoreDemo\Areas\Admin\Views\Chart\CategoryChart.cshtml"
  
    ViewBag.Title = "Kategori Grafiği | ";
    Layout = "_AdminLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    
    <h2>Kategori Grafiği</h2>

    <div class=""col-lg-12"">
        <div id=""chartdiv"" style=""width: 800px; height: 600px""></div>
    </div>
</div>

<script type=""text/javascript"" src=""https://www.gstatic.com/charts/loader.js""></script>
<script type=""text/javascript"">
    google.charts.load('current', { 'packages': ['corechart'] });

    google.charts.setOnLoadCallback(DrawOnLoad);

    function DrawOnLoad() {
        $(function() {
            $.ajax({
                type: 'GET',
                url: '/Admin/Chart/CategoryChartJsonReturn',
                success: function (chartData) {

                    var data = chartData.jsonList;

                    var googleData = new google.visualization.DataTable();

                    googleData.addColumn('string', 'categoryName');
                    googleData.addColumn('number', 'blogCount');

                    for (var i = 0; i < data.length; i++) {
                        googleData.addRow([data[i].");
            WriteLiteral(@"categoryName, data[i].blogCount]);
                    }

                    var chart = new google.visualization.PieChart(document.getElementById('chartdiv'));
                    chart.draw(googleData,
                        {
                            title: ""Kategorilere düşen blog grafiği"",
                            position: ""top"",
                            fontsize: ""16px""
                        });
                }
            });
        });
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
