<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="teamwear.ascx.cs" Inherits="nguyeensport.Display.teamwear" %>
<div class="main">
        <div class="slider js-slider-item">
            <div class="swiper-wrapper">
            <asp:Repeater ID="rptSlider" runat="server">
                <ItemTemplate>
                    <a href="/p/teamwear/<%#: Eval("linkSlider")%>" class="swiper-slide">
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
                    <asp:Repeater ID="rptSanPham" runat="server" OnItemDataBound="rptSanPham_ItemDataBound" >
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
        <div class="teamwear-box">
            <a href="/p/teamwear/all/">
                <img src="/images/teamwear/teamwear03.png" alt="Quần áo đội">
                <p class="teamwear-title">Quần áo đội</p>
            </a>
            <a href="/p/teamwear/all/training">
                <img src="/images/teamwear/teamwear04.png" alt="Quần áo tập">
                <p class="teamwear-title">Quần áo tập</p>
            </a>
            <a href="/p/teamwear/all/polo">
                <img src="/images/teamwear/teamwear09.png" alt="Polo đội">
                <p class="teamwear-title">Polo đội</p>
            </a>
            <a href="/p/teamwear/all/thu-mon">
                <img src="/images/teamwear/teamwear10.png" alt="Quần áo đội thủ môn">
                <p class="teamwear-title">Quần áo đội thủ môn</p>
            </a>
        </div>
        <div class="teamwear-colour">
            <div class="colour-title">Mua Sắm Theo Màu Sắc</div>
            <div class="colour-box">
                <div class="swiper-wrapper">
                    <a href="/p/teamwear/all/den" class="swiper-slide">
                        <img src="/images/teamwear/teamwear11.png" alt="Đen">
                        <p class="colour-name">Đen</p>
                    </a>
                    <a href="/p/teamwear/all/xanh-bich" class="swiper-slide">
                        <img src="/images/teamwear/teamwear12.png" alt="Xanh Bích">
                        <p class="colour-name">Xanh Bích</p>
                    </a>
                    <a href="/p/teamwear/all/do" class="swiper-slide">
                        <img src="/images/teamwear/teamwear13.png" alt="Đỏ">
                        <p class="colour-name">Đỏ</p>
                    </a>
                    <a href="/p/teamwear/all/trang" class="swiper-slide">
                        <img src="/images/teamwear/teamwear14.png" alt="Trắng">
                        <p class="colour-name">Trắng</p>
                    </a>
                    <a href="/p/teamwear/all/xanh-la" class="swiper-slide">
                        <img src="/images/teamwear/teamwear15.png" alt="Xanh Lá">
                        <p class="colour-name">Xanh Lá</p>
                    </a>
                    <a href="/p/teamwear/all/xanh-bien" class="swiper-slide">
                        <img src="/images/teamwear/teamwear16.png" alt="Xanh Biển">
                        <p class="colour-name">Xanh Biển</p>
                    </a>
                    <a href="/p/teamwear/all/vang" class="swiper-slide">
                        <img src="/images/teamwear/teamwear17.png" alt="Vàng">
                        <p class="colour-name">Vàng</p>
                    </a>
                    <a href="/p/teamwear/all/cam" class="swiper-slide">
                        <img src="/images/teamwear/teamwear18.png" alt="Cam">
                        <p class="colour-name">Cam</p>
                    </a>
                    <a href="/p/teamwear/all/xam" class="swiper-slide">
                        <img src="/images/teamwear/teamwear19.png" alt="Xám">
                        <p class="colour-name">Xám</p>
                    </a>
                    <a href="/p/teamwear/all/dong" class="swiper-slide">
                        <img src="/images/teamwear/teamwear20.png" alt="Đồng">
                        <p class="colour-name">Đồng</p>
                    </a>
                    <a href="/p/teamwear/all/hong" class="swiper-slide">
                        <img src="/images/teamwear/teamwear21.png" alt="Hồng">
                        <p class="colour-name">Hồng</p>
                    </a>
                    <a href="/p/teamwear/all/tim" class="swiper-slide">
                        <img src="/images/teamwear/teamwear22.png" alt="Tím">
                        <p class="colour-name">Tím</p>
                    </a>
                    <a href="/p/teamwear/all/nau" class="swiper-slide">
                        <img src="/images/teamwear/teamwear23.png" alt="Nâu">
                        <p class="colour-name">Nâu</p>
                    </a>
                    <a href="/p/teamwear/all/do-huyet" class="swiper-slide">
                        <img src="/images/teamwear/teamwear24.png" alt="Đỏ Huyết">
                        <p class="colour-name">Đỏ Huyết</p>
                    </a>
                </div>
                <div class="swiper-button-next"></div>
                <div class="swiper-button-prev"></div>
            </div>
        </div>
        <div class="teamwear-brands">
            <div class="teamwear-brands-box">
                <img src="/images/teamwear/bo-trang-phuc-nike.webp" alt="Bộ trang phục Nike" />
                <div class="teamwear-brands-content">
                    <h2 class="teamwear-brands_title">Bộ trang phục Nike</h2>
                    <p class="teamwear-brands_des">Ưu đãi hấp dẫn</p>
                    <a class="btn btn-white teamwear-brands_link" href="#">Shop Nike</a>
                </div>
            </div>
            <div class="teamwear-brands-box">
                <img src="/images/teamwear/bo-trang-phuc-adidas.webp" alt="Bộ trang phục Adidas" />
                <div class="teamwear-brands-content">
                    <h2 class="teamwear-brands_title">Bộ trang phục Adidas</h2>
                    <p class="teamwear-brands_des">Ưu đãi hấp dẫn</p>
                    <a class="btn btn-white teamwear-brands_link" href="#">Shop Adidas</a>
                </div>
            </div>
        </div>
        <div class="teamwear-kids">
            <a href="/p/teamwear/kids/ao">
                <img src="/images/teamwear/teamwear05.png" alt="Quần áo đội trẻ em">
                <p class="teamwear-kids-title">Quần áo đội trẻ em</p>
            </a>
            <a href="/p/teamwear/kids/training">
                <img src="/images/teamwear/teamwear06.png" alt="Quần áo tập trẻ em">
                <p class="teamwear-kids-title">Quần áo tập trẻ em</p>
            </a>
            <a href="/p/teamwear/kids/thu-mon">
                <img src="/images/teamwear/teamwear25.png" alt="Quần áo thủ môn trẻ em">
                <p class="teamwear-kids-title">Quần áo thủ môn trẻ em</p>
            </a>
        </div>
        <div class="teamwear-nxs">
            <h2 class="teamwear-nxs_title">
                Nhà sản xuất
            </h2>
            <div class="teamwear-swiper-container">
                <div class="swiper-wrapper">
                    <div class="swiper-slide"><img src="/images/teamwear/adidas-brand-logo-tab-black.webp" alt="adidas-brand-logo-tab-black" /></div>
                     <div class="swiper-slide"><img src="/images/teamwear/nike-brand-logo-tab-black.webp" alt="nike-brand-logo-tab-black" /></div>
                     <div class="swiper-slide"><img src="/images/teamwear/puma-brand-logo-tab-black.jpg" alt="puma-brand-logo-tab-black" /></div>
                     <div class="swiper-slide"><img src="/images/teamwear/newbalance-brand-logo-tab-black.webp" alt="newbalance-brand-logo-tab-black" /></div>
                     <div class="swiper-slide"><img src="/images/teamwear/desktop-tab-kappa.jpg" alt="desktop-tab-kappa" /></div>
                </div>
                <div class="swiper-button-next"></div>
                <div class="swiper-button-prev"></div>
            </div>
        </div>
        <div class="teamwear-header">
            <h1 class="teamwear-header_title">
                <span class="teamwear-header_text">
                    QUẦN ÁO BÓNG ĐÁ ĐỘI
                </span>
            </h1>
            <div class="teamwear-header_des">
                Hãy xem và lựa chọn giúp đội của bạn thể hiện tốt nhất trong ngày thi đấu với các trang phục thi đấu tại <strong>nguyeensport</strong> bộ dụ cụ bóng đá của đội từ các thương hiệu lớn trên thế giới.
                <br />
                Với nhiều loại áo thi đấu, quần short, tất trong trận đấu hoặc các buổi tập, cũng như áo khoác, quần dài, quần thể thao, áo thun polo, và áo mưa cho nhưng khoảng khác ngoài sân cỏ, bạn có thể mua được mọi thứ bạn cần đáp ứng nhu cầu về quần áo đồng phục của mình tại <strong>nguyeensport</strong>.
                <br />
                Chúng tôi có hàng tá kiểu dáng từ các thương hiệu lớn nhất với <strong>adidas</strong>, <strong>Nike</strong>, <strong>Puma</strong> và <strong>Bộ dụng cụ bóng đá Kamito</strong> có sẳn để giao hàng nhanh chóng với chất lượng tuyệt vời với đầy đủ các tùy chọn cá nhân hóa có sẳn từ các sản phẩm trong Teamwear của chúng tôi.
            </div>
        </div>  
    </div>