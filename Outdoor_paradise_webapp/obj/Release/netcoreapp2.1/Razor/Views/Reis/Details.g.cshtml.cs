#pragma checksum "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Reis\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c58df999df5de7d007a5eccbe5aff6594bd5951f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reis_Details), @"mvc.1.0.view", @"/Views/Reis/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Reis/Details.cshtml", typeof(AspNetCore.Views_Reis_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c58df999df5de7d007a5eccbe5aff6594bd5951f", @"/Views/Reis/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99258386c31a0232d3fe439693cc897483acd694", @"/Views/_ViewImports.cshtml")]
    public class Views_Reis_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Outdoor_paradise_webapp.Models.ReisViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Tours", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Welcome", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Boeking", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MedereizigersJa", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-bottom:5px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CustomerDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Reis\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "../Shared/_CustomerLayout";

#line default
#line hidden
            BeginContext(139, 157, true);
            WriteLiteral("\r\n<div class=\"card\">\r\n    <div class=\"card-header\">\r\n        <h2>Details</h2>\r\n    </div>\r\n    <div class=\"card-body\">\r\n        <h5 class=\"card-title\">Reis: ");
            EndContext();
            BeginContext(297, 10, false);
#line 12 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Reis\Details.cshtml"
                                Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(307, 15, true);
            WriteLiteral("</h5>\r\n        ");
            EndContext();
            BeginContext(322, 84, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cb06824073734531b2f456925a436daf", async() => {
                BeginContext(398, 4, true);
                WriteLiteral("Back");
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
            BeginContext(406, 408, true);
            WriteLiteral(@"
        <hr />
        <div class=""rowoverride"">
            <div class=""coloverride"">
                <div class=""card"" style=""width: 18rem;margin-bottom:10px;"">
                    <div class=""card-header"">
                        <h4>Info</h4>
                    </div>
                </div>
                <div class=""card"" style=""width:18rem; margin-bottom:10px;"">
                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 814, "\"", 846, 1);
#line 23 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Reis\Details.cshtml"
WriteAttributeValue("", 820, Model.ImagePath.Imagepath, 820, 26, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 847, "\"", 874, 1);
#line 23 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Reis\Details.cshtml"
WriteAttributeValue("", 853, Model.ImagePath.Name, 853, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(875, 258, true);
            WriteLiteral(@" style=""max-height:100%; max-width:100%;"" />
                </div>
                <div class=""card"" style=""width: 18rem;margin-bottom:10px;"">
                    <div class=""card-body"">
                        <h6 class=""card-subtitle mb-2 text-muted"">");
            EndContext();
            BeginContext(1134, 43, false);
#line 27 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Reis\Details.cshtml"
                                                             Write(Html.DisplayNameFor(model => model.Locatie));

#line default
#line hidden
            EndContext();
            BeginContext(1177, 52, true);
            WriteLiteral("</h6>\r\n                        <p class=\"card-text\">");
            EndContext();
            BeginContext(1230, 39, false);
#line 28 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Reis\Details.cshtml"
                                        Write(Html.DisplayFor(model => model.Locatie));

#line default
#line hidden
            EndContext();
            BeginContext(1269, 246, true);
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n                <div class=\"card\" style=\"width: 18rem;margin-bottom:10px;\">\r\n                    <div class=\"card-body\">\r\n                        <h6 class=\"card-subtitle mb-2 text-muted\">");
            EndContext();
            BeginContext(1516, 40, false);
#line 33 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Reis\Details.cshtml"
                                                             Write(Html.DisplayNameFor(model => model.Kind));

#line default
#line hidden
            EndContext();
            BeginContext(1556, 52, true);
            WriteLiteral("</h6>\r\n                        <p class=\"card-text\">");
            EndContext();
            BeginContext(1609, 36, false);
#line 34 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Reis\Details.cshtml"
                                        Write(Html.DisplayFor(model => model.Kind));

#line default
#line hidden
            EndContext();
            BeginContext(1645, 246, true);
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n                <div class=\"card\" style=\"width: 18rem;margin-bottom:10px;\">\r\n                    <div class=\"card-body\">\r\n                        <h6 class=\"card-subtitle mb-2 text-muted\">");
            EndContext();
            BeginContext(1892, 50, false);
#line 39 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Reis\Details.cshtml"
                                                             Write(Html.DisplayNameFor(model => model.Max_deelnemers));

#line default
#line hidden
            EndContext();
            BeginContext(1942, 52, true);
            WriteLiteral("</h6>\r\n                        <p class=\"card-text\">");
            EndContext();
            BeginContext(1995, 46, false);
#line 40 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Reis\Details.cshtml"
                                        Write(Html.DisplayFor(model => model.Max_deelnemers));

#line default
#line hidden
            EndContext();
            BeginContext(2041, 246, true);
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n                <div class=\"card\" style=\"width: 18rem;margin-bottom:10px;\">\r\n                    <div class=\"card-body\">\r\n                        <h6 class=\"card-subtitle mb-2 text-muted\">");
            EndContext();
            BeginContext(2288, 50, false);
