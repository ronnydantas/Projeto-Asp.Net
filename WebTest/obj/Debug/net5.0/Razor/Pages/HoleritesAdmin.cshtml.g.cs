#pragma checksum "C:\Users\ronny\Documents\ADS UNIP\4 Semestre\PIM\web\WebTest\Pages\HoleritesAdmin.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "94715ecbdfde6061221e8a842956c3a2a30a6dfaa41ef941df3127082bf5d8db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebTest.Pages.Pages_HoleritesAdmin), @"mvc.1.0.razor-page", @"/Pages/HoleritesAdmin.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"94715ecbdfde6061221e8a842956c3a2a30a6dfaa41ef941df3127082bf5d8db", @"/Pages/HoleritesAdmin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"77d100e5e536a9ddc75af70dc3ea628f3dbe971df0054b7d4eed7394bec11140", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_HoleritesAdmin : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Holerites</h1>\n\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th>Nome</th>\n            <th>Salário</th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 15 "C:\Users\ronny\Documents\ADS UNIP\4 Semestre\PIM\web\WebTest\Pages\HoleritesAdmin.cshtml"
         foreach (var funcionario in Model.Funcionarios)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td>");
#nullable restore
#line 18 "C:\Users\ronny\Documents\ADS UNIP\4 Semestre\PIM\web\WebTest\Pages\HoleritesAdmin.cshtml"
               Write(funcionario.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 19 "C:\Users\ronny\Documents\ADS UNIP\4 Semestre\PIM\web\WebTest\Pages\HoleritesAdmin.cshtml"
               Write(funcionario.Salario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            </tr>\n");
#nullable restore
#line 21 "C:\Users\ronny\Documents\ADS UNIP\4 Semestre\PIM\web\WebTest\Pages\HoleritesAdmin.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebTest.Pages.HoleritesAdminModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebTest.Pages.HoleritesAdminModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebTest.Pages.HoleritesAdminModel>)PageContext?.ViewData;
        public WebTest.Pages.HoleritesAdminModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
