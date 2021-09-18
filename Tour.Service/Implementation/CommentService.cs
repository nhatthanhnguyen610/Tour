using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tour.Base;
using Tour.Provider;

namespace Tour.Service
{
    public class CommentService : ICommentService
    {
        ICommentProvider _CommentProvider;
        public CommentService(string appId, string userId = "0")
        {
            _CommentProvider = new CommentProvider(appId, userId);
        }
        /// <summary>
        /// CreateBy: dtr
        /// Description: Lấy danh sách comment
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<CommentModel> GetList(SysUsrUserFilterModel model)
        {
            return _CommentProvider.GetList(model);
        }
        /// <summary>
        /// CreateBy: dtr
        /// Description: Lấy danh sách bài viết từ comment
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<NewsModel> GetListNews()
        {
            return _CommentProvider.GetListNews();
        }
        /// <summary>
        /// CreateBy: dtr
        /// Description: Thêm comment
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool InsertComment(CommentModel model)
        {
            return _CommentProvider.InsertComment(model);
        }
        /// <summary>
        /// CreateBy: dtr
        /// Description: Lấy thông tin comment
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public CommentModel GetInfo(decimal Id)
        {
            return _CommentProvider.GetInfo(Id);
        }
        /// <summary>
        /// CreateBy: dtr
        /// Description: Cập nhật comment
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool UpdateComment(CommentModel model)
        {
            return _CommentProvider.UpdateComment(model);
        }
        /// <summary>
        /// CreateBy: dtr
        /// Description: Xóa comment
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool DeleteComment(CommentModel model)
        {
            return _CommentProvider.DeleteComment(model);
        }
    }
}
