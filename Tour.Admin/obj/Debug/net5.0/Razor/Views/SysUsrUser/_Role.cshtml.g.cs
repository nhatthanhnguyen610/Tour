#pragma checksum "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\SysUsrUser\_Role.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2efe7b6b304f0784bbdc1c113d9133b33914e05"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SysUsrUser__Role), @"mvc.1.0.view", @"/Views/SysUsrUser/_Role.cshtml")]
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
#line 1 "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\_ViewImports.cshtml"
using DemoApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\_ViewImports.cshtml"
using DemoApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2efe7b6b304f0784bbdc1c113d9133b33914e05", @"/Views/SysUsrUser/_Role.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3da9fae43ccf361385e7b7b609456b65034ebb9", @"/Views/_ViewImports.cshtml")]
    public class Views_SysUsrUser__Role : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tour.Admin.Models.SysUsrRoleViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\SysUsrUser\_Role.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div id=\"RoleModal\" class=\"modal fade\" role=\"dialog\" tabindex=\"-1\" data-keyboard=\"false\" data-backdrop=\"static\">\r\n    <div class=\"modal-dialog\">\r\n        <div class=\"modal-content\">\r\n");
#nullable restore
#line 8 "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\SysUsrUser\_Role.cshtml"
         using (Html.BeginForm("_Role", "SysUsrUser", FormMethod.Post, new { id = "frmRole" }))
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\SysUsrUser\_Role.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\SysUsrUser\_Role.cshtml"
       Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\SysUsrUser\_Role.cshtml"
       Write(Html.HiddenFor(m => m.userCde));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""card-body"">
                <div class=""section"">
                    <table class=""table table-bordered table-striped table-hover"">
                        <thead>
                            <tr>
                                <th>
                                    Phân quyền user
                                </th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 24 "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\SysUsrUser\_Role.cshtml"
                             for (var i = 0; i < Model.ListSysUsrRole.Count; i++)
                            {
                                var item = Model.ListSysUsrRole[i];

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n");
            WriteLiteral("                                        <div class=\"row\">\r\n                                            ");
#nullable restore
#line 37 "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\SysUsrUser\_Role.cshtml"
                                       Write(Html.Hidden(string.Format("ListSysUsrRole[{0}].menuCde", i), item.menuCde));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            <div class=\"icheck-primary\">\r\n                                                <input type=\"checkbox\"");
            BeginWriteAttribute("name", " name=\"", 2177, "\"", 2213, 3);
            WriteAttributeValue("", 2184, "ListSysUsrRole[", 2184, 15, true);
#nullable restore
#line 39 "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\SysUsrUser\_Role.cshtml"
WriteAttributeValue("", 2199, i, 2199, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2201, "].isSelected", 2201, 12, true);
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 2214, "\"", 2248, 3);
            WriteAttributeValue("", 2219, "ListSysUsrRole[", 2219, 15, true);
#nullable restore
#line 39 "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\SysUsrUser\_Role.cshtml"
WriteAttributeValue("", 2234, i, 2234, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2236, "].isSelected", 2236, 12, true);
            EndWriteAttribute();
            WriteLiteral(" value=\"true\" ");
#nullable restore
#line 39 "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\SysUsrUser\_Role.cshtml"
                                                                                                                                                        Write(item.isSelected ? "checked" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n                                                <label");
            BeginWriteAttribute("for", " for=\"", 2355, "\"", 2390, 3);
            WriteAttributeValue("", 2361, "ListSysUsrRole[", 2361, 15, true);
#nullable restore
#line 40 "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\SysUsrUser\_Role.cshtml"
WriteAttributeValue("", 2376, i, 2376, 2, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2378, "].isSelected", 2378, 12, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                    ");
#nullable restore
#line 41 "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\SysUsrUser\_Role.cshtml"
                                               Write(item.menuTitleCde);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </label>\r\n                                            </div>\r\n                                        </div>\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 47 "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\SysUsrUser\_Role.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </tbody>
                    </table>
                </div>

                <div class=""modal-footer"">
                    <button type=""button"" id=""btnConfigRole"" class=""btn btn-success btn-sm float-sm-right disableBtnSave""><span class=""fa fa-save""></span>Lưu</button>
                    <button type=""button"" class=""btn btn-danger btn btn-sm float-sm-right btn-popup-cancel"" id=""btnClose"" style=""margin-right:5px"" data-dismiss=""modal""><span class=""fa fa-times""></span>Thoát</button>
                </div>
            </div>
");
#nullable restore
#line 57 "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\SysUsrUser\_Role.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tour.Admin.Models.SysUsrRoleViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591