#pragma checksum "F:\D\Uni\Third Year\WideBot Task\Trial\Task\Views\Home\getWithID.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "60b633946d012a691c1b21f519424c970b5ae4ba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_getWithID), @"mvc.1.0.view", @"/Views/Home/getWithID.cshtml")]
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
#line 1 "F:\D\Uni\Third Year\WideBot Task\Trial\Task\Views\_ViewImports.cshtml"
using Task;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\D\Uni\Third Year\WideBot Task\Trial\Task\Views\_ViewImports.cshtml"
using Task.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60b633946d012a691c1b21f519424c970b5ae4ba", @"/Views/Home/getWithID.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d8c759e459b02ea13d55074790ea8375b084362", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_getWithID : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "F:\D\Uni\Third Year\WideBot Task\Trial\Task\Views\Home\getWithID.cshtml"
   Layout = "_Layout"; ViewBag.Title = "Specific Users";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<table class=""table table-sm table-striped table-bordered m-2"">
    <thead>
        <tr>
            <th>First Name</th>
            <th>Last Name</th>
            <th>Email</th>
            <th>Avatar</th>

        </tr>
    </thead>
    <tbody>


        <tr>
            <td>");
#nullable restore
#line 22 "F:\D\Uni\Third Year\WideBot Task\Trial\Task\Views\Home\getWithID.cshtml"
           Write(Model.first_name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 23 "F:\D\Uni\Third Year\WideBot Task\Trial\Task\Views\Home\getWithID.cshtml"
           Write(Model.last_name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "F:\D\Uni\Third Year\WideBot Task\Trial\Task\Views\Home\getWithID.cshtml"
           Write(Model.email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "F:\D\Uni\Third Year\WideBot Task\Trial\Task\Views\Home\getWithID.cshtml"
           Write(Model.avatar);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n\r\n    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User> Html { get; private set; }
    }
}
#pragma warning restore 1591
