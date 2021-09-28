using Microsoft.AspNetCore.Authorization;
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
    public class TypeTicketController : BaseController
    {
        ITypeTicketService _TypeTicketService;
        public TypeTicketController()
        {
            _TypeTicketService = new TypeTicketService(string.Empty);
        }
        public IActionResult Index()
        {
            var vm = new TypeTicketVM();
            try
            {
                var model = new SysUsrUserFilterModel();
                vm.p = vm.p == 0 ? 1 : vm.p;
                model.pageIndex = vm.p;
                model.pageSize = DefinedConstants.RowPerPage;
                var _listTypeTicket = _TypeTicketService.GetList(model);
                vm.ListTTicket = _listTypeTicket;
                var _listFlight = _TypeTicketService.GetListFlight();
                vm.ListFlight = _listFlight;
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
        public PartialViewResult _Index(TypeTicketVM vm)
        {
            try
            {
                ViewBag.Paging = vm.p;
                var viewModel = vm.ConvertObject<TypeTicketVM, SysUsrUserFilterModel>();
                viewModel.pageIndex = vm.p == 0 ? 1 : vm.p;
                viewModel.pageSize = DefinedConstants.RowPerPage;
                vm.ListTTicket = _TypeTicketService.GetList(viewModel);
                vm.ListFlight = _TypeTicketService.GetListFlight();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return PartialView(vm);
        }

        /// <summary>
        ///  Author: dtr
        ///  Description: Tạo loại vé mới
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public IActionResult _Create()
        {
            ViewBag.listFlight = _TypeTicketService.GetListFlight();
            return View(new TypeTicketViewModel());
        }

        /// <summary>
        ///  Author: dtr
        ///  Description:  Tạo loại vé mới
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult _Create(TypeTicketViewModel vm)
        {
            var model = vm.ConvertObject<TypeTicketViewModel, TypeTicketModel>();
            model.createdBy = Constants.UserCde;
            try
            {
                if (!string.IsNullOrWhiteSpace(model.type) && !string.IsNullOrWhiteSpace(model.price.ToString()))
                {
                    var submitResult = _TypeTicketService.InsertTypeTicket(model);
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
        public IActionResult _Update(decimal tTicketID)
        {
            var vm = new TypeTicketViewModel();
            try
            {
                var _lstTTicket = _TypeTicketService.GetInfo(tTicketID);
                vm = _lstTTicket.ConvertObject<TypeTicketModel, TypeTicketViewModel>();
                ViewBag.listFlight = _TypeTicketService.GetListFlight();
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
        public ActionResult _Update(TypeTicketViewModel vm)
        {
            var model = vm.ConvertObject<TypeTicketViewModel, TypeTicketModel>();
            model.createdBy = Constants.UserCde;
            try
            {
                if (!string.IsNullOrWhiteSpace(model.type) && !string.IsNullOrWhiteSpace(model.price.ToString()))
                {
                    var submitResult = _TypeTicketService.UpdateTypeTicket(model);
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
        /// DeleteTypeTicket
        /// </summary>
        /// <param name="pTTicketID"></param>
        /// <param name="pRowVersion"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult Delete(decimal pTTicketID)
        {
            TypeTicketModel model = new TypeTicketModel()
            {
                Id = pTTicketID,
            };
            var submitResult = _TypeTicketService.DeleteTypeTicket(model);
            return Json(new
            {
                IsSuccess = submitResult,
                Message = submitResult ? ResultStatus.SUCCESS : ResultStatus.FAIL
            });
        }
    }
}
