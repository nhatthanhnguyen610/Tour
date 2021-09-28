using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tour.Provider.Connection;
using Tour.Base;
using static Tour.Provider.Connection.ConnectString;
using Tour.Common.Constants;

namespace Tour.Provider
{
    public class SysMenuProvider : ConnectSqlExecute, ISysMenuProvider
    {
        public SysMenuProvider(string appId, string userId)
          : base(ConnectCode.DBConnection, appId, userId)
        {

        }
        /// <summary>
        /// CreateBy: dtr
        /// Description: Lấy danh sách quyền menu của người dùng
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<SysMenuUserModel> GetListMenuSysUsr(SysUsrUserFilterModel model)
        {
            var paramObj = new object[]
            {

                model.keyWord,
                model.pageIndex,
                model.pageSize
            };
            var resultMenu = base.ExecProcedure<SysMenuUserModel>("sp_SysUsrMenu_GetMenuList_V01", paramObj);
            if (resultMenu.Any())
            {
                return resultMenu.ToList();
            }
            return null;
        }

        /// <summary>
        /// CreateBy: dtr
        /// Description: kiểm tra MenuTitle trùng
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool IsMenuTitlelUsed(SysMenuUserModel model)
        {
            var paramObj = new object[]
            {
                model.id,
                model.menuTitleCde
            };
            var result = base.ExeScalar("sp_SysUsrMenu_GetListMenuByTitle_V01", paramObj);
            if (result != null)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// CreateBy: dtr
        /// Description: Thêm Menu mới
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool InsertSysMenu(SysMenuUserModel model)
        {
            var paramObj = new object[]
            {
                model.menuCode,
                model.parentMenuCde,
                model.menuTitleCde,
                model.menuIcon,
                model.actionOrClass,
                model.controller,
                model.orderBy,
                model.createdBy
            };
            var result = base.ExeScalar("sp_SysUsrMenu_Insert_V01", paramObj);
            if (result != null && result.ToString().Equals("1"))
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// CreateBy: dtr
        /// Description: Lấy thông tin menu
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public SysMenuUserModel GetInfoSysUsrMenu(decimal menuID)
        {
            var paramObj = new object[]
            {
               menuID
            };
            var result = base.ExecProcedure<SysMenuUserModel>("sp_SysUsrMenu_GetInfo_V01", paramObj);
            if (result.Any())
            {
                return result.FirstOrDefault();
            }
            return new SysMenuUserModel();
        }
        /// <summary>
        /// CreateBy: dtr
        /// Description: Cập nhật menu
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool UpdateSysUsrMenu(SysMenuUserModel model)
        {
            var paramObj = new object[]
            {
                model.id,
                model.menuCode,
                model.parentMenuCde,
                model.menuTitleCde,
                model.menuIcon,
                model.actionOrClass,
                model.controller,
                model.orderBy,
                model.createdBy
            };
            var result = base.ExeScalar("sp_SysUsrMenu_Update_V01", paramObj);
            if (result != null && result.ToString().Equals(ResultCode.Success))
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// CreateBy: dtr
        /// Description: Xóa menu
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool DeleteSysUsrMenu(SysMenuUserModel model)
        {
            var paramObj = new object[]
            {
                model.id
            };
            var result = base.ExeScalar("sp_SysUsrMenu_Delete_V01", paramObj);
            if (result != null)
            {
                return true;
            }
            return false;
        }
    }
}
