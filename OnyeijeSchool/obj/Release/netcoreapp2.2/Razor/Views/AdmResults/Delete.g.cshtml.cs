#pragma checksum "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\AdmResults\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f59085d5ae743be24906b5b33392f929610e8a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdmResults_Delete), @"mvc.1.0.view", @"/Views/AdmResults/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AdmResults/Delete.cshtml", typeof(AspNetCore.Views_AdmResults_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f59085d5ae743be24906b5b33392f929610e8a4", @"/Views/AdmResults/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34f1e347ba21b0f56e0e9b066f616c277af2767a", @"/Views/_ViewImports.cshtml")]
    public class Views_AdmResults_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OnyeijeSchool.Models.AdmResult>
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
            BeginContext(39, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\AdmResults\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(83, 177, true);
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>AdmResult</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(261, 47, false);
#line 15 "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\AdmResults\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.StudentName));

#line default
#line hidden
            EndContext();
            BeginContext(308, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(370, 43, false);
#line 18 "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\AdmResults\Delete.cshtml"
       Write(Html.DisplayFor(model => model.StudentName));

#line default
#line hidden
            EndContext();
            BeginContext(413, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(474, 44, false);
#line 21 "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\AdmResults\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ExamName));

#line default
#line hidden
            EndContext();
            BeginContext(518, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(580, 40, false);
#line 24 "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\AdmResults\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ExamName));

#line default
#line hidden
            EndContext();
            BeginContext(620, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(681, 42, false);
#line 27 "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\AdmResults\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Course));

#line default
#line hidden
            EndContext();
            BeginContext(723, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(785, 38, false);
#line 30 "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\AdmResults\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Course));

#line default
#line hidden
            EndContext();
            BeginContext(823, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(884, 50, false);
#line 33 "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\AdmResults\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TotalQuestions));

#line default
#line hidden
            EndContext();
            BeginContext(934, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(996, 46, false);
#line 36 "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\AdmResults\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TotalQuestions));

#line default
#line hidden
            EndContext();
            BeginContext(1042, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1103, 45, false);
#line 39 "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\AdmResults\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Attempted));

#line default
#line hidden
            EndContext();
            BeginContext(1148, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1210, 41, false);
#line 42 "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\AdmResults\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Attempted));

#line default
#line hidden
            EndContext();
            BeginContext(1251, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1312, 48, false);
#line 45 "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\AdmResults\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.NotAttempted));

#line default
#line hidden
            EndContext();
            BeginContext(1360, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1422, 44, false);
#line 48 "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\AdmResults\Delete.cshtml"
       Write(Html.DisplayFor(model => model.NotAttempted));

#line default
#line hidden
            EndContext();
            BeginContext(1466, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1527, 43, false);
#line 51 "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\AdmResults\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Correct));

#line default
#line hidden
            EndContext();
            BeginContext(1570, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1632, 39, false);
#line 54 "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\AdmResults\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Correct));

#line default
#line hidden
            EndContext();
            BeginContext(1671, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1732, 45, false);
#line 57 "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\AdmResults\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.InCorrect));

#line default
#line hidden
            EndContext();
            BeginContext(1777, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1839, 41, false);
#line 60 "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\AdmResults\Delete.cshtml"
       Write(Html.DisplayFor(model => model.InCorrect));

#line default
#line hidden
            EndContext();
            BeginContext(1880, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1941, 41, false);
#line 63 "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\AdmResults\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Score));

#line default
#line hidden
            EndContext();
            BeginContext(1982, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2044, 37, false);
#line 66 "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\AdmResults\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Score));

#line default
#line hidden
            EndContext();
            BeginContext(2081, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2142, 47, false);
#line 69 "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\AdmResults\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DateCreated));

#line default
#line hidden
            EndContext();
            BeginContext(2189, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2251, 43, false);
#line 72 "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\AdmResults\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DateCreated));

#line default
#line hidden
            EndContext();
            BeginContext(2294, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2355, 47, false);
#line 75 "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\AdmResults\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.UserCreated));

#line default
#line hidden
            EndContext();
            BeginContext(2402, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2464, 43, false);
#line 78 "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\AdmResults\Delete.cshtml"
       Write(Html.DisplayFor(model => model.UserCreated));

#line default
#line hidden
            EndContext();
            BeginContext(2507, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2568, 48, false);
#line 81 "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\AdmResults\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DateModified));

#line default
#line hidden
            EndContext();
            BeginContext(2616, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2678, 44, false);
#line 84 "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\AdmResults\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DateModified));

#line default
#line hidden
            EndContext();
            BeginContext(2722, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2783, 48, false);
#line 87 "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\AdmResults\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.UserModified));

#line default
#line hidden
            EndContext();
            BeginContext(2831, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2893, 44, false);
#line 90 "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\AdmResults\Delete.cshtml"
       Write(Html.DisplayFor(model => model.UserModified));

#line default
#line hidden
            EndContext();
            BeginContext(2937, 34, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n\r\n    ");
            EndContext();
            BeginContext(2971, 212, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f59085d5ae743be24906b5b33392f929610e8a416455", async() => {
                BeginContext(2997, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(3007, 42, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5f59085d5ae743be24906b5b33392f929610e8a416848", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 95 "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\AdmResults\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ResultId);

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
                BeginContext(3049, 83, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                EndContext();
                BeginContext(3132, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f59085d5ae743be24906b5b33392f929610e8a418770", async() => {
                    BeginContext(3154, 12, true);
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
                BeginContext(3170, 6, true);
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
            BeginContext(3183, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OnyeijeSchool.Models.AdmResult> Html { get; private set; }
    }
}
#pragma warning restore 1591
