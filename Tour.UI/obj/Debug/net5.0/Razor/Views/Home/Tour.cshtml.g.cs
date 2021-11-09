#pragma checksum "C:\Users\DELL\Documents\GitHub\Tour\Tour.UI\Views\Home\Tour.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a28ef441858a2f71dca410933036145ff4981c9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Tour), @"mvc.1.0.view", @"/Views/Home/Tour.cshtml")]
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
#line 1 "C:\Users\DELL\Documents\GitHub\Tour\Tour.UI\Views\Home\Tour.cshtml"
using Microsoft.AspNetCore.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\DELL\Documents\GitHub\Tour\Tour.UI\Views\Home\Tour.cshtml"
using Tour.Common.Constants;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\DELL\Documents\GitHub\Tour\Tour.UI\Views\Home\Tour.cshtml"
using Tour.UI;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a28ef441858a2f71dca410933036145ff4981c9", @"/Views/Home/Tour.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52d79ad08d11418ded2b13adb4a9b2619d15bb23", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Tour : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tour.UI.Models.FlightVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("image-popup"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Users\DELL\Documents\GitHub\Tour\Tour.UI\Views\Home\Tour.cshtml"
  
    ViewData["Title"] = "Tour";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<header id=""gtco-header"" class=""gtco-cover gtco-cover-sm"" role=""banner"" style=""background-image: url('../assert/images/img_bg_1.jpg')"">
    <div class=""overlay""></div>
    <div class=""gtco-container"">
        <div class=""row"">
            <div class=""col-md-12 col-md-offset-0 text-center"">
                <div class=""row row-mt-15em"">

                    <div class=""col-md-12 mt-text animate-box"" data-animate-effect=""fadeInUp"">
                        <h1>Tham khảo tour du lịch sắp diễn ra</h1>
                    </div>

                </div>

            </div>
        </div>
    </div>
</header>

<div class=""gtco-section"">
    <div class=""gtco-container"">
        <div class=""row"">
            <div class=""col-md-8 col-md-offset-2 text-center gtco-heading"">
                <h2>Du lịch tới những nơi bạn yêu thích</h2>
                <p>Không cần nhiều lý do để bắt đầu 1 chuyến đi mới. Cuộc sống là một cuộc phiêu lưu đầy táo bạo hoặc không là gì cả.</p>
            </div>
        </");
            WriteLiteral("div>\r\n");
#nullable restore
#line 34 "C:\Users\DELL\Documents\GitHub\Tour\Tour.UI\Views\Home\Tour.cshtml"
         using (Html.BeginForm("_Index", "Home", FormMethod.Get, new { @class = "form-sm form-load-ajax", id = "frmHome", data_load_view = "divListDetail" }))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"row m-0\">\r\n                <div class=\"col-md-10\">\r\n                    <div class=\"form-group\">\r\n                        <label>Từ khóa</label>\r\n                        ");
