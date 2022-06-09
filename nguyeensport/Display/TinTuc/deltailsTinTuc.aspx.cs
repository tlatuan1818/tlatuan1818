using nguyeensport.dal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace nguyeensport
{
    public partial class deltailsTinTuc : System.Web.UI.Page
    {
        
        clsquanlydanhmuctintuc _quanlydanhmuctintuc = new clsquanlydanhmuctintuc();
        protected string del = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            del = Page.RouteData.Values["name"] as string;
            DataTable dt = new DataTable();
            dt = _quanlydanhmuctintuc.layNewsDeltailTheoLinkNewsDeltail(del);
            if (dt.Rows.Count > 0)
            {
                ltTitle.Text = dt.Rows[0]["titleNewsDeltail"].ToString();
                ltMetadescription.Text = "<meta name='description' content='" + dt.Rows[0]["metaDescriptionNewsDeltail"].ToString() + "' />";
                ltMetaKeyword.Text = "<meta name='keyword' content='" + dt.Rows[0]["metaKeyword"].ToString() + "' />";
              
                ltCategori.Text = "<a id='header-category' href='/tin-tuc/" + dt.Rows[0]["linkNews"].ToString() + "' target='_blank'>" + dt.Rows[0]["tenNews"].ToString() + "</a>";
                ltDanhMucTinTuc.Text = "<a href='/tin-tuc/" + dt.Rows[0]["linkNews"].ToString() + "' class='masonry-link' target='_blank'>" + dt.Rows[0]["tenNews"].ToString() + "</a>";
                if(dt.Rows[0]["images1"].ToString() != "")
                {
                    ltSlider1.Text = "<img class='swiper-slide' src='" + dt.Rows[0]["images1"].ToString() + "' alt='" + dt.Rows[0]["tenNewsDeltail"].ToString() + "'/>";
                }
                if(dt.Rows[0]["images2"].ToString() != "")
                {
                    ltSlider2.Text = "<img class='swiper-slide' src='" + dt.Rows[0]["images2"].ToString() + "' alt='" + dt.Rows[0]["tenNewsDeltail"].ToString() + "'/>";
                }
                if(dt.Rows[0]["images3"].ToString() != "")
                {
                    ltSlider3.Text = "<img class='swiper-slide' src='" + dt.Rows[0]["images3"].ToString() + "' alt='" + dt.Rows[0]["tenNewsDeltail"].ToString() + "'/>";
                }
                if(dt.Rows[0]["images4"].ToString() != "")
                {
                    ltSlider4.Text = "<img class='swiper-slide' src='" + dt.Rows[0]["images4"].ToString() + "' alt='" + dt.Rows[0]["tenNewsDeltail"].ToString() + "'/>";
                }
                if (dt.Rows[0]["images5"].ToString() != "") {
                    ltSlider5.Text = "<img class='swiper-slide' src='" + dt.Rows[0]["images5"].ToString() + "' alt='" + dt.Rows[0]["tenNewsDeltail"].ToString() + "'/>";
                }
                if (dt.Rows[0]["images6"].ToString() != "") {
                    ltSlider6.Text = "<img class='swiper-slide' src='" + dt.Rows[0]["images6"].ToString() + "' alt='" + dt.Rows[0]["tenNewsDeltail"].ToString() + "'/>";
                }
                if (dt.Rows[0]["images7"].ToString() != "") {
                    ltSlider7.Text = "<img class='swiper-slide' src='" + dt.Rows[0]["images7"].ToString() + "' alt='" + dt.Rows[0]["tenNewsDeltail"].ToString() + "'/>";
                }
                
                
                ltContent.Text = dt.Rows[0]["noiDung"].ToString();
                ltads.Text = "<a href='" + dt.Rows[0]["linkProduct"].ToString() + "' target='_blank'>" +
                    "<picture>"+
                        " <source media='(max-width:1000px)' srcset='" + dt.Rows[0]["imagesProductQCMobile"].ToString() + "'>" +
                        "<img class='' src='" + dt.Rows[0]["imagesProductQC"].ToString() + "' alt='" + dt.Rows[0]["tenNewsDeltail"].ToString() + "'/>" +
                    "</picture>" +
                    "</a>";
                ltTenTinTuc.Text = dt.Rows[0]["tenNewsDeltail"].ToString();
                ltNgayTao.Text = DateTime.Parse(dt.Rows[0]["ngayTao"].ToString()).ToString("dd/MM/yyyy hh:mm tt");
                int luotView = int.Parse(dt.Rows[0]["luotView"].ToString());
                luotView++;
                _quanlydanhmuctintuc.updateLuotViewNewsDeltail(int.Parse(dt.Rows[0]["maNewsDeltail"].ToString()),luotView);
                DataTable dtkhac = new DataTable();

                dtkhac = _quanlydanhmuctintuc.layNewsDeltailKhac(int.Parse(dt.Rows[0]["maNewsDeltail"].ToString()));
                if (dtkhac.Rows.Count > 0)
                {
                    rptTintuckhac.DataSource = dtkhac;
                    rptTintuckhac.DataBind();
                }
            }
            else
            {
                Response.Redirect("/404");
            }


        }
    }
}