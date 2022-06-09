using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace nguyeensport.Display.Unitl.Men
{
    public partial class men : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            loadData();
        }
        void loadData()
        {
            ltTitle.Text = "Hướng dẫn chọn kích thước - NGUYEENSPORT";
            loadheader.Controls.Add(LoadControl("~/Display/header.ascx"));
            loadMenuList1.Controls.Add(LoadControl("~/Display/menulist1.ascx"));
            loadMenuList2.Controls.Add(LoadControl("~/Display/menulist2.ascx"));
            loadSearch.Controls.Add(LoadControl("~/Display/search.ascx"));
            loadGioHang.Controls.Add(LoadControl("~/Display/giohang.ascx"));
            loadfooter.Controls.Add(LoadControl("~/Display/footer.ascx"));
            string gioitinh = Page.RouteData.Values["gioitinh"] as string;

            switch (gioitinh)
            {
                case "nam":
                    
                    loadNoiDung.Controls.Add(LoadControl("nam.ascx"));
                    break;
                case "nu":
                    loadNoiDung.Controls.Add(LoadControl("nu.ascx"));
                    break;
                case "tre-em":
                    loadNoiDung.Controls.Add(LoadControl("treem.ascx"));
                    break;
            }
        }
       
    }
}