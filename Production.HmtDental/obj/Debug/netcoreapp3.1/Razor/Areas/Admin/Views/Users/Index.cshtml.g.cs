#pragma checksum "E:\Project3M\HmtDental\Production.HmtDental\Areas\Admin\Views\Users\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9dd731947271c505cc34291b694f71ab30733916"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Users_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Users/Index.cshtml")]
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
#line 1 "E:\Project3M\HmtDental\Production.HmtDental\Areas\Admin\Views\_ViewImports.cshtml"
using Production.HmtDental;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Project3M\HmtDental\Production.HmtDental\Areas\Admin\Views\_ViewImports.cshtml"
using Production.HmtDental.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9dd731947271c505cc34291b694f71ab30733916", @"/Areas/Admin/Views/Users/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"845db80fe420c8cfbf4f7befec191a97d8644dc2", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Users_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Production.HmtDental.Models.User>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\Project3M\HmtDental\Production.HmtDental\Areas\Admin\Views\Users\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"right_col\" role=\"main\">\r\n    <h1>Index</h1>\r\n\r\n    <p>\r\n        <a href=\"/Admin/Users/Create\">Create New</a>\r\n    </p>\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 17 "E:\Project3M\HmtDental\Production.HmtDental\Areas\Admin\Views\Users\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 20 "E:\Project3M\HmtDental\Production.HmtDental\Areas\Admin\Views\Users\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 23 "E:\Project3M\HmtDental\Production.HmtDental\Areas\Admin\Views\Users\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 29 "E:\Project3M\HmtDental\Production.HmtDental\Areas\Admin\Views\Users\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 33 "E:\Project3M\HmtDental\Production.HmtDental\Areas\Admin\Views\Users\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 36 "E:\Project3M\HmtDental\Production.HmtDental\Areas\Admin\Views\Users\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 39 "E:\Project3M\HmtDental\Production.HmtDental\Areas\Admin\Views\Users\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1266, "\"", 1299, 2);
            WriteAttributeValue("", 1273, "/Admin/Users/Edit/", 1273, 18, true);
#nullable restore
#line 42 "E:\Project3M\HmtDental\Production.HmtDental\Areas\Admin\Views\Users\Index.cshtml"
WriteAttributeValue("", 1291, item.Id, 1291, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a>\r\n                        <a");
            BeginWriteAttribute("href", "  href=\"", 1337, "\"", 1374, 2);
            WriteAttributeValue("", 1345, "/Admin/Users/Details/", 1345, 21, true);
#nullable restore
#line 43 "E:\Project3M\HmtDental\Production.HmtDental\Areas\Admin\Views\Users\Index.cshtml"
WriteAttributeValue("", 1366, item.Id, 1366, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a>\r\n                        <a");
            BeginWriteAttribute("href", "  href=\"", 1415, "\"", 1451, 2);
            WriteAttributeValue("", 1423, "/Admin/Users/Delete/", 1423, 20, true);
#nullable restore
#line 44 "E:\Project3M\HmtDental\Production.HmtDental\Areas\Admin\Views\Users\Index.cshtml"
WriteAttributeValue("", 1443, item.Id, 1443, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 47 "E:\Project3M\HmtDental\Production.HmtDental\Areas\Admin\Views\Users\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Production.HmtDental.Models.User>> Html { get; private set; }
    }
}
#pragma warning restore 1591