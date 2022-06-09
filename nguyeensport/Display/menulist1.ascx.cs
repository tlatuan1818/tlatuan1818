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
    public partial class menulist1 : System.Web.UI.UserControl
    {
        clsquanlydanhmuc _quanlydanhmuc = new clsquanlydanhmuc();
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        void LoadData()
        {
            rptDanhMucCha.DataSource = _quanlydanhmuc.layCategoriesTheoHienThi();
            rptDanhMucCha.DataBind();
        }

        protected void rptDanhMucCha_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                string maDanhMuc = (e.Item.FindControl("hdMaDanhMuc") as HiddenField).Value;
                Repeater rptMenuList = e.Item.FindControl("rptMenuList") as Repeater;
                Literal ltSubNavListItemHighLight = e.Item.FindControl("ltSubNavListItemHighLight") as Literal;
                rptMenuList.DataSource = _quanlydanhmuc.laySubPanertCategoriesTheoMaDanhMucHienThi(int.Parse(maDanhMuc));
                rptMenuList.DataBind();
                if (maDanhMuc == "1")
                {
                    ltSubNavListItemHighLight.Text = "<ul class='sub-nav-list'>" +
                                                        "<li class='sub-nav-list__item sub-nav-list__item--highlight'>" +
                                                            "<a href='/p/fan-shop/nam' class='sub-nav-link'>Áo bóng đá Nam</a> " +
                                                        "</li>" +
                                                         "<li class='sub-nav-list__item sub-nav-list__item--highlight'>" +
                                                            "<a href='/p/fan-shop/nu' class='sub-nav-link'>Áo bóng đá Nữ</a> " +
                                                        "</li>" +
                                                         "<li class='sub-nav-list__item sub-nav-list__item--highlight'>" +
                                                            "<a href='/p/fan-shop/tre-em' class='sub-nav-link'>Áo bóng đá Trẻ em</a> " +
                                                        "</li>" +
                                                          "<li class='sub-nav-list__item sub-nav-list__item--highlight'>" +
                                                            "<a href='/c/news-fan-shop' class='sub-nav-link'>Áo bóng đá Mới</a> " +
                                                        "</li>" +
                                                          "<li class='sub-nav-list__item sub-nav-list__item--highlight'>" +
                                                            "<a href='/c/retro-fan-shop' class='sub-nav-link'>Áo bóng đá Retro</a> " +
                                                        "</li>" +
                                                     "</ul>";
                }
                else if(maDanhMuc == "2")
                {
                    ltSubNavListItemHighLight.Text = "<ul class='sub-nav-list'>" +
                                                        "<li class='sub-nav-list__item sub-nav-list__item--highlight'>" +
                                                            "<a href='/p/giay-bong-da/nguoi-lon' class='sub-nav-link'>Giày bóng đá Người lớn</a> " +
                                                        "</li>" +
                                                       
                                                         "<li class='sub-nav-list__item sub-nav-list__item--highlight'>" +
                                                            "<a href='/p/giay-bong-da/tre-em' class='sub-nav-link'>Giày bóng đá Trẻ em</a> " +
                                                        "</li>" +
                                                         "<li class='sub-nav-list__item sub-nav-list__item--highlight'>" +
                                                            "<a href='/c/news-giay-bong-da' class='sub-nav-link'>Giày bóng đá Mới</a> " +
                                                        "</li>" +
                                                     "</ul>";
                }
                else if(maDanhMuc == "3")
                {
                    ltSubNavListItemHighLight.Text = "<ul class='sub-nav-list'>" +
                                                        "<li class='sub-nav-list__item sub-nav-list__item--highlight'>" +
                                                            "<a href='/p/teamwear/nam' class='sub-nav-link'>Bộ quần áo bóng đá Nam</a> " +
                                                        "</li>" +
                                                        "<li class='sub-nav-list__item sub-nav-list__item--highlight'>" +
                                                            "<a href='/p/teamwear/nu' class='sub-nav-link'>Bộ quần áo bóng đá Nữ</a> " +
                                                        "</li>" +
                                                         "<li class='sub-nav-list__item sub-nav-list__item--highlight'>" +
                                                            "<a href='/p/teamwear/tre-em' class='sub-nav-link'>Bộ quần áo bóng đá Trẻ em</a> " +
                                                        "</li>" +
                                                         "<li class='sub-nav-list__item sub-nav-list__item--highlight'>" +
                                                            "<a href='/c/sales-teamwear' class='sub-nav-link'>Sale 50%</a> " +
                                                        "</li>" +
                                                     "</ul>";
                }
                else if(maDanhMuc == "4")
                {
                    ltSubNavListItemHighLight.Text = "<ul class='sub-nav-list'>" +
                                                      "<li class='sub-nav-list__item sub-nav-list__item--highlight'>" +
                                                          "<a href='/p/phu-kien/nguoi-lon' class='sub-nav-link'>Phụ kiện cho người lớn</a> " +
                                                      "</li>" +
                                                      "<li class='sub-nav-list__item sub-nav-list__item--highlight'>" +
                                                          "<a href='/p/phu-kien/tre-em' class='sub-nav-link'>Phụ kiện cho trẻ em</a> " +
                                                      "</li>" +
                                                     
                                                   "</ul>";
                }

                for (int i = 0; i < rptMenuList.Items.Count; i++)
                {
                    HiddenField hfIDDanhMucCon = rptMenuList.Items[i].FindControl("hfIDDanhMucCon") as HiddenField;
                    HiddenField hfViTri = rptMenuList.Items[i].FindControl("hfViTri") as HiddenField;
                    Repeater rptMenuCap1 = rptMenuList.Items[i].FindControl("rptMenuCap1") as Repeater;
                    rptMenuCap1.DataSource = _quanlydanhmuc.laySubChildCategoriesTheoMaDanhMucHienThi(int.Parse(hfIDDanhMucCon.Value), int.Parse(hfViTri.Value));
                    rptMenuCap1.DataBind();

                }
            }
        }
    }
}