<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="socialmedia.ascx.cs" Inherits="nguyeensport.admin.ortherpage.socialmedia" %>

<asp:Repeater ID="rptPost" runat="server">
    <ItemTemplate>
        <p><%#: Eval("message") %></p>
        <img src="<%#:Eval("full_picture") %>" alt="<%#: Eval("message") %>" />
    </ItemTemplate>
</asp:Repeater>