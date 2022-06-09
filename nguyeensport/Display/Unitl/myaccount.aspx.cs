using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace nguyeensport.Display.Unitl
{
    public partial class myaccount : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string account = Page.RouteData.Values["account"] as string;
            string delClubs = Page.RouteData.Values["delclub"] as string;
            if(Session["username"] != null)
            {
                loadheader.Controls.Add(LoadControl("~/Display/header.ascx"));
                loadMenuList1.Controls.Add(LoadControl("~/Display/menulist1.ascx"));
                loadMenuList2.Controls.Add(LoadControl("~/Display/menulist2.ascx"));
                loadSearch.Controls.Add(LoadControl("~/Display/search.ascx"));
                loadGioHang.Controls.Add(LoadControl("~/Display/giohang.ascx"));
                if(account == "chi-tiet-cua-toi")
                {
                    ltTitle.Text = "Thông tin của tôi";
                    ltCSS.Text = "<link rel='stylesheet' type='text/css' media='screen' href='/common/css/my-detail.css' />";
                    loadMain.Controls.Add(LoadControl("account/mydeltail.ascx"));
                }
                else if (account == "cau-lac-bo-cua-toi")
                {
                    ltTitle.Text = "Câu lạc bộ của tôi";
                    ltCSS.Text = "<link rel='stylesheet' type='text/css' media='screen' href='/common/css/my-clubs.css' />";
                    loadMain.Controls.Add(LoadControl("account/myclub.ascx"));
                }
                
                loadfooter.Controls.Add(LoadControl("~/Display/footer.ascx"));
            }
            else
            {
                Response.Redirect("/login");
            }
        }
    }
}