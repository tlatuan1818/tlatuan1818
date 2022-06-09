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
    public partial class giohang : System.Web.UI.UserControl
    {
        clsCart _cart = new clsCart();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["cart"] != null)
            {
                    DataTable dtCart = (DataTable)Session["cart"];
                    rptLoadGioHang.DataSource = dtCart;
                    rptLoadGioHang.DataBind();
                    float total = 0;
                    int soluong = 0;
                    for (int i = 0; i < dtCart.Rows.Count; i++)
                    {
                        total += Convert.ToSingle(dtCart.Rows[i]["Total"].ToString());
                        soluong += Convert.ToInt32(dtCart.Rows[i]["SoLuong"].ToString());
                    }
                    ltSoLuong.Text = soluong.ToString();
                    ltTongTien.Text = string.Format("{0:N0}", total);
                    ltTongThanhToan.Text = string.Format("{0:N0}", total);
            }
        }

        protected void rptLoadGioHang_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "update")
            {
                TextBox txtQuantity = e.Item.FindControl("txtQuantity") as TextBox;

                int quantity = 0;

                quantity += quantity + int.Parse(txtQuantity.Text.Trim());

                _cart.ShoppingCart_UpdateCart(e.CommandArgument.ToString(), quantity);
            }
            if (e.CommandName == "delete")
            {
                _cart.ShoppingCart_RemoveCart(e.CommandArgument.ToString());
            }
            Response.Redirect(Request.Url.ToString());
        }
    }
}