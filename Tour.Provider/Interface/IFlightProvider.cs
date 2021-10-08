using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tour.Base;

namespace Tour.Provider
{
    public interface IFlightProvider
    {
        /// <summary>
        /// CreateBy: dtr
        /// Description: Lấy danh sách chuyến bay
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<FlightModel> GetList(SysUsrUserFilterModel model);
        /// <summary>
        /// CreateBy: dtr
        /// Description: Thêm chuyến bay
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        bool InsertFlight(FlightModel model);
        /// <summary>
        /// CreateBy: dtr
        /// Description: Lấy thông tin chuyến bay
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        FlightModel GetInfo(decimal Id);
        /// <summary>
        /// CreateBy: dtr
        /// Description: Cập nhật chuyến bay
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        bool UpdateFlight(FlightModel model);
        /// <summary>
        /// CreateBy: dtr
        /// Description: Xóa chuyến bay
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        bool DeleteFlight(FlightModel model);
        /// <summary>
        /// CreateBy: dtr
        /// Description: Lấy danh sách chuyến bay cho UI
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<FlightModel> GetListUI();
    }
}
