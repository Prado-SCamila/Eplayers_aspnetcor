#pragma checksum "C:\Users\prado\OneDrive\Área de Trabalho\LOGICA PROGRAMACAO\Eplayers_Aspnetcore\Eplayers_aspnetcor\Views\Equipe\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b19703e6c5428fb1db5223830cdd0de29f077312"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Equipe_Index), @"mvc.1.0.view", @"/Views/Equipe/Index.cshtml")]
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
#line 1 "C:\Users\prado\OneDrive\Área de Trabalho\LOGICA PROGRAMACAO\Eplayers_Aspnetcore\Eplayers_aspnetcor\Views\_ViewImports.cshtml"
using Eplayers_aspnetcor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\prado\OneDrive\Área de Trabalho\LOGICA PROGRAMACAO\Eplayers_Aspnetcore\Eplayers_aspnetcor\Views\_ViewImports.cshtml"
using Eplayers_aspnetcor.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b19703e6c5428fb1db5223830cdd0de29f077312", @"/Views/Equipe/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e293fa552d4013d962018b6d318ef95fdd62209", @"/Views/_ViewImports.cshtml")]
    public class Views_Equipe_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Equipe>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("cadastro"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Link para excluir uma equipe", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Equipe", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Excluir", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(" \r\n");
#nullable restore
#line 3 "C:\Users\prado\OneDrive\Área de Trabalho\LOGICA PROGRAMACAO\Eplayers_Aspnetcore\Eplayers_aspnetcor\Views\Equipe\Index.cshtml"
  
    ViewData ["Title"] = "Equipes";
  

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"titulo_pagina\">\r\n        <h1>Cadastro de ");
#nullable restore
#line 8 "C:\Users\prado\OneDrive\Área de Trabalho\LOGICA PROGRAMACAO\Eplayers_Aspnetcore\Eplayers_aspnetcor\Views\Equipe\Index.cshtml"
                   Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    </div>\r\n\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b19703e6c5428fb1db5223830cdd0de29f0773126095", async() => {
                WriteLiteral(@"
        <div class=""campo"">

        <label for=""IdEquipe"">IdEquipe</label>
        <input type=""text"" name =""IdEquipe"" id=""IdEquipe""/>

        </div>
        <div class=""campo"">

        <label for=""Nome"">Nome</label>
        <input type=""text"" name =""Nome"" id=""Nome""/>

        </div>
        <div class=""campo"">

        <label for=""Imagem"">Imagem</label>
         <input type=""file"" name =""Imagem"" id=""Imagem""/>

        </div>
        
        <button class=""gradient btn"" type=""submit"">Cadastrar</button>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#nullable restore
#line 11 "C:\Users\prado\OneDrive\Área de Trabalho\LOGICA PROGRAMACAO\Eplayers_Aspnetcore\Eplayers_aspnetcor\Views\Equipe\Index.cshtml"
AddHtmlAttributeValue("", 215, Url.Action("Cadastrar"), 215, 24, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n    <table class=\"table table-striped table-responsive\">\r\n\r\n        <thread>\r\n            <th>ID</th>\r\n            <th>Nome</th>\r\n            <th>Foto</th>\r\n        </thread>\r\n        <tbody>\r\n");
#nullable restore
#line 42 "C:\Users\prado\OneDrive\Área de Trabalho\LOGICA PROGRAMACAO\Eplayers_Aspnetcore\Eplayers_aspnetcor\Views\Equipe\Index.cshtml"
             foreach(Equipe equipe in ViewBag.Equipes){

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 44 "C:\Users\prado\OneDrive\Área de Trabalho\LOGICA PROGRAMACAO\Eplayers_Aspnetcore\Eplayers_aspnetcor\Views\Equipe\Index.cshtml"
                   Write(equipe.IdEquipe);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 45 "C:\Users\prado\OneDrive\Área de Trabalho\LOGICA PROGRAMACAO\Eplayers_Aspnetcore\Eplayers_aspnetcor\Views\Equipe\Index.cshtml"
                   Write(equipe.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td><img");
            BeginWriteAttribute("src", " src=\"", 1210, "\"", 1243, 2);
            WriteAttributeValue("", 1216, "/img/Equipes/", 1216, 13, true);
#nullable restore
#line 46 "C:\Users\prado\OneDrive\Área de Trabalho\LOGICA PROGRAMACAO\Eplayers_Aspnetcore\Eplayers_aspnetcor\Views\Equipe\Index.cshtml"
WriteAttributeValue("", 1229, equipe.Imagem, 1229, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Imagem da Equipe.Nome\"></td>\r\n                    <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b19703e6c5428fb1db5223830cdd0de29f07731210512", async() => {
                WriteLiteral("Excluir");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 47 "C:\Users\prado\OneDrive\Área de Trabalho\LOGICA PROGRAMACAO\Eplayers_Aspnetcore\Eplayers_aspnetcor\Views\Equipe\Index.cshtml"
                                                                                                                  WriteLiteral(equipe.IdEquipe);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 49 "C:\Users\prado\OneDrive\Área de Trabalho\LOGICA PROGRAMACAO\Eplayers_Aspnetcore\Eplayers_aspnetcor\Views\Equipe\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Equipe> Html { get; private set; }
    }
}
#pragma warning restore 1591
