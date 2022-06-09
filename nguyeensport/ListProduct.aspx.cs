using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using nguyeensport.dal;
namespace nguyeensport
{
    public partial class ListProduct : System.Web.UI.Page
    {
        clsquanlydanhmuc _quanlydanhmuc = new clsquanlydanhmuc();
        DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            loadheader.Controls.Add(LoadControl("Display/header.ascx"));
            loadMenuList1.Controls.Add(LoadControl("Display/menulist1.ascx"));
            loadMenuList2.Controls.Add(LoadControl("Display/menulist2.ascx"));
            loadSearch.Controls.Add(LoadControl("Display/search.ascx"));
            loadGioHang.Controls.Add(LoadControl("Display/giohang.ascx"));
            loadfooter.Controls.Add(LoadControl("Display/footer.ascx"));

            string page = Page.RouteData.Values["page"] as string;
            string sex = "/p/"+ page+ "/" +Page.RouteData.Values["sex"] as string;
            if(page != null)
            {
                if(page == "fan-shop")
                {
                    if(sex != null)
                    {
                        dt = _quanlydanhmuc.laySubPanertCategoriesTheoLink(sex);
                        if(dt.Rows.Count > 0)
                        {
                            if(sex == dt.Rows[0]["linkDanhMucCon"].ToString())
                            {
                                ltTitle.Text = dt.Rows[0]["titleDanhMucCon"].ToString();
                                ltMetaDescription.Text = dt.Rows[0]["metaDescriptionDanhMucCon"].ToString();
                                ltMetaKeyword.Text = dt.Rows[0]["metaKeywordsDanhMucCon"].ToString();
                                loadMain.Controls.Add(LoadControl("Display/Activity/activity.ascx"));
                            }
                            
                        }
                        else
                        {
                            Server.TransferRequest("/404");
                        }
                       
                    }
                    else
                    {
                        Server.TransferRequest("/404");
                    }
                }
            }
            else
            {
                Server.TransferRequest("/404");
            }


        }
    }
}