using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tour.Admin
{
    public partial class PagingHelper
    {
        #region Properties

        /// <summary>
        /// The name of the action method.
        /// </summary>
        public string ActionName { get; set; }

        /// <summary>
        /// The name of the controller.
        /// </summary>
        public string ControllerName { get; set; }

        /// <summary>
        /// An object that contains the parameters for a route.
        /// </summary>
        public RouteValueDictionary RouteValues { get; set; }

        /// <summary>
        /// The key in the RouteValues dictionary where to put the page number.
        /// </summary>
        public string PageRouteValueName { get; set; }

        /// <summary>
        /// The current page number. By default it is 1 (the first page).
        /// </summary>
        public int CurrentPageNumber { get; set; }

        /// <summary>
        /// The maximum number of elements in a page. If less then 1 we will consider 10 by default.
        /// </summary>
        public int PageSize
        {
            get { return _pageSize < 1 ? 10 : _pageSize; }
            set { _pageSize = value; }
        }

        public string IdHTML { get; set; }

        private int _pageSize;

        /// <summary>
        /// The total number of elements in the list.
        /// </summary>
        public int TotalNumberOfItems { get; set; }

        /// <summary>
        /// This will create a google-like pager that will display a limited number of page links. Deafult it is 10.
        /// </summary>
        public int MaximumNumberOfPageLinksToRender
        {
            get { return _maximumNumberOfPageLinksToRender < 1 ? 10 : _maximumNumberOfPageLinksToRender; }
            set { _maximumNumberOfPageLinksToRender = value; }
        }

        private int _maximumNumberOfPageLinksToRender;

        /// <summary>
        /// The HTML string to use as a container for all the pages. Example: <ul>{0}</ul> where {0} will be replaced with the page elements. Default is "{0}".
        /// </summary>
        public string ContainerHtmlFormatString
        {
            get { return string.IsNullOrEmpty(_containerHtmlFormatString) ? "{0}" : _containerHtmlFormatString; }
            set { _containerHtmlFormatString = value; }
        }

        private string _containerHtmlFormatString;

        /// <summary>
        /// The HTML string to use as a container for a page link. Example: <li>{0}</li> where {0} will be replaced with the page link. Default is "{0}".
        /// </summary>
        public string PageNumberHtmlFormatString
        {
            get { return string.IsNullOrEmpty(_pageNumberHtmlFormatString) ? "{0}" : _pageNumberHtmlFormatString; }
            set { _pageNumberHtmlFormatString = value; }
        }

        private string _pageNumberHtmlFormatString;

        /// <summary>
        /// The HTML string to use as a container for the current page number. Example: <strong><li>{0}</li></strong> where {0} will be replaced with the current page number. Default is <strong>{0}</strong>.
        /// </summary>
        public string CurrentPageNumberHtmlFormatString
        {
            get { return string.IsNullOrEmpty(_currentPageNumberHtmlFormatString) ? "<strong>{0}</strong>" : _currentPageNumberHtmlFormatString; }
            set { _currentPageNumberHtmlFormatString = value; }
        }

        private string _currentPageNumberHtmlFormatString;

        /// <summary>
        /// The HTML string used for separating two page numbers. For example you can use , as a separator. Default is ' '.
        /// </summary>
        public string SeparatorHtmlString { get; set; }

        /// <summary>
        /// True to show a go to previous page link. Default is true.
        /// </summary>
        public bool ShowPreviousLink { get; set; }

        /// <summary>
        /// The HTML/text to show inside the previous link element. Default is '&lt;'.
        /// </summary>
        public string PreviousLinkInnerHtml { get; set; }

        /// <summary>
        /// True to show a go to next page link. Default is true.
        /// </summary>
        public bool ShowNextLink { get; set; }

        /// <summary>
        /// The HTML/text to show inside the next link element. Default is '&gt;'.
        /// </summary>
        public string NextLinkInnerHtml { get; set; }

        /// <summary>
        /// True to show a go to first page link. Default is true.
        /// </summary>
        public bool ShowFirstLink { get; set; }

        /// <summary>
        /// The HTML/text to show inside the first link element. Default is '&lt;&lt;'.
        /// </summary>
        public string FirstLinkInnerHtml { get; set; }

        /// <summary>
        /// True to show a go to last page link. Default is true.
        /// </summary>
        public bool ShowLastLink { get; set; }

        /// <summary>
        /// The HTML/text to show inside the last link element. Default is '&gt;&gt;'.
        /// </summary>
        public string LastLinkInnerHtml { get; set; }

        /// <summary>
        /// True to hide the pager when there is only one page. Default is false.
        /// </summary>
        public bool AutoHide { get; set; }

        /// <summary>
        /// A custom JavaScript function for the page click that has as an input parameter the page number.
        /// </summary>
        public string PageLinkCustomAction { get; set; }

        /// <summary>
        /// Start index of page
        /// </summary>
        public int StartShowIndex { get; set; }

        /// <summary>
        /// Start index of page
        /// </summary>
        public int EndShowIndex { get; set; }
        #endregion Properties
        public PagingHelper(int currentPageNumber, int pageSize, int maximumNumberOfPageLinksToRender, int totalNumberOfItems, string actionName, string controllerName, RouteValueDictionary routeValues, string pageRouteValueName, string idhtml = "")
        {
            CurrentPageNumber = currentPageNumber;
            PageSize = pageSize;
            TotalNumberOfItems = totalNumberOfItems;
            ActionName = actionName;
            ControllerName = controllerName;
            RouteValues = routeValues;
            PageRouteValueName = pageRouteValueName;
            StartShowIndex = ((currentPageNumber - 1) * PageSize) + 1;
            EndShowIndex = currentPageNumber * PageSize <= TotalNumberOfItems ? currentPageNumber * PageSize : TotalNumberOfItems;
            //Defaults
            MaximumNumberOfPageLinksToRender = maximumNumberOfPageLinksToRender;
            CurrentPageNumberHtmlFormatString = "<li class='paging_button page-item active'><a class='page-link'>{0}</a></li>";
            SeparatorHtmlString = "";
            ShowPreviousLink = true;
            PreviousLinkInnerHtml = "<i class='fa fa-fw fa-angle-left'></i>";
            ShowNextLink = true;
            NextLinkInnerHtml = "<i class='fa fa-angle-right fa-fw'></i>";
            ShowFirstLink = false;
            FirstLinkInnerHtml = "<i class='fa fa-angle-double-left fa-fw'></i>";
            ShowLastLink = false;
            LastLinkInnerHtml = "<i class='fa fa-angle-double-right fa-fw'></i>";
            AutoHide = true;
            IdHTML = idhtml;
            ContainerHtmlFormatString = "<ul class='pagination pagination-sm m-0 float-right'>{0}</ul>";
        }
        public string GeneratePagerHtml(Microsoft.AspNetCore.Mvc.IUrlHelper urlHelper)
        {
            var totalNumberOfPages = TotalNumberOfItems == 0 ? 1 : (TotalNumberOfItems / PageSize + (TotalNumberOfItems % PageSize > 0 ? 1 : 0));
            var currentPageNumber = CurrentPageNumber < 1 ? 1 : (CurrentPageNumber > totalNumberOfPages ? totalNumberOfPages : CurrentPageNumber);

            if (AutoHide && totalNumberOfPages == 1)
                return string.Empty;
            var sb = new StringBuilder();
            bool IsDisabled = false;
            if (ShowFirstLink)
            {
                IsDisabled = !(currentPageNumber > 1);
                AddToStringBuilder(sb, GetLinkHtml(1, FirstLinkInnerHtml, urlHelper, IsDisabled));
            }

            if (ShowPreviousLink)
            {
                IsDisabled = !(currentPageNumber > 1);
                AddToStringBuilder(sb, GetLinkHtml(currentPageNumber - 1, PreviousLinkInnerHtml, urlHelper, IsDisabled));
            }
            //Pages
            var centerPosition = MaximumNumberOfPageLinksToRender / 2;
            var startPageNumber = currentPageNumber <= centerPosition ? 1 : currentPageNumber - centerPosition;

            if (startPageNumber >= 2)
            {
                AddToStringBuilder(sb, GetLinkHtml(1, 1.ToString(CultureInfo.InvariantCulture), urlHelper, false));
                AddToStringBuilder(sb, "<li class=\"paging_button page-item disabled\"><a class='page-link'>...</a></li>");
            }

            for (var pageNumber = startPageNumber; pageNumber <= totalNumberOfPages && pageNumber < startPageNumber + MaximumNumberOfPageLinksToRender; pageNumber++)
            {
                AddToStringBuilder(sb,
                                   pageNumber == currentPageNumber
                                       ? string.Format(CurrentPageNumberHtmlFormatString, pageNumber)
                                       : string.Format(PageNumberHtmlFormatString, GetLinkHtml(pageNumber, pageNumber.ToString(CultureInfo.InvariantCulture), urlHelper, false)));
            }

            if (startPageNumber + MaximumNumberOfPageLinksToRender < totalNumberOfPages)
            {
                AddToStringBuilder(sb, "<li class=\"paging_button page-item disabled\"><a class='page-link'>...</a></li>");
                AddToStringBuilder(sb, GetLinkHtml(totalNumberOfPages, totalNumberOfPages.ToString(CultureInfo.InvariantCulture), urlHelper, false));
            }
            if (ShowNextLink)
            {
                IsDisabled = !(currentPageNumber < totalNumberOfPages);
                AddToStringBuilder(sb, GetLinkHtml(currentPageNumber + 1, NextLinkInnerHtml, urlHelper, IsDisabled));
            }
            if (ShowLastLink)
            {
                IsDisabled = !(currentPageNumber < totalNumberOfPages);
                AddToStringBuilder(sb, GetLinkHtml(totalNumberOfPages, LastLinkInnerHtml, urlHelper, IsDisabled));
            }

            return string.Format(ContainerHtmlFormatString, sb);
        }
        protected string GetLinkHtml(int pageNumber, string innerHtml, Microsoft.AspNetCore.Mvc.IUrlHelper urlHelper, bool IsDisabled)
        {
            return string.Format("<li class=\"paging_button page-item {0}\"><a class='page-link' href=\"{1}\" data-viewId=\"{2}\">{3}</a></li>",
                                    IsDisabled == true ? "disabled" : "",
                                    string.IsNullOrEmpty(PageLinkCustomAction) ? (IsDisabled == true ? "javascript:void(0);" : GetPageLink(pageNumber, urlHelper)) : GetCustomAction(pageNumber),
                                    IdHTML,
                                    innerHtml);
        }

        protected string GetCustomAction(int pageNumber)
        {
            return string.Format("javascript:{0}(1);", PageLinkCustomAction);
        }

        protected string GetPageLink(int pageNumber, Microsoft.AspNetCore.Mvc.IUrlHelper urlHelper)
        {
            if (RouteValues != null && !string.IsNullOrEmpty(PageRouteValueName) && RouteValues.ContainsKey(PageRouteValueName))
                RouteValues[PageRouteValueName] = pageNumber;

            return string.IsNullOrEmpty(ActionName) || string.IsNullOrEmpty(ControllerName) ? "#" : urlHelper.Action(ActionName, ControllerName, RouteValues);
        }

        /// <summary>
        /// Add the string to the string builder. If the string builder is not emplty add before a separator.
        /// </summary>
        /// <param name="sb"></param>
        /// <param name="textToAdd"></param>
        protected void AddToStringBuilder(StringBuilder sb, string textToAdd)
        {
            if (sb.Length > 0)
                sb.Append(SeparatorHtmlString);
            sb.Append(textToAdd);
        }
    }
}