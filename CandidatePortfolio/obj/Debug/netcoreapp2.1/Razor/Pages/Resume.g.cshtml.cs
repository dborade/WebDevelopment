#pragma checksum "C:\Users\darsh\Documents\GitHub\IS7012\HelloWorld\Pages\Resume.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03076f67e8495c0e70cd2ab3ea2404ae7ea86021"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(HelloWorld.Pages.Pages_Resume), @"mvc.1.0.razor-page", @"/Pages/Resume.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Resume.cshtml", typeof(HelloWorld.Pages.Pages_Resume), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03076f67e8495c0e70cd2ab3ea2404ae7ea86021", @"/Pages/Resume.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a66ee5e1da4a0905bae254e20323296a4c565f4", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Resume : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(34, 4, true);
            WriteLiteral("<h1>");
            EndContext();
            BeginContext(39, 17, false);
#line 5 "C:\Users\darsh\Documents\GitHub\IS7012\HelloWorld\Pages\Resume.cshtml"
Write(Model.Person.Name);

#line default
#line hidden
            EndContext();
            BeginContext(56, 46, true);
            WriteLiteral("</h1>\r\n<h4 style = \"color:cornflowerblue;\"><i>");
            EndContext();
            BeginContext(103, 18, false);
#line 6 "C:\Users\darsh\Documents\GitHub\IS7012\HelloWorld\Pages\Resume.cshtml"
                                  Write(Model.Person.Email);

#line default
#line hidden
            EndContext();
            BeginContext(121, 83, true);
            WriteLiteral("</i></h4>\r\n\r\n\r\n<h3 style = \"background-color:thistle\">Education</h3>\r\n<hr>\r\n<div>\r\n");
            EndContext();
