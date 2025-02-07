$(document).on('click', '.hidenId', function () {
    var dataId = $(this).attr('data-id');
    $('.BtnSubmit').attr('data-id', dataId);
});
$(document.body).on("click", ".BtnSubmit", function (e) {
    e.preventDefault();

    var count = 1;
    var id = $('.BtnSubmit').attr('data-id');
    var name = $(".textFname").val().trim();
    var email = $(".txtemailAdress").val().trim();
    var contact = $(".txtContact").val().trim();

    $(".spnfname").empty();
    $(".spnemail").empty();
    $(".spncontact").empty();
    if (name == "" || name == null) {
        $(".spnfname").html("field can't be empty");
        count = 0;
    }
    else if (/^[\w'\-,.][^0-9_!¡?÷?¿/\\+=@#$%ˆ&*(){}|~<>;:[\]]{2,}$/.test(name) === false) {
        $(".spnfname").html("Enter valid name");
        count = 0;
    }
    if (contact == "" || contact == null) {
        $(".spncontact").html("field can't be empty");
        count = 0;
    }
    else if (/^[0-9]\d{9}$/.test(contact) === false) {
        $(".spncontact").html("Invalid Contact number");
        count = 0;
    }
    if (email == "" || email == null) {
        $(".spnemail").html("field can't be empty");
        count = 0;
    }
    else if (/^\S+@\S+\.\S+$/.test(email) === false) {
        $(".spnemail").html("Invalid email address");
        count = 0;
    }
    if (count === 1) {
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


    //else {
    //    $('.error-message').removeClass("d-none");
    //    $('.error-message').append('Please fill all the fields.');
    //}
});

//Enquiry Form
$(".btnsubmit").on('click', function (e) {
    e.preventDefault();
    var count = 1;
    var Name = $("#txtname").val();
    var Phone = $("#txtcontact").val();
    var emailid = $("#txtemail").val();
    var message = $("#txtmessage").val();
    $(".spnname").empty();
    $(".spnemail").empty();
    $(".spncontact").empty();
    $(".spnmessage").empty();
    
    if (Name == "" || Name == null) {
        $(".spnname").html("field can't be empty");
        count = 0;
    }
    else if (/^[\w'\-,.][^0-9_!¡?÷?¿/\\+=@#$%ˆ&*(){}|~<>;:[\]]{2,}$/.test(Name) === false) {
        $(".spnname").html("Enter valid name");
        count = 0;
    }
    if (Phone == "" || Phone == null) {
        $(".spncontact").html("field can't be empty");
        count = 0;
    }
    else if (/^[0-9]\d{9}$/.test(Phone) === false) {
        $(".spncontact").html("Invalid mobile number");
        count = 0;
    }
    if (emailid == "" || emailid == null) {
        $(".spnemail").html("field can't be empty");
        count = 0;
    }
    else if (/^\S+@\S+\.\S+$/.test(emailid) === false) {
        $(".spnemail").html("Invalid email address");
        count = 0;
    }
    if (message == "" || message == null) {
        $(".spnmessage").html("field can't be empty");
        count = 0;
    }
    
   
    if (count == 1) {
        $.ajax({
            type: 'POST',
            url: "/product-details.aspx/GetEnquiry",
            data: "{Name:'" + Name + "',Phone:'" + Phone + "',emailid:'" + emailid + "',message:'" + message + "'}",
            contentType: 'application/json; charset=utf-8',
            dataType: "json",
            success: function (data2) {
                if (data2.d == "Success") {
                    window.location.href = "/thankyou.aspx";
                }
                else {
                    $(".lblstatus").removeClass("d-none");
                    $(".lblstatus").html("there is some problem right now please try again later");
                }
            }
        });
    }
});
