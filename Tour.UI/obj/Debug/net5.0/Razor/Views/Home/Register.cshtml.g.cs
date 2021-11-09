#pragma checksum "C:\Users\DELL\Documents\GitHub\Tour\Tour.UI\Views\Home\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "854bddd009126a14528d61f3f08e43136a623d23"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Register), @"mvc.1.0.view", @"/Views/Home/Register.cshtml")]
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
#line 1 "C:\Users\DELL\Documents\GitHub\Tour\Tour.UI\Views\_ViewImports.cshtml"
using UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DELL\Documents\GitHub\Tour\Tour.UI\Views\_ViewImports.cshtml"
using UI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"854bddd009126a14528d61f3f08e43136a623d23", @"/Views/Home/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52d79ad08d11418ded2b13adb4a9b2619d15bb23", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tour.UI.Models.CustomerViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\DELL\Documents\GitHub\Tour\Tour.UI\Views\Home\Register.cshtml"
  
    ViewData["Title"] = "Register";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<header id=""gtco-header"" class=""gtco-cover gtco-cover-md"" role=""banner"" style=""background-image: url('../assert/images/img_bg_1.jpg');"">
    <div class=""overlay""></div>
    <div class=""gtco-container"">
        <div class=""row"">
            <div class=""col-md-12 col-md-offset-0 text-left"">
                <div class=""row mt-sm"">
                    <div class=""col-md-7 mt-text animate-box"" data-animate-effect=""fadeInUp"">
                        <h1>Đăng ký khách hàng</h1>
                    </div>
                    <div class=""col-md-4 col-md-push-1 animate-box"" data-animate-effect=""fadeInRight"">
                        <div class=""form-wrap"">
                            <div class=""tab"">
                                <div class=""tab-content"">
                                    <div class=""tab-content-inner active"" data-content=""signup"">
                                        <h3>Đăng ký</h3>
");
#nullable restore
#line 21 "C:\Users\DELL\Documents\GitHub\Tour\Tour.UI\Views\Home\Register.cshtml"
                                         using (Html.BeginForm("_Register", "Home", FormMethod.Post))
                                        {
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\DELL\Documents\GitHub\Tour\Tour.UI\Views\Home\Register.cshtml"
                                       Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\DELL\Documents\GitHub\Tour\Tour.UI\Views\Home\Register.cshtml"
                                       Write(Html.HiddenFor(m => m.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            <div class=""row form-group"">
                                                <div class=""col-md-12"">
                                                    <label for=""userName"">Tên đăng nhập</label>
                                                    ");
#nullable restore
#line 28 "C:\Users\DELL\Documents\GitHub\Tour\Tour.UI\Views\Home\Register.cshtml"
                                               Write(Html.TextBoxFor(m => m.username, new { @class = "form-control", @type = "email" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    ");
#nullable restore
#line 29 "C:\Users\DELL\Documents\GitHub\Tour\Tour.UI\Views\Home\Register.cshtml"
                                               Write(Html.ValidationMessageFor(m => m.username, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                </div>
                                            </div>
                                            <div class=""row form-group"">
                                                <div class=""col-md-12"">
                                                    <label for=""password"">Mật khẩu</label>
                                                    ");
#nullable restore
#line 35 "C:\Users\DELL\Documents\GitHub\Tour\Tour.UI\Views\Home\Register.cshtml"
                                               Write(Html.PasswordFor(m => m.password, new { @class = "form-control", @type = "password" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    ");
#nullable restore
#line 36 "C:\Users\DELL\Documents\GitHub\Tour\Tour.UI\Views\Home\Register.cshtml"
                                               Write(Html.ValidationMessageFor(m => m.password, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                </div>
                                            </div>
                                            <div class=""row form-group"">
                                                <div class=""col-md-12"">
                                                    <label for=""fullName"">Họ và Tên</label>
                                                    ");
#nullable restore
#line 42 "C:\Users\DELL\Documents\GitHub\Tour\Tour.UI\Views\Home\Register.cshtml"
                                               Write(Html.TextBoxFor(m => m.fullName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    ");
#nullable restore
#line 43 "C:\Users\DELL\Documents\GitHub\Tour\Tour.UI\Views\Home\Register.cshtml"
                                               Write(Html.ValidationMessageFor(m => m.fullName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                </div>
                                            </div>
                                            <div class=""row form-group"">
                                                <div class=""col-md-6"">
                                                    <label for=""birthday"">Ngày sinh</label>
                                                    ");
#nullable restore
#line 49 "C:\Users\DELL\Documents\GitHub\Tour\Tour.UI\Views\Home\Register.cshtml"
                                               Write(Html.TextBoxFor(m => m.birthday, "{0:dd/MM/yyyy}", new { @class = "form-control show-datepicker", @placeholder = "Ngày sinh" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                    <div class=""input-group-append"">
                                                        <span class=""input-group-text"" style=""background-color: #fff;border-radius: 0 .25rem .25rem 0;""><i class=""fa fa-calendar""></i></span>
                                                    </div>
                                                </div>
                                                <div class=""col-md-6"">
                                                    <label for=""phone"">Số điện thoại</label>
                                                    ");
#nullable restore
#line 56 "C:\Users\DELL\Documents\GitHub\Tour\Tour.UI\Views\Home\Register.cshtml"
                                               Write(Html.TextBoxFor(m => m.phone, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                </div>
                                            </div>
                                            <div class=""row form-group"">
                                                <div class=""col-md-12"">
                                                    <label for=""address"">Địa chỉ</label>
                                                    ");
#nullable restore
#line 62 "C:\Users\DELL\Documents\GitHub\Tour\Tour.UI\Views\Home\Register.cshtml"
                                               Write(Html.TextAreaFor(m => m.address, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                </div>
                                            </div>
                                            <div class=""row form-group"">
                                                <div class=""col-md-12"">
                                                    <input type=""submit"" class=""btn btn-primary btn-block"" value=""Đăng kí"">
                                                </div>
                                            </div>
");
#nullable restore
#line 70 "C:\Users\DELL\Documents\GitHub\Tour\Tour.UI\Views\Home\Register.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    
                </div>
            </div>
        </div>
    </div>
</header>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tour.UI.Models.CustomerViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
