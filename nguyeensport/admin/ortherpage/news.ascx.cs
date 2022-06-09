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

namespace nguyeensport.admin.ortherpage
{
    public partial class news : System.Web.UI.UserControl
    {
       
        clsquanlydanhmuctintuc _quanlydanhmuctintuc = new clsquanlydanhmuctintuc();
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        void LoadData()
        {
            rptListProduct.DataSource = _quanlydanhmuctintuc.layNews();
            rptListProduct.DataBind();
            //v2
           
            cbkHienThi.InputAttributes.Add("class", "custom-control-input");
            cbkHienThi.LabelAttributes.Add("class", "custom-control-label");
            cbkActive.InputAttributes.Add("class", "custom-control-input");
            cbkActive.LabelAttributes.Add("class", "custom-control-label");

        }
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            hdInsert.Value = "insert";
            mlv.ActiveViewIndex = 1;
           
        }
        protected void rptListProduct_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                HiddenField hdMaNews = e.Item.FindControl("maNews") as HiddenField;
                CheckBox cbkHienThi = e.Item.FindControl("ckbHienThi") as CheckBox;
                cbkHienThi.InputAttributes.Add("class", "custom-control-input");
                cbkHienThi.LabelAttributes.Add("class", "custom-control-label");
                cbkHienThi.InputAttributes.Add("Value", hdMaNews.Value.ToString());
                CheckBox cbkActive = e.Item.FindControl("ckbActive") as CheckBox;
                cbkActive.InputAttributes.Add("class", "custom-control-input");
                cbkActive.LabelAttributes.Add("class", "custom-control-label");
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
            }
        }
        protected void btnBack_Click(object sender, EventArgs e)
        {
            mlv.ActiveViewIndex = 0;
            LoadData();
        }
      
        protected void btnUpdate_Click(object sender, EventArgs e)
        {
          
            if (!string.IsNullOrEmpty(txtTenTinTuc.Text.Trim()))
            {
                try
                {
                    bool Active = cbkActive.Checked ? true : false;
                    bool hienThi = cbkHienThi.Checked ? true : false;
                    string linkNewsDeltail = clsThuVien.utf8Convert3(txtTenTinTuc.Text.Trim()).ToLower().Replace(" ", "-");
                    if (hdInsert.Value.ToString() == "insert")
                    {
                        _quanlydanhmuctintuc.insertNews(txtTenTinTuc.Text.Trim(), linkNewsDeltail.ToString(), txtTitle.Text.Trim(), txtMetaDescription.Text.Trim(), txtKeyword.Text.Trim(), hienThi, Active);
                        lblThongBao.Text = "<div class='alert alert-success alert-dismissible fade show' role='alert'>" +
                                             "Thêm thành công" +
                                 "<button type='button' class='close' data-dismiss='alert' aria-label='Close'>" +
                                 "<span aria-hidden='true'>&times;</span>" +
                                 "</button>" +
                             "</div>";
                    }
                    else
                    {
                        _quanlydanhmuctintuc.updateNews(int.Parse(hdValue.Value.ToString()), txtTenTinTuc.Text.Trim(), linkNewsDeltail.ToString(), txtTitle.Text.Trim(), txtKeyword.Text.Trim(), txtMetaDescription.Text.Trim(), hienThi, Active);
                        lblThongBao.Text = "<div class='alert alert-success alert-dismissible fade show' role='alert'>" +
                                             "Sửa thành công" +
                                 "<button type='button' class='close' data-dismiss='alert' aria-label='Close'>" +
                                 "<span aria-hidden='true'>&times;</span>" +
                                 "</button>" +
                             "</div>";
                    }
                }
                catch(Exception ex)
                {
                    lblThongBao.Text = "<div class='alert alert-warning alert-dismissible fade show' role='alert'>" +
                                         ex.ToString() +
                             "<button type='button' class='close' data-dismiss='alert' aria-label='Close'>" +
                             "<span aria-hidden='true'>&times;</span>" +
                             "</button>" +
                         "</div>";
                }
                
            }
            else
            {
                txtTenTinTuc.CssClass = "form-control is-invalid";
                lblThongBao.Text = "<div class='alert alert-warning alert-dismissible fade show' role='alert'>" +
                                           "Vui lòng nhập tên danh mục tin tức" +
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
            DataTable dtFanShop = new DataTable();
            dtFanShop = _quanlydanhmuctintuc.layNewsTheoID(int.Parse(e.CommandArgument.ToString()));
            switch (e.CommandName)
            {
                case "update":

                    if (dtFanShop.Rows.Count > 0)
                    {
                        txtTenTinTuc.Text = dtFanShop.Rows[0]["tenNews"].ToString();
                        txtTitle.Text = dtFanShop.Rows[0]["titleNews"].ToString();
                        txtMetaDescription.Text = dtFanShop.Rows[0]["metaDescriptionNews"].ToString();
                        txtKeyword.Text = dtFanShop.Rows[0]["metaKeywordNews"].ToString();
                        cbkHienThi.Checked = ((bool)dtFanShop.Rows[0]["hienThi"]) ? true : false;
                        cbkActive.Checked = ((bool)dtFanShop.Rows[0]["Active"]) ? true : false;
                        hdValue.Value = e.CommandArgument.ToString();
                        hdInsert.Value = "update";
                        mlv.ActiveViewIndex = 1;
                    }
                    break;
                case "delete":

                    if (dtFanShop.Rows.Count > 0)
                    {
                        _quanlydanhmuctintuc.deleteNews(int.Parse(e.CommandArgument.ToString()));
                        LoadData();
                    }
                    break;
            }
        }

        protected void ckbHienThi_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                CheckBox cbkHienThi = sender as CheckBox;
                Boolean itemState = cbkHienThi.Checked;
                Int32 itemID = Int32.Parse(cbkHienThi.InputAttributes["Value"].ToString());
                clsThuVien.updateHienThi("News", "maNews", itemID, itemState);
                LoadData();

            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        protected void ckbHienThi_Load(object sender, EventArgs e)
        {
            ((CheckBox)sender).Attributes["onclick"] = "javascript:ShowProgressBar()";
        }

        protected void ckbActive_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                CheckBox cbkActive = sender as CheckBox;
                Boolean itemState = cbkActive.Checked;
                Int32 itemID = Int32.Parse(cbkActive.InputAttributes["Value"].ToString());
                clsThuVien.updateHienThi("News", "maNews", itemID, itemState);
                LoadData();

            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        protected void ckbActive_Load(object sender, EventArgs e)
        {
            ((CheckBox)sender).Attributes["onclick"] = "javascript:ShowProgressBar()";
        }
    }
}