<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="giaybongda.ascx.cs" Inherits="nguyeensport.Display.giaybongda" %>
<div class="main">
        <div class="slider js-slider-item">
            <div class="swiper-wrapper">
                <asp:Repeater ID="rptSlider" runat="server">
                    <ItemTemplate>
                        <a href="/p/giay-bong-da/<%#: Eval("linkSlider")%>" class="swiper-slide">
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
        <div class="boots-catalog">
            <a href="/p/giay-bong-da/adults">
                <img src="/images/giaybongda/giaybongda05.jpg" alt="Giày Bóng Đá Người Lớn">
                <p class="boots-title">Giày Bóng Đá Người Lớn</p>
            </a>
            <a href="/p/giay-bong-da/giay-bong-da-moi">
                <img src="/images/giaybongda/giaybongda06.webp" alt="Giày Bóng Đá Mới">
                <p class="boots-title">Giày Bóng Đá Mới</p>
            </a>
        </div>
        <div class="boots-choice">
            <div class="choice-title">
                Sự Lựa Chọn Chuyên Nghiệp
            </div>
            <div class="boots-brand">
                <a href="/p/giay-bong-da/adults/adidas">
                    <img src="/images/giaybongda/giaybongda07.jpg" alt="giay-bong-da-adidas">
                    <img src="/images/giaybongda/adidas-logo.svg" alt="adidas">
                </a>
                <a href="/p/giay-bong-da/adults/nike">
                    <img src="/images/giaybongda/giaybongda08.jpg" alt="giay-bong-da-nike">
                    <img src="/images/giaybongda/nike-logo.svg" alt="nike">
                </a>
            </div>
            <div class="boots-brand">
                <a href="/p/giay-bong-da/adults/puma">
                    <img src="/images/giaybongda/giaybongda09.webp" alt="giay-bong-da-puma">
                    <img src="/images/giaybongda/puma-logo.svg" alt="puma">
                </a>
                <a href="/p/giay-bong-da/adults/mizuno">
                    <img src="/images/giaybongda/giaybongda10.webp" alt="giay-bong-da-mizuno">
                    <img src="/images/giaybongda/mizuno-logo.svg" alt="mizuno">
                </a>
                <a href="/p/giay-bong-da/adults/new-balance">
                    <img src="/images/giaybongda/giaybongda11.webp" alt="giay-bong-da-new-balance">
                    <img src="/images/giaybongda/newbalance-logo.svg" alt="new balance">
                </a>
                <a href="/p/giay-bong-da/adults/kamito">
                    <img src="/images/giaybongda/giaybongda12.jpg" alt="giay-bong-da-kamito">
                    <img src="/images/giaybongda/kamito-logo.svg" alt="kamito">
                </a>
            </div>
        </div>
        <div class="boots-banner">
            <img src="/images/giaybongda/giaybongda13.png" alt="Tùy chỉnh nâng cao trò chơi theo phong cách của bạn" class="img768">
            <div class="banner-text">
                <div class="banner--content">
                    <p class="banner--content_title">Tùy chỉnh</p>
                    <p class="banner--content-des">nâng cao trò chơi theo phong cách của bạn</p>
                </div>
                <a href="/p/phu-kien/all" class="btn btn-white banner-btn">
                    Xem Ngay
                </a>
            </div>
        </div>
        <div class="boots-box">
            <a href="/p/giay-bong-da/classic">
                <img src="/images/giaybongda/giaybongda14.jpg" alt="Giày Classic">
                <p class="boots-box--title">Giày Classic</p>
            </a>
            <a href="/p/giay-bong-da/kids">
                <img src="/images/giaybongda/giaybongda15.jpg" alt="Giày Bóng Đá Trẻ Em">
                <p class="boots-box--title">Giày Bóng Đá Trẻ Em</p>
            </a>
        </div>
        <div class="boots-small">
            <a href="/p/giay-bong-da/adults/ag">
                <img src="/images/giaybongda/giaybongda16.jpg" alt="Giày Đinh AG">
                <p class="boots-small--title">Giày Đinh AG</p>
            </a>
            <a href="/p/giay-bong-da/adults/in">
                <img src="/images/giaybongda/giaybongda17.jpg" alt="Giày Futsal">
                <p class="boots-small--title">Giày Futsal</p>
            </a>
            <a href="/p/giay-bong-da/adults/tf">
                <img src="/images/giaybongda/giaybongda18.jpg" alt="Giày Cỏ Nhân Tạo">
                <p class="boots-small--title">Giày Cỏ Nhân Tạo</p>
            </a>
        </div>
        <div class="boots-banner">
            <img src="/images/giaybongda/giaybongda19.png" alt="Giày bóng đá mới nhất cho Trẻ em" class="img768">
            <div class="banner-text">
                <div class="banner--content">
                    <p class="banner--content-des">Giày bóng đá mới nhất cho</p>
                    <p class="banner--content_title">Trẻ em</p>
                </div>
                <a href="/p/giay-bong-da/kids" class="btn btn-white banner-btn">
                    Xem Ngay
                </a>
            </div>
        </div>
        <div class="boots-header">
            <h1 class="boots-header_title">
                <span class="boots-header_text">
                    GIÀY BÓNG ĐÁ
                </span>
            </h1>
            <div class="boots-header_des">
                Chào mừng bạn đến với <strong>NGUYEENSPORT</strong>, cửa hàng giày bóng đá tại TP. Hồ Chính Minh. <br>
                Tìm hơn 2000 giày bóng đá từ các thương hiệu lớn nhất trên thế giới, chẳng hạn như Nike, Adidas, PUMA, New Balance, Mizuno và ASICS.<br>
                Các loại giày của chúng tôi phục vụ cho tất cả các phong cách thi đấu và loại mặt sân: sân đất, sân cỏ nhân tạo, sân đan, sân fulsal, sân cỏ tự nhiên. <br>
                Ngoài lựa chọn tuyệt vời này, chúng tôi là lựa chọn số một cho các bộ sưu tập phiên bản giới hạn, chẳng hạn như Adidas Predator, Adidas Nemeziz, Nike Mercurial Vapor hoặc Superfly & Nike Phantom Venom hoặc Vision.<br>
                Độc quyền, hiệu suất và phong cách, chúng tôi có tất cả và với giá tốt nhất!<br>
                Hãy đến với Giày bóng đá dành cho người lớn hoặc Giày bóng đá dành cho phụ nữ và dành cho trẻ em và trẻ em cho các bé trai và bé gái.
            </div>
        </div>  
    </div>