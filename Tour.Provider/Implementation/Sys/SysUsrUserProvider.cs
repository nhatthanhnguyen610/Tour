using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tour.Base;
using Tour.Provider.Connection;
using static Tour.Provider.Connection.ConnectString;

namespace Tour.Provider
{
    public class SysUsrUserProvider : ConnectSqlExecute, ISysUsrUserProvider
    {
        public SysUsrUserProvider(string appId, string userId)
           : base(ConnectCode.DBConnection, appId, userId)
        {

        }
        /// <summary>
        /// CreateBy: thanhnn
        /// Description: Đăng nhập người dùng
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public UserLoginModel LoginSys(LoginRequestModel model)
        {
            var paramObj = new object[]
             {
                model.email,
                model.passWord
             };
            var result = base.ExecProcedure<UserLoginModel>("sp_SysUsrUser_Login_V01", paramObj);
            if (result.Any())
            {
                var userResult = result.FirstOrDefault();
                var paramObjMenu = new object[] { userResult.userCode };
                var resultMenu = base.ExecProcedure<SysMenuOfUser>("sp_SysUserRole_ByUsercode_V01", paramObjMenu);
                if (resultMenu.Any())
                {
                    userResult.ListMenuOfUser = resultMenu.ToList();
                }
                return userResult;
            }
            return null;
        }
    }
}
