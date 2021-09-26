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
    public class TicketController : BaseController
    {
        ITicketService _TicketService;
        public TicketController()
        {
            _TicketService = new TicketService(string.Empty);
        }
        public IActionResult Index()
        {
            var vm = new TicketVM();
            try
            {
                var model = new SysUsrUserFilterModel();
                vm.p = vm.p == 0 ? 1 : vm.p;
                model.pageIndex = vm.p;
                model.pageSize = DefinedConstants.RowPerPage;
                var _listTicket = _TicketService.GetList(model);
                vm.ListTicket = _listTicket;
                var _listFlight = _TicketService.GetListFlight();
                vm.ListFlight = _listFlight;
                var _listCustomer = _TicketService.GetListCustomer();
                vm.ListCustomer = _listCustomer;
                var _listTTicket = _TicketService.GetListTypeTicket();
                vm.ListTTicket = _listTTicket;
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
        public PartialViewResult _Index(TicketVM vm)
        {
            try
            {
                ViewBag.Paging = vm.p;
                var viewModel = vm.ConvertObject<TicketVM, SysUsrUserFilterModel>();
                viewModel.pageIndex = vm.p == 0 ? 1 : vm.p;
                viewModel.pageSize = DefinedConstants.RowPerPage;
                vm.ListTicket = _TicketService.GetList(viewModel);
                vm.ListFlight = _TicketService.GetListFlight();
                vm.ListCustomer = _TicketService.GetListCustomer();
                vm.ListTTicket = _TicketService.GetListTypeTicket();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return PartialView(vm);
        }

        /// <summary>
        ///  Author: dtr
        ///  Description: Đặt vé
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public IActionResult _Create()
        {
            ViewBag.listFlight = _TicketService.GetListFlight();
            ViewBag.listCustomer = _TicketService.GetListCustomer();
            ViewBag.listTTicket = _TicketService.GetListTypeTicket();
            return View(new TicketViewModel());
        }

        /// <summary>
        ///  Author: dtr
        ///  Description: Đặt vé
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult _Create(TicketViewModel vm)
        {
            var model = vm.ConvertObject<TicketViewModel, TicketModel>();
            model.createdBy = Constants.UserCde;
            try
            {
                if (!string.IsNullOrWhiteSpace(model.userId.ToString()) && !string.IsNullOrWhiteSpace(model.flightId.ToString()) 
                    && !string.IsNullOrWhiteSpace(model.TTicketId.ToString()))
                {
                    model.TTicketIdChange = model.TTicketId;
                    var submitResult = _TicketService.InsertTicket(model) && _TicketService.ReduceStock(model.TTicketId);
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
        ///  Description: Chỉnh sửa vé
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public IActionResult _Update(decimal ticketID)
        {
            var vm = new TicketViewModel();
            try
            {
                var _lstTicket = _TicketService.GetInfo(ticketID);
                vm = _lstTicket.ConvertObject<TicketModel, TicketViewModel>();
                ViewBag.listFlight = _TicketService.GetListFlight();
                ViewBag.listCustomer = _TicketService.GetListCustomer();
                ViewBag.listTTicket = _TicketService.GetListTypeTicket();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return View(vm);
        }
        /// <summary>
        ///  Author: dtr
        ///  Description: Chỉnh sửa vé
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult _Update(TicketViewModel vm)
        {
            var model = vm.ConvertObject<TicketViewModel, TicketModel>();
            model.createdBy = Constants.UserCde;
            try
            {
                if (!string.IsNullOrWhiteSpace(model.userId.ToString()) && !string.IsNullOrWhiteSpace(model.flightId.ToString())
                    && !string.IsNullOrWhiteSpace(model.TTicketId.ToString()))
                {
                    if (model.TTicketId != model.TTicketIdChange)
                    {
                        if (_TicketService.IncreaseStock(model.TTicketIdChange) && _TicketService.ReduceStock(model.TTicketId))
                        {
                            model.TTicketIdChange = model.TTicketId;
                        } 
                    }
                    model.TTicketIdChange = model.TTicketId;
                    var submitResult = _TicketService.UpdateTicket(model);
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
        /// DeleteSysNews
        /// </summary>
        /// <param name="ticketID"></param>
        /// <param name="pRowVersion"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult Delete(decimal ticketID)
        {
            TicketModel model = new TicketModel()
            {
                Id = ticketID,
            };
            var submitResult = _TicketService.DeleteTicket(model) && _TicketService.IncreaseStock(ticketID);
            return Json(new
            {
                IsSuccess = submitResult,
                Message = submitResult ? ResultStatus.SUCCESS : ResultStatus.FAIL
            });
        }
    }
}
