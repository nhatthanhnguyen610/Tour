#pragma checksum "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\Flight\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "59eccb0e8cea540d7ef9b2e182bb20d3cc947861"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Flight_Index), @"mvc.1.0.view", @"/Views/Flight/Index.cshtml")]
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
#nullable restore
#line 2 "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\Flight\Index.cshtml"
using Tour.Admin;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59eccb0e8cea540d7ef9b2e182bb20d3cc947861", @"/Views/Flight/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3da9fae43ccf361385e7b7b609456b65034ebb9", @"/Views/_ViewImports.cshtml")]
    public class Views_Flight_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tour.Admin.Models.FlightVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/flight.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<!-- Content Header (Page header) -->\r\n<section class=\"content-header\">\r\n    <div class=\"container-fluid\">\r\n        <div class=\"row mb-2\">\r\n            <div class=\"col-sm-6\">\r\n                ");
#nullable restore
#line 9 "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\Flight\Index.cshtml"
           Write(await Html.PartialAsync("_Partial_HeaderInfo"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>
            <div class=""col-sm-6"">
                <button type=""button""
                        class=""btn btn-success btn-sm float-sm-right btn-popup-size""
                        data-toggle=""modalMenu""
                        data-target=""#MenuModal""
                        data-width=""1000""
                        data-height=""600""
                        data-url=""");
#nullable restore
#line 18 "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\Flight\Index.cshtml"
                             Write(Url.Action("_Create", "Flight"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""">
                    <span class='fa fa-plus fa-fw'></span>Thêm mới
                </button>
            </div>
        </div>
    </div><!-- /.container-fluid -->
</section>
<!-- Main content -->
<section class=""content"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-12"">
                <div class=""card"">
                    <div class=""card-footer clearfix"">
");
#nullable restore
#line 32 "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\Flight\Index.cshtml"
                         using (Html.BeginForm("_Index", "Flight", FormMethod.Get, new { @class = "form-sm form-load-ajax", id = "frmFlight", data_load_view = "divListDetail" }))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""row m-0"">
                                <div class=""col-md-8"">
                                    <div class=""form-group"">
                                        <label>Từ khóa</label>
                                        ");
#nullable restore
#line 38 "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\Flight\Index.cshtml"
                                   Write(Html.TextBoxFor(m => m.keyWord, new { @class = "form-control", @placeholder = "Nhập từ khóa" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        ");
#nullable restore
#line 39 "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\Flight\Index.cshtml"
                                   Write(Html.TextBoxFor(m => m.p, new { @class = "form-control", @placeholder = "Nhập từ khóa", @hidden = "hidden" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </div>
                                </div>
                                <div class=""col-md-4"">
                                    <div class=""form-group"">
                                        <br />
                                        <button type=""submit"" class=""btn btn-primary"" id=""btnSearch"" style=""margin-top:5px"">
                                            <span class='fa fa-search'></span>
                                            Tìm kiếm
                                        </button>
                                    </div>
                                </div>
                            </div>
");
#nullable restore
#line 52 "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\Flight\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                    <div id=\"divListDetail\" class=\"panel-body pn\">\r\n                        ");
#nullable restore
#line 55 "C:\Users\DELL\Documents\GitHub\Tour\Tour.Admin\Views\Flight\Index.cshtml"
                   Write(await Html.PartialAsync("_Index", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <!-- /.card -->\r\n            </div>\r\n            <!-- /.col -->\r\n        </div>\r\n        <!-- /.row -->\r\n    </div>\r\n    <!-- /.container-fluid -->\r\n</section>\r\n<!-- /.content -->\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "59eccb0e8cea540d7ef9b2e182bb20d3cc9478618234", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <script>
        var RoleCreateURL = $('#menuModalPlace');
        $(function () {
            $('button[data-toggle=""modalMenu""]').click(function (event) {
                var url = $(this).data('url');
                $.get(url).done(function (data) {
                    RoleCreateURL.html(data);
                    RoleCreateURL.find('.modal').modal('show');
                })
            })
        })
    </script>
");
            }
            );
            WriteLiteral("\r\n<div id=\"menuModalPlace\">\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tour.Admin.Models.FlightVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
