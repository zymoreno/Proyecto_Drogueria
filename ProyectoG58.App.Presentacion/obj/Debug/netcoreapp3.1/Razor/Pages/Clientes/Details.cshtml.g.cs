<<<<<<< HEAD
#pragma checksum "C:\Proyecto_Drogueria\ProyectoG58.App.Presentacion\Pages\Clientes\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d12ffda6287877de14eadd045268ecef27f875a"
=======
#pragma checksum "C:\Proyecto_Drogueria\ProyectoG58.App.Presentacion\Pages\Clientes\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e3116e95a3aa0431454228182fdbf331bb1ef511"
>>>>>>> a632ea5c93d802a76e000df315448dafe92383b2
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ProyectoG58.App.Presentacion.Pages.Clientes.Pages_Clientes_Details), @"mvc.1.0.razor-page", @"/Pages/Clientes/Details.cshtml")]
namespace ProyectoG58.App.Presentacion.Pages.Clientes
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
#line 1 "C:\Proyecto_Drogueria\ProyectoG58.App.Presentacion\Pages\_ViewImports.cshtml"
using ProyectoG58.App.Presentacion;

#line default
#line hidden
#nullable disable
<<<<<<< HEAD
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d12ffda6287877de14eadd045268ecef27f875a", @"/Pages/Clientes/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21b84889515d41b020e3fb9353717f4f71160443", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Clientes_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./ListClient", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
=======
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3116e95a3aa0431454228182fdbf331bb1ef511", @"/Pages/Clientes/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21b84889515d41b020e3fb9353717f4f71160443", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Clientes_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./List", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
>>>>>>> a632ea5c93d802a76e000df315448dafe92383b2
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
<<<<<<< HEAD
#nullable restore
#line 3 "C:\Proyecto_Drogueria\ProyectoG58.App.Presentacion\Pages\Clientes\Details.cshtml"
  
    string est= "";

     

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Proyecto_Drogueria\ProyectoG58.App.Presentacion\Pages\Clientes\Details.cshtml"
      if (Model.cliente.estado.Equals("A"))
    {
        est ="Activo";
    }else{
        est = "inactivo";
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""row mb-3"">
    <div class=""container"">
        <div class=""row justify-content-center"">
            <div class=""col-lg-5"">
                <div class=""card shadow-lg border-0 rounded-lg mt-5"">
                    <div class=""card-header bg-dark""><h3 class=""text-center font-weight-light my-4 text-primary"">Detalle del Cliente</h3></div>
                    <div class=""card-body"">
                        <table class=""table table-bordered table-hover"">
                            <tr>
                                <td style=""width:200px""><b>ID:</b></td>
                                <td>");
#nullable restore
#line 23 "C:\Proyecto_Drogueria\ProyectoG58.App.Presentacion\Pages\Clientes\Details.cshtml"
                               Write(Model.cliente.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td><b>NOMBRE:</b></td>\r\n                                <td>");
#nullable restore
#line 27 "C:\Proyecto_Drogueria\ProyectoG58.App.Presentacion\Pages\Clientes\Details.cshtml"
                               Write(Model.cliente.nombre);
=======
            WriteLiteral("\r\n<h2>Datos Detallados de Cliente ");
#nullable restore
#line 6 "C:\Proyecto_Drogueria\ProyectoG58.App.Presentacion\Pages\Clientes\Details.cshtml"
                           Write(Model.cliente.identificacion);
>>>>>>> a632ea5c93d802a76e000df315448dafe92383b2

#line default
#line hidden
#nullable disable
<<<<<<< HEAD
            WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td><b>IDENTIFICACIÓN:</b></td>\r\n                                <td>");
#nullable restore
#line 31 "C:\Proyecto_Drogueria\ProyectoG58.App.Presentacion\Pages\Clientes\Details.cshtml"
                               Write(Model.cliente.identificacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td><b>DIRECCIÓN:</b></td>\r\n                                <td>");
#nullable restore
#line 35 "C:\Proyecto_Drogueria\ProyectoG58.App.Presentacion\Pages\Clientes\Details.cshtml"
                               Write(Model.cliente.direccion);
=======
            WriteLiteral(" ");
#nullable restore
#line 6 "C:\Proyecto_Drogueria\ProyectoG58.App.Presentacion\Pages\Clientes\Details.cshtml"
                                                         Write(Model.cliente.nombre);
>>>>>>> a632ea5c93d802a76e000df315448dafe92383b2

#line default
#line hidden
#nullable disable
<<<<<<< HEAD
            WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td><b>TELÉFONO:</b></td>\r\n                                <td>");
#nullable restore
#line 39 "C:\Proyecto_Drogueria\ProyectoG58.App.Presentacion\Pages\Clientes\Details.cshtml"
                               Write(Model.cliente.telefono);
=======
            WriteLiteral("</h2>\r\n<div>\r\n    ID: ");
#nullable restore
#line 8 "C:\Proyecto_Drogueria\ProyectoG58.App.Presentacion\Pages\Clientes\Details.cshtml"
   Write(Model.cliente.id);
>>>>>>> a632ea5c93d802a76e000df315448dafe92383b2

#line default
#line hidden
#nullable disable
<<<<<<< HEAD
            WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td><b>EMAIL:</b></td>\r\n                                <td>");
#nullable restore
#line 43 "C:\Proyecto_Drogueria\ProyectoG58.App.Presentacion\Pages\Clientes\Details.cshtml"
                               Write(Model.cliente.email);
=======
            WriteLiteral("\r\n</div>\r\n<div>\r\n    IDENTIFICACIÓN: ");
#nullable restore
#line 11 "C:\Proyecto_Drogueria\ProyectoG58.App.Presentacion\Pages\Clientes\Details.cshtml"
               Write(Model.cliente.identificacion);
>>>>>>> a632ea5c93d802a76e000df315448dafe92383b2

#line default
#line hidden
#nullable disable
<<<<<<< HEAD
            WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td><b>ESTADO:</b></td>\r\n                                <td>");
#nullable restore
#line 47 "C:\Proyecto_Drogueria\ProyectoG58.App.Presentacion\Pages\Clientes\Details.cshtml"
                               Write(est);
=======
            WriteLiteral("\r\n</div>\r\n<div>\r\n    NOMBRES: ");
#nullable restore
#line 14 "C:\Proyecto_Drogueria\ProyectoG58.App.Presentacion\Pages\Clientes\Details.cshtml"
        Write(Model.cliente.nombre);
>>>>>>> a632ea5c93d802a76e000df315448dafe92383b2

#line default
#line hidden
#nullable disable
<<<<<<< HEAD
            WriteLiteral("</td>\r\n                            </tr>\r\n                        </table>\r\n                    </div>\r\n                    <div class=\"card-footer text-center py-3\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d12ffda6287877de14eadd045268ecef27f875a7444", async() => {
                WriteLiteral("\r\n                            <button type=\"button\" class=\"btn btn-warning btn-xs\" aria-label=\"Left Align\"  title=\"Volver\">\r\n                                <span > Volver </span>\r\n                            </button>\r\n                        ");
=======
            WriteLiteral("\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e3116e95a3aa0431454228182fdbf331bb1ef5115024", async() => {
                WriteLiteral("Volver a la Lista de Clientes.. ");
>>>>>>> a632ea5c93d802a76e000df315448dafe92383b2
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
<<<<<<< HEAD
=======
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
>>>>>>> a632ea5c93d802a76e000df315448dafe92383b2
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
<<<<<<< HEAD
            WriteLiteral("  \r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
=======
            WriteLiteral("\r\n");
>>>>>>> a632ea5c93d802a76e000df315448dafe92383b2
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
<<<<<<< HEAD
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProyectoG58.App.Presentacion.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ProyectoG58.App.Presentacion.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ProyectoG58.App.Presentacion.DetailsModel>)PageContext?.ViewData;
        public ProyectoG58.App.Presentacion.DetailsModel Model => ViewData.Model;
=======
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProyectoG58.App.Presentacion.Pages.Clientes.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ProyectoG58.App.Presentacion.Pages.Clientes.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ProyectoG58.App.Presentacion.Pages.Clientes.DetailsModel>)PageContext?.ViewData;
        public ProyectoG58.App.Presentacion.Pages.Clientes.DetailsModel Model => ViewData.Model;
>>>>>>> a632ea5c93d802a76e000df315448dafe92383b2
    }
}
#pragma warning restore 1591
