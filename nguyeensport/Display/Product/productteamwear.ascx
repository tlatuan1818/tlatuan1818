<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="productteamwear.ascx.cs" Inherits="nguyeensport.Display.Product.productteamwear" %>
 <div class="main">
        <div class="container-product">
            <ol class="breadcrumbs clearFix">
                <li class="breadcrumbs__list-item">
                    <a class="breadcrumbs__link" href="/">
                        <span class="breadcrumbs__name">NGUYEENSPORT</span>
                    </a>
                </li>
                <li class="breadcrumbs__list-item">
                    <asp:Literal ID="ltTenSanPham" runat="server"></asp:Literal>
                </li>
            </ol>
        </div>
        <div class="product-details-container">
            <div class="gallery-container">
                <div class="gallery-nav">
                    <asp:Literal ID="ltImage1" runat="server"></asp:Literal>
                    <asp:Literal ID="ltImage2" runat="server"></asp:Literal>
                    <asp:Literal ID="ltImage3" runat="server"></asp:Literal>
                    <asp:Literal ID="ltImage4" runat="server"></asp:Literal>
                    <asp:Literal ID="ltImage5" runat="server"></asp:Literal>
                    <asp:Literal ID="ltImage6" runat="server"></asp:Literal>
                    <asp:Literal ID="ltImage7" runat="server"></asp:Literal>
                </div>
                <div class="gallery-bg">
                    <asp:Literal ID="ltImage8" runat="server"></asp:Literal>
                </div>
                <div class="gallery-content">
                    <div class="product-container">
                        <div class="product-info">
                            <div class="rating">
                                     <div class="rating__stars">
                                         <asp:Literal ID="ltSao3" runat="server"></asp:Literal>
                                        
                                     </div>
                                     <div class="rating__review">(<asp:Literal ID="ltTongBinhLuan2" runat="server"></asp:Literal>)</div>
                                </div>
                        </div>
                        <div class="product-title">
                            <asp:Literal ID="ltTenSanPham2" runat="server"></asp:Literal>
                        </div>
                        <div class="product-pirce">
                            <asp:Literal ID="ltGiaCuoi" runat="server"></asp:Literal>
                            <asp:Literal ID="ltGiaDau" runat="server"></asp:Literal>
                            <asp:Literal ID="ltGiaGiam" runat="server"></asp:Literal>  
                        </div>
                        <div class="product-filters">
                            <div class="product-filters__row">
                                
                                <div class="action-dropdown action-dropdown--full-view">
                                        <asp:Literal ID="ltSizeXS" runat="server"></asp:Literal>
                                        <asp:Literal ID="ltSizeS" runat="server"></asp:Literal>
                                        <asp:Literal ID="ltSizeM" runat="server"></asp:Literal>
                                        <asp:Literal ID="ltSizeL" runat="server"></asp:Literal>
                                        <asp:Literal ID="ltSizeXL" runat="server"></asp:Literal>
                                        <asp:Literal ID="ltSize2XL" runat="server"></asp:Literal>
                                        <asp:Literal ID="ltSize3XL" runat="server"></asp:Literal>
                                </div>
                                <div class="action-dropdown">
                                   <div class="action-dropdown__wrapper">
                                        <asp:TextBox ID="txtSize" runat="server" CssClass="action-dropdown__text" placeholder="Size"></asp:TextBox>
                                    </div>
                                    <div class="quantity-selector">
                                        <asp:TextBox ID="txtSoLuong" runat="server" CssClass="quantity-selector__input" Text="1" pattern="[0-9*]"></asp:TextBox>
                                    </div>
                                    <span class="action-dropdown_error"><asp:Literal ID="ltThongBao" runat="server"></asp:Literal></span>
                                </div>
                            </div>
                            <div class="product-filters__row">
                               <div class="product-customise__close"  id="js-customise">
                                    <div class="product-customise__content">
                                        <p class="product-customise__text">Cho phép thêm 4-6 ngày đối với các mặt hàng tùy chỉnh và vui lòng kiểm tra Hình thức đổi trả của chúng tôi để biết các hạn chế các mặt hàng tùy chỉnh.</p>
                                    </div>
                                    <div class="product-customise__form">
                                        <div class="product-customise__box">
                                            <div class="product-customise__label">Nameset:</div>
                                            <asp:TextBox ID="txtNameset" runat="server" CssClass="product-customise__input" placeholder="Ronaldo"></asp:TextBox>
                                            
                                        </div>
                                        <div class="product-customise__box">
                                            <div class="product-customise__label">Số áo:</div>
                                            <asp:TextBox ID="txtSoAo" runat="server" CssClass="product-customise__input" placeholder="7" pattern="[0-9]*"></asp:TextBox>
                                        </div>
                                        <div class="product-customise__box">
                                            <asp:HiddenField ID="hdImage1" runat="server" />
                                             <div class="product-customise__label">Logo (20.000):</div>
                                             <asp:FileUpload ID="txtLogo" runat="server" CssClass="file js-file"></asp:FileUpload>
                                             <span onclick="fileClick()">Tải ảnh</span>
                                             <div class="image js-image-active">
                                                 <img src="/" class="js-img" alt=""/>
                                                 <div id="cancel-btn"><div class="close icon"></div></div>
                                             </div>
                                        </div>
                                         <div class="product-customise__box">
                                             <asp:HiddenField ID="hdImage2" runat="server" />
                                            <div class="product-customise__label">Nhà tài trợ (20.000):</div>
                                            <asp:FileUpload ID="txtNhaTaiTro" runat="server" CssClass="file js-file1"></asp:FileUpload>
                                              <span onclick="fileClick1()">Tải ảnh</span>
                                             <div class="image js-image-active1">
                                                 <img src="/" class="js-img1" alt=""/>
                                                 <div id="cancel-btn1"><div class="close icon"></div></div>
                                             </div>
                                        </div>
                                         <div class="product-customise__box">
                                            <div class="product-customise__label">Kiểu in:</div>
                                             <div class="select-custom">
                                                <asp:DropDownList ID="drKieuIn" runat="server" AutoPostBack="false" CssClass="custom-select-element">
                                                    <asp:ListItem Value="In lụa">In lụa - 15.000</asp:ListItem>
                                                    <asp:ListItem Value="Decal thường">In decal thường - 40.000</asp:ListItem>
                                                    <asp:ListItem Value="Decal xịn">In decal xịn - 100.000</asp:ListItem>
                                                </asp:DropDownList>
                                             </div>
                                        </div>
                                    </div>
                                    <div class="product-customise__price">Giá tùy chỉnh bổ sung là In + Logo + Nhà tài trợ</div>
                                </div>
                           </div>
                            <div class="product-filters__row">
                                <asp:LinkButton ID="addCart" runat="server" CssClass="button button--submit" OnClick="addCart_Click"><div class="button__title">Thêm vào giỏ</div></asp:LinkButton>
                                <div class="button button--custom" id="js-customsie_btn"><div class="button__title">Tùy chỉnh</div></div>
                            </div>
                            <div class="product-endow">
                                <div class="endow-content">
                                    <div class="endow_item">
                                        <div class="endow-text">Ưu đãi dành cho đội bóng:</div>
                                    </div>
                                     <div class="endow_item">
                                        <span class="endow-icon"><img src="/images/product/gift-solid.svg" alt="box"></span>
                                        <div class="endow-text">Miễn phí in ấn.</div>
                                    </div>
                                     <div class="endow_item">
                                        <span class="endow-icon"><img src="/images/product/gift-solid.svg" alt="box"></span>
                                        <div class="endow-text">Tăng túi đựng đồ đội.</div>
                                    </div>
                                   <div class="endow_item">
                                        <span class="endow-icon"><img src="/images/product/gift-solid.svg" alt="box"></span>
                                        <div class="endow-text">Tặng voucher giảm 10%.</div>
                                    </div>
                                    <div class="endow_item">
                                        <span class="endow-icon"><img src="/images/product/shipping-fast-solid.svg" alt="shipping"></span>
                                        <div class="endow-text">Free ship</div>
                                    </div>
                                    <div class="endow_item">
                                        <span class="endow-icon"><img src="/images/product/sync-alt-solid.svg" alt="sync-alt"></span>
                                        <div class="endow-text">Đổi trả trong 30 ngày.</div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div> 
        </div>
        <div class="bulk-size">
            <div class="bulk-size-container">
                <div class="bulk-size-container__items">
                    <%
                        code = Page.RouteData.Values["code"] as string;
                        System.Data.DataTable dtSanPham = new System.Data.DataTable();
                        nguyeensport.dal.clsquanlysanpham _quanlysanpham = new nguyeensport.dal.clsquanlysanpham();
                        dtSanPham = _quanlysanpham.timAoTheoID(code);
                        if(dtSanPham.Rows.Count > 0)
                        {
                            System.Data.DataTable dtSize = new System.Data.DataTable();
                            dtSize = _quanlysanpham.timSizeTheoID(dtSanPham.Rows[0]["ID"].ToString());
                            if(dtSize.Rows.Count > 0)
                            {
                                foreach(System.Data.DataRow dr in dtSize.Rows)
                                {
                                    if (dr["TenSize"].ToString() == "XS")
                                    {
                                        if (int.Parse(dr["SoLuong"].ToString()) > 0)
                                        { %>
                                    
                                            <div class="bulk-size-item">
                                                <span class="bulk-size-item__value"><%Response.Write(dr["TenSize"].ToString()); %></span>
                                                <div class="product-prices">
                                                    <span class="product-prices__item product-prices__item--original"><%Response.Write(string.Format("{0:N0}", dtSanPham.Rows[0]["GiaDau"]) + " VNĐ"); %></span>
                                                    <span class="product-prices__item product-prices__item--saving"><%Response.Write(string.Format("{0:N0}", dtSanPham.Rows[0]["GiaCuoi"])+ " VNĐ");%></span>
                                                </div>
                                                <div class="product-amount"><%Response.Write("Số lượng: " + dr["SoLuong"].ToString());%></div>
                                                <div class="quantity-selector">
                                                    <asp:TextBox ID="txtSoLuong1" runat='server' CssClass="quantity-selector__input" pattern="[0-9*]" placeholder="Số lượng"></asp:TextBox>
                                                </div>
                                            </div>
                                
                                    <%
                                        }
                                        else{%>
                                            <div class="bulk-size-item bulk-active">
                                                <span class="bulk-size-item__value"><%Response.Write(dr["TenSize"].ToString()); %></span>
                                                <div class="product-prices">
                                                    <span class="product-prices__item product-prices__item--original"><%Response.Write(string.Format("{0:N0}", dtSanPham.Rows[0]["GiaDau"])+ " VNĐ"); %></span>
                                                    <span class="product-prices__item product-prices__item--saving"><%Response.Write(string.Format("{0:N0}", dtSanPham.Rows[0]["GiaCuoi"]) + " VNĐ");%></span>
                                                </div>
                                                <div class="product-amount"><%Response.Write("Hết size");%></div>
                                                <div class="quantity-selector">
                                                    <input type="text" class="quantity-selector__input" pattern="[0-9*]" placeholder="Số lượng" />
                                                </div>
                                            </div>
                                        <%}
                                    }
                                    if (dr["TenSize"].ToString() == "S")
                                    {
                                        if (int.Parse(dr["SoLuong"].ToString()) > 0)
                                        { %>
                                    
                                            <div class="bulk-size-item">
                                                <span class="bulk-size-item__value"><%Response.Write(dr["TenSize"].ToString()); %></span>
                                                <div class="product-prices">
                                                    <span class="product-prices__item product-prices__item--original"><%Response.Write(string.Format("{0:N0}", dtSanPham.Rows[0]["GiaDau"]) + " VNĐ"); %></span>
                                                    <span class="product-prices__item product-prices__item--saving"><%Response.Write(string.Format("{0:N0}", dtSanPham.Rows[0]["GiaCuoi"])+ " VNĐ");%></span>
                                                </div>
                                                <div class="product-amount"><%Response.Write("Số lượng: " + dr["SoLuong"].ToString());%></div>
                                                <div class="quantity-selector">
                                                    <asp:TextBox ID="txtSoLuong2" runat='server' CssClass="quantity-selector__input" pattern="[0-9*]" placeholder="Số lượng"></asp:TextBox>
                                                </div>
                                            </div>
                                
                                    <%
                                        }
                                        else{%>
                                            <div class="bulk-size-item bulk-active">
                                                <span class="bulk-size-item__value"><%Response.Write(dr["TenSize"].ToString()); %></span>
                                                <div class="product-prices">
                                                    <span class="product-prices__item product-prices__item--original"><%Response.Write(string.Format("{0:N0}", dtSanPham.Rows[0]["GiaDau"]) + " VNĐ"); %></span>
                                                    <span class="product-prices__item product-prices__item--saving"><%Response.Write(string.Format("{0:N0}", dtSanPham.Rows[0]["GiaCuoi"]) + " VNĐ");%></span>
                                                </div>
                                                <div class="product-amount"><%Response.Write("Hết size");%></div>
                                                <div class="quantity-selector">
                                                   <input type="text" class="quantity-selector__input" pattern="[0-9*]" placeholder="Số lượng" />
                                                </div>
                                            </div>
                                        <%}
                                    }
                                    if (dr["TenSize"].ToString() == "M")
                                    {
                                        if (int.Parse(dr["SoLuong"].ToString()) > 0)
                                        { %>
                                    
                                            <div class="bulk-size-item">
                                                <span class="bulk-size-item__value"><%Response.Write(dr["TenSize"].ToString()); %></span>
                                                <div class="product-prices">
                                                    <span class="product-prices__item product-prices__item--original"><%Response.Write(string.Format("{0:N0}", dtSanPham.Rows[0]["GiaDau"])+ " VNĐ"); %></span>
                                                    <span class="product-prices__item product-prices__item--saving"><%Response.Write(string.Format("{0:N0}", dtSanPham.Rows[0]["GiaCuoi"])+ " VNĐ");%></span>
                                                </div>
                                                <div class="product-amount"><%Response.Write("Số lượng: " + dr["SoLuong"].ToString());%></div>
                                                <div class="quantity-selector">
                                                    <asp:TextBox ID="txtSoLuong3" runat='server' CssClass="quantity-selector__input" pattern="[0-9*]" placeholder="Số lượng"></asp:TextBox>
                                                </div>
                                            </div>
                                
                                    <%
                                        }
                                        else{%>
                                            <div class="bulk-size-item bulk-active">
                                                <span class="bulk-size-item__value"><%Response.Write(dr["TenSize"].ToString()); %></span>
                                                <div class="product-prices">
                                                    <span class="product-prices__item product-prices__item--original"><%Response.Write(string.Format("{0:N0}", dtSanPham.Rows[0]["GiaDau"]) + " VNĐ"); %></span>
                                                    <span class="product-prices__item product-prices__item--saving"><%Response.Write(string.Format("{0:N0}", dtSanPham.Rows[0]["GiaCuoi"]) + " VNĐ");%></span>
                                                </div>
                                                <div class="product-amount"><%Response.Write("Hết size");%></div>
                                                <div class="quantity-selector">
                                                    <input type="text" class="quantity-selector__input" pattern="[0-9*]" placeholder="Số lượng" />
                                                </div>
                                            </div>
                                        <%}
                                    }
                                    if (dr["TenSize"].ToString() == "L")
                                    {
                                        if (int.Parse(dr["SoLuong"].ToString()) > 0)
                                        { %>
                                    
                                            <div class="bulk-size-item">
                                                <span class="bulk-size-item__value"><%Response.Write(dr["TenSize"].ToString()); %></span>
                                                <div class="product-prices">
                                                    <span class="product-prices__item product-prices__item--original"><%Response.Write(string.Format("{0:N0}", dtSanPham.Rows[0]["GiaDau"]) + " VNĐ"); %></span>
                                                    <span class="product-prices__item product-prices__item--saving"><%Response.Write(string.Format("{0:N0}", dtSanPham.Rows[0]["GiaCuoi"]) + " VNĐ");%></span>
                                                </div>
                                                <div class="product-amount"><%Response.Write("Số lượng: " + dr["SoLuong"].ToString());%></div>
                                                <div class="quantity-selector">
                                                    <asp:TextBox ID="txtSoLuong4" runat='server' CssClass="quantity-selector__input" pattern="[0-9*]" placeholder="Số lượng"></asp:TextBox>
                                                </div>
                                            </div>
                                
                                    <%
                                        }
                                        else{%>
                                            <div class="bulk-size-item bulk-active">
                                                <span class="bulk-size-item__value"><%Response.Write(dr["TenSize"].ToString()); %></span>
                                                <div class="product-prices">
                                                    <span class="product-prices__item product-prices__item--original"><%Response.Write(string.Format("{0:N0}", dtSanPham.Rows[0]["GiaDau"]) + " VNĐ"); %></span>
                                                    <span class="product-prices__item product-prices__item--saving"><%Response.Write(string.Format("{0:N0}", dtSanPham.Rows[0]["GiaCuoi"]) + " VNĐ");%></span>
                                                </div>
                                                <div class="product-amount"><%Response.Write("Hết size");%></div>
                                                <div class="quantity-selector">
                                                    <input type="text" class="quantity-selector__input" pattern="[0-9*]" placeholder="Số lượng" />
                                                </div>
                                            </div>
                                        <%}
                                    }
                                    if (dr["TenSize"].ToString() == "XL")
                                    {
                                        if (int.Parse(dr["SoLuong"].ToString()) > 0)
                                        { %>
                                    
                                            <div class="bulk-size-item">
                                                <span class="bulk-size-item__value"><%Response.Write(dr["TenSize"].ToString()); %></span>
                                                <div class="product-prices">
                                                    <span class="product-prices__item product-prices__item--original"><%Response.Write(string.Format("{0:N0}", dtSanPham.Rows[0]["GiaDau"]) + " VNĐ"); %></span>
                                                    <span class="product-prices__item product-prices__item--saving"><%Response.Write(string.Format("{0:N0}", dtSanPham.Rows[0]["GiaCuoi"]) + " VNĐ");%></span>
                                                </div>
                                                <div class="product-amount"><%Response.Write("Số lượng: " + dr["SoLuong"].ToString());%></div>
                                                <div class="quantity-selector">
                                                    <asp:TextBox ID="txtSoLuong5" runat='server' CssClass="quantity-selector__input" pattern="[0-9*]" placeholder="Số lượng"></asp:TextBox>
                                                </div>
                                            </div>
                                
                                    <%
                                        }
                                        else{%>
                                            <div class="bulk-size-item bulk-active">
                                                <span class="bulk-size-item__value"><%Response.Write(dr["TenSize"].ToString()); %></span>
                                                <div class="product-prices">
                                                    <span class="product-prices__item product-prices__item--original"><%Response.Write(string.Format("{0:N0}", dtSanPham.Rows[0]["GiaDau"]) + " VNĐ"); %></span>
                                                    <span class="product-prices__item product-prices__item--saving"><%Response.Write(string.Format("{0:N0}", dtSanPham.Rows[0]["GiaCuoi"]) + " VNĐ");%></span>
                                                </div>
                                                <div class="product-amount"><%Response.Write("Hết size");%></div>
                                                <div class="quantity-selector">
                                                    <input type="text" class="quantity-selector__input" pattern="[0-9*]" placeholder="Số lượng" />
                                                </div>
                                            </div>
                                        <%}
                                    }
                                    if (dr["TenSize"].ToString() == "2XL")
                                    {
                                        if (int.Parse(dr["SoLuong"].ToString()) > 0)
                                        { %>
                                    
                                            <div class="bulk-size-item">
                                                <span class="bulk-size-item__value"><%Response.Write(dr["TenSize"].ToString()); %></span>
                                                <div class="product-prices">
                                                    <span class="product-prices__item product-prices__item--original"><%Response.Write(string.Format("{0:N0}", dtSanPham.Rows[0]["GiaDau"]) + " VNĐ"); %></span>
                                                    <span class="product-prices__item product-prices__item--saving"><%Response.Write(string.Format("{0:N0}", dtSanPham.Rows[0]["GiaCuoi"]) + " VNĐ");%></span>
                                                </div>
                                                <div class="product-amount"><%Response.Write("Số lượng: " + dr["SoLuong"].ToString());%></div>
                                                <div class="quantity-selector">
                                                    <asp:TextBox ID="txtSoLuong6" runat='server' CssClass="quantity-selector__input" pattern="[0-9*]" placeholder="Số lượng"></asp:TextBox>
                                                </div>
                                            </div>
                                
                                    <%
                                        }
                                        else{%>
                                            <div class="bulk-size-item bulk-active">
                                                <span class="bulk-size-item__value"><%Response.Write(dr["TenSize"].ToString()); %></span>
                                                <div class="product-prices">
                                                    <span class="product-prices__item product-prices__item--original"><%Response.Write(string.Format("{0:N0}", dtSanPham.Rows[0]["GiaDau"]) + " VNĐ"); %></span>
                                                    <span class="product-prices__item product-prices__item--saving"><%Response.Write(string.Format("{0:N0}", dtSanPham.Rows[0]["GiaCuoi"]) + " VNĐ");%></span>
                                                </div>
                                                <div class="product-amount"><%Response.Write("Hết size");%></div>
                                                <div class="quantity-selector">
                                                    <input type="text" class="quantity-selector__input" pattern="[0-9*]" placeholder="Số lượng" />
                                                </div>
                                            </div>
                                        <%}
                                    }
                                    if (dr["TenSize"].ToString() == "3XL")
                                    {
                                        if (int.Parse(dr["SoLuong"].ToString()) > 0)
                                        { %>
                                    
                                            <div class="bulk-size-item">
                                                <span class="bulk-size-item__value"><%Response.Write(dr["TenSize"].ToString()); %></span>
                                                <div class="product-prices">
                                                    <span class="product-prices__item product-prices__item--original"><%Response.Write(string.Format("{0:N0}", dtSanPham.Rows[0]["GiaDau"]) + " VNĐ"); %></span>
                                                    <span class="product-prices__item product-prices__item--saving"><%Response.Write(string.Format("{0:N0}", dtSanPham.Rows[0]["GiaCuoi"]) + " VNĐ");%></span>
                                                </div>
                                                <div class="product-amount"><%Response.Write("Số lượng: " + dr["SoLuong"].ToString());%></div>
                                                <div class="quantity-selector">
                                                    <asp:TextBox ID="txtSoLuong7" runat='server' CssClass="quantity-selector__input" pattern="[0-9*]" placeholder="Số lượng"></asp:TextBox>
                                                </div>
                                            </div>
                                
                                    <%
                                        }
                                        else{%>
                                            <div class="bulk-size-item bulk-active">
                                                <span class="bulk-size-item__value"><%Response.Write(dr["TenSize"].ToString()); %></span>
                                                <div class="product-prices">
                                                    <span class="product-prices__item product-prices__item--original"><%Response.Write(string.Format("{0:N0}", dtSanPham.Rows[0]["GiaDau"]) + " VNĐ"); %></span>
                                                    <span class="product-prices__item product-prices__item--saving"><%Response.Write(string.Format("{0:N0}", dtSanPham.Rows[0]["GiaCuoi"]) + " VNĐ");%></span>
                                                </div>
                                                <div class="product-amount"><%Response.Write("Hết size");%></div>
                                                <div class="quantity-selector">
                                                    <input type="text" class="quantity-selector__input" pattern="[0-9*]" placeholder="Số lượng" />
                                                </div>
                                            </div>
                                        <%}
                                    }
                                }
                            }
                        }
                    %>
                </div>
                <div class="bulk-size-container__controller">
                    <div class="bulk-size-messaging">
                        <asp:Literal ID="ltThongBao2" runat="server"></asp:Literal>
                    </div>
                    <div class="button button--submit">
                        <asp:LinkButton ID="lnkadd" runat="server" CssClass="button__title" OnClick="lnkadd_Click">Thêm vào giỏ</asp:LinkButton>
                    </div>
                    <div class="button button--custom">
                        <asp:LinkButton ID="btncustom" runat="server" CssClass="button__title" OnClick="btncustom_Click">Tùy chỉnh</asp:LinkButton>
                        
                    </div>
                </div>
            </div>
        </div>
        <div class="container-product">
            <div class="double-product_box">
                <div class="product_box--item">
                    <ul class="accordion accordion--guttered">
                        <li class="accordion__item">
                            <div class="accordion__title" id="btnclick1">Mô tả sản phẩm</div>
                            <asp:Literal ID="ltMoTa" runat="server"></asp:Literal>
                        </li>
                        <li class="accordion__item">
                            <div class="accordion__title" id="btnclick2">Đánh giá
                                <div class="rating">
                                     <div class="rating__stars">
                                         <asp:Literal ID="ltSao" runat="server"></asp:Literal>
                                        
                                     </div>
                                     <div class="rating__review">(<asp:Literal ID="ltTongBinhLuan" runat="server"></asp:Literal>)</div>
                                </div>
                            </div>
                            <div class="accordion__content" id="content-two">
                                <div class="product-reviews js-product-reviews">
                                    <div class="reviews-summary">
                                        <span class="reviews-summary__item">
                                            <asp:Literal ID="ltTongBinhLuan1" runat="server"></asp:Literal> Bình luận
                                        </span>
                                        <span class="reviews-summary__item">
                                            Đánh giá trung bình:
                                            <asp:Literal ID="ltDanhGiaTB" runat="server"></asp:Literal>
                                        </span>
                                    </div>
                                </div>
                                  <hr class="product-reviews__divider">
                                  <div class="product-reviews__content js-product-reviews-content">
                                    <!--reviews list-->
                                    <ul class="reviews-list js-reviews-list">
                                        <asp:Repeater ID="rptComment" runat="server">
                                            <ItemTemplate>
                                                <li class="reviews-list__item">
                                                    <div class="reviews-list__header">
                                                        <div class="rating">
                                                             <div class="rating__stars">
                                                                <div class="rating__stars-filled" <%#:Eval("SoSaoCSS") %>></div>
                                                             </div>
                                                        </div>
                                                        <div class="reviews-list__author"><%#: Eval("FullName") %></div>
                                                        <div class="reviews-list__date"><%#: Eval("NgayBinhLuan") %></div>
                                                
                                                    </div>
                                                    <div class="reviews-list__content">
                                                        <div class="reviews-list__text"><%#: Eval("NoiDung") %></div>
                                                    </div>
                                                </li>
                                            </ItemTemplate>
                                        </asp:Repeater>
                                    </ul>
                                    <!--pagination-->
                                    <div class="product-reviews__pagination">
                                        <div class="pagination js-pagination">
                                            <asp:LinkButton ID="btnPrev" runat="server" CssClass="pagination__prev js-pagination-prev" OnClick="btnPrev_Click" >Prev</asp:LinkButton>
                                             <div class="pagination__summary">
                                                Trang
                                                <span class="pagination__current-page"><asp:Literal ID="ltPage" runat="server"></asp:Literal></span>
                                                của
                                                <span class="pagination__total-page"><asp:Literal ID="ltTotalPage" runat="server"></asp:Literal></span>
                                            </div>
                                            <asp:LinkButton ID="btnNext" runat="server" CssClass ="pagination__next js-pagination-next" OnClick="btnNext_Click">Next</asp:LinkButton>
                                        </div>
                                    </div>
                                    <!--comment-->
                                    <div class="product-reviews__comment">
                                        <asp:MultiView ID="cmtView" runat="server" ActiveViewIndex="0">
                                            <asp:View ID="v1" runat="server">
                                                <div class="button button--cmt">
                                                    <asp:LinkButton ID="btnCmt" runat="server" CssClass="button__title" OnClick="btnCmt_Click">Bình luận</asp:LinkButton>
                                                </div>
                                            </asp:View>
                                            <asp:View ID="v2" runat="server">
                                                <div class="form-cmt">
                                                    <div class="form-cmt_item">
                                                        <div class="form-input__name">Nội dung:</div>
                                                        <asp:TextBox ID="txtNoiDung" runat="server" CssClass="form-input__text" TextMode="MultiLine"></asp:TextBox>
                                                        
                                                    </div>
                                                    <div class="form-cmt_item">
                                                        <div class="form-input__name">Đánh giá (1 - 5) sao:</div>
                                                        <asp:TextBox ID="txtDanhGia" runat="server" CssClass="form-input__text" pattern="[1-5]*" ></asp:TextBox>
                                                       
                                                    </div>
                                                    <div class="form-cmt_item">
                                                        <div class="button button--cmt">
                                                            <asp:LinkButton ID="btnGui" runat="server" CssClass="button__title" OnClick="btnGui_Click">Gửi</asp:LinkButton>
                                                        </div>
                                                    </div>
                                                </div>
                                            </asp:View>
                                        </asp:MultiView>
                                    </div>
                                </div>
                            </div>

                        </li>
                        
                    </ul>
                </div>
                <div class="product_box--item">
                    <div class="product-recommended_wrapper">
                        <h2 class="product-recommended_title">
                            <span class="product-recommended_title--text">Đề xuất cho bạn</span>
                        </h2>
                        <div class="product-recommended_box js-product-recommended">
                            <asp:Repeater ID="rptDeXuat" runat="server">
                                <ItemTemplate>
                                    <a href="/<%#: Eval("DanhMuc") %>/<%#:Eval("Link") %>-<%#:Eval("ID") %>" class="product-recommended_item">
                                        <img src="/<%#:Eval("Avatar") %>" alt="<%#:Eval("TenSanPham") %>">
                                        <p class="recommended-name"><%#:Eval("TenSanPham") %></p>
                                        <p class="recommended-price"><%#:string.Format("{0:N0}",Eval("GiaCuoi")) %></p>
                                    </a>
                                </ItemTemplate>
                            </asp:Repeater>
                        </div>
                    </div>
                    <div class="product-look_wrapper">
                        <h2 class="product-look_title">
                            <span class="product-look_title--text">Teamwear mới</span>
                        </h2>
                        <div class="product-look_box--wrapper">
                            <div class="product-look_box">
                                <asp:Repeater ID="rptSanPhamMoi" runat="server">
                                    <ItemTemplate>
                                        <a href="/<%#: Eval("DanhMuc") %>/<%#:Eval("Link") %>-<%#:Eval("ID") %>" class="product-look_item">
                                            <img src="/<%#:Eval("Avatar") %>"  alt="<%#:Eval("TenSanPham") %>">
                                            <p class="look-name"><%#:Eval("TenSanPham") %></p>
                                            <p class="look-price"><%#:string.Format("{0:N0}",Eval("GiaCuoi")) %></p>
                                        </a>
                                    </ItemTemplate>
                                </asp:Repeater>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
