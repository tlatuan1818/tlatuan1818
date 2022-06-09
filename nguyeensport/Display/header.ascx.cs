using nguyeensport.dal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace nguyeensport.Display
{
    public partial class header : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] != null)
            {
                ltAvatar.Text = "<a id='openform'><img src='/" + Session["avatar"] + "' alt='" + Session["username"] + "' style='padding:5px; border-radius:50%;'></a>";
                ltAvatar1.Text = "<a id='openform1'><img src='/" + Session["avatar"] + "' alt='" + Session["username"] + "' style='padding:5px; border-radius:50%;'></a>";
            }
            else
            {
                ltAvatar.Text = "<a href='/login'><img src = '/images/common/user.svg' alt = 'User' ></a>";
                ltAvatar1.Text = "<a href='/login'><img src = '/images/common/user.svg' alt = 'User' ></a>";
            }

            if (Session["cart"] != null)
            {
                DataTable dtCart = (DataTable)Session["cart"];
                float total = 0;
                int soluong = 0;
                for (int i = 0; i < dtCart.Rows.Count; i++)
                {
                    total += Convert.ToSingle(dtCart.Rows[i]["Total"]);
                    soluong += Convert.ToInt32(dtCart.Rows[i]["SoLuong"]);
                }
                ltSoLuong.Text = "<span>" + soluong.ToString() + "</span>";
                ltSoLuong1.Text = "<span>" + soluong.ToString() + "</span>";
            }
        }

        protected void lnkLogout_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Session.Clear();
            Response.Redirect("/");
        }
    }
}