#nullable restore
#line 40 "C:\Users\DELL\Documents\GitHub\Tour\Tour.UI\Views\Home\Tour.cshtml"
                   Write(Html.TextBoxFor(m => m.keyWord, new { @class = "form-control", @placeholder = "Nhập từ khóa" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 41 "C:\Users\DELL\Documents\GitHub\Tour\Tour.UI\Views\Home\Tour.cshtml"
                   Write(Html.TextBoxFor(m => m.p, new { @class = "form-control", @placeholder = "Nhập từ khóa", style = "display: none;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                </div>
                <div class=""col-md-2"">
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
#line 54 "C:\Users\DELL\Documents\GitHub\Tour\Tour.UI\Views\Home\Tour.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\r\n");
#nullable restore
#line 56 "C:\Users\DELL\Documents\GitHub\Tour\Tour.UI\Views\Home\Tour.cshtml"
             if (Model.ListFlight != null && Model.ListFlight.Count > 0)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "C:\Users\DELL\Documents\GitHub\Tour\Tour.UI\Views\Home\Tour.cshtml"
                 foreach (var item in Model.ListFlight)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-lg-4 col-md-4 col-sm-6\">\r\n                        <div class=\"fh5co-card-item\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a28ef441858a2f71dca410933036145ff4981c99131", async() => {
                WriteLiteral("\r\n                                <figure>\r\n                                    <div class=\"overlay\"><i class=\"ti-plus\"></i></div>\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "1a28ef441858a2f71dca410933036145ff4981c99560", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 2873, "~/assert/img/", 2873, 13, true);
#nullable restore
#line 65 "C:\Users\DELL\Documents\GitHub\Tour\Tour.UI\Views\Home\Tour.cshtml"
AddHtmlAttributeValue("", 2886, item.name, 2886, 10, false);

#line default
#line hidden
#nullable disable
                AddHtmlAttributeValue("", 2896, "/img_1.jpg", 2896, 10, true);
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                </figure>\r\n\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2640, "~/assert/img/", 2640, 13, true);
#nullable restore
#line 62 "C:\Users\DELL\Documents\GitHub\Tour\Tour.UI\Views\Home\Tour.cshtml"
AddHtmlAttributeValue("", 2653, item.name, 2653, 10, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 2663, "/img_1.jpg", 2663, 10, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            <div class=\"fh5co-text\">\r\n                                <h2>");
#nullable restore
#line 70 "C:\Users\DELL\Documents\GitHub\Tour\Tour.UI\Views\Home\Tour.cshtml"
                               Write(item.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                                <p>");
#nullable restore
#line 71 "C:\Users\DELL\Documents\GitHub\Tour\Tour.UI\Views\Home\Tour.cshtml"
                              Write(item.description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 72 "C:\Users\DELL\Documents\GitHub\Tour\Tour.UI\Views\Home\Tour.cshtml"
                                 if (Constants.FullName == null)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p><a href=\"#exampleModalCenter\" data-toggle=\"modal\" data-target=\"#exampleModalCenter\"><span class=\"btn btn-primary\">Xem thêm</span></a></p>\r\n");
#nullable restore
#line 75 "C:\Users\DELL\Documents\GitHub\Tour\Tour.UI\Views\Home\Tour.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p><a");
            BeginWriteAttribute("href", " href=\"", 3617, "\"", 3679, 1);
#nullable restore
#line 78 "C:\Users\DELL\Documents\GitHub\Tour\Tour.UI\Views\Home\Tour.cshtml"
WriteAttributeValue("", 3624, Url.Action("Info", "Home", new { flightID = item.Id }), 3624, 55, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><span class=\"btn btn-primary\">Xem thêm</span></a></p>\r\n");
#nullable restore
#line 79 "C:\Users\DELL\Documents\GitHub\Tour\Tour.UI\Views\Home\Tour.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 83 "C:\Users\DELL\Documents\GitHub\Tour\Tour.UI\Views\Home\Tour.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 83 "C:\Users\DELL\Documents\GitHub\Tour\Tour.UI\Views\Home\Tour.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <div class=\"card-footer clearfix\">\r\n");
#nullable restore
#line 87 "C:\Users\DELL\Documents\GitHub\Tour\Tour.UI\Views\Home\Tour.cshtml"
             if (Model.ListFlight != null && Model.ListFlight.Count > 0)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 89 "C:\Users\DELL\Documents\GitHub\Tour\Tour.UI\Views\Home\Tour.cshtml"
           Write(HtmlPageHelper.Paging(this.Url, @Model.ListFlight[0].totalRows, "_Index", "Home", "divListDetail",
                new RouteValueDictionary() {
                    { "p", Model.p },
                    { "keyWord",Model.keyWord}
                 }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 93 "C:\Users\DELL\Documents\GitHub\Tour\Tour.UI\Views\Home\Tour.cshtml"
                   
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
    </div>
</div>



<div id=""gtco-subscribe"">
    <div class=""gtco-container"">
        <div class=""row animate-box"">
            <div class=""col-md-8 col-md-offset-2 text-center gtco-heading"">
                <h2>Theo dõi</h2>
                <p>Hãy là người đầu tiên được thông báo khi có những tour mới</p>
            </div>
        </div>
        <div class=""row animate-box"">
            <div class=""col-md-8 col-md-offset-2"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a28ef441858a2f71dca410933036145ff4981c916849", async() => {
                WriteLiteral(@"
                    <div class=""col-md-6 col-sm-6"">
                        <div class=""form-group"">
                            <label for=""email"" class=""sr-only"">Email</label>
                            <input type=""email"" class=""form-control"" id=""email"" placeholder=""Your Email"">
                        </div>
                    </div>
                    <div class=""col-md-6 col-sm-6"">
                        <button type=""submit"" class=""btn btn-default btn-block"">Nhận thông báo</button>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
        </div>
    </div>
</div>

<div class=""modal fade"" id=""exampleModalCenter"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalCenterTitle"" aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-centered"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-body"">
                <p>Bạn phải <a href=""/"">đăng nhập</a> mới có thể xem thêm</p>
            </div>
        </div>
    </div>
</div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tour.UI.Models.FlightVM> Html { get; private set; }
    }
}
#pragma warning restore 1591