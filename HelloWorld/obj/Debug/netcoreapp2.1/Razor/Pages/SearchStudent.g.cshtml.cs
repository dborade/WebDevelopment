#pragma checksum "C:\Users\darsh\Documents\GitHub\IS7012\HelloWorld\Pages\SearchStudent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f022bf249b3b26fe55127e6319033ce12c163b8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(HelloWorld.Pages.Pages_SearchStudent), @"mvc.1.0.razor-page", @"/Pages/SearchStudent.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/SearchStudent.cshtml", typeof(HelloWorld.Pages.Pages_SearchStudent), null)]
namespace HelloWorld.Pages
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f022bf249b3b26fe55127e6319033ce12c163b8", @"/Pages/SearchStudent.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a66ee5e1da4a0905bae254e20323296a4c565f4", @"/Pages/_ViewImports.cshtml")]
    public class Pages_SearchStudent : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-top: 50px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(41, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(45, 398, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "67dc112045b64188b2e494a4e3cec65c", async() => {
                BeginContext(101, 177, true);
                WriteLiteral("\r\n  <div class=\"form-group\">\r\n    <label class=\"control-label\" for=\"search\">University Name</label>\r\n    <input type=\"text\" class=\"form-control\" name=\"searchstudent\" id=\"search\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 278, "\"", 306, 1);
#line 10 "C:\Users\darsh\Documents\GitHub\IS7012\HelloWorld\Pages\SearchStudent.cshtml"
WriteAttributeValue("", 286, Model.SearchStudent, 286, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(307, 129, true);
                WriteLiteral(" />\r\n  </div>\r\n  <div class=\"form-group\">\r\n    <input type=\"submit\" value=\"Search Student\" class=\"btn btn-default\" />\r\n  </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
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
            BeginContext(443, 8, true);
            WriteLiteral("\r\n\r\n\r\n\r\n");
            EndContext();
#line 19 "C:\Users\darsh\Documents\GitHub\IS7012\HelloWorld\Pages\SearchStudent.cshtml"
 if(Model.SearchCompleted) {

#line default
#line hidden
            BeginContext(481, 253, true);
            WriteLiteral("    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>Student Name</th>\r\n                <th>Degree Name</th>\r\n                <th>University Name</th>\r\n                \r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 30 "C:\Users\darsh\Documents\GitHub\IS7012\HelloWorld\Pages\SearchStudent.cshtml"
             if(Model.SearchResults.Count > 0) {
                

#line default
#line hidden
#line 31 "C:\Users\darsh\Documents\GitHub\IS7012\HelloWorld\Pages\SearchStudent.cshtml"
                 foreach(var Education in Model.SearchResults) {

#line default
#line hidden
            BeginContext(850, 54, true);
            WriteLiteral("                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(905, 22, false);
#line 33 "C:\Users\darsh\Documents\GitHub\IS7012\HelloWorld\Pages\SearchStudent.cshtml"
                       Write(Education.Profile.Name);

#line default
#line hidden
            EndContext();
            BeginContext(927, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(963, 20, false);
#line 34 "C:\Users\darsh\Documents\GitHub\IS7012\HelloWorld\Pages\SearchStudent.cshtml"
                       Write(Education.DegreeName);

#line default
#line hidden
            EndContext();
            BeginContext(983, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1019, 24, false);
#line 35 "C:\Users\darsh\Documents\GitHub\IS7012\HelloWorld\Pages\SearchStudent.cshtml"
                       Write(Education.UniversityName);

#line default
#line hidden
            EndContext();
            BeginContext(1043, 34, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n");
            EndContext();
#line 37 "C:\Users\darsh\Documents\GitHub\IS7012\HelloWorld\Pages\SearchStudent.cshtml"
                }

#line default
#line hidden
#line 37 "C:\Users\darsh\Documents\GitHub\IS7012\HelloWorld\Pages\SearchStudent.cshtml"
                 
            } else {

#line default
#line hidden
            BeginContext(1118, 146, true);
            WriteLiteral("                <tr class=\"danger\">\r\n                    <td colspan=\"4\" class=\"text-center\">\r\n                        No results found for term \"");
            EndContext();
            BeginContext(1265, 19, false);
#line 41 "C:\Users\darsh\Documents\GitHub\IS7012\HelloWorld\Pages\SearchStudent.cshtml"
                                              Write(Model.SearchStudent);

#line default
#line hidden
            EndContext();
            BeginContext(1284, 53, true);
            WriteLiteral("\"\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 44 "C:\Users\darsh\Documents\GitHub\IS7012\HelloWorld\Pages\SearchStudent.cshtml"
            }

#line default
#line hidden
            BeginContext(1352, 32, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
            EndContext();
#line 47 "C:\Users\darsh\Documents\GitHub\IS7012\HelloWorld\Pages\SearchStudent.cshtml"
} else {

#line default
#line hidden
            BeginContext(1394, 166, true);
            WriteLiteral("    <div class=\"alert alert-info\">\r\n        <p>\r\n            Enter the search terms into the box and click <strong>Search student</strong>\r\n        </p>\r\n    </div>\r\n");
            EndContext();
#line 53 "C:\Users\darsh\Documents\GitHub\IS7012\HelloWorld\Pages\SearchStudent.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SearchStudentModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SearchStudentModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SearchStudentModel>)PageContext?.ViewData;
        public SearchStudentModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
