#pragma checksum "C:\Users\x\Desktop\EShopApp\EShopApp\Views\ShoppingCart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2444b420f42e817e5f8403322cfa77c9e80c7038"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ShoppingCart_Index), @"mvc.1.0.view", @"/Views/ShoppingCart/Index.cshtml")]
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
#line 1 "C:\Users\x\Desktop\EShopApp\EShopApp\Views\_ViewImports.cshtml"
using EShopApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\x\Desktop\EShopApp\EShopApp\Views\_ViewImports.cshtml"
using EShopApp.Domain;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\x\Desktop\EShopApp\EShopApp\Views\ShoppingCart\Index.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2444b420f42e817e5f8403322cfa77c9e80c7038", @"/Views/ShoppingCart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8576d7ecbea8bb5d27fd9bc6fe4cb25a6538f2a0", @"/Views/_ViewImports.cshtml")]
    public class Views_ShoppingCart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EShopApp.Domain.ShoppingCartDto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ShoppingCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteFromShoppingCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PayOrder", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 5 "C:\Users\x\Desktop\EShopApp\EShopApp\Views\ShoppingCart\Index.cshtml"
   ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<br />
<div class=""eden"" style=""color:white"">
    <div class=""container"">
        <h1 style=""text-align: center; color:white""><i>Вашата кошничка</i></h1>
        <br />

        <div class=""row m-4"">
            <table class=""table"" style=""color:white; font-size:20px; "">
                <thead class=""thead-light"">
                    <tr>
                        <th scope=""col"" style=""color: #fe87a7"">#</th>
                        <th scope=""col"" style=""color: #fe87a7"">Wine</th>
                        <th scope=""col"" style=""color: #fe87a7"">Quantity</th>
                        <th scope=""col"" style=""color: #fe87a7"">Price</th>
                        <th></th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 26 "C:\Users\x\Desktop\EShopApp\EShopApp\Views\ShoppingCart\Index.cshtml"
                     if (Model.Wines.Count == 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td colspan=\"5\" style=\"color:white; text-align:center; font-size:25px\"><b>No active Products</b></td>\n        </tr> ");
#nullable restore
#line 30 "C:\Users\x\Desktop\EShopApp\EShopApp\Views\ShoppingCart\Index.cshtml"
              }
                    else
                    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\x\Desktop\EShopApp\EShopApp\Views\ShoppingCart\Index.cshtml"
         for (int i = 0; i < Model.Wines.Count; i++)
        {
            var item = Model.Wines[i];


#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\n        <th scope=\"row\">");
#nullable restore
#line 38 "C:\Users\x\Desktop\EShopApp\EShopApp\Views\ShoppingCart\Index.cshtml"
                    Write(i + 1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n        <td><b>");
#nullable restore
#line 39 "C:\Users\x\Desktop\EShopApp\EShopApp\Views\ShoppingCart\Index.cshtml"
          Write(item.Wine.Vinarija);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></td>\n        <td><b>");
#nullable restore
#line 40 "C:\Users\x\Desktop\EShopApp\EShopApp\Views\ShoppingCart\Index.cshtml"
          Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></td>\n        <td><b>");
#nullable restore
#line 41 "C:\Users\x\Desktop\EShopApp\EShopApp\Views\ShoppingCart\Index.cshtml"
          Write(item.Wine.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></td>\n        <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2444b420f42e817e5f8403322cfa77c9e80c70388066", async() => {
                WriteLiteral("Delete this item");
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
#nullable restore
#line 42 "C:\Users\x\Desktop\EShopApp\EShopApp\Views\ShoppingCart\Index.cshtml"
                                                                                   WriteLiteral(item.WineId);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("</td>\n    </tr>");
#nullable restore
#line 43 "C:\Users\x\Desktop\EShopApp\EShopApp\Views\ShoppingCart\Index.cshtml"
         }

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\x\Desktop\EShopApp\EShopApp\Views\ShoppingCart\Index.cshtml"
          }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </tbody>
                <tfoot class=""thead-light"">
                    <tr>
                        <th scope=""col"" style=""color: #fe87a7"">Total Price:</th>
                        <th scope=""col""></th>
                        <th scope=""col""></th>
                        <th scope=""col""></th>
                        <th scope=""col"" style=""color: #fe87a7"">$");
#nullable restore
#line 51 "C:\Users\x\Desktop\EShopApp\EShopApp\Views\ShoppingCart\Index.cshtml"
                                                           Write(Model.TotalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                    </tr>\n                </tfoot>\n            </table>\n        </div>\n\n");
            WriteLiteral("        <div class=\"row m-4\">\n\n\n");
#nullable restore
#line 63 "C:\Users\x\Desktop\EShopApp\EShopApp\Views\ShoppingCart\Index.cshtml"
             if (Model.TotalPrice != 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2444b420f42e817e5f8403322cfa77c9e80c703811985", async() => {
                WriteLiteral("\n        <article style=\" margin-left: 456px;\">\n            <script src=\"https://checkout.stripe.com/checkout.js\"\n                    class=\"stripe-button\"\n                    data-key=\"");
#nullable restore
#line 69 "C:\Users\x\Desktop\EShopApp\EShopApp\Views\ShoppingCart\Index.cshtml"
                         Write(Stripe.Value.PublishableKey);

#line default
#line hidden
#nullable disable
                WriteLiteral("\"\n                    data-locale=\"auto\"\n                    data-description=\"EShop Application Payment\"\n                    data-amount=\"");
#nullable restore
#line 72 "C:\Users\x\Desktop\EShopApp\EShopApp\Views\ShoppingCart\Index.cshtml"
                             Write(Model.TotalPrice * 100);

#line default
#line hidden
#nullable disable
                WriteLiteral("\"\n                    data-label=\"Pay ");
#nullable restore
#line 73 "C:\Users\x\Desktop\EShopApp\EShopApp\Views\ShoppingCart\Index.cshtml"
                               Write(Model.TotalPrice);

#line default
#line hidden
#nullable disable
                WriteLiteral(" MKD\"></script>\n        </article>\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
#nullable restore
#line 75 "C:\Users\x\Desktop\EShopApp\EShopApp\Views\ShoppingCart\Index.cshtml"
           }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n\n    </div>\n\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IOptions<EShopApp.Domain.StripeSettings> Stripe { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EShopApp.Domain.ShoppingCartDto> Html { get; private set; }
    }
}
#pragma warning restore 1591
