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
using DevExpress.Web.ASPxTreeList;
using nguyeensport.dal;

namespace nguyeensport.admin.ortherpage
{
    public partial class category : System.Web.UI.UserControl
    {
        clsquanlydanhmuc _quanlydanhmuc = new clsquanlydanhmuc();
        protected void Page_Load(object sender, EventArgs e)
        {
             LoadData();
        }
        void LoadData()
        {
            rptListProduct.DataSource = _quanlydanhmuc.layCategories();
            rptListProduct.DataBind();
            //v2
            cbkHienThi.InputAttributes.Add("class", "custom-control-input");
            cbkHienThi.LabelAttributes.Add("class", "custom-control-label");
            cbkActive.InputAttributes.Add("class", "custom-control-input");
            cbkActive.LabelAttributes.Add("class", "custom-control-label");
            ckbHienThi1.InputAttributes.Add("class", "custom-control-input");
            ckbHienThi1.LabelAttributes.Add("class", "custom-control-label");
            ckbActive1.InputAttributes.Add("class", "custom-control-input");
            ckbActive1.LabelAttributes.Add("class", "custom-control-label");
            cbkHienThi2.InputAttributes.Add("class", "custom-control-input");
            cbkHienThi2.LabelAttributes.Add("class", "custom-control-label");
            cbkActive2.InputAttributes.Add("class", "custom-control-input");
            cbkActive2.LabelAttributes.Add("class", "custom-control-label");
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
                HiddenField hdMaDanhMuc = e.Item.FindControl("hdMaDanhMuc") as HiddenField;
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
                cbkHienThi.InputAttributes.Add("Value", hdMaDanhMuc.Value.ToString());
                cbkActive.InputAttributes.Add("Value", hdMaDanhMuc.Value.ToString());
                Repeater rptSubMenuList = e.Item.FindControl("rptSubMenuList") as Repeater;
                rptSubMenuList.DataSource = _quanlydanhmuc.laySubPanertCategoriesTheoMaDanhMucHienThi(int.Parse(hdMaDanhMuc.Value.ToString()));
                rptSubMenuList.DataBind();
                for (int i = 0; i < rptSubMenuList.Items.Count; i++)
                {
                    HiddenField hfIDDanhMucCon = rptSubMenuList.Items[i].FindControl("hfIDDanhMucCon") as HiddenField;
                    HiddenField hfViTri = rptSubMenuList.Items[i].FindControl("hfViTri") as HiddenField;
                    CheckBox cbkHienThi1 = rptSubMenuList.Items[i].FindControl("ckbHienThi1") as CheckBox;
                    cbkHienThi1.InputAttributes.Add("class", "custom-control-input");
                    cbkHienThi1.LabelAttributes.Add("class", "custom-control-label");
                    cbkHienThi1.InputAttributes.Add("Value", hfIDDanhMucCon.Value.ToString());
                   
                    CheckBox cbkActive1 = rptSubMenuList.Items[i].FindControl("ckbActive1") as CheckBox;
                    cbkActive1.InputAttributes.Add("class", "custom-control-input");
                    cbkActive1.LabelAttributes.Add("class", "custom-control-label");
                    cbkActive1.InputAttributes.Add("Value", hfIDDanhMucCon.Value.ToString());
                    LinkButton lnkbutAdd = rptSubMenuList.Items[i].FindControl("lnkbutAdd1") as LinkButton;
                    LinkButton lnkbutEdit = rptSubMenuList.Items[i].FindControl("lnkbutEdit1") as LinkButton;
                    LinkButton lnkbutDelete = rptSubMenuList.Items[i].FindControl("lnkbutDelete1") as LinkButton;
                    if (cbkHienThi1.Text == "True")
                    {
                        cbkHienThi1.Checked = true;
                    }
                    else
                    {
                        cbkHienThi1.Checked = false;
                    }

                    if (cbkActive1.Text == "True")
                    {
                        cbkActive1.Checked = true;
                    }
                    else
                    {
                        cbkActive1.Checked = false;
                    }
                    lnkbutAdd.Click += LnkbutAdd_Click;
               
                   
                    Repeater rptMenuList2 = rptSubMenuList.Items[i].FindControl("rptMenuList2") as Repeater;
                    rptMenuList2.DataSource = _quanlydanhmuc.laySubChildCategoriesTheoMaDanhMucHienThi(int.Parse(hfIDDanhMucCon.Value), int.Parse(hfViTri.Value));
                    rptMenuList2.DataBind();
                    for (int j = 0; j < rptMenuList2.Items.Count; j++)
                    {
                        HiddenField hdMaDanhMucConCap1 = rptMenuList2.Items[j].FindControl("hfMaDanhMucConCap1") as HiddenField;
                        CheckBox cbkHienThi2 = rptMenuList2.Items[j].FindControl("ckbHienThi2") as CheckBox;
                        cbkHienThi2.InputAttributes.Add("class", "custom-control-input");
                        cbkHienThi2.LabelAttributes.Add("class", "custom-control-label");
                        cbkHienThi2.InputAttributes.Add("Value", hdMaDanhMucConCap1.Value.ToString());
                        CheckBox cbkActive2 = rptMenuList2.Items[j].FindControl("ckbActive2") as CheckBox;
                        cbkActive2.InputAttributes.Add("class", "custom-control-input");
                        cbkActive2.LabelAttributes.Add("class", "custom-control-label");
                        cbkActive2.InputAttributes.Add("Value", hdMaDanhMucConCap1.Value.ToString());
                        if (cbkActive2.Text == "True")
                        {
                            cbkActive2.Checked = true;
                        }
                        else
                        {
                            cbkActive2.Checked = false;
                        }

                        if (cbkHienThi2.Text == "True")
                        {
                            cbkHienThi2.Checked = true;
                        }
                        else
                        {
                            cbkHienThi2.Checked = false;
                        }

                    }
                }
            }
        }

