using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Tour.Admin.Models;
using Tour.Base;
using Tour.Common.Constants;
using Tour.Service;

namespace Tour.Admin.Controllers
{
    public class SysCustomerController : BaseController
    {
        ISysCustomerService _sysCustomerService;
        public SysCustomerController()
        {
            _sysCustomerService = new SysCustomerService(string.Empty);
        }
        public IActionResult Index()
        {
            var vm = new SysCustomerVM();
            try
            {
                var model = new SysUsrUserFilterModel();
                vm.p = vm.p == 0 ? 1 : vm.p;
                model.pageIndex = vm.p;
                model.pageSize = DefinedConstants.RowPerPage;
                var _listCustomer = _sysCustomerService.GetListSysCustomer(model);
                vm.ListCustomer = _listCustomer;
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
        public PartialViewResult _Index(SysCustomerVM vm)
        {
            try
            {
                ViewBag.Paging = vm.p;
                var viewModel = vm.ConvertObject<SysCustomerVM, SysUsrUserFilterModel>();
                viewModel.pageIndex = vm.p == 0 ? 1 : vm.p;
                viewModel.pageSize = DefinedConstants.RowPerPage;
                vm.ListCustomer = _sysCustomerService.GetListSysCustomer(viewModel);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return PartialView(vm);
        }
        /// <summary>
        ///  Author: dtr
        ///  Description: tạo mới customer
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult _Create()
        {
            var vm = new SysCustomerViewModel();
            vm.avatar = string.IsNullOrWhiteSpace(vm.avatar) ? DefinedConstants.NoImageLink : vm.avatar;
            return View(vm);
        }
        /// <summary>
        ///  Author: dtr
        ///  Description: tạo mới customer
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> _Create(SysCustomerViewModel vm)
        {
            var model = vm.ConvertObject<SysCustomerViewModel, SysCustomerModel>();
            try
            {
                string uploads = string.Format("{0}{1}", PathServer.pathDir, PathServer.pathCustomer);
                foreach (var formFile in Request.Form.Files)
                {
                    if (formFile.Length > 0)
                    {
                        var fileName = DateTime.Now.ToString(PathServer.yyyyMMddhhmmssfff);
                        var fileExtension = Path.GetExtension(formFile.FileName);
                        string fileAvatar = fileName + fileExtension;
                        string filePath = Path.Combine(uploads, fileAvatar);
                        if (!Directory.Exists(Path.GetDirectoryName(uploads)))
                        {
                            Directory.CreateDirectory(Path.GetDirectoryName(uploads));
                        }
                        using (Stream fileStream = new FileStream(filePath, FileMode.Create))
                        {
                            await formFile.CopyToAsync(fileStream);
                        }
                        model.avatar = string.Format("{0}{1}{2}", PathServer.pathCustomer, fileAvatar);
                    }
                }
                model.createdBy = Constants.UserCde;
                if (_sysCustomerService.IsEmailUsed(model))
                {
                    return Json(new
                    {
                        IsSuccess = false,
                        Message = ResultStatus.UserEmailUsed
                    });
                }
                if (!string.IsNullOrWhiteSpace(model.fullName) && !string.IsNullOrWhiteSpace(model.password) && !string.IsNullOrWhiteSpace(model.username))
                {
                    var submitResult = _sysCustomerService.InsertSysCustomer(model);
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
        ///  Description: cập nhật customer
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public IActionResult _Update(decimal customerID)
        {
            var vm = new SysCustomerViewModel();
            try
            {

                var _lstCustomer = _sysCustomerService.GetInfoSysCustomer(customerID);
                vm = _lstCustomer.ConvertObject<SysCustomerModel, SysCustomerViewModel>();

                vm.avatar = string.IsNullOrWhiteSpace(vm.avatar) ? DefinedConstants.NoImageLink : vm.avatar;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return View(vm);
        }
        [AllowAnonymous]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> _Update(SysCustomerViewModel vm)
        {
            var model = vm.ConvertObject<SysCustomerViewModel, SysCustomerModel>();
            try
            {
                string uploads = string.Format("{0}{1}", PathServer.pathDir, PathServer.pathCustomer);
                foreach (var formFile in Request.Form.Files)
                {
                    if (formFile.Length > 0)
                    {
                        var fileName = DateTime.Now.ToString(PathServer.yyyyMMddhhmmssfff);
                        var fileExtension = Path.GetExtension(formFile.FileName);
                        string fileAvatar = fileName + fileExtension;
                        string filePath = Path.Combine(uploads, fileAvatar);
                        if (!Directory.Exists(Path.GetDirectoryName(uploads)))
                        {
                            Directory.CreateDirectory(Path.GetDirectoryName(uploads));
                        }
                        using (Stream fileStream = new FileStream(filePath, FileMode.Create))
                        {
                            await formFile.CopyToAsync(fileStream);
                        }
                        model.avatar = string.Format("{0}{1}{2}", PathServer.pathCustomer, fileAvatar);
                    }
                }
                model.createdBy = Constants.UserCde;
                if (_sysCustomerService.IsEmailUsed(model))
                {
                    return Json(new
                    {
                        IsSuccess = false,
                        Message = ResultStatus.UserEmailUsed
                    });
                }
                if (!string.IsNullOrWhiteSpace(model.fullName) && !string.IsNullOrWhiteSpace(model.password) && !string.IsNullOrWhiteSpace(model.username))
                {
                    var submitResult = _sysCustomerService.UpdateSysCustomer(model);
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
        /// DeleteSysUsrUser
        /// </summary>
        /// <param name="pCustomerID"></param>
        /// <param name="pRowVersion"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult Delete(decimal pCustomerID)
        {
            SysCustomerModel model = new SysCustomerModel()
            {
                Id = pCustomerID,
            };
            var submitResult = _sysCustomerService.DeleteSysCustomer(model);
            return Json(new
            {
                IsSuccess = submitResult,
                Message = submitResult ? ResultStatus.SUCCESS : ResultStatus.FAIL
            });
        }
    }
}
