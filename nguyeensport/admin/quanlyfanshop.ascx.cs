using nguyeensport.dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;
using System.Text.RegularExpressions;
using System.Text;
using System.Web.Services;
using System.Web.Script.Services;
using System.Data.SqlClient;
using System.Drawing;
using Facebook;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;


namespace nguyeensport.admin
{
    public partial class quanlyfanshop : System.Web.UI.UserControl
    {
        clsquanlygender _quanlygender = new clsquanlygender();
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        void LoadData()
        {
            rptListProduct.DataSource = clsquanlyfanshop.layAllFanshop();
            rptListProduct.DataBind();
            //v2
            drGender.DataSource = _quanlygender.layGender();
            drGender.DataValueField = "maGender";
            drGender.DataTextField = "tenGender";
            drGender.DataBind();
            drGender.Items.Insert(0, new ListItem("Chọn giới tính", "0"));
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
                if(dtProductSize.Rows.Count > 0)
                {
                    int tong = 0;
                    for(int i = 0; i < dtProductSize.Rows.Count; i++)
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
       
        public DataTable Tabulate(string json)
        {
            var jsonLinq = JObject.Parse(json);

            // Find the first array using Linq
            var srcArray = jsonLinq.Descendants().Where(d => d is JArray).First();
            var trgArray = new JArray();
            foreach (JObject row in srcArray.Children<JObject>())
            {
                var cleanRow = new JObject();
                foreach (JProperty column in row.Properties())
                {
                    // Only include JValue types
                    if (column.Value is JValue)
                    {
                        cleanRow.Add(column.Name, column.Value);
                    }
                }

                trgArray.Add(cleanRow);
            }

            return JsonConvert.DeserializeObject<DataTable>(trgArray.ToString());
        }
        private void CheckAuthorization(string text)
        {
            //string app_id = "828465094768129";
            //string app_secret = "0f5c7dc339e587e354c8131ba1a32adf";
            //string scope = " publish_actions,pages_show_list, pages_read_engagement, pages_manage_metadata, pages_read_user_content,  pages_manage_posts, pages_manage_engagement, public_profile";
            //if (Request["code"] == null)
            //{
            //    Response.Redirect(string.Format("https://www.facebook.com/v13.0/dialog/oauth?client_id={0}&redirect_uri={1}&state={2}"
            //        , app_id, Request.Url.AbsoluteUri, scope));
            //}
            //else
            //{
            //    Dictionary<string, string> tokens = new Dictionary<string, string>();
            //    //string url = string.Format("https://graph.facebook.com/oauth/access_token?client_id={0}&redirect_uri={1}&scope={2}&code={3}&client_secret={4}",app_id, Request.Url.AbsoluteUri,scope,Request["code"].ToString(),app_secret);

            //    //HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
            //    //string token;
            //    //using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
            //    //{
            //    //    StreamReader reader = new StreamReader(response.GetResponseStream());
            //    //    var vals = reader.ReadToEnd();
            //    //    var arr = vals.Split(':').ToArray();
            //    //    token = arr[1].Split(',').First();
            //    //    token = token.Substring(1);
            //    //    token = token.Substring(0, token.Length - 1);
            //    //}
          

           //}
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            var strPath = clsThuVien.getImages(hdImage1.Value, hdImage2.Value, hdImage3.Value, hdImage4.Value, hdImage5.Value, hdImage6.Value, hdImage7.Value, hdImage8.Value, hdImage9.Value, hdImage10.Value,txtTenSanPham.Text.Trim());
            if (!string.IsNullOrEmpty(txtMaSanPham.Text.Trim()))
            {
                try
                {
                    DataTable dtSizeOFProduct = new DataTable();
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
                        clsquanlyproduct.insertProduct(id, txtMaSanPham.Text.Trim(), txtTenSanPham.Text.Trim(), htmlEditor.Html.ToString(), float.Parse(txtGia.Text.Trim()), drDiscount.SelectedItem.ToString(), giaOutput, 1, txtTitle.Text.Trim(), txtMetaDescription.Text.Trim(), txtKeyword.Text.Trim(), clsThuVien.utf8Convert3(txtTenSanPham.Text.Trim()).ToLower().Replace(" ", "-"), strPath[0].ToString(), strPath[1].ToString(), strPath[2].ToString(), strPath[3].ToString(), strPath[4].ToString(), strPath[5].ToString(), strPath[6].ToString(), strPath[7].ToString(), strPath[8].ToString(), strPath[9].ToString(), 0, 0, DateTime.Now, hienThi, Active);
                        clsquanlyfanshop.insertFanShop(txtMaSanPham.Text.Trim(), txtProductType.Text.Trim(), txtdrSubType.Text.Trim(), drGender.SelectedItem.ToString(), txtBrands.Text.Trim(), txtLeague.Text.Trim(), txtTeam.Text.Trim(), txtRange.Text.Trim(), txtVersion.Text.Trim());
                        dtSizeOFProduct = clsquanlyproduct.laySizeOfProduct(txtMaSanPham.Text.Trim());
                        if (dtSizeOFProduct.Rows.Count <= 0)
                        {
                            clsquanlyproduct.insertProductSize(txtMaSanPham.Text.Trim(), lblS.Text.Trim(), Convert.ToInt32(txtS.Text.Trim() == "" ? null : txtS.Text.Trim()));
                            clsquanlyproduct.insertProductSize(txtMaSanPham.Text.Trim(), lblM.Text.Trim(), Convert.ToInt32(txtM.Text.Trim() == "" ? null : txtM.Text.Trim()));
                            clsquanlyproduct.insertProductSize(txtMaSanPham.Text.Trim(), lblL.Text.Trim(), Convert.ToInt32(txtL.Text.Trim() == "" ? null : txtL.Text.Trim()));
                            clsquanlyproduct.insertProductSize(txtMaSanPham.Text.Trim(), lblXL.Text.Trim(), Convert.ToInt32(txtXL.Text.Trim() == "" ? null : txtXL.Text.Trim()));
                            clsquanlyproduct.insertProductSize(txtMaSanPham.Text.Trim(), lblXXL.Text.Trim(), Convert.ToInt32(txtXXL.Text.Trim() == "" ? null : txtXXL.Text.Trim()));
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
                        catch(Exception ex)
                        {

                        }
                        clsquanlyproduct.updateProduct(txtMaSanPham.Text.Trim(), txtTenSanPham.Text.Trim(), htmlEditor.Html.ToString(), float.Parse(txtGia.Text.Trim()), drDiscount.SelectedItem.ToString(), giaOutput, 1, txtTitle.Text.Trim(), txtMetaDescription.Text.Trim(), txtKeyword.Text.Trim(), clsThuVien.utf8Convert3(txtTenSanPham.Text.Trim()).ToLower().Replace(" ", "-"), strPath[0].ToString(), strPath[1].ToString(), strPath[2].ToString(), strPath[3].ToString(), strPath[4].ToString(), strPath[5].ToString(), strPath[6].ToString(), strPath[7].ToString(), strPath[8].ToString(), strPath[9].ToString(), DateTime.Now, hienThi, Active);
                        clsquanlyfanshop.updateFanShop(txtMaSanPham.Text.Trim(), txtProductType.Text.Trim(), txtdrSubType.Text.Trim(), drGender.SelectedItem.ToString(), txtBrands.Text.Trim(), txtLeague.Text.Trim(), txtTeam.Text.Trim(), txtRange.Text.Trim(), txtVersion.Text.Trim());
                        clsquanlyproduct.updateProductSize(txtMaSanPham.Text.Trim(), lblS.Text.Trim(), Convert.ToInt32(txtS.Text.Trim() == "" ? null : txtS.Text.Trim()));
                        clsquanlyproduct.updateProductSize(txtMaSanPham.Text.Trim(), lblM.Text.Trim(), Convert.ToInt32(txtM.Text.Trim() == "" ? null : txtM.Text.Trim()));
                        clsquanlyproduct.updateProductSize(txtMaSanPham.Text.Trim(), lblL.Text.Trim(), Convert.ToInt32(txtL.Text.Trim() == "" ? null : txtL.Text.Trim()));
                        clsquanlyproduct.updateProductSize(txtMaSanPham.Text.Trim(), lblXL.Text.Trim(), Convert.ToInt32(txtXL.Text.Trim() == "" ? null :  txtXL.Text.Trim()));
                        clsquanlyproduct.updateProductSize(txtMaSanPham.Text.Trim(), lblXXL.Text.Trim(), Convert.ToInt32(txtXXL.Text.Trim() == "" ? null : txtXXL.Text.Trim()));
                        lblThongBao2.Text = "<div class='alert alert-success alert-dismissible fade show' role='alert'>" +
                                            "Sửa thành công" +
                                "<button type='button' class='close' data-dismiss='alert' aria-label='Close'>" +
                                "<span aria-hidden='true'>&times;</span>" +
                                "</button>" +
                            "</div>";
                    }
                }
                catch (Exception ex) {
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
            DataTable dtFanShop = new DataTable();
            dtFanShop = clsquanlyfanshop.layFanShopTheoID(e.CommandArgument.ToString());
          
            switch (e.CommandName)
            {
                case "update":
                   
                    if(dtFanShop.Rows.Count > 0)
                    {
                        txtMaSanPham.Text = dtFanShop.Rows[0]["maSanPham"].ToString();
                        txtTenSanPham.Text = dtFanShop.Rows[0]["tenSanPham"].ToString();
                        txtTitle.Text = dtFanShop.Rows[0]["titleSanPham"].ToString();
                        txtMetaDescription.Text = dtFanShop.Rows[0]["metaDescriptionSanPham"].ToString();
                        txtKeyword.Text = dtFanShop.Rows[0]["metaKeywordsSanPham"].ToString();
                        htmlEditor.Html = dtFanShop.Rows[0]["motaSanPham"].ToString();
                        txtGia.Text = dtFanShop.Rows[0]["giaInput"].ToString();
                        txtBrands.Text = dtFanShop.Rows[0]["brands"].ToString();
                        txtdrSubType.Text = dtFanShop.Rows[0]["subType"].ToString();
                        txtProductType.Text = dtFanShop.Rows[0]["productType"].ToString();
                        txtTeam.Text = dtFanShop.Rows[0]["team"].ToString();
                        txtLeague.Text = dtFanShop.Rows[0]["league"].ToString();
                        txtRange.Text = dtFanShop.Rows[0]["range"].ToString();
                        txtVersion.Text = dtFanShop.Rows[0]["version"].ToString();
                        cbkActive.Checked = ((bool)dtFanShop.Rows[0]["Active"]) ? true:false;
                        cbkHienThi.Checked = ((bool)dtFanShop.Rows[0]["hienTHi"]) ? true:false;
                        hdImage1.Value = dtFanShop.Rows[0]["avatarSanPham"].ToString();
                        hdImage2.Value = dtFanShop.Rows[0]["anh1"].ToString();
                        hdImage3.Value = dtFanShop.Rows[0]["anh2"].ToString();
                        hdImage4.Value = dtFanShop.Rows[0]["anh3"].ToString();
                        hdImage5.Value = dtFanShop.Rows[0]["anh4"].ToString();
                        hdImage6.Value = dtFanShop.Rows[0]["anh5"].ToString();
                        hdImage7.Value = dtFanShop.Rows[0]["anh6"].ToString();
                        hdImage8.Value = dtFanShop.Rows[0]["anh7"].ToString();
                        hdImage9.Value = dtFanShop.Rows[0]["anh8"].ToString();
                        hdImage10.Value = dtFanShop.Rows[0]["anh9"].ToString();
                        DataTable dtProductSize = new DataTable();
                        dtProductSize = clsquanlyproduct.layProductSizeTheoMaSanPham(dtFanShop.Rows[0]["maSanPham"].ToString());
                        if(dtProductSize.Rows.Count > 0)
                        {  for(int i = 0; i< dtProductSize.Rows.Count; i++)
                           {
                                if (dtProductSize.Rows[i]["tenSize"].ToString() == "S") {
                                    txtS.Text = dtProductSize.Rows[i]["soLuong"].ToString();
                                }
                                if (dtProductSize.Rows[i]["tenSize"].ToString() == "M")
                                {
                                    txtM.Text = dtProductSize.Rows[i]["soLuong"].ToString();
                                }
                                if (dtProductSize.Rows[i]["tenSize"].ToString() == "L")
                                {
                                    txtL.Text = dtProductSize.Rows[i]["soLuong"].ToString();
                                }
                                if (dtProductSize.Rows[i]["tenSize"].ToString() == "XL")
                                {
                                    txtXL.Text = dtProductSize.Rows[i]["soLuong"].ToString();
                                }
                                if (dtProductSize.Rows[i]["tenSize"].ToString() == "XXL")
                                {
                                    txtXXL.Text = dtProductSize.Rows[i]["soLuong"].ToString();
                                }
                            }
                           
                        }
                        hdInsert.Value = "update";
                        hdId_FB.Value = dtFanShop.Rows[0]["id_FB"].ToString();
                        mlv.ActiveViewIndex = 1;
                    }
                    break;
                case "delete":

                    if (dtFanShop.Rows.Count > 0)
                    {
                        if (dtFanShop.Rows[0]["avatarSanPham"].ToString().Length > 0){
                          
                            clsThuVien.deleteImage(dtFanShop.Rows[0]["avatarSanPham"].ToString().Substring(52).Replace(".jpg", "").Replace(".png", ""));
                        }
                        if(dtFanShop.Rows[0]["anh1"].ToString().Length > 0)
                        {
                            clsThuVien.deleteImage(dtFanShop.Rows[0]["anh1"].ToString().Substring(52).Replace(".jpg","").Replace(".png",""));
                        }
                        if (dtFanShop.Rows[0]["anh2"].ToString().Length > 0)
                        {
                            clsThuVien.deleteImage(dtFanShop.Rows[0]["anh2"].ToString().Substring(52).Replace(".jpg", "").Replace(".png", ""));
                        }
                        if (dtFanShop.Rows[0]["anh3"].ToString().Length > 0)
                        {
                            clsThuVien.deleteImage(dtFanShop.Rows[0]["anh3"].ToString().Substring(52).Replace(".jpg", "").Replace(".png", ""));
                        }
                        if (dtFanShop.Rows[0]["anh4"].ToString().Length > 0)
                        {
                            clsThuVien.deleteImage(dtFanShop.Rows[0]["anh4"].ToString().Substring(52).Replace(".jpg", "").Replace(".png", ""));
                        }
                        if (dtFanShop.Rows[0]["anh5"].ToString().Length > 0)
                        {
                            clsThuVien.deleteImage(dtFanShop.Rows[0]["anh5"].ToString().Substring(52).Replace(".jpg", "").Replace(".png", ""));
                        }
                        if (dtFanShop.Rows[0]["anh6"].ToString().Length > 0)
                        {
                            clsThuVien.deleteImage(dtFanShop.Rows[0]["anh6"].ToString().Substring(52).Replace(".jpg", "").Replace(".png", ""));
                        }
                        if (dtFanShop.Rows[0]["anh7"].ToString().Length > 0)
                        {
                            clsThuVien.deleteImage(dtFanShop.Rows[0]["anh7"].ToString().Substring(52).Replace(".jpg", "").Replace(".png", ""));
                        }
                        if (dtFanShop.Rows[0]["anh8"].ToString().Length > 0)
                        {
                            clsThuVien.deleteImage(dtFanShop.Rows[0]["anh8"].ToString().Substring(52).Replace(".jpg", "").Replace(".png", ""));
                        }
                        if (dtFanShop.Rows[0]["anh9"].ToString().Length > 0)
                        {
                            clsThuVien.deleteImage(dtFanShop.Rows[0]["anh9"].ToString().Substring(52).Replace(".jpg", "").Replace(".png", ""));
                        }
                        clsquanlyproduct.deleteProductSize(dtFanShop.Rows[0]["maSanPham"].ToString());
                        clsquanlyfanshop.deleteFanShop(dtFanShop.Rows[0]["maSanPham"].ToString());
                        clsquanlyproduct.deleteProduct(dtFanShop.Rows[0]["maSanPham"].ToString());
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