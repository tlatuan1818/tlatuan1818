using nguyeensport.dal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace nguyeensport.Display.Unitl.account.clubs
{
    public partial class delClubs : System.Web.UI.Page
    {
       
        //clsquanlyclb _quanlyclb = new clsquanlyclb();
        protected void Page_Load(object sender, EventArgs e)
        {
            string delClubs = Page.RouteData.Values["delclub"] as string;
                    DataTable dt = new DataTable();
                    //dt = _quanlyclb.timCLBTheoLink(delClubs);
                    if(dt.Rows.Count > 0)
                    { 
                        ltTitle.Text = dt.Rows[0]["TenCLB"].ToString();
                        ltHeaderTitle.Text = dt.Rows[0]["TenCLB"].ToString();
                    }

            loadheader.Controls.Add(LoadControl("~/Display/header.ascx"));
            loadMenuList1.Controls.Add(LoadControl("~/Display/menulist1.ascx"));
            loadMenuList2.Controls.Add(LoadControl("~/Display/menulist2.ascx"));
            loadSearch.Controls.Add(LoadControl("~/Display/search.ascx"));
            loadGioHang.Controls.Add(LoadControl("~/Display/giohang.ascx"));
            loadfooter.Controls.Add(LoadControl("~/Display/footer.ascx"));
        }
    }
}