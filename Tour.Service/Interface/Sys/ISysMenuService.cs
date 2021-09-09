using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tour.Base;

namespace Tour.Service
{
    public interface ISysMenuService
    {
        /// <summary>
        /// CreateBy: dtr
        /// Description: Lấy danh sách quyền menu của người dùng
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        List<SysMenuUserModel> GetListMenuSysUsr(SysUsrUserFilterModel model);
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
