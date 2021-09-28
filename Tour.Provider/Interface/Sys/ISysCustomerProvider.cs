using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tour.Base;

namespace Tour.Provider
{
    public interface ISysCustomerProvider
    {
        /// <summary>
        /// CreateBy: dtr
        /// Description: Lấy danh sách customer
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<SysCustomerModel> GetListSysCustomer(SysUsrUserFilterModel model);
        /// <summary>
        /// CreateBy: dtr
        /// Description: kiểm tra Email trùng
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        bool IsEmailUsed(SysCustomerModel model);
        /// <summary>
        /// CreateBy: dtr
        /// Description: Thêm mới customer
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        bool InsertSysCustomer(SysCustomerModel model);
        /// <summary>
        /// CreateBy: dtr
        /// Description: lấy thông tin customer
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        SysCustomerModel GetInfoSysCustomer(decimal customerID);
        /// <summary>
        /// CreateBy: dtr
        /// Description: Cập nhật customer
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        bool UpdateSysCustomer(SysCustomerModel model);
        /// <summary>
        /// CreateBy: dtr
        /// Description: xóa customer
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        bool DeleteSysCustomer(SysCustomerModel model);
    }
}
