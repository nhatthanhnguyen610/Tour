using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tour.Base;
using Tour.Provider;

namespace Tour.Service
{
    public class SysNewsService : ISysNewsService
    {
        ISysNewsProvider _sysNewsProvider;
        public SysNewsService(string appId, string userId = "0")
        {
            _sysNewsProvider = new SysNewsProvider(appId, userId);
        }
        /// <summary>
        /// CreateBy: dtr
        /// Description: Lấy danh sách bài viết
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<SysNewsModel> GetList(SysUsrUserFilterModel model)
        {
            return _sysNewsProvider.GetList(model);
        }
        /// <summary>
        /// CreateBy: dtr
        /// Description: Thêm bài viết
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool InsertSysNews(SysNewsModel model)
        {
            return _sysNewsProvider.InsertSysNews(model);
        }
        /// <summary>
        /// CreateBy: dtr
        /// Description: Lấy thông tin bài viết
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public SysNewsModel GetInfo(decimal newsId)
        {
            return _sysNewsProvider.GetInfo(newsId);
        }
        /// <summary>
        /// CreateBy: dtr
        /// Description: Cập nhật bài viết
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool UpdateSysNews(SysNewsModel model)
        {
            return _sysNewsProvider.UpdateSysNews(model);
        }
        /// <summary>
        /// CreateBy: dtr
        /// Description: Xóa bài viết
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool DeleteSysNews(SysNewsModel model)
        {
            return _sysNewsProvider.DeleteSysNews(model);
        }
    }
}
