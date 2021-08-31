using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tour.Admin.Models;
using Tour.Base;
using Tour.Service;
using Tour.Common.Constants;

namespace Tour.Admin.Controllers.Menu
{
    public class MenuController : BaseController
    {
        ISysUsrUserService _sysUsrUserService;
        public MenuController()
        {
            _sysUsrUserService = new SysUsrUserService(string.Empty);
        }
        public IActionResult Index()
        {
            var vm = new SysMenuUserVM();
            try
            {
                var model = new SysUsrUserFilterModel();
                vm.p = vm.p == 0 ? 1 : vm.p;
                model.pageIndex = vm.p;
                model.pageSize = DefinedConstants.RowPerPage;
                var _listUser = _sysUsrUserService.GetListMenuSysUsr(model);
                vm.ListMenuUser = _listUser;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return View(vm);
        }

        /// <summary>
        /// _Index
        /// </summary>
        /// <param name="vm"></param>
        /// <returns></returns>
        public PartialViewResult _Index(SysMenuUserVM vm)
        {
            try
            {
                ViewBag.Paging = vm.p;
                var viewModel = vm.ConvertObject<SysMenuUserVM, SysUsrUserFilterModel>();
                viewModel.pageIndex = vm.p == 0 ? 1 : vm.p;
                viewModel.pageSize = DefinedConstants.RowPerPage;
                vm.ListMenuUser = _sysUsrUserService.GetListMenuSysUsr(viewModel);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return PartialView(vm);
        }
    }
}
