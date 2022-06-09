using nguyeensport.dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace nguyeensport.Display
{
    public partial class phukien : System.Web.UI.UserControl
    {
        clsquanlyslider _quanlyslider = new clsquanlyslider();
        clsquanlyproduct _quanlyproduct = new clsquanlyproduct();
        protected void Page_Load(object sender, EventArgs e)
        {
            rptSlider.DataSource = _quanlyslider.layTop5SliderTheoMaDanhMuc(4);
            rptSlider.DataBind();

            rptSanPham.DataSource = _quanlyproduct.layTop15ProductTheoMaDanhMuc(4);
            rptSanPham.DataBind();
        }

        protected void rptSanPham_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            Label lblMessage = e.Item.FindControl("lblMessage") as Label;
            Label lblDiscount = e.Item.FindControl("lblDiscount") as Label;
            Label lblSaving = e.Item.FindControl("lblSaving") as Label;
            if (lblMessage.Text == "New")
            {
                lblMessage.CssClass = "product-message product-message--new";
            }
            if (lblMessage.Text == "Pre-Order")
            {
                lblMessage.CssClass = "product-message product-message__text";
            }
            if (lblMessage.Text == "0%")
            {
                lblMessage.Text = "";
                lblMessage.CssClass = "product-message";
            }
            if (lblMessage.Text == "5%")
            {
                lblMessage.CssClass = "product-message product-message--sale";
            }
            if (lblMessage.Text == "10%")
            {
                lblMessage.CssClass = "product-message product-message--sale";
            }
            if (lblMessage.Text == "15%")
            {
                lblMessage.CssClass = "product-message product-message--sale";
            }
            if (lblMessage.Text == "20%")
            {
                lblMessage.CssClass = "product-message product-message--sale";
            }
            if (lblMessage.Text == "25%")
            {
                lblMessage.CssClass = "product-message product-message--sale";
            }
            if (lblMessage.Text == "30%")
            {
                lblMessage.CssClass = "product-message product-message--sale";
            }
            if (lblMessage.Text == "35%")
            {
                lblMessage.CssClass = "product-message product-message--sale";
            }
            if (lblMessage.Text == "50%")
            {
                lblMessage.CssClass = "product-message product-message--sale";
            }

            if (lblSaving.Text == "Giảm 0")
            {
                lblDiscount.Visible = false;
                lblSaving.Visible = false;
            }
            else
            {
                lblDiscount.Visible = true;
                lblSaving.Visible = true;
                lblDiscount.CssClass = "product-prices__item product-prices__item--original";
                lblSaving.CssClass = "product-prices__item product-prices__item--saving";
            }
        }
    }
}