<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="phukien.ascx.cs" Inherits="nguyeensport.Display.phukien" %>
<div class="main">
        <div class="slider js-slider-item">
            <div class="swiper-wrapper">
                <asp:Repeater ID="rptSlider" runat="server">
                    <ItemTemplate>
                        <a href="/p/phu-kien/<%#: Eval("linkSlider")%>" class="swiper-slide">
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
        <div class="phukien-catalog">
            <a href="/p/phu-kien/all">
                <img src="/images/phukien/phukien03.png" alt="Tất cả phụ kiện">
                <p class="phukien-title">Tất cả phụ kiện</p>
            </a>
            <a href="/p/phu-kien/all/tat">
                <img src="/images/phukien/phukien04.png" alt="Tất ống và ốp">
                <p class="phukien-title">Tất ống</p>
            </a>
        </div>
        <div class="phukien-box">
            <a href="/p/phu-kien/all/balo">
                <img src="/images/phukien/phukien05.png" alt="Balo">
                <p class="phukien-box-title">Balo</p>
            </a>
            <a href="/p/phu-kien/all/khau-trang">
                <img src="/images/phukien/phukien06.png" alt="Khẩu trang thể thao" class="img768">
                <p class="phukien-box-title">Khẩu trang thể thao</p>
            </a>
            <a href="/p/phu-kien/all/tat">
                <img src="/images/phukien/phukien07.png" alt="Tất thể thao">
                <p class="phukien-box-title">Tất thể thao</p>
            </a>
        </div>
        <div class="phukien-choice">
            <div class="phukien-choice-title">
                Sự lựa chọn chuyên nghiệp
            </div>
            <div class="phukien-brands">
                <a href="/p/phu-kien/all/adidas">
                    <img src="/images/phukien/phukien08.png" alt="adidas">
                    <img src="/images/phukien/adidas-logo.svg" alt="adidas">
                </a>
                <a href="/p/phu-kien/all/nike">
                    <img src="/images/phukien/phukien09.png" alt="Nike">
                    <img src="/images/phukien/nike-logo.svg" alt="Nike">
                </a>
                <a href="/p/phu-kien/all/new-balance">
                    <img src="/images/phukien/phukien10.png" alt="new balance">
                    <img src="/images/phukien/newbalance-logo.svg" alt="New Balance">
                </a>
                <a href="/p/phu-kien/all/puma">
                    <img src="/images/phukien/phukien11.png" alt="Puma">
                    <img src="/images/phukien/puma-logo.svg" alt="Puma">
                </a>
            </div>
        </div>
        <div class="phukien-header">
            <h1 class="phukien-header_title">
                <span class="phukien-header_text">
                    PHỤ KIỆN BÓNG ĐÁ
                </span>
            </h1>
            <div class="phukien-header_des">
                Tham gia hoạt động bóng đá trong thật chuyên nghiệp với các phụ kiện bóng đá từ Nike, Adidas, PUMA, New Balance, Mizuno, Kamito,.. tại <strong>NGUYEENSPORT</strong>, nhà cung cấp phụ kiện bóng đá. <br>
                Với số lượng lớn phụ kiện từ người lớn đến trẻ em có trong kho, NGUYEENSPORT có mọi thứ mà bạn cần để nâng cao chất lượng sức khỏe và bảo vể cơ thể tránh các chấn thương không mong muốn.<br>
                Chúng tôi cung cấp một lượng lớn Tất bóng đá, ốp bảo vệ, túi và balo có luôn cả khẩu trang bóng đá để ra sân thật phong cách theo phong cách của bạn.<br>
                
            </div>
        </div>  
    </div>