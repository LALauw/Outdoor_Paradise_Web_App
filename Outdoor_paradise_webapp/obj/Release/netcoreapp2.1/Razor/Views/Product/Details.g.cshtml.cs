#pragma checksum "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Product\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b3d0716dfa7ca14786e3749155fe865a6e7227d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Details), @"mvc.1.0.view", @"/Views/Product/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/Details.cshtml", typeof(AspNetCore.Views_Product_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b3d0716dfa7ca14786e3749155fe865a6e7227d", @"/Views/Product/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99258386c31a0232d3fe439693cc897483acd694", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductDetailsModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(28, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Product\Details.cshtml"
  
	ViewData["Title"] = "Details";
	Layout = "../Shared/_MarketingLayout.cshtml";

#line default
#line hidden
            BeginContext(118, 137, true);
            WriteLiteral("<div class=\"card\">\r\n\t<div class=\"card-header\">\r\n\t\t<h2>Details</h2>\r\n\t</div>\r\n\t<div class=\"card-body\">\r\n\t\t<h5 class=\"card-title\">Product: ");
            EndContext();
            BeginContext(256, 10, false);
#line 12 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Product\Details.cshtml"
                                   Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(266, 9, true);
            WriteLiteral("</h5>\r\n\t\t");
            EndContext();
            BeginContext(275, 78, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "733ee6f7826a407a95a20427c6839a76", async() => {
                BeginContext(345, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 13 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Product\Details.cshtml"
                               WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(353, 4, true);
            WriteLiteral("\r\n\t\t");
            EndContext();
            BeginContext(357, 89, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "094fe81924494d1bb6064d307b72b7b3", async() => {
                BeginContext(436, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 14 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Product\Details.cshtml"
                                 WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(446, 4, true);
            WriteLiteral("\r\n\t\t");
            EndContext();
            BeginContext(450, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de2363173a9346c1ad34e366af97fb8f", async() => {
                BeginContext(501, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(517, 365, true);
            WriteLiteral(@"
		<hr />
		<div class=""rowoverride"">
			<div class=""coloverride"">
				<div class=""card"" style=""width: 18rem;margin-bottom:10px;"">
					<div class=""card-header"">
						<h4>Product Info</h4>
					</div>
				</div>
				<div class=""card"" style=""width: 18rem;margin-bottom:10px;"">
					<div class=""card-body"">
						<h6 class=""card-subtitle mb-2 text-muted"">");
            EndContext();
            BeginContext(883, 38, false);
#line 26 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Product\Details.cshtml"
                                                             Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(921, 34, true);
            WriteLiteral("</h6>\r\n\t\t\t\t\t\t<p class=\"card-text\">");
            EndContext();
            BeginContext(956, 34, false);
#line 27 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Product\Details.cshtml"
                                        Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(990, 174, true);
            WriteLiteral("</p>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t\t<div class=\"card\" style=\"width: 18rem;margin-bottom:10px;\">\r\n\t\t\t\t\t<div class=\"card-body\">\r\n\t\t\t\t\t\t<h6 class=\"card-subtitle mb-2 text-muted\">");
            EndContext();
            BeginContext(1165, 40, false);
#line 32 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Product\Details.cshtml"
                                                             Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1205, 34, true);
            WriteLiteral("</h6>\r\n\t\t\t\t\t\t<p class=\"card-text\">");
            EndContext();
            BeginContext(1240, 36, false);
#line 33 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Product\Details.cshtml"
                                        Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1276, 219, true);
            WriteLiteral("</p>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t\t<div class=\"card\" style=\"width: 18rem;margin-bottom:10px;\">\r\n\t\t\t\t\t<div class=\"card-body\">\r\n\t\t\t\t\t\t<h6 class=\"card-subtitle mb-2 text-muted\">Description</h6>\r\n\t\t\t\t\t\t<p class=\"card-text\">");
            EndContext();
            BeginContext(1496, 43, false);
#line 39 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Product\Details.cshtml"
                                        Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1539, 216, true);
            WriteLiteral("</p>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t\t<div class=\"card\" style=\"width: 18rem;margin-bottom:10px;\">\r\n\t\t\t\t\t<div class=\"card-body\">\r\n\t\t\t\t\t\t<h6 class=\"card-subtitle mb-2 text-muted\">Category</h6>\r\n\t\t\t\t\t\t<p class=\"card-text\">");
            EndContext();
            BeginContext(1756, 40, false);
#line 45 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Product\Details.cshtml"
                                        Write(Html.DisplayFor(model => model.Category));

#line default
#line hidden
            EndContext();
            BeginContext(1796, 225, true);
            WriteLiteral("</p>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t\t<div class=\"card\" style=\"width: 18rem;margin-bottom:10px;\">\r\n\t\t\t\t\t<div class=\"card-body\">\r\n\t\t\t\t\t\t<h6 class=\"card-subtitle mb-2 text-muted\">Introduction date</h6>\r\n\t\t\t\t\t\t<p class=\"card-text\">");
            EndContext();
            BeginContext(2022, 49, false);
#line 51 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Product\Details.cshtml"
                                        Write(Html.DisplayFor(model => model.Introduction_date));

#line default
#line hidden
            EndContext();
            BeginContext(2071, 213, true);
            WriteLiteral("</p>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t\t<div class=\"card\" style=\"width: 18rem;margin-bottom:10px;\">\r\n\t\t\t\t\t<div class=\"card-body\">\r\n\t\t\t\t\t\t<h6 class=\"card-subtitle mb-2 text-muted\">Color</h6>\r\n\t\t\t\t\t\t<p class=\"card-text\">");
            EndContext();
            BeginContext(2285, 37, false);
#line 57 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Product\Details.cshtml"
                                        Write(Html.DisplayFor(model => model.Color));

#line default
#line hidden
            EndContext();
            BeginContext(2322, 212, true);
            WriteLiteral("</p>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t\t<div class=\"card\" style=\"width: 18rem;margin-bottom:10px;\">\r\n\t\t\t\t\t<div class=\"card-body\">\r\n\t\t\t\t\t\t<h6 class=\"card-subtitle mb-2 text-muted\">Size</h6>\r\n\t\t\t\t\t\t<p class=\"card-text\">");
            EndContext();
            BeginContext(2535, 36, false);
#line 63 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Product\Details.cshtml"
                                        Write(Html.DisplayFor(model => model.Size));

#line default
#line hidden
            EndContext();
            BeginContext(2571, 212, true);
            WriteLiteral("</p>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t\t<div class=\"card\" style=\"width: 18rem;margin-bottom:10px;\">\r\n\t\t\t\t\t<div class=\"card-body\">\r\n\t\t\t\t\t\t<h6 class=\"card-subtitle mb-2 text-muted\">Size</h6>\r\n\t\t\t\t\t\t<p class=\"card-text\">");
            EndContext();
            BeginContext(2784, 36, false);
#line 69 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Product\Details.cshtml"
                                        Write(Html.DisplayFor(model => model.Size));

#line default
#line hidden
            EndContext();
            BeginContext(2820, 220, true);
            WriteLiteral("</p>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t\t<div class=\"card\" style=\"width: 18rem;margin-bottom:10px;\">\r\n\t\t\t\t\t<div class=\"card-body\">\r\n\t\t\t\t\t\t<h6 class=\"card-subtitle mb-2 text-muted\">Product type</h6>\r\n\t\t\t\t\t\t<p class=\"card-text\">");
            EndContext();
            BeginContext(3041, 44, false);
#line 75 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Product\Details.cshtml"
                                        Write(Html.DisplayFor(model => model.Product_type));

#line default
#line hidden
            EndContext();
            BeginContext(3085, 402, true);
            WriteLiteral(@"</p>
					</div>
				</div>
			</div>
			<div class=""coloverride"">
				<div class=""card"" style=""width: 18rem;margin-bottom:10px;"">
					<div class=""card-header"">
						<h4>Cost Info</h4>
					</div>
				</div>
				<div class=""card"" style=""width: 18rem;margin-bottom:10px;"">
					<div class=""card-body"">
						<h6 class=""card-subtitle mb-2 text-muted"">Price</h6>
						<p class=""card-text"">");
            EndContext();
            BeginContext(3488, 37, false);
#line 88 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Product\Details.cshtml"
                                        Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(3525, 223, true);
            WriteLiteral("</p>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t\t<div class=\"card\" style=\"width: 18rem;margin-bottom:10px;\">\r\n\t\t\t\t\t<div class=\"card-body\">\r\n\t\t\t\t\t\t<h6 class=\"card-subtitle mb-2 text-muted\">Production cost</h6>\r\n\t\t\t\t\t\t<p class=\"card-text\">");
            EndContext();
            BeginContext(3749, 47, false);
#line 94 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Product\Details.cshtml"
                                        Write(Html.DisplayFor(model => model.Production_cost));

#line default
#line hidden
            EndContext();
            BeginContext(3796, 221, true);
            WriteLiteral("</p>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t\t<div class=\"card\" style=\"width: 18rem;margin-bottom:10px;\">\r\n\t\t\t\t\t<div class=\"card-body\">\r\n\t\t\t\t\t\t<h6 class=\"card-subtitle mb-2 text-muted\">Profit margin</h6>\r\n\t\t\t\t\t\t<p class=\"card-text\">");
            EndContext();
            BeginContext(4018, 45, false);
#line 100 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Product\Details.cshtml"
                                        Write(Html.DisplayFor(model => model.Profit_margin));

#line default
#line hidden
            EndContext();
            BeginContext(4063, 69, true);
            WriteLiteral("</p>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductDetailsModel> Html { get; private set; }
    }
}
#pragma warning restore 1591