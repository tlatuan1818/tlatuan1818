using nguyeensport.dal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace nguyeensport.Display.Unitl.account
{
    public partial class myclub : System.Web.UI.UserControl
    {
        //clsquanlytaikhoan _quanlytaikhoan = new clsquanlytaikhoan();
        //clsquanlyclb _quanlyclb = new clsquanlyclb();
        //protected void Page_Load(object sender, EventArgs e)
        //{
        //    if(Session["username"] != null)
        //    {
        //        DataTable dt = new DataTable();
        //        dt = _quanlytaikhoan.timAccountTheoTen(Session["email"].ToString());
        //        if(dt.Rows.Count > 0)
        //        {
        //            DataTable dtCLB = new DataTable();
                    
        //            dtCLB = _quanlyclb.timCLBTheoID(int.Parse(dt.Rows[0]["ID"].ToString()));
        //            if(dtCLB.Rows.Count > 0) {
        //                ltMuaSam.Text = "";
        //                rptClb.DataSource = dtCLB;
        //                rptClb.DataBind();
        //            }
        //            else
        //            {
        //                ltMuaSam.Text = "<a class='button js-button'>Mua săm quần áo đội</a>";
        //            }

                    
        //        }
        //    }
        //}

        //protected void Delete_Load(object sender, System.EventArgs e)
        //{
        //    ((LinkButton)sender).Attributes["onclick"] = "return confirm('Bạn có muốn xóa ?')";
        //}
        //protected void rptClb_ItemCommand(object source, RepeaterCommandEventArgs e)
        //{
        //    if (e.CommandName.ToString() == "delete")
        //    {
        //        DataTable dt = new DataTable();
        //        dt = _quanlyclb.timCLBTheoID(int.Parse(e.CommandArgument.ToString()));
        //        if (dt.Rows.Count > 0)
        //        {
        //            _quanlyclb.DeleteCLB(int.Parse(e.CommandArgument.ToString()));
        //        }
        //    }
        //}
    }
}