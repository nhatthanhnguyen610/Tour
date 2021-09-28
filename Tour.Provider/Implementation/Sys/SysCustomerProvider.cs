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
    public class SysCustomerProvider : ConnectSqlExecute, ISysCustomerProvider
    {
        public SysCustomerProvider(string appId, string userId)
         : base(ConnectCode.DBConnection, appId, userId)
        {

        }
        /// <summary>
        /// CreateBy: dtr
        /// Description: Lấy danh sách customer
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<SysCustomerModel> GetListSysCustomer(SysUsrUserFilterModel model)
        {
            var paramObj = new object[]
           {
                model.keyWord,
                model.pageIndex,
                model.pageSize
           };
            var resultMenu = base.ExecProcedure<SysCustomerModel>("sp_SysCustomer_GetList_V01", paramObj);
            if (resultMenu.Any())
            {
                return resultMenu.ToList();
            }
            return null;
        }
        /// <summary>
        /// CreateBy: dtr
        /// Description: kiểm tra Email trùng
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool IsEmailUsed(SysCustomerModel model)
        {
            var paramObj = new object[]
           {
                model.Id,
                model.email
           };
            var result = base.ExeScalar("sp_SysCustomer_GetListByEmail_V01", paramObj);
            if (result != null)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// CreateBy: dtr
        /// Description: Thêm mới customer
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool InsertSysCustomer(SysCustomerModel model)
        {
            var paramObj = new object[]
           {
                model.username,
                model.password,
                model.fullName,
                model.birthday,
                model.address,
                model.email,
                model.phone,
                model.avatar,
                model.createdBy
           };
            var result = base.ExeScalar("sp_SysCustomer_Insert_V01", paramObj);
            if (result != null && result.ToString().Equals("1"))
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// CreateBy: dtr
        /// Description: lấy thông tin customer
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public SysCustomerModel GetInfoSysCustomer(decimal customerID)
        {
            var paramObj = new object[]
            {
               customerID
            };
            var result = base.ExecProcedure<SysCustomerModel>("sp_SysCustomer_GetInfo_V01", paramObj);
            if (result.Any())
            {
                return result.FirstOrDefault();
            }
            return new SysCustomerModel();
        }
        /// <summary>
        /// CreateBy: dtr
        /// Description: Cập nhật customer
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool UpdateSysCustomer(SysCustomerModel model)
        {
            var paramObj = new object[]
           {
                model.Id,
                model.username,
                model.password,
                model.fullName,
                model.birthday,
                model.address,
                model.email,
                model.phone,
                model.avatar,
                model.createdBy
           };
            var result = base.ExeScalar("sp_SysCustomer_Update_V01", paramObj);
            if (result != null && result.ToString().Equals(ResultCode.Success))
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// CreateBy: dtr
        /// Description: xóa customer
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool DeleteSysCustomer(SysCustomerModel model)
        {
            var paramObj = new object[]
            {
                model.Id
            };
            var result = base.ExeScalar("sp_SysCustomer_Delete_V01", paramObj);
            if (result != null)
            {
                return true;
            }
            return false;
        }
    }
}
