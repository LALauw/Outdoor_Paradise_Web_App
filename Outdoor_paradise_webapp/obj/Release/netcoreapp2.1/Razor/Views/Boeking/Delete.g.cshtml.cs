#pragma checksum "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Boeking\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a3ccd18889dc363bb02bd01deb6b154562500ac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Boeking_Delete), @"mvc.1.0.view", @"/Views/Boeking/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Boeking/Delete.cshtml", typeof(AspNetCore.Views_Boeking_Delete))]
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
#line 2 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Boeking\Delete.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a3ccd18889dc363bb02bd01deb6b154562500ac", @"/Views/Boeking/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99258386c31a0232d3fe439693cc897483acd694", @"/Views/_ViewImports.cshtml")]
    public class Views_Boeking_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Reis_uitvoeringModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Welcome", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "YourTours", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(155, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Boeking\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Views/Shared/_CustomerLayout.cshtml";

#line default
#line hidden
            BeginContext(254, 212, true);
            WriteLiteral("\r\n<div class=\"card\">\r\n    <div class=\"card-header\">\r\n        <h2>Cancel Booking</h2>\r\n    </div>\r\n    <div class=\"card-body\">\r\n        <h5 class=\"card-title\">Are you sure you want to cancel your booking of tour: ");
            EndContext();
            BeginContext(467, 18, false);
#line 16 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Boeking\Delete.cshtml"
                                                                                Write(Model.ReisObj.Name);

#line default
#line hidden
            EndContext();
            BeginContext(485, 141, true);
            WriteLiteral("</h5>\r\n        <h6 class=\"card-title\">Your payment will be canceled, if you\'ve already paid it will be refunded automatically.</h6>\r\n        ");
            EndContext();
            BeginContext(626, 417, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f2b191fc77f7455b86328268ea40ac5e", async() => {
                BeginContext(652, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(666, 43, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d1977b35acf7461bba35c8088d493d65", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 19 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Boeking\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(709, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(723, 47, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0e6264e0546f4e8fbef314613710eef4", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 20 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Boeking\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.boeker);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(770, 108, true);
                WriteLiteral("\r\n            <input type=\"submit\" value=\"Cancel my booking\" class=\"btn btn-outline-danger\" />\r\n            ");
                EndContext();
                BeginContext(878, 148, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "541150ad56ea46b09654dd65d15581d0", async() => {
                    BeginContext(1010, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-username", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 22 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Boeking\Delete.cshtml"
                                                                       WriteLiteral(UserManager.GetUserName(User));

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["username"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-username", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["username"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1026, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1043, 418, true);
            WriteLiteral(@"
        <hr />

        <div class=""card"" style=""width: 18rem;margin-bottom:10px;"">
            <div class=""card-header"">
                <h4>Uitvoering Info</h4>
            </div>
        </div>
        <div class=""card"" style=""width: 18rem;margin-bottom:10px;"">
            <div class=""card-body"">
                <h6 class=""card-subtitle mb-2 text-muted"">Tour</h6>
                <p class=""card-text"">");
            EndContext();
            BeginContext(1462, 44, false);
#line 34 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Boeking\Delete.cshtml"
                                Write(Html.DisplayFor(model => model.ReisObj.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1506, 254, true);
            WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n        <div class=\"card\" style=\"width: 18rem;margin-bottom:10px;\">\r\n            <div class=\"card-body\">\r\n                <h6 class=\"card-subtitle mb-2 text-muted\">Tour</h6>\r\n                <p class=\"card-text\">");
            EndContext();
            BeginContext(1761, 47, false);
#line 40 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Boeking\Delete.cshtml"
                                Write(Html.DisplayFor(model => model.ReisObj.Locatie));

#line default
#line hidden
            EndContext();
            BeginContext(1808, 260, true);
            WriteLiteral(@"</p>
            </div>
        </div>
        <div class=""card"" style=""width: 18rem;margin-bottom:10px;"">
            <div class=""card-body"">
                <h6 class=""card-subtitle mb-2 text-muted"">Start Date</h6>
                <p class=""card-text"">");
            EndContext();
            BeginContext(2069, 43, false);
#line 46 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Boeking\Delete.cshtml"
                                Write(Html.DisplayFor(model => model.Begin_datum));

#line default
#line hidden
            EndContext();
            BeginContext(2112, 261, true);
            WriteLiteral(@"</p>
            </div>
        </div>
        <div class=""card"" style=""width: 18rem;margin-bottom:10px;"">
            <div class=""card-body"">
                <h6 class=""card-subtitle mb-2 text-muted"">Ending Date</h6>
                <p class=""card-text"">");
            EndContext();
            BeginContext(2374, 42, false);
#line 52 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Boeking\Delete.cshtml"
                                Write(Html.DisplayFor(model => model.Eind_datum));

#line default
#line hidden
            EndContext();
            BeginContext(2416, 262, true);
            WriteLiteral(@"</p>
            </div>
        </div>
        <div class=""card"" style=""width: 18rem;margin-bottom:10px;"">
            <div class=""card-body"">
                <h6 class=""card-subtitle mb-2 text-muted"">Totaal Prijs</h6>
                <p class=""card-text"">");
            EndContext();
            BeginContext(2679, 43, false);
#line 58 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Boeking\Delete.cshtml"
                                Write(Html.DisplayFor(model => model.TotaalPrijs));

#line default
#line hidden
            EndContext();
            BeginContext(2722, 264, true);
            WriteLiteral(@"</p>
            </div>
        </div>
        <div class=""card"" style=""width: 18rem;margin-bottom:10px;"">
            <div class=""card-body"">
                <h6 class=""card-subtitle mb-2 text-muted"">Price / Person</h6>
                <p class=""card-text"">");
            EndContext();
            BeginContext(2987, 51, false);
#line 64 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Boeking\Delete.cshtml"
                                Write(Html.DisplayFor(model => model.Prijs_per_deelnemer));

#line default
#line hidden
            EndContext();
            BeginContext(3038, 60, true);
            WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
