#pragma checksum "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Welcome\Tours.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c17e2cda8f1b99e048fa8d895f4adc6f8e20c9c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Welcome_Tours), @"mvc.1.0.view", @"/Views/Welcome/Tours.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Welcome/Tours.cshtml", typeof(AspNetCore.Views_Welcome_Tours))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c17e2cda8f1b99e048fa8d895f4adc6f8e20c9c", @"/Views/Welcome/Tours.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99258386c31a0232d3fe439693cc897483acd694", @"/Views/_ViewImports.cshtml")]
    public class Views_Welcome_Tours : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Outdoor_paradise_webapp.Models.ReisViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Reis", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Welcome\Tours.cshtml"
   
    Layout = "../Shared/_CustomerLayout.cshtml";

#line default
#line hidden
            BeginContext(124, 27, true);
            WriteLiteral("<div class=\"rowoverride\">\r\n");
            EndContext();
#line 6 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Welcome\Tours.cshtml"
     foreach (var reis in Model)
    {

#line default
#line hidden
            BeginContext(192, 109, true);
            WriteLiteral("        <div class=\"coloverride\">\r\n            <div class=\"card\" style=\"width: 18rem;\">\r\n                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 301, "\"", 332, 1);
#line 10 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Welcome\Tours.cshtml"
WriteAttributeValue("", 307, reis.ImagePath.Imagepath, 307, 25, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(333, 21, true);
            WriteLiteral(" class=\"card-img-top\"");
            EndContext();
            BeginWriteAttribute("alt", " alt=\"", 354, "\"", 380, 1);
#line 10 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Welcome\Tours.cshtml"
WriteAttributeValue("", 360, reis.ImagePath.Name, 360, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(381, 131, true);
            WriteLiteral(">\r\n                <div class=\"card-body\" style=\"min-height:250px; max-height:250px;\">\r\n                    <h5 class=\"card-title\">");
            EndContext();
            BeginContext(513, 9, false);
#line 12 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Welcome\Tours.cshtml"
                                      Write(reis.Name);

#line default
#line hidden
            EndContext();
            BeginContext(522, 122, true);
            WriteLiteral("</h5>\r\n                    <p class=\"card-text hiddenscroll\" style=\"overflow:scroll;overflow-x:hidden; max-height:100px;\">");
            EndContext();
            BeginContext(645, 16, false);
#line 13 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Welcome\Tours.cshtml"
                                                                                                              Write(reis.Description);

#line default
#line hidden
            EndContext();
            BeginContext(661, 121, true);
            WriteLiteral("</p>\r\n                    <div style=\"display:flex;justify-content:center;margin-bottom:10px;\">\r\n                        ");
            EndContext();
            BeginContext(782, 105, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cf8fb083723a422fafba72a8ba85340f", async() => {
                BeginContext(876, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 15 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Welcome\Tours.cshtml"
                                                                        WriteLiteral(reis.Id);

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
            BeginContext(887, 90, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 20 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Welcome\Tours.cshtml"
    }

#line default
#line hidden
            BeginContext(984, 6, true);
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Outdoor_paradise_webapp.Models.ReisViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
