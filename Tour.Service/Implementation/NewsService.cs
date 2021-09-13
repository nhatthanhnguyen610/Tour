using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tour.Base;
using Tour.Provider;

namespace Tour.Service
{
    public class NewsService : INewsService
    {
        INewsProvider _sysNewsProvider;
        public NewsService(string appId, string userId = "0")
        {
            _sysNewsProvider = new NewsProvider(appId, userId);
        }
        /// <summary>
        /// CreateBy: dtr
        /// Description: Lấy danh sách bài viết
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<NewsModel> GetList(SysUsrUserFilterModel model)
        {
            return _sysNewsProvider.GetList(model);
        }
        /// <summary>
        /// CreateBy: dtr
        /// Description: Thêm bài viết
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool InsertSysNews(NewsModel model)
        {
            return _sysNewsProvider.InsertSysNews(model);
        }
        /// <summary>
        /// CreateBy: dtr
        /// Description: Lấy thông tin bài viết
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public NewsModel GetInfo(decimal newsId)
        {
            return _sysNewsProvider.GetInfo(newsId);
        }
        /// <summary>
        /// CreateBy: dtr
        /// Description: Cập nhật bài viết
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool UpdateSysNews(NewsModel model)
        {
            return _sysNewsProvider.UpdateSysNews(model);
        }
        /// <summary>
        /// CreateBy: dtr
        /// Description: Xóa bài viết
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool DeleteSysNews(NewsModel model)
        {
            return _sysNewsProvider.DeleteSysNews(model);
        }
    }
}
