#pragma checksum "C:\Users\darsh\Documents\GitHub\IS7012\HelloWorld\Pages\Experiences\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff899f3c38d25d49768397d6fb24152e00894b7f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(HelloWorld.Pages.Experiences.Pages_Experiences_Details), @"mvc.1.0.razor-page", @"/Pages/Experiences/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Experiences/Details.cshtml", typeof(HelloWorld.Pages.Experiences.Pages_Experiences_Details), null)]
namespace HelloWorld.Pages.Experiences
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\darsh\Documents\GitHub\IS7012\HelloWorld\Pages\_ViewImports.cshtml"
using HelloWorld;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff899f3c38d25d49768397d6fb24152e00894b7f", @"/Pages/Experiences/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a66ee5e1da4a0905bae254e20323296a4c565f4", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Experiences_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(57, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\darsh\Documents\GitHub\IS7012\HelloWorld\Pages\Experiences\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(102, 124, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Experience</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(227, 58, false);
#line 15 "C:\Users\darsh\Documents\GitHub\IS7012\HelloWorld\Pages\Experiences\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Experience.CompanyName));

#line default
#line hidden
            EndContext();
            BeginContext(285, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(329, 54, false);
#line 18 "C:\Users\darsh\Documents\GitHub\IS7012\HelloWorld\Pages\Experiences\Details.cshtml"
       Write(Html.DisplayFor(model => model.Experience.CompanyName));

#line default
#line hidden
            EndContext();
            BeginContext(383, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(427, 58, false);
#line 21 "C:\Users\darsh\Documents\GitHub\IS7012\HelloWorld\Pages\Experiences\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Experience.Designation));

#line default
#line hidden
            EndContext();
            BeginContext(485, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(529, 54, false);
#line 24 "C:\Users\darsh\Documents\GitHub\IS7012\HelloWorld\Pages\Experiences\Details.cshtml"
       Write(Html.DisplayFor(model => model.Experience.Designation));

#line default
#line hidden
            EndContext();
            BeginContext(583, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(627, 54, false);
#line 27 "C:\Users\darsh\Documents\GitHub\IS7012\HelloWorld\Pages\Experiences\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Experience.Project));

#line default
#line hidden
            EndContext();
            BeginContext(681, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(725, 50, false);
#line 30 "C:\Users\darsh\Documents\GitHub\IS7012\HelloWorld\Pages\Experiences\Details.cshtml"
       Write(Html.DisplayFor(model => model.Experience.Project));

#line default
#line hidden
            EndContext();
            BeginContext(775, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(819, 53, false);
#line 33 "C:\Users\darsh\Documents\GitHub\IS7012\HelloWorld\Pages\Experiences\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Experience.Tenure));

#line default
#line hidden
            EndContext();
            BeginContext(872, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(916, 49, false);
#line 36 "C:\Users\darsh\Documents\GitHub\IS7012\HelloWorld\Pages\Experiences\Details.cshtml"
       Write(Html.DisplayFor(model => model.Experience.Tenure));

#line default
#line hidden
            EndContext();
            BeginContext(965, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1009, 51, false);
#line 39 "C:\Users\darsh\Documents\GitHub\IS7012\HelloWorld\Pages\Experiences\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Experience.City));

#line default
#line hidden
            EndContext();
            BeginContext(1060, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1104, 47, false);
#line 42 "C:\Users\darsh\Documents\GitHub\IS7012\HelloWorld\Pages\Experiences\Details.cshtml"
       Write(Html.DisplayFor(model => model.Experience.City));

#line default
#line hidden
            EndContext();
            BeginContext(1151, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1195, 54, false);
#line 45 "C:\Users\darsh\Documents\GitHub\IS7012\HelloWorld\Pages\Experiences\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Experience.Country));

#line default
#line hidden
            EndContext();
            BeginContext(1249, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1293, 50, false);
#line 48 "C:\Users\darsh\Documents\GitHub\IS7012\HelloWorld\Pages\Experiences\Details.cshtml"
       Write(Html.DisplayFor(model => model.Experience.Country));

#line default
#line hidden
            EndContext();
            BeginContext(1343, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1387, 64, false);
#line 51 "C:\Users\darsh\Documents\GitHub\IS7012\HelloWorld\Pages\Experiences\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Experience.ExperienceDetails));

#line default
#line hidden
            EndContext();
            BeginContext(1451, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1495, 60, false);
#line 54 "C:\Users\darsh\Documents\GitHub\IS7012\HelloWorld\Pages\Experiences\Details.cshtml"
       Write(Html.DisplayFor(model => model.Experience.ExperienceDetails));

#line default
#line hidden
            EndContext();
            BeginContext(1555, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1599, 54, false);
#line 57 "C:\Users\darsh\Documents\GitHub\IS7012\HelloWorld\Pages\Experiences\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Experience.Profile));

#line default
#line hidden
            EndContext();
            BeginContext(1653, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1697, 53, false);
#line 60 "C:\Users\darsh\Documents\GitHub\IS7012\HelloWorld\Pages\Experiences\Details.cshtml"
       Write(Html.DisplayFor(model => model.Experience.Profile.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1750, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1797, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3f2ec76515f49eda6f5ab481065aad1", async() => {
                BeginContext(1854, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 65 "C:\Users\darsh\Documents\GitHub\IS7012\HelloWorld\Pages\Experiences\Details.cshtml"
                           WriteLiteral(Model.Experience.Id);

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
            BeginContext(1862, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1870, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "105115bb5e11457a85c513d7cfbdff81", async() => {
                BeginContext(1892, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1908, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HelloWorld.Pages.Experiences.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HelloWorld.Pages.Experiences.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HelloWorld.Pages.Experiences.DetailsModel>)PageContext?.ViewData;
        public HelloWorld.Pages.Experiences.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
