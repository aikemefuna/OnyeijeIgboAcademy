#pragma checksum "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\Questions\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0071e30df992b7eeb2a4de3d57f4ef2e92c6b81a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Questions_Delete), @"mvc.1.0.view", @"/Views/Questions/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Questions/Delete.cshtml", typeof(AspNetCore.Views_Questions_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0071e30df992b7eeb2a4de3d57f4ef2e92c6b81a", @"/Views/Questions/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34f1e347ba21b0f56e0e9b066f616c277af2767a", @"/Views/_ViewImports.cshtml")]
    public class Views_Questions_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OnyeijeSchool.Models.Questions>
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
#line 3 "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\Questions\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(83, 179, true);
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Questions</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(263, 46, false);
#line 15 "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\Questions\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.AdmCourses));

#line default
#line hidden
            EndContext();
            BeginContext(309, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(373, 51, false);
#line 18 "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\Questions\Delete.cshtml"
       Write(Html.DisplayFor(model => model.AdmCourses.CourseId));

#line default
#line hidden
            EndContext();
            BeginContext(424, 68, true);
            WriteLiteral("\r\n        </dd class>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(493, 48, false);
#line 21 "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\Questions\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Instructions));

#line default
#line hidden
            EndContext();
            BeginContext(541, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(605, 44, false);
#line 24 "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\Questions\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Instructions));

#line default
#line hidden
            EndContext();
            BeginContext(649, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(712, 44, false);
#line 27 "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\Questions\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Question));

#line default
#line hidden
            EndContext();
            BeginContext(756, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(820, 40, false);
#line 30 "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\Questions\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Question));

#line default
#line hidden
            EndContext();
            BeginContext(860, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(923, 43, false);
#line 33 "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\Questions\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Option1));

#line default
#line hidden
            EndContext();
            BeginContext(966, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1030, 39, false);
#line 36 "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\Questions\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Option1));

#line default
#line hidden
            EndContext();
            BeginContext(1069, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1132, 43, false);
#line 39 "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\Questions\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Option2));

#line default
#line hidden
            EndContext();
            BeginContext(1175, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1239, 39, false);
#line 42 "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\Questions\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Option2));

#line default
#line hidden
            EndContext();
            BeginContext(1278, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1341, 43, false);
#line 45 "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\Questions\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Option3));

#line default
#line hidden
            EndContext();
            BeginContext(1384, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1448, 39, false);
#line 48 "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\Questions\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Option3));

#line default
#line hidden
            EndContext();
            BeginContext(1487, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1550, 43, false);
#line 51 "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\Questions\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Option4));

#line default
#line hidden
            EndContext();
            BeginContext(1593, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1657, 39, false);
#line 54 "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\Questions\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Option4));

#line default
#line hidden
            EndContext();
            BeginContext(1696, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1759, 47, false);
#line 57 "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\Questions\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.RightAnswer));

#line default
#line hidden
            EndContext();
            BeginContext(1806, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1870, 43, false);
#line 60 "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\Questions\Delete.cshtml"
       Write(Html.DisplayFor(model => model.RightAnswer));

#line default
#line hidden
            EndContext();
            BeginContext(1913, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1976, 47, false);
#line 63 "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\Questions\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DateCreated));

#line default
#line hidden
            EndContext();
            BeginContext(2023, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2087, 43, false);
#line 66 "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\Questions\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DateCreated));

#line default
#line hidden
            EndContext();
            BeginContext(2130, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2193, 47, false);
#line 69 "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\Questions\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.UserCreated));

#line default
#line hidden
            EndContext();
            BeginContext(2240, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2304, 43, false);
#line 72 "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\Questions\Delete.cshtml"
       Write(Html.DisplayFor(model => model.UserCreated));

#line default
#line hidden
            EndContext();
            BeginContext(2347, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2410, 48, false);
#line 75 "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\Questions\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DateModified));

#line default
#line hidden
            EndContext();
            BeginContext(2458, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2522, 44, false);
#line 78 "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\Questions\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DateModified));

#line default
#line hidden
            EndContext();
            BeginContext(2566, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2629, 48, false);
#line 81 "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\Questions\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.UserModified));

#line default
#line hidden
            EndContext();
            BeginContext(2677, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2741, 44, false);
#line 84 "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\Questions\Delete.cshtml"
       Write(Html.DisplayFor(model => model.UserModified));

#line default
#line hidden
            EndContext();
            BeginContext(2785, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(2823, 211, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0071e30df992b7eeb2a4de3d57f4ef2e92c6b81a15618", async() => {
                BeginContext(2849, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(2859, 41, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0071e30df992b7eeb2a4de3d57f4ef2e92c6b81a16011", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 89 "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\Questions\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.QuestId);

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
                BeginContext(2900, 83, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                EndContext();
                BeginContext(2983, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0071e30df992b7eeb2a4de3d57f4ef2e92c6b81a17931", async() => {
                    BeginContext(3005, 12, true);
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
                BeginContext(3021, 6, true);
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
            BeginContext(3034, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OnyeijeSchool.Models.Questions> Html { get; private set; }
    }
}
#pragma warning restore 1591
