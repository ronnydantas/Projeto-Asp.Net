#pragma checksum "C:\Users\ronny\Documents\ADS UNIP\4 Semestre\PIM\web\WebTest\Pages\PontoList.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "595e2348a7f5218ed47a27edbadf943d0654ac32682318091bdaba1458dff617"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebTest.Pages.Pages_PontoList), @"mvc.1.0.razor-page", @"/Pages/PontoList.cshtml")]
namespace WebTest.Pages
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\ronny\Documents\ADS UNIP\4 Semestre\PIM\web\WebTest\Pages\_ViewImports.cshtml"
using WebTest;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"595e2348a7f5218ed47a27edbadf943d0654ac32682318091bdaba1458dff617", @"/Pages/PontoList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"77d100e5e536a9ddc75af70dc3ea628f3dbe971df0054b7d4eed7394bec11140", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_PontoList : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<h1>Pontos</h1>

<table class=""table"">
    <thead>
        <tr>
            <th>Id</th>
            <th>Nome</th>
            <th>Dia</th>
            <th>Horário de entrada</th>
            <th>Horário de saída</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 19 "C:\Users\ronny\Documents\ADS UNIP\4 Semestre\PIM\web\WebTest\Pages\PontoList.cshtml"
         foreach (var ponto in Model.Pontos)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td>");
#nullable restore
#line 22 "C:\Users\ronny\Documents\ADS UNIP\4 Semestre\PIM\web\WebTest\Pages\PontoList.cshtml"
               Write(ponto.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 23 "C:\Users\ronny\Documents\ADS UNIP\4 Semestre\PIM\web\WebTest\Pages\PontoList.cshtml"
               Write(ponto.NomeUsuario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 24 "C:\Users\ronny\Documents\ADS UNIP\4 Semestre\PIM\web\WebTest\Pages\PontoList.cshtml"
               Write(ponto.Dia.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 25 "C:\Users\ronny\Documents\ADS UNIP\4 Semestre\PIM\web\WebTest\Pages\PontoList.cshtml"
               Write(DateTime.Today.Add(ponto.HorarioEntrada).ToString("HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 26 "C:\Users\ronny\Documents\ADS UNIP\4 Semestre\PIM\web\WebTest\Pages\PontoList.cshtml"
                Write(ponto.HorarioSaida != null ? DateTime.Today.Add(ponto.HorarioSaida.Value).ToString("HH:mm") : "");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            </tr>\n");
#nullable restore
#line 28 "C:\Users\ronny\Documents\ADS UNIP\4 Semestre\PIM\web\WebTest\Pages\PontoList.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebTest.Pages.PontoListModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebTest.Pages.PontoListModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebTest.Pages.PontoListModel>)PageContext?.ViewData;
        public WebTest.Pages.PontoListModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
