#pragma checksum "C:\Kentico_Leaning\Kentico13_Git_TestFunction_DancingGoat_050423\DancingGoatCore\Views\Checkout\DisplayTemplates\CustomerViewModel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e6b9c073feee151a0197015d7906eb2df6019086"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Checkout_DisplayTemplates_CustomerViewModel), @"mvc.1.0.view", @"/Views/Checkout/DisplayTemplates/CustomerViewModel.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6b9c073feee151a0197015d7906eb2df6019086", @"/Views/Checkout/DisplayTemplates/CustomerViewModel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88d8fa80da67568a3e522497460b5cdcd2065f73", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Checkout_DisplayTemplates_CustomerViewModel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DancingGoat.Models.CustomerViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div>");
#nullable restore
#line 3 "C:\Kentico_Leaning\Kentico13_Git_TestFunction_DancingGoat_050423\DancingGoatCore\Views\Checkout\DisplayTemplates\CustomerViewModel.cshtml"
Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 3 "C:\Kentico_Leaning\Kentico13_Git_TestFunction_DancingGoat_050423\DancingGoatCore\Views\Checkout\DisplayTemplates\CustomerViewModel.cshtml"
                 Write(Model.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<div>");
#nullable restore
#line 4 "C:\Kentico_Leaning\Kentico13_Git_TestFunction_DancingGoat_050423\DancingGoatCore\Views\Checkout\DisplayTemplates\CustomerViewModel.cshtml"
Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<div>");
#nullable restore
#line 5 "C:\Kentico_Leaning\Kentico13_Git_TestFunction_DancingGoat_050423\DancingGoatCore\Views\Checkout\DisplayTemplates\CustomerViewModel.cshtml"
Write(Model.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 6 "C:\Kentico_Leaning\Kentico13_Git_TestFunction_DancingGoat_050423\DancingGoatCore\Views\Checkout\DisplayTemplates\CustomerViewModel.cshtml"
 if (Model.IsCompanyAccount)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <div>");
#nullable restore
#line 9 "C:\Kentico_Leaning\Kentico13_Git_TestFunction_DancingGoat_050423\DancingGoatCore\Views\Checkout\DisplayTemplates\CustomerViewModel.cshtml"
    Write(Model.Company);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    <div>");
#nullable restore
#line 10 "C:\Kentico_Leaning\Kentico13_Git_TestFunction_DancingGoat_050423\DancingGoatCore\Views\Checkout\DisplayTemplates\CustomerViewModel.cshtml"
    Write(Model.OrganizationID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    <div>");
#nullable restore
#line 11 "C:\Kentico_Leaning\Kentico13_Git_TestFunction_DancingGoat_050423\DancingGoatCore\Views\Checkout\DisplayTemplates\CustomerViewModel.cshtml"
    Write(Model.TaxRegistrationID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 12 "C:\Kentico_Leaning\Kentico13_Git_TestFunction_DancingGoat_050423\DancingGoatCore\Views\Checkout\DisplayTemplates\CustomerViewModel.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DancingGoat.Models.CustomerViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
