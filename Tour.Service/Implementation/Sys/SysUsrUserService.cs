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
