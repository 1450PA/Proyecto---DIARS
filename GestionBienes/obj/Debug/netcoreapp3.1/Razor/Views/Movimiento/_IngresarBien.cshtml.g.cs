#pragma checksum "C:\Users\PABLO AGUILAR\Desktop\GestionBienes\Views\Movimiento\_IngresarBien.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56033890732fb268dc9a9d22d50831eaadfb2523"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movimiento__IngresarBien), @"mvc.1.0.view", @"/Views/Movimiento/_IngresarBien.cshtml")]
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
#line 1 "C:\Users\PABLO AGUILAR\Desktop\GestionBienes\Views\_ViewImports.cshtml"
using GestionBienes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\PABLO AGUILAR\Desktop\GestionBienes\Views\_ViewImports.cshtml"
using GestionBienes.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56033890732fb268dc9a9d22d50831eaadfb2523", @"/Views/Movimiento/_IngresarBien.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4db0c8f0ef48e848727736a6cc3fa4d3482d3438", @"/Views/_ViewImports.cshtml")]
    public class Views_Movimiento__IngresarBien : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<GestionBienes.Models.Bien>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Navbar.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Estilos.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r");
#nullable restore
#line 2 "C:\Users\PABLO AGUILAR\Desktop\GestionBienes\Views\Movimiento\_IngresarBien.cshtml"
   Layout = null;   var bien = new Bien();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r<!DOCTYPE html>\r<html lang=\"es\">\r");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56033890732fb268dc9a9d22d50831eaadfb25235423", async() => {
                WriteLiteral(@"    <meta name=""viewport"" content=""width=device-width"" />    <title>Gestión de bienes</title>    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css"" integrity=""sha384-9aIt2nRpC12Uk9gS9baDl411NQApFmC26EwAOH8WgZl5MYYxFfc+NcPb1dKGj7Sk"" crossorigin=""anonymous"">    <link rel=""stylesheet"" href=""https://use.fontawesome.com/releases/v5.7.0/css/all.css"">    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "56033890732fb268dc9a9d22d50831eaadfb25236101", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "56033890732fb268dc9a9d22d50831eaadfb25237277", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\r");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56033890732fb268dc9a9d22d50831eaadfb25239157", async() => {
                WriteLiteral(@"    <nav class=""navbar navbar-expand-lg bg-secondary text-uppercase fixed-top"" id=""mainNav"">        <div class=""container"">            <a class=""navbar-brand js-scroll-trigger"" href=""#page-top"">Gestion de Bienes</a>            <ul class=""navbar-nav"">                <li class=""nav-item active"">                    <a class=""nav-link"" href=""/Bien/Index"">Bienes<span class=""sr-only"">(current)</span></a>                </li>                <li class=""nav-item"">                    <a class=""nav-link"" href=""/Movimiento/_RetirarBien"">Retirar Bienes</a>                </li>                <li class=""nav-item dropdown"">                    <a class=""nav-link dropdown-toggle"" href=""#"" id=""navbarDropdown"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">                        Ingresar Bienes                    </a>                    <div class=""dropdown-menu"" aria-labelledby=""navbarDropdown"">                        <a class=""dropdown-item"" href=""/Movimiento/_IngresarBien"">R");
                WriteLiteral(@"egistrado</a>                        <div class=""dropdown-divider""></div>                        <a class=""dropdown-item"" href=""/Bien/IngresarBienNoRegistrado"">No Registrado</a>                    </div>                </li>                <li class=""nav-item"">                    <a class=""btn btn-md btn-secondary"" href=""/Home/Index"">Cerrar Sesión</a>                </li>            </ul>        </div>    </nav>    <div class=""container col-md-6"" style=""padding-top: 100px; text-align:center"">        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56033890732fb268dc9a9d22d50831eaadfb252311057", async() => {
                    WriteLiteral(@"            <h4>Ingresar Bienes</h4>            <div class=""row"">                <div class=""col-md-10"">                    <input type=""text"" class=""form-control"" id=""buscar"" placeholder=""Ingresa Código o Nombre del Bien"">                </div>                <a class=""btn btn-md btn-success"" onclick=""ActivarCampoOtroTema();"">Buscar</a>            </div>        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"    </div>    <div style=""padding-top: 50px"">        <table class=""table table-bordered"" id=""tabla"" style=""display:none;"">            <thead class=""bg-success"" style=""text-align:center"">                <tr>                    <th>N°</th>                    <th>Nombre</th>                    <th>Código</th>                    <th>Marca</th>                    <th>Cantidad actual</th>                    <th>Última entrada hecha</th>                    <th>Última salida hecha</th>                    <th>Retirar bienes</th>                </tr>            </thead>            <tbody style=""text-align:center"">");
#nullable restore
#line 68 "C:\Users\PABLO AGUILAR\Desktop\GestionBienes\Views\Movimiento\_IngresarBien.cshtml"
                   int i = 1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "C:\Users\PABLO AGUILAR\Desktop\GestionBienes\Views\Movimiento\_IngresarBien.cshtml"
                 foreach (var item in Model)                {

#line default
#line hidden
#nullable disable
                WriteLiteral("    <tr>\r        <td>");
#nullable restore
#line 72 "C:\Users\PABLO AGUILAR\Desktop\GestionBienes\Views\Movimiento\_IngresarBien.cshtml"
        Write(i++);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r        <td>");
#nullable restore
#line 73 "C:\Users\PABLO AGUILAR\Desktop\GestionBienes\Views\Movimiento\_IngresarBien.cshtml"
       Write(item.Nombre);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r        <td>");
#nullable restore
#line 74 "C:\Users\PABLO AGUILAR\Desktop\GestionBienes\Views\Movimiento\_IngresarBien.cshtml"
       Write(item.Codigo);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r        <td>\r");
#nullable restore
#line 76 "C:\Users\PABLO AGUILAR\Desktop\GestionBienes\Views\Movimiento\_IngresarBien.cshtml"
              var marca = string.IsNullOrEmpty(item.Marca) ? "No se ha registrado una marca" : item.Marca;

#line default
#line hidden
#nullable disable
                WriteLiteral("            ");
#nullable restore
#line 77 "C:\Users\PABLO AGUILAR\Desktop\GestionBienes\Views\Movimiento\_IngresarBien.cshtml"
       Write(marca);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r        </td>\r        <td>\r            ");
#nullable restore
#line 80 "C:\Users\PABLO AGUILAR\Desktop\GestionBienes\Views\Movimiento\_IngresarBien.cshtml"
       Write(item.CantidadActual);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r");
#nullable restore
#line 81 "C:\Users\PABLO AGUILAR\Desktop\GestionBienes\Views\Movimiento\_IngresarBien.cshtml"
             if (item.UnidadMedida == 1)            {

#line default
#line hidden
#nullable disable
                WriteLiteral("<t>Kilogramos</t>");
#nullable restore
#line 82 "C:\Users\PABLO AGUILAR\Desktop\GestionBienes\Views\Movimiento\_IngresarBien.cshtml"
                              }

#line default
#line hidden
#nullable disable
#nullable restore
#line 83 "C:\Users\PABLO AGUILAR\Desktop\GestionBienes\Views\Movimiento\_IngresarBien.cshtml"
             if (item.UnidadMedida == 2)            {

#line default
#line hidden
#nullable disable
                WriteLiteral("<t>Metros</t>");
#nullable restore
#line 84 "C:\Users\PABLO AGUILAR\Desktop\GestionBienes\Views\Movimiento\_IngresarBien.cshtml"
                          }

#line default
#line hidden
#nullable disable
#nullable restore
#line 85 "C:\Users\PABLO AGUILAR\Desktop\GestionBienes\Views\Movimiento\_IngresarBien.cshtml"
             if (item.UnidadMedida == 3)            {

#line default
#line hidden
#nullable disable
                WriteLiteral("<t>Litros</t>");
#nullable restore
#line 86 "C:\Users\PABLO AGUILAR\Desktop\GestionBienes\Views\Movimiento\_IngresarBien.cshtml"
                          }

#line default
#line hidden
#nullable disable
#nullable restore
#line 87 "C:\Users\PABLO AGUILAR\Desktop\GestionBienes\Views\Movimiento\_IngresarBien.cshtml"
             if (item.UnidadMedida == 4)            {

#line default
#line hidden
#nullable disable
                WriteLiteral("<t>Unidades</t>");
#nullable restore
#line 88 "C:\Users\PABLO AGUILAR\Desktop\GestionBienes\Views\Movimiento\_IngresarBien.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </td>\r\r        <td>");
#nullable restore
#line 90 "C:\Users\PABLO AGUILAR\Desktop\GestionBienes\Views\Movimiento\_IngresarBien.cshtml"
       Write(bien.UltimaEntrada(item.Id));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r        <td>");
#nullable restore
#line 91 "C:\Users\PABLO AGUILAR\Desktop\GestionBienes\Views\Movimiento\_IngresarBien.cshtml"
       Write(bien.UltimaSalida(item.Id));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\r        <td>\r            <a");
                BeginWriteAttribute("href", " href=\"", 4015, "\"", 4068, 2);
                WriteAttributeValue("", 4022, "/Movimiento/AgregarExistencias?IdBien=", 4022, 38, true);
#nullable restore
#line 93 "C:\Users\PABLO AGUILAR\Desktop\GestionBienes\Views\Movimiento\_IngresarBien.cshtml"
WriteAttributeValue("", 4060, item.Id, 4060, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" data-toggle=\"modal\" data-target=\"#exampleModal\" style=\"Color: #28a745\" class=\"fas fa-plus agregar\"></a>\r        </td>\r    </tr>\r");
#nullable restore
#line 96 "C:\Users\PABLO AGUILAR\Desktop\GestionBienes\Views\Movimiento\_IngresarBien.cshtml"
}

#line default
#line hidden
#nullable disable
                WriteLiteral(@"            </tbody>        </table>    </div>    <div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">        <div class=""modal-dialog"" role=""document"">            <div id=""formagregar"" class=""modal-content"">            </div>        </div>    </div>    <script type=""text/javascript"">        document.querySelector(""#buscar"").onkeyup = function () {            $TableFilter(""#tabla"", this.value);        }        $TableFilter = function (id, value) {            var rows = document.querySelectorAll(id + ' tbody tr');            for (var i = 0; i < rows.length; i++) {                var showRow = false;                var row = rows[i];                row.style.display = 'none';                for (var x = 0; x < row.childElementCount; x++) {                    if (row.children[x].textContent.toLowerCase().indexOf(value.toLowerCase().trim()) > -1) {                        showRow = true;                        brea");
                WriteLiteral(@"k;                    }                }                if (showRow) {                    row.style.display = null;                }            }        }        function ActivarCampoOtroTema() {            var contenedor = document.getElementById(""tabla"");            contenedor.style.display = ""inline-table"";            return true;        }    </script>    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56033890732fb268dc9a9d22d50831eaadfb252320168", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"    <script src=""https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js"" integrity=""sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo"" crossorigin=""anonymous""></script>    <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/js/bootstrap.min.js"" integrity=""sha384-OgVRvuATP1z7JjHLkuOU7Xw704+h835Lr+6QL9UvYjZE3Ipu6Tp75j7Bh/kR0JKI"" crossorigin=""anonymous""></script>    <script>        function AgregarExistencias(element) {            $.ajax({                url: element.href            }).done(function (e) {                $('#formagregar').html(e);            });        }        $('.agregar').on(""click"", function (e) {            e.preventDefault();            AgregarExistencias(this);        });    </script>");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<GestionBienes.Models.Bien>> Html { get; private set; }
    }
}
#pragma warning restore 1591
