using Facebook;
using nguyeensport.dal;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace nguyeensport.admin
{
    public partial class quanlyphukien : System.Web.UI.UserControl
    {
        clsquanlyproduct _quanlyproduct = new clsquanlyproduct();
        clsquanlyphukien _quanlyphukien = new clsquanlyphukien();
        clsquanlyproducttype _quanlyproducttype = new clsquanlyproducttype();
        clsquanlybrands _quanlybrands = new clsquanlybrands();
        clsquanlycolor _quanlycolor = new clsquanlycolor();
       
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        void LoadData()
        {
            rptListProduct.DataSource = _quanlyphukien.layPhuKien();
            rptListProduct.DataBind();

            //v2
            cbkActive.InputAttributes.Add("class", "custom-control-input");
            cbkActive.LabelAttributes.Add("class", "custom-control-label");
            cbkHienThi.InputAttributes.Add("class", "custom-control-input");
            cbkHienThi.LabelAttributes.Add("class", "custom-control-label");

        }
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            hdInsert.Value = "insert";
            mlv.ActiveViewIndex = 1;
            //LoadData();
        }

        protected void rptListProduct_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                HiddenField hdIDSanPham = e.Item.FindControl("idSanPham") as HiddenField;
                Label lblDiscount = e.Item.FindControl("lblDiscount") as Label;
                Label lblSaving = e.Item.FindControl("lblSaving") as Label;
                CheckBox cbkHienThi = e.Item.FindControl("cbkHienThi") as CheckBox;
                cbkHienThi.InputAttributes.Add("class", "custom-control-input");
                cbkHienThi.LabelAttributes.Add("class", "custom-control-label");
                cbkHienThi.InputAttributes.Add("Value", hdIDSanPham.Value.ToString());
                CheckBox cbkActive = e.Item.FindControl("cbkActive") as CheckBox;
                cbkActive.InputAttributes.Add("class", "custom-control-input");
                cbkActive.LabelAttributes.Add("class", "custom-control-label");
                cbkActive.InputAttributes.Add("Value", hdIDSanPham.Value.ToString());
                if (cbkHienThi.Text == "True")
                {
                    cbkHienThi.Checked = true;
                }
                else
                {
                    cbkHienThi.Checked = false;
                }
                if (cbkActive.Text == "True")
                {
                    cbkActive.Checked = true;
                }
                else
                {
                    cbkActive.Checked = false;
                }
                HiddenField maSanPham = e.Item.FindControl("maSanPham") as HiddenField;
                Literal ltTongSoLuong = e.Item.FindControl("ltTongSoLuong") as Literal;
                Repeater rptProductSize = e.Item.FindControl("rptProductSize") as Repeater;
                DataTable dtProductSize = new DataTable();
                dtProductSize = clsquanlyproduct.laySizeOfProduct(maSanPham.Value.ToString());
                if (dtProductSize.Rows.Count > 0)
                {
                    int tong = 0;
                    for (int i = 0; i < dtProductSize.Rows.Count; i++)
                    {
                        tong += int.Parse(dtProductSize.Rows[i]["soLuong"].ToString());
                    }
                    ltTongSoLuong.Text = tong.ToString() + " sản phẩm";
                    rptProductSize.DataSource = dtProductSize;
                    rptProductSize.DataBind();

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

                    lblSaving.CssClass = "text-danger";
                }


            }
        }

        protected void btnThemSize_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTenSize.Text.Trim()))
            {
                if (!string.IsNullOrEmpty(txtSoLuong.Text.Trim()))
                {
                    //_quanlyproduct.ProductSize_addSize(txtTenSize.Text.Trim(), int.Parse(txtSoLuong.Text.Trim()));
                    lblThongBao.Text = "Thêm thành công";
                    lblThongBao.CssClass = "valid-feedback mr-3";
                    DataTable dtSize = new DataTable();
                    dtSize = (DataTable)Session["productsize"];
                    rptListSize.DataSource = dtSize;
                    rptListSize.DataBind();
                    UpdatePanel.Update();
                    UpdatePanel1.Update();
                }
                else
                {
                    lblThongBao.Text = "Vui lòng nhập số lượng size";
                    txtSoLuong.CssClass = "form-control form-control-sm is-invalid";
                    lblThongBao.CssClass = "invalid-feedback mr-3";
                    lblThongBao.Visible = true;
                    UploadTxtSoLuong.Update();
                    UpdatePanel1.Update();
                }

            }
            else
            {
                lblThongBao.Text = "Vui lòng nhập tên size";
                txtTenSize.CssClass = "form-control form-control-sm is-invalid";
                lblThongBao.CssClass = "invalid-feedback mr-3";
                lblThongBao.Visible = true;
                UploadTxtTenSize.Update();
                UpdatePanel1.Update();
            }
        }

        protected void btnXoa_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = (DataTable)Session["productsize"];
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    if (!string.IsNullOrEmpty(txtTenSize.Text.Trim()))
                    {
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            if (txtTenSize.Text.Trim() == dt.Rows[i]["tenSize"].ToString())
                            {
                               // _quanlyproduct.ProductSize_RemoveSize(txtTenSize.Text.Trim());
                                lblThongBao.Text = "Xóa thành công";
                                lblThongBao.CssClass = "valid-feedback mr-3";
                                DataTable dtSize = new DataTable();
                                dtSize = (DataTable)Session["productsize"];
                                rptListSize.DataSource = dtSize;
                                rptListSize.DataBind();
                                UpdatePanel.Update();
                                UpdatePanel1.Update();
                            }
                            else
                            {
                                lblThongBao.Text = "Chưa có size trên bảng size";
                                lblThongBao.CssClass = "invalid-feedback mr-3";
                                lblThongBao.Visible = true;
                                DataTable dtSize = new DataTable();
                                dtSize = (DataTable)Session["productsize"];
                                rptListSize.DataSource = dtSize;
                                rptListSize.DataBind();
                                UpdatePanel.Update();
                                UpdatePanel1.Update();
                            }

                        }
                    }
                    else
                    {
                        lblThongBao.Text = "Vui lòng nhập tên size để xóa";
                        txtTenSize.CssClass = "form-control form-control-sm is-invalid";
                        lblThongBao.CssClass = "invalid-feedback mr-3";
                        lblThongBao.Visible = true;
                        DataTable dtSize = new DataTable();
                        dtSize = (DataTable)Session["productsize"];
                        rptListSize.DataSource = dtSize;
                        rptListSize.DataBind();
                        UploadTxtTenSize.Update();
                        UpdatePanel.Update();
                        UpdatePanel1.Update();
                    }

                }
                else
                {
                    lblThongBao.Text = "Bảng size không tìm thấy dòng nào trong bảng";
                    lblThongBao.CssClass = "invalid-feedback mr-3";
                    lblThongBao.Visible = true;
                    UpdatePanel1.Update();
                }
            }
            else
            {
                lblThongBao.Text = "Bảng size không tồn tại";
                lblThongBao.CssClass = "invalid-feedback mr-3";
                lblThongBao.Visible = true;
                UpdatePanel1.Update();
            }
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            mlv.ActiveViewIndex = 0;
            LoadData();
        }
        public static string utf8Convert3(string s)
        {
            Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string temp = s.Normalize(NormalizationForm.FormD);
            return regex.Replace(temp, string.Empty).Replace('\u0111', 'd').Replace('\u0111', 'D');
        }
        protected void btnUpdate_Click(object sender, EventArgs e)
        {

          
            String image1 = hdImage1.Value;
            String image2 = hdImage2.Value;
            String image3 = hdImage3.Value;
            String image4 = hdImage4.Value;
            String image5 = hdImage5.Value;
            String image6 = hdImage6.Value;
            String image7 = hdImage7.Value;
            String image8 = hdImage8.Value;
            String image9 = hdImage9.Value;
            String image10 = hdImage10.Value;
            String path = "";
            HttpFileCollection hfc = Request.Files;
            for (int i = 0; i < hfc.Count; i++)
            {
                HttpPostedFile hpf = hfc[i];
                if (hpf.ContentLength > 0)
                {
                    path = utf8Convert3(txtTenSanPham.Text).ToLower().Replace(" ", "-").Replace("/", "-") + "-" + i;
                    if (i == 0)
                    {
                        image1 = clsThuVien.uploadImage(path, hpf);
                    }
                    if (i == 1)
                    {
                        image2 = clsThuVien.uploadImage(path, hpf);
                    }
                    if (i == 2)
                    {
                        image3 = clsThuVien.uploadImage(path, hpf);
                    }
                    if (i == 3)
                    {
                        image4 = clsThuVien.uploadImage(path, hpf);
                    }
                    if (i == 4)
                    {
                        image5 = clsThuVien.uploadImage(path, hpf);
                    }
                    if (i == 5)
                    {
                        image6 = clsThuVien.uploadImage(path, hpf);
                    }
                    if (i == 6)
                    {
                        image7 = clsThuVien.uploadImage(path, hpf);
                    }
                    if (i == 7)
                    {
                        image8 = clsThuVien.uploadImage(path, hpf);
                    }
                    if (i == 8)
                    {
                        image9 = clsThuVien.uploadImage(path, hpf);
                    }
                    if (i == 9)
                    {
                        image10 = clsThuVien.uploadImage(path, hpf);
                    }

                }
            }
          
            if (!string.IsNullOrEmpty(txtMaSanPham.Text.Trim()))
            {
                try
                {
                    bool Active = cbkActive.Checked ? true : false;
                    bool hienThi = cbkHienThi.Checked ? true : false;
                    float giaOutput = float.Parse(txtGia.Text.Trim()) - (float.Parse(txtGia.Text.Trim()) * float.Parse(drDiscount.SelectedValue.ToString()));
                    if (hdInsert.Value.ToString() == "insert")
                    {
                        string id = "";
                        try
                        {
                            var client = new FacebookClient("EAABsbCS1iHgBANNncdQwHQ4HZA7urzAgb6lXk6OmKO40e84yhqIAXQZBiotXprZBehsh2bi28UaYad9ZBUDg1EfsEhVQ8mFVqZB32CIYOzumNZCtpLu2bBaJRt6xiORWWtWMGM7vOn8kbk9fJuRIZC501YH5OYZCK9SvUUBUkffEQjZBk4hgct6Bi0c2EhdVPhOQZD");
                            client.Post("1649023352043081/feed", new { message = txtTenSanPham.Text });
                            dynamic d = client.Get("1649023352043081/feed", new { fields = "id", limit = "1" });
                            id = d.data[0].id;
                        }
                        catch (Exception ex)
                        {
                            id = "";
                        }

                        clsquanlyproduct.insertProduct(id,txtMaSanPham.Text.Trim(), txtTenSanPham.Text.Trim(), htmlEditor.Html.ToString(), float.Parse(txtGia.Text.Trim()), drDiscount.SelectedItem.ToString(), giaOutput, 4, txtTitle.Text.Trim(), txtMetaDescription.Text.Trim(), txtMetaKeywork.Text.Trim(), utf8Convert3(txtTenSanPham.Text.Trim()).ToLower().Replace(" ", "-"), image1, image2, image3, image4, image5, image6, image7, image8, image9, image10, 0, 0, DateTime.Now, hienThi, Active);
                        _quanlyphukien.insertPhuKien(txtMaSanPham.Text.Trim(), txtProductType.Text.Trim(), txtdrSubType.Text.Trim(), txtBrands.Text.Trim(), txtColor.Text.Trim());
                        DataTable dtSizeOFProduct = new DataTable();
                        dtSizeOFProduct = clsquanlyproduct.laySizeOfProduct(txtMaSanPham.Text.Trim());
                        if (dtSizeOFProduct.Rows.Count <= 0)
                        {
                            if (Session["productsize"] != null)
                            {
                                DataTable dtSzie = new DataTable();
                                dtSzie = (DataTable)Session["productsize"];
                                if (dtSzie.Rows.Count > 0)
                                {
                                    for (int i = 0; i < dtSzie.Rows.Count; i++)
                                    {
                                        clsquanlyproduct.insertProductSize(txtMaSanPham.Text.Trim(), dtSzie.Rows[i]["tenSize"].ToString(), int.Parse(dtSzie.Rows[i]["soLuong"].ToString()));
                                    }
                                }
                                dtSzie = null;
                                Session["productsize"] = dtSzie;
                            }
                            else
                            {
                                lblThongBao.Text = "Bảng size không tồn tại";
                                lblThongBao.CssClass = "invalid-feedback mr-3";
                                lblThongBao.Visible = true;
                            }
                        }
                        else
                        {
                            lblThongBao.Text = "Size của sản phẩm đã tồn tại";
                            lblThongBao.CssClass = "invalid-feedback mr-3";
                            lblThongBao.Visible = true;
                        }
                        lblThongBao2.Text = "<div class='alert alert-success alert-dismissible fade show' role='alert'>" +
                                            "Thêm thành công" +
                                "<button type='button' class='close' data-dismiss='alert' aria-label='Close'>" +
                                "<span aria-hidden='true'>&times;</span>" +
                                "</button>" +
                            "</div>";
                    }
                    else
                    {
                        try
                        {
                            var client = new FacebookClient("EAABsbCS1iHgBANNncdQwHQ4HZA7urzAgb6lXk6OmKO40e84yhqIAXQZBiotXprZBehsh2bi28UaYad9ZBUDg1EfsEhVQ8mFVqZB32CIYOzumNZCtpLu2bBaJRt6xiORWWtWMGM7vOn8kbk9fJuRIZC501YH5OYZCK9SvUUBUkffEQjZBk4hgct6Bi0c2EhdVPhOQZD");
                            //dynamic d = client.Get("me/accounts", new { fields = "id" });
                            //string id = d.data[2].id;

                            client.Post("" + hdId_FB.Value + "/", new { message = txtTenSanPham.Text });
                        }
                        catch (Exception ex)
                        {

                        }
                        clsquanlyproduct.updateProduct(txtMaSanPham.Text.Trim(), txtTenSanPham.Text.Trim(), htmlEditor.Html.ToString(), float.Parse(txtGia.Text.Trim()), drDiscount.SelectedItem.ToString(), giaOutput, 1, txtTitle.Text.Trim(), txtMetaDescription.Text.Trim(), txtMetaKeywork.Text.Trim(), utf8Convert3(txtTenSanPham.Text.Trim()).ToLower().Replace(" ", "-"), image1, image2, image3, image4, image5, image6, image7, image8, image9, image10, DateTime.Now, hienThi, Active);
                        _quanlyphukien.updatePhuKien(txtMaSanPham.Text.Trim(), txtProductType.Text.Trim(), txtdrSubType.Text.Trim(), txtBrands.Text.Trim(), txtColor.Text.Trim());
                        DataTable dtSzie = new DataTable();
                        dtSzie = (DataTable)Session["productsize"];
                        if (dtSzie.Rows.Count > 0)
                        {
                            for (int i = 0; i < dtSzie.Rows.Count; i++)
                            {
                                clsquanlyproduct.updateProductSize(txtMaSanPham.Text.Trim(), dtSzie.Rows[i]["tenSize"].ToString(), int.Parse(dtSzie.Rows[i]["soLuong"].ToString()));
                            }
                        }
                        dtSzie = null;
                        Session["productsize"] = dtSzie;
                        lblThongBao2.Text = "<div class='alert alert-success alert-dismissible fade show' role='alert'>" +
                                           "Sửa thành công" +
                               "<button type='button' class='close' data-dismiss='alert' aria-label='Close'>" +
                               "<span aria-hidden='true'>&times;</span>" +
                               "</button>" +
                           "</div>";
                    }
                }
                catch(Exception ex)
                {
                    lblThongBao2.Text = "<div class='alert alert-warning alert-dismissible fade show' role='alert'>" +
                                       ex.ToString() +
                           "<button type='button' class='close' data-dismiss='alert' aria-label='Close'>" +
                           "<span aria-hidden='true'>&times;</span>" +
                           "</button>" +
                       "</div>";
                }
             
            }
            else
            {
                txtMaSanPham.CssClass = "form-control is-invalid";
                lblThongBao2.Text = "<div class='alert alert-warning alert-dismissible fade show' role='alert'>" +
                                         "Vui lòng nhập mã sản phẩm" +
                              "<button type='button' class='close' data-dismiss='alert' aria-label='Close'>" +
                              "<span aria-hidden='true'>&times;</span>" +
                              "</button>" +
                          "</div>";
            }

        }

        protected void btnXoa_Load(object sender, EventArgs e)
        {
            ((LinkButton)sender).Attributes["onclick"] = "return confirm('Bạn có muốn xóa dòng này không ?')";
        }

        protected void rptListProduct_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            DataTable dtPhuKien = new DataTable();
            dtPhuKien = _quanlyphukien.layPhuKienTheoID(e.CommandArgument.ToString());
            switch (e.CommandName)
            {
                case "update":

                    if (dtPhuKien.Rows.Count > 0)
                    {
                        txtMaSanPham.Text = dtPhuKien.Rows[0]["maSanPham"].ToString();
                        txtTenSanPham.Text = dtPhuKien.Rows[0]["tenSanPham"].ToString();
                        txtTitle.Text = dtPhuKien.Rows[0]["titleSanPham"].ToString();
                        txtMetaDescription.Text = dtPhuKien.Rows[0]["metaDescriptionSanPham"].ToString();
                        txtMetaKeywork.Text = dtPhuKien.Rows[0]["metaKeywordsSanPham"].ToString();
                        htmlEditor.Html = dtPhuKien.Rows[0]["motaSanPham"].ToString();
                        txtGia.Text = dtPhuKien.Rows[0]["giaInput"].ToString();
                        cbkActive.Checked = ((bool)dtPhuKien.Rows[0]["Active"]) ? true : false;
                        cbkHienThi.Checked = ((bool)dtPhuKien.Rows[0]["hienThi"]) ? true : false;
                        hdImage1.Value = dtPhuKien.Rows[0]["avatarSanPham"].ToString();
                        hdImage2.Value = dtPhuKien.Rows[0]["anh1"].ToString();
                        hdImage3.Value = dtPhuKien.Rows[0]["anh2"].ToString();
                        hdImage4.Value = dtPhuKien.Rows[0]["anh3"].ToString();
                        hdImage5.Value = dtPhuKien.Rows[0]["anh4"].ToString();
                        hdImage6.Value = dtPhuKien.Rows[0]["anh5"].ToString();
                        hdImage7.Value = dtPhuKien.Rows[0]["anh6"].ToString();
                        hdImage8.Value = dtPhuKien.Rows[0]["anh7"].ToString();
                        hdImage9.Value = dtPhuKien.Rows[0]["anh8"].ToString();
                        hdImage10.Value = dtPhuKien.Rows[0]["anh9"].ToString();
                        DataTable dtProductSize = new DataTable();
                        dtProductSize = clsquanlyproduct.layProductSizeTheoMaSanPham(dtPhuKien.Rows[0]["maSanPham"].ToString());
                        Session["productsize"] = dtProductSize;
                        rptListSize.DataSource = dtProductSize;
                        rptListSize.DataBind();
                        hdInsert.Value = "update";
                        hdId_FB.Value = dtPhuKien.Rows[0]["id_FB"].ToString();
                        mlv.ActiveViewIndex = 1;
                    }
                    break;
                case "delete":

                    if (dtPhuKien.Rows.Count > 0)
                    {
                        if (dtPhuKien.Rows[0]["avatarSanPham"].ToString().Length > 0)
                        {

                            clsThuVien.deleteImage(dtPhuKien.Rows[0]["avatarSanPham"].ToString().Substring(52).Replace(".jpg", "").Replace(".png", ""));
                        }
                        if (dtPhuKien.Rows[0]["anh1"].ToString().Length > 0)
                        {
                            clsThuVien.deleteImage(dtPhuKien.Rows[0]["anh1"].ToString().Substring(52).Replace(".jpg", "").Replace(".png", ""));
                        }
                        if (dtPhuKien.Rows[0]["anh2"].ToString().Length > 0)
                        {
                            clsThuVien.deleteImage(dtPhuKien.Rows[0]["anh2"].ToString().Substring(52).Replace(".jpg", "").Replace(".png", ""));
                        }
                        if (dtPhuKien.Rows[0]["anh3"].ToString().Length > 0)
                        {
                            clsThuVien.deleteImage(dtPhuKien.Rows[0]["anh3"].ToString().Substring(52).Replace(".jpg", "").Replace(".png", ""));
                        }
                        if (dtPhuKien.Rows[0]["anh4"].ToString().Length > 0)
                        {
                            clsThuVien.deleteImage(dtPhuKien.Rows[0]["anh4"].ToString().Substring(52).Replace(".jpg", "").Replace(".png", ""));
                        }
                        if (dtPhuKien.Rows[0]["anh5"].ToString().Length > 0)
                        {
                            clsThuVien.deleteImage(dtPhuKien.Rows[0]["anh5"].ToString().Substring(52).Replace(".jpg", "").Replace(".png", ""));
                        }
                        if (dtPhuKien.Rows[0]["anh6"].ToString().Length > 0)
                        {
                            clsThuVien.deleteImage(dtPhuKien.Rows[0]["anh6"].ToString().Substring(52).Replace(".jpg", "").Replace(".png", ""));
                        }
                        if (dtPhuKien.Rows[0]["anh7"].ToString().Length > 0)
                        {
                            clsThuVien.deleteImage(dtPhuKien.Rows[0]["anh7"].ToString().Substring(52).Replace(".jpg", "").Replace(".png", ""));
                        }
                        if (dtPhuKien.Rows[0]["anh8"].ToString().Length > 0)
                        {
                            clsThuVien.deleteImage(dtPhuKien.Rows[0]["anh8"].ToString().Substring(52).Replace(".jpg", "").Replace(".png", ""));
                        }
                        if (dtPhuKien.Rows[0]["anh9"].ToString().Length > 0)
                        {
                            clsThuVien.deleteImage(dtPhuKien.Rows[0]["anh9"].ToString().Substring(52).Replace(".jpg", "").Replace(".png", ""));
                        }
                        clsquanlyproduct.deleteProductSize(dtPhuKien.Rows[0]["maSanPham"].ToString());
                        _quanlyphukien.deletePhuKien(dtPhuKien.Rows[0]["maSanPham"].ToString());
                        clsquanlyproduct.deleteProduct(dtPhuKien.Rows[0]["maSanPham"].ToString());
                        LoadData();
                    }
                    break;
            }
        }
        protected void cbkHienThi_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                CheckBox cbkHienThi = sender as CheckBox;
                Boolean itemState = cbkHienThi.Checked;
                Int32 itemID = Int32.Parse(cbkHienThi.InputAttributes["Value"].ToString());
                clsThuVien.updateHienThi("Product", "id", itemID, itemState);
                LoadData();

            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        protected void cbkHienThi_Load(object sender, EventArgs e)
        {
            ((CheckBox)sender).Attributes["onclick"] = "javascript:ShowProgressBar()";
        }

        protected void cbkActive_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                CheckBox cbkActive = sender as CheckBox;
                Boolean itemState = cbkActive.Checked;
                Int32 itemID = Int32.Parse(cbkActive.InputAttributes["Value"].ToString());
                clsThuVien.updateActive("Product", "id", itemID, itemState);
                LoadData();

            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        protected void cbkActive_Load(object sender, EventArgs e)
        {
            ((CheckBox)sender).Attributes["onclick"] = "javascript:ShowProgressBar()";
        }
    }
}