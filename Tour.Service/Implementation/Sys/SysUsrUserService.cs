using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tour.Base;
using Tour.Provider;

namespace Tour.Service
{
    public class SysUsrUserService : ISysUsrUserService
    {
        ISysUsrUserProvider _sysUsrUserProvider;
        public SysUsrUserService(string appId, string userId = "0")
        {
            _sysUsrUserProvider = new SysUsrUserProvider(appId, userId);
        }
        /// <summary>
        /// CreateBy: thanhnn
        /// Description: Lấy danh sách người dùng
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<SysUsrUserModel> GetListSysUsrUser(SysUsrUserFilterModel model)
        {
            return _sysUsrUserProvider.GetListSysUsrUser(model);
        }

        /// <summary>
        /// CreateBy: dtr
        /// Description: Doi mat khau nguoi dung
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool ChangePassSysUser(RequestChangePassModel model)
        {
            return _sysUsrUserProvider.ChangePassSysUser(model);
        }

        /// <summary>
        /// CreateBy: thanhnn
        /// Description: Đăng nhập người dùng
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public UserLoginModel LoginSys(LoginRequestModel model)
        {
            return _sysUsrUserProvider.LoginSys(model);
        }
        /// <summary>
        /// CreateBy: thanhnn
        /// Description: Lấy danh sách quyền của người dùng
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<SysUserRoleModel> GetSysUserRoleByUser(string userCde)
        {
            return _sysUsrUserProvider.GetSysUserRoleByUser(userCde);
        }
        /// <summary>
        /// CreateBy: thanhnn
        /// Description: Thêm quyền người dùng
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool InsertSysUserRoleByUser(List<SysUserRoleModel> model)
        {
            return _sysUsrUserProvider.InsertSysUserRoleByUser(model);
        }
    }
}
