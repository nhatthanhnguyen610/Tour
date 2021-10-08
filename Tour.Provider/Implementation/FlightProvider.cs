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
    public class FlightProvider : ConnectSqlExecute, IFlightProvider
    {
        public FlightProvider(string appId, string userId)
            : base(ConnectCode.DBConnection, appId, userId)
        {

        }
        /// <summary>
        /// CreateBy: dtr
        /// Description: Lấy danh sách chuyến bay
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<FlightModel> GetList(SysUsrUserFilterModel model)
        {
            var paramObj = new object[]
            {
                model.keyWord,
                model.pageIndex,
                model.pageSize
            };
            var resultComment = base.ExecProcedure<FlightModel>("sp_Flight_GetList_V01", paramObj);
            if (resultComment.Any())
            {
                return resultComment.ToList();
            }
            return null;

        }
        /// <summary>
        /// CreateBy: dtr
        /// Description: Thêm chuyến bay
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool InsertFlight(FlightModel model)
        {
            var paramObj = new object[]
            {
                model.name,
                model.image,
                model.description,
                model.date,
                model.duaration,
                model.stock,
                model.tigia,
                model.createdBy
            };
            var result = base.ExeScalar("sp_Flight_Insert_V01", paramObj);
            if (result != null && result.ToString().Equals("1"))
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// CreateBy: dtr
        /// Description: Lấy thông tin chuyến bay
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public FlightModel GetInfo(decimal Id)
        {
            var paramObj = new object[]
            {
               Id
            };
            var result = base.ExecProcedure<FlightModel>("sp_Flight_GetInfo_V01", paramObj);
            if (result.Any())
            {
                return result.FirstOrDefault();
            }
            return new FlightModel();
        }
        /// <summary>
        /// CreateBy: dtr
        /// Description: Cập nhật chuyến bay
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool UpdateFlight(FlightModel model)
        {
            var paramObj = new object[]
            {
                model.Id,
                model.name,
                model.image,
                model.description,
                model.date,
                model.stock,
                model.tigia,
                model.duaration,
                model.createdBy
            };
            var result = base.ExeScalar("sp_Flight_Update_V01", paramObj);
            if (result != null && result.ToString().Equals(ResultCode.Success))
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// CreateBy: dtr
        /// Description: Xóa chuyến bay
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool DeleteFlight(FlightModel model)
        {
            var paramObj = new object[]
            {
                model.Id
            };
            var result = base.ExeScalar("sp_Flight_Delete_V01", paramObj);
            if (result != null)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// CreateBy: dtr
        /// Description: Lấy danh sách chuyến bay cho UI
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<FlightModel> GetListUI()
        {
            var resultComment = base.ExecProcedure<FlightModel>("sp_Flight_GetListFlight_V01");
            if (resultComment.Any())
            {
                return resultComment.ToList();
            }
            return null;
        }
    }
}
