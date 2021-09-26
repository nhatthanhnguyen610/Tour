using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tour.Base;
using Tour.Provider;

namespace Tour.Service
{
    public class TypeTicketService : ITypeTicketService
    {
        ITypeTicketProvider _TypeTicketProvider;
        public TypeTicketService(string appId, string userId = "0")
        {
            _TypeTicketProvider = new TypeTicketProvider(appId, userId);
        }
        /// <summary>
        /// CreateBy: dtr
        /// Description: Lấy danh sách loại vé
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<TypeTicketModel> GetList(SysUsrUserFilterModel model)
        {
            return _TypeTicketProvider.GetList(model);
        }
        /// <summary>
        /// CreateBy: dtr
        /// Description: Thêm loại vé
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool InsertTypeTicket(TypeTicketModel model)
        {
            return _TypeTicketProvider.InsertTypeTicket(model);
        }
        /// <summary>
        /// CreateBy: dtr
        /// Description: Lấy thông tin loại vé
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public TypeTicketModel GetInfo(decimal Id)
        {
            return _TypeTicketProvider.GetInfo(Id);
        }
        /// <summary>
        /// CreateBy: dtr
        /// Description: Cập nhật loại vé
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool UpdateTypeTicket(TypeTicketModel model)
        {
            return _TypeTicketProvider.UpdateTypeTicket(model);
        }
        /// <summary>
        /// CreateBy: dtr
        /// Description: Xóa loại vé
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool DeleteTypeTicket(TypeTicketModel model)
        {
            return _TypeTicketProvider.DeleteTypeTicket(model);
        }
    }
}
