<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="fanshop.ascx.cs" Inherits="nguyeensport.Display.fanshop" %>
<div class="main">
        <div class="slider js-slider-item">
            <div class="swiper-wrapper">
                <asp:Repeater ID="rptSlider" runat="server">
                    <ItemTemplate>
                        <a href="/p/fan-shop/<%#: Eval("linkSlider")%>" class="swiper-slide">
                           <picture>
                                <source media="(max-width:768px)" srcset="/<%#: Eval("imageSliderMobile") %>" />
                                <img src="<%#: Eval("imageSliderDesktop") %>" alt="<%#: Eval("tenSlider") %>" />
                            </picture>
                        </a>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
             <!-- Add Pagination -->
            <div class="swiper-pagination"></div>
            <!-- Add Arrows -->
            <div class="swiper-button-next"></div>
            <div class="swiper-button-prev"></div>
        </div>
        <div class="trending">
            <div class="swiper-container">
                <div class="swiper-wrapper">
                    <asp:Repeater ID="rptSanPham" runat="server" OnItemDataBound="rptSanPham_ItemDataBound">
                        <ItemTemplate>
                           <div class="swiper-slide">
                              <div class="product-thumb">
                                <a href="/<%#: Eval("linkSanPham") %>-<%#:Eval("maSanPham") %>" class="product-thumb__link">
                                    <div class="product-thumb__box">
                                        <img class="product-thumb__image" src="<%#: Eval("avatarSanPham") %>" alt="<%#: Eval("tenSanPham") %>">
                                        <asp:Label ID="lblMessage" runat="server" Text='<%#:Eval("giaDiscount") %>' ></asp:Label>
                                    </div>
                                    <h2 class="product-thumb__name"><%#: Eval("tenSanPham") %></h2>
                                    <div class="product-thumb__price">
                                       <div class="product-prices-container">
                                           <div class="product-prices product-prices--small">
                                               <div class="product-prices__item"><%#: string.Format("{0:N0}",Eval("giaOutput")) %> VNĐ</div>
                                               <asp:Label ID="lblDiscount" runat="server" Text ='<%#: string.Format("{0:N0}",Eval("giaInput")) + " VNĐ" %>'></asp:Label>
                                               <asp:Label ID="lblSaving" runat="server" Text ='<%#: "Giảm " + string.Format("{0:N0}",int.Parse(Eval("giaInput").ToString()) - int.Parse(Eval("giaOutput").ToString())) %>'></asp:Label>
                                             
                                           </div>
                                       </div>
                                    </div>
                                  
                                </a>
                               </div>
                             </div>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
                <div class="swiper-scrollbar"></div>
            </div>
        </div>
        <div class="fanshop-looking">
            <img src="/images/fanshop/fanshop11.png" alt="" class="img768">
            <div class="looking-box">
                <div class="looking-title">
                    Tìm kiếm cái gì khác ?
                </div>
                <div class="looking-btn_box">
                    <a href="/p/fan-shop/nu" class="btn btn-white looking-link">Áo bóng đá nử</a>
                    <a href="/p/fan-shop/ao-bong-da-retro" class="btn btn-white looking-link">Áo bóng đá Retro</a>
                    <a href="/p/fan-shop/kids" class="btn btn-white looking-link">Áo bóng đá trẻ em</a>
                </div>
            </div>
        </div>
        <div class="fanshop-premier-league">
            <div class="premier-league__title">
                Premier League
            </div>
            <div class="premier-league_box js-premier-league">
                <div class="swiper-wrapper">
                <div class="premier-league_item swiper-slide">
                    <a href="/p/fan-shop/nam/manchester-city"><img src="/images/fanshop/fanshop5.webp" alt="manchester-city" /></a>
                    <p class="premier-league_name">Manchester City</p>
                </div>
                <div class="premier-league_item swiper-slide">
                    <a href="/p/fan-shop/nam/totenham"><img src="/images/fanshop/fanshop6.webp" alt="tottenham" /></a>
                    <p class="premier-league_name">Tottenham</p>
                </div>
                <div class="premier-league_item swiper-slide">
                    <a href="/p/fan-shop/nam/liverpool"><img src="/images/fanshop/fanshop1.jpg" alt="liverpool" /></a>
                    <p class="premier-league_name">Liverpool</p>
                    
                </div>
                <div class="premier-league_item swiper-slide">
                    <a href="/p/fan-shop/nam/manchester-united"><img src="/images/fanshop/fanshop3.jpg" alt="manchester-united" /></a>
                    <p class="premier-league_name">Manchester United</p>
                </div>
                <div class="premier-league_item swiper-slide">
                    <a href="/p/fan-shop/nam/arsenal"><img src="/images/fanshop/fanshop2.jpg" alt="Arsenal" /></a>
                    <p class="premier-league_name">Arsenal</p>
                </div>
                <div class="premier-league_item swiper-slide">
                    <a href="/p/fan-shop/nam/chelsea"><img src="/images/fanshop/fanshop4.webp" alt="chelsea" /></a>
                    <p class="premier-league_name">Chelsea</p>
                </div>
                </div>
            </div>
        </div>
        <div class="fanshop-footballs">
            <div class="fanshop-footballs-box">
                <img src="/images/fanshop/fanshop12.jpg" alt="Tất cả áo bóng đá" />
                <div class="footballs-link">
                    <p class="footballs-title">Tất Cả Áo Bóng Đá</p>
                    <a href="/p/fan-shop/all-footballkit" class="btn btn-white football-btn">Xem Ngay</a>
                </div>
            </div>
            <div class="fanshop-footballs-box">
                <img src="/images/fanshop/fanshop13.webp" alt="Áo bóng đá mới" />
                <div class="footballs-link">
                    <p class="footballs-title">Áo Bóng Đá Mới</p>
                    <a href="/p/fan-shop/ao-bong-da-moi" class="btn btn-white football-btn">Xem Ngay</a>
                </div>
            </div>
        </div>
        <div class="fanshop-catalog ">
            <div class="catalog-box">
                <a href="/p/fan-shop/nam"><img src="/images/fanshop/fanshop16.jpg" alt="áo bóng đá fan" /></a>
                <p class="catalog-title">Trang Phục Thi Đấu</p>
                <p class="catalog-des">Có được diện mạo ưu tú với bộ quần áo bóng đá quốc tế và câu lạc bộ mới nhất được các cầu thủ mặc trên sân.</p>
            </div>
            <div class="catalog-box">
                <a href="/p/fan-shop/training"><img src="/images/fanshop/fanshop15.webp" alt="áo bóng đá fan traning" /></a>
                <p class="catalog-title">Trang Phục Tập Luyện</p>
                <p class="catalog-des">Tập luyện như những người chơi chuyên nghiệp với trang phục tập luyện hiệu suất từ các đội tốt nhất thế giới.</p>
            </div>
            <div class="catalog-box">
                <a href="/p/fan-shop/ao-khoac-bong-da"><img src="/images/fanshop/fanshop14.jpg" alt="thời trang bóng đá" /></a>
                <p class="catalog-title">Phong Cách Bóng Đá</p>
                <p class="catalog-des">Văn hóa của bóng đá. Khám phá bộ sưu tập phong cách sống mới nhất của câu lạc bộ và đội tuyển quốc gia.</p>
            </div>
        </div>
        <div class="fanshop-league">
            <img src="/images/fanshop/fanshop17.png" alt="Chọn giải đấu của bạn" class="img768" />
            <div class="league-box">
                <p class="league-title">Chọn Giải Đấu Của Bạn</p>
                <div class="league-team">
                    <a href="/p/fan-shop/nam/premier-league" class="btn btn-white">Premier League</a>
                    <a href="/p/fan-shop/nam/la-liga" class="btn btn-white">La Liga</a>
                    <a href="/p/fan-shop/nam/bundesliga" class="btn btn-white">Bundesliga</a>
                    <a href="/p/fan-shop/nam/serie-a" class="btn btn-white">Serie A</a>
                    <a href="/p/fan-shop/nam/ligue-1" class="btn btn-white">Ligue 1</a>
                    <a href="/p/fan-shop/nam/mls" class="btn btn-white">MLS</a>
                    <a href="/p/fan-shop/nam/all-clb-of-world" class="btn btn-white">All Clb Of World</a>
                    <a href="/p/fan-shop/nam/international" class="btn btn-white">International</a>
                </div>
                <div class="league-dropdow-team">
                    <div class="form-item">
                        <div class="input-validation-warrper">
                            <div class="custom-select">
                               <%-- <asp:DropDownList ID="drlGiaiDau" runat="server" CssClass="custom-select__element" OnSelectedIndexChanged="drlGiaiDau_SelectedIndexChanged" AutoPostBack="true">
                                    <asp:ListItem Value="">Chọn giải đấu</asp:ListItem>
                                    <asp:ListItem Value="Premier League">Premier League</asp:ListItem>
                                    <asp:ListItem Value="La Liga">La Liga</asp:ListItem>
                                    <asp:ListItem Value="Bundesliga">Bundesliga</asp:ListItem>
                                    <asp:ListItem Value="Serie A">Serie A</asp:ListItem>
                                    <asp:ListItem Value="Ligue 1">Ligue 1</asp:ListItem>
                                    <asp:ListItem Value="MLS">MLS</asp:ListItem>
                                    <asp:ListItem Value="All Clb Of World">All Clb Of World</asp:ListItem>
                                    <asp:ListItem Value="International">International</asp:ListItem>
                                </asp:DropDownList>--%>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="fanshop-euroleague">
            <div class="euro-league-title">
                European Teams
            </div>
            <div class="euroleague-box js-euroleague">
                <div class="swiper-wrapper">
                    <a href="/p/fan-shop/nam/psg" class="swiper-slide"><img src="/images/fanshop/fanshop19.webp" alt="PSG" /></a>
                    <a href="/p/fan-shop/nam/real-madrid" class="swiper-slide"><img src="/images/fanshop/fanshop20.webp" alt="REALMADRID" /></a>
                    <a href="/p/fan-shop/nam/juventus" class="swiper-slide"><img src="/images/fanshop/fanshop22.webp" alt="JUVENTUS" /></a>
                    <a href="/p/fan-shop/nam/barcelona" class="swiper-slide"><img src="/images/fanshop/fanshop23.jpg" alt="BARCELONA" /></a>
                </div>
            </div>
        </div>
        <div class="fanshop-header">
            <h1 class="fanshop-header_title">
                <span class="fanshop-header_text">
                    ÁO BÓNG ĐÁ FAN
                </span>
            </h1>
            <div class="fanshop-header_des">
                Thể hiện sự ủng hộ của bạn theo cách tốt nhất có thể với bộ sưu tập các áo bóng đá Fan các câu lạc bộ và đội tuyển quốc gia mới nhất của chúng tôi từ khắp nơi trên thế giới, có sẵn cho nam, nữ và trẻ em. Từ Man Utd đến Liverpool và Arsenal đến Chelsea, chúng tôi mang đến cho bạn tất cả các lựa chọn trang phục thi đấu trên sân nhà, sân khách và trang phục thứ ba cho các đội hàng đầu tại Premier League, cùng với các câu lạc bộ châu Âu bao gồm Real Madrid, Barcelona, ​​Bayern Munich, Juventus và PSG. <br>
                Sự lựa chọn của chúng tôi cũng tự hào về những gì tốt nhất của phần còn lại của thế giới, từ những gã khổng lồ Nam Mỹ Boca Juniors và Corinthians đến New York City FC và bộ dụng cụ bóng đá MLS mới nhất. Các câu lạc bộ có ý thức về thời trang như AIK và Kaizer Chiefs cũng có đầy đủ đại diện, vì vậy, cho dù bạn đang mua sắm cho năm mới hay tủ quần áo theo phong cách sống của mình, chúng tôi đều giúp bạn.<br>
                Nếu trò chơi quốc tế là túi của bạn nhiều hơn, bạn sẽ thấy tất cả các quốc gia lớn đều có mặt và chỉnh sửa, bao gồm áo đấu mới của đội tuyển Anh và các bộ quần áo mới nhất của Pháp, Đức, Tây Ban Nha, Ý, Hà Lan và Bồ Đào Nha đã sẵn sàng cho giải đấu lớn tiếp theo. Đối với một cái gì đó cổ hơn một chút, hãy xem phần Retro của chúng tôi, có những chiếc áo bóng đá cổ điển từ Score Draw, cùng với bộ sưu tập kỷ niệm phiên bản đặc biệt và áo kỷ niệm một lần.
            </div>
        </div>  
</div>