#line 45 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Reis\Details.cshtml"
                                                             Write(Html.DisplayNameFor(model => model.Min_deelnemers));

#line default
#line hidden
            EndContext();
            BeginContext(2338, 52, true);
            WriteLiteral("</h6>\r\n                        <p class=\"card-text\">");
            EndContext();
            BeginContext(2391, 46, false);
#line 46 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Reis\Details.cshtml"
                                        Write(Html.DisplayFor(model => model.Min_deelnemers));

#line default
#line hidden
            EndContext();
            BeginContext(2437, 246, true);
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n                <div class=\"card\" style=\"width: 18rem;margin-bottom:10px;\">\r\n                    <div class=\"card-body\">\r\n                        <h6 class=\"card-subtitle mb-2 text-muted\">");
            EndContext();
            BeginContext(2684, 47, false);
#line 51 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Reis\Details.cshtml"
                                                             Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(2731, 52, true);
            WriteLiteral("</h6>\r\n                        <p class=\"card-text\">");
            EndContext();
            BeginContext(2784, 43, false);
#line 52 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Reis\Details.cshtml"
                                        Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(2827, 1322, true);
            WriteLiteral(@"</p>
                    </div>
                </div>
            </div>

                <div class=""card"">
                    <div class=""card-header"">
                        <h2>Uitvoeringen</h2>
                    </div>
                    <div class=""table-responsive table-striped table-bordered card-body"">
                        <table class=""table"">
                            <thead class=""thead-dark"">
                                <tr>
                                    <th>
                                        Start Date
                                    </th>
                                    <th>
                                        End Date
                                    </th>
                                    <th>
                                        Total Price / Person
                                    </th>
                                    <th>
                                        Bookings
                                    </th>
");
            WriteLiteral(@"                                    <th>
                                        Excursions
                                    </th>
                                    <th></th>
                                </tr>
                            </thead>
                            <tbody>
");
            EndContext();
#line 84 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Reis\Details.cshtml"
                                 if (Model.Uitvoeringen != null)
                                {
                                

#line default
#line hidden
#line 86 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Reis\Details.cshtml"
                                 foreach (var item in Model.Uitvoeringen)
                                {

#line default
#line hidden
            BeginContext(4360, 120, true);
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(4481, 46, false);
#line 90 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Reis\Details.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Begin_datum));

#line default
#line hidden
            EndContext();
            BeginContext(4527, 127, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(4655, 45, false);
#line 93 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Reis\Details.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Eind_datum));

#line default
#line hidden
            EndContext();
            BeginContext(4700, 127, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(4828, 46, false);
#line 96 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Reis\Details.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.TotaalPrijs));

#line default
#line hidden
            EndContext();
            BeginContext(4874, 127, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(5002, 48, false);
#line 99 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Reis\Details.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.countBookings));

#line default
#line hidden
            EndContext();
            BeginContext(5050, 127, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(5178, 49, false);
#line 102 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Reis\Details.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.CountExcursies));

#line default
#line hidden
            EndContext();
            BeginContext(5227, 127, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(5354, 188, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f0f80029c5e04a4f92bebcaed625ad3e", async() => {
                BeginContext(5534, 4, true);
                WriteLiteral("Book");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-reis_uitvoering", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 105 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Reis\Details.cshtml"
                                                                                                                WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["reis_uitvoering"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-reis_uitvoering", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["reis_uitvoering"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 105 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Reis\Details.cshtml"
                                                                                                                                          WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["reis"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-reis", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["reis"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5542, 42, true);
            WriteLiteral("\r\n                                        ");
            EndContext();
            BeginContext(5584, 158, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "264b770cf83f4e5c9f24eb2efef85eee", async() => {
                BeginContext(5734, 4, true);
                WriteLiteral("Info");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-reis_uitvoering", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 106 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Reis\Details.cshtml"
                                                                                                                WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["reis_uitvoering"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-reis_uitvoering", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["reis_uitvoering"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5742, 84, true);
            WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n");
            EndContext();
#line 109 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Reis\Details.cshtml"
                                }

#line default
#line hidden
#line 109 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Reis\Details.cshtml"
                                 
                                }

#line default
#line hidden
            BeginContext(5896, 174, true);
            WriteLiteral("                            </tbody>\r\n                        </table>\r\n                    </div>\r\n          \r\n            </div>\r\n            </div>\r\n        </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Outdoor_paradise_webapp.Models.ReisViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
