<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="header.ascx.cs" Inherits="nguyeensport.Display.header" %>
<header>
    <a class="logo" href="/">
        <picture>
            <source  media="(max-width:768px)" srcset="/images/common/nguyeensport_sp.svg" />
            <img src="/images/common/nguyeensport.svg" alt="NGUYEENSPORT">
        </picture>
        
    </a>
    <div class="h-icon">
        <img src="/images/common/search.svg" alt="Search..."  class="js-open-search">
        <asp:Literal ID="ltAvatar" runat="server">
                
        </asp:Literal>
        <div class="h-cart js-open-cart">
            <img src="/images/common/cart.svg" alt="Cart" >
            <asp:Literal runat="server" ID="ltSoLuong"></asp:Literal>
        </div>
        <img src="/images/common/menu.svg" alt="menu" class="menu-icon js-open-menu">
    </div>
    <div class="h-menu">
        <img src="/images/common/menu.svg" alt="H-menu" class="js-menu">
        <img src="/images/common/search.svg" alt="Search..." class="js-search">
        <a href="/" class="logo-btn"></a>
        <asp:Literal ID="ltAvatar1" runat="server"></asp:Literal>
        
        <div class="h-cart js-cart">
            <img src="/images/common/cart.svg" alt="Cart">
            <asp:Literal runat="server" ID="ltSoLuong1"></asp:Literal>
        </div>
    </div>
</header>
<div class="formAccount" id="js-formaccount">
    <ul class="formAccount-menu">
        <li class="formAccount-list">
            <asp:LinkButton ID="lnkInfo" runat="server">Thông tin tài khoản</asp:LinkButton>
        </li>
        <li class="formAccount-list">
            <asp:LinkButton ID="lnkLogout" runat="server" OnClick="lnkLogout_Click">Đăng xuất</asp:LinkButton>
        </li>
    </ul>
</div>
