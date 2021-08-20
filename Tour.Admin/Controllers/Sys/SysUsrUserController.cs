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
            return View();
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

        [AllowAnonymous]
        [HttpPost]
        public ActionResult ChangePassword(ChangePassViewModel model)
        {
            try
            {
                if (model.passwordNew != model.passwordConfirm || model.passwordOld != Constants.Password)
                {
                    return View(new ChangePassViewModel()
                    {
                        errorMessage = "Mat khau khong dung"
                    }) ;
                }
                var infoMemer = _sysUsrUserService.ChangePassSys(
                    new RequestChangePassModel()
                    {
                        userCde = Constants.UserCde,
                        passWordOld = model.passwordOld,
                        passWordNew = model.passwordNew,
                        passWordConfirm = model.passwordConfirm
                    });
                if (infoMemer == true)
                {
                    Constants.Password = model.passwordNew;
                    return RedirectToAction("Index", "Home");
                }
                model.errorMessage = "Mat khau sai";
                return View(model);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
