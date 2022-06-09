using nguyeensport.dal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace nguyeensport.Display.TinTuc
{
    public partial class DanhSachTinTuc : System.Web.UI.Page
    {
        clsquanlydanhmuctintuc _quanlytintuc = new clsquanlydanhmuctintuc();
        protected string danhmuc = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            danhmuc = Page.RouteData.Values["danhmuc"] as string;
            if (danhmuc != null)
            {
                DataTable dt = new DataTable();
                dt = _quanlytintuc.layNewsDeltailTheoLinkNews(danhmuc);

                if (dt.Rows.Count > 0)
                {
                    ltTitle.Text = dt.Rows[0]["tenNews"].ToString() + " - NGUYEENSPORT";
                    ltheaderCategory.Text = "<a id='header-category' href='/tin-tuc/" + dt.Rows[0]["linkNews"].ToString() + "'>" + dt.Rows[0]["tenNews"] + "</a>";
                    rptContent.DataSource = dt;
                    rptContent.DataBind();
                }
                else
                {
                    Response.Redirect("/404");
                }
            }
            else
            {
                ltTitle.Text = "Tin tức - NGUYEENSPORT";
                ltheaderCategory.Text = "<a id='header-category' href='/tin-tuc/'>Tin tức</a>";
                rptContent.DataSource = _quanlytintuc.layNewsDeltailTheoHienThi();
                rptContent.DataBind();

            }
        }

    }
}