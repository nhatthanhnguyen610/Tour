$(window).on("load", function () {
    ticket.init();
});
var ticket = {
    init: function () {
        $('body').on('click', '#btnSubmit', ticket.InsertFunc);
        $('body').on('click', '#btnUpdate', ticket.UpdateFunc);
        $('body').on('click', '.btnDelete', ticket.DeleteFunc);
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
                        ticket.ReloadData();
                        toastr.success(msg.Message);
                    }
                    else {
                        toastr.error(msg.Message);
                    }
                }
            });
        }
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
                        ticket.ReloadData();
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
        var _ticketID = $(this).attr('data-id');
        bootbox.confirm(_self.attr("data-message-confirm"), function (result) {
            if (result) {
                $.ajax({
                    url: '/Ticket/Delete',
                    data: { ticketID: _ticketID },
                    type: 'POST',
                    success: function (msg) {
                        msg.IsSuccess ? toastr.success(msg.Message) : toastr.error(msg.Message)
                        ticket.ReloadData();
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