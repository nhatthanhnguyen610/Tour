using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tour.Base;

namespace Tour.Service
{
    public interface INewsService
    {     
        /// <summary>
        /// CreateBy: dtr
        /// Description: Lấy danh sách bài viết
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<NewsModel> GetList(SysUsrUserFilterModel model);
        /// <summary>
        /// CreateBy: dtr
        /// Description: Thêm bài viết
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        bool InsertSysNews(NewsModel model);
        /// <summary>
        /// CreateBy: dtr
        /// Description: Lấy thông tin bài viết
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        NewsModel GetInfo(decimal newsId);
        /// <summary>
        /// CreateBy: dtr
        /// Description: Cập nhật bài viết
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        bool UpdateSysNews(NewsModel model);
        /// <summary>
        /// CreateBy: dtr
        /// Description: Xóa bài viết
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        bool DeleteSysNews(NewsModel model);
        /// <summary>
        /// CreateBy: dtr
        /// Description: Lấy danh sách chuyến bay
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<FlightModel> GetListFlight();
    }
}
