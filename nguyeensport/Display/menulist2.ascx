<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="menulist2.ascx.cs" Inherits="nguyeensport.Display.menulist2" %>
<nav class="navigation">
    <div class="navigation__content">
        <ul class="nav-list" id="MenuItems">
            <li class="nav-list__item--close">
                <div class="close icon js-close-menu"></div>
            </li>
            <asp:Repeater ID="rptMenuList" runat="server" OnItemDataBound="rptMenuList_ItemDataBound">
                <ItemTemplate>
                    <asp:HiddenField ID="hdMaDanhMuc" Value='<%#:Eval("maDanhMuc") %>' runat="server" />
                    <li class="nav-list__item">
                        <a href="/p/<%#:Eval("linkDanhMuc") %>" class="nav-list__link"><%#: Eval("tenDanhMuc") %></a>
                    </li>
                    <div class="sub-nav-list-section--global">
                        <div class="global-sub-nav">
                            <asp:Repeater ID="rptSubMenuList" runat="server">
                                <ItemTemplate>
                                    <asp:HiddenField ID="hfViTri" Value='<%#: Eval("viTri") %>' runat="server" />
                                    <asp:HiddenField ID="hfIDDanhMucCon" Value='<%#: Eval("maDanhMucCon") %>' runat="server" />
                                    <div class="global-sub-nav-column global-sub-nav-column--parent  ">
                                        <ul class="sub-nav-list global-sub-nav-column--parent ">
                                            <li class="sub-nav-list__item sub-nav-list__item--group sub-nav-list__item--highlight sub-nav-list__item--underline">
                                                <div class="sub-nav-link sub-nav-link--empty has-children">
                                                    <%#: Eval("tenDanhMucCon") %>
                                                </div>
                                                <div class="sub-nav-list__content">
                                                    <ul class="sub-nav-list">
                                                        <li class="sub-nav-list__item sub-nav-list__item--mob-only">
                                                            <a href="<%#: Eval("linkDanhMucCon") %>" class="sub-nav-link">View All
                                                            </a>
                                                        </li>
                                                        <asp:Repeater ID="rptMenuList2" runat="server">
                                                            <ItemTemplate>
                                                                <li class="sub-nav-list__item">
                                                                    <a href="/p/<%#: Eval("linkDanhMucConCap1") %>/" class="sub-nav-link">
                                                                         <%#: Eval("tenDanhMucConCap1") %>
                                                                     </a>
                                                                </li>
                                                            </ItemTemplate>
                                                        </asp:Repeater>

                                                    </ul>
                                                </div>
                                            </li>
                                        </ul>
                                      </div>
                                </ItemTemplate>
                            </asp:Repeater> 
                        </div>
                    </div>
                </ItemTemplate>      
            </asp:Repeater>
        </ul>
    </div>
</nav>
