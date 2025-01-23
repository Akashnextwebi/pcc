﻿$(document).on('click', '.hidenId', function () {
    var dataId = $(this).attr('data-id');
    $('.BtnSubmit').attr('data-id', dataId);
});
$(document.body).on("click", ".BtnSubmit", function (e) {
    e.preventDefault();

    if ($(".textFname").val() || $(".txtemailAdress").val() || $(".txtContact").val() !== "") {
        var id = $('.BtnSubmit').attr('data-id');
        var name = $(".textFname").val().trim();
        var email = $(".txtemailAdress").val().trim();
        var contact = $(".txtContact").val().trim();
        $.ajax({
            type: 'POST',
            url: "/product-details.aspx/SaveDownloadBroucherEnquiry",
            contentType: 'application/json; charset=utf-8',
            dataType: "json",
            data: JSON.stringify({
                name: name, email: email, contact: contact, Id: id
            }),
            success: function (data2) {
                var result = data2.d;
                if (result.split('|')[0] == "Success ") {
                    Snackbar.show({ pos: 'top-right', text: 'Thank you for Submitting.', actionTextColor: '#008a3d', backgroundColor: '#ff7f3e' });
                    $('.error-message').addClass("d-none");
                    $(".textFname").val("");
                    $(".txtemailAdress").val("");
                    $(".txtContact").val("");
                    $('.btn-close').trigger('click');
                    var pdf = result.split('|')[1].trim();


                    if (pdf) {
                        var a = document.createElement('a');
                        a.href = "/" + pdf;
                        a.download = '';
                        document.body.appendChild(a);
                        a.click();
                        document.body.removeChild(a);
                    }

                } else {
                    Snackbar.show({
                        pos: 'top-right', text: 'Oops...! There is some problem right now. Please try again later.', actionTextColor: '#fff', backgroundColor: '#ff7f3e'
                    });
                }
            }
        });
    }
    else {
        $('.error-message').removeClass("d-none");
        $('.error-message').text('Please fill all the fields.');
    }
});
