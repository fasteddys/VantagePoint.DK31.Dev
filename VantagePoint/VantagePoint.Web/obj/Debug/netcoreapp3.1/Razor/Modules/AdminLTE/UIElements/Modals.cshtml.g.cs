#pragma checksum "C:\Users\esgrd\source\repos\VantagePoint.DK31.Dev\VantagePoint\VantagePoint.Web\Modules\AdminLTE\UIElements\Modals.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ec4a66d123fd1693f875d765a10aba7e103b2e2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Modules_AdminLTE_UIElements_Modals), @"mvc.1.0.view", @"/Modules/AdminLTE/UIElements/Modals.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ec4a66d123fd1693f875d765a10aba7e103b2e2", @"/Modules/AdminLTE/UIElements/Modals.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80744f0d30d3774e02a8d83691fd1a0c9313f33d", @"/Modules/_ViewImports.cshtml")]
    public class Modules_AdminLTE_UIElements_Modals : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/adminlte/demo.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\esgrd\source\repos\VantagePoint.DK31.Dev\VantagePoint\VantagePoint.Web\Modules\AdminLTE\UIElements\Modals.cshtml"
  
    ViewData["Title"] = "Modals";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Head", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ec4a66d123fd1693f875d765a10aba7e103b2e24593", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

    <style>
        .example-modal .modal {
            position: relative;
            top: auto;
            bottom: auto;
            right: auto;
            left: auto;
            display: block;
            z-index: 1;
        }

        .example-modal .modal {
            background: transparent !important;
        }
    </style>
");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("ContentHeader", async() => {
                WriteLiteral("\r\n    <h1>");
#nullable restore
#line 26 "C:\Users\esgrd\source\repos\VantagePoint.DK31.Dev\VantagePoint\VantagePoint.Web\Modules\AdminLTE\UIElements\Modals.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("<small></small></h1>\r\n");
            }
            );
            WriteLiteral(@"
<div class=""example-modal"">
    <div class=""modal"">
        <div class=""modal-dialog"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close""><span aria-hidden=""true"">&times;</span></button>
                    <h4 class=""modal-title"">Modal Default</h4>
                </div>
                <div class=""modal-body"">
                    <p>One fine body&hellip;</p>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-default pull-left"" data-dismiss=""modal"">Close</button>
                    <button type=""button"" class=""btn btn-primary"">Save changes</button>
                </div>
            </div><!-- /.modal-content -->
        </div><!-- /.modal-dialog -->
    </div><!-- /.modal -->
</div><!-- /.example-modal -->
<div class=""example-modal"">
    <div class=""modal modal-primary"">
        <div cla");
            WriteLiteral(@"ss=""modal-dialog"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close""><span aria-hidden=""true"">&times;</span></button>
                    <h4 class=""modal-title"">Modal Primary</h4>
                </div>
                <div class=""modal-body"">
                    <p>One fine body&hellip;</p>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-outline pull-left"" data-dismiss=""modal"">Close</button>
                    <button type=""button"" class=""btn btn-outline"">Save changes</button>
                </div>
            </div><!-- /.modal-content -->
        </div><!-- /.modal-dialog -->
    </div><!-- /.modal -->
</div><!-- /.example-modal -->
<div class=""example-modal"">
    <div class=""modal modal-info"">
        <div class=""modal-dialog"">
            <div class=""modal-content"">
              ");
            WriteLiteral(@"  <div class=""modal-header"">
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close""><span aria-hidden=""true"">&times;</span></button>
                    <h4 class=""modal-title"">Modal Info</h4>
                </div>
                <div class=""modal-body"">
                    <p>One fine body&hellip;</p>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-outline pull-left"" data-dismiss=""modal"">Close</button>
                    <button type=""button"" class=""btn btn-outline"">Save changes</button>
                </div>
            </div><!-- /.modal-content -->
        </div><!-- /.modal-dialog -->
    </div><!-- /.modal -->
</div><!-- /.example-modal -->
<div class=""example-modal"">
    <div class=""modal modal-warning"">
        <div class=""modal-dialog"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <button type=""button"" cla");
            WriteLiteral(@"ss=""close"" data-dismiss=""modal"" aria-label=""Close""><span aria-hidden=""true"">&times;</span></button>
                    <h4 class=""modal-title"">Modal Warning</h4>
                </div>
                <div class=""modal-body"">
                    <p>One fine body&hellip;</p>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-outline pull-left"" data-dismiss=""modal"">Close</button>
                    <button type=""button"" class=""btn btn-outline"">Save changes</button>
                </div>
            </div><!-- /.modal-content -->
        </div><!-- /.modal-dialog -->
    </div><!-- /.modal -->
</div><!-- /.example-modal -->
<div class=""example-modal"">
    <div class=""modal modal-success"">
        <div class=""modal-dialog"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close""><span aria-hidden=""tr");
            WriteLiteral(@"ue"">&times;</span></button>
                    <h4 class=""modal-title"">Modal Success</h4>
                </div>
                <div class=""modal-body"">
                    <p>One fine body&hellip;</p>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-outline pull-left"" data-dismiss=""modal"">Close</button>
                    <button type=""button"" class=""btn btn-outline"">Save changes</button>
                </div>
            </div><!-- /.modal-content -->
        </div><!-- /.modal-dialog -->
    </div><!-- /.modal -->
</div><!-- /.example-modal -->
<div class=""example-modal"">
    <div class=""modal modal-danger"">
        <div class=""modal-dialog"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close""><span aria-hidden=""true"">&times;</span></button>
                    <h4 class=""modal-title"">");
            WriteLiteral(@"Modal Danger</h4>
                </div>
                <div class=""modal-body"">
                    <p>One fine body&hellip;</p>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-outline pull-left"" data-dismiss=""modal"">Close</button>
                    <button type=""button"" class=""btn btn-outline"">Save changes</button>
                </div>
            </div><!-- /.modal-content -->
        </div><!-- /.modal-dialog -->
    </div><!-- /.modal -->
</div><!-- /.example-modal -->
");
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