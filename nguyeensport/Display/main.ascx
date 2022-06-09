<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="main.ascx.cs" Inherits="nguyeensport.Display.main" %>
<div class="main">
        <div class="slider js-slider-item">
            <div class="swiper-wrapper">
                <asp:Repeater ID="rptSlider" runat="server">
                    <ItemTemplate>
                        <a href="<%#: Eval("linkSlider") %>" class="swiper-slide">
                             <picture>
                                <source media="(max-width:768px)" srcset="<%#: Eval("imageSliderMobile") %>" />
                                <img src="<%#: Eval("imageSliderDesktop") %>" alt="<%#: Eval("tenSlider") %>">
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
        <div class="top-grid">
            <div class="top-grid_box swiper-wrapper">
                <a href="#" class="top-grid_item swiper-slide ">
                    <img src="/images/top/nguyeen-bootroom.png" alt="BOOTROOM" />
                    <div class="top-grid_content">
                        <h2>Bộ sưu tập giày</h2>
                        <p>Hơn 2000 đôi giày từ các thương hiệu lớn nhất trên thế giới.</p>
                    </div>
                </a>
                 <a href="#" class="top-grid_item swiper-slide">
                    <img src="/images/top/nguyeen-fanshop.png" alt="FANSHOP" />
                    <div class="top-grid_content">
                        <h2>Bộ sưu tập áo Fan</h2>
                        <p>Tổng hợp tất cả áo bóng đá Fan khắp các châu lục.</p>
                    </div>
                </a>
                <a href="#" class="top-grid_item swiper-slide">
                    <img src="/images/top/nguyeen-teamwear.png" alt="TEANWEAR" />
                    <div class="top-grid_content">
                        <h2>TEAMWEAR BY ME</h2>
                        <p>Hãy lựa chọn và thiết kế cho đội bóng của bạn với tất cả trang phục đội thật đẹp.</p>
                    </div>
                </a>
            </div>
        </div>
        <div class="trending">
            <div class="trend-header__title">
                    Trending
            </div>
            <div class="swiper-container">
                <div class="swiper-wrapper">
                    <asp:Repeater ID="rptTop10SanPham" runat="server" OnItemDataBound="rptTop10SanPham_ItemDataBound">
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
        <div class="double-container">
            <div class="double-container__box">
                <img src="images/top/img11.jpg" alt="Fan Store">
                <div class="double-media-text">
                    <p class="double__title">Fan Store</p>
                    <p class="double__des">Tất cả áo Fan mới nhất từ các câu lạc bộ lớn</p>
                    <a href="/fan-shop" class="double__btn">Cửa hàng áo</a>
                </div>
            </div>
            <div class="double-container__box">
                <img src="images/top/img12.jpg" alt="Football Boots Store">
                <div class="double-media-text">
                    <p class="double__title">Football Boots Store</p>
                    <p class="double__des">Tất cả giày bóng đá mới nhất trên thế giới</p>
                    <a href="/giay-bong-da" class="double__btn">Cửa hàng giày</a>
                </div>
            </div>
        </div>
        <div class="news">
            <div class="news-container">
                <div class="news-flex">
                    <asp:Repeater ID="rptNews" runat="server">
                        <ItemTemplate>
                             <div class="news-flex_items">
                                <a href="/tin-tuc/<%#: Eval("linkNews")+"/"+ Eval("linkNewsDeltail") %>" class="news-item_link">
                                    <div class="news-item_img">
                                        <picture>
                                            <source media="(max-width:768px)" srcset="<%#: Eval("avatarNewsDeltailHome") %>" />
                                            <img src="<%#: Eval("avatarNewsDeltailHome") %>"  alt="<%#: Eval("tenNewsDeltail") %>"/>
                                        </picture>
                                    </div>
                                    <div class="news-item_content">
                                        <h2 class="news-item_title"><%#: Eval("tenNewsDeltail") %></h2>
                                        <p class="news-item-des"><%#: Eval("metaDescriptionNewsDeltail") %></p>
                                        <div class="statsbar">
                                            <div class="statsbar-items"><%#: DateTime.Parse(Eval("ngayTao").ToString()).ToString("dd/MM/yyyy")+" | "+Eval("tenNews") %></div>
                                            <div class="statsbar-items">
                                                <div class="statsbar_icon">
                                                     <span><svg class="svg-icon" width="30" viewBox="0 0 24 24">
							                            <path d="M10,6.978c-1.666,0-3.022,1.356-3.022,3.022S8.334,13.022,10,13.022s3.022-1.356,3.022-3.022S11.666,6.978,10,6.978M10,12.267c-1.25,0-2.267-1.017-2.267-2.267c0-1.25,1.016-2.267,2.267-2.267c1.251,0,2.267,1.016,2.267,2.267C12.267,11.25,11.251,12.267,10,12.267 M18.391,9.733l-1.624-1.639C14.966,6.279,12.563,5.278,10,5.278S5.034,6.279,3.234,8.094L1.609,9.733c-0.146,0.147-0.146,0.386,0,0.533l1.625,1.639c1.8,1.815,4.203,2.816,6.766,2.816s4.966-1.001,6.767-2.816l1.624-1.639C18.536,10.119,18.536,9.881,18.391,9.733 M16.229,11.373c-1.656,1.672-3.868,2.594-6.229,2.594s-4.573-0.922-6.23-2.594L2.41,10l1.36-1.374C5.427,6.955,7.639,6.033,10,6.033s4.573,0.922,6.229,2.593L17.59,10L16.229,11.373z"></path>
						                            </svg></span>
                                                     <span><%#: Eval("luotView") %></span>

                                                     <span>
                                                   
                                                     </span>
                                                    
                                                </div>    
                                            </div>
                                        </div>
                                    </div>
                                </a>
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>
                   
                </div>
                <div class="swiper-button-next"></div>
                <div class="swiper-button-prev"></div>
            </div>
        </div>
        <div class="brands">
            <div class="brands-box swiper-wrapper" >
                 <picture class="swiper-slide">
                    <img src="images/top/adidas-brand-logo-tab-black.webp" alt="adidas" >
               </picture>
                 <picture class="swiper-slide">
                    <img src="images/top/nike-brand-logo-tab-black.webp" alt="Nike" >
               </picture>
                 <picture class="swiper-slide">
                    <img src="images/top/puma-brand-logo-tab-black.jpg" alt="Puma">
               </picture>
                 <picture class="swiper-slide">
                    <img src="images/top/newbalance-brand-logo-tab-black.webp" alt="New balance">
               </picture>
                 <picture class="swiper-slide">
                    <img src="images/top/mizuno-brand-logo-tab-black.webp" alt="Mizuno">
               </picture>
                 <picture class="swiper-slide">
                    <img src="images/top/umbro-brand-logo-tab-black.webp" alt="Umbro">
               </picture>
                 <picture class="swiper-slide">
                    <img src="images/top/desktop-tab-kappa.jpg" alt="Kappa">
               </picture>
            </div>
        </div>

        <div class="nguyeensport">
            <h1 class="nguyeen_title">
                <span class="nguyeen_text">
                    NGUYEENSPORT - NƠI ĐAM MÊ ĐƯỢC PHỤC VỤ
                </span>
            </h1>
            <div class="nguyeen_des">
                Cho dù bạn đang tìm kiếm giày, quần áo hoặc phụ kiện trong sân hay nếu bạn đang muốn hoàn thiện vẻ ngoài của mình với thời trang bóng sành điệu, thời trang hoặc bộ dụng cụ bóng đá, <strong>NGUYEENSPORT</strong> có tất cả các sản phẩm tốt nhất từ nhãn hiệu trên thế giới.<br/>

                Chúng tôi cung cấp mọi thứ bạn có thể cần để nâng cấp trò chơi của mình và vượt qua đối thủ, trong các bộ phận trên sân của chúng tôi, bạn có thể tìm thấy tất cả các sản phẩm tốt nhất và mới nhất giày bóng đá từ các thương hiệu bao gồm <strong>Nike</strong>, <strong>Adidas</strong>, <strong>PUMA</strong> và nhiều thứ khác nữa. Chúng tôi cũng có mọi thứ bạn cần cho ngày tập luyện và trận đấu, với quần áo tập và quần áo đồng đội cho tất cả các câu lạc bộ cỡ lớn.<br/>
                Bóng đá không dừng lại khi bạn rời sân cỏ. chúng tôi có một loạt các sản phẩm phong cách sống ngoài sân cỏ để giúp bạn luôn tươi mới ngoài sân cỏ như khi bạn ở trên đó. từ tuyển chọn tuyệt vời các huấn luyện viên từ nike, adidas, jordan và hơn thế nữa, đến các bản phát hành mới của quần áo bóng đá và phong cách sống từ tất cả các thương hiệu hàng đầu.
            </div>
        </div>     
</div>