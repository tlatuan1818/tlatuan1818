<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="activity.ascx.cs" Inherits="nguyeensport.Display.Activity.activity" %>
 <div class="main">

       <section class="banner-product banner-product--product-lister">
           <div class="banner">
               <div class="banner__main">
                   <picture>
                       <asp:Literal ID="ltBannerListing" runat="server"></asp:Literal>
                   </picture>
               </div>
               <div class="banner__content">
                   <div class="banner__content-wrapper">
                       <div class="banner__meta-wrapper">
                           <div class="banner__title">
                           </div>
                           <div class="banner__description">

                           </div>
                       </div>
                   </div>
               </div>
               <div class="banner__buttons-content buttons--h-left buttons--v-middle">
                   <div class="banner__buttons buttons--desktop-only">
                       <ul class="banner__buttons-box">
                           <asp:Repeater ID="rptDanhMucConCap1" runat="server">
                               <ItemTemplate>
                                   <li class="banner__buttons-items">
                                       <a href="<%#: Eval("linkDanhMucCon") %>" class="btn btn-white banner__buttons--link"><%#: Eval("tenDanhMucCon") %></a>
                                   </li>
                               </ItemTemplate>
                           </asp:Repeater>
                       </ul>
                   </div>
                   <div class="banner__dropdown buttons--v-bottom">
                       <div class="form-item">
                           <div class="input-validation-wrapper">
                               <div class="custom-select">
                                   <asp:DropDownList ID="drCauLacBo" runat="server" CssClass="custom-select__element" AutoPostBack="true"></asp:DropDownList>
                               </div>
                           </div>
                       </div>
                   </div>
               </div>
           </div>

       </section>

        <section class="container-inner">
            <ol class="breadcrumbs clearFix">
                <li class="breadcrumbs__list-item">
                    <a class="breadcrumbs__link" href="/">
                        <span class="breadcrumbs__name">NGUYEENSPORT</span>
                    </a>
                </li>
                <asp:Literal ID="ltDanhMuc" runat="server"></asp:Literal>
                
            </ol>
        </section>
        <section class="container-inner clearFix">
            <h1 class=" product-category-title"><asp:Literal ID="ltHeaderTitle" runat="server"></asp:Literal></h1>
            <div class="lister-controls">
                <div class="lister-controls__box lister-controls__box--left">
                    <div class="filters-menu-container">
                        <div class="filter-menu" id="check">
                            <span class="filter-menu__button">
                                Lọc
                            </span>
                        </div>
                    </div>
                </div>
                <div class="lister-controls__box lister-controls__box--center">
                    <div class="grid-control">
                        <button type="button" class="grid-control__item grid-control__item--active">
                            <span class=" grid-control__box"></span>
                            <span class="grid-control__box"></span>
                            <span class="grid-control__box"></span>
                            <span class="grid-control__box"></span>
                        </button>
                        
                    </div>
                    <div class="vertical-line"></div>
                </div>
                <div class="lister-controls__box lister-controls__box--right">
                    <span class="line-addon line-addon--total">
                       <asp:Literal ID="ltSoLuong" runat="server"></asp:Literal>
                    </span>
                </div>
            </div>
        </section>
        <section class="container-wrap">
            <div class="lister-filters">
                <ul class="accordion">
                     <li class="accordion__item js-accordion-item ">
                        <button class="accordion__title js-accordion-title" type="button" aria-label="Thương hiệu">
                            Thương hiệu
                        </button>
                        <div class="accordion__content">
                            <ul class="filters">
                                <asp:Repeater ID="rptBrands" runat="server">
                                    <ItemTemplate>
                                        <li class="filters__item ">
                                            <a class="filters__link" href="<%=HttpContext.Current.Request.Url.AbsolutePath %>/<%#: Eval("linkBrands") %>">
                                                <%#:Eval("tenBrands") %>
                                            </a>
                                        </li>
                                    </ItemTemplate>
                                </asp:Repeater>
                            </ul>
                        </div>
                    </li>
                    <li class="accordion__item js-accordion-item ">
                        <button class="accordion__title js-accordion-title" type="button" aria-label=" Loại sản phẩm">
                            Loại sản phẩm
                        </button>
                        <div class="accordion__content">
                            <ul class="filters">
                                <asp:Repeater ID="rptProductType" runat="server">
                                    <ItemTemplate>
                                        <li class="filters__item ">
                                            <a class="filters__link" href="<%=HttpContext.Current.Request.Url.AbsolutePath %>/<%#: Eval("linkProductType") %>">
                                                <%#:Eval("tenProductType") %>
                                            </a>
                                        </li>
                                    </ItemTemplate>
                                </asp:Repeater>
                            </ul>
                        </div>
                    </li>
                    <li class="accordion__item js-accordion-item ">
                        <button class="accordion__title js-accordion-title" type="button" aria-label="Giải đấu">
                            Giải đấu
                        </button>
                        <div class="accordion__content">
                            <ul class="filters">
                                <asp:Repeater ID="rptList" runat="server">
                                    <ItemTemplate>
                                        <li class="filters__item ">
                                            <a class="filters__link" href="<%=HttpContext.Current.Request.Url.AbsolutePath %>/<%#: Eval("linkLeague") %>">
                                                <%#:Eval("tenLeague") %>
                                            </a>
                                        </li>
                                    </ItemTemplate>
                                </asp:Repeater>
                            </ul>
                        </div>
                    </li>
                    <li class="accordion__item js-accordion-item ">
                        <button class="accordion__title js-accordion-title" type="button" aria-label="  Đội bóng">
                            Đội bóng
                        </button>
                        <div class="accordion__content">
                            <ul class="filters">
                                <asp:Repeater ID="rptList1" runat="server">
                                    <ItemTemplate>
                                        <li class="filters__item ">
                                            <a class="filters__link" href="<%=HttpContext.Current.Request.Url.AbsolutePath %>/<%#: Eval("linkTeam") %>">
                                                <%#:Eval("tenTeam") %>
                                            </a>
                                        </li>
                                    </ItemTemplate>
                                </asp:Repeater>
                            </ul>
                        </div>
                    </li>
                     <li class="accordion__item js-accordion-item ">
                        <button class="accordion__title js-accordion-title" type="button" aria-label=" Trang phụ">
                            Trang phục
                        </button>
                        <div class="accordion__content">
                            <ul class="filters">
                                <asp:Repeater ID="rptList2" runat="server">
                                    <ItemTemplate>
                                        <li class="filters__item ">
                                            <a class="filters__link" href="<%=HttpContext.Current.Request.Url.AbsolutePath %>/<%#: Eval("linkRange") %>">
                                                <%#:Eval("tenRange") %>
                                            </a>
                                        </li>
                                    </ItemTemplate>
                                </asp:Repeater>
                            </ul>
                        </div>
                    </li>
                </ul>
            </div>
            <div class="lister-gird">
                <div class="lister-gird-box">
                    <asp:Repeater ID="rptSanPham" runat="server">
                        <ItemTemplate>
                            <div class="lister-gird-item">
                                <div class="product-thumb">
                                    <a href="<%#: Eval("DanhMuc") %>/<%#: Eval("Link") %>-<%#:Eval("ID") %>" class="product-thumb__link">
                                        <div class="product-thumb__box">
                                            <img class="product-thumb__image" src="/<%#: Eval("Avatar") %>" alt="<%#: Eval("TenSanPham") %>">
                                            <div class="product-message">
                                                <div class="product-message__text">
                                                    Pre-Order
                                                </div>
                                            </div>
                                        </div>
                                        <h2 class="product-thumb__name"><%#: Eval("TenSanPham") %></h2>
                                        <p class="product-thumb__price"><%#: string.Format("{0:N0}",Eval("GiaCuoi")) %> VNĐ</p>
                                    </a>
                                   </div>
                             </div>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
            </div>
        </section>
        <div class="lister-grid__pagination">
            <div class="pagination pagination--visible">
                <asp:LinkButton ID="btnPrev" runat="server" CssClass ="pagination__prev js-pagination-prev pagination__prev--disabled">Prev</asp:LinkButton>

                <div class="pagination__summary">
                    Page
                    <span class="pagination__current-page"><asp:Literal ID="ltPage" runat="server"></asp:Literal></span>
                    of
                    <span class="pagination__total-page"><asp:Literal ID="ltTotalPage" runat="server"></asp:Literal></span>
                </div>
                <asp:LinkButton ID="btnNext" runat="server" CssClass ="pagination__next js-pagination-next">Next</asp:LinkButton>
                
            </div>
        </div>
        <div class="container-inner">
            <p class="description">Hổ trợ các đội bóng yêu thích của bạn từ khắc nơi trên thế giới với nhiều loại quần áo và áo bóng đá này. Với sự góp mặt của nhiều đội bóng hàng đầu thế giới với nhiều giải đấu hay nhất, bạn có thể tự hào khoác lên mình màu áo của đội bóng mình yêu thích ở trận đấu trong và ngoài sân bóng.<br>
            Được thiết kế với công nghệ từ nhiều nhà sản xuất hàng đầu trên thế giới, bộ quần áo thể thao này được chế tạo để biễu diễn trong mọi điều kiện, từ cổ vũ với những người hâm mộ cuồng nhiệt khác đến luyện tập trên sân cỏ. Không giới hạn quần và áo, bộ quần áo bóng đá cao cấp bao gồm áo khoác và quần tập giúp bạn thể hiện sự ủng hộ của mình ngay cả khi thời tiết chuyển mùa. Với áo đấu sân nhà, sân khách và áo thi đấu mẫu thứ ba với quần short phù hợp, bạn có thể tìm thấy diện mạo đội bóng yêu thích của mình. Cũng có sãn một số mẫu retro, cho phép bạn trông thật phong cách trong chiếc áo từ thời hoàn kim của đội bóng yêu thích của bạn!
            </p>
        </div>
    </div>