$(document).ready(function () {
    Populateproduct();
    var product = "";
    $("#Update").click(function (e) {
        var elem = $(this);
        elem.val("Please wait...");
        e.preventDefault();
        product = "";
        $.each($('#left-defaults').find('li'), function () {
            if (product == "") {
                product = product + $(this).attr("data-id");
            }
            else {
                product = product + "," + $(this).attr("data-id");
            }
        });
        Arrengeproduct(product);
    });
});
function Arrengeproduct(product) {
    var parameter = { "product": product };
    $.ajax({
        type: 'POST',
        url: "rearrange-products.aspx/ProductOrderUpdate",
        data: JSON.stringify(parameter),
        contentType: 'application/json; charset=utf-8',
        dataType: "json",
        success: function (data) {
            if (data.d == 0) {
                Swal.fire({
                    html:
                        '<div class="mt-3"><lord-icon src="https://cdn.lordicon.com/kfzfxczd.json" trigger="loop" colors="primary:#0ab39c,secondary:#405189" style="width:120px;height:120px"></lord-icon><div class="mt-4 pt-2 fs-15"><h4 style="color:red">Order Updated!</h4><p class="text-muted mx-4 mb-0">Order Updated Successfully</p></div></div>',
                    showCancelButton: !0,
                    showConfirmButton: !1,
                    cancelButtonClass: "btn btn-primary w-xs mb-1 back",
                    cancelButtonText: "Back",
                    buttonsStyling: !1,
                    showCloseButton: !0,
                });
                Populateproduct();
            }
            else {
                Swal.fire({
                    html:
                        '<div class="mt-3"><lord-icon src="https://cdn.lordicon.com/tdrtiskw.json" trigger="loop" colors="primary:#f06548,secondary:#f7b84b" style="width:120px;height:120px"></lord-icon><div class="mt-4 pt-2 fs-15"><h4>Oops...! There is some problem now !</h4><p class="text-muted mx-4 mb-0">Please try again later</p></div></div>',
                    showCancelButton: !0,
                    showConfirmButton: !1,
                    cancelButtonClass: "btn btn-primary w-xs mb-1",
                    cancelButtonText: "Dismiss",
                    buttonsStyling: !1,
                    showCloseButton: !0,
                });
            }
            $("#Update").val("Update Order");
        },
        error: function (error) {
            Swal.fire({
                html:
                    '<div class="mt-3"><lord-icon src="https://cdn.lordicon.com/tdrtiskw.json" trigger="loop" colors="primary:#f06548,secondary:#f7b84b" style="width:120px;height:120px"></lord-icon><div class="mt-4 pt-2 fs-15"><h4>Oops...! There is some problem now !</h4><p class="text-muted mx-4 mb-0">Please try again later</p></div></div>',
                showCancelButton: !0,
                showConfirmButton: !1,
                cancelButtonClass: "btn btn-primary w-xs mb-1",
                cancelButtonText: "Dismiss",
                buttonsStyling: !1,
                showCloseButton: !0,
            });
            $("#Update").val("Update Order");
        }
    });
}
function Populateproduct() {
    $.ajax({
        type: 'POST',
        url: "rearrange-products.aspx/ProductOrder",
        data: "{}",
        contentType: 'application/json; charset=utf-8',
        dataType: "json",
        async: false,
        success: function (data) {
            if (data.d != null) {
                var str = "";
                for (var i = 0; i < data.d.length; i++) {
                    str = str + "<li data-id='" + data.d[i].Id + "' class='ui-state-default media  d-md-flex d-block text-sm-left text-center col-md-2'><div class='maindiv'><img src='/" + data.d[i].ThumbImage + "' alt='" + data.d[i].ProductName + "' class='img-responsive' style='max-width:100%;' /><div><span>" + data.d[i].ProductName + "</span></div></div></li>";
                }
                $("#left-defaults").html(str);
            }
        },
        error: function (error) {
            Swal.fire({
                html:
                    '<div class="mt-3"><lord-icon src="https://cdn.lordicon.com/tdrtiskw.json" trigger="loop" colors="primary:#f06548,secondary:#f7b84b" style="width:120px;height:120px"></lord-icon><div class="mt-4 pt-2 fs-15"><h4>Oops...! There is some problem now !</h4><p class="text-muted mx-4 mb-0">Please try again later</p></div></div>',
                showCancelButton: !0,
                showConfirmButton: !1,
                cancelButtonClass: "btn btn-primary w-xs mb-1",
                cancelButtonText: "Dismiss",
                buttonsStyling: !1,
                showCloseButton: !0,
            });
        }
    });
}