        private void LnkbutAdd_Click(object sender, EventArgs e)
        {
            mlv.ActiveViewIndex = 3;
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

            if (!string.IsNullOrEmpty(txtTenDanhMuc.Text.Trim()))
            {
                try
                {
                    if (hdInsert.Value.ToString() == "insert")
                    {
                        bool Active = cbkActive.Checked ? true : false;
                        bool hienThi = cbkHienThi.Checked ? true : false;
                        _quanlydanhmuc.insertCategories(txtTenDanhMuc.Text.Trim(), utf8Convert3(txtTenDanhMuc.Text.Trim()).ToLower().Replace(" ", "-"), txtTitle.Text.Trim(), txtMetaDescription.Text.Trim(), ASPxTokenBox1.Text.Trim(), DateTime.Now, hienThi, Active);
                        lblThongBao1.Text = "<div class='alert alert-success alert-dismissible fade show' role='alert'>" +
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
                        _quanlydanhmuc.updateCategories(int.Parse(hdValue.Value.ToString()), txtTenDanhMuc.Text.Trim(), utf8Convert3(txtTenDanhMuc.Text.Trim()).ToLower().Replace(" ", "-"), txtTitle.Text.Trim(), txtMetaDescription.Text.Trim(), ASPxTokenBox1.Text.Trim(), DateTime.Now, hienThi, Active);
                        lblThongBao1.Text = "<div class='alert alert-success alert-dismissible fade show' role='alert'>" +
                                          "Sửa thành công" +
                              "<button type='button' class='close' data-dismiss='alert' aria-label='Close'>" +
                              "<span aria-hidden='true'>&times;</span>" +
                              "</button>" +
                          "</div>";
                    }
                }
                catch(Exception ex)
                {
                    lblThongBao1.Text = "<div class='alert alert-warning alert-dismissible fade show' role='alert'>" +
                                          ex.ToString() +
                              "<button type='button' class='close' data-dismiss='alert' aria-label='Close'>" +
                              "<span aria-hidden='true'>&times;</span>" +
                              "</button>" +
                          "</div>";
                }
            }
            else
            {
                txtTenDanhMuc.CssClass = "form-control is-invalid";
            }

        }

        protected void btnXoa_Load(object sender, EventArgs e)
        {
            ((LinkButton)sender).Attributes["onclick"] = "return confirm('Bạn có muốn xóa dòng này không ?')";
        }

