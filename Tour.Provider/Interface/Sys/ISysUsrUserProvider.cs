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
        /// Description: Đăng nhập người dùng
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        UserLoginModel LoginSys(LoginRequestModel model);
        Boolean ChangePassSys(RequestChangePassModel model);
    }
}
