$(window).on("load", function () {
    syscustomer.init();
});
var syscustomer = {
    init: function () {
        $('body').on('click', '.btnDelete', syscustomer.DeleteFunc);
        $('body').on('click', '#btnSubmit', syscustomer.InsertFunc);
        $('body').on('change', '#file', syscustomer.AvatarURL);
        $('body').on('click', '#btnUpdate', syscustomer.UpdateFunc);
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
                        syscustomer.ReloadData();
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
                        syscustomer.ReloadData();
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
        var _customerID = $(this).attr('data-id');
        bootbox.confirm(_self.attr("data-message-confirm"), function (result) {
            if (result) {
                $.ajax({
                    url: '/SysCustomer/Delete',
                    data: { pCustomerID: _customerID },
                    type: 'POST',
                    success: function (msg) {
                        msg.IsSuccess ? toastr.success(msg.Message) : toastr.error(msg.Message)
                        syscustomer.ReloadData();
                    }
                });
            }
        });

    },
    ReloadData: function () {
        location.reload()
        $("[name='p']").val($("#PagingIndex").val());
        $('#btnSearch').trigger('click');
    }
}
