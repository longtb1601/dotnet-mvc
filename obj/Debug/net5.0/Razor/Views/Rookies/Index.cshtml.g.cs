#pragma checksum "E:\C#\MVC\Views\Rookies\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "246a5f34ac85038e5f9c03f52d8eb0a5496c13c5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Rookies_Index), @"mvc.1.0.view", @"/Views/Rookies/Index.cshtml")]
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
#line 1 "E:\C#\MVC\Views\_ViewImports.cshtml"
using MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\C#\MVC\Views\_ViewImports.cshtml"
using MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"246a5f34ac85038e5f9c03f52d8eb0a5496c13c5", @"/Views/Rookies/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d7a8f56340c239c091cff637a00cc2fdf252300", @"/Views/_ViewImports.cshtml")]
    public class Views_Rookies_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\C#\MVC\Views\Rookies\Index.cshtml"
  
    ViewData["Title"] = "Rookies";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"my-5\">\r\n    <h3 class=\"d-inline-block\">Rookies</h3>\r\n    <a");
            BeginWriteAttribute("href", " href=\'", 116, "\'", 155, 1);
#nullable restore
#line 7 "E:\C#\MVC\Views\Rookies\Index.cshtml"
WriteAttributeValue("", 123, Url.Action("Create", "Rookies"), 123, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-primary float-right""><i class=""fa fa-plus"" aria-hidden=""true""></i> Create new persons</a>
</div>

<table class=""table"">
    <thead>
        <tr>
            <th scope=""col"" class=""text-center"">#</th>
            <th scope=""col"" class=""text-center"">ID</th>
            <th scope=""col"">FullName</th>
            <th scope=""col"">Gender</th>
            <th scope=""col"">Date of Birth</th>
            <th scope=""col"">Age</th>
            <th scope=""col"" class=""text-center"">Actions</th>
        </tr>
    </thead>

    <tbody>
");
#nullable restore
#line 24 "E:\C#\MVC\Views\Rookies\Index.cshtml"
          
            var index = 0;
            foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <th scope=\"row\" class=\"text-center\">");
#nullable restore
#line 29 "E:\C#\MVC\Views\Rookies\Index.cshtml"
                                                    Write(++index);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th class=\"text-center\">");
#nullable restore
#line 30 "E:\C#\MVC\Views\Rookies\Index.cshtml"
                                       Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <td>");
#nullable restore
#line 31 "E:\C#\MVC\Views\Rookies\Index.cshtml"
                   Write(item.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 32 "E:\C#\MVC\Views\Rookies\Index.cshtml"
                   Write(item.Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 33 "E:\C#\MVC\Views\Rookies\Index.cshtml"
                    Write(item.DateOfBirth.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 34 "E:\C#\MVC\Views\Rookies\Index.cshtml"
                   Write(item.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"text-center\" style=\"width:200px\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\'", 1255, "\'", 1312, 1);
#nullable restore
#line 36 "E:\C#\MVC\Views\Rookies\Index.cshtml"
WriteAttributeValue("", 1262, Url.Action("Edit", "Rookies", new {id = item.Id}), 1262, 50, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-secondary btn-sm\" role=\"button\" aria-pressed=\"true\"><i class=\"fa fa-pencil\" aria-hidden=\"true\"></i> Edit</a>\r\n                        <a");
            BeginWriteAttribute("href", " href=\'", 1465, "\'", 1524, 1);
#nullable restore
#line 37 "E:\C#\MVC\Views\Rookies\Index.cshtml"
WriteAttributeValue("", 1472, Url.Action("Delete", "Rookies", new {id = item.Id}), 1472, 52, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-danger btn-sm"" role=""button"" aria-pressed=""true"" 
                            onclick=""return confirm('Are you sure you want to delete this person?');""><i class=""fa fa-trash"" aria-hidden=""true""></i> Delete</a>
                    </td>
                </tr>
");
#nullable restore
#line 41 "E:\C#\MVC\Views\Rookies\Index.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
