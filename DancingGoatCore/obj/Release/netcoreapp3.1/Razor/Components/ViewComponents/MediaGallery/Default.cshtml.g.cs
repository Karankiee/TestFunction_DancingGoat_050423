#pragma checksum "C:\Kentico_Leaning\Kentico13_Git_TestFunction_DancingGoat_050423\DancingGoatCore\Components\ViewComponents\MediaGallery\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d03238ca77f4fe93e69e9276ec4b0942980bb34c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Components_ViewComponents_MediaGallery_Default), @"mvc.1.0.view", @"/Components/ViewComponents/MediaGallery/Default.cshtml")]
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
#line 1 "C:\Kentico_Leaning\Kentico13_Git_TestFunction_DancingGoat_050423\DancingGoatCore\Components\_ViewImports.cshtml"
using DancingGoat;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Kentico_Leaning\Kentico13_Git_TestFunction_DancingGoat_050423\DancingGoatCore\Components\_ViewImports.cshtml"
using CMS.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Kentico_Leaning\Kentico13_Git_TestFunction_DancingGoat_050423\DancingGoatCore\Components\_ViewImports.cshtml"
using Kentico.Web.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Kentico_Leaning\Kentico13_Git_TestFunction_DancingGoat_050423\DancingGoatCore\Components\_ViewImports.cshtml"
using Kentico.Content.Web.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Kentico_Leaning\Kentico13_Git_TestFunction_DancingGoat_050423\DancingGoatCore\Components\_ViewImports.cshtml"
using Kentico.PageBuilder.Web.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Kentico_Leaning\Kentico13_Git_TestFunction_DancingGoat_050423\DancingGoatCore\Components\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d03238ca77f4fe93e69e9276ec4b0942980bb34c", @"/Components/ViewComponents/MediaGallery/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3dd21c4f465e83903a12d676a1dd0c01e2783b2", @"/Components/_ViewImports.cshtml")]
    #nullable restore
    public class Components_ViewComponents_MediaGallery_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DancingGoat.Models.MediaGalleryViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Kentico_Leaning\Kentico13_Git_TestFunction_DancingGoat_050423\DancingGoatCore\Components\ViewComponents\MediaGallery\Default.cshtml"
  
    int index = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"media-gallery\">\r\n    <div class=\"title-wrapper\">\r\n        <h1 class=\"title-tab\">");
#nullable restore
#line 8 "C:\Kentico_Leaning\Kentico13_Git_TestFunction_DancingGoat_050423\DancingGoatCore\Components\ViewComponents\MediaGallery\Default.cshtml"
                         Write(Model.MediaGalleryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    </div>\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 11 "C:\Kentico_Leaning\Kentico13_Git_TestFunction_DancingGoat_050423\DancingGoatCore\Components\ViewComponents\MediaGallery\Default.cshtml"
         foreach (var mediaFile in Model.MediaFiles)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div");
            BeginWriteAttribute("class", " class=\"", 316, "\"", 378, 4);
            WriteAttributeValue("", 324, "media-item", 324, 10, true);
            WriteAttributeValue(" ", 334, "col-lg-", 335, 8, true);
#nullable restore
#line 13 "C:\Kentico_Leaning\Kentico13_Git_TestFunction_DancingGoat_050423\DancingGoatCore\Components\ViewComponents\MediaGallery\Default.cshtml"
WriteAttributeValue("", 342, index++ == 0 ? "6" : "3", 342, 27, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 369, "col-md-6", 370, 9, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                <span class=\"cafe-overlay\"><span class=\"ourcoffee-tile-text center-text\">");
#nullable restore
#line 14 "C:\Kentico_Leaning\Kentico13_Git_TestFunction_DancingGoat_050423\DancingGoatCore\Components\ViewComponents\MediaGallery\Default.cshtml"
                                                                                    Write(mediaFile.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></span>\r\n                <div class=\"ratio-4-3\"");
            BeginWriteAttribute("style", " style=\"", 541, "\"", 610, 4);
            WriteAttributeValue("", 549, "background-image:", 549, 17, true);
            WriteAttributeValue(" ", 566, "url(\'", 567, 6, true);
#nullable restore
#line 15 "C:\Kentico_Leaning\Kentico13_Git_TestFunction_DancingGoat_050423\DancingGoatCore\Components\ViewComponents\MediaGallery\Default.cshtml"
WriteAttributeValue("", 572, Url.Content(mediaFile.RelativePath), 572, 36, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 608, "\')", 608, 2, true);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n            </div>\r\n");
#nullable restore
#line 17 "C:\Kentico_Leaning\Kentico13_Git_TestFunction_DancingGoat_050423\DancingGoatCore\Components\ViewComponents\MediaGallery\Default.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DancingGoat.Models.MediaGalleryViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
