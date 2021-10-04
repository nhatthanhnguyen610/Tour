using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tour.UI
{
    public static class HtmlPageHelper
    {
        public static IHtmlContent IframeButton(string iframeTitle, string iframeUrl, string iconHtml, int width, int height, object htmlAttributes)
        {
            var tagName = "a";
            var tagBuilder = new TagBuilder(tagName);
            string result;
            var htmlAttributeDic = (IDictionary<string, object>)HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes);
            htmlAttributeDic.Add("data-href", ".popup-modal");
            htmlAttributeDic.Add("data-title", iframeTitle);
            htmlAttributeDic.Add("data-event", "popup-modal");
            htmlAttributeDic.Add("data-url", iframeUrl);
            htmlAttributeDic.Add("data-width", width);
            htmlAttributeDic.Add("data-height", height);
            htmlAttributeDic.Add("href", "javascript:void(0);");
            if (htmlAttributeDic.Count(m => m.Key == "class") > 0)
            {
                htmlAttributeDic["class"] = htmlAttributeDic["class"] + " btn-show-popup";
            }
            else
            {
                htmlAttributeDic.Add("class", "btn-show-popup");
            }
            tagBuilder.MergeAttributes(htmlAttributeDic);
            tagBuilder.InnerHtml.AppendHtml(string.Concat(iconHtml, iframeTitle));
            using (var sw = new System.IO.StringWriter())
            {
                tagBuilder.WriteTo(sw, System.Text.Encodings.Web.HtmlEncoder.Default);
                result = sw.ToString();
            }
            return new HtmlString(result);
        }
        public static IHtmlContent Paging(Microsoft.AspNetCore.Mvc.IUrlHelper urlHelper, int totalRow,
                                                 string actionName, string controllerName, string idhtml, RouteValueDictionary routeValue)
        {
            var rowPerPage = DefinedConstants.RowPerPage;
            var maxPageLink = DefinedConstants.MaxPagingLink;
            var pageRouteValueName = DefinedConstants.PageRouteValueName;
            var currentPage = Convert.ToInt32(routeValue[pageRouteValueName]);
            var pagingData = new PagingHelper(currentPage, rowPerPage, maxPageLink, totalRow, actionName, controllerName, routeValue, pageRouteValueName, idhtml);
            return new HtmlString(pagingData.GeneratePagerHtml(urlHelper));
        }
    }
}
