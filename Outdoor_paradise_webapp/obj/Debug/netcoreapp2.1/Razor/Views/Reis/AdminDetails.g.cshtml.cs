#pragma checksum "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Reis\AdminDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "37faf9bc5ea48ede857de55cb4c85407b35626c9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reis_AdminDetails), @"mvc.1.0.view", @"/Views/Reis/AdminDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Reis/AdminDetails.cshtml", typeof(AspNetCore.Views_Reis_AdminDetails))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37faf9bc5ea48ede857de55cb4c85407b35626c9", @"/Views/Reis/AdminDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99258386c31a0232d3fe439693cc897483acd694", @"/Views/_ViewImports.cshtml")]
    public class Views_Reis_AdminDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Outdoor_paradise_webapp.Models.ReisViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Reis", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Reis\AdminDetails.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "../Shared/_AdminLayout";

#line default
#line hidden
            BeginContext(136, 157, true);
            WriteLiteral("\r\n<div class=\"card\">\r\n    <div class=\"card-header\">\r\n        <h2>Details</h2>\r\n    </div>\r\n    <div class=\"card-body\">\r\n        <h5 class=\"card-title\">Reis: ");
            EndContext();
            BeginContext(294, 10, false);
#line 12 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Reis\AdminDetails.cshtml"
                                Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(304, 19, true);
            WriteLiteral("</h5>\r\n            ");
            EndContext();
            BeginContext(323, 100, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66e12a6c331048229582e63b19e7ff3e", async() => {
                BeginContext(415, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 13 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Reis\AdminDetails.cshtml"
                                                         WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(423, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(437, 89, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "326af5329e334f748695d06dbd47d7b2", async() => {
                BeginContext(510, 12, true);
                WriteLiteral("Back to list");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(526, 278, true);
            WriteLiteral(@"
        <hr />
        <div class=""card"" style=""width: 18rem;margin-bottom:10px;"">
            <div class=""card-header"">
                <h4>Info</h4>
            </div>
        </div>
        <div class=""card"" style=""width:18rem; margin-bottom:10px;"">
            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 804, "\"", 836, 1);
#line 22 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Reis\AdminDetails.cshtml"
WriteAttributeValue("", 810, Model.ImagePath.Imagepath, 810, 26, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 837, "\"", 864, 1);
#line 22 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Reis\AdminDetails.cshtml"
WriteAttributeValue("", 843, Model.ImagePath.Name, 843, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(865, 226, true);
            WriteLiteral(" style=\"max-height:100%; max-width:100%;\" />\r\n        </div>\r\n        <div class=\"card\" style=\"width: 18rem;margin-bottom:10px;\">\r\n            <div class=\"card-body\">\r\n                <h6 class=\"card-subtitle mb-2 text-muted\">");
            EndContext();
            BeginContext(1092, 43, false);
#line 26 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Reis\AdminDetails.cshtml"
                                                     Write(Html.DisplayNameFor(model => model.Locatie));

#line default
#line hidden
            EndContext();
            BeginContext(1135, 44, true);
            WriteLiteral("</h6>\r\n                <p class=\"card-text\">");
            EndContext();
            BeginContext(1180, 39, false);
#line 27 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Reis\AdminDetails.cshtml"
                                Write(Html.DisplayFor(model => model.Locatie));

#line default
#line hidden
            EndContext();
            BeginContext(1219, 206, true);
            WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n        <div class=\"card\" style=\"width: 18rem;margin-bottom:10px;\">\r\n            <div class=\"card-body\">\r\n                <h6 class=\"card-subtitle mb-2 text-muted\">");
            EndContext();
            BeginContext(1426, 40, false);
#line 32 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Reis\AdminDetails.cshtml"
                                                     Write(Html.DisplayNameFor(model => model.Kind));

#line default
#line hidden
            EndContext();
            BeginContext(1466, 44, true);
            WriteLiteral("</h6>\r\n                <p class=\"card-text\">");
            EndContext();
            BeginContext(1511, 36, false);
#line 33 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Reis\AdminDetails.cshtml"
                                Write(Html.DisplayFor(model => model.Kind));

#line default
#line hidden
            EndContext();
            BeginContext(1547, 206, true);
            WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n        <div class=\"card\" style=\"width: 18rem;margin-bottom:10px;\">\r\n            <div class=\"card-body\">\r\n                <h6 class=\"card-subtitle mb-2 text-muted\">");
            EndContext();
            BeginContext(1754, 50, false);
#line 38 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Reis\AdminDetails.cshtml"
                                                     Write(Html.DisplayNameFor(model => model.Max_deelnemers));

#line default
#line hidden
            EndContext();
            BeginContext(1804, 44, true);
            WriteLiteral("</h6>\r\n                <p class=\"card-text\">");
            EndContext();
            BeginContext(1849, 46, false);
#line 39 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Reis\AdminDetails.cshtml"
                                Write(Html.DisplayFor(model => model.Max_deelnemers));

#line default
#line hidden
            EndContext();
            BeginContext(1895, 206, true);
            WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n        <div class=\"card\" style=\"width: 18rem;margin-bottom:10px;\">\r\n            <div class=\"card-body\">\r\n                <h6 class=\"card-subtitle mb-2 text-muted\">");
            EndContext();
            BeginContext(2102, 50, false);
#line 44 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Reis\AdminDetails.cshtml"
                                                     Write(Html.DisplayNameFor(model => model.Min_deelnemers));

#line default
#line hidden
            EndContext();
            BeginContext(2152, 44, true);
            WriteLiteral("</h6>\r\n                <p class=\"card-text\">");
            EndContext();
            BeginContext(2197, 46, false);
#line 45 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Reis\AdminDetails.cshtml"
                                Write(Html.DisplayFor(model => model.Min_deelnemers));

#line default
#line hidden
            EndContext();
            BeginContext(2243, 206, true);
            WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n        <div class=\"card\" style=\"width: 18rem;margin-bottom:10px;\">\r\n            <div class=\"card-body\">\r\n                <h6 class=\"card-subtitle mb-2 text-muted\">");
            EndContext();
            BeginContext(2450, 47, false);
#line 50 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Reis\AdminDetails.cshtml"
                                                     Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(2497, 44, true);
            WriteLiteral("</h6>\r\n                <p class=\"card-text\">");
            EndContext();
            BeginContext(2542, 43, false);
#line 51 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Reis\AdminDetails.cshtml"
                                Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(2585, 64, true);
            WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
