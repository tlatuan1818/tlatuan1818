using nguyeensport.dal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace nguyeensport.admin.ortherpage
{
    public partial class version : System.Web.UI.UserControl
    {
        clsquanlyrange _quanlyrange = new clsquanlyrange();
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        void LoadData()
        {
            rptListProduct.DataSource = _quanlyrange.layVersion();
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
                HiddenField hdMaVersion = e.Item.FindControl("maVersion") as HiddenField;
                CheckBox cbkHienThi = e.Item.FindControl("cbkHienThi") as CheckBox;
                cbkHienThi.InputAttributes.Add("class", "custom-control-input");
                cbkHienThi.LabelAttributes.Add("class", "custom-control-label");
                cbkHienThi.InputAttributes.Add("Value", hdMaVersion.Value.ToString());
                CheckBox cbkActive = e.Item.FindControl("cbkActive") as CheckBox;
                cbkActive.InputAttributes.Add("class", "custom-control-input");
                cbkActive.LabelAttributes.Add("class", "custom-control-label");
                cbkActive.InputAttributes.Add("Value", hdMaVersion.Value.ToString());
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

            if (!string.IsNullOrEmpty(txtTenVersion.Text.Trim()))
            {
                try
                {
                    if (hdInsert.Value.ToString() == "insert")
                    {
                        bool Active = cbkActive.Checked ? true : false;
                        bool hienThi = cbkHienThi.Checked ? true : false;
                        _quanlyrange.insertVersion(txtTenVersion.Text.Trim(), hienThi, Active);
                        lblThongBao2.Text = "<div class='alert alert-success alert-dismissible fade show' role='alert'>" +
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
                        _quanlyrange.updateVersion(int.Parse(hdValue.Value.ToString()), txtTenVersion.Text.Trim(), hienThi, Active);
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
                txtTenVersion.CssClass = "form-control is-invalid";
                lblThongBao2.Text = "<div class='alert alert-warning alert-dismissible fade show' role='alert'>" +
                                      "Vui lòng nhập tên phiên bản" +
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
            dtBrands = _quanlyrange.layVersionTheoID(int.Parse(e.CommandArgument.ToString()));
            switch (e.CommandName)
            {
                case "update":

                    if (dtBrands.Rows.Count > 0)
                    {

                        txtTenVersion.Text = dtBrands.Rows[0]["tenVersion"].ToString();
                        //txtTitle.Text = dtBrands.Rows[0]["titleBrands"].ToString();
                        //txtMetaDescription.Text = dtBrands.Rows[0]["metaDescriptionBrands"].ToString();
                        //txtMetaKeywork.Text = dtBrands.Rows[0]["metaKeywordsBrands"].ToString();
                        cbkActive.Checked = ((bool)dtBrands.Rows[0]["Active"]) ? true : false;
                        cbkHienThi.Checked = ((bool)dtBrands.Rows[0]["hienThi"]) ? true : false;
                        hdInsert.Value = "update";
                        hdValue.Value = e.CommandArgument.ToString();
                        mlv.ActiveViewIndex = 1;
                    }
                    break;
                case "delete":

                    if (dtBrands.Rows.Count > 0)
                    {
                        _quanlyrange.deleteVersion(int.Parse(e.CommandArgument.ToString()));
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
                clsThuVien.updateHienThi("Version", "maVersion", itemID, itemState);
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
                clsThuVien.updateActive("Version", "maVersion", itemID, itemState);
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