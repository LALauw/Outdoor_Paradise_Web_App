#pragma checksum "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Reis_uitvoering\CustomerDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8dba82661926c98df35e8637624e2ecf798213cc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reis_uitvoering_CustomerDetails), @"mvc.1.0.view", @"/Views/Reis_uitvoering/CustomerDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Reis_uitvoering/CustomerDetails.cshtml", typeof(AspNetCore.Views_Reis_uitvoering_CustomerDetails))]
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
#line 2 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Reis_uitvoering\CustomerDetails.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8dba82661926c98df35e8637624e2ecf798213cc", @"/Views/Reis_uitvoering/CustomerDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99258386c31a0232d3fe439693cc897483acd694", @"/Views/_ViewImports.cshtml")]
    public class Views_Reis_uitvoering_CustomerDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Reis_uitvoeringModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "YourTours", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Welcome", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(155, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Reis_uitvoering\CustomerDetails.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_CustomerLayout.cshtml";

#line default
#line hidden
            BeginContext(255, 178, true);
            WriteLiteral("\r\n<div class=\"card\">\r\n    <div class=\"card-header\">\r\n        <h2>Details</h2>\r\n    </div>\r\n    <div class=\"card-body\">\r\n        <h5 class=\"card-title\">Reis Uitvoering voor reis: ");
            EndContext();
            BeginContext(434, 18, false);
#line 16 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Reis_uitvoering\CustomerDetails.cshtml"
                                                     Write(Model.ReisObj.Name);

