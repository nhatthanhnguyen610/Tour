using Microsoft.AspNetCore.Authorization;
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
    public class SysMenuController : BaseController
    {
        ISysUsrUserService _sysUsrUserService;
        public SysMenuController()
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

        /// <summary>
        ///  Author: dtr
        ///  Description: Tạo menu hệ thống
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public IActionResult _Create()
        {
            return View(new SysMenuUserViewModel());
        }

        /// <summary>
        ///  Author: dtr
        ///  Description: Tạo menu hệ thống
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult _Create(SysMenuUserViewModel vm)
        {
            var model = vm.ConvertObject<SysMenuUserViewModel, SysMenuUserModel>();
            model.createdBy = Constants.UserCde;
            model.orderBy = 1;
            try
            {
                //if (_sysUsrUserService.IsMenuTitlelUsed(model))
                //{
                //    return Json(new
                //    {
                //        IsSuccess = false,
                //        Message = "Title đã có người dùng"
                //    });
                //}
                if (!string.IsNullOrWhiteSpace(model.menuCode) && !string.IsNullOrWhiteSpace(model.actionOrClass) && !string.IsNullOrWhiteSpace(model.controller))
                {
                    var submitResult = _sysUsrUserService.InsertSysMenu(model);
                    return Json(new
                    {
                        IsSuccess = submitResult,
                        Message = submitResult ? ResultStatus.SUCCESS : ResultStatus.FAIL
                    });
                }
                else
                {
                    return Json(new
                    {
                        IsSuccess = false,
                        Message = ResultStatus.FAIL
                    });
                }
            } 
            catch (Exception ex)
            {
                return Json(new
                {
                    IsSuccess = false,
                    Message = ResultStatus.ERROR
                });
            }

        }
        /// <summary>
        ///  Author: dtr
        ///  Description: cập nhật
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public IActionResult _Update(decimal menuID)
        {
            var vm = new SysMenuUserViewModel();
            try
            {
                var _lstMenu = _sysUsrUserService.GetInfoSysUsrMenu(menuID);
                vm = _lstMenu.ConvertObject<SysMenuUserModel, SysMenuUserViewModel>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return View(vm);
        }
        /// <summary>
        ///  Author: dtr
        ///  Description: cập nhật
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult _Update(SysMenuUserViewModel vm)
        {
            var model = vm.ConvertObject<SysMenuUserViewModel, SysMenuUserModel>();
            try
            {
                //if (_sysUsrUserService.IsMenuTitlelUsed(model))
                //{
                //    return Json(new
                //    {
                //        IsSuccess = false,
                //        Message = "Title đã có người dùng"
                //    });
                //}
                if (!string.IsNullOrWhiteSpace(model.menuCode) && !string.IsNullOrWhiteSpace(model.menuIcon) && !string.IsNullOrWhiteSpace(model.controller))
                {
                    var submitResult = _sysUsrUserService.UpdateSysUsrMenu(model);
                    return Json(new
                    {
                        IsSuccess = submitResult,
                        Message = submitResult ? ResultStatus.SUCCESS : ResultStatus.FAIL
                    });
                }
                else
                {
                    return Json(new
                    {
                        IsSuccess = false,
                        Message = ResultStatus.FAIL
                    });
                }
            }
            catch (Exception ex)
            {
                return Json(new
                {
                    IsSuccess = false,
                    Message = ResultStatus.ERROR
                });
            }
        }
    }   
}