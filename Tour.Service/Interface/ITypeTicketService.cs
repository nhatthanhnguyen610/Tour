using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tour.Base;

namespace Tour.Service
{
    public interface ITypeTicketService
    {
        /// <summary>
        /// CreateBy: dtr
        /// Description: Lấy danh sách loại vé
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<TypeTicketModel> GetList(SysUsrUserFilterModel model);
        /// <summary>
        /// CreateBy: dtr
        /// Description: Thêm loại vé
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        bool InsertTypeTicket(TypeTicketModel model);
        /// <summary>
        /// CreateBy: dtr
        /// Description: Lấy thông tin loại vé
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        TypeTicketModel GetInfo(decimal Id);
        /// <summary>
        /// CreateBy: dtr
        /// Description: Cập nhật loại vé
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        bool UpdateTypeTicket(TypeTicketModel model);
        /// <summary>
        /// CreateBy: dtr
        /// Description: Xóa loại vé
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        bool DeleteTypeTicket(TypeTicketModel model);
        /// <summary>
        /// CreateBy: dtr
        /// Description: Lấy danh sách chuyến bay
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<FlightModel> GetListFlight();
    }
}
