using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace nguyeensport.Display.Unitl
{
    public partial class tro_giup_hoi_dap : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            loadheader.Controls.Add(LoadControl("~/Display/header.ascx"));
            loadMenuList1.Controls.Add(LoadControl("~/Display/menulist1.ascx"));
            loadMenuList2.Controls.Add(LoadControl("~/Display/menulist2.ascx"));
            loadSearch.Controls.Add(LoadControl("~/Display/search.ascx"));
            loadGioHang.Controls.Add(LoadControl("~/Display/giohang.ascx"));
            loadfooter.Controls.Add(LoadControl("~/Display/footer.ascx"));
            LoadData();
        }
        void LoadData()
        {
            string link = Page.RouteData.Values["link"] as string;
            switch(link)
            {
                case "tro-giup-hoi-dap":
                ltTitle.Text = "Trợ giúp & Hỏi đáp - NGUYEENSPORT";
                loadContent.Controls.Add(LoadControl("trogiuphoidap.ascx"));
                break;
                case "van-chuyen":
                    ltTitle.Text = "Vận chuyển - NGUYEENSPORT";
                    loadContent.Controls.Add(LoadControl("delivery.ascx"));
                    break;
                case "doi-tra":
                    ltTitle.Text = "Đổi trả - NGUYEENSPORT";
                    loadContent.Controls.Add(LoadControl("doitra.ascx"));
                    break;

            }
        }

    }
}