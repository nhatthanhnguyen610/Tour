using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tour.Base;

namespace Tour.Service
{
    public interface ITicketService
    {
        /// <summary>
        /// CreateBy: dtr
        /// Description: Lấy danh sách vé
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<TicketModel> GetList(SysUsrUserFilterModel model);
        /// <summary>
        /// CreateBy: dtr
        /// Description: Lấy danh sách chuyến bay
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<FlightModel> GetListFlight();
        /// <summary>
        /// CreateBy: dtr
        /// Description: Lấy danh sách khách hàng
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<SysCustomerModel> GetListCustomer();
        /// <summary>
        /// CreateBy: dtr
        /// Description: Lấy danh sách loại vé chuyến bay
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<TypeTicketModel> GetListTypeTicket();
        /// <summary>
        /// CreateBy: dtr
        /// Description: Đặt vé
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        bool InsertTicket(TicketModel model);
        /// <summary>
        /// CreateBy: dtr
        /// Description: Lấy thông tin vé
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        TicketModel GetInfo(decimal Id);
        /// <summary>
        /// CreateBy: dtr
        /// Description: Cập nhật vé
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        bool UpdateTicket(TicketModel model);
        /// <summary>
        /// CreateBy: dtr
        /// Description: Xóa vé
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        bool DeleteTicket(TicketModel model);
        /// <summary>
        /// CreateBy: dtr
        /// Description: Tăng stock
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        bool IncreaseStock(decimal id);
        /// <summary>
        /// CreateBy: dtr
        /// Description: giảm stock
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        bool ReduceStock(decimal id);
    }
}
