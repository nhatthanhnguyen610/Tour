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
    public class TypeTicketProvider : ConnectSqlExecute, ITypeTicketProvider
    {
        public TypeTicketProvider(string appId, string userId)
           : base(ConnectCode.DBConnection, appId, userId)
        {

        }
        /// <summary>
        /// CreateBy: dtr
        /// Description: Lấy danh sách loại vé
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<TypeTicketModel> GetList(SysUsrUserFilterModel model)
        {
            var paramObj = new object[]
            {

                model.keyWord,
                model.pageIndex,
                model.pageSize
            };
            var resultComment = base.ExecProcedure<TypeTicketModel>("sp_TypeTicket_GetList_V01", paramObj);
            if (resultComment.Any())
            {
                return resultComment.ToList();
            }
            return null;
        }
        /// <summary>
        /// CreateBy: dtr
        /// Description: Thêm loại vé
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool InsertTypeTicket(TypeTicketModel model)
        {
            var paramObj = new object[]
            {
                model.type,
                model.price,
                model.stock,
                model.flightId,
                model.createdBy
            };
            var result = base.ExeScalar("sp_TypeTicket_Insert_V01", paramObj);
            if (result != null && result.ToString().Equals("1"))
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// CreateBy: dtr
        /// Description: Lấy thông tin loại vé
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public TypeTicketModel GetInfo(decimal Id)
        {
            var paramObj = new object[]
            {
               Id
            };
            var result = base.ExecProcedure<TypeTicketModel>("sp_TypeTicket_GetInfo_V01", paramObj);
            if (result.Any())
            {
                return result.FirstOrDefault();
            }
            return new TypeTicketModel();
        }
        /// <summary>
        /// CreateBy: dtr
        /// Description: Cập nhật loại vé
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool UpdateTypeTicket(TypeTicketModel model)
        {
            var paramObj = new object[]
           {
                model.Id,
                model.type,
                model.price,
                model.stock,
                model.flightId,
                model.createdBy
           };
            var result = base.ExeScalar("sp_TypeTicket_Update_V01", paramObj);
            if (result != null && result.ToString().Equals(ResultCode.Success))
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// CreateBy: dtr
        /// Description: Xóa loại vé
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool DeleteTypeTicket(TypeTicketModel model)
        {
            var paramObj = new object[]
            {
                model.Id
            };
            var result = base.ExeScalar("sp_TypeTicket_Delete_V01", paramObj);
            if (result != null)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// CreateBy: dtr
        /// Description: Lấy danh sách chuyến bay
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<FlightModel> GetListFlight()
        {
            var resultComment = base.ExecProcedure<FlightModel>("sp_TypeTicket_GetListFlight_V01");
            if (resultComment.Any())
            {
                return resultComment.ToList();
            }
            return null;
        }
    }
}
