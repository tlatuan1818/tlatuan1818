using nguyeensport.dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace nguyeensport.Display
{
    public partial class menulist2 : System.Web.UI.UserControl
    {
        clsquanlydanhmuc _quanlydanhmuc = new clsquanlydanhmuc();
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        void LoadData()
        {
            rptMenuList.DataSource = _quanlydanhmuc.layCategoriesTheoHienThi();
            rptMenuList.DataBind();
        }

        protected void rptMenuList_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                string maDanhMuc = (e.Item.FindControl("hdMaDanhMuc") as HiddenField).Value;
                Repeater rptSubMenuList = e.Item.FindControl("rptSubMenuList") as Repeater;
                rptSubMenuList.DataSource = _quanlydanhmuc.laySubPanertCategoriesTheoMaDanhMucHienThi(int.Parse(maDanhMuc));
                rptSubMenuList.DataBind();

                for (int i = 0; i < rptSubMenuList.Items.Count; i++)
                {
                    HiddenField hfIDDanhMucCon = rptSubMenuList.Items[i].FindControl("hfIDDanhMucCon") as HiddenField;
                    HiddenField hfViTri = rptSubMenuList.Items[i].FindControl("hfViTri") as HiddenField;
                    Repeater rptMenuList2 = rptSubMenuList.Items[i].FindControl("rptMenuList2") as Repeater;
                    rptMenuList2.DataSource = _quanlydanhmuc.laySubChildCategoriesTheoMaDanhMucHienThi(int.Parse(hfIDDanhMucCon.Value), int.Parse(hfViTri.Value));
                    rptMenuList2.DataBind();

                }
            }
        }
    }
}