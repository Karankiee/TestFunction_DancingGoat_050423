#pragma checksum "C:\Kentico_Leaning\Kentico13_Git_TestFunction_DancingGoat_050423\DancingGoatCore\Views\Product\_PriceDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f4d40162cc64ea309ccf689562c95f615e0a94e8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product__PriceDetails), @"mvc.1.0.view", @"/Views/Product/_PriceDetails.cshtml")]
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
#line 1 "C:\Kentico_Leaning\Kentico13_Git_TestFunction_DancingGoat_050423\DancingGoatCore\Views\_ViewImports.cshtml"
using DancingGoat;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Kentico_Leaning\Kentico13_Git_TestFunction_DancingGoat_050423\DancingGoatCore\Views\_ViewImports.cshtml"
using CMS.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Kentico_Leaning\Kentico13_Git_TestFunction_DancingGoat_050423\DancingGoatCore\Views\_ViewImports.cshtml"
using Kentico.Web.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Kentico_Leaning\Kentico13_Git_TestFunction_DancingGoat_050423\DancingGoatCore\Views\_ViewImports.cshtml"
using Kentico.Content.Web.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Kentico_Leaning\Kentico13_Git_TestFunction_DancingGoat_050423\DancingGoatCore\Views\_ViewImports.cshtml"
using Kentico.PageBuilder.Web.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Kentico_Leaning\Kentico13_Git_TestFunction_DancingGoat_050423\DancingGoatCore\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Kentico_Leaning\Kentico13_Git_TestFunction_DancingGoat_050423\DancingGoatCore\Views\Product\_PriceDetails.cshtml"
using CMS.Ecommerce;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4d40162cc64ea309ccf689562c95f615e0a94e8", @"/Views/Product/_PriceDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88d8fa80da67568a3e522497460b5cdcd2065f73", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Product__PriceDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DancingGoat.Models.ProductViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Kentico_Leaning\Kentico13_Git_TestFunction_DancingGoat_050423\DancingGoatCore\Views\Product\_PriceDetails.cshtml"
  
    var price = Model.PriceDetail;
    var currency = price.Currency;
    var discount = price.StandardPrice - price.Price;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"price-details\">\r\n");
#nullable restore
#line 11 "C:\Kentico_Leaning\Kentico13_Git_TestFunction_DancingGoat_050423\DancingGoatCore\Views\Product\_PriceDetails.cshtml"
     if (price.ListPrice > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\r\n            <div class=\"col-xs-6\">List price</div>\r\n            <div class=\"col-xs-6\">");
#nullable restore
#line 15 "C:\Kentico_Leaning\Kentico13_Git_TestFunction_DancingGoat_050423\DancingGoatCore\Views\Product\_PriceDetails.cshtml"
                             Write(string.Format(currency.CurrencyFormatString, price.ListPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        </div>\r\n");
#nullable restore
#line 17 "C:\Kentico_Leaning\Kentico13_Git_TestFunction_DancingGoat_050423\DancingGoatCore\Views\Product\_PriceDetails.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div");
            BeginWriteAttribute("class", " class=\"", 487, "\"", 543, 2);
            WriteAttributeValue("", 495, "discount-price", 495, 14, true);
#nullable restore
#line 19 "C:\Kentico_Leaning\Kentico13_Git_TestFunction_DancingGoat_050423\DancingGoatCore\Views\Product\_PriceDetails.cshtml"
WriteAttributeValue(" ", 509, (discount > 0) ? "" : "hidden", 510, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <div class=\"row\">\r\n            <div class=\"col-xs-6\">");
#nullable restore
#line 21 "C:\Kentico_Leaning\Kentico13_Git_TestFunction_DancingGoat_050423\DancingGoatCore\Views\Product\_PriceDetails.cshtml"
                             Write(HtmlLocalizer["Price"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <div id=\"js-before-discount\" class=\"col-xs-6\">");
#nullable restore
#line 22 "C:\Kentico_Leaning\Kentico13_Git_TestFunction_DancingGoat_050423\DancingGoatCore\Views\Product\_PriceDetails.cshtml"
                                                     Write(string.Format(currency.CurrencyFormatString, price.StandardPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        </div>\r\n");
#nullable restore
#line 24 "C:\Kentico_Leaning\Kentico13_Git_TestFunction_DancingGoat_050423\DancingGoatCore\Views\Product\_PriceDetails.cshtml"
         if (price.Price > 0)
        {
            var discountPercentage = Math.Round(discount * 100 / price.StandardPrice);


#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"row\">\r\n                <div class=\"col-xs-6\">");
#nullable restore
#line 29 "C:\Kentico_Leaning\Kentico13_Git_TestFunction_DancingGoat_050423\DancingGoatCore\Views\Product\_PriceDetails.cshtml"
                                 Write(HtmlLocalizer["You save"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                <div id=\"js-savings\" class=\"col-xs-6\">");
#nullable restore
#line 30 "C:\Kentico_Leaning\Kentico13_Git_TestFunction_DancingGoat_050423\DancingGoatCore\Views\Product\_PriceDetails.cshtml"
                                                 Write(string.Format(currency.CurrencyFormatString, discount));

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 30 "C:\Kentico_Leaning\Kentico13_Git_TestFunction_DancingGoat_050423\DancingGoatCore\Views\Product\_PriceDetails.cshtml"
                                                                                                           Write(discountPercentage);

#line default
#line hidden
#nullable disable
            WriteLiteral("%)</div>\r\n            </div>\r\n");
#nullable restore
#line 32 "C:\Kentico_Leaning\Kentico13_Git_TestFunction_DancingGoat_050423\DancingGoatCore\Views\Product\_PriceDetails.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHtmlLocalizer<SharedResources> HtmlLocalizer { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DancingGoat.Models.ProductViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
