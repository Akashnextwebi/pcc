﻿var pNo = 1;
var pSize = 6;
$(document).ready(function () {


    BindBlogs();
    $(document.body).on('click', ".pPVClick", function () {
        var ele = $(this);
        $(".pPagination a").removeClass("current");
        ele.addClass("current");
        BindBlogs();

    });
    $(document.body).on('click', ".prPVClick", function () {
        var ele = $(this);
        var activeIndex = $(".pPagination li.current a").attr("id");
        var currentIndex = ele.attr("id");
        if (activeIndex == currentIndex) {
            $(".pPagination li a.dNonePrev").css("display", "none");
            return;
        }
        $(".pPagination a").removeClass("current");
        ele.addClass("current");
        BindBlogs();
    });
    $(document.body).on('click', ".nxPVClick", function () {
        $(".pPagination li.dNonePrev").css("display", "flex");
        var ele = $(this);

        var currentIndex = ele.attr("id");
        var activeIndex = $(".pPagination li.current a").attr("id");

        if (currentIndex == activeIndex) {
            $(".pPagination li a.dNoneNext").css("display", "none");
            return;
        }

        $(".pPagination a").removeClass("current");
        ele.addClass("current");
        BindBlogs();

    })
    
});
function BindBlogs() {

    var pNo = "1";
    if ($(".pPagination .page-number").hasClass("current")) {
        pNo = $(".pPagination .page-number.current").attr('id').split('_')[1];
    }

    
    $('.Bloglist').html("");
    
    $.ajax({
        type: 'POST',
        url: "/Blogs.aspx/GetAllBlogs", 
        data: "{PgNo : '" + pNo + "',PLenght : '" + pSize + "'}",
        contentType: 'application/json; charset=utf-8',

        dataType: "json",
        async: false,
        success: function (data2) {

            if (data2.d != null && data2.d != "") {
                result = data2.d;
                var Bloglist = "";
                var TotalCount = 0;
                for (var i = 0; i < result.length; i++) {
                    TotalCount = result[i].TotalCount == "" ? 0 : parseInt(result[i].TotalCount);

                    Bloglist += "<div class='col-12 col-md-4'>"; 
                    Bloglist += "<a class='blog-card' href='/blog/" + result[i].BlogURL + "'>";
                    Bloglist += "<div class='image'>";
                    Bloglist += "<div class='tag'>"+result[i].Tag+"</div>";
                    Bloglist += "<img src='" + result[i].BlogImage +"' alt=''>";
                    Bloglist += "</div>";
                    Bloglist += "<div class='content'>";
                    Bloglist += "<h3>" + result[i].BlogTitle +"</h3>";
                    Bloglist += "<div class='posted-date'>";
                    Bloglist += "<span>" + result[i].PostedOn +"</span>";
                    Bloglist += "<div class='read-more'>";
                    Bloglist += "Read More <i class='fal fa-long-arrow-right'></i>";
                    Bloglist += "</div>";
                    Bloglist += "</div>";
                    Bloglist += "</div>";
                    Bloglist += "</a>";
                    Bloglist += "</div>";
                }

                BindPPage(pSize, pNo, TotalCount);

                $('.Bloglist').append(Bloglist);

            }
            else {
                Bloglist = "<div class='col-12 text-center'><h3>No Blogs To show</h3></div>";
                $('.Bloglist').append(Bloglist);

            }

        }

    });

}



function BindPPage(pageS, cPage, pCount) {
    var noOfPagesCreated = ~~(parseFloat(pCount) / parseInt(pageS));
    var isExtra = (parseFloat(pCount) % parseInt(pageS)) === 0 ? 0 : 1;

    noOfPagesCreated = noOfPagesCreated + isExtra;

    $(".pPagination").empty();

    var pagesss = "";

    var np = parseInt(cPage) % 5 === 0 ? (parseInt(cPage) / parseInt(5) - 1) : parseInt(cPage) / parseInt(5);
    var nearestNextP = (~~np + 1) * 5;
    var pLength = noOfPagesCreated < parseInt(nearestNextP) ? noOfPagesCreated : parseInt(nearestNextP);
    var startPage = (parseInt(nearestNextP) - 4);


    for (var i = startPage; i <= pLength; i++) {
        var activ = i === parseInt(cPage) ? "active" : "";
        var LastIndex = i === pLength ? "LastIndex" : "";
        pagesss += "<li class='page-number'><a class='page-number pPVClick " + activ + " " + LastIndex + "' href='javascript:void(0);' id='pno_" + (i) + "'>" + (i) + "</a></li>";
    }
    if (noOfPagesCreated > pLength) {
        pagesss += "<li class='page-number'><a class='page-number pPVClick' href='javascript:void(0);' id='pno_" + (pLength + 1) + "'>...</a></li>";
        pagesss += "<li class='page-number'><a class='page-number pPVClick LastIndex' href='javascript:void(0);' id='pno_" + (noOfPagesCreated) + "'>" + (noOfPagesCreated) + "</a></li>";
    }

    var prvPg = startPage === 1 ? 1 : startPage - 1;
    var nxtPg = noOfPagesCreated > pLength ? (pLength + 1) : pLength;

    if (noOfPagesCreated <= 5) {
        prvPg = parseInt(cPage) === 1 ? 1 : parseInt(cPage) - 1;
        nxtPg = parseInt(cPage) === pLength ? pLength : parseInt(cPage) + 1;
    }

    var dNonePrev = parseInt(cPage) === 1 ? "dNonePrev" : "";
    var dNoneNext = parseInt(cPage) === nxtPg ? "dNoneNext" : "";

    var pgnPrev = "<li class='page-number " + dNonePrev + "'><a id='pnon_" + prvPg + "' class='page-number prPVClick' href='javascript:void(0);' aria-label='Previous'><i class='fa-solid fa-chevron-left prPVClick'></i></a></li>";

    var pgnNext = "<li class='page-number " + dNoneNext + "'><a class='page-number nxPVClick ' href='javascript:void(0);' id='pnon_" + nxtPg + "' aria-label='Next'><i class='fa-solid fa-chevron-right nxPVClick'></i></a></li>";

    $(".pPagination").append(pgnPrev + pagesss + pgnNext);


}