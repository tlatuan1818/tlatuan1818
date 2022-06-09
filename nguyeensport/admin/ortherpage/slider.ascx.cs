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
    public partial class slider : System.Web.UI.UserControl
    {
        clsquanlyslider _quanlyslider = new clsquanlyslider();
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        void LoadData()
        {
            rptListProduct.DataSource = _quanlyslider.laySlider();
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
                HiddenField hdMaSlider = e.Item.FindControl("maSlider") as HiddenField;
                CheckBox cbkHienThi = e.Item.FindControl("ckbHienThi") as CheckBox;
                cbkHienThi.InputAttributes.Add("class", "custom-control-input");
                cbkHienThi.LabelAttributes.Add("class", "custom-control-label");
                cbkHienThi.InputAttributes.Add("Value", hdMaSlider.Value.ToString());
                CheckBox cbkActive = e.Item.FindControl("cbkActive") as CheckBox;
                cbkActive.InputAttributes.Add("class", "custom-control-input");
                cbkActive.LabelAttributes.Add("class", "custom-control-label");
                cbkActive.InputAttributes.Add("Value", hdMaSlider.Value.ToString());
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
        public static string utf8Convert3(string s)
        {
            Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string temp = s.Normalize(NormalizationForm.FormD);
            return regex.Replace(temp, string.Empty).Replace('\u0111', 'd').Replace('\u0111', 'D');
        }
        protected void btnUpdate_Click(object sender, EventArgs e)
        {

            String fileextension;
            String image1 = hdImage1.Value;
            String image2 = hdImage2.Value;
            String path = "";

            HttpFileCollection hfc = Request.Files;
            for (int i = 0; i < hfc.Count; i++)
            {
                HttpPostedFile hpf = hfc[i];
                if (hpf.ContentLength > 0)
                {
                    fileextension = Path.GetExtension(hpf.FileName);
                    path = utf8Convert3(txtTenSlider.Text).ToLower().Replace(" ", "-").Replace("/", "-") + "-" + i + fileextension;
                    hpf.SaveAs(Server.MapPath("~/images/anh-slider") + "/" + path);
                    if (i == 0)
                    {
                        image1 = "/images/anh-slider/" + path;
                    }
                    if (i == 1)
                    {
                        image2 = "/images/anh-slider/" + path;
                    }

                }
            }
            if (!image1.Equals(hdImage1.Value))
            {
                if (!hdImage1.Value.Equals(""))
                {
                    if (System.IO.File.Exists(Server.MapPath("~/images/anh-slider" + hdImage1.Value)) == true)
                    {
                        System.IO.File.Exists(Server.MapPath("~/images/anh-slider" + hdImage1.Value));
                    }
                }
                if (!hdImage2.Value.Equals(""))
                {
                    if (System.IO.File.Exists(Server.MapPath("~/images/anh-slider" + hdImage2.Value)) == true)
                    {
                        System.IO.File.Exists(Server.MapPath("~/images/anh-slider" + hdImage2.Value));
                    }
                }
            }


            if (!string.IsNullOrEmpty(txtTenSlider.Text.Trim()))
            {
                try
                {
                    if (hdInsert.Value.ToString() == "insert")
                    {
                        bool Active = cbkActive.Checked ? true : false;
                        bool hienThi = cbkHienThi.Checked ? true : false;
                        _quanlyslider.insertSlider(txtTenSlider.Text.Trim(), txtMetaDescription.Text.Trim(), utf8Convert3(txtTenSlider.Text).ToLower().Replace(" ", "-").Replace("/", "-"), image1, image2, int.Parse(txtMaDanhMuc.Text.Trim()), DateTime.Now, hienThi, Active);
                        lblThongBao.Text = "<div class='alert alert-success alert-dismissible fade show' role='alert'>" +
                                           "Thêm thành công" +
                               "<button type='button' class='close' data-dismiss='alert' aria-label='Close'>" +
                               "<span aria-hidden='true'>&times;</span>" +
                               "</button>" +
                           "</div>";

                    }
                    else
                    {
                        bool Active = cbkActive.Checked ? true : false;
                        bool hienThi = cbkHienThi.Checked ? true : false;
                        _quanlyslider.updateSlider(int.Parse(hdValue.Value.ToString()), txtTenSlider.Text.Trim(), txtMetaDescription.Text.Trim(), utf8Convert3(txtTenSlider.Text).ToLower().Replace(" ", "-").Replace("/", "-"), image1, image2, int.Parse(txtMaDanhMuc.Text.Trim()), hienThi, Active);
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
                txtTenSlider.CssClass = "form-control is-invalid";
                lblThongBao.Text = "<div class='alert alert-warning alert-dismissible fade show' role='alert'>" +
                                           "Vui lòng nhập tên slider" +
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
            DataTable dtBrands = new DataTable();
            dtBrands = _quanlyslider.laySliderTheoID(int.Parse(e.CommandArgument.ToString()));
            switch (e.CommandName)
            {
                case "update":

                    if (dtBrands.Rows.Count > 0)
                    {
                        txtTenSlider.Text = dtBrands.Rows[0]["tenSlider"].ToString();
                        txtMetaDescription.Text = dtBrands.Rows[0]["desSlider"].ToString();
                        txtMaDanhMuc.Text = dtBrands.Rows[0]["maDanhMuc"].ToString();
                        cbkActive.Checked = ((bool)dtBrands.Rows[0]["Active"]) ? true : false;
                        cbkHienThi.Checked = ((bool)dtBrands.Rows[0]["hienThi"]) ? true : false;
                        hdImage1.Value = dtBrands.Rows[0]["imageSliderDesktop"].ToString();
                        hdImage2.Value = dtBrands.Rows[0]["imageSliderMobile"].ToString();
                        hdInsert.Value = "update";
                        hdValue.Value = dtBrands.Rows[0]["maSlider"].ToString();
                        mlv.ActiveViewIndex = 1;
                    }
                    break;
                case "delete":

                    if (dtBrands.Rows.Count > 0)
                    {
                        if (System.IO.File.Exists(Server.MapPath("~/" + dtBrands.Rows[0]["imageSliderDesktop"])) == true)
                        {
                            System.IO.File.Delete(Server.MapPath("~/" + dtBrands.Rows[0]["imageSliderDesktop"]));
                        }
                        if (System.IO.File.Exists(Server.MapPath("~/" + dtBrands.Rows[0]["imageSliderMobile"])) == true)
                        {
                            System.IO.File.Delete(Server.MapPath("~/" + dtBrands.Rows[0]["imageSliderMobile"]));
                        }
                        _quanlyslider.deleteSlider(int.Parse(e.CommandArgument.ToString()));
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
                clsThuVien.updateHienThi("Slider", "maSlider", itemID, itemState);
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
                clsThuVien.updateHienThi("Slider", "Slider", itemID, itemState);
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