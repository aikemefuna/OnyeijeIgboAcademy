#pragma checksum "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\StCourseEnrollments\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e27bec83b54e757d9a7d1b891e1dc86b7130176e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_StCourseEnrollments_Delete), @"mvc.1.0.view", @"/Views/StCourseEnrollments/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/StCourseEnrollments/Delete.cshtml", typeof(AspNetCore.Views_StCourseEnrollments_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e27bec83b54e757d9a7d1b891e1dc86b7130176e", @"/Views/StCourseEnrollments/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34f1e347ba21b0f56e0e9b066f616c277af2767a", @"/Views/_ViewImports.cshtml")]
    public class Views_StCourseEnrollments_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OnyeijeSchool.Models.StCourseEnrollment>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(48, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\StCourseEnrollments\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(92, 188, true);
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>StCourseEnrollment</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(281, 46, false);
#line 15 "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\StCourseEnrollments\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.IsApproved));

#line default
#line hidden
            EndContext();
            BeginContext(327, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(391, 42, false);
#line 18 "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\StCourseEnrollments\Delete.cshtml"
       Write(Html.DisplayFor(model => model.IsApproved));

#line default
#line hidden
            EndContext();
            BeginContext(433, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(496, 47, false);
#line 21 "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\StCourseEnrollments\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.IsCompleted));

#line default
#line hidden
            EndContext();
            BeginContext(543, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(607, 43, false);
#line 24 "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\StCourseEnrollments\Delete.cshtml"
       Write(Html.DisplayFor(model => model.IsCompleted));

#line default
#line hidden
            EndContext();
            BeginContext(650, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(713, 43, false);
#line 27 "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\StCourseEnrollments\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Student));

#line default
#line hidden
            EndContext();
            BeginContext(756, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(820, 56, false);
#line 30 "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\StCourseEnrollments\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Student.StudentFirstName));

#line default
#line hidden
            EndContext();
            BeginContext(876, 68, true);
            WriteLiteral("\r\n        </dd class>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(945, 46, false);
#line 33 "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\StCourseEnrollments\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.AdmCourses));

#line default
#line hidden
            EndContext();
            BeginContext(991, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1055, 51, false);
#line 36 "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\StCourseEnrollments\Delete.cshtml"
       Write(Html.DisplayFor(model => model.AdmCourses.CourseId));

#line default
#line hidden
            EndContext();
            BeginContext(1106, 68, true);
            WriteLiteral("\r\n        </dd class>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1175, 48, false);
#line 39 "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\StCourseEnrollments\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ApprovedDate));

#line default
#line hidden
            EndContext();
            BeginContext(1223, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1287, 44, false);
#line 42 "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\StCourseEnrollments\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ApprovedDate));

#line default
#line hidden
            EndContext();
            BeginContext(1331, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1394, 47, false);
#line 45 "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\StCourseEnrollments\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DateCreated));

#line default
#line hidden
            EndContext();
            BeginContext(1441, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1505, 43, false);
#line 48 "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\StCourseEnrollments\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DateCreated));

#line default
#line hidden
            EndContext();
            BeginContext(1548, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1611, 47, false);
#line 51 "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\StCourseEnrollments\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.UserCreated));

#line default
#line hidden
            EndContext();
            BeginContext(1658, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1722, 43, false);
#line 54 "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\StCourseEnrollments\Delete.cshtml"
       Write(Html.DisplayFor(model => model.UserCreated));

#line default
#line hidden
            EndContext();
            BeginContext(1765, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1828, 48, false);
#line 57 "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\StCourseEnrollments\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DateModified));

#line default
#line hidden
            EndContext();
            BeginContext(1876, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1940, 44, false);
#line 60 "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\StCourseEnrollments\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DateModified));

#line default
#line hidden
            EndContext();
            BeginContext(1984, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2047, 48, false);
#line 63 "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\StCourseEnrollments\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.UserModified));

#line default
#line hidden
            EndContext();
            BeginContext(2095, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2159, 44, false);
#line 66 "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\StCourseEnrollments\Delete.cshtml"
       Write(Html.DisplayFor(model => model.UserModified));

#line default
#line hidden
            EndContext();
            BeginContext(2203, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(2241, 206, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e27bec83b54e757d9a7d1b891e1dc86b7130176e13328", async() => {
                BeginContext(2267, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(2277, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e27bec83b54e757d9a7d1b891e1dc86b7130176e13721", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 71 "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\StCourseEnrollments\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2313, 83, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                EndContext();
                BeginContext(2396, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e27bec83b54e757d9a7d1b891e1dc86b7130176e15646", async() => {
                    BeginContext(2418, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2434, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2447, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OnyeijeSchool.Models.StCourseEnrollment> Html { get; private set; }
    }
}
#pragma warning restore 1591