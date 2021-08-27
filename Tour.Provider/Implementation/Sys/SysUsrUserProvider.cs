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
    public class SysUsrUserProvider : ConnectSqlExecute, ISysUsrUserProvider
    {
        public SysUsrUserProvider(string appId, string userId)
           : base(ConnectCode.DBConnection, appId, userId)
        {

        }
        /// <summary>
        /// CreateBy: thanhnn
        /// Description: Lấy danh sách người dùng
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<SysUsrUserModel> GetListSysUsrUser(SysUsrUserFilterModel model)
        {
            var paramObj = new object[]
            {
                model.keyWord,
                model.pageIndex,
                model.pageSize
            };
            var result = base.ExecProcedure<SysUsrUserModel>("sp_SysUsrUser_GetList_V01", paramObj);
            if (result.Any())
            {
                return result.ToList();
            }
            return null;
        }

        /// <summary>
        /// CreateBy: dtr
        /// Description: Doi mat khau nguoi dung
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool ChangePassSysUser(RequestChangePassModel model)
        {
            var paramObj = new object[]
            {
                model.passWordOld,
                model.userCde,
                model.passWordNew,
                model.passWordConfirm
            };
            var result = base.ExeScalar("sp_SysUsrUser_ChangePassword_V01", paramObj);
            if (result != null && result.ToString().Equals("1"))
            {
                return true;
            }
            return false;
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
        /// <summary>
        /// CreateBy: thanhnn
        /// Description: Lấy danh sách quyền của người dùng
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<SysUserRoleModel> GetSysUserRoleByUser(string userCde)
        {
            var paramObj = new object[]
            {
                userCde
            };
            var result = base.ExecProcedure<SysUserRoleModel>("sp_SysUserRole_ByUser_V01", paramObj);
            if (result.Any())
            {
                return result.ToList();
            }
            return null;
        }
        /// <summary>
        /// CreateBy: thanhnn
        /// Description: Thêm quyền người dùng
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool InsertSysUserRoleByUser(List<SysUserRoleModel> model)
        {
            using (var tran = new System.Transactions.TransactionScope(System.Transactions.TransactionScopeOption.Required,
             new System.Transactions.TransactionOptions { IsolationLevel = System.Transactions.IsolationLevel.ReadUncommitted }))
            {
                if (model != null && model.Count > 0)
                {
                    var userCde = model[0].userCde;
                    var paramObj = new object[]
                    {
                        userCde
                    };
                    var resultDele = base.ExeScalar("sp_SysUserRole_Delete_V01", paramObj);
                    if (resultDele != null && resultDele.ToString().Equals("1"))
                    {
                        foreach (var item in model)
                        {
                            var paramObjAdd = new object[]
                                {
                                    item.userCde,
                                    item.menuCde,
                                    item.createdBy
                                };
                            var result = base.ExeScalar("sp_SysUserRole_Insert_V01", paramObjAdd);
                            if (result == null || !result.ToString().Equals("1"))
                            {
                                return false;
                            }
                        }
                    }
                }
                tran.Complete();
                return true;
            }
        }
        /// <summary>
        /// CreateBy: thanhnn
        /// Description: Thêm mới người dùng
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool InsertSysUser(SysUsrUserModel model)
        {
            var paramObj = new object[]
            {
                model.userName,
                model.password,
                model.fullName,
                model.birthday,
                model.address,
                model.email,
                model.phone,
                model.avatar,
                model.isActive,
                model.createdBy
            };
            var result = base.ExeScalar("sp_SysUsrUser_Insert_V01", paramObj);
            if (result != null && result.ToString().Equals("1"))
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// CreateBy: thanhnn
        /// Description: lấy thông tin người dùng
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public SysUsrUserModel GetInfoSysUsrUser(decimal userID)
        {
            var paramObj = new object[]
            {
               userID
            };
            var result = base.ExecProcedure<SysUsrUserModel>("sp_SysUsrUser_GetInfo_V01", paramObj);
            if (result.Any())
            {
                return result.FirstOrDefault();
            }
            return new SysUsrUserModel();
        }
        /// <summary>
        /// CreateBy: thanhnn
        /// Description: Cập nhật người dùng
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool UpdateSysUsrUser(SysUsrUserModel model)
        {
            var paramObj = new object[]
            {
                model.userID,
                model.userName,
                model.password,
                model.fullName,
                model.birthday,
                model.address,
                model.email,
                model.phone,
                model.avatar,
                model.isActive,
                model.createdBy
            };
            var result = base.ExeScalar("sp_SysUsrUser_Update_V01", paramObj);
            if (result != null && result.ToString().Equals(ResultCode.Success))
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// CreateBy: thanhnn
        /// Description: kiểm tra Email trùng
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool IsEmailUsed(SysUsrUserModel model)
        {
            var paramObj = new object[]
            {
                model.userID,
                model.email
            };
            var result = base.ExeScalar("sp_SysUsrUser_GetListByEmail_V01", paramObj);
            if (result != null)
            {
                return true;
            }
            return false;
        }
    }
}
