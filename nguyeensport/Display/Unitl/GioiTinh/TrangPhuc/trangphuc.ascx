<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="trangphuc.ascx.cs" Inherits="nguyeensport.Display.Unitl.GioiTinh.TrangPhuc.trangphuc" %>
<div class="size-guide-navigation_product-type">
    <div class="container-inner">
        <h2>Bạn tìm kiếm kích thức sản phẩm nào?</h2>
        <asp:Literal ID="ltMenuTrangPhuc" runat="server"></asp:Literal>
        
    </div>
</div>
<div class="size-guide-navigation_brand">
    <div class="container-inner">
        <h2><asp:Literal ID="ltTrangPhuc" runat="server"></asp:Literal></h2>
        <p>Chọn thương hiệu của bạn trong menu thả xuống bên dưới.</p>
        <div class="size-guide-navigation__brand-select-container">
            <asp:DropDownList ID="brand" runat="server" AutoPostBack="true" OnSelectedIndexChanged="brand_SelectedIndexChanged">
                <asp:ListItem Value="">Vui lòng chọn nhãn hiệu</asp:ListItem>
                <asp:ListItem Value="adidas">adidas</asp:ListItem>
                <asp:ListItem Value="nike">Nike</asp:ListItem>
                <asp:ListItem Value="puma">Puma</asp:ListItem>
                <asp:ListItem Value="mizuno">Mizuno</asp:ListItem>
                <asp:ListItem Value="newbalance">New Balance</asp:ListItem>
                <asp:ListItem Value="asics">Asics</asp:ListItem>
                <asp:ListItem Value="kamito">Kamito</asp:ListItem>
            </asp:DropDownList>

        </div>
    </div>
</div>

<asp:PlaceHolder ID="loadTableSize" runat="server"></asp:PlaceHolder>