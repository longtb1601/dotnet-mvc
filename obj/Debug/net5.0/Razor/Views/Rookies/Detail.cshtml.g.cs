#pragma checksum "D:\C#\MVC\Views\Rookies\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9032d33ad0e1d036fb6ba6b9ecbf98e5455970e9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Rookies_Detail), @"mvc.1.0.view", @"/Views/Rookies/Detail.cshtml")]
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
#line 1 "D:\C#\MVC\Views\_ViewImports.cshtml"
using MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\C#\MVC\Views\_ViewImports.cshtml"
using MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9032d33ad0e1d036fb6ba6b9ecbf98e5455970e9", @"/Views/Rookies/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d7a8f56340c239c091cff637a00cc2fdf252300", @"/Views/_ViewImports.cshtml")]
    public class Views_Rookies_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Person>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\C#\MVC\Views\Rookies\Detail.cshtml"
  
    ViewData["Title"] = "Edit information of person";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"my-5\">\r\n        <h3 class=\"d-inline-block\">Edit information of person</h3>\r\n</div>\r\n<hr/>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-6 offset-3\">\r\n");
#nullable restore
#line 13 "D:\C#\MVC\Views\Rookies\Detail.cshtml"
         using(Html.BeginForm())
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\C#\MVC\Views\Rookies\Detail.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 18 "D:\C#\MVC\Views\Rookies\Detail.cshtml"
           Write(Html.LabelFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <label class = \"form-control\"> ");
#nullable restore
#line 19 "D:\C#\MVC\Views\Rookies\Detail.cshtml"
                                          Write(Html.ValueFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 22 "D:\C#\MVC\Views\Rookies\Detail.cshtml"
           Write(Html.LabelFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <label class = \"form-control\"> ");
#nullable restore
#line 23 "D:\C#\MVC\Views\Rookies\Detail.cshtml"
                                          Write(Html.ValueFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n            </div>\r\n             <div class=\"form-group\">\r\n                ");
#nullable restore
#line 26 "D:\C#\MVC\Views\Rookies\Detail.cshtml"
           Write(Html.LabelFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <label class = \"form-control\"> ");
#nullable restore
#line 27 "D:\C#\MVC\Views\Rookies\Detail.cshtml"
                                          Write(Html.ValueFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n            </div>\r\n             <div class=\"form-group\">\r\n                ");
#nullable restore
#line 30 "D:\C#\MVC\Views\Rookies\Detail.cshtml"
           Write(Html.LabelFor(model => model.DateOfBirth));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <label class = \"form-control\"> ");
#nullable restore
#line 31 "D:\C#\MVC\Views\Rookies\Detail.cshtml"
                                          Write(Html.ValueFor(model => model.DateOfBirth));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 34 "D:\C#\MVC\Views\Rookies\Detail.cshtml"
           Write(Html.LabelFor(model => model.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <label class = \"form-control\"> ");
#nullable restore
#line 35 "D:\C#\MVC\Views\Rookies\Detail.cshtml"
                                          Write(Html.ValueFor(model => model.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n            </div>\r\n             <div class=\"form-group\">\r\n                ");
#nullable restore
#line 38 "D:\C#\MVC\Views\Rookies\Detail.cshtml"
           Write(Html.LabelFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <label class = \"form-control\"> ");
#nullable restore
#line 39 "D:\C#\MVC\Views\Rookies\Detail.cshtml"
                                          Write(Html.ValueFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 42 "D:\C#\MVC\Views\Rookies\Detail.cshtml"
           Write(Html.LabelFor(model => model.BirthPlace));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n               <label class = \"form-control\"> ");
#nullable restore
#line 43 "D:\C#\MVC\Views\Rookies\Detail.cshtml"
                                         Write(Html.ValueFor(model => model.BirthPlace));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n            </div>\r\n            <div class=\"form-group col-12 text-center\">\r\n                <a");
            BeginWriteAttribute("href", " href=\'", 1884, "\'", 1944, 1);
#nullable restore
#line 46 "D:\C#\MVC\Views\Rookies\Detail.cshtml"
WriteAttributeValue("", 1891, Url.Action("Delete", "Rookies", new {id = Model.Id}), 1891, 53, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\" role=\"button\" aria-pressed=\"true\" \r\n                            onclick=\"return confirm(\'Are you sure you want to delete this person?\');\"><i class=\"fa fa-trash\" aria-hidden=\"true\"></i> Delete</a>\r\n            </div>\r\n");
#nullable restore
#line 49 "D:\C#\MVC\Views\Rookies\Detail.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Person> Html { get; private set; }
    }
}
#pragma warning restore 1591