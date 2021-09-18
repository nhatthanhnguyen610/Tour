using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tour.Base
{
    public class CommentModel : DefaultModel
    {
        public decimal id { get; set; }
        public string email { get; set; }
        public string content { get; set; }
        public decimal rate { get; set; }
        public int newsId { get; set; }
        public int totalRows { get; set; }
        public int totalPages { get; set; }
    }
}
