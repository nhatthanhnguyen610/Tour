#pragma checksum "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\SysMenu\_Update.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "82d5dee3011b70ffd2a41553b8515c1813759f4a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SysMenu__Update), @"mvc.1.0.view", @"/Views/SysMenu/_Update.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82d5dee3011b70ffd2a41553b8515c1813759f4a", @"/Views/SysMenu/_Update.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3da9fae43ccf361385e7b7b609456b65034ebb9", @"/Views/_ViewImports.cshtml")]
    public class Views_SysMenu__Update : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tour.Admin.Models.SysMenuUserViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\SysMenu\_Update.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("<style>\r\n    .error-valid {\r\n        color: red;\r\n    }\r\n</style>\r\n<div id=\"RoleModalAction\" class=\"modal fade\">\r\n    <div class=\"modal-dialog\">\r\n        <div class=\"modal-content\">\r\n");
#nullable restore
#line 13 "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\SysMenu\_Update.cshtml"
             using (Html.BeginForm("_Update", "SysMenu", FormMethod.Post, new { id = "frmUpdate" }))
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\SysMenu\_Update.cshtml"
           Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\SysMenu\_Update.cshtml"
           Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\SysMenu\_Update.cshtml"
           Write(Html.HiddenFor(m => m.id));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""card-body"">
                    <div class=""row section"">
                        <div class=""row"">
                            <div class=""col-sm-6"">
                                <div class=""form-group"">
                                    <label>Mã<span style=""color:red"">*</span></label>
                                    ");
#nullable restore
#line 24 "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\SysMenu\_Update.cshtml"
                               Write(Html.TextBoxFor(m => m.menuCode, new { @class = "form-control", @placeholder = "Mã" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    ");
#nullable restore
#line 25 "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\SysMenu\_Update.cshtml"
                               Write(Html.ValidationMessageFor(m => m.menuCode));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </div>
                            </div>
                            <div class=""col-sm-6"">
                                <div class=""form-group"">
                                    <label>Menu Cha</label>
                                    ");
#nullable restore
#line 31 "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\SysMenu\_Update.cshtml"
                               Write(Html.TextBoxFor(m => m.parentMenuCde, new { @class = "form-control", @placeholder = "Meunu Cha" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </div>
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-sm-6"">
                                <div class=""form-group"">
                                    <label>Menu icon</label>
                                    ");
#nullable restore
#line 39 "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\SysMenu\_Update.cshtml"
                               Write(Html.TextBoxFor(m => m.menuIcon, new { @class = "form-control", @placeholder = "Menu Icon" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </div>
                            </div>
                            <div class=""col-sm-6"">
                                <div class=""form-group"">
                                    <label>Tên Menu<span style=""color:red"">*</span></label>
                                    ");
#nullable restore
#line 45 "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\SysMenu\_Update.cshtml"
                               Write(Html.TextBoxFor(m => m.menuTitleCde, new { @class = "form-control", @placeholder = "Tên Menu" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    ");
#nullable restore
#line 46 "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\SysMenu\_Update.cshtml"
                               Write(Html.ValidationMessageFor(m => m.menuTitleCde));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </div>
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-sm-6"">
                                <div class=""form-group"">
                                    <label>Controller</label>
                                    ");
#nullable restore
#line 54 "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\SysMenu\_Update.cshtml"
                               Write(Html.TextBoxFor(m => m.controller, new { @class = "form-control", @placeholder = "Controller" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </div>
                            </div>
                            <div class=""col-sm-6"">
                                <div class=""form-group"">
                                    <label>Action</label>
                                    ");
#nullable restore
#line 60 "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\SysMenu\_Update.cshtml"
                               Write(Html.TextBoxFor(m => m.actionOrClass, new { @class = "form-control", @placeholder = "Action" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""modal-footer"">
                        <button type=""button"" id=""btnUpdate"" class=""btn btn-success btn-sm float-sm-right disableBtnSave""><span class=""fa fa-save""></span>Lưu</button>
                        <button type=""button"" class=""btn btn-danger btn btn-sm float-sm-right btn-popup-cancel"" id=""btnClose"" style=""margin-right:5px"" data-dismiss=""modal""><span class=""fa fa-times""></span>Thoát</button>
                    </div>
                </div>
");
#nullable restore
#line 70 "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\SysMenu\_Update.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
    </div>
</div>
<script language=""javascript"">
    $('#frmUpdate').validate({
        rules: {
            ""menuCode"": {
                required: true
            },
            ""menuTitleCde"": {
                required: true
            },
        },
        messages: {
            ""menuCode"": ""Vui lòng không để trống"",
            ""menuTitleCde"": ""Vui lòng không để trống"",
        },
        errorPlacement: function (error, element) {
            error.addClass('error-valid');
            error.insertAfter(element);
            if (element.attr(""name"") == """") {
                error.insertAfter(""#"");
            }
        }
    })
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tour.Admin.Models.SysMenuUserViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
