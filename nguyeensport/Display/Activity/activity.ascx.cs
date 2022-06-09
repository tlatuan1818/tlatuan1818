using nguyeensport.dal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace nguyeensport.Display.Activity
{
    public partial class activity : System.Web.UI.UserControl
    {
        clsquanlydanhmuc _quanlydanhmuc = new clsquanlydanhmuc();
        clsquanlyfanshop _quanlyfanshop = new clsquanlyfanshop();
        clsquanlybrands _qualybrands = new clsquanlybrands();
        clsquanlyleague _quanlyleague = new clsquanlyleague();
        clsquanlyproducttype _quanlyproducttype = new clsquanlyproducttype();
        clsquanlyteam _quanlyteam = new clsquanlyteam();
        clsquanlyrange _quanlyrange = new clsquanlyrange();
        DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {

            LoadData();

        }
        void LoadData()
        {
            
            
            string path = Request.Url.AbsolutePath;
           
            dt = _quanlydanhmuc.laySubPanertCategoriesTheoLink(path);
            if (path != null)
            {
                if (path == dt.Rows[0]["linkDanhMucCon"].ToString()) 
                {
                   
                  
                        ltBannerListing.Text = "<source media='(max-width: 599px)' srcset='" + dt.Rows[0]["anhBiaMobile"].ToString() + "' />" +
                            "<img class='banner__image' src='" + dt.Rows[0]["anhBiaDesktop"].ToString() + "' />";

                        rptDanhMucConCap1.DataSource = _quanlydanhmuc.laySubPanertCategoriesTheoMaDanhMucHienThi(int.Parse(dt.Rows[0]["maDanhMuc"].ToString()));
                        rptDanhMucConCap1.DataBind();
                        drCauLacBo.DataSource = _quanlydanhmuc.laySubPanertCategoriesTheoMaDanhMucHienThi(int.Parse(dt.Rows[0]["maDanhMuc"].ToString()));
                        drCauLacBo.DataValueField = "linkDanhMucCon";
                        drCauLacBo.DataTextField = "tenDanhMucCon";
                        drCauLacBo.DataBind();

                        ltDanhMuc.Text = " <li class='breadcrumbs__list-item'>" +
                                        "<a href='/p/fan-shop' class='breadcrumbs__link'>" +
                                          "<span class='breadcrumbs__name'>" +
                                              "Fan shop" +
                                          "</span>" +
                                      "</a>" +
                                    "</li>"+
                        "<li class='breadcrumbs__list-item'>" +
                                        "<a class='breadcrumbs__link'>" +
                                          "<span class='breadcrumbs__name'>" +
                                              dt.Rows[0]["tenDanhMucCon"].ToString() +
                                          "</span>" +
                                      "</a>" +
                                    "</li>";
                    rptList.DataSource = _quanlyleague.layLeagueTheoHienThi();
                    rptList.DataBind();
                    rptBrands.DataSource = _qualybrands.layBrandsTheoHienThi();
                    rptBrands.DataBind();
                    rptProductType.DataSource = _quanlyproducttype.layProductTypeTheoHienThi();
                    rptProductType.DataBind();
                    rptList1.DataSource = _quanlyteam.layTeamTheoHienThi();
                    rptList1.DataBind();
                    rptList2.DataSource = _quanlyrange.layRangeTheoHienThi();
                    rptList2.DataBind();
                }
            }
            else
            {
                Server.TransferRequest("/404");
            }

        }
        public int PageNumber
        {
            get
            {
                if (ViewState["PageNumber"] != null)
                    return Convert.ToInt32(ViewState["PageNumber"]);
                else
                    return 0;
            }
            set
            {
                ViewState["PageNumber"] = value;
            }
        }

        protected void btnPrev_Click(object sender, EventArgs e)
        {
            PageNumber = PageNumber - 1;
            LoadData();
        }

        protected void btnNext_Click(object sender, EventArgs e)
        {
            PageNumber = PageNumber + 1;
            LoadData();
        }
    }
}