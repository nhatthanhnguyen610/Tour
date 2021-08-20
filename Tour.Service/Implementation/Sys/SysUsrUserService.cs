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
        /// CreateBy: dtr
        /// Description: Doi mat khau nguoi dung
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool ChangePassSysUser(RequestChangePassModel model)
        {
            return _sysUsrUserProvider.ChangePassSys(model);
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
    }
}
