using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Tour.Base;

namespace Tour.Admin.Models
{
    public class CommentVM
    {
        public CommentVM()
        {
            ListComment = new List<CommentModel>();
        }
        public int p { get; set; }
        public string keyWord { get; set; }
        public List<CommentModel> ListComment { get; set; }
        public List<NewsModel> ListNews { get; set; }
        public int TotalRows
        {
            get
            {
                return ListComment != null ? (ListComment.Count > 0 ? ListComment.First().totalRows : 0) : 0;
            }
        }
    }

    public class CommentViewModel
    {
        public decimal id { get; set; }
        public string email { get; set; }
        public string content { get; set; }
        [Range(0.0, 5.0, ErrorMessage = "Số nhập từ 0 đến 5 và khoảng cách 0,5")]
        public decimal rate { get; set; }
        public int newsId { get; set; }
    }
}
