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
    public partial class deltailnews : System.Web.UI.UserControl
    {
        clsquanlydanhmuctintuc _quanlydanhmuctintuc = new clsquanlydanhmuctintuc();
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        void LoadData()
        {
            rptListProduct.DataSource = _quanlydanhmuctintuc.layNewDeltail();
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
            //LoadData();
        }
        protected void rptListProduct_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                HiddenField hdMaDeltialNews = e.Item.FindControl("maNewsDeltail") as HiddenField;
                CheckBox cbkHienThi = e.Item.FindControl("ckbHienThi") as CheckBox;
                cbkHienThi.InputAttributes.Add("class", "custom-control-input");
                cbkHienThi.LabelAttributes.Add("class", "custom-control-label");
                cbkHienThi.InputAttributes.Add("Value", hdMaDeltialNews.Value.ToString());
                CheckBox cbkActive = e.Item.FindControl("ckbActive") as CheckBox;
                cbkActive.InputAttributes.Add("class", "custom-control-input");
                cbkActive.LabelAttributes.Add("class", "custom-control-label");
                cbkActive.InputAttributes.Add("Value", hdMaDeltialNews.Value.ToString());
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
            String image3 = hdImage3.Value;
            String image4 = hdImage4.Value;
            String image5 = hdImage5.Value;
            String image6 = hdImage6.Value;
            String image7 = hdImage7.Value;
            String image8 = hdImage8.Value;
            String image9 = hdImage9.Value;
            String image10 = hdImage10.Value;
            String image11 = hdImage11.Value;
            String path = "";

            HttpFileCollection hfc = Request.Files;
            for (int i = 0; i < hfc.Count; i++)
            {
                HttpPostedFile hpf = hfc[i];
                if (hpf.ContentLength > 0)
                {
                    fileextension = Path.GetExtension(hpf.FileName);
                    path = utf8Convert3(txtTenTinTuc.Text.Trim()).ToLower().Replace(" ", "-") + "-" + i + fileextension;
                    hpf.SaveAs(Server.MapPath("~/images/anh-tin-tuc") + "/" + path);
                    if (i == 0)
                    {
                        image1 = "/images/anh-tin-tuc/" + path;
                    }
                    if (i == 1)
                    {
                        image2 = "/images/anh-tin-tuc/" + path;
                    }
                    if (i == 2)
                    {
                        image3 = "/images/anh-tin-tuc/" + path;
                    }
                    if (i == 3)
                    {
                        image4 = "/images/anh-tin-tuc/" + path;
                    }
                    if (i == 4)
                    {
                        image5 = "/images/anh-tin-tuc/" + path;
                    }
                    if (i == 5)
                    {
                        image6 = "/images/anh-tin-tuc/" + path;
                    }
                    if (i == 6)
                    {
                        image7 = "/images/anh-tin-tuc/" + path;
                    }
                    if (i == 7)
                    {
                        image8 = "/images/anh-tin-tuc/" + path;
                    }
                    if (i == 8)
                    {
                        image9 = "/images/anh-tin-tuc/" + path;
                    }
                    if (i == 9)
                    {
                        image10 = "/images/anh-tin-tuc/" + path;
                    }
                    if (i == 10)
                    {
                        image11 = "/images/anh-tin-tuc/" + path;
                    }


                }
            }
            if (!image1.Equals(hdImage1.Value))
            {
                if (!hdImage1.Value.Equals(""))
                {
                    if (System.IO.File.Exists(Server.MapPath("~/images/anh-tin-tuc" + hdImage1.Value)) == true)
                    {
                        System.IO.File.Exists(Server.MapPath("~/images/anh-tin-tuc" + hdImage1.Value));
                    }
                }
            }
            if (!image2.Equals(hdImage2.Value))
            {
                if (!hdImage2.Value.Equals(""))
                {
                    if (System.IO.File.Exists(Server.MapPath("~/images/anh-tin-tuc" + hdImage2.Value)) == true)
                    {
                        System.IO.File.Exists(Server.MapPath("~/images/anh-tin-tuc" + hdImage2.Value));
                    }
                }
            }
            if (!image3.Equals(hdImage3.Value))
            {
                if (!hdImage3.Value.Equals(""))
                {
                    if (System.IO.File.Exists(Server.MapPath("~/images/anh-tin-tuc" + hdImage3.Value)) == true)
                    {
                        System.IO.File.Exists(Server.MapPath("~/images/anh-tin-tuc" + hdImage3.Value));
                    }
                }
            }
            if (!image4.Equals(hdImage4.Value))
            {
                if (!hdImage4.Value.Equals(""))
                {
                    if (System.IO.File.Exists(Server.MapPath("~/images/anh-tin-tuc" + hdImage4.Value)) == true)
                    {
                        System.IO.File.Exists(Server.MapPath("~/images/anh-tin-tuc" + hdImage4.Value));
                    }
                }
            }
            if (!image5.Equals(hdImage5.Value))
            {
                if (!hdImage5.Value.Equals(""))
                {
                    if (System.IO.File.Exists(Server.MapPath("~/images/anh-tin-tuc" + hdImage5.Value)) == true)
                    {
                        System.IO.File.Exists(Server.MapPath("~/images/anh-tin-tuc" + hdImage5.Value));
                    }
                }
            }
            if (!image6.Equals(hdImage6.Value))
            {
                if (!hdImage6.Value.Equals(""))
                {
                    if (System.IO.File.Exists(Server.MapPath("~/images/anh-tin-tuc" + hdImage6.Value)) == true)
                    {
                        System.IO.File.Exists(Server.MapPath("~/images/anh-tin-tuc" + hdImage6.Value));
                    }
                }
            }
            if (!image7.Equals(hdImage7.Value))
            {
                if (!hdImage7.Value.Equals(""))
                {
                    if (System.IO.File.Exists(Server.MapPath("~/images/anh-tin-tuc" + hdImage7.Value)) == true)
                    {
                        System.IO.File.Exists(Server.MapPath("~/images/anh-tin-tuc" + hdImage7.Value));
                    }
                }
            }
            if (!image8.Equals(hdImage8.Value))
            {
                if (!hdImage8.Value.Equals(""))
                {
                    if (System.IO.File.Exists(Server.MapPath("~/images/anh-tin-tuc" + hdImage8.Value)) == true)
                    {
                        System.IO.File.Exists(Server.MapPath("~/images/anh-tin-tuc" + hdImage8.Value));
                    }
                }
            }
            if (!image9.Equals(hdImage9.Value))
            {
                if (!hdImage9.Value.Equals(""))
                {
                    if (System.IO.File.Exists(Server.MapPath("~/images/anh-tin-tuc" + hdImage9.Value)) == true)
                    {
                        System.IO.File.Exists(Server.MapPath("~/images/anh-tin-tuc" + hdImage9.Value));
                    }
                }
            }
            if (!image10.Equals(hdImage10.Value))
            {
                if (!hdImage10.Value.Equals(""))
                {
                    if (System.IO.File.Exists(Server.MapPath("~/images/anh-tin-tuc" + hdImage10.Value)) == true)
                    {
                        System.IO.File.Exists(Server.MapPath("~/images/anh-tin-tuc" + hdImage10.Value));
                    }
                }
            }
            if (!image11.Equals(hdImage11.Value))
            {
                if (!hdImage11.Value.Equals(""))
                {
                    if (System.IO.File.Exists(Server.MapPath("~/images/anh-tin-tuc" + hdImage11.Value)) == true)
                    {
                        System.IO.File.Exists(Server.MapPath("~/images/anh-tin-tuc" + hdImage11.Value));
                    }
                }
            }
          
            if (!string.IsNullOrEmpty(txtTenTinTuc.Text.Trim()))
            {
                try
                {
                    bool Active = cbkActive.Checked ? true : false;
                    bool hienThi = cbkHienThi.Checked ? true : false;
                    string linkNewsDeltail = utf8Convert3(txtTenTinTuc.Text.Trim()).ToLower().Replace(" ", "-");
                    if (hdInsert.Value.ToString() == "insert")
                    {
                        _quanlydanhmuctintuc.insertNewsDeltail(txtNews.Text.Trim(), txtTenTinTuc.Text.Trim(), htmlEditor.Html.ToString(), linkNewsDeltail.ToString(), txtTitle.Text.Trim(), txtMetaDescription.Text.Trim(), ASPxTokenBox1.Text.Trim(), image1, image2, image3, image4, image5, image6, image7, image8, image9, txtLinkSanPhamQC.Text.Trim(), image10, image11, 0, DateTime.Now, hienThi, Active);
                        lblThongBao.Text = "<div class='alert alert-success alert-dismissible fade show' role='alert'>" +
                                               "Thêm thành công" +
                                   "<button type='button' class='close' data-dismiss='alert' aria-label='Close'>" +
                                   "<span aria-hidden='true'>&times;</span>" +
                                   "</button>" +
                               "</div>";
                    }
                    else
                    {
                        _quanlydanhmuctintuc.updateNewsDeltail(int.Parse(hdValue.Value.ToString()), txtNews.Text.Trim(), txtTenTinTuc.Text.Trim(), htmlEditor.Html.ToString(), linkNewsDeltail.ToString(), txtTitle.Text.Trim(), ASPxTokenBox1.Text.Trim(), txtMetaDescription.Text.Trim(), image1, image2, image3, image4, image5, image6, image7, image8, image9, txtLinkSanPhamQC.Text.Trim(), image10, image11, 0, DateTime.Now, hienThi, Active);
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
            dtFanShop = _quanlydanhmuctintuc.layNewsDeltailTheoID(int.Parse(e.CommandArgument.ToString()));
            switch (e.CommandName)
            {
                case "update":

                    if (dtFanShop.Rows.Count > 0)
                    {
                        txtTenTinTuc.Text = dtFanShop.Rows[0]["tenNewsDeltail"].ToString();
                        txtTitle.Text = dtFanShop.Rows[0]["titleNewsDeltail"].ToString();
                        txtMetaDescription.Text = dtFanShop.Rows[0]["metaDescriptionNewsDeltail"].ToString();
                        txtNews.Text = dtFanShop.Rows[0]["tenNews"].ToString();
                        ASPxTokenBox1.Text = dtFanShop.Rows[0]["metaKeyword"].ToString();
                        htmlEditor.Html = dtFanShop.Rows[0]["noiDung"].ToString();
                        txtLinkSanPhamQC.Text = dtFanShop.Rows[0]["linkProduct"].ToString();
                        cbkHienThi.Checked = ((bool)dtFanShop.Rows[0]["hienThi"]) ? true : false;
                        cbkActive.Checked = ((bool)dtFanShop.Rows[0]["Active"]) ? true : false;
                        hdImage1.Value = dtFanShop.Rows[0]["avatarNewsDeltail"].ToString();
                        hdImage2.Value = dtFanShop.Rows[0]["avatarNewsDeltailHome"].ToString();
                        hdImage3.Value = dtFanShop.Rows[0]["images1"].ToString();
                        hdImage4.Value = dtFanShop.Rows[0]["images2"].ToString();
                        hdImage5.Value = dtFanShop.Rows[0]["images3"].ToString();
                        hdImage6.Value = dtFanShop.Rows[0]["images4"].ToString();
                        hdImage7.Value = dtFanShop.Rows[0]["images5"].ToString();
                        hdImage8.Value = dtFanShop.Rows[0]["images6"].ToString();
                        hdImage9.Value = dtFanShop.Rows[0]["images7"].ToString();
                        hdImage10.Value = dtFanShop.Rows[0]["imagesProductQC"].ToString();
                        hdImage11.Value = dtFanShop.Rows[0]["imagesProductQCMobile"].ToString();
                        hdValue.Value = e.CommandArgument.ToString();
                        hdInsert.Value = "update";
                        mlv.ActiveViewIndex = 1;
                    }
                    break;
                case "delete":

                    if (dtFanShop.Rows.Count > 0)
                    {
                        if (System.IO.File.Exists(Server.MapPath("~/" + dtFanShop.Rows[0]["avatarNewsDeltail"])) == true)
                        {
                            System.IO.File.Delete(Server.MapPath("~/" + dtFanShop.Rows[0]["avatarNewsDeltail"]));
                        }
                        if (System.IO.File.Exists(Server.MapPath("~/" + dtFanShop.Rows[0]["avatarNewsDeltailHome"])) == true)
                        {
                            System.IO.File.Delete(Server.MapPath("~/" + dtFanShop.Rows[0]["avatarNewsDeltailHome"]));
                        }
                        if (System.IO.File.Exists(Server.MapPath("~/" + dtFanShop.Rows[0]["images1"])) == true)
                        {
                            System.IO.File.Delete(Server.MapPath("~/" + dtFanShop.Rows[0]["images1"]));
                        }
                        if (System.IO.File.Exists(Server.MapPath("~/" + dtFanShop.Rows[0]["images2"])) == true)
                        {
                            System.IO.File.Delete(Server.MapPath("~/" + dtFanShop.Rows[0]["images2"]));
                        }
                        if (System.IO.File.Exists(Server.MapPath("~/" + dtFanShop.Rows[0]["images3"])) == true)
                        {
                            System.IO.File.Delete(Server.MapPath("~/" + dtFanShop.Rows[0]["images3"]));
                        }
                        if (System.IO.File.Exists(Server.MapPath("~/" + dtFanShop.Rows[0]["images4"])) == true)
                        {
                            System.IO.File.Delete(Server.MapPath("~/" + dtFanShop.Rows[0]["images4"]));
                        }
                        if (System.IO.File.Exists(Server.MapPath("~/" + dtFanShop.Rows[0]["images5"])) == true)
                        {
                            System.IO.File.Delete(Server.MapPath("~/" + dtFanShop.Rows[0]["images5"]));
                        }
                        if (System.IO.File.Exists(Server.MapPath("~/" + dtFanShop.Rows[0]["images6"])) == true)
                        {
                            System.IO.File.Delete(Server.MapPath("~/" + dtFanShop.Rows[0]["images6"]));
                        }
                        if (System.IO.File.Exists(Server.MapPath("~/" + dtFanShop.Rows[0]["images7"])) == true)
                        {
                            System.IO.File.Delete(Server.MapPath("~/" + dtFanShop.Rows[0]["images7"]));
                        }
                        if (System.IO.File.Exists(Server.MapPath("~/" + dtFanShop.Rows[0]["imagesProductQC"])) == true)
                        {
                            System.IO.File.Delete(Server.MapPath("~/" + dtFanShop.Rows[0]["imagesProductQC"]));
                        }
                        if (System.IO.File.Exists(Server.MapPath("~/" + dtFanShop.Rows[0]["imagesProductQCMobile"])) == true)
                        {
                            System.IO.File.Delete(Server.MapPath("~/" + dtFanShop.Rows[0]["imagesProductQCMobile"]));
                        }

                        _quanlydanhmuctintuc.deleteNewsDeltail(int.Parse(e.CommandArgument.ToString()));
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
                clsThuVien.updateHienThi("NewsDeltail", "maNewsDeltail", itemID, itemState);
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
                clsThuVien.updateActive("NewsDeltail", "maNewsDeltail", itemID, itemState);
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