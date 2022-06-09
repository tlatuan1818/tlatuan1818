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
    public partial class productfanshop : System.Web.UI.UserControl
    {
        //clsquanlysanpham _quanlysanpham = new clsquanlysanpham();
        //clsCart _clsCart = new clsCart();
        //clsfanshop _fanshop = new clsfanshop();
        //clsquanlytaikhoan _quanlytaikhoan = new clsquanlytaikhoan();
        //protected string code = "";
        //protected void Page_Load(object sender, EventArgs e)
        //{
        //    if (!IsPostBack)
        //    {
        //        LoadData();
        //    }
                
        //}
        //void LoadData()
        //{
        //    code = Page.RouteData.Values["code"] as string;
        //    if (code != null)
        //    {
        //        DataTable dtSanPham = new DataTable();
        //        dtSanPham = _quanlysanpham.timAoTheoID(code);
        //        if (dtSanPham.Rows.Count > 0)
        //        {
        //            ltTenSanPham.Text = "<a class='breadcrumbs__link' href='/" + dtSanPham.Rows[0]["DanhMuc"].ToString() + "/" + dtSanPham.Rows[0]["Link"].ToString() + "-" + dtSanPham.Rows[0]["ID"].ToString() + "'>" +
        //                                    "<span class='breadcrumbs__name'>" +
        //                                        dtSanPham.Rows[0]["TenSanPham"].ToString() +
        //                                    "</span>" +
        //                                 "</a>";
        //            if (dtSanPham.Rows[0]["Image1"].ToString() != "")
        //            {
        //                ltImage1.Text = "<div class='gallery-nav-box is-active' onclick='changeImage(this)'>" +
        //                                    "<img src='/" + dtSanPham.Rows[0]["Image1"].ToString() + "' alt ='" + dtSanPham.Rows[0]["TenSanPham"].ToString() + "' />" +
        //                                "</div>";
        //            }
        //            else
        //            {
        //                ltImage1.Text = "";
        //            }
        //            if (dtSanPham.Rows[0]["Image2"].ToString() != "")
        //            {
        //                ltImage2.Text = "<div class='gallery-nav-box' onclick='changeImage(this)'>" +
        //                                "<img src='/" + dtSanPham.Rows[0]["Image2"].ToString() + "' alt ='" + dtSanPham.Rows[0]["TenSanPham"].ToString() + "' />" +
        //                            "</div>";
        //            }
        //            else
        //            {
        //                ltImage2.Text = "";
        //            }

        //            if (dtSanPham.Rows[0]["Image3"].ToString() != "")
        //            {
        //                ltImage3.Text = "<div class='gallery-nav-box' onclick='changeImage(this)'>" +
        //                                "<img src='/" + dtSanPham.Rows[0]["Image3"].ToString() + "' alt ='" + dtSanPham.Rows[0]["TenSanPham"].ToString() + "' />" +
        //                            "</div>";
        //            }
        //            else
        //            {
        //                ltImage3.Text = "";
        //            }

        //            if (dtSanPham.Rows[0]["Image4"].ToString() != "")
        //            {
        //                ltImage4.Text = "<div class='gallery-nav-box' onclick='changeImage(this)'>" +
        //                               "<img src='/" + dtSanPham.Rows[0]["Image4"].ToString() + "' alt ='" + dtSanPham.Rows[0]["TenSanPham"].ToString() + "' />" +
        //                           "</div>";
        //            }
        //            else
        //            {
        //                ltImage4.Text = "";
        //            }

        //            if (dtSanPham.Rows[0]["Image5"].ToString() != "")
        //            {
        //                ltImage5.Text = "<div class='gallery-nav-box' onclick='changeImage(this)'>" +
        //                                "<img src='/" + dtSanPham.Rows[0]["Image5"].ToString() + "' alt ='" + dtSanPham.Rows[0]["TenSanPham"].ToString() + "' />" +
        //                            "</div>";
        //            }
        //            else
        //            {
        //                ltImage5.Text = "";
        //            }

        //            if (dtSanPham.Rows[0]["Image6"].ToString() != "")
        //            {
        //                ltImage6.Text = "<div class='gallery-nav-box' onclick='changeImage(this)'>" +
        //                                "<img src='/" + dtSanPham.Rows[0]["Image6"].ToString() + "' alt ='" + dtSanPham.Rows[0]["TenSanPham"].ToString() + "' />" +
        //                            "</div>";
        //            }
        //            else
        //            {
        //                ltImage6.Text = "";
        //            }

        //            if (dtSanPham.Rows[0]["Image7"].ToString() != "")
        //            {
        //                ltImage7.Text = "<div class='gallery-nav-box' onclick='changeImage(this)'>" +
        //                               "<img src='/" + dtSanPham.Rows[0]["Image7"].ToString() + "' alt ='" + dtSanPham.Rows[0]["TenSanPham"].ToString() + "' />" +
        //                           "</div>";
        //            }
        //            else
        //            {
        //                ltImage7.Text = "";
        //            }
        //            //if (dtSanPham.Rows[0]["Image8"].ToString() != "")
        //            //{
        //            //    ltImage8.Text = "<img src='/" + dtSanPham.Rows[0]["Image1"].ToString() + "' alt='" + dtSanPham.Rows[0]["TenSanPham"].ToString() + "' class='is-bg-active'>";
        //            //}
        //            //else
        //            //{
        //            //    ltImage8.Text = "";
        //            //}
        //            ltTenSanPham2.Text = "<h1 class='gallery-content_title'>" +
        //                                    dtSanPham.Rows[0]["TenSanPham"].ToString() +
        //                                    "<span class='product-title__colorway'>" +
        //                                      dtSanPham.Rows[0]["Version"].ToString() +
        //                                    "</span>" +
        //                                "</h1>";
        //            if (dtSanPham.Rows[0]["GiaGiam"].ToString() == "0")
        //            {
        //                ltGiaCuoi.Text = "<span class='product-prices_item'>" + string.Format("{0:N0}", dtSanPham.Rows[0]["GiaCuoi"]) + " VNĐ</span>";
        //                ltGiaGiam.Text = "";
        //                ltGiaDau.Text = "";
        //            }
        //            else
        //            {
        //                ltGiaCuoi.Text = "<span class='product-prices_item'>" + string.Format("{0:N0}", dtSanPham.Rows[0]["GiaCuoi"]) + " VNĐ</span>";
        //                ltGiaDau.Text = "<span class='product-prices_item product-prices_item--original'>" + string.Format("{0:N0}", dtSanPham.Rows[0]["GiaDau"]) + " VNĐ</span>";
        //                ltGiaGiam.Text = "<span class='product-prices_item product-prices_item--saving'>Giảm " + string.Format("{0:N0}", dtSanPham.Rows[0]["GiaGiam"]) + "</span>";
        //            }
                    
        //            DataTable dtSize = new DataTable();
        //            dtSize = _quanlysanpham.timSizeTheoID(dtSanPham.Rows[0]["ID"].ToString());

        //            if (dtSize.Rows.Count > 0)
        //            {
        //                foreach (DataRow dr in dtSize.Rows)
        //                {
        //                    if (dr["TenSize"].ToString() == "XS")
        //                    {
        //                        if (int.Parse(dr["SoLuong"].ToString()) > 0)
        //                        {
        //                            ltSizeXS.Text = "<div class='button'>" +
        //                                            "<span class='button__title'>" +
        //                                                  "XS" +
        //                                            "</span>" +
        //                                            "<span class='button__postion'>"+
        //                                                "Số lượng: "+
        //                                                dr["SoLuong"].ToString()+
        //                                            "</span>"+
        //                                     "</div>";
        //                        }
        //                        else
        //                        {
        //                            ltSizeXS.Text = "<div class='button btn-active'>" +
        //                                            "<span class='button__title'>" +
        //                                                  "XS" +
        //                                            "</span>" +
        //                                            "<span class='button__postion'>" +
        //                                                "Số lượng: " +
        //                                                dr["SoLuong"].ToString() +
        //                                            "</span>" +
        //                                     "</div>";
        //                        }
        //                    }
        //                    if (dr["TenSize"].ToString() == "S")
        //                    {
        //                        if (int.Parse(dr["SoLuong"].ToString()) > 0)
        //                        {
        //                            ltSizeS.Text = "<div class='button'>" +
        //                                            "<span class='button__title'>" +
        //                                                  "S" +
        //                                            "</span>" +
        //                                            "<span class='button__postion'>" +
        //                                                "Số lượng: " +
        //                                                dr["SoLuong"].ToString() +
        //                                            "</span>" +
        //                                     "</div>";
        //                        }
        //                        else
        //                        {
        //                            ltSizeS.Text = "<div class='button btn-active'>" +
        //                                            "<span class='button__title'>" +
        //                                                  "S" +
        //                                            "</span>" +
        //                                            "<span class='button__postion'>" +
        //                                                "Số lượng: " +
        //                                                dr["SoLuong"].ToString() +
        //                                            "</span>" +
        //                                     "</div>";
        //                        }
        //                    }
        //                    if (dr["TenSize"].ToString() == "M")
        //                    {
        //                        if (int.Parse(dr["SoLuong"].ToString()) > 0)
        //                        {
        //                            ltSizeM.Text = "<div class='button'>" +
        //                                            "<span class='button__title'>" +
        //                                                  "M" +
        //                                         "</span>" +
        //                                         "<span class='button__postion'>" +
        //                                                "Số lượng: " +
        //                                                dr["SoLuong"].ToString() +
        //                                            "</span>" +
        //                                     "</div>";
        //                        }
        //                        else
        //                        {
        //                            ltSizeM.Text = "<div class='button btn-active'>" +
        //                                            "<span class='button__title'>" +
        //                                                  "M" +
        //                                         "</span>" +
        //                                         "<span class='button__postion'>" +
        //                                                "Số lượng: " +
        //                                                dr["SoLuong"].ToString() +
        //                                            "</span>" +
        //                                     "</div>";
        //                        }
        //                    }
        //                    if (dr["TenSize"].ToString() == "L")
        //                    {
        //                        if (int.Parse(dr["SoLuong"].ToString()) > 0)
        //                        {
        //                            ltSizeL.Text = "<div class='button'>" +
        //                                            "<span class='button__title'>" +
        //                                                  "L" +
        //                                         "</span>" +
        //                                         "<span class='button__postion'>" +
        //                                                "Số lượng: " +
        //                                                dr["SoLuong"].ToString() +
        //                                            "</span>" +
        //                                     "</div>";
        //                        }
        //                        else
        //                        {
        //                            ltSizeL.Text = "<div class='button btn-active'>" +
        //                                            "<span class='button__title'>" +
        //                                                  "L" +
        //                                         "</span>" +
        //                                         "<span class='button__postion'>" +
        //                                                "Số lượng: " +
        //                                                dr["SoLuong"].ToString() +
        //                                            "</span>" +
        //                                     "</div>";
        //                        }
        //                    }
        //                    if (dr["TenSize"].ToString() == "XL")
        //                    {
        //                        if (int.Parse(dr["SoLuong"].ToString()) > 0)
        //                        {
        //                            ltSizeXL.Text = "<div class='button'>" +
        //                                            "<span class='button__title'>" +
        //                                                  "XL" +
        //                                         "</span>" +
        //                                         "<span class='button__postion'>" +
        //                                                "Số lượng: " +
        //                                                dr["SoLuong"].ToString() +
        //                                            "</span>" +
        //                                     "</div>";
        //                        }
        //                        else
        //                        {
        //                            ltSizeXL.Text = "<div class='button btn-active'>" +
        //                                            "<span class='button__title'>" +
        //                                                  "XL" +
        //                                         "</span>" +
        //                                         "<span class='button__postion'>" +
        //                                                "Số lượng: " +
        //                                                dr["SoLuong"].ToString() +
        //                                            "</span>" +
        //                                     "</div>";
        //                        }
        //                    }
        //                    if (dr["TenSize"].ToString() == "2XL")
        //                    {
        //                        if (int.Parse(dr["SoLuong"].ToString()) > 0)
        //                        {
        //                            ltSize2XL.Text = "<div class='button'>" +
        //                                            "<span class='button__title'>" +
        //                                                  "2XL" +
        //                                         "</span>" +
        //                                         "<span class='button__postion'>" +
        //                                                "Số lượng: " +
        //                                                dr["SoLuong"].ToString() +
        //                                            "</span>" +
        //                                     "</div>";
        //                        }
        //                        else
        //                        {
        //                            ltSize2XL.Text = "<div class='button btn-active'>" +
        //                                            "<span class='button__title'>" +
        //                                                  "2XL" +
        //                                         "</span>" +
        //                                         "<span class='button__postion'>" +
        //                                                "Số lượng: " +
        //                                                dr["SoLuong"].ToString() +
        //                                            "</span>" +
        //                                     "</div>";
        //                        }
        //                    }
        //                    if (dr["TenSize"].ToString() == "3XL")
        //                    {
        //                        if (int.Parse(dr["SoLuong"].ToString()) > 0)
        //                        {
        //                            ltSize3XL.Text = "<div class='button'>" +
        //                                            "<span class='button__title'>" +
        //                                                  "3XL" +
        //                                         "</span>" +
        //                                         "<span class='button__postion'>" +
        //                                                "Số lượng: " +
        //                                                dr["SoLuong"].ToString() +
        //                                            "</span>" +
        //                                     "</div>";
        //                        }
        //                        else
        //                        {
        //                            ltSize3XL.Text = "<div class='button btn-active'>" +
        //                                            "<span class='button__title'>" +
        //                                                  "3XL" +
        //                                         "</span>" +
        //                                         "<span class='button__postion'>" +
        //                                                "Số lượng: " +
        //                                                dr["SoLuong"].ToString() +
        //                                            "</span>" +
        //                                     "</div>";
        //                        }
        //                    }
        //                }
        //            }

        //            ltMoTa.Text = "<div class='accordion__content' id='content-one'>" +
        //                          "<div class='product-details'>" +
        //                            "<div class='product-details__description'>" +
        //                                  dtSanPham.Rows[0]["MoTa"].ToString() +
        //                            "</div>" +
        //                            "<ul class='product-details__list'>" +
                                        
        //                                "<li class='product-details__list-item'>" +
        //                                    "<span class='product-details__list-title'>Code: </span>" +
        //                                    "<span class='product-details__list-value'>" + dtSanPham.Rows[0]["ID"].ToString() + "</span>" +
        //                                "</li>" +
        //                            "</ul>" +
        //                        "</div>" +
        //                    "</div>";

        //            rptDeXuat.DataSource = _quanlysanpham.timAoTheoTeam(dtSanPham.Rows[0]["Team"].ToString());
        //            rptDeXuat.DataBind();

        //            rptSanPhamMoi.DataSource = _quanlysanpham.sanPhamKhac(dtSanPham.Rows[0]["ID"].ToString(), int.Parse(dtSanPham.Rows[0]["DanhMuc"].ToString()));
        //            rptSanPhamMoi.DataBind();

        //            DataTable dtComment = new DataTable();
        //            dtComment = _quanlysanpham.layDanhGiaTheoIDSanPham(dtSanPham.Rows[0]["ID"].ToString());
        //            if (dtComment.Rows.Count > 0)
        //            {
        //                PagedDataSource pgitems = new PagedDataSource();
        //                System.Data.DataView dv = new System.Data.DataView(dtComment);
        //                pgitems.DataSource = dv;
        //                pgitems.AllowPaging = true;
        //                pgitems.PageSize = 5;
        //                pgitems.CurrentPageIndex = PageNumber;

        //                if (pgitems.PageCount >= 1)
        //                {
        //                    int trang = PageNumber + 1;
        //                    ltPage.Text = trang.ToString();


        //                    ltTotalPage.Text = pgitems.PageCount.ToString();

        //                }
        //                rptComment.DataSource = pgitems;
        //                rptComment.DataBind();

        //                ltTongBinhLuan.Text = dtComment.Rows.Count.ToString();
        //                ltTongBinhLuan1.Text = dtComment.Rows.Count.ToString();
        //                ltTongBinhLuan2.Text = dtComment.Rows.Count.ToString();
        //                float DanhGiaTB = 0;
        //                int tong = 0;

        //                for (int i = 0; i < dtComment.Rows.Count; i++)
        //                {
        //                    tong = tong + int.Parse(dtComment.Rows[i]["SoSao"].ToString());
        //                }
        //                DanhGiaTB = float.Parse(tong.ToString()) / float.Parse(dtComment.Rows.Count.ToString());

        //                if (DanhGiaTB >= 1 && DanhGiaTB < 1.5)
        //                {
        //                    ltDanhGiaTB.Text = "1.0 / 5.0";
        //                    ltSao.Text = "<div class='rating__stars-filled' style='width:20%; '></div>";
        //                    ltSao3.Text = "<div class='rating__stars-filled' style='width:20%; '></div>";
        //                }
        //                else if (DanhGiaTB >= 1.5 && DanhGiaTB < 2)
        //                {
        //                    ltDanhGiaTB.Text = " 1.5 / 5.0";
        //                    ltSao.Text = "<div class='rating__stars-filled' style='width:30%; '></div>";
        //                    ltSao3.Text = "<div class='rating__stars-filled' style='width:30%; '></div>";
        //                }
        //                else if (DanhGiaTB >= 2 && DanhGiaTB < 2.5)
        //                {
        //                    ltDanhGiaTB.Text = " 2.0 / 5.0";
        //                    ltSao.Text = "<div class='rating__stars-filled' style='width:40%; '></div>";
        //                    ltSao3.Text = "<div class='rating__stars-filled' style='width:40%; '></div>";
        //                }
        //                else if (DanhGiaTB >= 2.5 && DanhGiaTB < 3)
        //                {
        //                    ltDanhGiaTB.Text = " 2.5 / 5.0";
        //                    ltSao.Text = "<div class='rating__stars-filled' style='width:50%; '></div>";
        //                }
        //                else if (DanhGiaTB >= 3 && DanhGiaTB < 3.5)
        //                {
        //                    ltDanhGiaTB.Text = " 3.0 / 5.0";
        //                    ltSao.Text = "<div class='rating__stars-filled' style='width:60%; '></div>";
        //                    ltSao3.Text = "<div class='rating__stars-filled' style='width:60%; '></div>";
        //                }
        //                else if (DanhGiaTB >= 3.5 && DanhGiaTB < 4)
        //                {
        //                    ltDanhGiaTB.Text = " 3.5 / 5.0";
        //                    ltSao.Text = "<div class='rating__stars-filled' style='width:70%; '></div>";
        //                    ltSao3.Text = "<div class='rating__stars-filled' style='width:70%; '></div>";
        //                }
        //                else if (DanhGiaTB >= 4 && DanhGiaTB < 4.5)
        //                {
        //                    ltDanhGiaTB.Text = " 4.0 / 5.0";
        //                    ltSao.Text = "<div class='rating__stars-filled' style='width:80%; '></div>";
        //                    ltSao3.Text = "<div class='rating__stars-filled' style='width:80%; '></div>";
        //                }
        //                else if (DanhGiaTB == 4.5 && DanhGiaTB < 5)
        //                {
        //                    ltDanhGiaTB.Text = " 4.5 / 5.0";
        //                    ltSao.Text = "<div class='rating__stars-filled' style='width:90%; '></div>";
        //                    ltSao3.Text = "<div class='rating__stars-filled' style='width:90%; '></div>";
        //                }
        //                else if (DanhGiaTB == 5)
        //                {
        //                    ltDanhGiaTB.Text = " 5.0 / 5.0";
        //                    ltSao.Text = "<div class='rating__stars-filled' style='width:100%; '></div>";
        //                    ltSao3.Text = "<div class='rating__stars-filled' style='width:100%; '></div>";
        //                }
        //            }
        //        }
        //    }
        //    else
        //    {
        //        Response.Redirect("/404");
        //    }
        //}
        //public int PageNumber
        //{
        //    get
        //    {
        //        if (ViewState["PageNumber"] != null)
        //            return Convert.ToInt32(ViewState["PageNumber"]);
        //        else
        //            return 0;
        //    }
        //    set
        //    {
        //        ViewState["PageNumber"] = value;
        //    }
        //}
        //protected void btnPrev_Click(object sender, EventArgs e)
        //{
        //    PageNumber = PageNumber - 1;
        //    LoadData();
        //}

        //protected void btnNext_Click(object sender, EventArgs e)
        //{
        //    PageNumber = PageNumber + 1;
        //    LoadData();
        //}

        //protected void btnGui_Click(object sender, EventArgs e)
        //{
        //    string sosaoCSS = "";
        //    if (txtDanhGia.Text.Trim() == "1")
        //    {
        //        sosaoCSS = "style=width:20%;";
        //    }
        //    else if (txtDanhGia.Text.Trim() == "2")
        //    {
        //        sosaoCSS = "style=width:40%;";
        //    }
        //    else if (txtDanhGia.Text.Trim() == "3")
        //    {
        //        sosaoCSS = "style=width:60%;";
        //    }
        //    else if (txtDanhGia.Text.Trim() == "4")
        //    {
        //        sosaoCSS = "style=width:80%;";
        //    }
        //    else if (txtDanhGia.Text.Trim() == "5")
        //    {
        //        sosaoCSS = "style=width:100%;";
        //    }
        //    DataTable dtUser = new DataTable();
        //    dtUser = _quanlytaikhoan.timAccountTheoTen(Session["email"].ToString());
        //    if (dtUser.Rows.Count > 0)
        //    {
        //        if (!string.IsNullOrEmpty(txtNoiDung.Text.Trim()))
        //        {
        //            code = Page.RouteData.Values["code"] as string;
        //            _quanlysanpham.InsertDanhGia(txtNoiDung.Text.Trim(), int.Parse(txtDanhGia.Text.Trim()), sosaoCSS, DateTime.Now, int.Parse(dtUser.Rows[0]["ID"].ToString()), code, true);
        //        }

        //        Response.Redirect(Request.Url.ToString());
        //    }
        //}

        //protected void btnCmt_Click(object sender, EventArgs e)
        //{
        //    if (Session["username"] == null)
        //    {
        //        Response.Redirect("/Login");
        //    }
        //    else
        //    {
        //        cmtView.ActiveViewIndex = 1;

        //    }
        //}
        //protected void addCart_Click(object sender, EventArgs e)
        //{
        //    if(!string.IsNullOrEmpty(txtSize.Text.Trim()))
        //    {
        //        code = Page.RouteData.Values["code"] as string;
        //        string danhmuc = Page.RouteData.Values["danhmuc"] as string;
        //        int soluong = 0;
        //        DataTable dtSize = new DataTable();
        //        dtSize = _quanlysanpham.TimSizeSanPham(code, txtSize.Text.Trim());
        //        if(dtSize.Rows.Count >= 0)
        //        {   
        //            int temp = int.Parse(dtSize.Rows[0]["SoLuong"].ToString()) - int.Parse(txtSoLuong.Text.Trim());
        //            if (temp >= 0)
        //            {
        //                string size = txtSize.Text.Trim();
        //                soluong = soluong + int.Parse(txtSoLuong.Text.Trim());
        //                string url = Request.Url.AbsoluteUri;
        //                _clsCart.ShoppingCart_addCart(code, url,soluong, size, txtNameset.Text.Trim(), txtSoAo.Text.Trim(), txtPatchLeft.Text.Trim(), txtPatchRight.Text.Trim(), danhmuc, drKieuIn.SelectedValue.ToString());
        //                if (!string.IsNullOrEmpty(txtNameset.Text.Trim()) && !string.IsNullOrEmpty(txtSoAo.Text.Trim()))
        //                {
        //                    _fanshop.ShoppingCart_addCart(code, txtNameset.Text.Trim(), txtSoAo.Text.Trim(), txtPatchLeft.Text.Trim(), txtPatchRight.Text.Trim(), txtFont.Text.Trim(), drKieuIn.SelectedValue.ToString(), danhmuc);
        //                }

        //                Response.Redirect(Request.Url.ToString());
        //            }
        //            else
        //            {
        //                ltThongBao.Text = "Size của sản phẩm này trong kho đã hết, quý khách vui lòng chọn size khác hoặc mẫu khác!!";
        //            }
        //        }
        //        else
        //        {
        //            ltThongBao.Text = "Vui lòng nhập lại size, vì sản phẩm không có size vừa nhập !!";
        //        }

        //    }
        //    else
        //    {
        //        ltThongBao.Text = "Vui lòng nhập size sản phẩm";
        //    }
        //}

        
    }
}