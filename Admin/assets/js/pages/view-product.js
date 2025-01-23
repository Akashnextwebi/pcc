$(document).ready(function () {
    
    BindCapability();
    BindIndustry();
    Bindproducts();
    $(document.body).on('change', ".pageLenght", function () {
        $(".mppagination").empty();
        $('.loaderclass').removeClass("d-none");
        $('.mytablewrap').addClass("d-none");
        Bindproducts();
    });
    $(document.body).on('click', "#btnSearch", function () {
        Bindproducts();
    });
    $(document.body).on("keyup", ".txtsearch", function (e) {
        $(".mppagination").empty();
        $('.loaderclass').removeClass("d-none");
        $('.mytablewrap').addClass("d-none");
        Bindproducts();
    })

    $(document.body).on("click", ".deleteItem", function () {
        var id = $(this).attr('data-id');
        $.ajax({
            type: 'POST',
            url: "view-product.aspx/Delete",
            data: "{id: '" + id + "'}",
            contentType: 'application/json; charset=utf-8',
            dataType: "json",
            async: false,
            success: function (data2) {
                if (data2.d.toString() == "Success") {
                    Snackbar.show({ pos: 'top-right', text: 'Product Deleted successfully.', actionTextColor: '#fff', backgroundColor: '#008a3d' });
                    setTimeout(function () { window.location.href = "view-product.aspx"; }, 1000);

                }
                else {
                    Snackbar.show({ pos: 'top-right', text: 'Oops!!! There is some error right now, please try again after some time.', actionTextColor: '#fff', backgroundColor: '#ea1c1c' });
                }
            },
            error: function (err) {
                Snackbar.show({ pos: 'top-right', text: 'Oops!!! There is some error right now, please try again after some time.', actionTextColor: '#fff', backgroundColor: '#ea1c1c' });
            }
        });
    });

    //Current Page
    $(document.body).on('click', ".pVClick", function () {
        var ele = $(this);
        $(".mppagination a").removeClass("active");
        ele.addClass("active");

        //$('.loaderclass').removeClass("d-none")
        //$('.mytablewrap').addClass("d-none")
        Bindproducts();

    });

    //Previous Page
    $(document.body).on('click', ".prVClick", function () {
        var ele = $(this);
        $(".mppagination a").removeClass("active");
        ele.addClass("active");

        //$('.loaderclass').removeClass("d-none")
        //$('.mytablewrap').addClass("d-none")
        Bindproducts();
    });

    //Next Page
    $(document.body).on('click', ".nxVClick", function () {
        var ele = $(this);
        $(".mppagination a").removeClass("active");
        ele.addClass("active");

        //$('.loaderclass').removeClass("d-none")
        //$('.mytablewrap').addClass("d-none")
        Bindproducts();

    });

});
//Bind Products
function Bindproducts() {
    var PLenght = $(".pageLenght option:selected").val();
    var PageNo = "1";
    if ($(".mppagination li a").hasClass("active")) {
        PageNo = $(".mppagination li .active").attr('id').split('_')[1];
    }
    var PLenght = $(".pageLenght option:selected").val();
    //var PageNo = "1";
    var Key = $("#txtSearch").val();
    var Capability = $("#ddlCapabilityType option:selected").val();
    var Industry = $("#ddlindustry option:selected").val();
    if ($(".mppagination li a").hasClass("active")) {
        PageNo = $(".mppagination li .active").attr('id').split('_')[1];
    }
    
    $.ajax({
        type: 'POST',
        url: "view-product.aspx/Getproducts",
        data: "{PageNo:'" + PageNo + "',PageLenght:'" + PLenght + "',Key:'" + Key + "',Capability:'" + Capability + "',Industry:'" + Industry + "'}",
        contentType: 'application/json; charset=utf-8',
        dataType: "json",
        async: false,
        success: function (data2) {

            if (data2.d == "Error") {
                $(".strTable").html("<tr><td colspan='12' class='text-center'>no data available in the table</td></tr>");
              
            }
            if (data2.d == "Empty") {
                $(".strTable").html("<tr><td colspan='12' class='text-center'>no data available in the table</td></tr>");
               
            }
            else {
                data = $.parseJSON(data2.d);
                $(".strTable").html(data.table);

               
                BindLPage(PageNo, PLenght, data.count);
            }
        }
    });

}
//New Pagination
function BindLPage(cPage, pageS, pCount) {
    var noOfPagesCreated = ~~(parseFloat(pCount) / parseInt(pageS));
    var isExtra = (parseFloat(pCount) % parseInt(pageS)) === 0 ? 0 : 1;

    noOfPagesCreated = noOfPagesCreated + isExtra;

    $(".mppagination").empty();

    var pagesss = "";

    var np = parseInt(cPage) % 5 === 0 ? (parseInt(cPage) / parseInt(5) - 1) : parseInt(cPage) / parseInt(5);
    var nearestNextP = (~~np + 1) * 5;
    var pLength = noOfPagesCreated < parseInt(nearestNextP) ? noOfPagesCreated : parseInt(nearestNextP);
    var startPage = (parseInt(nearestNextP) - 4);

    if (parseInt(cPage) > 5) {
        pagesss += "<li class='page-item'><a class='page-link pVClick' href='javascript:void(0);' id='pno_1'>1</a></li>";
        pagesss += "<li class='page-item'><a class='page-link pVClick' href='javascript:void(0);' id='pno_1'>...</a></li>";
    }

    for (var i = startPage; i <= pLength; i++) {
        var act = i === parseInt(cPage) ? "active" : "";
        pagesss += "<li class='page-item'><a class='page-link pVClick " + act + "' href='javascript:void(0);' id='pno_" + (i) + "'>" + (i) + "</a></li>";
    }
    if (noOfPagesCreated > pLength) {
        pagesss += "<li class='page-item'><a class='page-link pVClick' href='javascript:void(0);' id='pno_" + (pLength + 1) + "'>...</a></li>";
        pagesss += "<li class='page-item'><a class='page-link pVClick' href='javascript:void(0);' id='pno_" + (noOfPagesCreated) + "'>" + (noOfPagesCreated) + "</a></li>";
    }



    var prvPg = startPage === 1 ? 1 : startPage - 1;
    var nxtPg = noOfPagesCreated > pLength ? (pLength + 1) : pLength;


    if (noOfPagesCreated <= 5) {
        prvPg = parseInt(cPage) === 1 ? 1 : parseInt(cPage) - 1;
        nxtPg = parseInt(cPage) === pLength ? pLength : parseInt(cPage) + 1;
    }

    var pgnPrev = "";
    if (parseInt(cPage) > 1) {
        pgnPrev = "<li class='page-item'><a id='pnon_" + prvPg + "' class='page-link prVClick' href='javascript:void(0);' aria-label='Previous'><i class='mdi mdi-chevron-left'></i> Previous</a></li>";
    }
    else {
        pgnPrev = "<li class='page-item'><a id='pnon_" + prvPg + "' class='page-link disabled' href='javascript:void(0);' aria-label='Previous'><i class='mdi mdi-chevron-left'></i> Previous</a></li>";
    }

    var pgnNext = "";

    if (nxtPg != parseInt(cPage)) {
        pgnNext = "<li class='page-item'><a class='page-link nxVClick' href='javascript:void(0);' id='pnon_" + nxtPg + "' aria-label='Next'>Next <i class='mdi mdi-chevron-right'></i></a></li>";
    }
    else {
        pgnNext = "<li class='page-item'><a class='page-link disabled' href='javascript:void(0);' id='pnon_" + nxtPg + "' aria-label='Next'>Next <i class='mdi mdi-chevron-right'></i></a></li>";
    }
    $(".mppagination").append(pgnPrev + pagesss + pgnNext);
}

function BindCapability() {
  
    $.ajax({
        type: 'POST',
        url: 'view-product.aspx/alllist',
        data: "{}",
        contentType: 'application/json; charset=utf-8',
        dataType: "json",
        async: false,
        success: function (res) { 
            var listings = "<option value=''>All</option>";
            var result = res.d;
            for (var i = 0; i < result.length; i++) {
                
                listings += "<option value='" + result[i].Id + "'>" + result[i].CapabilityName + "</option>";
            }
           
            $("#ddlCapabilityType").append(listings);
        },
        error: function (err) {
            $("#ddlCapabilityType").empty();
        }
    });
}

function BindIndustry() {

    $.ajax({
        type: 'POST',
        url: 'view-product.aspx/industrylist',
        data: "{}",
        contentType: 'application/json; charset=utf-8',
        dataType: "json",
        async: false,
        success: function (res) {
            var listings = "<option value=''>All</option>";
            var result = res.d;
            for (var i = 0; i < result.length; i++) {
                listings += "<option value='" + result[i].Id + "'>" + result[i].IndustryName + "</option>";
            }
            $("#ddlindustry").append(listings);
        },
        error: function (err) {
            $("#ddlindustry").empty();
        }
    });
   
}
