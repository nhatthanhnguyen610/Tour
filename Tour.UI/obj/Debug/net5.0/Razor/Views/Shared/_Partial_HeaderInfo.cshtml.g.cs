#pragma checksum "C:\Users\DELL\Documents\GitHub\Tour\Tour.UI\Views\Shared\_Partial_HeaderInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53d9a83470e0dd9846d955f0da7baf89aa5c3579"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Partial_HeaderInfo), @"mvc.1.0.view", @"/Views/Shared/_Partial_HeaderInfo.cshtml")]
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
#nullable restore
#line 1 "C:\Users\DELL\Documents\GitHub\Tour\Tour.UI\Views\Shared\_Partial_HeaderInfo.cshtml"
using Tour.Common.Constants;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53d9a83470e0dd9846d955f0da7baf89aa5c3579", @"/Views/Shared/_Partial_HeaderInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52d79ad08d11418ded2b13adb4a9b2619d15bb23", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Partial_HeaderInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!-- <div class=""page-inner""> -->
<nav class=""gtco-nav"" role=""navigation"">
    <div class=""gtco-container"">

        <div class=""row"">
            <div class=""col-sm-4 col-xs-12"">
                <div id=""gtco-logo""><a href=""/"">Traveler <em>.</em></a></div>
            </div>
            <div class=""col-xs-8 text-right menu-1"">
                <ul>
                    <li><a href=""/Home/Tour"">Tour</a></li>
                    <!-- <li class=""has-dropdown"">
                        <a href=""#"">Travel</a>
                        <ul class=""dropdown"">
                            <li><a href=""#"">Europe</a></li>
                            <li><a href=""#"">Asia</a></li>
                            <li><a href=""#"">America</a></li>
                            <li><a href=""#"">Canada</a></li>
                        </ul>
                    </li> -->
                    <li><a href=""/Home/Doitac"">Đăng kí đối tác</a></li>
                    <li><a href=""/Home/Contact"">Liên hệ</a></li>
");
#nullable restore
#line 24 "C:\Users\DELL\Documents\GitHub\Tour\Tour.UI\Views\Shared\_Partial_HeaderInfo.cshtml"
                     if (@Constants.FullName != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"has-dropdown\">     \r\n                                <a href=\"#\">Xin chào ");
#nullable restore
#line 27 "C:\Users\DELL\Documents\GitHub\Tour\Tour.UI\Views\Shared\_Partial_HeaderInfo.cshtml"
                                                Write(Constants.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                            <ul class=\"dropdown\">\r\n                                <li><a href=\"/Home/Logout\">Đăng xuất</a></li>\r\n                            </ul>\r\n                        </li>\r\n");
#nullable restore
#line 32 "C:\Users\DELL\Documents\GitHub\Tour\Tour.UI\Views\Shared\_Partial_HeaderInfo.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ul>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</nav>");
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
