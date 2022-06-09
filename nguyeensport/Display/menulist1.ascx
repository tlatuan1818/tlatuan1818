<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="menulist1.ascx.cs" Inherits="nguyeensport.Display.menulist1" %>
<nav>
    <ul class="menu-pc">
        <asp:Repeater ID="rptDanhMucCha" runat="server" OnItemDataBound="rptDanhMucCha_ItemDataBound">
            <ItemTemplate>
                <asp:HiddenField ID="hdMaDanhMuc" Value='<%#:Eval("maDanhMuc") %>' runat="server" />
                <li class="menu-pc__item">
                    <a href="/p/<%#:Eval("linkDanhMuc") %>" class="menu-pc__link"><%#: Eval("tenDanhMuc") %></a>
                    <div class="sub-nav-list-section sub-nav-list-section--global">
                        <div class="global-sub-nav">
                            <div class="global-sub-nav-column">

                                <asp:Literal ID="ltSubNavListItemHighLight" runat="server"></asp:Literal>
                                    
                             </div>
                             <asp:Repeater ID="rptMenuList" runat="server">
                                         
                                        <ItemTemplate>
                                           <asp:HiddenField ID="hfViTri" Value='<%#: Eval("viTri") %>' runat="server" />
                                           <asp:HiddenField ID="hfIDDanhMucCon" Value='<%#: Eval("maDanhMucCon") %>' runat="server" />
                                           <div class="global-sub-nav-column global-sub-nav-column--parent">
                                                <ul class="sub-nav-list global-sub-nav-column--parent ">
                                                    <li class="sub-nav-list__item sub-nav-list__item--group sub-nav-list__item--highlight sub-nav-list__item--underline">
                                                        <button title="<%#: Eval("tenDanhMucCon") %>" class="sub-nav-link sub-nav-link--empty  has-children ">
                                                            <%#: Eval("tenDanhMucCon") %>
                                                        </button>
                                                        <div class="sub-nav-list__content">
                                                            <ul class="sub-nav-list">
                                                                <li class="sub-nav-list__item sub-nav-list__item--mob-only">
                                                                    <a href="<%#: Eval("linkDanhMucCon") %>" class="sub-nav-link">View All
                                                                    </a>
                                                                </li>
                                                                 <asp:Repeater ID="rptMenuCap1" runat="server">
                                                                     <ItemTemplate>
                                                                          <li class="sub-nav-list__item">
                                                                             <a href="/<%#: Eval("linkDanhMucConCap1") %>/" class="sub-nav-link">
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
                </li>
            </ItemTemplate>
        </asp:Repeater>
    </ul>
</nav>
