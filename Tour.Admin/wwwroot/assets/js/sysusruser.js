$(window).on("load", function () {
    sysuser.init();
});
var sysuser = {
    init: function () {
        $('body').on('click', '.btnDelete', sysuser.DeleteFunc);
        $('body').on('click', '#btnConfigRole', sysuser.ConfigRole);
        $('body').on('click', '#btnSubmit', sysuser.InsertFunc); 
        $('body').on('change', '#file', sysuser.AvatarURL);
        $('body').on('click', '#btnUpdate', sysuser.UpdateFunc); 
    },
    UpdateFunc: function () {
        if ($('#frmUpdate').valid()) {
            var _self = $('#frmUpdate');
            var _selfForm = new FormData();
            if (document.getElementById("file").files != null) {
                var totalFiles = document.getElementById("file").files.length;
                for (var i = 0; i < totalFiles; i++) {
                    var file = document.getElementById("file").files[i];
                    _selfForm.append("file", file);
                }
            }
            _self.serializeArray().forEach(function (field) {
                _selfForm.append(field.name, field.value);
            })
            $.ajax({
                url: _self.attr('action'),
                data: _selfForm,
                type: 'POST',
                contentType: false,
                processData: false,
                //dataType: 'json',
                //contentType: 'application/x-www-form-urlencoded; charset=UTF-8',
                success: function (msg) {
                    if (msg.IsSuccess) {
                        $('#btnUpdate').data('clicked', true);
                        $(".disableBtnSave").trigger("custom");
                        $("#btnClose").trigger("click");
                        sysuser.ReloadData();
                        toastr.success(msg.Message);
                    }
                    else {
                        toastr.error(msg.Message);
                    }
                }
            });
        }
    },
    //Upload image
    AvatarURL: function () {
        if ($('#file').val().trim() === '') {
            return;
        }
        var _image = $('#file').val();
        $('#uploader').val(_image);
    },  
    InsertFunc: function () {
        if ($('#frmCreate').valid()) {
            var _self = $('#frmCreate');
            var _selfForm = new FormData();
            if (document.getElementById("file").files != null) {
                var totalFiles = document.getElementById("file").files.length;
                for (var i = 0; i < totalFiles; i++) {
                    var file = document.getElementById("file").files[i];
                    _selfForm.append("file", file);
                }
            }
            _self.serializeArray().forEach(function (field) {
                _selfForm.append(field.name, field.value);
            })
            $.ajax({
                url: _self.attr('action'),
                data: _selfForm,
                type: 'POST',
                contentType: false,
                processData: false,
                //dataType: 'json',
                //contentType: 'application/x-www-form-urlencoded; charset=UTF-8',
                success: function (msg) {
                    if (msg.IsSuccess) {
                        $('#btnSubmit').data('clicked', true);
                        $(".disableBtnSave").trigger("custom");
                        $("#btnClose").trigger("click");
                        sysuser.ReloadData();
                        toastr.success(msg.Message);
                    }
                    else {
                        toastr.error(msg.Message);
                    }
                }
            });
        }
    },
    DeleteFunc: function () {
        var _self = $(this);
        var _userID = $(this).attr('data-id');
        var _rowVersion = $(this).attr('row-version');
        bootbox.confirm(_self.attr("data-message-confirm"), function (result) {
            if (result) {
                $.ajax({
                    url: '/SysUsrUser/DeleteSysUsrUser',
                    data: { pUserID: _userID, pRowVersion:_rowVersion},
                    type: 'POST',
                    success: function (msg) {
                        msg.IsSuccess ? toastr.success(msg.Message) : toastr.error(msg.Message)
                        sysuser.ReloadData();
                    }
                });
            }
        });

    },
    ConfigRole: function () {
        $.ajax({
            url: $('#frmRole').attr('action'),
            data: $('#frmRole').serialize(),
            type: 'POST',
            dataType: 'json',
            contentType: 'application/x-www-form-urlencoded; charset=UTF-8',
            success: function (msg) {
                if (msg.IsSuccess) {
                    $('#btnConfigRole').data('clicked', true);
                    $(".disableBtnSave").trigger("custom");
                    $("#btnClose").trigger("click");
                    sysuser.ReloadData();
                    toastr.success(msg.Message);
                }
                else {
                    toastr.error(msg.Message);
                }
            }
        });
    },
    ReloadData: function () {
        $("[name='p']").val($("#PagingIndex").val());
        $('#btnSearch').trigger('click');
    }
}
