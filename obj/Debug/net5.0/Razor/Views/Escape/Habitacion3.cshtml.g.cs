#pragma checksum "C:\Users\santi\Downloads\TP7 (2)\Views\Escape\Habitacion3.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a74c503dd7287df5a53ad4d0dbb83573c05c6b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Escape_Habitacion3), @"mvc.1.0.view", @"/Views/Escape/Habitacion3.cshtml")]
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
#line 1 "C:\Users\santi\Downloads\TP7 (2)\Views\_ViewImports.cshtml"
using TP7;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\santi\Downloads\TP7 (2)\Views\_ViewImports.cshtml"
using TP7.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a74c503dd7287df5a53ad4d0dbb83573c05c6b7", @"/Views/Escape/Habitacion3.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e2dee2682a229adccc76d28c7514d60cd2d99bb", @"/Views/_ViewImports.cshtml")]
    public class Views_Escape_Habitacion3 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\santi\Downloads\TP7 (2)\Views\Escape\Habitacion3.cshtml"
  
    ViewData["Title"] = "Supermercado";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container-fluid"">
  <div class=""row"">
    <div class=""col-lg-12 col-md-12 col-sm-12"">
<div class=""jumbotron jumbotron-fluid supermercado"">
  <div class=""container"">
    <h1 class=""display-4"">??Has ingresado al Supermercado!</h1>
    <p class=""lead"">Para lograr escapar, deber??s encontrar las palabras en la sopa de letras, con las que despu??s deber??s desifrar la clave. La misma es un producto que todas las palabras hayadas tienen en com??n. Las pistas estan incluidas en el juego apretando el boton que ""Mostrar palabra"".</p>
  </div>
</div>
    </div>
  </div>
  <div class=""row"">
    <div class=""col-lg-12 col-md-12 col-sm-12"">
<center>
<iframe style=""width: 78rem;"" height=""590"" frameborder=""0"" class=""juego"" src=""https://es.educaplay.com/juego/9993564-supermercado.html""></iframe>

</div>
  </div>
<br>
  <div class=""row"">
    <div class=""col-lg-12 col-md-12 col-sm-12"">
<div id = ""hespecial""> 
<br>
<center>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a74c503dd7287df5a53ad4d0dbb83573c05c6b74641", async() => {
                WriteLiteral(@"
<div class=""input-group ml-0 mb-0"">
  <input type=""text"" class=""form-control"" name= ""clave"" placeholder=""Ingrese la clave"" aria-label=""clave"" aria-describedby=""button-addon2"">
  <div class=""input-group-append"">
    <button class=""btn btn-danger"" type=""submit"" id=""button-addon2"">Enviar</button>
");
#nullable restore
#line 33 "C:\Users\santi\Downloads\TP7 (2)\Views\Escape\Habitacion3.cshtml"
      
    if(ViewBag.Alerta==true){

#line default
#line hidden
#nullable disable
                WriteLiteral(@"    <div class=""modal"" id= ""terminal"" tabindex=""-1"" role=""dialog"">
      <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
          <div class=""modal-header"">
            <h5 class=""modal-title texto"">C??digo incorrecto</h5>
            <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
              <span aria-hidden=""true"">&times;</span>
            </button>
          </div>
          <div class=""modal-body"">
            <p class=""texto"">Vuelva a intentar.</p>
          </div>
          <div class=""modal-footer"">
            <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Cerrar</button>
            <button type=""button"" class=""btn btn-primary"" data-dismiss=""modal"">Volver a intentar</button>
          </div>
        </div>
      </div>
    </div>
");
#nullable restore
#line 54 "C:\Users\santi\Downloads\TP7 (2)\Views\Escape\Habitacion3.cshtml"
}

#line default
#line hidden
#nullable disable
                WriteLiteral(" </div>\r\n</div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#nullable restore
#line 28 "C:\Users\santi\Downloads\TP7 (2)\Views\Escape\Habitacion3.cshtml"
AddHtmlAttributeValue("", 1011, Url.Action("Habitacion3","Escape"), 1011, 35, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<br>\r\n</div>\r\n    </div>\r\n  </div>\r\n  </div>\r\n</div>\r\n<br>");
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
