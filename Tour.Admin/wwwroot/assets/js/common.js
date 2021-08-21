$(window).on("load", function () {
    common.init();
    common.initSaveButton();
});
var common = {
    init: function () {
        $('body').on('click', '.btn-show-popup', common.ShowPopupDialog);
        $('body').on('submit', '.form-load-ajax', common.FormLoadAjax);
        $('body').on('click', '.paging_button a', common.LoadPaging);
        $("body").on('click', '.show-datepicker', common.ShowDatePicker);
        $('body').on('click', '.btn-popup-cancel', function () {
            $($(this).parents('.modal').find('.close')).trigger('click');
        });
        $('body').on('click', '.btnchangepassword', common.ChangePassWord);
    },
    ChangePassWord: function () {
        var _oldPassword = $("#OldPassword").val();
        var _password = $("#Password").val();
        var _confimPassword = $("#ConfimPassword").val();
        if (_password == _confimPassword && _oldPassword != null && _password!=null) {
            $.ajax({
                url: '/SysUsrUser/ChangePassword',
                data: {
                    OldPassword: _oldPassword,
                    Password: _password,
                    ConfimPassword: _confimPassword
                },
                type: 'POST',
                success: function (msg) {
                    $("#btnClose").trigger("click");
                    msg.IsSuccess ? toastr.success(msg.Message) : toastr.error(msg.Message)
                }
            });
        }
        else {
            toastr.error("Mật khẩu không giống nhau");
        }
    },
    InitValid: function (e, element) {
        $.validator.unobtrusive.parse($(element));
        $(element).validate();
    },
    ValidForm: function () {
        if (!$(this).valid()) {
            return false;
        }
    },
    LoadPaging: function (e) {
        var idHtml = $(this).attr('data-viewid');
        if (idHtml != undefined && idHtml != '') {
            e.preventDefault();
            var href = $(this).attr('href');
            $.get(href, function (data) {
                $('#' + idHtml).html(data);
            });
        }
    },
    FormLoadAjax: function (e) {
        var _seft = $(this);
        var idHtml = $(this).attr('data-load-view');
        var fnx = $(this).attr('data-function');
        if (idHtml != undefined && idHtml != '') {
            e.preventDefault();
            var href = $('.form-load-ajax').attr('action');
            $.ajax({
                url: href,
                data: _seft.serialize(),
                success: function (data) {
                    $('#' + idHtml).html(data);
                    setTimeout(function () {
                        eval(fnx);
                    }, 500);
                }
            });
            return false;
        }
    },
    ShowPopupDialog: function (e) {
        e.stopPropagation();
        var isDisable = $(this).attr('disabled');
        if (isDisable != undefined)
            return;
        var popupModal = $(this).attr("data-href");
        if (popupModal == undefined) {
            popupModal = '.popup-modal';
        }

        if (popupModal.includes('.') == false) {
            popupModal = '.' + popupModal;
        }
        var iframe = $(popupModal).find('.modal-content');
        var modalIcon = $(this).attr("data-modal");
        var iframeHref = $(this).attr("data-url");
        var iframeTitle = $(this).attr("data-title");
        var iframeWidth = $(this).attr("data-width");
        var iframeHeight = $(this).data("height");
        var iframeSize = $(this).data("size");
        var functionrun = $(this).attr("data-function-run-close");

        $(popupModal + ' .modal-body').children().remove();
        $(popupModal + ' #panel').attr("src", iframeHref);
        $('#panel').attr("data-function-run-close", functionrun);
        $('#panel').children().remove();
        if (iframeHref !== undefined) {
            $.get(iframeHref, function (html) {
                $(popupModal + ' .modal-body').html(html);
                //$.validator.unobtrusive.parse($(iframe.find('form')));
                //$(iframe.find('form')).validate();
            });
        }

        var fnx = $(this).attr("data-function");

        if (fnx != undefined) {
            setTimeout(function () {
                eval(fnx);
            }, 500);
        }

        if (iframeTitle !== undefined) {
            var htmlStr =
                "<button type='button' class='close' data-dismiss='modal'>×</button>"
                + "<h4 class='modal-title panel-title' style='font-size: 18px'></h4>";
            $(popupModal).find('.modal-header').html(htmlStr);

            var _iconShow = modalIcon !== undefined ? '<i class="' + modalIcon + '"></i>' : '';
            $(popupModal).find('.modal-title').html(_iconShow + iframeTitle);
        }

        if (iframeWidth !== undefined) {
            if (iframeWidth != 0) {
                $(popupModal).find('.modal-dialog').css("width", iframeWidth);
                $(popupModal).find('.modal-dialog').css("max-width", '100%');
            }
            else {
                $(popupModal).find('.modal-content').css("width", '100%');
                $(popupModal).find('.modal-dialog').css("width", '95%');
                $(popupModal).find('.modal-dialog').css("max-width", '100%');
            }
        }

        if (iframeHeight !== undefined) {
            $(iframe).attr("height", iframeHeight);
        }

        if (iframeSize !== undefined) {
            $(popupModal).addClass('modal-lg');
        }
        else {
            $(popupModal).removeClass('modal-lg');
        }


        $(popupModal)
            .on('hide', function () {
                console.log('hide');
                var runfuntion = $(this.items[0].inlineElement[0]).find('#panel').attr('data-function-run-close');
                $(this.items[0].inlineElement[0]).find('#panel').removeAttr('data-function-run-close');

                $(this.items[0].inlineElement[0]).find('iframe').attr('src', 'about: blank');
                $(popupSrc).find('iframe').attr('style', '');
                if (runfuntion != undefined) {
                    setTimeout(function () { eval(runfuntion) }, 500);
                    this.items[0] = null;
                }
            })
            .on('hidden', function () {
                console.log('hidden');
            })
            .on('show', function () {
                console.log('show');
            })
            .on('shown', function () {
                console.log('shown')
            });
        $(popupModal).modal({
            backdrop: false
        });
        $(popupModal).on('hidden.bs.modal', function () {
            if (functionrun != undefined) {
                setTimeout(function () { eval(functionrun) }, 500);
            }
        })
    },    
    initSaveButton: function () {
        $('body').on('custom', '.disableBtnSave', function () {
            $(".disableBtnSave").css("pointer-events", "none");
            $(".disableBtnSave").css("opacity", ".5");
        });
    },
    isNumberKey: function (evt, isBirthDay) {
        var charCode = (evt.which) ? evt.which : event.keyCode;
        if (isBirthDay) {
            if (charCode == 59 || charCode == 46 || charCode == 47)
                return true;
            if (charCode > 31 && (charCode < 48 || charCode > 57))
                return false;
        } else {
            if (charCode == 59 || charCode == 46)
                return true;
            if (charCode > 31 && (charCode < 48 || charCode > 57))
                return false;
        }
        return true;
    },
     ShowDatePicker: function () {
         if (!$(this).is(':disabled')) {
             $(this).datepicker({
                 changeYear: true,
                 changeMonth: true,
                 maxDate: 'now'
             });
             $(this).datepicker('show');
             $(".ui-datepicker-month").css("width", "auto");
             $(".ui-datepicker-year").css("width", "auto");
         } 
    },
}

