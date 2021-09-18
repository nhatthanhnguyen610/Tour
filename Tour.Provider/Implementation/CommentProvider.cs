using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tour.Base;
using Tour.Common.Constants;
using Tour.Provider.Connection;
using static Tour.Provider.Connection.ConnectString;

namespace Tour.Provider
{
    public class CommentProvider : ConnectSqlExecute, ICommentProvider
    {
        public CommentProvider(string appId, string userId)
           : base(ConnectCode.DBConnection, appId, userId)
        {

        }
        /// <summary>
        /// CreateBy: dtr
        /// Description: Lấy danh sách comment
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<CommentModel> GetList(SysUsrUserFilterModel model)
        {
            var paramObj = new object[]
           {

                model.keyWord,
                model.pageIndex,
                model.pageSize
           };
            var resultComment = base.ExecProcedure<CommentModel>("sp_Comment_GetList_V01", paramObj);
            if (resultComment.Any())
            {
                return resultComment.ToList();
            }
            return null;
        }
        /// <summary>
        /// CreateBy: dtr
        /// Description: Lấy danh sách bài viết từ comment
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<NewsModel> GetListNews()
        {
            var resultComment = base.ExecProcedure<NewsModel>("sp_Comment_GetListNews_V01");
            if (resultComment.Any())
            {
                return resultComment.ToList();
            }
            return null;
        }
        /// <summary>
        /// CreateBy: dtr
        /// Description: Thêm comment
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool InsertComment(CommentModel model)
        {
            var paramObj = new object[]
            {
                model.email,
                model.content,
                model.rate,
                model.newsId,
                model.createdBy
            };
            var result = base.ExeScalar("sp_Comment_Insert_V01", paramObj);
            if (result != null && result.ToString().Equals("1"))
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// CreateBy: dtr
        /// Description: Lấy thông tin comment
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public CommentModel GetInfo(decimal Id)
        {
            var paramObj = new object[]
            {
               Id
            };
            var result = base.ExecProcedure<CommentModel>("sp_Comment_GetInfo_V01", paramObj);
            if (result.Any())
            {
                return result.FirstOrDefault();
            }
            return new CommentModel();
        }
        /// <summary>
        /// CreateBy: dtr
        /// Description: Cập nhật comment
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool UpdateComment(CommentModel model)
        {
            var paramObj = new object[]
            {
                model.id,
                model.email,
                model.content,
                model.rate,
                model.newsId,
                model.createdBy
            };
            var result = base.ExeScalar("sp_Comment_Update_V01", paramObj);
            if (result != null && result.ToString().Equals(ResultCode.Success))
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// CreateBy: dtr
        /// Description: Xóa comment
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool DeleteComment(CommentModel model)
        {
            var paramObj = new object[]
           {
                model.id
           };
            var result = base.ExeScalar("sp_Comment_Delete_V01", paramObj);
            if (result != null)
            {
                return true;
            }
            return false;
        }
    }
}
