#pragma checksum "C:\Users\Ought2018\source\repos\Ecom\Ecom\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f18faa0eab7f2e95869bee727a9a844998490e1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/Index.cshtml", typeof(AspNetCore.Views_Product_Index))]
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
#line 1 "C:\Users\Ought2018\source\repos\Ecom\Ecom\Views\_ViewImports.cshtml"
using Ecom;

#line default
#line hidden
#line 2 "C:\Users\Ought2018\source\repos\Ecom\Ecom\Views\_ViewImports.cshtml"
using Ecom.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f18faa0eab7f2e95869bee727a9a844998490e1", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4821c05eaf6eb340aa43bf49ef175b1eb1ed8737", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Ecom.Models.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ProductDetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Ought2018\source\repos\Ecom\Ecom\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "_FrontendLayout";

#line default
#line hidden
            BeginContext(162, 246, true);
            WriteLiteral("\r\n<div class=\"container-fluid\">\r\n    <div class=\"row bg-title text-center text-uppercase\">\r\n        <div class=\"col-md-12\">\r\n            <h4 class=\"page-title\">Products</h4>\r\n        </div>\r\n    </div>\r\n    <!-- /.row -->\r\n    <div class=\"row\">\r\n");
            EndContext();
#line 16 "C:\Users\Ought2018\source\repos\Ecom\Ecom\Views\Product\Index.cshtml"
         foreach (var prod in Model)
        {

#line default
#line hidden
            BeginContext(457, 176, true);
            WriteLiteral("            <div class=\"col-lg-3 col-md-3 col-sm-6 col-xs-12\">\r\n                <div class=\"white-box\">\r\n                    <div class=\"product-img\">\r\n                        ");
            EndContext();
            BeginContext(633, 44, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2f18faa0eab7f2e95869bee727a9a844998490e14835", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
            AddHtmlAttributeValue("", 643, "~/uploads/", 643, 10, true);
#line 21 "C:\Users\Ought2018\source\repos\Ecom\Ecom\Views\Product\Index.cshtml"
AddHtmlAttributeValue("", 653, prod.ProductImagePath, 653, 22, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(677, 139, true);
            WriteLiteral("\r\n\r\n                    </div>\r\n                    <div class=\"product-text\">\r\n                        <span class=\"pro-price bg-inverse\">");
            EndContext();
            BeginContext(817, 14, false);
#line 25 "C:\Users\Ought2018\source\repos\Ecom\Ecom\Views\Product\Index.cshtml"
                                                      Write(prod.UnitPrice);

#line default
#line hidden
            EndContext();
            BeginContext(831, 33, true);
            WriteLiteral("</span>\r\n                        ");
            EndContext();
            BeginContext(864, 107, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f18faa0eab7f2e95869bee727a9a844998490e16958", async() => {
                BeginContext(951, 16, false);
#line 26 "C:\Users\Ought2018\source\repos\Ecom\Ecom\Views\Product\Index.cshtml"
                                                                                                         Write(prod.ProductName);

#line default
#line hidden
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
#line 26 "C:\Users\Ought2018\source\repos\Ecom\Ecom\Views\Product\Index.cshtml"
                                                                                 WriteLiteral(prod.ProductID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(971, 55, true);
            WriteLiteral("\r\n                        <small class=\"text-muted db\">");
            EndContext();
            BeginContext(1027, 11, false);
#line 27 "C:\Users\Ought2018\source\repos\Ecom\Ecom\Views\Product\Index.cshtml"
                                                Write(prod.Detail);

#line default
#line hidden
            EndContext();
            BeginContext(1038, 82, true);
            WriteLiteral("</small>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 31 "C:\Users\Ought2018\source\repos\Ecom\Ecom\Views\Product\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1131, 37, true);
            WriteLiteral("\r\n    </div>\r\n    <!--row -->\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Ecom.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
