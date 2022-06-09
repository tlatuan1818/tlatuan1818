
using CloudinaryDotNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;


namespace nguyeensport
{
    public class Global : HttpApplication
    {
        void DangKyRoutes(RouteCollection routes)
        {
            routes.MapPageRoute("Home", "", "~/Default.aspx");
            routes.MapPageRoute("", "p/{page}", "~/Default.aspx");
            routes.MapPageRoute("", "p/{page}/{sex}", "~/ListProduct.aspx");
            routes.MapPageRoute("", "cart", "~/cart.aspx");
            routes.MapPageRoute("", "404", "~/404.aspx");
            routes.MapPageRoute("", "tin-tuc/", "~/Display/TinTuc/DanhSachTinTuc.aspx");
            routes.MapPageRoute("", "tin-tuc/{danhmuc}", "~/Display/TinTuc/DanhSachTinTuc.aspx");
            routes.MapPageRoute("", "tin-tuc/{list}/{name}", "~/Display/TinTuc/deltailsTinTuc.aspx");
            routes.MapPageRoute("", "unitl/{link}", "~/Display/Unitl/tro-giup-hoi-dap.aspx");
            routes.MapPageRoute("", "kich-thuoc", "~/Display/Unitl/huongdanchokichthuoc.aspx");
            routes.MapPageRoute("", "kich-thuoc/{gioitinh}", "~/Display/Unitl/GioiTinh/gioitinh.aspx");
            routes.MapPageRoute("", "kich-thuoc/{gioitinh}/{trangphuc}", "~/Display/Unitl/GioiTinh/gioitinh.aspx");
            routes.MapPageRoute("", "kich-thuoc/{gioitinh}/{trangphuc}/{brands}", "~/Display/Unitl/GioiTinh/gioitinh.aspx");
            routes.MapPageRoute("", "my-account/{account}", "~/Display/Unitl/myaccount.aspx");
            routes.MapPageRoute("", "my-account/{account}/{delclub}", "~/Display/Unitl/account/clubs/delClubs.aspx");
            routes.MapPageRoute("", "privacy-policy", "~/Display/Unitl/privacypolicy.aspx");
            routes.MapPageRoute("", "terms-and-conditions", "~/Display/Unitl/termsandconditions.aspx");
            routes.MapPageRoute("", "p/{page}/{danhmuccapone}", "~/activityfootball.aspx");
            routes.MapPageRoute("", "p/{page}/{league}/{team}", "~/activityfootball.aspx");
            routes.MapPageRoute("", "p/{page}/{league}/{team}/{range}", "~/activityfootball.aspx");
            //routes.MapPageRoute("", "{danhmuc}/{delproduct}-{code}", "~/delProduct.aspx");
            

            routes.MapPageRoute("admin", "manager", "~/admin/adminitrator.aspx");
            routes.MapPageRoute("", "manager/{quanlypage}", "~/admin/adminitrator.aspx");
            routes.MapPageRoute("", "manager/category/{quanlypage}", "~/admin/adminitrator.aspx");
        }
        
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            SQLDB.SQLDB.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Connect"].ConnectionString;
           
            DangKyRoutes(RouteTable.Routes);
           
        }
        protected void Session_Start(object sender, EventArgs e)
        {
            if (Request.IsSecureConnection)
            {
                if (Response.Cookies.Count > 0)
                {
                    foreach (string s in Response.Cookies.AllKeys)
                    {
                        if (s == FormsAuthentication.FormsCookieName || s.ToLower() == "asp.net_sessionid")
                        {
                            Response.Cookies[s].Secure = true;
                        }
                    }
                }
            }
            else
            {
                //if not secure, then don't set session cookie
                Response.Cookies["asp.net_sessionid"].Value = string.Empty;
                Response.Cookies["asp.net_sessionid"].Expires = new DateTime(2018, 01, 01);
            }
        }
        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}