<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="giohang.ascx.cs" Inherits="nguyeensport.Display.giohang" %>
<div>
    <div class="slideout-basket">
        <div class="slide-menu slide-menu--right slide-menu--with-background">
            <div class="slide-menu__container">
                <div class="js-slide-menu-alert-container alert-strip"></div>
                <div class="js-basket-message-container">
                    <div class="messages"></div>
                </div>
                <div class="slide-menu__header ">
                    <span class="slide-menu__close"></span>
                    <div class="slide-menu-header-content">
                        <div class="slide-menu-header-dynamic-content">
                            <div class="js-products-title">
                                <div class="total-products-title-container">
                                    <div class="total-products-title">
                                        <h2 class="total-products-title__heading">Tổng sản phẩm (<asp:Literal ID="ltSoLuong" runat="server"></asp:Literal>)</h2>
                                    </div>
                                </div>
                            </div>
                            <div class="js-order-summary order-summary">
                                <hr class="horizontal-rule">
                                <div class="order-summary__item order-summary__item--subprimary">
                                    <span class="order-summary__title">Tạm tính</span>
                                    <span class="order-summary__price">
                                        <asp:Literal ID="ltTongTien" runat="server"></asp:Literal>
                                        VNĐ</span>
                                </div>
                                <div class="order-summary__item">
                                    <span class="order-summary__title">VAT</span>
                                    <span class="order-summary__price">0 VNĐ</span>
                                </div>
                                <div class="order-summary__item ">
                                    <span class="order-summary__title">Vận chuyển</span>
                                    <span class="order-summary__price">0 VNĐ</span>
                                </div>
                                <hr class="horizontal-rule">
                                <div class="order-summary__item order-summary__item--primary">
                                    <span class="order-summary__title">Tổng thanh toán</span>
                                    <span class="order-summary__price">
                                        <asp:Literal ID="ltTongThanhToan" runat="server"></asp:Literal>
                                        VNĐ</span>
                                </div>
                                <hr class="horizontal-rule">
                            </div>
                            <div class="js-checkout-now checkout-now">
                                <div class="checkout-now__description">
                                </div>
                                <div class="checkout-now__buttons">
                                    <a href="/cart" class="button button--black-submit">
                                        <div class="button__title">Xem giỏ hàng</div>
                                    </a>
                                    <a href="/thanhtoan" class="button button--submit">
                                        <div class="button__title">Thanh toán ngay</div>
                                    </a>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="slide-menu__content">
                    <div class="js-basket-product-list">
                        <div class="basket-product-list-container">

                            <asp:Repeater ID="rptLoadGioHang" runat="server" OnItemCommand="rptLoadGioHang_ItemCommand">
                                <ItemTemplate>
                                    <div class="basket-product-list">
                                        <div class="basket-product-list__item-container">
                                            <div class="product-list-item">
                                                <div class="product-list-item__details-container">
                                                    <img src="/<%#:Eval("Avatar") %>" alt="<%#:Eval("TenSanPham") %>" class="product-list-item__image">
                                                    <div class="product-list-item__details">
                                                        <h3 class="product-list-item__title">
                                                            <a class="product-list-item__link"><%#: Eval("TenSanPham") %></a>
                                                        </h3>
                                                        <div class="product-list-item__prices">
                                                            <div class="product-list-item__price"><%#:string.Format("{0:N0}", Eval("Gia")) %> VNĐ</div>
                                                        </div>
                                                        <div class="product-list-item__additional">
                                                            <div class="additional-info">
                                                                <div class="product-list-item__wrapper">
                                                                    <div class="additional-info__item">
                                                                        <span class="additional-info__label additional-info__label--colon">Tộng tiền</span>
                                                                        <span class="additional-info__value"><%#:string.Format("{0:N0}", Eval("Total")) %> VNĐ</span>
                                                                    </div>
                                                                </div>
                                                            </div>
                                                        </div>
                                                        <div class="product-list-item__controls">
                                                            <div class="controls-links__quantity-control">
                                                                <div class="quantity-selector">
                                                                    <asp:TextBox ID="txtQuantity" runat="server" CssClass="quantity-selector__input" Text='<%#: Eval("SoLuong")%>'></asp:TextBox>
                                                                </div>
                                                            </div>
                                                            <div class="controls-links">
                                                                <asp:LinkButton ID="lnkDelete" runat="server" CommandArgument='<%#:Eval("ID") %>' CssClass="controls-links__item" CommandName="delete">Xóa</asp:LinkButton>
                                                                <asp:LinkButton ID="lnkUpdate" runat="server" CommandArgument='<%#:Eval("ID") %>' CssClass="controls-links__item" CommandName="update">Cập nhật</asp:LinkButton>
                                                            </div>
                                                        </div>

                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </ItemTemplate>
                            </asp:Repeater>
                        </div>
                    </div>
                </div>
            </div>
        </div>

    </div>
</div>
