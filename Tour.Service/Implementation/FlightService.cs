using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tour.Base;
using Tour.Provider;

namespace Tour.Service
{
    public class FlightService : IFlightService
    {
        IFlightProvider _FlightProvider;
        public FlightService(string appId, string userId = "0")
        {
            _FlightProvider = new FlightProvider(appId, userId);
        }
        /// <summary>
        /// CreateBy: dtr
        /// Description: Lấy danh sách chuyến bay
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<FlightModel> GetList(SysUsrUserFilterModel model)
        {
            return _FlightProvider.GetList(model);
        }
        /// <summary>
        /// CreateBy: dtr
        /// Description: Thêm chuyến bay
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool InsertFlight(FlightModel model)
        {
            return _FlightProvider.InsertFlight(model);
        }
        /// <summary>
        /// CreateBy: dtr
        /// Description: Lấy thông tin chuyến bay
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public FlightModel GetInfo(decimal Id)
        {
            return _FlightProvider.GetInfo(Id);
        }
        /// <summary>
        /// CreateBy: dtr
        /// Description: Cập nhật chuyến bay
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool UpdateFlight(FlightModel model)
        {
            return _FlightProvider.UpdateFlight(model);
        }
        /// <summary>
        /// CreateBy: dtr
        /// Description: Xóa chuyến bay
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool DeleteFlight(FlightModel model)
        {
            return _FlightProvider.DeleteFlight(model);
        }
    }
}
