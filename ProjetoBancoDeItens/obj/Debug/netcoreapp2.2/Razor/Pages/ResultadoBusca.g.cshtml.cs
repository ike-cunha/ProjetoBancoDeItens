#pragma checksum "C:\Users\Trampo e Família\source\repos\ProjetoBancoDeItens\ProjetoBancoDeItens\ProjetoBancoDeItens\Pages\ResultadoBusca.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ed8975112dca954b91aaa0c040df6b7a34f9631"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ProjetoBancoDeItens.Pages.Pages_ResultadoBusca), @"mvc.1.0.razor-page", @"/Pages/ResultadoBusca.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/ResultadoBusca.cshtml", typeof(ProjetoBancoDeItens.Pages.Pages_ResultadoBusca), null)]
namespace ProjetoBancoDeItens.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Trampo e Família\source\repos\ProjetoBancoDeItens\ProjetoBancoDeItens\ProjetoBancoDeItens\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\Trampo e Família\source\repos\ProjetoBancoDeItens\ProjetoBancoDeItens\ProjetoBancoDeItens\Pages\_ViewImports.cshtml"
using ProjetoBancoDeItens;

#line default
#line hidden
#line 3 "C:\Users\Trampo e Família\source\repos\ProjetoBancoDeItens\ProjetoBancoDeItens\ProjetoBancoDeItens\Pages\_ViewImports.cshtml"
using ProjetoBancoDeItens.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ed8975112dca954b91aaa0c040df6b7a34f9631", @"/Pages/ResultadoBusca.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0abcddd9076ca64aca7166240ff99a1fd802c260", @"/Pages/_ViewImports.cshtml")]
    public class Pages_ResultadoBusca : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_BreadCrumb", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control text-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Campo de Busca"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("aria-label", new global::Microsoft.AspNetCore.Html.HtmlString("Campo de Busca"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("aria-describedby", new global::Microsoft.AspNetCore.Html.HtmlString("basic-addon1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Trampo e Família\source\repos\ProjetoBancoDeItens\ProjetoBancoDeItens\ProjetoBancoDeItens\Pages\ResultadoBusca.cshtml"
  
    ViewData["Title"] = "ResultadoBusca";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(158, 10, true);
            WriteLiteral("<header>\r\n");
            EndContext();
#line 8 "C:\Users\Trampo e Família\source\repos\ProjetoBancoDeItens\ProjetoBancoDeItens\ProjetoBancoDeItens\Pages\ResultadoBusca.cshtml"
      
        var modelo = new List<string> { "Home", "Resultado Pesquisa" };

    

#line default
#line hidden
            BeginContext(258, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(262, 45, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4ed8975112dca954b91aaa0c040df6b7a34f96316989", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 12 "C:\Users\Trampo e Família\source\repos\ProjetoBancoDeItens\ProjetoBancoDeItens\ProjetoBancoDeItens\Pages\ResultadoBusca.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = modelo;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(307, 15, true);
            WriteLiteral("\r\n</header>\r\n\r\n");
            EndContext();
            BeginContext(323, 66, false);
#line 15 "C:\Users\Trampo e Família\source\repos\ProjetoBancoDeItens\ProjetoBancoDeItens\ProjetoBancoDeItens\Pages\ResultadoBusca.cshtml"
Write(Html.Hidden("__RequestVerificationToken", Html.AntiForgeryToken()));

#line default
#line hidden
            EndContext();
            BeginContext(389, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(391, 683, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4ed8975112dca954b91aaa0c040df6b7a34f96319142", async() => {
                BeginContext(411, 420, true);
                WriteLiteral(@"
    <div class=""row p-5"">
        <div class=""col-1""></div>
        <div class=""input-group col-10"">
            <div class=""input-group-prepend"">
                <button type=""submit"" class=""btn btn-sm btn-success"">
                    <span class=""input-group-text bg-success border-0"" id=""basic-addon1""><i class=""fa fa-search text-white""></i></span>
                </button>
            </div>
            ");
                EndContext();
                BeginContext(831, 171, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4ed8975112dca954b91aaa0c040df6b7a34f96319961", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 25 "C:\Users\Trampo e Família\source\repos\ProjetoBancoDeItens\ProjetoBancoDeItens\ProjetoBancoDeItens\Pages\ResultadoBusca.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Busca.ConteudoBusca);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1002, 65, true);
                WriteLiteral("\r\n        </div>\r\n        <div class=\"col-1\"></div>\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1074, 559, true);
            WriteLiteral(@"
<div class=""row p-5"">
    <div class=""col-1""></div>
    <div class=""col-10"">
        <div class=""table-responsive"">
            <table class=""table-sm table-striped col-12"">
                <thead>
                    <tr>
                        <th scope=""col"" class=""text-center col-3"">Código</th>
                        <th scope=""col"" class=""text-center col-6"">Item (comando)</th>
                        <th scope=""col"" class=""text-center col-3"">Visualizar</th>
                    </tr>
                </thead>
                <tbody>
");
            EndContext();
#line 43 "C:\Users\Trampo e Família\source\repos\ProjetoBancoDeItens\ProjetoBancoDeItens\ProjetoBancoDeItens\Pages\ResultadoBusca.cshtml"
                     foreach (var item in Model.Busca.Itens)
                    {

#line default
#line hidden
            BeginContext(1718, 116, true);
            WriteLiteral("                        <tr>\r\n                            <td class=\"text-center\">\r\n                                ");
            EndContext();
            BeginContext(1835, 7, false);
#line 47 "C:\Users\Trampo e Família\source\repos\ProjetoBancoDeItens\ProjetoBancoDeItens\ProjetoBancoDeItens\Pages\ResultadoBusca.cshtml"
                           Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1842, 37, true);
            WriteLiteral("\r\n                            </td>\r\n");
            EndContext();
#line 49 "C:\Users\Trampo e Família\source\repos\ProjetoBancoDeItens\ProjetoBancoDeItens\ProjetoBancoDeItens\Pages\ResultadoBusca.cshtml"
                                  
                                    if (item.Nome.Length > 40)
                                    {

#line default
#line hidden
            BeginContext(2018, 100, true);
            WriteLiteral("                                    <td class=\"text-left\">\r\n                                        ");
            EndContext();
            BeginContext(2119, 26, false);
#line 53 "C:\Users\Trampo e Família\source\repos\ProjetoBancoDeItens\ProjetoBancoDeItens\ProjetoBancoDeItens\Pages\ResultadoBusca.cshtml"
                                   Write(item.Nome.Substring(0, 40));

#line default
#line hidden
            EndContext();
            BeginContext(2145, 49, true);
            WriteLiteral(" ...\r\n                                    </td>\r\n");
            EndContext();
#line 55 "C:\Users\Trampo e Família\source\repos\ProjetoBancoDeItens\ProjetoBancoDeItens\ProjetoBancoDeItens\Pages\ResultadoBusca.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(2302, 100, true);
            WriteLiteral("                                    <td class=\"text-left\">\r\n                                        ");
            EndContext();
            BeginContext(2403, 9, false);
#line 59 "C:\Users\Trampo e Família\source\repos\ProjetoBancoDeItens\ProjetoBancoDeItens\ProjetoBancoDeItens\Pages\ResultadoBusca.cshtml"
                                   Write(item.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(2412, 45, true);
            WriteLiteral("\r\n                                    </td>\r\n");
            EndContext();
#line 61 "C:\Users\Trampo e Família\source\repos\ProjetoBancoDeItens\ProjetoBancoDeItens\ProjetoBancoDeItens\Pages\ResultadoBusca.cshtml"
                                }
                                

#line default
#line hidden
            BeginContext(2527, 171, true);
            WriteLiteral("                                <td class=\"text-center\">\r\n                                    <span>\r\n                                        <a href=\"#\" class=\"text-dark\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2698, "\"", 2743, 3);
            WriteAttributeValue("", 2708, "javascript:visualizarItem(", 2708, 26, true);
#line 65 "C:\Users\Trampo e Família\source\repos\ProjetoBancoDeItens\ProjetoBancoDeItens\ProjetoBancoDeItens\Pages\ResultadoBusca.cshtml"
WriteAttributeValue("", 2734, item.Id, 2734, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 2742, ")", 2742, 1, true);
            EndWriteAttribute();
            BeginContext(2744, 239, true);
            WriteLiteral(">\r\n                                            <i class=\"fa fa-eye\"></i>\r\n                                        </a>\r\n                                    </span>\r\n                                </td>\r\n                            </tr>\r\n");
            EndContext();
#line 71 "C:\Users\Trampo e Família\source\repos\ProjetoBancoDeItens\ProjetoBancoDeItens\ProjetoBancoDeItens\Pages\ResultadoBusca.cshtml"
                        }

#line default
#line hidden
            BeginContext(3010, 145, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n    <div class=\"col-1\"></div>\r\n</div>\r\n<div id=\"itemModal\"></div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(3173, 73, true);
                WriteLiteral("\r\n    <script src=\"https://kit.fontawesome.com/faeb5bd984.js\"></script>\r\n");
                EndContext();
            }
            );
            BeginContext(3249, 662, true);
            WriteLiteral(@"
<script>
    function visualizarItem(itemId) {
        $.ajax({
            type: ""POST"",
            url: ""/ResultadoBusca?handler=Visualizar"",
            beforeSend: function (xhr) {
                xhr.setRequestHeader(""XSRF-TOKEN"",
                    $('input:hidden[name=""__RequestVerificationToken""]').val());
            },
            data: { itemId: itemId },
            success: function (response) {
                $('#itemModal').html(response);
                $('#modal').modal('show');
            },
            failure: function (response) {
                alert(response);
            }
        });

    }
</script>
");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjetoBancoDeItens.Pages.ResultadoBuscaModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ProjetoBancoDeItens.Pages.ResultadoBuscaModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ProjetoBancoDeItens.Pages.ResultadoBuscaModel>)PageContext?.ViewData;
        public ProjetoBancoDeItens.Pages.ResultadoBuscaModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
