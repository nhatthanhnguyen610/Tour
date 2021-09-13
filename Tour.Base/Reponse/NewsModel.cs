using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tour.Base
{
    public class NewsModel : DefaultModel
    {
        public decimal newsId { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string category { get; set; }
        public int totalRows { get; set; }
        public int totalPages { get; set; }
    }
}
