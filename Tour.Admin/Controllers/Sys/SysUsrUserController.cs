using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tour.Admin.Models;
using Tour.Base;
using Tour.Common.Constants;
using Tour.Service;

namespace Tour.Admin.Controllers
{
    public class SysUsrUserController : BaseController
    {
        ISysUsrUserService _sysUsrUserService;
        public SysUsrUserController()
        {
            _sysUsrUserService = new SysUsrUserService(string.Empty);
        }
        public IActionResult Index()
        {
            var vm = new SysUsrUserVM();
            try
            {
                var model = new SysUsrUserFilterModel();
                vm.p = vm.p == 0 ? 1 : vm.p;
                model.pageIndex = vm.p;
                model.pageSize = DefinedConstants.RowPerPage;
                var _listUser = _sysUsrUserService.GetListSysUsrUser(model);
                vm.ListUser = _listUser;
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
        public PartialViewResult _Index(SysUsrUserVM vm)
        {
            try
            {
                ViewBag.Paging = vm.p;
                var viewModel = vm.ConvertObject<SysUsrUserVM, SysUsrUserFilterModel>();
                viewModel.pageIndex = vm.p == 0 ? 1 : vm.p;
                viewModel.pageSize = DefinedConstants.RowPerPage;
                vm.ListUser = _sysUsrUserService.GetListSysUsrUser(viewModel);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return PartialView(vm);
        }
        /// <summary>
        ///  Author: thanhnn
        ///  Description: Đăng nhập
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        [AllowAnonymous]
        public ActionResult Login()
        {
            return View(new LoginViewModel());
        }
        /// <summary>
        ///  Author: thanhnn
        ///  Description: Đăng nhập
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginViewModel viewModel)
        {
            try
            {

                if (viewModel.userName == null && viewModel.password == null)
                {
                    return View(new LoginViewModel()
                    {
                        errorMessage = "Người dùng hoặc tên đăng nhập không được để trống"
                    }) ;
                }
                var infoMemer = _sysUsrUserService.LoginSys(
                    new LoginRequestModel()
                    {
                        passWord = viewModel.password,
                        email = viewModel.userName
                    });
                if (infoMemer != null && infoMemer.userID > 0)
                {
                    Constants.UserCde = infoMemer.userCode;
                    Constants.FullName = infoMemer.fullName;
                    Constants.Password = infoMemer.password;
                    Constants.Avatar = infoMemer.avatar == null ? Constants.No_Image : infoMemer.avatar;
                    string strData = infoMemer.ToJSON();
                    HttpContext.Session.SetString(DefinedConstants.SessionUser, strData);
                    return RedirectToAction("Index", "Home", new ChangePassViewModel());
                }
                viewModel.errorMessage = "Đăng nhập không thành công";
                return View(viewModel);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        ///  Author: thanhnn
        ///  Description: Phân quyền
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public PartialViewResult _Role(string userCde)
        {
            var vm = new SysUsrRoleViewModel();
            try
            {
                vm.ListSysUsrRole = _sysUsrUserService.GetSysUserRoleByUser(userCde);
                vm.userCde = userCde;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return PartialView(vm);
        }
        /// <summary>
        ///  Author: thanhnn
        ///  Description: Phân quyền
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult _Role(SysUsrRoleViewModel vm)
        {
            List<SysUserRoleModel> lstModel = new List<SysUserRoleModel>();
            foreach (var item in vm.ListSysUsrRole)
            {
                if (item.isSelected == true)
                {
                    lstModel.Add(new SysUserRoleModel()
                    {
                        createdBy = Constants.UserCde,
                        userCde = vm.userCde,
                        menuCde = item.menuCde,
                        isSelected = item.isSelected
                    });
                }
            }
            var submitResult = _sysUsrUserService.InsertSysUserRoleByUser(lstModel);
            return Json(new
            {
                IsSuccess = submitResult,
                Message = submitResult ? "Thành công" : "Không thành công"
            });
        }
        /// <summary>
        ///  Author: dtr
        ///  Description: doi mat khau
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpPost]
        public ActionResult ChangePasswordSysUser(string OldPassword, string Password, string ConfimPassword)
        {
            if (string.IsNullOrWhiteSpace(Password) || string.IsNullOrWhiteSpace(ConfimPassword))
            {
                return Json(new
                {
                    IsSuccess = false,
                    Message = "Mật khẩu không được để trống"
                });
            }
            if (Password != ConfimPassword)
            {
                return Json(new
                {
                    IsSuccess = false,
                    Message = "Xác nhận mật khẩu không trùng nhau"
                });
            }
            var viewModel = new RequestChangePassModel()
            {
                passWordNew = Password,
                userCde = Constants.UserCde,
                passWordOld = OldPassword
            };
            var result = _sysUsrUserService.ChangePassSysUser(viewModel);
            return Json(new
            {
                IsSuccess = result,
                Message = result ? "Đổi mật khẩu thành công" : (!result ? "Đổi mật khẩu không thành công" : "Nhập mật khẩu cũ không chính xác")
            });
        }
    }
}
