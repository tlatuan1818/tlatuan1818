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
    public partial class quanlyfootballboots : System.Web.UI.UserControl
    {
        clsquanlyproduct _quanlyproduct = new clsquanlyproduct();
        clsquanlyfootballboots _quanlyfootballboots = new clsquanlyfootballboots();
        clsquanlybrands _quanlybrands = new clsquanlybrands();
        clsquanlycollection _quanlycollection = new clsquanlycollection();
        clsquanlymodel _quanlymodel = new clsquanlymodel();
        clsquanlyage _quanlyage = new clsquanlyage();
        clsquanlygroundtype _quanlygroundtype = new clsquanlygroundtype();
        clsquanlyclass _quanlyclass = new clsquanlyclass();
        clsquanlycolor _quanlycolor = new clsquanlycolor();
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        void LoadData()
        {
            rptListProduct.DataSource = _quanlyfootballboots.layFootballBoots();
            rptListProduct.DataBind();

            //v2
            drAge.DataSource = _quanlyage.layAge();
            drAge.DataValueField = "maAge";
            drAge.DataTextField = "tenAge";
            drAge.DataBind();
            drAge.Items.Insert(0, new ListItem("Chọn đối tượng", "0"));
          
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

     
        protected void btnBack_Click(object sender, EventArgs e)
        {
            mlv.ActiveViewIndex = 0;
            LoadData();
        }
       
        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            var strPath = clsThuVien.getImages(hdImage1.Value, hdImage2.Value, hdImage3.Value, hdImage4.Value, hdImage5.Value, hdImage6.Value, hdImage7.Value, hdImage8.Value, hdImage9.Value, hdImage10.Value, txtTenSanPham.Text.Trim(), "anh-san-pham");

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

                        clsquanlyproduct.insertProduct(id,txtMaSanPham.Text.Trim(), txtTenSanPham.Text.Trim(), htmlEditor.Html.ToString(), float.Parse(txtGia.Text.Trim()), drDiscount.SelectedItem.ToString(), giaOutput, 2, txtTitle.Text.Trim(), txtMetaDescription.Text.Trim(), txtMetaKeywork.Text.Trim(), clsThuVien.utf8Convert3(txtTenSanPham.Text.Trim()).ToLower().Replace(" ", "-"), strPath[0].ToString(), strPath[1].ToString(), strPath[2].ToString(), strPath[3].ToString(), strPath[4].ToString(), strPath[5].ToString(), strPath[6].ToString(), strPath[7].ToString(), strPath[8].ToString(), strPath[9].ToString(), 0, 0, DateTime.Now, hienThi, Active);
                        _quanlyfootballboots.insertFootballBoots(txtMaSanPham.Text.Trim(), txtBrands.Text.Trim(), txtCollection.Text.Trim(), txtModel.Text.Trim(), drAge.SelectedItem.ToString(), txtGroundType.Text.Trim(), txtClass.Text.Trim(), txtColor.Text.Trim());
                        DataTable dtSizeOFProduct = new DataTable();
                        dtSizeOFProduct = clsquanlyproduct.laySizeOfProduct(txtMaSanPham.Text.Trim());
                        if (dtSizeOFProduct.Rows.Count <= 0)
                        {
                            switch (drAge.SelectedItem.Value) 
                            {
                                case "1":
                                    clsquanlyproduct.insertProductSize(txtMaSanPham.Text.Trim(), drAge.SelectedItem.Text.Trim(), lbl39.Text.Trim(), Convert.ToInt32(txt39.Text.Trim() == "" ? null : txt39.Text.Trim()));
                                    clsquanlyproduct.insertProductSize(txtMaSanPham.Text.Trim(), drAge.SelectedItem.Text.Trim(), lbl40.Text.Trim(), Convert.ToInt32(txt40.Text.Trim() == "" ? null : txt40.Text.Trim()));
                                    clsquanlyproduct.insertProductSize(txtMaSanPham.Text.Trim(), drAge.SelectedItem.Text.Trim(), lbl41.Text.Trim(), Convert.ToInt32(txt41.Text.Trim() == "" ? null : txt41.Text.Trim()));
                                    clsquanlyproduct.insertProductSize(txtMaSanPham.Text.Trim(), drAge.SelectedItem.Text.Trim(), lbl42.Text.Trim(), Convert.ToInt32(txt42.Text.Trim() == "" ? null : txt42.Text.Trim()));
                                    clsquanlyproduct.insertProductSize(txtMaSanPham.Text.Trim(), drAge.SelectedItem.Text.Trim(), lbl43.Text.Trim(), Convert.ToInt32(txt43.Text.Trim() == "" ? null : txt43.Text.Trim()));
                                    clsquanlyproduct.insertProductSize(txtMaSanPham.Text.Trim(), drAge.SelectedItem.Text.Trim(), lbl44.Text.Trim(), Convert.ToInt32(txt44.Text.Trim() == "" ? null : txt44.Text.Trim()));
                                    clsquanlyproduct.insertProductSize(txtMaSanPham.Text.Trim(), drAge.SelectedItem.Text.Trim(), lbl3913.Text.Trim(), Convert.ToInt32(txt395.Text.Trim() == "" ? null : txt395.Text.Trim()));
                                    clsquanlyproduct.insertProductSize(txtMaSanPham.Text.Trim(), drAge.SelectedItem.Text.Trim(), lbl4023.Text.Trim(), Convert.ToInt32(txt4023.Text.Trim() == "" ? null : txt4023.Text.Trim()));
                                    clsquanlyproduct.insertProductSize(txtMaSanPham.Text.Trim(), drAge.SelectedItem.Text.Trim(), lbl4113.Text.Trim(), Convert.ToInt32(txt4113.Text.Trim() == "" ? null : txt4113.Text.Trim()));
                                    clsquanlyproduct.insertProductSize(txtMaSanPham.Text.Trim(), drAge.SelectedItem.Text.Trim(), lbl4223.Text.Trim(), Convert.ToInt32(txt4223.Text.Trim() == "" ? null : txt4223.Text.Trim()));
                                    clsquanlyproduct.insertProductSize(txtMaSanPham.Text.Trim(), drAge.SelectedItem.Text.Trim(), lbl4313.Text.Trim(), Convert.ToInt32(txt4313.Text.Trim() == "" ? null : txt4313.Text.Trim()));
                                    clsquanlyproduct.insertProductSize(txtMaSanPham.Text.Trim(), drAge.SelectedItem.Text.Trim(), lbl4423.Text.Trim(), Convert.ToInt32(txt4423.Text.Trim() == "" ? null : txt4423.Text.Trim()));
                                    break;
                                case "2":
                                    clsquanlyproduct.insertProductSize(txtMaSanPham.Text.Trim(), drAge.SelectedItem.Text.Trim(), lbl36.Text.Trim(), Convert.ToInt32(txt36.Text.Trim() == "" ? null : txt36.Text.Trim()));
                                    clsquanlyproduct.insertProductSize(txtMaSanPham.Text.Trim(), drAge.SelectedItem.Text.Trim(), lbl3623.Text.Trim(), Convert.ToInt32(txt3623.Text.Trim() == "" ? null : txt3623.Text.Trim()));
                                    clsquanlyproduct.insertProductSize(txtMaSanPham.Text.Trim(), drAge.SelectedItem.Text.Trim(), lbl3713.Text.Trim(), Convert.ToInt32(txt3713.Text.Trim() == "" ? null : txt3713.Text.Trim()));
                                    clsquanlyproduct.insertProductSize(txtMaSanPham.Text.Trim(), drAge.SelectedItem.Text.Trim(), lbl38.Text.Trim(), Convert.ToInt32(txt38.Text.Trim() == "" ? null : txt38.Text.Trim()));
                                    clsquanlyproduct.insertProductSize(txtMaSanPham.Text.Trim(), drAge.SelectedItem.Text.Trim(), lbl3823.Text.Trim(), Convert.ToInt32(txt3823.Text.Trim() == "" ? null : txt3823.Text.Trim()));
                                    break;
                            }
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
                        clsquanlyproduct.updateProduct(txtMaSanPham.Text.Trim(), txtTenSanPham.Text.Trim(), htmlEditor.Html.ToString(), float.Parse(txtGia.Text.Trim()), drDiscount.SelectedItem.Text.Trim(), giaOutput, 1, txtTitle.Text.Trim(), txtMetaDescription.Text.Trim(), txtMetaKeywork.Text.Trim(), clsThuVien.utf8Convert3(txtTenSanPham.Text.Trim()).ToLower().Replace(" ", "-"), strPath[0].ToString(), strPath[1].ToString(), strPath[2].ToString(), strPath[3].ToString(), strPath[4].ToString(), strPath[5].ToString(), strPath[6].ToString(), strPath[7].ToString(), strPath[8].ToString(), strPath[9].ToString(), DateTime.Now, hienThi, Active);
                        _quanlyfootballboots.updateFootballBoots(txtMaSanPham.Text.Trim(), txtBrands.Text.Trim(), txtCollection.Text.Trim(), txtModel.Text.Trim(), drAge.SelectedItem.ToString(), txtGroundType.Text.Trim(), txtClass.Text.Trim(), txtColor.Text.Trim());
                        switch (drAge.SelectedItem.Value)
                        {
                            case "1":
                                clsquanlyproduct.updateProductSize(txtMaSanPham.Text.Trim(), lbl39.Text.Trim(), drAge.SelectedItem.Text.Trim(), Convert.ToInt32(txt39.Text.Trim() == "" ? null : txt39.Text.Trim()));
                                clsquanlyproduct.updateProductSize(txtMaSanPham.Text.Trim(), lbl40.Text.Trim(), drAge.SelectedItem.Text.Trim(), Convert.ToInt32(txt40.Text.Trim() == "" ? null : txt40.Text.Trim()));
                                clsquanlyproduct.updateProductSize(txtMaSanPham.Text.Trim(), lbl41.Text.Trim(), drAge.SelectedItem.Text.Trim(), Convert.ToInt32(txt41.Text.Trim() == "" ? null : txt41.Text.Trim()));
                                clsquanlyproduct.updateProductSize(txtMaSanPham.Text.Trim(), lbl42.Text.Trim(), drAge.SelectedItem.Text.Trim(), Convert.ToInt32(txt42.Text.Trim() == "" ? null : txt42.Text.Trim()));
                                clsquanlyproduct.updateProductSize(txtMaSanPham.Text.Trim(), lbl43.Text.Trim(), drAge.SelectedItem.Text.Trim(), Convert.ToInt32(txt43.Text.Trim() == "" ? null : txt43.Text.Trim()));
                                clsquanlyproduct.updateProductSize(txtMaSanPham.Text.Trim(), lbl44.Text.Trim(), drAge.SelectedItem.Text.Trim(), Convert.ToInt32(txt44.Text.Trim() == "" ? null : txt44.Text.Trim()));
                                clsquanlyproduct.updateProductSize(txtMaSanPham.Text.Trim(), lbl3913.Text.Trim(), drAge.SelectedItem.Text.Trim(), Convert.ToInt32(txt395.Text.Trim() == "" ? null : txt395.Text.Trim()));
                                clsquanlyproduct.updateProductSize(txtMaSanPham.Text.Trim(), lbl4023.Text.Trim(), drAge.SelectedItem.Text.Trim(), Convert.ToInt32(txt4023.Text.Trim() == "" ? null : txt4023.Text.Trim()));
                                clsquanlyproduct.updateProductSize(txtMaSanPham.Text.Trim(), lbl4113.Text.Trim(), drAge.SelectedItem.Text.Trim(), Convert.ToInt32(txt4113.Text.Trim() == "" ? null : txt4113.Text.Trim()));
                                clsquanlyproduct.updateProductSize(txtMaSanPham.Text.Trim(), lbl4223.Text.Trim(), drAge.SelectedItem.Text.Trim(), Convert.ToInt32(txt4223.Text.Trim() == "" ? null : txt4223.Text.Trim()));
                                clsquanlyproduct.updateProductSize(txtMaSanPham.Text.Trim(), lbl4313.Text.Trim(), drAge.SelectedItem.Text.Trim(), Convert.ToInt32(txt4313.Text.Trim() == "" ? null : txt4313.Text.Trim()));
                                clsquanlyproduct.updateProductSize(txtMaSanPham.Text.Trim(), lbl4423.Text.Trim(), drAge.SelectedItem.Text.Trim(), Convert.ToInt32(txt4423.Text.Trim() == "" ? null : txt4423.Text.Trim()));
                                break;
                            case "2":
                                clsquanlyproduct.updateProductSize(txtMaSanPham.Text.Trim(), drAge.SelectedItem.Text.Trim(), lbl36.Text.Trim(), Convert.ToInt32(txt36.Text.Trim() == "" ? null : txt36.Text.Trim()));
                                clsquanlyproduct.updateProductSize(txtMaSanPham.Text.Trim(), drAge.SelectedItem.Text.Trim(), lbl3623.Text.Trim(), Convert.ToInt32(txt3623.Text.Trim() == "" ? null : txt3623.Text.Trim()));
                                clsquanlyproduct.updateProductSize(txtMaSanPham.Text.Trim(), drAge.SelectedItem.Text.Trim(), lbl3713.Text.Trim(), Convert.ToInt32(txt3713.Text.Trim() == "" ? null : txt3713.Text.Trim()));
                                clsquanlyproduct.updateProductSize(txtMaSanPham.Text.Trim(), drAge.SelectedItem.Text.Trim(), lbl38.Text.Trim(), Convert.ToInt32(txt38.Text.Trim() == "" ? null : txt38.Text.Trim()));
                                clsquanlyproduct.updateProductSize(txtMaSanPham.Text.Trim(), drAge.SelectedItem.Text.Trim(), lbl3823.Text.Trim(), Convert.ToInt32(txt3823.Text.Trim() == "" ? null : txt3823.Text.Trim()));
                                break;
                        }
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
            DataTable dtFootballBoots = new DataTable();
            dtFootballBoots = _quanlyfootballboots.layFootballBootsTheoID(e.CommandArgument.ToString());
            switch (e.CommandName)
            {
                case "update":

                    if (dtFootballBoots.Rows.Count > 0)
                    {
                        txtMaSanPham.Text = dtFootballBoots.Rows[0]["maSanPham"].ToString();
                        txtTenSanPham.Text = dtFootballBoots.Rows[0]["tenSanPham"].ToString();
                        txtTitle.Text = dtFootballBoots.Rows[0]["titleSanPham"].ToString();
                        txtMetaDescription.Text = dtFootballBoots.Rows[0]["metaDescriptionSanPham"].ToString();
                        txtMetaKeywork.Text = dtFootballBoots.Rows[0]["metaKeywordsSanPham"].ToString();
                        htmlEditor.Html = dtFootballBoots.Rows[0]["motaSanPham"].ToString();
                        txtGroundType.Text = dtFootballBoots.Rows[0]["groundType"].ToString();
                        txtBrands.Text = dtFootballBoots.Rows[0]["brands"].ToString();
                        txtCollection.Text = dtFootballBoots.Rows[0]["collection"].ToString();
                        txtClass.Text = dtFootballBoots.Rows[0]["class"].ToString();
                        txtColor.Text = dtFootballBoots.Rows[0]["color"].ToString();
                        txtModel.Text = dtFootballBoots.Rows[0]["model"].ToString();
                        txtGia.Text = dtFootballBoots.Rows[0]["giaInput"].ToString();
                        cbkActive.Checked = ((bool)dtFootballBoots.Rows[0]["Active"]) ? true : false;
                        cbkHienThi.Checked = ((bool)dtFootballBoots.Rows[0]["hienThi"]) ? true : false;
                        hdImage1.Value = dtFootballBoots.Rows[0]["avatarSanPham"].ToString();
                        hdImage2.Value = dtFootballBoots.Rows[0]["anh1"].ToString();
                        hdImage3.Value = dtFootballBoots.Rows[0]["anh2"].ToString();
                        hdImage4.Value = dtFootballBoots.Rows[0]["anh3"].ToString();
                        hdImage5.Value = dtFootballBoots.Rows[0]["anh4"].ToString();
                        hdImage6.Value = dtFootballBoots.Rows[0]["anh5"].ToString();
                        hdImage7.Value = dtFootballBoots.Rows[0]["anh6"].ToString();
                        hdImage8.Value = dtFootballBoots.Rows[0]["anh7"].ToString();
                        hdImage9.Value = dtFootballBoots.Rows[0]["anh8"].ToString();
                        hdImage10.Value = dtFootballBoots.Rows[0]["anh9"].ToString();
                        DataTable dtProductSize = new DataTable();
                        dtProductSize = clsquanlyproduct.layProductSizeTheoMaSanPhamANDGender(dtFootballBoots.Rows[0]["maSanPham"].ToString(), dtFootballBoots.Rows[0]["age"].ToString());
                        if (dtProductSize.Rows.Count > 0)
                        {
                            if (dtProductSize.Rows[0]["doiTuong"].ToString() == "Người lớn")
                            {
                                viewSize.ActiveViewIndex = 0;
                                for (int i = 0; i < dtProductSize.Rows.Count; i++)
                                {
                                    if (dtProductSize.Rows[i]["tenSize"].ToString() == "39")
                                    {
                                        txt39.Text = dtProductSize.Rows[i]["soLuong"].ToString();
                                    }
                                    if (dtProductSize.Rows[i]["tenSize"].ToString() == "40")
                                    {
                                        txt40.Text = dtProductSize.Rows[i]["soLuong"].ToString();
                                    }
                                    if (dtProductSize.Rows[i]["tenSize"].ToString() == "41")
                                    {
                                        txt41.Text = dtProductSize.Rows[i]["soLuong"].ToString();
                                    }
                                    if (dtProductSize.Rows[i]["tenSize"].ToString() == "42")
                                    {
                                        txt42.Text = dtProductSize.Rows[i]["soLuong"].ToString();
                                    }
                                    if (dtProductSize.Rows[i]["tenSize"].ToString() == "43")
                                    {
                                        txt43.Text = dtProductSize.Rows[i]["soLuong"].ToString();
                                    }
                                    if (dtProductSize.Rows[i]["tenSize"].ToString() == "44")
                                    {
                                        txt44.Text = dtProductSize.Rows[i]["soLuong"].ToString();
                                    }
                                    if (dtProductSize.Rows[i]["tenSize"].ToString() == "39 1/3")
                                    {
                                        txt395.Text = dtProductSize.Rows[i]["soLuong"].ToString();
                                    }
                                    if (dtProductSize.Rows[i]["tenSize"].ToString() == "40 2/3")
                                    {
                                        txt4023.Text = dtProductSize.Rows[i]["soLuong"].ToString();
                                    }
                                    if (dtProductSize.Rows[i]["tenSize"].ToString() == "41 1/3")
                                    {
                                        txt4113.Text = dtProductSize.Rows[i]["soLuong"].ToString();
                                    }
                                    if (dtProductSize.Rows[i]["tenSize"].ToString() == "42 2/3")
                                    {
                                        txt4223.Text = dtProductSize.Rows[i]["soLuong"].ToString();
                                    }
                                    if (dtProductSize.Rows[i]["tenSize"].ToString() == "43 1/3")
                                    {
                                        txt4313.Text = dtProductSize.Rows[i]["soLuong"].ToString();
                                    }
                                    if (dtProductSize.Rows[i]["tenSize"].ToString() == "44 2/3")
                                    {
                                        txt4423.Text = dtProductSize.Rows[i]["soLuong"].ToString();
                                    }
                                }
                            }
                            if(dtProductSize.Rows[0]["doiTuong"].ToString() ==  "Trẻ em")
                            {
                                viewSize.ActiveViewIndex = 1;
                                for (int i = 0; i < dtProductSize.Rows.Count; i++)
                                {
                                    if (dtProductSize.Rows[i]["tenSize"].ToString() == "36")
                                    {
                                        txt36.Text = dtProductSize.Rows[i]["soLuong"].ToString();
                                    }
                                    if (dtProductSize.Rows[i]["tenSize"].ToString() == "36 2/3")
                                    {
                                        txt3623.Text = dtProductSize.Rows[i]["soLuong"].ToString();
                                    }
                                    if (dtProductSize.Rows[i]["tenSize"].ToString() == "37 1/3")
                                    {
                                        txt3713.Text = dtProductSize.Rows[i]["soLuong"].ToString();
                                    }
                                    if (dtProductSize.Rows[i]["tenSize"].ToString() == "38")
                                    {
                                        txt38.Text = dtProductSize.Rows[i]["soLuong"].ToString();
                                    }
                                    if (dtProductSize.Rows[i]["tenSize"].ToString() == "38 2/3")
                                    {
                                        txt3823.Text = dtProductSize.Rows[i]["soLuong"].ToString();
                                    }
                                    
                                }
                            }
                        }
                        hdInsert.Value = "update";
                        hdId_FB.Value = dtFootballBoots.Rows[0]["id_FB"].ToString();
                        mlv.ActiveViewIndex = 1;
                    }
                    break;
                case "delete":

                    if (dtFootballBoots.Rows.Count > 0)
                    {
                        if (dtFootballBoots.Rows[0]["avatarSanPham"].ToString().Length > 0)
                        {

                            clsThuVien.deleteImage(dtFootballBoots.Rows[0]["avatarSanPham"].ToString());
                        }
                        if (dtFootballBoots.Rows[0]["anh1"].ToString().Length > 0)
                        {
                            clsThuVien.deleteImage(dtFootballBoots.Rows[0]["anh1"].ToString());
                        }
                        if (dtFootballBoots.Rows[0]["anh2"].ToString().Length > 0)
                        {
                            clsThuVien.deleteImage(dtFootballBoots.Rows[0]["anh2"].ToString());
                        }
                        if (dtFootballBoots.Rows[0]["anh3"].ToString().Length > 0)
                        {
                            clsThuVien.deleteImage(dtFootballBoots.Rows[0]["anh3"].ToString());
                        }
                        if (dtFootballBoots.Rows[0]["anh4"].ToString().Length > 0)
                        {
                            clsThuVien.deleteImage(dtFootballBoots.Rows[0]["anh4"].ToString());
                        }
                        if (dtFootballBoots.Rows[0]["anh5"].ToString().Length > 0)
                        {
                            clsThuVien.deleteImage(dtFootballBoots.Rows[0]["anh5"].ToString());
                        }
                        if (dtFootballBoots.Rows[0]["anh6"].ToString().Length > 0)
                        {
                            clsThuVien.deleteImage(dtFootballBoots.Rows[0]["anh6"].ToString());
                        }
                        if (dtFootballBoots.Rows[0]["anh7"].ToString().Length > 0)
                        {
                            clsThuVien.deleteImage(dtFootballBoots.Rows[0]["anh7"].ToString());
                        }
                        if (dtFootballBoots.Rows[0]["anh8"].ToString().Length > 0)
                        {
                            clsThuVien.deleteImage(dtFootballBoots.Rows[0]["anh8"].ToString());
                        }
                        if (dtFootballBoots.Rows[0]["anh9"].ToString().Length > 0)
                        {
                            clsThuVien.deleteImage(dtFootballBoots.Rows[0]["anh9"].ToString());
                        }
                        clsquanlyproduct.deleteProductSize(dtFootballBoots.Rows[0]["maSanPham"].ToString());
                        _quanlyfootballboots.deleteFootballBoots(dtFootballBoots.Rows[0]["maSanPham"].ToString());
                        clsquanlyproduct.deleteProduct(dtFootballBoots.Rows[0]["maSanPham"].ToString());
                        Response.Redirect(Request.Url.ToString());
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

        protected void drAge_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(drAge.SelectedItem.Value == "1")
            {
                viewSize.ActiveViewIndex = 0;
                upBangSize.Update();
            }
            else if(drAge.SelectedItem.Value == "2")
            {
                viewSize.ActiveViewIndex = 1;
                upBangSize.Update();
            }
        }
    }
}