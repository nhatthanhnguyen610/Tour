using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tour.Base;
using Tour.Provider;

namespace Tour.Service
{
    public class SysMenuService : ISysMenuService
    {
        ISysMenuProvider _sysMenuProvider;
        public SysMenuService(string appId, string userId = "0")
        {
            _sysMenuProvider = new SysMenuProvider(appId, userId);
        }
        /// <summary>
        /// CreateBy: dtr
        /// Description: Lấy thông tin menu
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public SysMenuUserModel GetInfoSysUsrMenu(decimal menuID)
        {
            return _sysMenuProvider.GetInfoSysUsrMenu(menuID);
        }
        /// <summary>
        /// CreateBy: dtr
        /// Description: Lấy danh sách quyền menu của người dùng
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<SysMenuUserModel> GetListMenuSysUsr(SysUsrUserFilterModel model)
        {
            return _sysMenuProvider.GetListMenuSysUsr(model);
        }
        /// <summary>
        /// CreateBy: dtr
        /// Description: Thêm Menu mới
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool InsertSysMenu(SysMenuUserModel model)
        {
            return _sysMenuProvider.InsertSysMenu(model);
        }
        /// <summary>
        /// CreateBy: dtr
        /// Description: kiểm tra MenuTitle trùng
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool IsMenuTitlelUsed(SysMenuUserModel model)
        {
            return _sysMenuProvider.IsMenuTitlelUsed(model);
        }
        /// <summary>
        /// CreateBy: dtr
        /// Description: Cập nhật menu
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool UpdateSysUsrMenu(SysMenuUserModel model)
        {
            return _sysMenuProvider.UpdateSysUsrMenu(model);
        }
    }
}
