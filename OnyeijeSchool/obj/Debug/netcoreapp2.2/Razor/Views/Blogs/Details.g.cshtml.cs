#pragma checksum "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\Blogs\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f217d9558498c6fc2ac0715b9349bfe612bd290"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blogs_Details), @"mvc.1.0.view", @"/Views/Blogs/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Blogs/Details.cshtml", typeof(AspNetCore.Views_Blogs_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f217d9558498c6fc2ac0715b9349bfe612bd290", @"/Views/Blogs/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34f1e347ba21b0f56e0e9b066f616c277af2767a", @"/Views/_ViewImports.cshtml")]
    public class Views_Blogs_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OnyeijeSchool.Models.Blog>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(34, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\Blogs\Details.cshtml"
  
    ViewBag.Title = Model.Title;


#line default
#line hidden
            BeginContext(79, 114, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"card\" style=\"padding:50px;\">\r\n\r\n\r\n\r\n\r\n        <h4 style=\"font-weight: bold;\">");
            EndContext();
            BeginContext(194, 11, false);
#line 14 "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\Blogs\Details.cshtml"
                                  Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(205, 28, true);
            WriteLiteral("</h4>\r\n        <p>Posted by ");
            EndContext();
            BeginContext(234, 17, false);
#line 15 "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\Blogs\Details.cshtml"
                Write(Model.UserCreated);

#line default
#line hidden
            EndContext();
            BeginContext(251, 5, true);
            WriteLiteral(". on ");
            EndContext();
            BeginContext(257, 17, false);
#line 15 "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\Blogs\Details.cshtml"
                                       Write(Model.DateCreated);

#line default
#line hidden
            EndContext();
            BeginContext(274, 17, true);
            WriteLiteral("</p>\r\n        <p>");
            EndContext();
            BeginContext(292, 49, false);
#line 16 "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\Blogs\Details.cshtml"
      Write(Html.Raw(Model.Content.Replace("\r\n", "<br />")));

#line default
#line hidden
            EndContext();
            BeginContext(341, 41, true);
            WriteLiteral("</p>\r\n\r\n\r\n\r\n        <p>\r\n\r\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 382, "\"", 418, 1);
#line 22 "C:\Users\ROYALDOT\source\repos\OnyeijeSchool\OnyeijeSchool\Views\Blogs\Details.cshtml"
WriteAttributeValue("", 389, Url.Action("Index", "Blogs"), 389, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(419, 79, true);
            WriteLiteral(" class=\"btn btn-rose btn-fill\">View Blogs</a>\r\n        </p>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OnyeijeSchool.Models.Blog> Html { get; private set; }
    }
}
#pragma warning restore 1591
