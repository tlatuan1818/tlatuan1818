using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace nguyeensport
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            loadData();
            string page = Page.RouteData.Values["page"] as string;
            switch (page)
            {
                case "fan-shop":
                    ltTitle.Text = "Fan shop | NGUYEENSPORT";
                    ltMetaKeyword.Text = " <meta name='keywords' content='áo bóng đá, áo manchester united, áo chelsea, áo real madric, áo bracelona, áo bayern munich, áo dortmund, áo psg' />";
                    ltMetaDescription.Text = "<meta name='description' content='Chào mừng bạn đã đến với cửa hàng bóng đá trực tuyến! ở đây chúng tôi bán áo bóng đá fan từ các câu lạc bộ nổi tiếng trên toàn thế giới.' />";
                    ltCSS.Text = "<link rel='stylesheet' type='text/css' media='screen' href='/common/css/fanshop.css' />";
                    break;
                case "giay-bong-da":
                    ltTitle.Text = "Giày bóng đá | NGUYEENSPORT";
                    ltMetaKeyword.Text = " <meta name='keywords' content='giày bóng đá, giày adidas X, giày adidas Copa, giày adidas Nemeziz, giày adidas Predator, giày Nike CR7, giày Nike Mercurial Vapor, giày Nike Phantom, giày Nike Tiempo' />";
                    ltMetaDescription.Text = "<meta name='description' content='Chào mừng bạn đã đến với cửa hàng bóng đá trực tuyến! ở đây chúng tôi bán giày bóng đá từ các thương hiệu nổi tiếng trên toàn thế giới.' />";
                    ltCSS.Text = "<link rel='stylesheet' type='text/css' media='screen' href='/common/css/giaybongda.css' />";
                    break;
                case "phu-kien":
                    ltTitle.Text = "Phụ kiện | NGUYEENSPORT";
                    ltMetaKeyword.Text = " <meta name='keywords' content='phu kien bong da, phu kien bong da adidas,phu kien bong da nike,phu kien bong da puma, phu kien bong da mizuno,phu kien bong da tai ho chi minh ' />";
                    ltMetaDescription.Text = "<meta name='description' content='Chào mừng bạn đã đến với cửa hàng bóng đá trực tuyến! ở đây chúng tôi bán tất cả phụ kiện thể thao từ các thương hiệu nổi tiếng trên toàn thế giới' />";
                    ltCSS.Text = "<link rel='stylesheet' type='text/css' media='screen' href='/common/css/phukien.css' />";
                    break;
                case "teamwear":
                    ltTitle.Text = "Quần áo bóng đá đội | NGUYEENSPORT";
                    ltMetaKeyword.Text = " <meta name='keywords' content='quần áo bóng đá đội,quan ao bong da doi,quần áo bóng đá đội tại hồ chính minh' />";
                    ltMetaDescription.Text = "<meta name='description' content='Chào mừng bạn đã đến với cửa hàng bóng đá trực tuyến! ở đây chúng tôi bán tất cả quần áo bóng đá đội từ các thương hiệu nổi tiếng trên toàn thế giới' />";
                    ltCSS.Text = "<link rel='stylesheet' type='text/css' media='screen' href='/common/css/teamwear.css' />";
                    break;
                default:
                    ltTitle.Text = "NGUYEENSPORT | NƠI ĐAM MÊ ĐƯỢC PHỤC VỤ";
                    ltMetaKeyword.Text = " <meta name='keywords' content='nguyeensport, nguyen sport, nguyeensport.com, NGUYEEN SPORT, NGUYEENSPORT' />";
                    ltMetaDescription.Text = "<meta name='description' content='Chào mừng bạn đã đến với cửa hàng bóng đá trực tuyến!Nhận các sản phẩm bóng đá mới của bạn từ nguyeensport.com - giao hàng trên toàn quốc và giá tốt' />";
                    ltCSS.Text = "<link rel='stylesheet' type='text/css' media='screen' href='/common/css/top.css' />";
                    break;
            }

        }
        void loadData()
        {
            loadheader.Controls.Add(LoadControl("Display/header.ascx"));
            loadMenuList1.Controls.Add(LoadControl("Display/menulist1.ascx"));
            loadMenuList2.Controls.Add(LoadControl("Display/menulist2.ascx"));
            loadSearch.Controls.Add(LoadControl("Display/search.ascx"));
            loadGioHang.Controls.Add(LoadControl("Display/giohang.ascx"));
            loadfooter.Controls.Add(LoadControl("Display/footer.ascx"));
        }
    }
}