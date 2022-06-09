using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace nguyeensport.Display.Unitl.Men
{
    public partial class nam : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string trangphuc = Page.RouteData.Values["trangphuc"] as string;
            switch (trangphuc)
            {
                case "ao":
                    loadTrangPhuc.Controls.Add(LoadControl("TrangPhuc/trangphuc.ascx"));
                    break;
                case "giay-bong-da":
                    loadTrangPhuc.Controls.Add(LoadControl("TrangPhuc/trangphuc.ascx"));
                    break;
                case "quan":
                    loadTrangPhuc.Controls.Add(LoadControl("TrangPhuc/trangphuc.ascx"));
                    break;
                case "giay-the-thao":
                    loadTrangPhuc.Controls.Add(LoadControl("TrangPhuc/trangphuc.ascx"));
                    break;
            }
        }
    }
}