using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tour.Base;

namespace Tour.Provider
{
    public interface ICommentProvider
    {
        /// <summary>
        /// CreateBy: dtr
        /// Description: Lấy danh sách comment
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<CommentModel> GetList(SysUsrUserFilterModel model);
        /// <summary>
        /// CreateBy: dtr
        /// Description: Lấy danh sách bài viết từ comment
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<NewsModel> GetListNews();
        /// <summary>
        /// CreateBy: dtr
        /// Description: Thêm comment
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        bool InsertComment(CommentModel model);
        /// <summary>
        /// CreateBy: dtr
        /// Description: Lấy thông tin comment
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        CommentModel GetInfo(decimal Id);
        /// <summary>
        /// CreateBy: dtr
        /// Description: Cập nhật comment
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        bool UpdateComment(CommentModel model);
        /// <summary>
        /// CreateBy: dtr
        /// Description: Xóa comment
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        bool DeleteComment(CommentModel model);
    }
}
