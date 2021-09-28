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
    public class NewsProvider : ConnectSqlExecute, INewsProvider
    {
        public NewsProvider(string appId, string userId)
           : base(ConnectCode.DBConnection, appId, userId)
        {

        }
        /// <summary>
        /// CreateBy: dtr
        /// Description: Lấy danh sách bài viết
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<NewsModel> GetList(SysUsrUserFilterModel model)
        {
            var paramObj = new object[]
            {

                model.keyWord,
                model.pageIndex,
                model.pageSize
            };
            var resultMenu = base.ExecProcedure<NewsModel>("sp_News_GetList_V01", paramObj);
            if (resultMenu.Any())
            {
                return resultMenu.ToList();
            }
            return null;
        }
        /// <summary>
        /// CreateBy: dtr
        /// Description: Thêm bài viết
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool InsertSysNews(NewsModel model)
        {
            var paramObj = new object[]
            {
                model.title,
                model.description,
                model.category,
                model.createdBy
            };
            var result = base.ExeScalar("sp_News_Insert_V01", paramObj);
            if (result != null && result.ToString().Equals("1"))
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// CreateBy: dtr
        /// Description: Lấy thông tin bài viết
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public NewsModel GetInfo(decimal newsId)
        {
            var paramObj = new object[]
            {
               newsId
            };
            var result = base.ExecProcedure<NewsModel>("sp_News_GetInfo_V01", paramObj);
            if (result.Any())
            {
                return result.FirstOrDefault();
            }
            return new NewsModel();
        }
        /// <summary>
        /// CreateBy: dtr
        /// Description: Cập nhật bài viết
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool UpdateSysNews(NewsModel model)
        {
            var paramObj = new object[]
            {
                model.newsId,
                model.title,
                model.description,
                model.category,
                model.createdBy
            };
            var result = base.ExeScalar("sp_News_Update_V01", paramObj);
            if (result != null && result.ToString().Equals(ResultCode.Success))
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// CreateBy: dtr
        /// Description: Xóa bài viết
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool DeleteSysNews(NewsModel model)
        {
            var paramObj = new object[]
            {
                model.newsId
            };
            var result = base.ExeScalar("sp_News_Delete_V01", paramObj);
            if (result != null)
            {
                return true;
            }
            return false;
        }
    }
}
