#pragma checksum "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\Blogs\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b7a4b0410be3c82bbeb8e4daa1e35461377c4ae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blogs_Index), @"mvc.1.0.view", @"/Views/Blogs/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Blogs/Index.cshtml", typeof(AspNetCore.Views_Blogs_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b7a4b0410be3c82bbeb8e4daa1e35461377c4ae", @"/Views/Blogs/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34f1e347ba21b0f56e0e9b066f616c277af2767a", @"/Views/_ViewImports.cshtml")]
    public class Views_Blogs_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OnyeijeSchool.Models.Blog>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(47, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\Blogs\Index.cshtml"
  
    ViewBag.Title = "Index";

#line default
#line hidden
            BeginContext(86, 288, true);
            WriteLiteral(@"<div class=""wizard-navigation"">
    <ul class=""nav nav-pills col-md-12"">
        <li class=""nav-item"">
            <a class=""nav-link active "" data-toggle=""tab"" role=""tab"">
                Blog List
            </a>
        </li>
    </ul>
    <div class=""pull-right"">
        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 374, "\"", 411, 1);
#line 15 "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\Blogs\Index.cshtml"
WriteAttributeValue("", 381, Url.Action("Create", "Blogs"), 381, 30, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(412, 223, true);
            WriteLiteral(" class=\"btn btn-rose btn-fill\">Post a New Blog</a>\r\n\r\n    </div>\r\n    <div class=\"pull-right\">\r\n\r\n    </div>\r\n    <div class=\"clearfix\"></div>\r\n</div>\r\n<hr />\r\n<div class=\"row\">\r\n\r\n    <div class=\"col-md-9\">\r\n\r\n\r\n\r\n        ");
            EndContext();
            BeginContext(636, 13, false);
#line 30 "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\Blogs\Index.cshtml"
   Write(ViewBag.Empty);

#line default
#line hidden
            EndContext();
            BeginContext(649, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 32 "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\Blogs\Index.cshtml"
         foreach (var post in Model)
        {

#line default
#line hidden
            BeginContext(702, 203, true);
            WriteLiteral("            <div class=\"card\">\r\n                <div class=\"array\">\r\n                    <div class=\"col-lg-12\" style=\"background-color:white; \">\r\n\r\n\r\n                        <b style=\"font-size:20px\"><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 905, "\"", 969, 1);
#line 39 "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\Blogs\Index.cshtml"
WriteAttributeValue("", 912, Url.Action("Details", "Blogs", new { id = post.BlogId }), 912, 57, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(970, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(972, 10, false);
#line 39 "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\Blogs\Index.cshtml"
                                                                                                                 Write(post.Title);

#line default
#line hidden
            EndContext();
            BeginContext(982, 43, true);
            WriteLiteral("</a></b><br />\r\n                        <p>");
            EndContext();
            BeginContext(1026, 21, false);
#line 40 "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\Blogs\Index.cshtml"
                      Write(post.ShortDescription);

#line default
#line hidden
            EndContext();
            BeginContext(1047, 24, true);
            WriteLiteral("<br /><br />Posted by:  ");
            EndContext();
            BeginContext(1072, 16, false);
#line 40 "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\Blogs\Index.cshtml"
                                                                    Write(post.UserCreated);

#line default
#line hidden
            EndContext();
            BeginContext(1088, 4, true);
            WriteLiteral(" on ");
            EndContext();
            BeginContext(1093, 16, false);
#line 40 "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\Blogs\Index.cshtml"
                                                                                         Write(post.DateCreated);

#line default
#line hidden
            EndContext();
            BeginContext(1109, 82, true);
            WriteLiteral("</p>\r\n\r\n                    </div>\r\n                </div>\r\n\r\n            </div>\r\n");
            EndContext();
#line 46 "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\Blogs\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1202, 48, true);
            WriteLiteral("        <hr />\r\n\r\n    </div>\r\n\r\n\r\n\r\n\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<OnyeijeSchool.Models.Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591
