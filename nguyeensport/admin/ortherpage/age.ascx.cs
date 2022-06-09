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
    public partial class age : System.Web.UI.UserControl
    {
        clsquanlyage _quanlyage = new clsquanlyage();
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        void LoadData()
        {
            rptListProduct.DataSource = _quanlyage.layAge();
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
                CheckBox cbkHienThi = e.Item.FindControl("ckbHienThi") as CheckBox;
                cbkHienThi.InputAttributes.Add("class", "custom-control-input");
                cbkHienThi.LabelAttributes.Add("class", "custom-control-label");
                CheckBox cbkActive = e.Item.FindControl("cbkActive") as CheckBox;
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
        public static string utf8Convert3(string s)
        {
            Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string temp = s.Normalize(NormalizationForm.FormD);
            return regex.Replace(temp, string.Empty).Replace('\u0111', 'd').Replace('\u0111', 'D');
        }
        protected void btnUpdate_Click(object sender, EventArgs e)
        {

            //String fileextension;
            //String image1 = hdImage1.Value;

            //String path = "";

            //HttpFileCollection hfc = Request.Files;
            //for (int i = 0; i < hfc.Count; i++)
            //{
            //    HttpPostedFile hpf = hfc[i];
            //    if (hpf.ContentLength > 0)
            //    {
            //        fileextension = Path.GetExtension(hpf.FileName);
            //        path = utf8Convert3(txtTenCollection.Text).ToLower().Replace(" ", "-").Replace("/", "-") + "-" + i + fileextension;
            //        hpf.SaveAs(Server.MapPath("~/images/anh-brands") + "/" + path);
            //        if (i == 0)
            //        {
            //            image1 = "/images/anh-brands/" + path;
            //        }

            //    }
            //}
            //if (!image1.Equals(hdImage1.Value))
            //{
            //    if (!hdImage1.Value.Equals(""))
            //    {
            //        if (System.IO.File.Exists(Server.MapPath("~/images/anh-brands" + hdImage1.Value)) == true)
            //        {
            //            System.IO.File.Exists(Server.MapPath("~/images/anh-brands" + hdImage1.Value));
            //        }
            //    }
            //}


            if (!string.IsNullOrEmpty(txtTenAge.Text.Trim()))
            {
                if (hdInsert.Value.ToString() == "insert")
                {
                    bool Active = cbkActive.Checked ? true : false;
                    bool hienThi = cbkHienThi.Checked ? true : false;
                    _quanlyage.insertAge(txtTenAge.Text.Trim(), hienThi, Active);


                }
                else
                {
                    bool Active = cbkActive.Checked ? true : false;
                    bool hienThi = cbkHienThi.Checked ? true : false;
                    _quanlyage.updateAge(int.Parse(hdValue.Value.ToString()), txtTenAge.Text.Trim(), hienThi, Active);

                }
                Response.Redirect(Request.Url.ToString());
            }
            else
            {
                txtTenAge.CssClass = "form-control is-invalid";
            }

        }

        protected void btnXoa_Load(object sender, EventArgs e)
        {
            ((LinkButton)sender).Attributes["onclick"] = "return confirm('Bạn có muốn xóa dòng này không ?')";
        }

        protected void rptListProduct_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            DataTable dtBrands = new DataTable();
            dtBrands = _quanlyage.layAgeTheoID(int.Parse(e.CommandArgument.ToString()));
            switch (e.CommandName)
            {
                case "update":

                    if (dtBrands.Rows.Count > 0)
                    {
                      
                        txtTenAge.Text = dtBrands.Rows[0]["tenAge"].ToString();
                        //txtTitle.Text = dtBrands.Rows[0]["titleBrands"].ToString();
                        //txtMetaDescription.Text = dtBrands.Rows[0]["metaDescriptionBrands"].ToString();
                        //txtMetaKeywork.Text = dtBrands.Rows[0]["metaKeywordsBrands"].ToString();
                        cbkActive.Checked = ((bool)dtBrands.Rows[0]["Active"]) ? true : false;
                        cbkHienThi.Checked = ((bool)dtBrands.Rows[0]["hienThi"]) ? true : false;
                        //hdImage1.Value = dtBrands.Rows[0]["avatarBrands"].ToString();
                        hdInsert.Value = "update";
                        hdValue.Value = e.CommandArgument.ToString();
                        mlv.ActiveViewIndex = 1;
                    }
                    break;
                case "delete":

                    if (dtBrands.Rows.Count > 0)
                    {
                        if (System.IO.File.Exists(Server.MapPath("~/" + dtBrands.Rows[0]["avatarBrands"])) == true)
                        {
                            System.IO.File.Delete(Server.MapPath("~/" + dtBrands.Rows[0]["avatarBrands"]));
                        }
                        _quanlyage.deleteAge(int.Parse(e.CommandArgument.ToString()));
                        Response.Redirect(Request.Url.ToString());
                    }
                    break;
            }
        }
    }
}