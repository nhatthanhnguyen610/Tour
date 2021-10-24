$(window).on("load", function () {
    flight.init();
});
var flight = {
    init: function () {
        $('body').on('click', '.btnDelete', flight.DeleteFunc);
        $('body').on('click', '#btnSubmit', flight.InsertFunc);
        $('body').on('click', '#btnUpdate', flight.UpdateFunc);
    },
    UpdateFunc: function () {
        if ($('#frmUpdate').valid()) {
            var _self = $('#frmUpdate');
            var _selfForm = new FormData();

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
                        flight.ReloadData();
                        toastr.success(msg.Message);
                    }
                    else {
                        toastr.error(msg.Message);
                    }
                }
            });
        }
    },
    InsertFunc: function () {
        if ($('#frmCreate').valid()) {
            var _self = $('#frmCreate');
            var _selfForm = new FormData();

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
                        flight.ReloadData();
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
        var _flightID = $(this).attr('data-id');
        bootbox.confirm(_self.attr("data-message-confirm"), function (result) {
            if (result) {
                $.ajax({
                    url: '/Flight/Delete',
                    data: { pFlightID: _flightID },
                    type: 'POST',
                    success: function (msg) {
                        msg.IsSuccess ? toastr.success(msg.Message) : toastr.error(msg.Message)
                        flight.ReloadData();
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
