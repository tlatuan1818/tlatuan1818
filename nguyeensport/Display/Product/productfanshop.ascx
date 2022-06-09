<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="productfanshop.ascx.cs" Inherits="nguyeensport.Display.Product.productfanshop" %>
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
                                        <asp:TextBox ID="txtSoLuong" runat="server" CssClass="quantity-selector__input"  Text="1" pattern="[0-9*]"></asp:TextBox>
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
                                            <div class="product-customise__label">Patch 1(20.000):</div>
                                            <asp:TextBox ID="txtPatchLeft" runat="server" CssClass="product-customise__input" placeholder="Premier League"></asp:TextBox>
                                           
                                        </div>
                                         <div class="product-customise__box">
                                            <div class="product-customise__label">Patch 2(20.000):</div>
                                            <asp:TextBox ID="txtPatchRight" runat="server" CssClass="product-customise__input" placeholder="KOHLER"></asp:TextBox>
                                        </div>
                                         <div class="product-customise__box w">
                                            <div class="product-customise__label">Font:</div>
                                            <asp:TextBox ID="txtFont" runat="server" CssClass="product-customise__input" placeholder="Manchester United 2021"></asp:TextBox>
                                        </div>
                                        <div class="product-customise__box">
                                            <div class="product-customise__label">Kiểu in:</div>
                                            <div class="select-custom">
                                                <asp:DropDownList ID="drKieuIn" runat="server" AutoPostBack="false" CssClass="custom-select-element">
                                                    <asp:ListItem Value="Decal thường">In decal thường - 45.000</asp:ListItem>
                                                    <asp:ListItem Value="Decal xịn">In decal xịn - 100.000</asp:ListItem>
                                                </asp:DropDownList>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="product-customise__price">Giá tùy chỉnh bổ sung là In + Patch1 + Patch2</div>
                                   </div>
                           </div>
                            
                            <div class="product-filters__row">
                                <asp:LinkButton ID="addCart" runat="server" CssClass="button button--submit" OnClick="addCart_Click"><div class="button__title">Thêm vào giỏ</div></asp:LinkButton>
                                <div class="button button--custom" id="js-customsie_btn"><div class="button__title">Tùy chỉnh</div></div>
                            </div>
                            
                            <div class="product-endow">
                                <div class="endow-content">
                                     <div class="endow_item">
                                        <div class="endow-text">Ưu đãi dành cho khách hàng:</div>
                                    </div>
                                    <div class="endow_item">
                                        <span class="endow-icon"><img src="/images/product/shipping-fast-solid.svg" alt="shipping"></span>
                                        <div class="endow-text">Free ship từ 2 bộ trở lên.</div>
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
                            <span class="product-look_title--text">Áo bóng đá mới</span>
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