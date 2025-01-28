var pNo = 1;
var pSize = 6;
$(document).ready(function () {

    BindBlogs();
    $(document.body).on('click', ".pVClick", function () {
        var ele = $(this);
        $(".vPagination span").removeClass("current");
        ele.addClass("current");
        BindBlogs();
    });
    $(document.body).on('click', ".prVClick", function () {
        var ele = $(this);
        $(".vPagination span").removeClass("current");
        ele.addClass("current");
        BindBlogs();

    });
    $(document.body).on('click', ".nxVClick", function () {
        var ele = $(this);
        $(".vPagination span").removeClass("current");
        ele.addClass("current");
        BindBlogs();
    });
    
});
function BindBlogs() {

    //var pNo = "1";
    //if ($(".pPagination .page-number").hasClass("current")) {
    //    pNo = $(".pPagination .page-number.current").attr('id').split('_')[1];
    //}
    
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

                BindLPage(pSize, parseInt(pNo), TotalCount);

                $('.Bloglist').append(Bloglist);

            }
            else {
                Bloglist = "<div class='col-12 text-center'><h3>No Blogs To show</h3></div>";
                $('.Bloglist').append(Bloglist);

            }

        }

    });

}



function BindLPage(pageS, cPage, pCount) {
    var noOfPagesCreated = ~~(parseFloat(pCount) / parseInt(pageS));
    var isExtra = (parseFloat(pCount) % parseInt(pageS)) === 0 ? 0 : 1;

    noOfPagesCreated = noOfPagesCreated + isExtra;

    $(".vPagination").empty();

    var pagesss = "";

    var np = parseInt(cPage) % 5 === 0 ? (parseInt(cPage) / parseInt(5) - 1) : parseInt(cPage) / parseInt(5);
    var nearestNextP = (~~np + 1) * 5;
    var pLength = noOfPagesCreated < parseInt(nearestNextP) ? noOfPagesCreated : parseInt(nearestNextP);
    var startPage = (parseInt(nearestNextP) - 4);


    for (var i = startPage; i <= pLength; i++) {

        if (i === parseInt(cPage)) {
            pagesss += "<li><span class='page-numbers current' id='pno_" + (i) + "'>" + (i) + "</span></li>";
        }
        else {
            pagesss += "<li><a class='page-numbers pVClick' href='javascript:void();' id='pno_" + (i) + "'>" + (i) + "</a></li>";
        }

    }
    if (noOfPagesCreated > pLength) {
        pagesss += "<li><a class='page-numbers pVClick' href='javascript:void();' id='pno_" + (pLength + 1) + "'>...</a></li>";
        pagesss += "<li><a class='page-numbers pVClick' href='javascript:void();' id='pno_" + (noOfPagesCreated) + "'>" + (noOfPagesCreated) + "</a></li>";
    }

    var prvPg = startPage === 1 ? 1 : startPage - 1;
    var nxtPg = noOfPagesCreated > pLength ? (pLength + 1) : pLength;

    var pgnPrev = "<li><a id='pnon_" + prvPg + "' class='prev page-numbers prVClick' href='javascript:void();' aria-label='Previous'></a></li>";
    var pgnNext = "<li><a class='next page-numbers nxVClick' href='javascript:void();' id='pnon_" + nxtPg + "' aria-label='Next'></a></li>";

    $(".vPagination").append(pgnPrev + pagesss + pgnNext);

}