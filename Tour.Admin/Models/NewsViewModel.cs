using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tour.Base;

namespace Tour.Admin.Models
{
    public class NewsVM
    {
        public NewsVM()
        {
            ListNews = new List<NewsModel>();
        }
        public int p { get; set; }
        public string keyWord { get; set; }
        public List<NewsModel> ListNews { get; set; }
        public int TotalRows
        {
            get
            {
                return ListNews != null ? (ListNews.Count > 0 ? ListNews.First().totalRows : 0) : 0;
            }
        }
    }

    public class NewsViewModel
    {
        public decimal newsId { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string category { get; set; }
        public int flightId { get; set; }
    }
}
