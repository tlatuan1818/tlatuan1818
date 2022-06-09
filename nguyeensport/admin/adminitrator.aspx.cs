using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.Script.Services;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace nguyeensport.admin
{
    public partial class adminitrator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        void LoadData()
        {
            string manager = Page.RouteData.Values["quanlypage"] as string;
            switch (manager)
            {
                case "fan-shop":
                    ltJSHeader.Text = "";
                    cssDataTable.Text = "<link href='/admin/vendor/datatables/dataTables.bootstrap4.min.css'  rel='stylesheet' />";
                    ltJSDataTable.Text = "<script src='/admin/vendor/datatables/jquery.dataTables.js'></script>";
                    ltJSCustom.Text = "<script src='/admin/js/customdataTables.js'></script>";
                    loadMain.Controls.Add(LoadControl("~/admin/quanlyfanshop.ascx"));
                    break;
                case "giay-bong-da":
                    ltJSHeader.Text = "";
                    cssDataTable.Text = "<link href='/admin/vendor/datatables/dataTables.bootstrap4.min.css'  rel='stylesheet' />";
                    ltJSDataTable.Text = "<script src='/admin/vendor/datatables/jquery.dataTables.js'></script>";
                    ltJSCustom.Text = "<script src='/admin/js/customdataTables.js'></script>";
                    loadMain.Controls.Add(LoadControl("~/admin/quanlyfootballboots.ascx"));
                    break;
                case "teamwear":
                    ltJSHeader.Text = "";
                    cssDataTable.Text = "<link href='/admin/vendor/datatables/dataTables.bootstrap4.min.css'  rel='stylesheet' />";
                    ltJSDataTable.Text = "<script src='/admin/vendor/datatables/jquery.dataTables.js'></script>";
                    ltJSCustom.Text = "<script src='/admin/js/customdataTables.js'></script>";
                    loadMain.Controls.Add(LoadControl("~/admin/quanlyteamwear.ascx"));
                    break;
                case "phu-kien":
                    ltJSHeader.Text = "";
                    cssDataTable.Text = "<link href='/admin/vendor/datatables/dataTables.bootstrap4.min.css'  rel='stylesheet' />";
                    ltJSDataTable.Text = "<script src='/admin/vendor/datatables/jquery.dataTables.js'></script>";
                    ltJSCustom.Text = "<script src='/admin/js/customdataTables.js'></script>";
                    loadMain.Controls.Add(LoadControl("~/admin/quanlyphukien.ascx"));
                    break;
                case "gender":
                    ltJSHeader.Text = "";
                    cssDataTable.Text = "<link href='/admin/vendor/datatables/dataTables.bootstrap4.min.css'  rel='stylesheet' />";
                    ltJSDataTable.Text = "<script src='/admin/vendor/datatables/jquery.dataTables.js'></script>";
                    ltJSCustom.Text = "<script src='/admin/js/customdataTables.js'></script>";
                    loadMain.Controls.Add(LoadControl("~/admin/ortherpage/gender.ascx"));
                    break;
                case "brands":
                    ltJSHeader.Text = "";
                    cssDataTable.Text = "<link href='/admin/vendor/datatables/dataTables.bootstrap4.min.css'  rel='stylesheet' />";
                    ltJSDataTable.Text = "<script src='/admin/vendor/datatables/jquery.dataTables.js'></script>";
                    ltJSCustom.Text = "<script src='/admin/js/customdataTables.js'></script>";
                    loadMain.Controls.Add(LoadControl("~/admin/ortherpage/brands.ascx"));
                    break;
                case "collection":
                    ltJSHeader.Text = "";
                    cssDataTable.Text = "<link href='/admin/vendor/datatables/dataTables.bootstrap4.min.css'  rel='stylesheet' />";
                    ltJSDataTable.Text = "<script src='/admin/vendor/datatables/jquery.dataTables.js'></script>";
                    ltJSCustom.Text = "<script src='/admin/js/customdataTables.js'></script>";
                    loadMain.Controls.Add(LoadControl("~/admin/ortherpage/collection.ascx"));
                    break;
                case "model":
                    ltJSHeader.Text = "";
                    cssDataTable.Text = "<link href='/admin/vendor/datatables/dataTables.bootstrap4.min.css'  rel='stylesheet' />";
                    ltJSDataTable.Text = "<script src='/admin/vendor/datatables/jquery.dataTables.js'></script>";
                    ltJSCustom.Text = "<script src='/admin/js/customdataTables.js'></script>";
                    loadMain.Controls.Add(LoadControl("~/admin/ortherpage/model.ascx"));
                    break;
                case "producttype":
                    ltJSHeader.Text = "";
                    cssDataTable.Text = "<link href='/admin/vendor/datatables/dataTables.bootstrap4.min.css'  rel='stylesheet' />";
                    ltJSDataTable.Text = "<script src='/admin/vendor/datatables/jquery.dataTables.js'></script>";
                    ltJSCustom.Text = "<script src='/admin/js/customdataTables.js'></script>";
                    loadMain.Controls.Add(LoadControl("~/admin/ortherpage/producttype.ascx"));
                    break;
                case "productsubtype":
                    ltJSHeader.Text = "";
                    cssDataTable.Text = "<link href='/admin/vendor/datatables/dataTables.bootstrap4.min.css'  rel='stylesheet' />";
                    ltJSDataTable.Text = "<script src='/admin/vendor/datatables/jquery.dataTables.js'></script>";
                    ltJSCustom.Text = "<script src='/admin/js/customdataTables.js'></script>";
                    loadMain.Controls.Add(LoadControl("~/admin/ortherpage/productsubtype.ascx"));
                    break;
                case "color":
                    ltJSHeader.Text = "";
                    cssDataTable.Text = "<link href='/admin/vendor/datatables/dataTables.bootstrap4.min.css'  rel='stylesheet' />";
                    ltJSDataTable.Text = "<script src='/admin/vendor/datatables/jquery.dataTables.js'></script>";
                    ltJSCustom.Text = "<script src='/admin/js/customdataTables.js'></script>";
                    loadMain.Controls.Add(LoadControl("~/admin/ortherpage/color.ascx"));
                    break;
                case "groundtype":
                    ltJSHeader.Text = "";
                    cssDataTable.Text = "<link href='/admin/vendor/datatables/dataTables.bootstrap4.min.css'  rel='stylesheet' />";
                    ltJSDataTable.Text = "<script src='/admin/vendor/datatables/jquery.dataTables.js'></script>";
                    ltJSCustom.Text = "<script src='/admin/js/customdataTables.js'></script>";
                    loadMain.Controls.Add(LoadControl("~/admin/ortherpage/groundtype.ascx"));
                    break;
                case "age":
                    ltJSHeader.Text = "";
                    cssDataTable.Text = "<link href='/admin/vendor/datatables/dataTables.bootstrap4.min.css'  rel='stylesheet' />";
                    ltJSDataTable.Text = "<script src='/admin/vendor/datatables/jquery.dataTables.js'></script>";
                    ltJSCustom.Text = "<script src='/admin/js/customdataTables.js'></script>";
                    loadMain.Controls.Add(LoadControl("~/admin/ortherpage/age.ascx"));
                    break;
                case "class":
                    ltJSHeader.Text = "";
                    cssDataTable.Text = "<link href='/admin/vendor/datatables/dataTables.bootstrap4.min.css'  rel='stylesheet' />";
                    ltJSDataTable.Text = "<script src='/admin/vendor/datatables/jquery.dataTables.js'></script>";
                    ltJSCustom.Text = "<script src='/admin/js/customdataTables.js'></script>";
                    loadMain.Controls.Add(LoadControl("~/admin/ortherpage/lop.ascx"));
                    break;
                case "league":
                    ltJSHeader.Text = "";
                    cssDataTable.Text = "<link href='/admin/vendor/datatables/dataTables.bootstrap4.min.css'  rel='stylesheet' />";
                    ltJSDataTable.Text = "<script src='/admin/vendor/datatables/jquery.dataTables.js'></script>";
                    ltJSCustom.Text = "<script src='/admin/js/customdataTables.js'></script>";
                    loadMain.Controls.Add(LoadControl("~/admin/ortherpage/league.ascx"));
                    break;
                case "team":
                    ltJSHeader.Text = "";
                    cssDataTable.Text = "<link href='/admin/vendor/datatables/dataTables.bootstrap4.min.css'  rel='stylesheet' />";
                    ltJSDataTable.Text = "<script src='/admin/vendor/datatables/jquery.dataTables.js'></script>";
                    ltJSCustom.Text = "<script src='/admin/js/customdataTables.js'></script>";
                    loadMain.Controls.Add(LoadControl("~/admin/ortherpage/team.ascx"));
                    break;
                case "range":
                    ltJSHeader.Text = "";
                    cssDataTable.Text = "<link href='/admin/vendor/datatables/dataTables.bootstrap4.min.css'  rel='stylesheet' />";
                    ltJSDataTable.Text = "<script src='/admin/vendor/datatables/jquery.dataTables.js'></script>";
                    ltJSCustom.Text = "<script src='/admin/js/customdataTables.js'></script>";
                    loadMain.Controls.Add(LoadControl("~/admin/ortherpage/range.ascx"));
                    break;
                case "version":
                    ltJSHeader.Text = "";
                    cssDataTable.Text = "<link href='/admin/vendor/datatables/dataTables.bootstrap4.min.css'  rel='stylesheet' />";
                    ltJSDataTable.Text = "<script src='/admin/vendor/datatables/jquery.dataTables.js'></script>";
                    ltJSCustom.Text = "<script src='/admin/js/customdataTables.js'></script>";
                    loadMain.Controls.Add(LoadControl("~/admin/ortherpage/version.ascx"));
                    break;
                case "slider":
                    ltJSHeader.Text = "";
                    cssDataTable.Text = "<link href='/admin/vendor/datatables/dataTables.bootstrap4.min.css'  rel='stylesheet' />";
                    ltJSDataTable.Text = "<script src='/admin/vendor/datatables/jquery.dataTables.js'></script>";
                    ltJSCustom.Text = "<script src='/admin/js/customdataTables.js'></script>";
                    loadMain.Controls.Add(LoadControl("~/admin/ortherpage/slider.ascx"));
                    break;
                case "deltail-news":
                    ltJSHeader.Text = "";
                    cssDataTable.Text = "<link href='/admin/vendor/datatables/dataTables.bootstrap4.min.css'  rel='stylesheet' />";
                    ltJSDataTable.Text = "<script src='/admin/vendor/datatables/jquery.dataTables.js'></script>";
                    ltJSCustom.Text = "<script src='/admin/js/customdataTables.js'></script>";
                    loadMain.Controls.Add(LoadControl("~/admin/ortherpage/deltailnews.ascx"));
                    break;
                case "category":
                    loadMain.Controls.Add(LoadControl("~/admin/ortherpage/category.ascx"));
                    ltJSCustom.Text = "<script src='/admin/js/tree-list.js'></script>";
                    break;
                case "news":
                    ltJSHeader.Text = "";
                    cssDataTable.Text = "<link href='/admin/vendor/datatables/dataTables.bootstrap4.min.css'  rel='stylesheet' />";
                    ltJSDataTable.Text = "<script src='/admin/vendor/datatables/jquery.dataTables.js'></script>";
                    ltJSCustom.Text = "<script src='/admin/js/customdataTables.js'></script>";
                    loadMain.Controls.Add(LoadControl("~/admin/ortherpage/news.ascx"));
                    break;
                case "social-media":
                    ltJSHeader.Text = "";
                    cssDataTable.Text = "<link href='/admin/vendor/datatables/dataTables.bootstrap4.min.css'  rel='stylesheet' />";
                    ltJSDataTable.Text = "<script src='/admin/vendor/datatables/jquery.dataTables.js'></script>";
                    ltJSCustom.Text = "<script src='/admin/js/customdataTables.js'></script>";
                    loadMain.Controls.Add(LoadControl("~/admin/ortherpage/socialmedia.ascx"));
                    break;

                default:
                    loadMain.Controls.Add(LoadControl("~/admin/index.ascx"));
                    ltJSCustom.Text = "<script src='/admin/vendor/chart.js/Chart.min.js'></script>"+
                                       "<script src='/admin/js/demo/chart-area-demo.js'></script>"+
                                       "<script src='/admin/js/demo/chart-pie-demo.js'></script>";
                    break;
            }
           

        }

       
    }
}