<asp:MultiView ID="customView" ActiveViewIndex="0" runat="server">
    <asp:View ID="cv1" runat="server"></asp:View>
    <asp:View ID="cv2" runat="server">
        <section class="base-popup__wrapper">
    <div class="base-popup teamwear-customisation base-popup--white base-popup--desktop-mode">
        <div class="base-popup__content-wrapper">
            <div class="base-popup__header-container base-popup__header-container--with-content">
                <asp:LinkButton ID="btncustomClose" runat="server" CssClass="base-popup__close-button js-base-popup__close" OnClick="btncustomClose_Click"></asp:LinkButton> 
            </div>
            <div class="base-popup__content-container">
                <div class="popup-column-container">
                    <div class="popup-column popup-column--left">
                        <div class="finish-customisation-form">
                            <div class="finish-customisation-form__kit-info">
                                <div class="save-fields save-fields--inline">
                                     <div class="input-field teamwear-customisation-save-screen__field kit-type save-fields__child-wrapper">
                                        <span>Kiểu in</span>
                                         <div class="custom-select">
                                            <asp:DropDownList ID="drListKieuIn" runat="server" CssClass="custom-select__element">
                                                <asp:ListItem Value="In lụa">In lụa - 15.000</asp:ListItem>
                                                <asp:ListItem Value="Decal thường">In decal thường - 40.000</asp:ListItem>
                                                <asp:ListItem Value="Decal xịn">In decal xịn - 100.000</asp:ListItem>
                                            </asp:DropDownList>
                                         </div>
                                    </div>
                                    
                                    <div class="save-fields__child-wrapper custom-datalist is-empty">
                                        <div class="input-field teamwear-customisation-save-screen__field team-name">
                                            <span>Logo CLB</span>
                                            <asp:HiddenField ID="hdImage3" runat="server" />
                                            <asp:FileUpload ID="txtLogo1" runat="server" CssClass="input-file js-file2" />
                                            <span class="input-file__span" onclick="fileClick2()">Tải ảnh</span>
                                            <div class="image js-image-active2">
                                                <img class="js-img2" src="/" alt="" />
                                                <div id="cancel-btn2">
                                                    <div class=" close icon"></div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="input-field teamwear-customisation-save-screen__field club-name save-fields__child-wrapper">
                                        <span>Nhà tài trợ</span>
                                        <asp:HiddenField ID="hdImage4" runat="server" />
                                        <asp:FileUpload ID="txtNhaTaiTro1" runat="server" CssClass="input-file js-file3" />
                                        <span class="input-file__span" onclick="fileClick3()">Tải ảnh</span>
                                        <div class="image js-image-active3">
                                                <img class="js-img3" src="/" alt="" />
                                                <div id="cancel-btn3">
                                                    <div class=" close icon"></div>
                                                </div>
                                            </div>
                                    </div>
                                   
                                </div>
                            </div>
                            <div class="finish-customisation-form__team-info">
                                <div class="teamwear-customisation-info-allocation-box">
                                    <span class="teamwear-customisation-info-allocation-box__label">Vui lòng điền tên và số áo</span>
                                    <ul class="teamwear-customisation-info-allocation-box__list">
                                        
                                           <asp:Repeater ID="rptCustom" runat="server">
                                               <ItemTemplate>

                                               
                                                <li class="teamwear-customisation-info-allocation-box__list-item">
                                                    <div class="info-allocation">
                                                        <span class="info-allocation__label">
                                                            Size -
                                                             <span class="info-allocation__label-bold"><asp:Label ID="lbSize" runat="server" Text='<%#:Eval("TenSize")%>'></asp:Label></span>
                                                        </span>
                                                        <div class="info-allocation__input-list">
                                                            <label class="input-field info-allocation__input info-allocation__input--short">
                                                               <asp:TextBox ID="txtNameset1"  runat="server" CssClass="input input-nameset"  placeholder="Name set"></asp:TextBox>
                                                            </label>
                                                            <label class="input-field info-allocation__input info-allocation__input--long">
                                                                <asp:TextBox ID="txtSoAo1" runat="server" CssClass="input input-number"  placeholder="Số áo"></asp:TextBox> 
                                                            </label>
                                                        </div>
                                                    </div>
                                                </li>
                                                   </ItemTemplate>
                                        </asp:Repeater>

                                    </ul>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="popup-column popup-column--right">
                        <div class="popup-column--right__price-block">
                            <div class="teamwear-customisation-running-subtotal">
                                <ul>
                                    <li class="teamwear-customisation-running-subtotal__item">
                                        <div class="teamwear-customisation-running-subtotal__discount-name">
                                            <span class="teamwear-customisation-running-subtotal__discount-name__title">Tổng sản phẩm</span>
                                        </div>
                                        <span class="teamwear-customisation-running-subtotal__discount-item"><asp:Literal ID="ltTongSanPham" runat="server"></asp:Literal></span>
                                    </li>
                                    <li class="teamwear-customisation-running-subtotal__item">
                                        <div class="teamwear-customisation-running-subtotal__discount-name">
                                            <span class="teamwear-customisation-running-subtotal__discount-name__title">Tạm tính</span>
                                        </div>
                                        <span class="teamwear-customisation-running-subtotal__discount-item"><asp:Literal ID="ltTamTinh" runat="server"></asp:Literal> VNĐ</span>
                                    </li>
                                </ul>
                            </div>
                            <hr class="popup-column--right__delimeter" />
                            <ul class="teamwear-running-price">
                                <li class="teamwear-running-price__customisation-type-container">
                                    <span class="teamwear-running-price__customisation-type-name">Lưu ý</span>
                                    <ul>
                                        <li class="teamwear-running-price__customisation-type-option">
                                            <span class="teamwear-running-price__customisation-type-option-description">Giá của logo là 20,000 VNĐ</span>
                                        </li>
                                        <li class="teamwear-running-price__customisation-type-option">
                                            <span class="teamwear-running-price__customisation-type-option-description">Giá của nhà tài trợ là 20,000 VNĐ</span>
                                        </li>
                                    </ul>
                                </li>

                            </ul>
                        </div>
                        <div class="teamwear-customisation-footer">
                            <div class="teamwear-customisation-footer-buttons">
                                <div class="teamwear-customisation-footer-buttons__button-add-to-bag">
                                    <div class="button button--submit">
                                        <asp:LinkButton ID="addCustom" runat="server" CssClass="button__title" OnClick="addCustom_Click">Thêm vào giỏ</asp:LinkButton>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
    </asp:View>
</asp:MultiView>