#line 12 "C:\Users\darsh\Documents\GitHub\IS7012\HelloWorld\Pages\Resume.cshtml"
       foreach(var Education in Model.Person.Educations) {
            

#line default
#line hidden
            BeginContext(278, 54, true);
            WriteLiteral("            <h4 style = \"background-color: lightcyan\">");
            EndContext();
            BeginContext(333, 24, false);
#line 14 "C:\Users\darsh\Documents\GitHub\IS7012\HelloWorld\Pages\Resume.cshtml"
                                                 Write(Education.UniversityName);

#line default
#line hidden
            EndContext();
            BeginContext(357, 7, true);
            WriteLiteral("</h4>\r\n");
            EndContext();
            BeginContext(378, 19, true);
            WriteLiteral("                <p>");
            EndContext();
            BeginContext(398, 21, false);
#line 16 "C:\Users\darsh\Documents\GitHub\IS7012\HelloWorld\Pages\Resume.cshtml"
              Write(Education.CollegeName);

#line default
#line hidden
            EndContext();
            BeginContext(419, 25, true);
            WriteLiteral("</p>\r\n                <p>");
            EndContext();
            BeginContext(445, 20, false);
#line 17 "C:\Users\darsh\Documents\GitHub\IS7012\HelloWorld\Pages\Resume.cshtml"
              Write(Education.DegreeName);

#line default
#line hidden
            EndContext();
            BeginContext(465, 25, true);
            WriteLiteral("</p>\r\n                <p>");
            EndContext();
            BeginContext(491, 13, false);
#line 18 "C:\Users\darsh\Documents\GitHub\IS7012\HelloWorld\Pages\Resume.cshtml"
              Write(Education.GPA);

#line default
#line hidden
            EndContext();
            BeginContext(504, 25, true);
            WriteLiteral("</p>\r\n                <p>");
            EndContext();
            BeginContext(530, 28, false);
#line 19 "C:\Users\darsh\Documents\GitHub\IS7012\HelloWorld\Pages\Resume.cshtml"
              Write(Education.RelevantCoursework);

#line default
#line hidden
            EndContext();
            BeginContext(558, 25, true);
            WriteLiteral("</p>\r\n                <p>");
            EndContext();
            BeginContext(584, 24, false);
#line 20 "C:\Users\darsh\Documents\GitHub\IS7012\HelloWorld\Pages\Resume.cshtml"
              Write(Education.Certifications);

#line default
#line hidden
            EndContext();
            BeginContext(608, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 21 "C:\Users\darsh\Documents\GitHub\IS7012\HelloWorld\Pages\Resume.cshtml"
           
      }

#line default
#line hidden
            BeginContext(636, 94, true);
            WriteLiteral("</div>\r\n\r\n<h3 style = \"background-color:thistle\">Professional Experience</h3>\r\n<hr>\r\n\r\n<div>\r\n");
            EndContext();
#line 29 "C:\Users\darsh\Documents\GitHub\IS7012\HelloWorld\Pages\Resume.cshtml"
       foreach(var Experience in Model.Person.Experiences) {

#line default
#line hidden
            BeginContext(792, 46, true);
            WriteLiteral("            <ul>\r\n                <blockquote>");
            EndContext();
            BeginContext(839, 22, false);
#line 31 "C:\Users\darsh\Documents\GitHub\IS7012\HelloWorld\Pages\Resume.cshtml"
                       Write(Experience.CompanyName);

#line default
#line hidden
            EndContext();
            BeginContext(861, 35, true);
            WriteLiteral("</blockquote>\r\n                <li>");
            EndContext();
            BeginContext(897, 22, false);
#line 32 "C:\Users\darsh\Documents\GitHub\IS7012\HelloWorld\Pages\Resume.cshtml"
               Write(Experience.Designation);

#line default
#line hidden
            EndContext();
            BeginContext(919, 27, true);
            WriteLiteral("</li>\r\n                <li>");
            EndContext();
            BeginContext(947, 18, false);
#line 33 "C:\Users\darsh\Documents\GitHub\IS7012\HelloWorld\Pages\Resume.cshtml"
               Write(Experience.Project);

#line default
#line hidden
            EndContext();
            BeginContext(965, 27, true);
            WriteLiteral("</li>\r\n                <li>");
            EndContext();
            BeginContext(993, 17, false);
#line 34 "C:\Users\darsh\Documents\GitHub\IS7012\HelloWorld\Pages\Resume.cshtml"
               Write(Experience.Tenure);

#line default
#line hidden
            EndContext();
            BeginContext(1010, 27, true);
            WriteLiteral("</li>\r\n                <li>");
            EndContext();
            BeginContext(1038, 15, false);
#line 35 "C:\Users\darsh\Documents\GitHub\IS7012\HelloWorld\Pages\Resume.cshtml"
               Write(Experience.City);

#line default
#line hidden
            EndContext();
            BeginContext(1053, 27, true);
            WriteLiteral("</li>\r\n                <li>");
            EndContext();
            BeginContext(1081, 18, false);
#line 36 "C:\Users\darsh\Documents\GitHub\IS7012\HelloWorld\Pages\Resume.cshtml"
               Write(Experience.Country);

#line default
#line hidden
            EndContext();
            BeginContext(1099, 27, true);
            WriteLiteral("</li>\r\n                <li>");
            EndContext();
            BeginContext(1127, 28, false);
#line 37 "C:\Users\darsh\Documents\GitHub\IS7012\HelloWorld\Pages\Resume.cshtml"
               Write(Experience.ExperienceDetails);

#line default
#line hidden
            EndContext();
            BeginContext(1155, 25, true);
            WriteLiteral("</li>\r\n           </ul>\r\n");
            EndContext();
#line 39 "C:\Users\darsh\Documents\GitHub\IS7012\HelloWorld\Pages\Resume.cshtml"
      }

#line default
#line hidden
            BeginContext(1189, 77, true);
            WriteLiteral("</div>\r\n\r\n<h3 style = \"background-color:thistle\">Projects</h3>\r\n<hr>\r\n<div>\r\n");
            EndContext();
#line 45 "C:\Users\darsh\Documents\GitHub\IS7012\HelloWorld\Pages\Resume.cshtml"
       foreach(var Project in Model.Person.Projects) {
            

#line default
#line hidden
            BeginContext(1336, 21, true);
            WriteLiteral("                <div>");
            EndContext();
            BeginContext(1358, 12, false);
#line 47 "C:\Users\darsh\Documents\GitHub\IS7012\HelloWorld\Pages\Resume.cshtml"
                Write(Project.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1370, 29, true);
            WriteLiteral("</div>\r\n                <div>");
            EndContext();
            BeginContext(1400, 14, false);
#line 48 "C:\Users\darsh\Documents\GitHub\IS7012\HelloWorld\Pages\Resume.cshtml"
                Write(Project.Skills);

#line default
#line hidden
            EndContext();
            BeginContext(1414, 29, true);
            WriteLiteral("</div>\r\n                <div>");
            EndContext();
            BeginContext(1444, 12, false);
#line 49 "C:\Users\darsh\Documents\GitHub\IS7012\HelloWorld\Pages\Resume.cshtml"
                Write(Project.Info);

#line default
#line hidden
            EndContext();
            BeginContext(1456, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
#line 50 "C:\Users\darsh\Documents\GitHub\IS7012\HelloWorld\Pages\Resume.cshtml"
           
      }

#line default
#line hidden
            BeginContext(1486, 75, true);
            WriteLiteral("</div>\r\n\r\n<h3 style = \"background-color:thistle\">Skills</h3>\r\n<hr>\r\n<div>\r\n");
            EndContext();
#line 57 "C:\Users\darsh\Documents\GitHub\IS7012\HelloWorld\Pages\Resume.cshtml"
       foreach(var Skillset in Model.Person.Skillsets) {
            

#line default
#line hidden
            BeginContext(1633, 21, true);
            WriteLiteral("                <div>");
            EndContext();
            BeginContext(1655, 17, false);
#line 59 "C:\Users\darsh\Documents\GitHub\IS7012\HelloWorld\Pages\Resume.cshtml"
                Write(Skillset.Language);

#line default
#line hidden
            EndContext();
            BeginContext(1672, 29, true);
            WriteLiteral("</div>\r\n                <div>");
            EndContext();
            BeginContext(1702, 14, false);
#line 60 "C:\Users\darsh\Documents\GitHub\IS7012\HelloWorld\Pages\Resume.cshtml"
                Write(Skillset.Tools);

#line default
#line hidden
            EndContext();
            BeginContext(1716, 29, true);
            WriteLiteral("</div>\r\n                <div>");
            EndContext();
            BeginContext(1746, 18, false);
#line 61 "C:\Users\darsh\Documents\GitHub\IS7012\HelloWorld\Pages\Resume.cshtml"
                Write(Skillset.Addskills);

#line default
#line hidden
            EndContext();
            BeginContext(1764, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
#line 62 "C:\Users\darsh\Documents\GitHub\IS7012\HelloWorld\Pages\Resume.cshtml"
           
      }

#line default
#line hidden
            BeginContext(1794, 8, true);
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ResumeModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ResumeModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ResumeModel>)PageContext?.ViewData;
        public ResumeModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591