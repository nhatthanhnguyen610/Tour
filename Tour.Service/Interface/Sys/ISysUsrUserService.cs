using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tour.Base;

namespace Tour.Service
{
    public interface ISysUsrUserService
    {
        /// <summary>
        /// CreateBy: thanhnn
        /// Description: Lấy danh sách người dùng
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<SysUsrUserModel> GetListSysUsrUser(SysUsrUserFilterModel model);
        /// <summary>
        /// CreateBy: thanhnn
        /// Description: Đăng nhập người dùng
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        UserLoginModel LoginSys(LoginRequestModel model);

        /// <summary>
        /// CreateBy: dtr
        /// Description: Doi mat khau nguoi dung
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        bool ChangePassSysUser(RequestChangePassModel model);
        /// <summary>
        /// CreateBy: thanhnn
        /// Description: Lấy danh sách quyền của người dùng
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<SysUserRoleModel> GetSysUserRoleByUser(string userCde);
        /// <summary>
        /// CreateBy: thanhnn
        /// Description: Thêm quyền người dùng
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        bool InsertSysUserRoleByUser(List<SysUserRoleModel> model);
        /// <summary>
        /// CreateBy: thanhnn
        /// Description: Thêm mới người dùng
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        bool InsertSysUser(SysUsrUserModel model);
        /// <summary>
        /// CreateBy: thanhnn
        /// Description: lấy thông tin người dùng
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        SysUsrUserModel GetInfoSysUsrUser(decimal userID);
        /// <summary>
        /// CreateBy: thanhnn
        /// Description: Cập nhật người dùng
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        bool UpdateSysUsrUser(SysUsrUserModel model);
        /// <summary>
        /// CreateBy: thanhnn
        /// Description: kiểm tra Email trùng
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        bool IsEmailUsed(SysUsrUserModel model);
       
    }
}
