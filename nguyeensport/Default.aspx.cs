using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace nguyeensport
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string page = Page.RouteData.Values["page"] as string;
            if (page != null)
            {
                switch (page)
                {
                    case "fan-shop":
                        loadMain.Controls.Add(LoadControl("Display/fanshop.ascx"));
                        break;
                    case "giay-bong-da":
                        loadMain.Controls.Add(LoadControl("Display/giaybongda.ascx"));
                        break;
                    case "phu-kien":
                        loadMain.Controls.Add(LoadControl("Display/phukien.ascx"));
                        break;
                    case "teamwear":
                        loadMain.Controls.Add(LoadControl("Display/teamwear.ascx"));
                        break;
                    default:
                        Response.Redirect("/404");
                        break;
                }
            }
            else
            {
                loadMain.Controls.Add(LoadControl("Display/main.ascx"));
            }
        }
    }
}