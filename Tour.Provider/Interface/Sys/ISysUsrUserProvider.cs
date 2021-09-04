using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tour.Base;

namespace Tour.Provider
{
    public interface ISysUsrUserProvider
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
        /// Description: Lấy danh sách quyền menu của người dùng
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<SysMenuUserModel> GetListMenuSysUsr(SysUsrUserFilterModel model);
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
        /// <summary>
        /// CreateBy: dtr
        /// Description: kiểm tra MenuTitle trùng
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        bool IsMenuTitlelUsed(SysMenuUserModel model);
        /// <summary>
        /// CreateBy: dtr
        /// Description: Thêm Menu mới
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        bool InsertSysMenu(SysMenuUserModel model);
        /// <summary>
        /// CreateBy: dtr
        /// Description: Lấy thông tin menu
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        SysMenuUserModel GetInfoSysUsrMenu(decimal menuID);
        /// <summary>
        /// CreateBy: dtr
        /// Description: Cập nhật menu
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        bool UpdateSysUsrMenu(SysMenuUserModel model);
    }
}
