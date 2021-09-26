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
    public class TicketProvider : ConnectSqlExecute, ITicketProvider
    {
        public TicketProvider(string appId, string userId)
          : base(ConnectCode.DBConnection, appId, userId)
        {

        }
        /// <summary>
        /// CreateBy: dtr
        /// Description: Lấy danh sách vé
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<TicketModel> GetList(SysUsrUserFilterModel model)
        {
            var paramObj = new object[]
            {

                model.keyWord,
                model.pageIndex,
                model.pageSize
            };
            var resultComment = base.ExecProcedure<TicketModel>("sp_Ticket_GetList_V01", paramObj);
            if (resultComment.Any())
            {
                return resultComment.ToList();
            }
            return null;
        }
        /// <summary>
        /// CreateBy: dtr
        /// Description: Lấy danh sách chuyến bay
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<FlightModel> GetListFlight()
        {
            var resultComment = base.ExecProcedure<FlightModel>("sp_Ticket_GetListFlight_V01");
            if (resultComment.Any())
            {
                return resultComment.ToList();
            }
            return null;
        }
        /// <summary>
        /// CreateBy: dtr
        /// Description: Lấy danh sách khách hàng
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<SysCustomerModel> GetListCustomer()
        {
            var resultComment = base.ExecProcedure<SysCustomerModel>("sp_Ticket_GetListCustomer_V01");
            if (resultComment.Any())
            {
                return resultComment.ToList();
            }
            return null;
        }
        /// <summary>
        /// CreateBy: dtr
        /// Description: Lấy danh sách loại vé chuyến bay
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<TypeTicketModel> GetListTypeTicket()
        {
            var resultComment = base.ExecProcedure<TypeTicketModel>("sp_Ticket_GetListTypeTicket_V01");
            if (resultComment.Any())
            {
                return resultComment.ToList();
            }
            return null;
        }
        /// <summary>
        /// CreateBy: dtr
        /// Description: Đặt vé
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool InsertTicket(TicketModel model)
        {
            var paramObj = new object[]
            {
                model.userId,
                model.flightId,
                model.TTicketId,
                model.TTicketIdChange,
                model.createdBy
            };
            var result = base.ExeScalar("sp_Ticket_Insert_V01", paramObj);
            if (result != null && result.ToString().Equals("1"))
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// CreateBy: dtr
        /// Description: Lấy thông tin vé
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public TicketModel GetInfo(decimal Id)
        {
            var paramObj = new object[]
            {
               Id
            };
            var result = base.ExecProcedure<TicketModel>("sp_Ticket_GetInfo_V01", paramObj);
            if (result.Any())
            {
                return result.FirstOrDefault();
            }
            return new TicketModel();
        }
        /// <summary>
        /// CreateBy: dtr
        /// Description: Cập nhật vé
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool UpdateTicket(TicketModel model)
        {
            var paramObj = new object[]
            {
                model.Id,
                model.userId,
                model.flightId,
                model.TTicketId,
                model.TTicketIdChange,
                model.createdBy
            };
            var result = base.ExeScalar("sp_Ticket_Update_V01", paramObj);
            if (result != null && result.ToString().Equals(ResultCode.Success))
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// CreateBy: dtr
        /// Description: Xóa vé
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool DeleteTicket(TicketModel model)
        {
            var paramObj = new object[]
            {
                model.Id
            };
            var result = base.ExeScalar("sp_Ticket_Delete_V01", paramObj);
            if (result != null)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// CreateBy: dtr
        /// Description: Tăng stock
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool IncreaseStock(decimal id)
        {
            var paramObj = new object[]
            {
                id
            };
            var result = base.ExeScalar("sp_Ticket_IncreaseStock_V01", paramObj);
            if (result != null)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// CreateBy: dtr
        /// Description: giảm stock
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool ReduceStock(decimal id)
        {
            var paramObj = new object[]
           {
                id
           };
            var result = base.ExeScalar("sp_Ticket_ReduceStock_V01", paramObj);
            if (result != null)
            {
                return true;
            }
            return false;
        }
    }
}
