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
    public class CommentController : BaseController
    {
        ICommentService _CommentService;
        public CommentController() {
            _CommentService = new CommentService(string.Empty);
        }
        public IActionResult Index()
        {
            var vm = new CommentVM();
            try
            {
                var model = new SysUsrUserFilterModel();
                vm.p = vm.p == 0 ? 1 : vm.p;
                model.pageIndex = vm.p;
                model.pageSize = DefinedConstants.RowPerPage;
                var _listComment = _CommentService.GetList(model);
                vm.ListComment = _listComment;
                var _listNews = _CommentService.GetListNews();
                vm.ListNews = _listNews;
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
        public PartialViewResult _Index(CommentVM vm)
        {
            try
            {
                ViewBag.Paging = vm.p;
                var viewModel = vm.ConvertObject<CommentVM, SysUsrUserFilterModel>();
                viewModel.pageIndex = vm.p == 0 ? 1 : vm.p;
                viewModel.pageSize = DefinedConstants.RowPerPage;
                vm.ListComment = _CommentService.GetList(viewModel);
                vm.ListNews = _CommentService.GetListNews();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return PartialView(vm);
        }

        /// <summary>
        ///  Author: dtr
        ///  Description: Tạo bài viết mới
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public IActionResult _Create()
        {
            ViewBag.listNews = _CommentService.GetListNews();
            return View(new CommentViewModel());
        }

        /// <summary>
        ///  Author: dtr
        ///  Description:  Tạo bài viết mới
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult _Create(CommentViewModel vm)
        {
            var model = vm.ConvertObject<CommentViewModel, CommentModel>();
            model.createdBy = Constants.UserCde;
            try
            {
                if (!string.IsNullOrWhiteSpace(model.content) && model.rate <= 5)
                {
                    var submitResult = _CommentService.InsertComment(model);
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
        public IActionResult _Update(decimal commentID)
        {
            var vm = new CommentViewModel();
            try
            {
                var _lstComment = _CommentService.GetInfo(commentID);
                vm = _lstComment.ConvertObject<CommentModel, CommentViewModel>();
                ViewBag.listNews = _CommentService.GetListNews();
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
        public ActionResult _Update(CommentViewModel vm)
        {
            var model = vm.ConvertObject<CommentViewModel, CommentModel>();
            model.createdBy = Constants.UserCde;
            try
            {
                if (!string.IsNullOrWhiteSpace(model.content))
                {
                    var submitResult = _CommentService.UpdateComment(model);
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
        /// <param name="pmenuID"></param>
        /// <param name="pRowVersion"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult Delete(decimal commentID)
        {
            CommentModel model = new CommentModel()
            {
                id = commentID,
            };
            var submitResult = _CommentService.DeleteComment(model);
            return Json(new
            {
                IsSuccess = submitResult,
                Message = submitResult ? ResultStatus.SUCCESS : ResultStatus.FAIL
            });
        }
    }
}