        protected void rptListProduct_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            DataTable dtBrands = new DataTable();
            dtBrands = _quanlydanhmuc.layCategoriesTheoID(int.Parse(e.CommandArgument.ToString()));
            switch (e.CommandName)
            {
                case "insert":
                    mlv.ActiveViewIndex = 2;
                    hdInsert1.Value = "insert";
                    hdValue1.Value = e.CommandArgument.ToString();
                   
                    break;
                case "update":

                    if (dtBrands.Rows.Count > 0)
                    {
                        txtTenDanhMuc.Text = dtBrands.Rows[0]["tenDanhMuc"].ToString();
                        txtTitle.Text = dtBrands.Rows[0]["titleDanhMuc"].ToString();
                        txtMetaDescription.Text = dtBrands.Rows[0]["metaDescriptionDanhMuc"].ToString();
                        ASPxTokenBox1.Text = dtBrands.Rows[0]["metaKeywordsDanhMuc"].ToString();
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
                        _quanlydanhmuc.deleteDanhMuc(int.Parse(e.CommandArgument.ToString()));
                        LoadData();
                    }
                    break;
            }
        }

        protected void btnUpdatePanertCategori_Click(object sender, EventArgs e)
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
                    path = utf8Convert3(txtTenDanhMucCon.Text).ToLower().Replace(" ", "-").Replace("/", "-") + "-" + i + fileextension;
                    hpf.SaveAs(Server.MapPath("~/images/anh-danh-muc-con") + "/" + path);
                    if (i == 0)
                    {
                        image1 = "/images/anh-danh-muc-con/" + path;
                    }
                    if (i == 1)
                    {
                        image2 = "/images/anh-danh-muc-con/" + path;
                    }
                }
            }
            if (!image1.Equals(hdImage1.Value))
            {
                if (!hdImage1.Value.Equals(""))
                {
                    if (System.IO.File.Exists(Server.MapPath("~/images/anh-danh-muc-con" + hdImage1.Value)) == true)
                    {
                        System.IO.File.Exists(Server.MapPath("~/images/anh-danh-muc-con" + hdImage1.Value));
                    }
                }
            }
            if (!image2.Equals(hdImage2.Value))
            {
                if (!hdImage2.Value.Equals(""))
                {
                    if (System.IO.File.Exists(Server.MapPath("~/images/anh-danh-muc-con" + hdImage2.Value)) == true)
                    {
                        System.IO.File.Exists(Server.MapPath("~/images/anh-danh-muc-con" + hdImage2.Value));
                    }
                }
            }
            DataTable dtDanhMuc = new DataTable();
            dtDanhMuc = _quanlydanhmuc.layCategoriesTheoID(int.Parse(hdValue1.Value.ToString()));

            if (!string.IsNullOrEmpty(txtTenDanhMucCon.Text.Trim()))
            {
                try
                {
                    if (hdInsert1.Value.ToString() == "insert")
                    {
                        bool Active1 = ckbActive1.Checked ? true : false;
                        bool hienThi1 = ckbHienThi1.Checked ? true : false;
                        _quanlydanhmuc.insertPanertCategories(int.Parse(hdValue1.Value.ToString()), txtTenDanhMucCon.Text.Trim(), int.Parse(txtVitri.Text.Trim()), image1, image2, "/p/" + utf8Convert3(dtDanhMuc.Rows[0]["tenDanhMuc"].ToString()).ToLower().Replace(" ", "-") + "/" + utf8Convert3(txtTenDanhMucCon.Text.Trim()).ToLower().Replace(" ", "-"), txtTitlePanertCategori.Text.Trim(), txtMetaDescriptionPanertCategori.Text.Trim(), ASPxTokenBox2.Text.Trim(), DateTime.Now, hienThi1, Active1);
                        lblThongBao.Text = "<div class='alert alert-success alert-dismissible fade show' role='alert'>" +
                                            "Thêm thành công" +
                                "<button type='button' class='close' data-dismiss='alert' aria-label='Close'>" +
                                "<span aria-hidden='true'>&times;</span>" +
                                "</button>" +
                            "</div>";
                    }
                    else
                    {
                        bool Active1 = ckbActive1.Checked ? true : false;
                        bool hienThi1 = ckbHienThi1.Checked ? true : false;
                        _quanlydanhmuc.updatePanertCategories(int.Parse(hdValue2.Value.ToString()), int.Parse(hdValue1.Value.ToString()), txtTenDanhMucCon.Text.Trim(), int.Parse(txtVitri.Text.Trim()), image1, image2, "/p/" + utf8Convert3(dtDanhMuc.Rows[0]["tenDanhMuc"].ToString()).ToLower().Replace(" ", "-") + "/" + utf8Convert3(txtTenDanhMucCon.Text.Trim()).ToLower().Replace(" ", "-"), txtTitlePanertCategori.Text.Trim(), txtMetaDescriptionPanertCategori.Text.Trim(), ASPxTokenBox2.Text.Trim(), DateTime.Now, hienThi1, Active1);
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
                    lblThongBao.Text = "<div class='alert  alert-warning alert-dismissible fade show' role='alert'>" +
                                           ex.ToString() +
                               "<button type='button' class='close' data-dismiss='alert' aria-label='Close'>" +
                               "<span aria-hidden='true'>&times;</span>" +
                               "</button>" +
                           "</div>";
                }
               
            }
            else
            {
                txtTenDanhMucCon.CssClass = "form-control is-invalid";
            }
           


        }

        protected void rptSubMenuList_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            DataTable dtPanert = new DataTable();
            dtPanert = _quanlydanhmuc.laySubPanertCategoriesTheoMaDanhMucCon(int.Parse(e.CommandArgument.ToString()));
            switch (e.CommandName)
            {
                case "insert":
                    mlv.ActiveViewIndex = 3;
                    hdInsert3.Value = "insert";
                    hdValue3.Value = e.CommandArgument.ToString();
                    txtViTriChild.Text = dtPanert.Rows[0]["viTri"].ToString();
                    
                    break;
                case "update":
                    if (dtPanert.Rows.Count > 0)
                    {
                        txtTenDanhMucCon.Text = dtPanert.Rows[0]["tenDanhMucCon"].ToString();
                        txtVitri.Text = dtPanert.Rows[0]["viTri"].ToString();
                        txtTitlePanertCategori.Text = dtPanert.Rows[0]["titleDanhMucCon"].ToString();
                        txtMetaDescriptionPanertCategori.Text = dtPanert.Rows[0]["metaDescriptionDanhMucCon"].ToString();
                        ASPxTokenBox2.Text = dtPanert.Rows[0]["metaKeywordsDanhMucCon"].ToString();
                        hdImage1.Value = dtPanert.Rows[0]["anhBiaDesktop"].ToString();
                        hdImage2.Value = dtPanert.Rows[0]["anhBiaMobile"].ToString();
                        hdValue1.Value = dtPanert.Rows[0]["maDanhMuc"].ToString();
                        hdValue2.Value = e.CommandArgument.ToString();
                        ckbHienThi1.Checked = ((bool)dtPanert.Rows[0]["hienThi"]) ? true : false;
                        ckbActive1.Checked = ((bool)dtPanert.Rows[0]["Active"]) ? true : false;
                        hdInsert1.Value = "update";
                        mlv.ActiveViewIndex = 2;
                    }
                    break;
                case "delete":
                    if (dtPanert.Rows.Count > 0) {
                        if (System.IO.File.Exists(Server.MapPath("~/" + dtPanert.Rows[0]["anhBiaDesktop"])) == true)
                        {
                            System.IO.File.Delete(Server.MapPath("~/" + dtPanert.Rows[0]["anhBiaDesktop"]));
                        }
                        if (System.IO.File.Exists(Server.MapPath("~/" + dtPanert.Rows[0]["anhBiaMobile"])) == true)
                        {
                            System.IO.File.Delete(Server.MapPath("~/" + dtPanert.Rows[0]["anhBiaMobile"]));
                        }
                        _quanlydanhmuc.deletePanertCategories(int.Parse(e.CommandArgument.ToString()));
                        LoadData();
                      
                    }
                    break;
            }

        }

        protected void btnUpdateChildCategories_Click(object sender, EventArgs e)
        {
            String fileextension;
            String image3 = hdImage3.Value;
            String image4 = hdImage4.Value;
            String path = "";
            HttpFileCollection hfc = Request.Files;
            for (int i = 0; i < hfc.Count; i++)
            {
                HttpPostedFile hpf = hfc[i];
                if (hpf.ContentLength > 0)
                {
                    fileextension = Path.GetExtension(hpf.FileName);
                    path = utf8Convert3(txtTenChildCatagories.Text).ToLower().Replace(" ", "-").Replace("/", "-") + "-" + i + fileextension;
                    hpf.SaveAs(Server.MapPath("~/images/anh-danh-muc-con") + "/" + path);
                    if (i == 0)
                    {
                        image3 = "/images/anh-danh-muc-con/" + path;
                    }
                    if (i == 1)
                    {
                        image4 = "/images/anh-danh-muc-con/" + path;
                    }
                }
            }
            if (!image3.Equals(hdImage3.Value))
            {
                if (!hdImage1.Value.Equals(""))
                {
                    if (System.IO.File.Exists(Server.MapPath("~/images/anh-danh-muc-con" + hdImage3.Value)) == true)
                    {
                        System.IO.File.Exists(Server.MapPath("~/images/anh-danh-muc-con" + hdImage3.Value));
                    }
                }
            }
            if (!image4.Equals(hdImage4.Value))
            {
                if (!hdImage2.Value.Equals(""))
                {
                    if (System.IO.File.Exists(Server.MapPath("~/images/anh-danh-muc-con" + hdImage4.Value)) == true)
                    {
                        System.IO.File.Exists(Server.MapPath("~/images/anh-danh-muc-con" + hdImage4.Value));
                    }
                }
            }
            if (!string.IsNullOrEmpty(txtTenChildCatagories.Text.Trim()))
            {
                DataTable dtDanhMuc = new DataTable();
                dtDanhMuc = _quanlydanhmuc.laySubPanertCategoriesTheoMaDanhMucCon(int.Parse(hdValue3.Value.ToString()));
                try
                {
                    if(hdInsert3.Value.ToString() == "insert")
                    {
                        bool Active2 = cbkActive2.Checked ? true : false;
                        bool hienThi2 = cbkHienThi2.Checked ? true : false;
                        _quanlydanhmuc.insertChildCategories(int.Parse(hdValue3.Value.ToString()), txtTenChildCatagories.Text.Trim(),int.Parse(txtViTriChild.Text.Trim()), image3, image4, dtDanhMuc.Rows[0]["linkDanhMucCon"].ToString() + "/" + utf8Convert3(txtTenChildCatagories.Text.Trim()).ToLower().Replace(" ", "-"), txtTitleChild.Text.Trim(), txtMetaDescriptionChild.Text.Trim(), txtKeywordChild.Text.Trim(), DateTime.Now, hienThi2, Active2);
                        lblThongBao2.Text = "<div class='alert alert-success alert-dismissible fade show' role='alert'>" +
                                              "Thêm thành công" +
                                  "<button type='button' class='close' data-dismiss='alert' aria-label='Close'>" +
                                  "<span aria-hidden='true'>&times;</span>" +
                                  "</button>" +
                              "</div>";
                    }
                    else
                    {
                        bool Active2 = cbkActive2.Checked ? true : false;
                        bool hienThi2 = cbkHienThi2.Checked ? true : false;
                        _quanlydanhmuc.updateChildCategories(int.Parse(hdValue4.Value.ToString()),int.Parse(hdValue3.Value.ToString()), txtTenChildCatagories.Text.Trim(), int.Parse(txtViTriChild.Text.Trim()), image3, image4, dtDanhMuc.Rows[0]["linkDanhMucCon"].ToString() + "/" + utf8Convert3(txtTenChildCatagories.Text.Trim()).ToLower().Replace(" ", "-"), txtTitleChild.Text.Trim(), txtMetaDescriptionChild.Text.Trim(), txtKeywordChild.Text.Trim(), DateTime.Now, hienThi2, Active2);
                        lblThongBao2.Text = "<div class='alert alert-success alert-dismissible fade show' role='alert'>" +
                                         "Sửa thành công" +
                             "<button type='button' class='close' data-dismiss='alert' aria-label='Close'>" +
                             "<span aria-hidden='true'>&times;</span>" +
                             "</button>" +
                         "</div>";
                    }
                }
                catch (Exception ex)
                {
                    lblThongBao2.Text = "<div class='alert  alert-warning alert-dismissible fade show' role='alert'>" +
                                         ex.ToString() +
                             "<button type='button' class='close' data-dismiss='alert' aria-label='Close'>" +
                             "<span aria-hidden='true'>&times;</span>" +
                             "</button>" +
                         "</div>";
                }
            }
            else
            {
                txtTenChildCatagories.CssClass = "form-control is-invalid";
            }
           
        }

        protected void rptMenuList2_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            DataTable dtChild = new DataTable();
            dtChild = _quanlydanhmuc.laySubChildCategoriesTheoMaDanhMucConCap1(int.Parse(e.CommandArgument.ToString()));
            switch (e.CommandName)
            {
                case "update":
                    if(dtChild.Rows.Count > 0)
                    {
                        txtTenChildCatagories.Text = dtChild.Rows[0]["tenDanhMucConCap1"].ToString();
                        txtViTriChild.Text = dtChild.Rows[0]["viTri"].ToString();
                        txtTitleChild.Text = dtChild.Rows[0]["titleDanhMucConCap1"].ToString();
                        txtMetaDescriptionChild.Text = dtChild.Rows[0]["metaDescriptionDanhMucConCap1"].ToString();
                        txtKeywordChild.Text = dtChild.Rows[0]["metaKeywordsDanhMucConCap1"].ToString();
                        hdImage3.Value = dtChild.Rows[0]["anhBiaDesktop"].ToString();
                        hdImage4.Value = dtChild.Rows[0]["anhBiaMobile"].ToString();
                        hdValue3.Value = dtChild.Rows[0]["maDanhMucCon"].ToString();
                        hdValue4.Value = e.CommandArgument.ToString();
                        cbkHienThi2.Checked = ((bool)dtChild.Rows[0]["hienThi"]) ? true : false;
                        cbkActive2.Checked = ((bool)dtChild.Rows[0]["Active"]) ? true : false;
                        mlv.ActiveViewIndex = 3;
                        hdInsert3.Value = "update";
                    }
                    break;
                case "delete":
                    if (dtChild.Rows.Count > 0)
                    {
                        if (System.IO.File.Exists(Server.MapPath("~/" + dtChild.Rows[0]["anhBiaDesktop"])) == true)
                        {
                            System.IO.File.Delete(Server.MapPath("~/" + dtChild.Rows[0]["anhBiaDesktop"]));
                        }
                        if (System.IO.File.Exists(Server.MapPath("~/" + dtChild.Rows[0]["anhBiaMobile"])) == true)
                        {
                            System.IO.File.Delete(Server.MapPath("~/" + dtChild.Rows[0]["anhBiaMobile"]));
                        }
                        _quanlydanhmuc.deleteChildCategories(int.Parse(e.CommandArgument.ToString()));
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
                clsThuVien.updateHienThi("Categories", "maDanhMuc", itemID, itemState);
                LoadData();
            }
            catch( Exception ex)
            {
                ex.ToString();
            }
        }

        protected void ckbHienThi_Load(object sender, EventArgs e)
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
                clsThuVien.updateActive("Categories", "maDanhMuc", itemID, itemState);
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

        protected void ckbHienThi1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                CheckBox cbkHienThi1 = sender as CheckBox;
                Boolean itemState = cbkHienThi1.Checked;
                Int32 itemID = Int32.Parse(cbkHienThi1.InputAttributes["Value"].ToString());
                clsThuVien.updateHienThi("SubPanertCategories", "maDanhMucCon", itemID, itemState);
                LoadData();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        protected void ckbHienThi1_Load(object sender, EventArgs e)
        {
            ((CheckBox)sender).Attributes["onclick"] = "javascript:ShowProgressBar()";
        }

        protected void ckbActive1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                CheckBox cbkActive1 = sender as CheckBox;
                Boolean itemState = cbkActive1.Checked;
                Int32 itemID = Int32.Parse(cbkActive1.InputAttributes["Value"].ToString());
                clsThuVien.updateActive("SubPanertCategories", "maDanhMucCon", itemID, itemState);
                LoadData();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        protected void ckbActive1_Load(object sender, EventArgs e)
        {
            ((CheckBox)sender).Attributes["onclick"] = "javascript:ShowProgressBar()";
        }

        protected void ckbHienThi2_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                CheckBox cbkHienThi2 = sender as CheckBox;
                Boolean itemState = cbkHienThi2.Checked;
                Int32 itemID = Int32.Parse(cbkHienThi2.InputAttributes["Value"].ToString());
                clsThuVien.updateHienThi("SubChildCategories", "maDanhMucConCap1", itemID, itemState);
                LoadData();

            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        protected void ckbHienThi2_Load(object sender, EventArgs e)
        {
            ((CheckBox)sender).Attributes["onclick"] = "javascript:ShowProgressBar()";
        }

        protected void ckbActive2_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                CheckBox cbkActive2 = sender as CheckBox;
                Boolean itemState = cbkActive2.Checked;
                Int32 itemID = Int32.Parse(cbkActive2.InputAttributes["Value"].ToString());
                clsThuVien.updateActive("SubChildCategories", "maDanhMucConCap1", itemID, itemState);
                LoadData();

            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        protected void ckbActive2_Load(object sender, EventArgs e)
        {
            ((CheckBox)sender).Attributes["onclick"] = "javascript:ShowProgressBar()";
        }
    }
}