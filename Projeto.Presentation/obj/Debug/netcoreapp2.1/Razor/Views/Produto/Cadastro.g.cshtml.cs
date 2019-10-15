#pragma checksum "C:\Guilherme\Aula23\Projeto.Presentation\Views\Produto\Cadastro.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a1eca16de26a2b3e459964e1cdf1f167a9c1c0f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produto_Cadastro), @"mvc.1.0.view", @"/Views/Produto/Cadastro.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Produto/Cadastro.cshtml", typeof(AspNetCore.Views_Produto_Cadastro))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a1eca16de26a2b3e459964e1cdf1f167a9c1c0f", @"/Views/Produto/Cadastro.cshtml")]
    public class Views_Produto_Cadastro : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Projeto.Presentation.Models.ProdutoCadastroModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Guilherme\Aula23\Projeto.Presentation\Views\Produto\Cadastro.cshtml"
  
    ViewData["Title"] = "Cadastro";
    Layout = "~/Views/Templates/Layout.cshtml";

#line default
#line hidden
            BeginContext(150, 165, true);
            WriteLiteral("\r\n<!-- utilizar a model de cadastro -->\r\n<!-- precisa criar uma model (ProdutoCadastroModel) para interagir com a página-->\r\n<h4>Cadastro de Produto</h4>\r\n<hr />\r\n\r\n");
            EndContext();
#line 12 "C:\Guilherme\Aula23\Projeto.Presentation\Views\Produto\Cadastro.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
            BeginContext(345, 112, true);
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"col-md-6\">\r\n            <label>Nome do Produto:</label>\r\n            ");
            EndContext();
            BeginContext(458, 69, false);
#line 17 "C:\Guilherme\Aula23\Projeto.Presentation\Views\Produto\Cadastro.cshtml"
       Write(Html.TextBoxFor(model => model.Nome, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(527, 136, true);
            WriteLiteral("\r\n\r\n            <!-- span para mostrar os erros de validação do campo nome -->\r\n            <span class=\"text-danger\">\r\n                ");
            EndContext();
            BeginContext(664, 46, false);
#line 21 "C:\Guilherme\Aula23\Projeto.Presentation\Views\Produto\Cadastro.cshtml"
           Write(Html.ValidationMessageFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(710, 92, true);
            WriteLiteral("\r\n            </span>\r\n            <br />\r\n\r\n            <label>Preço:</label>\r\n            ");
            EndContext();
            BeginContext(803, 70, false);
#line 26 "C:\Guilherme\Aula23\Projeto.Presentation\Views\Produto\Cadastro.cshtml"
       Write(Html.TextBoxFor(model => model.Preco, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(873, 137, true);
            WriteLiteral("\r\n\r\n            <!-- span para mostrar os erros de validação do campo preco -->\r\n            <span class=\"text-danger\">\r\n                ");
            EndContext();
            BeginContext(1011, 47, false);
#line 30 "C:\Guilherme\Aula23\Projeto.Presentation\Views\Produto\Cadastro.cshtml"
           Write(Html.ValidationMessageFor(model => model.Preco));

#line default
#line hidden
            EndContext();
            BeginContext(1058, 97, true);
            WriteLiteral("\r\n            </span>\r\n            <br />\r\n\r\n            <label>Quantidade:</label>\r\n            ");
            EndContext();
            BeginContext(1156, 75, false);
#line 35 "C:\Guilherme\Aula23\Projeto.Presentation\Views\Produto\Cadastro.cshtml"
       Write(Html.TextBoxFor(model => model.Quantidade, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1231, 142, true);
            WriteLiteral("\r\n\r\n            <!-- span para mostrar os erros de validação do campo quantidade -->\r\n            <span class=\"text-danger\">\r\n                ");
            EndContext();
            BeginContext(1374, 52, false);
#line 39 "C:\Guilherme\Aula23\Projeto.Presentation\Views\Produto\Cadastro.cshtml"
           Write(Html.ValidationMessageFor(model => model.Quantidade));

#line default
#line hidden
            EndContext();
            BeginContext(1426, 302, true);
            WriteLiteral(@"
            </span>
            <br />

            <!-- botão para o submit -->
            <input type=""submit"" value=""Cadastrar Produto""
                   class=""btn btn-success"" />
            <br />
            <br />
            <!-- Mostra a mensagem de erro -->
            <strong>");
            EndContext();
            BeginContext(1729, 20, false);
#line 49 "C:\Guilherme\Aula23\Projeto.Presentation\Views\Produto\Cadastro.cshtml"
               Write(TempData["Mensagem"]);

#line default
#line hidden
            EndContext();
            BeginContext(1749, 41, true);
            WriteLiteral("</strong>\r\n\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 53 "C:\Guilherme\Aula23\Projeto.Presentation\Views\Produto\Cadastro.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Projeto.Presentation.Models.ProdutoCadastroModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
