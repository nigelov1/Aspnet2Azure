#pragma checksum "C:\BCIT\COMP3973\Lab 2 - MVC\MvcAppW2\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "90c657d90d2b3d702b71192e612297012eac7b2d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_Index), @"mvc.1.0.view", @"/Views/Category/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Category/Index.cshtml", typeof(AspNetCore.Views_Category_Index))]
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
#line 1 "C:\BCIT\COMP3973\Lab 2 - MVC\MvcAppW2\Views\_ViewImports.cshtml"
using MvcAppW2;

#line default
#line hidden
#line 2 "C:\BCIT\COMP3973\Lab 2 - MVC\MvcAppW2\Views\_ViewImports.cshtml"
using MvcAppW2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90c657d90d2b3d702b71192e612297012eac7b2d", @"/Views/Category/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6b187cfcf13f7a86b44e74eda9860db323a8475", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MvcAppW2.NW.Categories>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(44, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\BCIT\COMP3973\Lab 2 - MVC\MvcAppW2\Views\Category\Index.cshtml"
  
    ViewData["Title"] = "Category Name Only";

#line default
#line hidden
            BeginContext(100, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(107, 17, false);
#line 7 "C:\BCIT\COMP3973\Lab 2 - MVC\MvcAppW2\Views\Category\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(124, 15, true);
            WriteLiteral("</h2>\r\n\r\n<ul>\r\n");
            EndContext();
#line 10 "C:\BCIT\COMP3973\Lab 2 - MVC\MvcAppW2\Views\Category\Index.cshtml"
     foreach (var category in Model)
    {

#line default
#line hidden
            BeginContext(184, 12, true);
            WriteLiteral("        <li>");
            EndContext();
            BeginContext(197, 89, false);
#line 12 "C:\BCIT\COMP3973\Lab 2 - MVC\MvcAppW2\Views\Category\Index.cshtml"
       Write(Html.ActionLink(category.CategoryName, "Details", null, new { id = category.CategoryId }));

#line default
#line hidden
            EndContext();
            BeginContext(286, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 13 "C:\BCIT\COMP3973\Lab 2 - MVC\MvcAppW2\Views\Category\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(300, 99, true);
            WriteLiteral("</ul>\r\n\r\n<p>The Index action method is responsible for displaying only the CategoryName column.</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MvcAppW2.NW.Categories>> Html { get; private set; }
    }
}
#pragma warning restore 1591
