#pragma checksum "/Users/josetapia/mac-repos/LaunchCode/Unit 2/Exercises/EventApp/CodingEvents/Views/EventCategory/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "33ba41eaa3258d5f2a5d6fe9e4403bb7a357bc8a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_EventCategory_Index), @"mvc.1.0.view", @"/Views/EventCategory/Index.cshtml")]
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
#nullable restore
#line 1 "/Users/josetapia/mac-repos/LaunchCode/Unit 2/Exercises/EventApp/CodingEvents/Views/_ViewImports.cshtml"
using Coding_Events;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/josetapia/mac-repos/LaunchCode/Unit 2/Exercises/EventApp/CodingEvents/Views/_ViewImports.cshtml"
using Coding_Events.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33ba41eaa3258d5f2a5d6fe9e4403bb7a357bc8a", @"/Views/EventCategory/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bad3464f3f8bb837d8f12d9ed3d1db985057f22a", @"/Views/_ViewImports.cshtml")]
    public class Views_EventCategory_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<EventCategory>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral("\n");
            WriteLiteral("\n\n<h1>Here are your events</h1>\n\n");
#nullable restore
#line 10 "/Users/josetapia/mac-repos/LaunchCode/Unit 2/Exercises/EventApp/CodingEvents/Views/EventCategory/Index.cshtml"
 if (Model.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>No Categories yet!</p>\n");
#nullable restore
#line 13 "/Users/josetapia/mac-repos/LaunchCode/Unit 2/Exercises/EventApp/CodingEvents/Views/EventCategory/Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<table class=\"table\">\n    <tr>\n        <th>ID</th>\n        <th>Category</th>\n\n    </tr>\n");
#nullable restore
#line 22 "/Users/josetapia/mac-repos/LaunchCode/Unit 2/Exercises/EventApp/CodingEvents/Views/EventCategory/Index.cshtml"
     foreach (var category in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>");
#nullable restore
#line 25 "/Users/josetapia/mac-repos/LaunchCode/Unit 2/Exercises/EventApp/CodingEvents/Views/EventCategory/Index.cshtml"
           Write(category.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 26 "/Users/josetapia/mac-repos/LaunchCode/Unit 2/Exercises/EventApp/CodingEvents/Views/EventCategory/Index.cshtml"
           Write(category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n");
#nullable restore
#line 28 "/Users/josetapia/mac-repos/LaunchCode/Unit 2/Exercises/EventApp/CodingEvents/Views/EventCategory/Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\n");
#nullable restore
#line 30 "/Users/josetapia/mac-repos/LaunchCode/Unit 2/Exercises/EventApp/CodingEvents/Views/EventCategory/Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<EventCategory>> Html { get; private set; }
    }
}
#pragma warning restore 1591
