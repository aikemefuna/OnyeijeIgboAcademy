#pragma checksum "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\AdmAssignments\Assignments.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b1a881c82b21ad9f9c597d3dc3d04f6d240ae145"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdmAssignments_Assignments), @"mvc.1.0.view", @"/Views/AdmAssignments/Assignments.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AdmAssignments/Assignments.cshtml", typeof(AspNetCore.Views_AdmAssignments_Assignments))]
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
#line 1 "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\_ViewImports.cshtml"
using OnyeijeSchool;

#line default
#line hidden
#line 2 "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\_ViewImports.cshtml"
using OnyeijeSchool.Models;

#line default
#line hidden
#line 4 "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1a881c82b21ad9f9c597d3dc3d04f6d240ae145", @"/Views/AdmAssignments/Assignments.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34f1e347ba21b0f56e0e9b066f616c277af2767a", @"/Views/_ViewImports.cshtml")]
    public class Views_AdmAssignments_Assignments : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OnyeijeSchool.Models.AdmAssignment>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\AdmAssignments\Assignments.cshtml"
  
    Layout = "~/Views/Shared/_SLayout.cshtml";
    ViewData["Title"] = "Assignments";

#line default
#line hidden
            BeginContext(152, 333, true);
            WriteLiteral(@"
<div class=""wizard-navigation"">
    <ul class=""nav nav-pills col-md-12"">
        <li class=""nav-item"">
            <a class=""nav-link active "" data-toggle=""tab"" role=""tab"">
                Assignment List
            </a>
        </li>
    </ul>


    <div class=""clearfix""></div>

</div>
<hr />

<div class=""row"">
");
            EndContext();
#line 23 "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\AdmAssignments\Assignments.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(524, 413, true);
            WriteLiteral(@"<div class=""col-lg-4"">

            <ul class=""timeline timeline-simple"">
                <li class=""timeline-inverted"">
                    <div class=""timeline-badge danger"">
                        <i class=""nc-icon nc-single-copy-04""></i>
                    </div>
                    <div class=""timeline-panel"">
                        <div class=""timeline-heading"">
                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 937, "\"", 1016, 1);
#line 33 "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\AdmAssignments\Assignments.cshtml"
WriteAttributeValue("", 944, Url.Action("Details", "AdmAssignments", new { id = item.AssignmentId }), 944, 72, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1017, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1019, 10, false);
#line 33 "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\AdmAssignments\Assignments.cshtml"
                                                                                                          Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1029, 218, true);
            WriteLiteral("</a>\r\n                        </div>\r\n                        <div class=\"timeline-body\">\r\n\r\n                        </div>\r\n                        <h6>\r\n                            <i class=\"ti-time\"></i> Given by:  ");
            EndContext();
            BeginContext(1248, 16, false);
#line 39 "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\AdmAssignments\Assignments.cshtml"
                                                          Write(item.UserCreated);

#line default
#line hidden
            EndContext();
            BeginContext(1264, 10, true);
            WriteLiteral(" on<br /> ");
            EndContext();
            BeginContext(1275, 16, false);
#line 39 "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\AdmAssignments\Assignments.cshtml"
                                                                                     Write(item.DateCreated);

#line default
#line hidden
            EndContext();
            BeginContext(1291, 121, true);
            WriteLiteral("\r\n                        </h6>\r\n                    </div>\r\n                </li>\r\n\r\n            </ul>\r\n        </div>\r\n");
            EndContext();
#line 46 "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\AdmAssignments\Assignments.cshtml"
    }

#line default
#line hidden
            BeginContext(1419, 6, true);
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<OnyeijeSchool.Models.AdmAssignment>> Html { get; private set; }
    }
}
#pragma warning restore 1591
