#pragma checksum "C:\Users\Ivo\Desktop\SeaChessDEMOREAL\SeaChessDEMO\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e09cffb0a8dec019dccbf062895e14b96f00e56b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Ivo\Desktop\SeaChessDEMOREAL\SeaChessDEMO\Views\_ViewImports.cshtml"
using SeaChessDEMO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ivo\Desktop\SeaChessDEMOREAL\SeaChessDEMO\Views\_ViewImports.cshtml"
using SeaChessDEMO.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e09cffb0a8dec019dccbf062895e14b96f00e56b", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"199fa2dc5752e821aaadc41346628b29063fc1e4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CellOnClick", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Ivo\Desktop\SeaChessDEMOREAL\SeaChessDEMO\Views\Home\Index.cshtml"
  
    var game = ViewData["Game"] as SeaChessModel;
    string[,] gameMatrix = game.GameMatrix;
    ViewData["Title"] = "Play SeaChess";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container-fluid\">\r\n    <div class=\"row\">\r\n        <div class=\"col-sm-12\">\r\n            <div class=\"text-center\" style=\'padding:10px\'>\r\n                <h2>");
#nullable restore
#line 11 "C:\Users\Ivo\Desktop\SeaChessDEMOREAL\SeaChessDEMO\Views\Home\Index.cshtml"
               Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"row\" style=\'padding:20px; font-size:30px\'>\r\n        <div class=\"col-sm-4\">\r\n            <div class=\"text-right\">\r\n                <p>\r\n                    Play with: \r\n");
#nullable restore
#line 20 "C:\Users\Ivo\Desktop\SeaChessDEMOREAL\SeaChessDEMO\Views\Home\Index.cshtml"
                     if (game.Player == "X")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span style=\"color: red; font-size:40px\">");
#nullable restore
#line 22 "C:\Users\Ivo\Desktop\SeaChessDEMOREAL\SeaChessDEMO\Views\Home\Index.cshtml"
                                                            Write(game.Player);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 23 "C:\Users\Ivo\Desktop\SeaChessDEMOREAL\SeaChessDEMO\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\Ivo\Desktop\SeaChessDEMOREAL\SeaChessDEMO\Views\Home\Index.cshtml"
                     if (game.Player == "O")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span style=\"color: limegreen;font-size: 40px\">");
#nullable restore
#line 26 "C:\Users\Ivo\Desktop\SeaChessDEMOREAL\SeaChessDEMO\Views\Home\Index.cshtml"
                                                                  Write(game.Player);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 27 "C:\Users\Ivo\Desktop\SeaChessDEMOREAL\SeaChessDEMO\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </p>
            </div>
        </div>
    </div>
    <div class=""row"">
        <div class=""col-sm-4""></div>
        <div class=""col-sm-4"">
            <table class=""table table-bordered"">
                <tbody class=""text-center"">
");
#nullable restore
#line 38 "C:\Users\Ivo\Desktop\SeaChessDEMOREAL\SeaChessDEMO\Views\Home\Index.cshtml"
                     for (int i = 0; i < 3; i++)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n");
#nullable restore
#line 41 "C:\Users\Ivo\Desktop\SeaChessDEMOREAL\SeaChessDEMO\Views\Home\Index.cshtml"
                             for (int j = 0; j < 3; j++)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td>\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e09cffb0a8dec019dccbf062895e14b96f00e56b7637", async() => {
                WriteLiteral("\r\n                                        <input type=\"hidden\" name=\"row\"");
                BeginWriteAttribute("value", " value=\"", 1599, "\"", 1609, 1);
#nullable restore
#line 45 "C:\Users\Ivo\Desktop\SeaChessDEMOREAL\SeaChessDEMO\Views\Home\Index.cshtml"
WriteAttributeValue("", 1607, i, 1607, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                        <input type=\"hidden\" name=\"col\"");
                BeginWriteAttribute("value", " value=\"", 1684, "\"", 1694, 1);
#nullable restore
#line 46 "C:\Users\Ivo\Desktop\SeaChessDEMOREAL\SeaChessDEMO\Views\Home\Index.cshtml"
WriteAttributeValue("", 1692, j, 1692, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n");
#nullable restore
#line 47 "C:\Users\Ivo\Desktop\SeaChessDEMOREAL\SeaChessDEMO\Views\Home\Index.cshtml"
                                         if (gameMatrix[@i,@j]=="X")
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <button type=\"submit\" style=\'color: red;width:80px;height:80px;font-size:40px;\' class=\"btn-default\">\r\n                                                ");
#nullable restore
#line 50 "C:\Users\Ivo\Desktop\SeaChessDEMOREAL\SeaChessDEMO\Views\Home\Index.cshtml"
                                           Write(gameMatrix[@i, @j]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                            </button>\r\n");
#nullable restore
#line 52 "C:\Users\Ivo\Desktop\SeaChessDEMOREAL\SeaChessDEMO\Views\Home\Index.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <button type=\"submit\" style=\'color: limegreen;width:80px;height:80px;font-size:40px;\' class=\"btn-default\">\r\n                                                ");
#nullable restore
#line 56 "C:\Users\Ivo\Desktop\SeaChessDEMOREAL\SeaChessDEMO\Views\Home\Index.cshtml"
                                           Write(gameMatrix[@i, @j]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                            </button>\r\n");
#nullable restore
#line 58 "C:\Users\Ivo\Desktop\SeaChessDEMOREAL\SeaChessDEMO\Views\Home\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        \r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </td>\r\n");
#nullable restore
#line 62 "C:\Users\Ivo\Desktop\SeaChessDEMOREAL\SeaChessDEMO\Views\Home\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tr>\r\n");
#nullable restore
#line 64 "C:\Users\Ivo\Desktop\SeaChessDEMOREAL\SeaChessDEMO\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n        <div class=\"col-sm-2\"></div>\r\n    </div>\r\n    <div class=\"row\" style=\'padding:20px; font-size:30px\'>\r\n        <div class=\"col-sm-12 \">\r\n            <div>\r\n");
#nullable restore
#line 73 "C:\Users\Ivo\Desktop\SeaChessDEMOREAL\SeaChessDEMO\Views\Home\Index.cshtml"
                 if (game.PlayerWin == "X")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p class=\"row float-right\" style=\"color: red;\">\"");
#nullable restore
#line 75 "C:\Users\Ivo\Desktop\SeaChessDEMOREAL\SeaChessDEMO\Views\Home\Index.cshtml"
                                                               Write(game.PlayerWin);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" is the Winner! </p>\r\n");
#nullable restore
#line 76 "C:\Users\Ivo\Desktop\SeaChessDEMOREAL\SeaChessDEMO\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 77 "C:\Users\Ivo\Desktop\SeaChessDEMOREAL\SeaChessDEMO\Views\Home\Index.cshtml"
                 if (game.PlayerWin == "O")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p class=\"row float-right\" style=\"color:limegreen;\">\"");
#nullable restore
#line 79 "C:\Users\Ivo\Desktop\SeaChessDEMOREAL\SeaChessDEMO\Views\Home\Index.cshtml"
                                                                    Write(game.PlayerWin);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" is the Winner! </p>\r\n");
#nullable restore
#line 80 "C:\Users\Ivo\Desktop\SeaChessDEMOREAL\SeaChessDEMO\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
