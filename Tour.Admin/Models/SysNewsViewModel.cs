using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tour.Base;

namespace Tour.Admin.Models
{
    public class SysNewsVM
    {
        public SysNewsVM()
        {
            ListNews = new List<SysNewsModel>();
        }
        public int p { get; set; }
        public string keyWord { get; set; }
        public List<SysNewsModel> ListNews { get; set; }
        public int TotalRows
        {
            get
            {
                return ListNews != null ? (ListNews.Count > 0 ? ListNews.First().totalRows : 0) : 0;
            }
        }
    }

    public class SysNewsViewModel
    {
        public decimal newsId { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string category { get; set; }
    }
}
