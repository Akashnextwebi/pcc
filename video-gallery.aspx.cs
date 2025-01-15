using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class video_gallery : System.Web.UI.Page
{
    SqlConnection conSQ = new SqlConnection(ConfigurationManager.ConnectionStrings["conSQ"].ConnectionString);
    public string strvideogallery = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        BindVideogallery();
    }
    private void BindVideogallery()
    {

        try
        {
            strvideogallery = "";
            var video = VideoDetails.GetAllVideogalleries(conSQ).ToList();
            if (video.Count > 0)
            {
                for (int i = 0; i < video.Count; i++)
                {


                    strvideogallery += @"<div class='col-lg-4 col-md-6 slick-slide slick-cloned' data-slick-index='5' id='' aria-hidden='true' tabindex='-1' style='width: 432px;'>
                            <div class='service-card'>
                                <div class='card-inner'>

                                    <div class='image'>
                                        <div class='icon'>
                                            <a href='/"+ video[i].VideoLink + @"' class='video-i popup-video' contenteditable='false' style='cursor: pointer;' tabindex='-1'>
                                                <span class='play-icon'>
                                                    <i class='fa-solid fa-play'></i>
                                                    <span class='playvideo_animation'></span>
                                                    <span class='playvideo_animation' style='animation-delay: 0.4s'></span>
                                                    <span class='playvideo_animation' style='animation-delay: 0.6s'></span>
                                                </span>
                                            </a>
                                        </div>
                                        <img src='/" + video[i].ThumbImage +@"' alt=''>
                                    </div>
                                   <div class='product-link'>
      <a href='/"+ video[i].VideoLink + @"' class='video-i popup-video custom-btn' contenteditable='false' style='cursor: pointer;' tabindex='-1'>Watch Now</a>
  </div>
                                </div>
                            </div>
                        </div>";

                }
            }
        }
        catch (Exception ex)
        {
            ExceptionCapture.CaptureException(HttpContext.Current.Request.Url.PathAndQuery, "BindVideogallery", ex.Message);
        }
    }
}