using nguyeensport.dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace nguyeensport.Display
{
    public partial class fanshop : System.Web.UI.UserControl
    {
        clsquanlyslider _quanlyslider = new clsquanlyslider();
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        void LoadData()
        {
            rptSlider.DataSource = _quanlyslider.layTop5SliderTheoMaDanhMuc(1);
            rptSlider.DataBind();

            rptSanPham.DataSource = clsquanlyproduct.layTop15ProductTheoMaDanhMuc(1);
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
        //protected void drlGiaiDau_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if(drlGiaiDau.SelectedValue == "Premier League")
        //    {
        //        Response.Redirect("/p/fan-shop/nam/premier-league");
        //    }
        //    if (drlGiaiDau.SelectedValue == "La Liga")
        //    {
        //        Response.Redirect("/p/fan-shop/nam/la-liga");
        //    }
        //    if (drlGiaiDau.SelectedValue == "Bundesliga")
        //    {
        //        Response.Redirect("/p/fan-shop/nam/bundesliga");
        //    }
        //    if (drlGiaiDau.SelectedValue == "Ligue 1")
        //    {
        //        Response.Redirect("/p/fan-shop/nam/ligue-1");
        //    }
        //    if (drlGiaiDau.SelectedValue == "MLS")
        //    {
        //        Response.Redirect("/p/fan-shop/nam/mls");
        //    }
        //    if (drlGiaiDau.SelectedValue == "All Clb Of World")
        //    {
        //        Response.Redirect("/p/fan-shop/nam/all-clb-of-world");
        //    }
        //    if (drlGiaiDau.SelectedValue == "International")
        //    {
        //        Response.Redirect("/p/fan-shop/nam/international");
        //    }

        //}
    }
}
