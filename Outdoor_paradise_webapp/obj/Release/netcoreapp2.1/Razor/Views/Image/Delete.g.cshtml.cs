#pragma checksum "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Image\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13999d8015f43ba7cc8869dfbaa6339ecbadaca1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Image_Delete), @"mvc.1.0.view", @"/Views/Image/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Image/Delete.cshtml", typeof(AspNetCore.Views_Image_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13999d8015f43ba7cc8869dfbaa6339ecbadaca1", @"/Views/Image/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99258386c31a0232d3fe439693cc897483acd694", @"/Views/_ViewImports.cshtml")]
    public class Views_Image_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Image>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(14, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Image\Delete.cshtml"
  
	ViewData["Title"] = "Delete";
	Layout = "../Shared/_MarketingLayout.cshtml";

#line default
#line hidden
            BeginContext(103, 205, true);
            WriteLiteral("\r\n<div class=\"card\">\r\n\t<div class=\"card-header\">\r\n\t\t<h2>Delete</h2>\r\n\t</div>\r\n\t<div class=\"card-body\">\r\n\t\t<h5 class=\"card-title\">Are you sure you want to delete this?</h5>\r\n\t\t<h5 class=\"card-title\">Image: ");
            EndContext();
            BeginContext(309, 10, false);
#line 14 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Image\Delete.cshtml"
                                 Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(319, 9, true);
            WriteLiteral("</h5>\r\n\t\t");
            EndContext();
            BeginContext(328, 216, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87da1f0845b347f4842432cac929b016", async() => {
                BeginContext(354, 5, true);
                WriteLiteral("\r\n\t\t\t");
                EndContext();
                BeginContext(359, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1ab6fb13cd0c4a40a2a1d9e95ba36858", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 16 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Image\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

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
                BeginContext(395, 71, true);
                WriteLiteral("\r\n\t\t\t<input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" />\r\n\t\t\t");
                EndContext();
                BeginContext(466, 67, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2685da411c374cdcb8b1ff4b6812cf6e", async() => {
                    BeginContext(517, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
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
                BeginContext(533, 4, true);
                WriteLiteral("\r\n\t\t");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(544, 399, true);
            WriteLiteral(@"
		<hr />
		<div class=""rowoverride"">
			<div class=""coloverride"">
				<div class=""card"" style=""width: 18rem;margin-bottom:10px;"">
					<div class=""card-header"">
						<h4>Image Info</h4>
					</div>
				</div>
				<div class=""card"" style=""width: 18rem;margin-bottom:10px;"">
					<div class=""card-body"">
						<h6 class=""card-subtitle mb-2 text-muted"">Id</h6>
						<p class=""card-text"">");
            EndContext();
            BeginContext(944, 34, false);
#line 31 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Image\Delete.cshtml"
                                        Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(978, 212, true);
            WriteLiteral("</p>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t\t<div class=\"card\" style=\"width: 18rem;margin-bottom:10px;\">\r\n\t\t\t\t\t<div class=\"card-body\">\r\n\t\t\t\t\t\t<h6 class=\"card-subtitle mb-2 text-muted\">Name</h6>\r\n\t\t\t\t\t\t<p class=\"card-text\">");
            EndContext();
            BeginContext(1191, 36, false);
#line 37 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Image\Delete.cshtml"
                                        Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1227, 215, true);
            WriteLiteral("</p>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t\t<div class=\"card\" style=\"width: 18rem;margin-bottom:10px;\">\r\n\t\t\t\t\t<div class=\"card-body\">\r\n\t\t\t\t\t\t<h6 class=\"card-subtitle mb-2 text-muted\">Product</h6>\r\n\t\t\t\t\t\t<p class=\"card-text\">");
            EndContext();
            BeginContext(1443, 42, false);
#line 43 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Image\Delete.cshtml"
                                        Write(Html.DisplayFor(model => model.Product_id));

#line default
#line hidden
            EndContext();
            BeginContext(1485, 218, true);
            WriteLiteral("</p>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t\t<div class=\"card\" style=\"width: 18rem;margin-bottom:10px;\">\r\n\t\t\t\t\t<div class=\"card-body\">\r\n\t\t\t\t\t\t<h6 class=\"card-subtitle mb-2 text-muted\">Image path</h6>\r\n\t\t\t\t\t\t<p class=\"card-text\">");
            EndContext();
            BeginContext(1704, 41, false);
#line 49 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Image\Delete.cshtml"
                                        Write(Html.DisplayFor(model => model.Imagepath));

#line default
#line hidden
            EndContext();
            BeginContext(1745, 196, true);
            WriteLiteral("</p>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t\t<div class=\"card\" style=\"width: 18rem;margin-bottom:10px;\">\r\n\t\t\t\t\t<div class=\"card-body\">\r\n\t\t\t\t\t\t<h6 class=\"card-subtitle mb-2 text-muted\">Image</h6>\r\n\t\t\t\t\t\t<img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1941, "\"", 1989, 1);
#line 55 "C:\Users\lauw2\Documents\Projects\Outdoor_paradise_webapp\Outdoor_paradise_webapp\Views\Image\Delete.cshtml"
WriteAttributeValue("", 1947, Html.DisplayFor(model => model.Imagepath), 1947, 42, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1990, 105, true);
            WriteLiteral(" style=\"width:200px;height:100px\" />\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Image> Html { get; private set; }
    }
}
#pragma warning restore 1591