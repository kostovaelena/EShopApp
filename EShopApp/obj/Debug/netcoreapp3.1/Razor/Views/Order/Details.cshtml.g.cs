#pragma checksum "C:\Users\x\Desktop\EShopApp\EShopApp\Views\Order\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d1527e2394e13721881e5222b5c67992a2eade1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Details), @"mvc.1.0.view", @"/Views/Order/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d1527e2394e13721881e5222b5c67992a2eade1", @"/Views/Order/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8576d7ecbea8bb5d27fd9bc6fe4cb25a6538f2a0", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EShopApp.Domain.Order>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral("<div class=\"eden\" style=\"color:#fe87a7;\">\n\n    <div class=\"container\">\n\n        <p style=\"margin-left:500px\">\n            <a class=\"btn btn-outline-light\">");
#nullable restore
#line 8 "C:\Users\x\Desktop\EShopApp\EShopApp\Views\Order\Details.cshtml"
                                        Write(Model.User.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n        </p>\n\n");
#nullable restore
#line 11 "C:\Users\x\Desktop\EShopApp\EShopApp\Views\Order\Details.cshtml"
         for (int i = 0; i < Model.WineInOrders.Count(); i++)
        {
            var item = Model.WineInOrders.ElementAt(i).OrderedWine;

            if (i % 3 == 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            WriteLiteral("<div class=\"row\" style=\"line-height: 0; color:white\">\n");
#nullable restore
#line 18 "C:\Users\x\Desktop\EShopApp\EShopApp\Views\Order\Details.cshtml"
    }


#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-md-3 m-4\">\n        <div class=\"wrapper\">\n            <div class=\"product\">\n                <div class=\"imgbox\" style=\"background-color:white\"> <img");
            BeginWriteAttribute("src", " src=\"", 641, "\"", 658, 1);
#nullable restore
#line 23 "C:\Users\x\Desktop\EShopApp\EShopApp\Views\Order\Details.cshtml"
WriteAttributeValue("", 647, item.Image, 647, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> </div>\n                <div class=\"specifies\">\n                    <h2 style=\"color: white\">");
#nullable restore
#line 25 "C:\Users\x\Desktop\EShopApp\EShopApp\Views\Order\Details.cshtml"
                                        Write(item.Vinarija);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br></h2>\n                    <div class=\"price\">");
#nullable restore
#line 26 "C:\Users\x\Desktop\EShopApp\EShopApp\Views\Order\Details.cshtml"
                                  Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" МКД.</div>
                    <br />
                    <p style=""font-family: Century Gothic; margin-top: 15px; font-size: 14px; color:white"">Произведено е во</p>
                    <p style=""font-family: Century Gothic; margin-top: 22px; font-size: 14px; color:white"">");
#nullable restore
#line 29 "C:\Users\x\Desktop\EShopApp\EShopApp\Views\Order\Details.cshtml"
                                                                                                      Write(item.Zemja);

#line default
#line hidden
#nullable disable
            WriteLiteral(" во <b> ");
#nullable restore
#line 29 "C:\Users\x\Desktop\EShopApp\EShopApp\Views\Order\Details.cshtml"
                                                                                                                         Write(item.Godina);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> год.</p>\n\n                  \n                </div>\n            </div>\n\n");
            WriteLiteral("        </div>\n\n    </div> ");
#nullable restore
#line 41 "C:\Users\x\Desktop\EShopApp\EShopApp\Views\Order\Details.cshtml"
           if (i % 3 == 2)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            WriteLiteral("</div>\n");
#nullable restore
#line 44 "C:\Users\x\Desktop\EShopApp\EShopApp\Views\Order\Details.cshtml"
}

}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EShopApp.Domain.Order> Html { get; private set; }
    }
}
#pragma warning restore 1591