#pragma checksum "C:\Users\esgrd\source\repos\VantagePoint.DK31.Dev\VantagePoint\VantagePoint.Web\Modules\AdvancedSamples\Editors\ProductPicker\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c6e62222f4042686ac120a13128e0ab07fabaa9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Modules_AdvancedSamples_Editors_ProductPicker_Index), @"mvc.1.0.view", @"/Modules/AdvancedSamples/Editors/ProductPicker/Index.cshtml")]
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
#line 1 "C:\Users\esgrd\source\repos\VantagePoint.DK31.Dev\VantagePoint\VantagePoint.Web\Modules\_ViewImports.cshtml"
using Serenity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\esgrd\source\repos\VantagePoint.DK31.Dev\VantagePoint\VantagePoint.Web\Modules\_ViewImports.cshtml"
using Serenity.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\esgrd\source\repos\VantagePoint.DK31.Dev\VantagePoint\VantagePoint.Web\Modules\_ViewImports.cshtml"
using VantagePoint;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\esgrd\source\repos\VantagePoint.DK31.Dev\VantagePoint\VantagePoint.Web\Modules\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\esgrd\source\repos\VantagePoint.DK31.Dev\VantagePoint\VantagePoint.Web\Modules\_ViewImports.cshtml"
using System.Text;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c6e62222f4042686ac120a13128e0ab07fabaa9", @"/Modules/AdvancedSamples/Editors/ProductPicker/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80744f0d30d3774e02a8d83691fd1a0c9313f33d", @"/Modules/_ViewImports.cshtml")]
    public class Modules_AdvancedSamples_Editors_ProductPicker_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\esgrd\source\repos\VantagePoint.DK31.Dev\VantagePoint\VantagePoint.Web\Modules\AdvancedSamples\Editors\ProductPicker\Index.cshtml"
  
    ViewData["Title"] = "Product Picker";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Head", async() => {
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("ContentHeader", async() => {
                WriteLiteral("\r\n    <h1>");
#nullable restore
#line 9 "C:\Users\esgrd\source\repos\VantagePoint.DK31.Dev\VantagePoint\VantagePoint.Web\Modules\AdvancedSamples\Editors\ProductPicker\Index.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("<small></small></h1>\r\n");
            }
            );
            WriteLiteral(@"
<div class=""alert alert-info alert-dismissable"">
    <button type=""button"" class=""close"" data-dismiss=""alert"" aria-hidden=""true"">&times;</button>
    <p>This is a modified version of Northwind Order dialog that provides a Product Picker for selecting products to add details.</p>
    <p>Open an order record and click <b>Pick Products</b> button.</p>

    <p style=""text-align: right;""><b>Source Files:</b> 
        ");
#nullable restore
#line 18 "C:\Users\esgrd\source\repos\VantagePoint.DK31.Dev\VantagePoint\VantagePoint.Web\Modules\AdvancedSamples\Editors\ProductPicker\Index.cshtml"
   Write(Html.PremiumSourceFile("Index.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral(",\r\n        ");
#nullable restore
#line 19 "C:\Users\esgrd\source\repos\VantagePoint.DK31.Dev\VantagePoint\VantagePoint.Web\Modules\AdvancedSamples\Editors\ProductPicker\Index.cshtml"
   Write(Html.PremiumSourceFile("PickerOrderDetailsEditor.ts"));

#line default
#line hidden
#nullable disable
            WriteLiteral(", \r\n        ");
#nullable restore
#line 20 "C:\Users\esgrd\source\repos\VantagePoint.DK31.Dev\VantagePoint\VantagePoint.Web\Modules\AdvancedSamples\Editors\ProductPicker\Index.cshtml"
   Write(Html.PremiumSourceFile("PickerOrderDialog.ts"));

#line default
#line hidden
#nullable disable
            WriteLiteral(",\r\n        ");
#nullable restore
#line 21 "C:\Users\esgrd\source\repos\VantagePoint.DK31.Dev\VantagePoint\VantagePoint.Web\Modules\AdvancedSamples\Editors\ProductPicker\Index.cshtml"
   Write(Html.PremiumSourceFile("PickerOrderForm.cs"));

#line default
#line hidden
#nullable disable
            WriteLiteral(",\r\n        ");
#nullable restore
#line 22 "C:\Users\esgrd\source\repos\VantagePoint.DK31.Dev\VantagePoint\VantagePoint.Web\Modules\AdvancedSamples\Editors\ProductPicker\Index.cshtml"
   Write(Html.PremiumSourceFile("PickerOrderGrid.ts"));

#line default
#line hidden
#nullable disable
            WriteLiteral(",\r\n        ");
#nullable restore
#line 23 "C:\Users\esgrd\source\repos\VantagePoint.DK31.Dev\VantagePoint\VantagePoint.Web\Modules\AdvancedSamples\Editors\ProductPicker\Index.cshtml"
   Write(Html.PremiumSourceFile("ProductCheckGrid.ts"));

#line default
#line hidden
#nullable disable
            WriteLiteral(",\r\n        ");
#nullable restore
#line 24 "C:\Users\esgrd\source\repos\VantagePoint.DK31.Dev\VantagePoint\VantagePoint.Web\Modules\AdvancedSamples\Editors\ProductPicker\Index.cshtml"
   Write(Html.PremiumSourceFile("ProductPickerDialog.ts"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 25 "C:\Users\esgrd\source\repos\VantagePoint.DK31.Dev\VantagePoint\VantagePoint.Web\Modules\AdvancedSamples\Editors\ProductPicker\Index.cshtml"
          await Html.RenderPartialAsync("~/Modules/AdvancedSamples/PremiumSourceWarning.cshtml");

#line default
#line hidden
#nullable disable
            WriteLiteral("    </p>\r\n</div>\r\n\r\n<div id=\"GridDiv\"></div>\r\n\r\n<script type=\"text/javascript\">\r\n    jQuery(function () {\r\n        new VantagePoint.AdvancedSamples.PickerOrderGrid($(\'#GridDiv\'));\r\n        Q.initFullHeightGridPage($(\'#GridDiv\'));\r\n    });\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591