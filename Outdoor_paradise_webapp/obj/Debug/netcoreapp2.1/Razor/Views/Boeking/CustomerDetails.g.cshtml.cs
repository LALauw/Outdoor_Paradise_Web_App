#pragma checksum "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Boeking\CustomerDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28c261d87d61c2ccbf2724f2f34340733043bdef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Boeking_CustomerDetails), @"mvc.1.0.view", @"/Views/Boeking/CustomerDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Boeking/CustomerDetails.cshtml", typeof(AspNetCore.Views_Boeking_CustomerDetails))]
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
#line 1 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\_ViewImports.cshtml"
using Outdoor_paradise_webapp;

#line default
#line hidden
#line 2 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\_ViewImports.cshtml"
using Outdoor_paradise_webapp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28c261d87d61c2ccbf2724f2f34340733043bdef", @"/Views/Boeking/CustomerDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99258386c31a0232d3fe439693cc897483acd694", @"/Views/_ViewImports.cshtml")]
    public class Views_Boeking_CustomerDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Reis_uitvoeringCreateModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Tours", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Welcome", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(35, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Boeking\CustomerDetails.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_CustomerLayout.cshtml";

#line default
#line hidden
            BeginContext(135, 189, true);
            WriteLiteral("\r\n<div class=\"card\">\r\n    <div class=\"card-header\">\r\n        <h2>Details</h2>\r\n    </div>\r\n    <div class=\"card-body\">\r\n        <h5 class=\"card-title\">Reis Uitvoering details</h5>\r\n        ");
            EndContext();
            BeginContext(324, 92, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a57b2dec5944c16b623a5626d3c6ee1", async() => {
                BeginContext(400, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(416, 573, true);
            WriteLiteral(@"
        <hr />
        <div class=""rowoverride"">
            <div class=""coloverride"">
                <div class=""card"" style=""width: 18rem;margin-bottom:10px;"">
                    <div class=""card-header"">
                        <h4>Uitvoering Info</h4>
                    </div>
                </div>
                <div class=""card"" style=""width: 18rem;margin-bottom:10px;"">
                    <div class=""card-body"">
                        <h6 class=""card-subtitle mb-2 text-muted"">Prijs / Persoon</h6>
                        <p class=""card-text"">");
            EndContext();
            BeginContext(990, 51, false);
#line 26 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Boeking\CustomerDetails.cshtml"
                                        Write(Html.DisplayFor(model => model.Prijs_per_deelnemer));

#line default
#line hidden
            EndContext();
            BeginContext(1041, 310, true);
            WriteLiteral(@"</p>
                    </div>
                </div>
                <div class=""card"" style=""width: 18rem;margin-bottom:10px;"">
                    <div class=""card-body"">
                        <h6 class=""card-subtitle mb-2 text-muted"">Begin Datum,</h6>
                        <p class=""card-text"">");
            EndContext();
            BeginContext(1352, 43, false);
#line 32 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Boeking\CustomerDetails.cshtml"
                                        Write(Html.DisplayFor(model => model.Begin_datum));

#line default
#line hidden
            EndContext();
            BeginContext(1395, 308, true);
            WriteLiteral(@"</p>
                    </div>
                </div>
                <div class=""card"" style=""width: 18rem;margin-bottom:10px;"">
                    <div class=""card-body"">
                        <h6 class=""card-subtitle mb-2 text-muted"">Eind Datum</h6>
                        <p class=""card-text"">");
            EndContext();
            BeginContext(1704, 42, false);
#line 38 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Boeking\CustomerDetails.cshtml"
                                        Write(Html.DisplayFor(model => model.Eind_datum));

#line default
#line hidden
            EndContext();
            BeginContext(1746, 119, true);
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"coloverride\">\r\n\r\n");
            EndContext();
#line 44 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Boeking\CustomerDetails.cshtml"
                 foreach (var e in Model.ExcursiesModel)
                {

#line default
#line hidden
            BeginContext(1942, 174, true);
            WriteLiteral("                    <div class=\"card\" style=\"width: 18rem;margin-bottom:10px;\">\r\n                        <div class=\"card-header\">\r\n                            <h4>Excursie: ");
            EndContext();
            BeginContext(2117, 6, false);
#line 48 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Boeking\CustomerDetails.cshtml"
                                     Write(e.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2123, 327, true);
            WriteLiteral(@"</h4>
                        </div>
                    </div>
                    <div class=""card"" style=""width: 18rem;margin-bottom:10px;"">
                        <div class=""card-body"">
                            <h6 class=""card-subtitle mb-2 text-muted"">Gids</h6>
                            <p class=""card-text"">");
            EndContext();
            BeginContext(2451, 10, false);
#line 54 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Boeking\CustomerDetails.cshtml"
                                            Write(e.GidsNaam);

#line default
#line hidden
            EndContext();
            BeginContext(2461, 327, true);
            WriteLiteral(@"</p>
                        </div>
                    </div>
                    <div class=""card"" style=""width: 18rem;margin-bottom:10px;"">
                        <div class=""card-body"">
                            <h6 class=""card-subtitle mb-2 text-muted"">Prijs</h6>
                            <p class=""card-text"">");
            EndContext();
            BeginContext(2789, 7, false);
#line 60 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Boeking\CustomerDetails.cshtml"
                                            Write(e.Prijs);

#line default
#line hidden
            EndContext();
            BeginContext(2796, 327, true);
            WriteLiteral(@"</p>
                        </div>
                    </div>
                    <div class=""card"" style=""width: 18rem;margin-bottom:10px;"">
                        <div class=""card-body"">
                            <h6 class=""card-subtitle mb-2 text-muted"">Datum</h6>
                            <p class=""card-text"">");
            EndContext();
            BeginContext(3124, 7, false);
#line 66 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Boeking\CustomerDetails.cshtml"
                                            Write(e.Datum);

#line default
#line hidden
            EndContext();
            BeginContext(3131, 333, true);
            WriteLiteral(@"</p>
                        </div>
                    </div>
                    <div class=""card"" style=""width: 18rem;margin-bottom:10px;"">
                        <div class=""card-body"">
                            <h6 class=""card-subtitle mb-2 text-muted"">Description</h6>
                            <p class=""card-text"">");
            EndContext();
            BeginContext(3465, 13, false);
#line 72 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Boeking\CustomerDetails.cshtml"
                                            Write(e.Description);

#line default
#line hidden
            EndContext();
            BeginContext(3478, 66, true);
            WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n");
            EndContext();
#line 75 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Boeking\CustomerDetails.cshtml"
                }

#line default
#line hidden
            BeginContext(3563, 64, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Reis_uitvoeringCreateModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
