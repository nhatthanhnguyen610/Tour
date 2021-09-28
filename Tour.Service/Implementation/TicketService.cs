using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tour.Base;
using Tour.Provider;

namespace Tour.Service
{
    public class TicketService : ITicketService
    {
        ITicketProvider _TicketProvider;
        public TicketService(string appId, string userId = "0")
        {
            _TicketProvider = new TicketProvider(appId, userId);
        }
        /// <summary>
        /// CreateBy: dtr
        /// Description: Lấy danh sách vé
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<TicketModel> GetList(SysUsrUserFilterModel model)
        {
            return _TicketProvider.GetList(model);
        }
        /// <summary>
        /// CreateBy: dtr
        /// Description: Lấy danh sách chuyến bay
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<FlightModel> GetListFlight()
        {
            return _TicketProvider.GetListFlight();
        }
        /// <summary>
        /// CreateBy: dtr
        /// Description: Lấy danh sách khách hàng
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<SysCustomerModel> GetListCustomer()
        {
            return _TicketProvider.GetListCustomer();
        }
        /// <summary>
        /// CreateBy: dtr
        /// Description: Lấy danh sách loại vé chuyến bay
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<TypeTicketModel> GetListTypeTicket()
        {
            return _TicketProvider.GetListTypeTicket();
        }
        /// <summary>
        /// CreateBy: dtr
        /// Description: Đặt vé
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool InsertTicket(TicketModel model)
        {
            return _TicketProvider.InsertTicket(model);
        }
        /// <summary>
        /// CreateBy: dtr
        /// Description: Lấy thông tin vé
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public TicketModel GetInfo(decimal Id)
        {
            return _TicketProvider.GetInfo(Id);
        }
        /// <summary>
        /// CreateBy: dtr
        /// Description: Cập nhật vé
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool UpdateTicket(TicketModel model)
        {
            return _TicketProvider.UpdateTicket(model);
        }
        /// <summary>
        /// CreateBy: dtr
        /// Description: Xóa vé
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool DeleteTicket(TicketModel model)
        {
            return _TicketProvider.DeleteTicket(model);
        }
        /// <summary>
        /// CreateBy: dtr
        /// Description: Tăng stock
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool IncreaseStock(decimal id)
        {
            return _TicketProvider.IncreaseStock(id);
        }
        /// <summary>
        /// CreateBy: dtr
        /// Description: giảm stock
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool ReduceStock(decimal id)
        {
            return _TicketProvider.ReduceStock(id);
        }
    }
}
