using nguyeensport.dal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace nguyeensport.Display.Product
{
    public partial class productgiaybongda : System.Web.UI.UserControl
    {
        //clsquanlysanpham _quanlysanpham = new clsquanlysanpham();
        //clsCart _cart = new clsCart();
        //clsquanlytaikhoan _quanlytaikhoan = new clsquanlytaikhoan();
    //    protected string code = "";
    //    protected void Page_Load(object sender, EventArgs e)
    //    {
    //        if (!IsPostBack)
    //        {
    //            LoadData();
                
    //        }
                
    //    }
    //    void LoadData()
    //    {
    //        code = Page.RouteData.Values["code"] as string;
    //        if (code != null)
    //        {
    //            DataTable dtSanPham = new DataTable();
    //            dtSanPham = _quanlysanpham.timGiayTheoID(code);
    //            if (dtSanPham.Rows.Count > 0)
    //            { 
    //                ltTenSanPham.Text = "<a class='breadcrumbs__link' href='/" + dtSanPham.Rows[0]["DanhMuc"].ToString() + "/" + dtSanPham.Rows[0]["Link"].ToString() + "-" + dtSanPham.Rows[0]["ID"].ToString() + "'>" +
    //                                        "<span class='breadcrumbs__name'>" +
    //                                            dtSanPham.Rows[0]["TenSanPham"].ToString() +
    //                                        "</span>" +
    //                                     "</a>";
    //                ltImage1.Text = "<div class='gallery-nav-box is-active' onclick='changeImage(this)'>" +
    //                                    "<img src='/" + dtSanPham.Rows[0]["Image1"].ToString() + "' alt ='" + dtSanPham.Rows[0]["TenSanPham"].ToString() + "' />" +
    //                                "</div>";
    //                if (dtSanPham.Rows[0]["Image2"].ToString() != "")
    //                {
    //                    ltImage2.Text = "<div class='gallery-nav-box' onclick='changeImage(this)'>" +
    //                                    "<img src='/" + dtSanPham.Rows[0]["Image2"].ToString() + "' alt ='" + dtSanPham.Rows[0]["TenSanPham"].ToString() + "' />" +
    //                                "</div>";
    //                }
    //                else
    //                {
    //                    ltImage2.Text = "";
    //                }

    //                if (dtSanPham.Rows[0]["Image3"].ToString() != "")
    //                {
    //                    ltImage3.Text = "<div class='gallery-nav-box' onclick='changeImage(this)'>" +
    //                                    "<img src='/" + dtSanPham.Rows[0]["Image3"].ToString() + "' alt ='" + dtSanPham.Rows[0]["TenSanPham"].ToString() + "' />" +
    //                                "</div>";
    //                }
    //                else
    //                {
    //                    ltImage3.Text = "";
    //                }

    //                if (dtSanPham.Rows[0]["Image4"].ToString() != "")
    //                {
    //                    ltImage4.Text = "<div class='gallery-nav-box' onclick='changeImage(this)'>" +
    //                                   "<img src='/" + dtSanPham.Rows[0]["Image4"].ToString() + "' alt ='" + dtSanPham.Rows[0]["TenSanPham"].ToString() + "' />" +
    //                               "</div>";
    //                }
    //                else
    //                {
    //                    ltImage4.Text = "";
    //                }

    //                if (dtSanPham.Rows[0]["Image5"].ToString() != "")
    //                {
    //                    ltImage5.Text = "<div class='gallery-nav-box' onclick='changeImage(this)'>" +
    //                                    "<img src='/" + dtSanPham.Rows[0]["Image5"].ToString() + "' alt ='" + dtSanPham.Rows[0]["TenSanPham"].ToString() + "' />" +
    //                                "</div>";
    //                }
    //                else
    //                {
    //                    ltImage5.Text = "";
    //                }

    //                if (dtSanPham.Rows[0]["Image6"].ToString() != "")
    //                {
    //                    ltImage6.Text = "<div class='gallery-nav-box' onclick='changeImage(this)'>" +
    //                                    "<img src='/" + dtSanPham.Rows[0]["Image6"].ToString() + "' alt ='" + dtSanPham.Rows[0]["TenSanPham"].ToString() + "' />" +
    //                                "</div>";
    //                }
    //                else
    //                {
    //                    ltImage6.Text = "";
    //                }

    //                if (dtSanPham.Rows[0]["Image7"].ToString() != "")
    //                {
    //                    ltImage7.Text = "<div class='gallery-nav-box' onclick='changeImage(this)'>" +
    //                                   "<img src='/" + dtSanPham.Rows[0]["Image7"].ToString() + "' alt ='" + dtSanPham.Rows[0]["TenSanPham"].ToString() + "' />" +
    //                               "</div>";
    //                }
    //                else
    //                {
    //                    ltImage7.Text = "";
    //                }

    //                ltImage8.Text = "<img src='/" + dtSanPham.Rows[0]["Image1"].ToString() + "' alt='" + dtSanPham.Rows[0]["TenSanPham"].ToString() + "' class='is-bg-active'>";

    //                ltTenSanPham2.Text = "<h1 class='gallery-content_title'>" +
    //                                        dtSanPham.Rows[0]["TenSanPham"].ToString() +
    //                                        "<span class='product-title__colorway'>" +
    //                                          dtSanPham.Rows[0]["MauSac"].ToString() +  
    //                                        "</span>"+
    //                                    "</h1>";
    //                if(dtSanPham.Rows[0]["GiaGiam"].ToString() == "0")
    //                {
    //                    ltGiaCuoi.Text = "<span class='product-prices_item'>" + string.Format("{0:N0}", dtSanPham.Rows[0]["GiaCuoi"]) + " VNĐ</span>";
    //                    ltGiaGiam.Text = "";
    //                    ltGiaDau.Text = "";
    //                }
    //                else
    //                {
    //                    ltGiaCuoi.Text = "<span class='product-prices_item'>" + string.Format("{0:N0}", dtSanPham.Rows[0]["GiaCuoi"]) + " VNĐ</span>";
    //                    ltGiaDau.Text = "<span class='product-prices_item product-prices_item--original'>" + string.Format("{0:N0}", dtSanPham.Rows[0]["GiaDau"]) + " VNĐ</span>";
    //                    ltGiaGiam.Text = "<span class='product-prices_item product-prices_item--saving'>Giảm " + string.Format("{0:N0}", dtSanPham.Rows[0]["GiaGiam"]) + "</span>";
    //                }
    //                ltDinh.Text = "<span class='action-dropdown__text'>"+dtSanPham.Rows[0]["Dinh"].ToString()+"</span>";
    //                DataTable dtSize = new DataTable();
    //                dtSize = _quanlysanpham.timSizeTheoID(dtSanPham.Rows[0]["ID"].ToString());

    //                if(dtSize.Rows.Count > 0)
    //                {
    //                    foreach(DataRow dr in dtSize.Rows)
    //                    {
    //                        if (dr["TenSize"].ToString() == "38")
    //                        {
    //                            if(int.Parse(dr["SoLuong"].ToString()) > 0)
    //                            {
    //                                ltSize38.Text = "<div class='button'>"+
    //                                                "<span class='button__title'>"+
    //                                                      "38"+  
    //                                             "</span>"+
    //                                             "<span class='button__postion'>" +
    //                                                    "Số lượng: " +
    //                                                    dr["SoLuong"].ToString() +
    //                                                "</span>" +
    //                                         "</div>";
    //                            }
    //                            else
    //                            {
    //                                ltSize38.Text = "<div class='button btn-active'>" +
    //                                                "<span class='button__title'>" +
    //                                                      "38" +
    //                                             "</span>" +
    //                                             "<span class='button__postion'>" +
    //                                                    "Số lượng: " +
    //                                                    dr["SoLuong"].ToString() +
    //                                                "</span>" +
    //                                         "</div>";
    //                            }
    //                        }
    //                        if (dr["TenSize"].ToString() == "39")
    //                        {
    //                            if (int.Parse(dr["SoLuong"].ToString()) > 0)
    //                            {
    //                                ltSize39.Text = "<div class='button'>" +
    //                                                "<span class='button__title'>" +
    //                                                      "39" +
    //                                             "</span>" +
    //                                             "<span class='button__postion'>" +
    //                                                    "Số lượng: " +
    //                                                    dr["SoLuong"].ToString() +
    //                                                "</span>" +
    //                                         "</div>";
    //                            }
    //                            else
    //                            {
    //                                ltSize39.Text = "<div class='button btn-active'>" +
    //                                                "<span class='button__title'>" +
    //                                                      "39" +
    //                                             "</span>" +
    //                                             "<span class='button__postion'>" +
    //                                                    "Số lượng: " +
    //                                                    dr["SoLuong"].ToString() +
    //                                                "</span>" +
    //                                         "</div>";
    //                            }
    //                        }
    //                        if (dr["TenSize"].ToString() == "40")
    //                        {
    //                            if (int.Parse(dr["SoLuong"].ToString()) > 0)
    //                            {
    //                                ltSize40.Text = "<div class='button'>" +
    //                                                "<span class='button__title'>" +
    //                                                      "40" +
    //                                             "</span>" +
    //                                             "<span class='button__postion'>" +
    //                                                    "Số lượng: " +
    //                                                    dr["SoLuong"].ToString() +
    //                                                "</span>" +
    //                                         "</div>";
    //                            }
    //                            else
    //                            {
    //                                ltSize40.Text = "<div class='button btn-active'>" +
    //                                                "<span class='button__title'>" +
    //                                                      "40" +
    //                                             "</span>" +
    //                                             "<span class='button__postion'>" +
    //                                                    "Số lượng: " +
    //                                                    dr["SoLuong"].ToString() +
    //                                                "</span>" +
    //                                         "</div>";
    //                            }
    //                        }
    //                        if (dr["TenSize"].ToString() == "41")
    //                        {
    //                            if (int.Parse(dr["SoLuong"].ToString()) > 0)
    //                            {
    //                                ltSize41.Text = "<div class='button'>" +
    //                                                "<span class='button__title'>" +
    //                                                      "41" +
    //                                             "</span>" +
    //                                             "<span class='button__postion'>" +
    //                                                    "Số lượng: " +
    //                                                    dr["SoLuong"].ToString() +
    //                                                "</span>" +
    //                                         "</div>";
    //                            }
    //                            else
    //                            {
    //                                ltSize41.Text = "<div class='button btn-active'>" +
    //                                                "<span class='button__title'>" +
    //                                                      "41" +
    //                                             "</span>" +
    //                                             "<span class='button__postion'>" +
    //                                                    "Số lượng: " +
    //                                                    dr["SoLuong"].ToString() +
    //                                                "</span>" +
    //                                         "</div>";
    //                            }
    //                        }
    //                        if (dr["TenSize"].ToString() == "42")
    //                        {
    //                            if (int.Parse(dr["SoLuong"].ToString()) > 0)
    //                            {
    //                                ltSize42.Text = "<div class='button'>" +
    //                                                "<span class='button__title'>" +
    //                                                      "42" +
    //                                             "</span>" +
    //                                             "<span class='button__postion'>" +
    //                                                    "Số lượng: " +
    //                                                    dr["SoLuong"].ToString() +
    //                                                "</span>" +
    //                                         "</div>";
    //                            }
    //                            else
    //                            {
    //                                ltSize42.Text = "<div class='button btn-active'>" +
    //                                                "<span class='button__title'>" +
    //                                                      "42" +
    //                                             "</span>" +
    //                                             "<span class='button__postion'>" +
    //                                                    "Số lượng: " +
    //                                                    dr["SoLuong"].ToString() +
    //                                                "</span>" +
    //                                         "</div>";
    //                            }
    //                        }
    //                        if (dr["TenSize"].ToString() == "43")
    //                        {
    //                            if (int.Parse(dr["SoLuong"].ToString()) > 0)
    //                            {
    //                                ltSize43.Text = "<div class='button'>" +
    //                                                "<span class='button__title'>" +
    //                                                      "43" +
    //                                             "</span>" +
    //                                             "<span class='button__postion'>" +
    //                                                    "Số lượng: " +
    //                                                    dr["SoLuong"].ToString() +
    //                                                "</span>" +
    //                                         "</div>";
    //                            }
    //                            else
    //                            {
    //                                ltSize43.Text = "<div class='button btn-active'>" +
    //                                                "<span class='button__title'>" +
    //                                                      "43" +
    //                                             "</span>" +
    //                                             "<span class='button__postion'>" +
    //                                                    "Số lượng: " +
    //                                                    dr["SoLuong"].ToString() +
    //                                                "</span>" +
    //                                         "</div>";
    //                            }
    //                        }
    //                        if (dr["TenSize"].ToString() == "44")
    //                        {
    //                            if (int.Parse(dr["SoLuong"].ToString()) > 0)
    //                            {
    //                                ltSize44.Text = "<div class='button'>" +
    //                                                "<span class='button__title'>" +
    //                                                      "44" +
    //                                             "</span>" +
    //                                             "<span class='button__postion'>" +
    //                                                    "Số lượng: " +
    //                                                    dr["SoLuong"].ToString() +
    //                                                "</span>" +
    //                                         "</div>";
    //                            }
    //                            else
    //                            {
    //                                ltSize44.Text = "<div class='button btn-active'>" +
    //                                                "<span class='button__title'>" +
    //                                                      "44" +
    //                                             "</span>" +
    //                                             "<span class='button__postion'>" +
    //                                                    "Số lượng: " +
    //                                                    dr["SoLuong"].ToString() +
    //                                                "</span>" +
    //                                         "</div>";
    //                            }
    //                        }
    //                        if (dr["TenSize"].ToString() == "37")
    //                        {
    //                            if (int.Parse(dr["SoLuong"].ToString()) > 0)
    //                            {
    //                                ltSize38.Text = "<div class='button'>" +
    //                                                "<span class='button__title'>" +
    //                                                      "37" +
    //                                             "</span>" +
    //                                             "<span class='button__postion'>" +
    //                                                    "Số lượng: " +
    //                                                    dr["SoLuong"].ToString() +
    //                                                "</span>" +
    //                                         "</div>";
    //                            }
    //                            else
    //                            {
    //                                ltSize38.Text = "<div class='button btn-active'>" +
    //                                                "<span class='button__title'>" +
    //                                                      "37" +
    //                                             "</span>" +
    //                                             "<span class='button__postion'>" +
    //                                                    "Số lượng: " +
    //                                                    dr["SoLuong"].ToString() +
    //                                                "</span>" +
    //                                         "</div>";
    //                            }
    //                        }
    //                        if (dr["TenSize"].ToString() == "36")
    //                        {
    //                            if (int.Parse(dr["SoLuong"].ToString()) > 0)
    //                            {
    //                                ltSize39.Text = "<div class='button'>" +
    //                                                "<span class='button__title'>" +
    //                                                      "36" +
    //                                             "</span>" +
    //                                             "<span class='button__postion'>" +
    //                                                    "Số lượng: " +
    //                                                    dr["SoLuong"].ToString() +
    //                                                "</span>" +
    //                                         "</div>";
    //                            }
    //                            else
    //                            {
    //                                ltSize39.Text = "<div class='button btn-active'>" +
    //                                                "<span class='button__title'>" +
    //                                                      "36" +
    //                                             "</span>" +
    //                                             "<span class='button__postion'>" +
    //                                                    "Số lượng: " +
    //                                                    dr["SoLuong"].ToString() +
    //                                                "</span>" +
    //                                         "</div>";
    //                            }
    //                        }
    //                        if (dr["TenSize"].ToString() == "35")
    //                        {
    //                            if (int.Parse(dr["SoLuong"].ToString()) > 0)
    //                            {
    //                                ltSize40.Text = "<div class='button'>" +
    //                                                "<span class='button__title'>" +
    //                                                      "35" +
    //                                             "</span>" +
    //                                             "<span class='button__postion'>" +
    //                                                    "Số lượng: " +
    //                                                    dr["SoLuong"].ToString() +
    //                                                "</span>" +
    //                                         "</div>";
    //                            }
    //                            else
    //                            {
    //                                ltSize40.Text = "<div class='button btn-active'>" +
    //                                                "<span class='button__title'>" +
    //                                                      "35" +
    //                                             "</span>" +
    //                                             "<span class='button__postion'>" +
    //                                                    "Số lượng: " +
    //                                                    dr["SoLuong"].ToString() +
    //                                                "</span>" +
    //                                         "</div>";
    //                            }
    //                        }
    //                        if (dr["TenSize"].ToString() == "34")
    //                        {
    //                            if (int.Parse(dr["SoLuong"].ToString()) > 0)
    //                            {
    //                                ltSize41.Text = "<div class='button'>" +
    //                                                "<span class='button__title'>" +
    //                                                      "34" +
    //                                             "</span>" +
    //                                             "<span class='button__postion'>" +
    //                                                    "Số lượng: " +
    //                                                    dr["SoLuong"].ToString() +
    //                                                "</span>" +
    //                                         "</div>";
    //                            }
    //                            else
    //                            {
    //                                ltSize41.Text = "<div class='button btn-active'>" +
    //                                                "<span class='button__title'>" +
    //                                                      "34" +
    //                                             "</span>" +
    //                                             "<span class='button__postion'>" +
    //                                                    "Số lượng: " +
    //                                                    dr["SoLuong"].ToString() +
    //                                                "</span>" +
    //                                         "</div>";
    //                            }
    //                        }
    //                        if (dr["TenSize"].ToString() == "33")
    //                        {
    //                            if (int.Parse(dr["SoLuong"].ToString()) > 0)
    //                            {
    //                                ltSize42.Text = "<div class='button'>" +
    //                                                "<span class='button__title'>" +
    //                                                      "33" +
    //                                             "</span>" +
    //                                             "<span class='button__postion'>" +
    //                                                    "Số lượng: " +
    //                                                    dr["SoLuong"].ToString() +
    //                                                "</span>" +
    //                                         "</div>";
    //                            }
    //                            else
    //                            {
    //                                ltSize42.Text = "<div class='button btn-active'>" +
    //                                                "<span class='button__title'>" +
    //                                                      "33" +
    //                                             "</span>" +
    //                                             "<span class='button__postion'>" +
    //                                                    "Số lượng: " +
    //                                                    dr["SoLuong"].ToString() +
    //                                                "</span>" +
    //                                         "</div>";
    //                            }
    //                        }
    //                        if (dr["TenSize"].ToString() == "32")
    //                        {
    //                            if (int.Parse(dr["SoLuong"].ToString()) > 0)
    //                            {
    //                                ltSize43.Text = "<div class='button'>" +
    //                                                "<span class='button__title'>" +
    //                                                      "32" +
    //                                             "</span>" +
    //                                             "<span class='button__postion'>" +
    //                                                    "Số lượng: " +
    //                                                    dr["SoLuong"].ToString() +
    //                                                "</span>" +
    //                                         "</div>";
    //                            }
    //                            else
    //                            {
    //                                ltSize43.Text = "<div class='button btn-active'>" +
    //                                                "<span class='button__title'>" +
    //                                                      "32" +
    //                                             "</span>" +
    //                                             "<span class='button__postion'>" +
    //                                                    "Số lượng: " +
    //                                                    dr["SoLuong"].ToString() +
    //                                                "</span>" +
    //                                         "</div>";
    //                            }
    //                        }
    //                        if (dr["TenSize"].ToString() == "31")
    //                        {
    //                            if (int.Parse(dr["SoLuong"].ToString()) > 0)
    //                            {
    //                                ltSize44.Text = "<div class='button'>" +
    //                                                "<span class='button__title'>" +
    //                                                      "31" +
    //                                             "</span>" +
    //                                             "<span class='button__postion'>" +
    //                                                    "Số lượng: " +
    //                                                    dr["SoLuong"].ToString() +
    //                                                "</span>" +
    //                                         "</div>";
    //                            }
    //                            else
    //                            {
    //                                ltSize44.Text = "<div class='button btn-active'>" +
    //                                                "<span class='button__title'>" +
    //                                                      "31" +
    //                                             "</span>" +
    //                                             "<span class='button__postion'>" +
    //                                                    "Số lượng: " +
    //                                                    dr["SoLuong"].ToString() +
    //                                                "</span>" +
    //                                         "</div>";
    //                            }
    //                        }

    //                    }
    //                }

    //                ltMoTa.Text = "<div class='accordion__content' id='content-one'>"+
    //                              "<div class='product-details'>"+
    //                                "<div class='product-details__description'>"+
    //                                      dtSanPham.Rows[0]["MoTa"].ToString()+
    //                                "</div>"+
    //                                "<ul class='product-details__list'>"+
    //                                    "<li class='product-details__list-item'>"+
    //                                        "<span class='product-details__list-title'>Màu săc: </span>"+
    //                                        "<span class='product-details__list-value'>"+dtSanPham.Rows[0]["MauSac"].ToString()+"</span>"+
    //                                    "</li>"+
    //                                    "<li class='product-details__list-item'>"+
    //                                        "<span class='product-details__list-title'>Code: </span>"+
    //                                        "<span class='product-details__list-value'>"+dtSanPham.Rows[0]["ID"].ToString()+"</span>"+
    //                                    "</li>"+
    //                                "</ul>"+
    //                            "</div>"+
    //                        "</div>";

    //                rptDeXuat.DataSource = _quanlysanpham.deXuatChoBan(3);
    //                rptDeXuat.DataBind();

    //                rptSanPhamMoi.DataSource = _quanlysanpham.sanPhamKhac(dtSanPham.Rows[0]["ID"].ToString(),int.Parse(dtSanPham.Rows[0]["DanhMuc"].ToString()));
    //                rptSanPhamMoi.DataBind();

    //                DataTable dtComment = new DataTable();
    //                dtComment = _quanlysanpham.layDanhGiaTheoIDSanPham(dtSanPham.Rows[0]["ID"].ToString());
    //                if(dtComment.Rows.Count > 0)
    //                {
    //                    PagedDataSource pgitems = new PagedDataSource();
    //                    System.Data.DataView dv = new System.Data.DataView(dtComment);
    //                    pgitems.DataSource = dv;
    //                    pgitems.AllowPaging = true;
    //                    pgitems.PageSize = 5;
    //                    pgitems.CurrentPageIndex = PageNumber;

    //                    if (pgitems.PageCount >= 1)
    //                    {
    //                        int trang = PageNumber + 1;
    //                        ltPage.Text = trang.ToString();
    //                        ltTotalPage.Text = pgitems.PageCount.ToString();
    //                    }
    //                    rptComment.DataSource = pgitems;
    //                    rptComment.DataBind();

    //                    ltTongBinhLuan.Text = dtComment.Rows.Count.ToString();
    //                    ltTongBinhLuan1.Text = dtComment.Rows.Count.ToString();
    //                    ltTongBinhLuan2.Text = dtComment.Rows.Count.ToString();
    //                    float DanhGiaTB = 0;
    //                    int tong = 0;
                        
    //                    for (int i = 0; i < dtComment.Rows.Count; i++)
    //                    {
    //                        tong = tong + int.Parse(dtComment.Rows[i]["SoSao"].ToString());
    //                    }
    //                    DanhGiaTB = float.Parse(tong.ToString()) / float.Parse(dtComment.Rows.Count.ToString());

    //                    if (DanhGiaTB >= 1 && DanhGiaTB <1.5)
    //                    {
    //                        ltDanhGiaTB.Text = "1.0 / 5.0";
    //                        ltSao.Text = "<div class='rating__stars-filled' style='width:20%; '></div>";
    //                        ltSao3.Text = "<div class='rating__stars-filled' style='width:20%; '></div>";
    //                    }
    //                    else if(DanhGiaTB >= 1.5 && DanhGiaTB< 2)
    //                    {
    //                        ltDanhGiaTB.Text = " 1.5 / 5.0";
    //                        ltSao.Text = "<div class='rating__stars-filled' style='width:30%; '></div>";
    //                        ltSao3.Text = "<div class='rating__stars-filled' style='width:30%; '></div>";
    //                    }
    //                    else if(DanhGiaTB >= 2 && DanhGiaTB <2.5)
    //                    {
    //                        ltDanhGiaTB.Text = " 2.0 / 5.0";
    //                        ltSao.Text = "<div class='rating__stars-filled' style='width:40%; '></div>";
    //                        ltSao3.Text = "<div class='rating__stars-filled' style='width:40%; '></div>";
    //                    }
    //                    else if (DanhGiaTB >= 2.5 && DanhGiaTB < 3)
    //                    {
    //                        ltDanhGiaTB.Text = " 2.5 / 5.0";
    //                        ltSao.Text = "<div class='rating__stars-filled' style='width:50%; '></div>";
    //                    }
    //                    else if (DanhGiaTB >= 3 && DanhGiaTB <3.5)
    //                    {
    //                        ltDanhGiaTB.Text = " 3.0 / 5.0";
    //                        ltSao.Text = "<div class='rating__stars-filled' style='width:60%; '></div>";
    //                        ltSao3.Text = "<div class='rating__stars-filled' style='width:60%; '></div>";
    //                    }
    //                    else if (DanhGiaTB >= 3.5 && DanhGiaTB <4)
    //                    {
    //                        ltDanhGiaTB.Text = " 3.5 / 5.0";
    //                        ltSao.Text = "<div class='rating__stars-filled' style='width:70%; '></div>";
    //                        ltSao3.Text = "<div class='rating__stars-filled' style='width:70%; '></div>";
    //                    }
    //                    else if (DanhGiaTB >= 4 && DanhGiaTB <4.5)
    //                    {
    //                        ltDanhGiaTB.Text = " 4.0 / 5.0";
    //                        ltSao.Text = "<div class='rating__stars-filled' style='width:80%; '></div>";
    //                        ltSao3.Text = "<div class='rating__stars-filled' style='width:80%; '></div>";
    //                    }
    //                    else if (DanhGiaTB == 4.5 && DanhGiaTB < 5)
    //                    {
    //                        ltDanhGiaTB.Text = " 4.5 / 5.0";
    //                        ltSao.Text = "<div class='rating__stars-filled' style='width:90%; '></div>";
    //                        ltSao3.Text = "<div class='rating__stars-filled' style='width:90%; '></div>";
    //                    }
    //                    else if (DanhGiaTB == 5)
    //                    {
    //                        ltDanhGiaTB.Text = " 5.0 / 5.0";
    //                        ltSao.Text = "<div class='rating__stars-filled' style='width:100%; '></div>";
    //                        ltSao3.Text = "<div class='rating__stars-filled' style='width:100%; '></div>";
    //                    }
    //                }
    //            }
    //        }
    //        else
    //        {
    //            Response.Redirect("/404");
    //        }
    //    }

    //    protected void btnCmt_Click(object sender, EventArgs e)
    //    {
    //        if (Session["username"] == null)
    //        {
    //            Response.Redirect("/Login");
    //        }
    //        else
    //        {
    //            cmtView.ActiveViewIndex = 1;
                
    //        }
            
    //    }
    //    public int PageNumber
    //    {
    //        get
    //        {
    //            if (ViewState["PageNumber"] != null)
    //                return Convert.ToInt32(ViewState["PageNumber"]);
    //            else
    //                return 0;
    //        }
    //        set
    //        {
    //            ViewState["PageNumber"] = value;
    //        }
    //    }
    //    protected void btnPrev_Click(object sender, EventArgs e)
    //    {
    //        PageNumber = PageNumber - 1;
    //        LoadData();
            
    //    }

    //    protected void btnNext_Click(object sender, EventArgs e)
    //    {
    //        PageNumber = PageNumber + 1;
    //        LoadData();
            
    //    }

    //    protected void btnGui_Click(object sender, EventArgs e)
    //    {
    //        string sosaoCSS = "";
    //        if (txtDanhGia.Text.Trim() == "1")
    //        {
    //            sosaoCSS = "style=width:20%;";
    //        }
    //        else if(txtDanhGia.Text.Trim() == "2")
    //        {
    //            sosaoCSS = "style=width:40%;";
    //        }
    //        else if (txtDanhGia.Text.Trim() == "3")
    //        {
    //            sosaoCSS = "style=width:60%;";
    //        }
    //        else if (txtDanhGia.Text.Trim() == "4")
    //        {
    //            sosaoCSS = "style=width:80%;";
    //        }
    //        else if (txtDanhGia.Text.Trim() == "5")
    //        {
    //            sosaoCSS = "style=width:100%;";
    //        }
    //        DataTable dtUser = new DataTable();
    //        dtUser = _quanlytaikhoan.timAccountTheoTen(Session["email"].ToString());
    //        if(dtUser.Rows.Count > 0)
    //        {
    //            if (!string.IsNullOrEmpty(txtNoiDung.Text.Trim()))
    //            {
    //                code = Page.RouteData.Values["code"] as string;
    //                _quanlysanpham.InsertDanhGia(txtNoiDung.Text.Trim(), int.Parse(txtDanhGia.Text.Trim()), sosaoCSS, DateTime.Now, int.Parse(dtUser.Rows[0]["ID"].ToString()), code, true);
    //            }

    //            Response.Redirect(Request.Url.ToString());
    //        }

           
    //    }

    //    protected void addCart_Click(object sender, EventArgs e)
    //    {
    //        if (!string.IsNullOrEmpty(txtSize.Text.Trim()))
    //        {
    //            code = Page.RouteData.Values["code"] as string;
    //            string danhmuc = Page.RouteData.Values["danhmuc"] as string;
    //            int soluong = 0;
    //            DataTable dtSize = new DataTable();
    //            dtSize = _quanlysanpham.TimSizeSanPham(code, txtSize.Text.Trim());
    //            if(dtSize.Rows.Count > 0)
    //            {
    //                int temp = int.Parse(dtSize.Rows[0]["SoLuong"].ToString()) - int.Parse(txtSoLuong.Text.Trim());
    //                if (temp >= 0)
    //                {
    //                    string size = txtSize.Text.Trim();
    //                    soluong = soluong + int.Parse(txtSoLuong.Text.Trim());
    //                    string url = Request.Url.AbsoluteUri;
    //                    _cart.ShoppingCart_addCart(code, url, soluong, size, "", "", "", "", danhmuc, "");
    //                    Response.Redirect(Request.Url.ToString());

    //                }
    //                else
    //                {
    //                    ltThongBao.Text = "Size của sản phẩm này trong kho đã hết, quý khách vui lòng chọn size khác hoặc mẫu khác!!";
    //                }
    //            }
    //            else
    //            {
    //                ltThongBao.Text = "Vui lòng nhập lại size, vì sản phẩm không có size vừa nhập !!";
    //            }
    //        }
    //        else
    //        {
    //            ltThongBao.Text = "Vui lòng nhập size sản phẩm";
    //        }

    //    }
    }
}