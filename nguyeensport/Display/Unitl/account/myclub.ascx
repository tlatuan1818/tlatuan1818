<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="myclub.ascx.cs" Inherits="nguyeensport.Display.Unitl.account.myclub" %>
<div class="main">
        <div class="banner-account">
            <div class="banner-center">
                <div class="banner__main">
                    <img src="../../images/unitl/my-account01.png" alt="Tài khoản của tôi" class="img768">
                </div>
                <div class="banner--content">
                    <h2 class="banner-title">Tài khoản của tôi</h2>
                </div>
                <div class="banner-menu">
                    <div class="banner-menu__wrapper">
                        <div class="banner-menu__item ">
                            <a href="/my-account/thong-tin-cua-toi" class="banner-menu__link">Thông tin của tôi</a>
                        </div>
                        <div class="banner-menu__item banner-menu__item--active swiper-slide-active">
                            <a href="/my-account/cau-lac-bo-cua-toi" class="banner-menu__link">Câu lạc bộ của tôi</a>
                        </div>
                        <div class="banner-menu__item">
                            <a href="/my-account/lich-su-mua-hang" class="banner-menu__link">Lịch sử đơn hàng</a>
                        </div>
                        <div class="banner-menu__item">
                            <a href="/my-account/so-thich-cua-toi" class="banner-menu__link">Sở thích của tôi</a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="container-inner">
            <div class="my-clubs">
                <h2 class="my-clubs__title">Câu lạc bộ của tôi</h2>
                <asp:Literal ID="ltMuaSam" runat="server"></asp:Literal>
                
            </div>
           <asp:Repeater ID="rptClb" runat="server" OnItemCommand="rptClb_ItemCommand">
               <HeaderTemplate>
                   <ul class="clubs-list">
               </HeaderTemplate>
               <ItemTemplate>
                   <li class="clubs-list__item">
                    <div class="clubs-list__item__description">
                        <div class="clubs-list__item__logo">
                            <img src="<%#: Eval("AvatarCLB") %>" alt="<%#: Eval("TenCLB") %>">
                        </div>
                        <div class="clubs-list__item__text">
                            <h2 class="my-clubs-name"><%#: Eval("TenCLB") %></h2>
                        </div>
                    </div>
                    <div class="clubs-list__item__buttons">
                        <a href="/my-account/cau-lac-bo-cua-toi/<%#: Eval("LinkCLB") %>" class="button--club-list">
                            <div class="button">
                                <div class="button__title ">Quản lý</div>
                            </div>
                        </a>
                        <asp:LinkButton ID="btnXoa" CommandArgument='<%#:Eval("IDCLB") %>' CommandName="delete" runat="server" CssClass="clubs-list__cleaner-wrapper" OnLoad="Delete_Load">
                            <span class="clubs-list__cleaner-close"></span>
                        </asp:LinkButton>
                    </div>
                </li>
               </ItemTemplate>
               <FooterTemplate>
                   </ul>
               </FooterTemplate>
           </asp:Repeater>
            
                
            
        </div>
    </div>