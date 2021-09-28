using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tour.Base;
using Tour.Provider;

namespace Tour.Service
{
    public class SysCustomerService : ISysCustomerService
    {
        ISysCustomerProvider _sysCustomerProvider;
        public SysCustomerService(string appId, string userId = "0")
        {
            _sysCustomerProvider = new SysCustomerProvider(appId, userId);
        }
        /// <summary>
        /// CreateBy: dtr
        /// Description: Lấy danh sách customer
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<SysCustomerModel> GetListSysCustomer(SysUsrUserFilterModel model)
        {
            return _sysCustomerProvider.GetListSysCustomer(model);
        }
        /// <summary>
        /// CreateBy: dtr
        /// Description: kiểm tra Email trùng
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool IsEmailUsed(SysCustomerModel model)
        {
            return _sysCustomerProvider.IsEmailUsed(model);
        }
        /// <summary>
        /// CreateBy: dtr
        /// Description: Thêm mới customer
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool InsertSysCustomer(SysCustomerModel model)
        {
            return _sysCustomerProvider.InsertSysCustomer(model);
        }
        /// <summary>
        /// CreateBy: dtr
        /// Description: lấy thông tin customer
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public SysCustomerModel GetInfoSysCustomer(decimal customerID)
        {
            return _sysCustomerProvider.GetInfoSysCustomer(customerID);
        }
        /// <summary>
        /// CreateBy: dtr
        /// Description: Cập nhật customer
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool UpdateSysCustomer(SysCustomerModel model)
        {
            return _sysCustomerProvider.UpdateSysCustomer(model);
        }
        /// <summary>
        /// CreateBy: dtr
        /// Description: xóa customer
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool DeleteSysCustomer(SysCustomerModel model)
        {
            return _sysCustomerProvider.DeleteSysCustomer(model);
        }
    }
}