#line default
#line hidden
            EndContext();
            BeginContext(452, 15, true);
            WriteLiteral("</h5>\r\n        ");
            EndContext();
            BeginContext(467, 148, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "608f7f918a2f4922bfa5b370f854ed55", async() => {
                BeginContext(599, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-username", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 17 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Reis_uitvoering\CustomerDetails.cshtml"
                                                                                                WriteLiteral(UserManager.GetUserName(User));

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["username"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-username", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["username"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(615, 570, true);
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
                        <h6 class=""card-subtitle mb-2 text-muted"">Totaal Prijs</h6>
                        <p class=""card-text"">");
            EndContext();
            BeginContext(1186, 43, false);
#line 29 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Reis_uitvoering\CustomerDetails.cshtml"
                                        Write(Html.DisplayFor(model => model.TotaalPrijs));

#line default
#line hidden
            EndContext();
            BeginContext(1229, 308, true);
            WriteLiteral(@"</p>
                    </div>
                </div>
                <div class=""card"" style=""width: 18rem;margin-bottom:10px;"">
                    <div class=""card-body"">
                        <h6 class=""card-subtitle mb-2 text-muted"">Reis prijs</h6>
                        <p class=""card-text"">");
            EndContext();
            BeginContext(1538, 51, false);
#line 35 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Reis_uitvoering\CustomerDetails.cshtml"
                                        Write(Html.DisplayFor(model => model.Prijs_per_deelnemer));

#line default
#line hidden
            EndContext();
            BeginContext(1589, 314, true);
            WriteLiteral(@"</p>
                    </div>
                </div>
                <div class=""card"" style=""width: 18rem;margin-bottom:10px;"">
                    <div class=""card-body"">
                        <h6 class=""card-subtitle mb-2 text-muted"">Aantal Boekingen</h6>
                        <p class=""card-text"">");
            EndContext();
            BeginContext(1904, 45, false);
#line 41 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Reis_uitvoering\CustomerDetails.cshtml"
                                        Write(Html.DisplayFor(model => model.countBookings));

#line default
#line hidden
            EndContext();
            BeginContext(1949, 312, true);
            WriteLiteral(@"</p>
                    </div>
                </div>
                <div class=""card"" style=""width: 18rem;margin-bottom:10px;"">
                    <div class=""card-body"">
                        <h6 class=""card-subtitle mb-2 text-muted"">Max deelnemers</h6>
                        <p class=""card-text"">");
            EndContext();
            BeginContext(2262, 54, false);
#line 47 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Reis_uitvoering\CustomerDetails.cshtml"
                                        Write(Html.DisplayFor(model => model.ReisObj.Max_deelnemers));

#line default
#line hidden
            EndContext();
            BeginContext(2316, 581, true);
            WriteLiteral(@"</p>
                    </div>
                </div>
            </div>
            <div class=""coloverride"">
                <div class=""card"" style=""width: 18rem;margin-bottom:10px;"">
                    <div class=""card-header"">
                        <h4>Reis Info</h4>
                    </div>
                </div>
                <div class=""card"" style=""width: 18rem;margin-bottom:10px;"">
                    <div class=""card-body"">
                        <h6 class=""card-subtitle mb-2 text-muted"">Reis</h6>
                        <p class=""card-text"">");
            EndContext();
            BeginContext(2898, 44, false);
#line 60 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Reis_uitvoering\CustomerDetails.cshtml"
                                        Write(Html.DisplayFor(model => model.ReisObj.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2942, 305, true);
            WriteLiteral(@"</p>
                    </div>
                </div>
                <div class=""card"" style=""width: 18rem;margin-bottom:10px;"">
                    <div class=""card-body"">
                        <h6 class=""card-subtitle mb-2 text-muted"">Locatie</h6>
                        <p class=""card-text"">");
            EndContext();
            BeginContext(3248, 47, false);
#line 66 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Reis_uitvoering\CustomerDetails.cshtml"
                                        Write(Html.DisplayFor(model => model.ReisObj.Locatie));

#line default
#line hidden
            EndContext();
            BeginContext(3295, 314, true);
            WriteLiteral(@"</p>
                    </div>
                </div>
                <div class=""card"" style=""width: 18rem;margin-bottom:10px;"">
                    <div class=""card-body"">
                        <h6 class=""card-subtitle mb-2 text-muted"">Kind Toegestaan?</h6>
                        <p class=""card-text"">");
            EndContext();
            BeginContext(3610, 44, false);
#line 72 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Reis_uitvoering\CustomerDetails.cshtml"
                                        Write(Html.DisplayFor(model => model.ReisObj.Kind));

#line default
#line hidden
            EndContext();
            BeginContext(3654, 117, true);
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"coloverride\">\r\n");
            EndContext();
#line 77 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Reis_uitvoering\CustomerDetails.cshtml"
                 if (Model.Excursies.Any())
                {
                    

#line default
#line hidden
#line 79 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Reis_uitvoering\CustomerDetails.cshtml"
                     foreach (var e in Model.Excursies)
                    {

#line default
#line hidden
            BeginContext(3915, 249, true);
            WriteLiteral("                        <div class=\"coloverride\">\r\n                            <div class=\"card\" style=\"width: 18rem;margin-bottom:10px;\">\r\n                                <div class=\"card-header\">\r\n                                    <h4>Excursie: ");
            EndContext();
            BeginContext(4165, 6, false);
#line 84 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Reis_uitvoering\CustomerDetails.cshtml"
                                             Write(e.Name);

#line default
#line hidden
            EndContext();
            BeginContext(4171, 375, true);
            WriteLiteral(@"</h4>
                                </div>
                            </div>
                            <div class=""card"" style=""width: 18rem;margin-bottom:10px;"">
                                <div class=""card-body"">
                                    <h6 class=""card-subtitle mb-2 text-muted"">Gids</h6>
                                    <p class=""card-text"">");
            EndContext();
            BeginContext(4547, 10, false);
#line 90 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Reis_uitvoering\CustomerDetails.cshtml"
                                                    Write(e.GidsNaam);

#line default
#line hidden
            EndContext();
            BeginContext(4557, 375, true);
            WriteLiteral(@"</p>
                                </div>
                            </div>
                            <div class=""card"" style=""width: 18rem;margin-bottom:10px;"">
                                <div class=""card-body"">
                                    <h6 class=""card-subtitle mb-2 text-muted"">Prijs</h6>
                                    <p class=""card-text"">");
            EndContext();
            BeginContext(4933, 7, false);
#line 96 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Reis_uitvoering\CustomerDetails.cshtml"
                                                    Write(e.Prijs);

#line default
#line hidden
            EndContext();
            BeginContext(4940, 375, true);
            WriteLiteral(@"</p>
                                </div>
                            </div>
                            <div class=""card"" style=""width: 18rem;margin-bottom:10px;"">
                                <div class=""card-body"">
                                    <h6 class=""card-subtitle mb-2 text-muted"">Datum</h6>
                                    <p class=""card-text"">");
            EndContext();
            BeginContext(5316, 7, false);
#line 102 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Reis_uitvoering\CustomerDetails.cshtml"
                                                    Write(e.Datum);

#line default
#line hidden
            EndContext();
            BeginContext(5323, 381, true);
            WriteLiteral(@"</p>
                                </div>
                            </div>
                            <div class=""card"" style=""width: 18rem;margin-bottom:10px;"">
                                <div class=""card-body"">
                                    <h6 class=""card-subtitle mb-2 text-muted"">Description</h6>
                                    <p class=""card-text"">");
            EndContext();
            BeginContext(5705, 13, false);
#line 108 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Reis_uitvoering\CustomerDetails.cshtml"
                                                    Write(e.Description);

#line default
#line hidden
            EndContext();
            BeginContext(5718, 114, true);
            WriteLiteral("</p>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
            EndContext();
#line 112 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Reis_uitvoering\CustomerDetails.cshtml"
                    }

#line default
#line hidden
#line 112 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Reis_uitvoering\CustomerDetails.cshtml"
                     
                }

#line default
#line hidden
            BeginContext(5874, 64, true);
            WriteLiteral("            </div>\r\n            \r\n        </div>\r\n</div>\r\n\r\n\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<AppUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<AppUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Reis_uitvoeringModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
