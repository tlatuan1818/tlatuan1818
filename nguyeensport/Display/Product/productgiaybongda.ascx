<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="productgiaybongda.ascx.cs" Inherits="nguyeensport.Display.Product.productgiaybongda" %>
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
                                    <div class="action-dropdown__wrapper">
                                        <asp:Literal ID="ltDinh" runat="server"></asp:Literal>
                                    </div>
                                </div>
                                <div class="action-dropdown action-dropdown--full-view">
                                        <asp:Literal ID="ltSize38" runat="server"></asp:Literal>
                                        <asp:Literal ID="ltSize39" runat="server"></asp:Literal>
                                        <asp:Literal ID="ltSize40" runat="server"></asp:Literal>
                                        <asp:Literal ID="ltSize41" runat="server"></asp:Literal>
                                        <asp:Literal ID="ltSize42" runat="server"></asp:Literal>
                                        <asp:Literal ID="ltSize43" runat="server"></asp:Literal>
                                        <asp:Literal ID="ltSize44" runat="server"></asp:Literal>
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
                                <asp:LinkButton ID="addCart" runat="server" CssClass="button button--submit" OnClick="addCart_Click"><div class="button__title">Thêm vào giỏ</div></asp:LinkButton>
                            </div>
                            <div class="product-endow">
                                <div class="endow-content">
                                    <div class="endow_item">
                                        <span class="endow-icon"><img src="/images/product/box-solid.svg" alt="box"></span>
                                        <div class="endow-text">Hộp Fullbox.</div>
                                    </div>
                                    <div class="endow_item">
                                        <span class="endow-icon"><img src="/images/product/gift-solid.svg" alt="gift"></span>
                                        <div class="endow-text">Tặng vớ dệt kim theo thương hiệu.</div>
                                    </div>
                                    <div class="endow_item">
                                        <span class="endow-icon"><img src="/images/product/shipping-fast-solid.svg" alt="shipping"></span>
                                        <div class="endow-text">Free ship nội thành (ngoại thành hộ trợ 50% phí ship).</div>
                                    </div>
                                    <div class="endow_item">
                                        <span class="endow-icon"><img src="/images/product/sync-alt-solid.svg" alt="sync-alt"></span>
                                        <div class="endow-text">Đổi trả trong 7 ngày.</div>
                                    </div>
                                    <div class="endow_item">
                                        <span class="endow-icon"><img src="/images/product/ribbon.svg" alt="guarantee"></span>
                                        <div class="endow-text">Bảo hành keo và khâu đế miễn phí.</div>
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
                        <li class="accordion__item">
                            <div class="accordion__title" id="btnclick3">Các loại mặt sân</div>
                            <div class="accordion__content" id="content-three">
                               <div class="accordion__content-img">
                                   <div class="content-img_box js-img-active">
                                        <img src="/images/product/fg.png" alt="FG" class="thumbnail__image">
                                        <p class="content-img_title">FG</p>
                                    </div>
                                    <div class="content-img_box">
                                        <img src="/images/product/sg.png" alt="SG" class="thumbnail__image">
                                        <p class="content-img_title">SG</p>
                                    </div>
                                    <div class="content-img_box">
                                        <img src="/images/product/ag.png" alt="AG" class="thumbnail__image">
                                        <p class="content-img_title">AG</p>
                                    </div>
                                    <div class="content-img_box">
                                        <img src="/images/product/tf.png" alt="TF" class="thumbnail__image">
                                        <p class="content-img_title">TF</p>
                                    </div>
                                    <div class="content-img_box">
                                        <img src="/images/product/st.png" alt="ST" class="thumbnail__image">
                                        <p class="content-img_title">ST</p>
                                    </div>
                                    <div class="content-img_box">
                                        <img src="/images/product/in.png" alt="IN" class="thumbnail__image">
                                        <p class="content-img_title">IN</p>
                                    </div>
                               </div>
                               <ul class="carousel-content">
                                   <li class="carousel-content__item carousel-content__item--active">
                                        <div class="ground-type-guide__title ">Firm Ground</div>
                                        <div class="ground-type-guide__description">Giày có mặt đế cứng được sử dụng trên các bề mặt cỏ ngắn tự nhiên, bề mặt chắc chắn hơi ướt. Được thiết kế đặc biệt cho bề mặt chơi này, chúng mang lại khả năng tăng tốc, thoải mái và tăng cường lực kéo, phân tán lực đinh tán đều trên bàn chân. Mặt đế FG được cố định (không thể tháo rời) và được sử dụng trên toàn thế giới, các nước ẩm ướt hơn có xu hướng sử dụng chúng từ mùa xuân đến mùa thu. Giày bóng đá FG không được sử dụng trên bề mặt đất nhân tạo (AG) vì mắt sân không được thiết kế cho ma sát lớn hơn. Giày FG được sử dụng trên bề mặt AG sẽ làm mất hiệu lực bảo hành của nhà sản xuất. </div>
                                        <div class="ground-type-guide__preview"><img src="/images/product/fg.png" alt="FG"></div>
                                   </li>
                                    <li class="carousel-content__item">
                                        <div class="ground-type-guide__title">Soft Ground</div>
                                        <div class="ground-type-guide__description">Mặt đế Soft Ground (SG) được thiết kế đặc biệt để sử dụng trên sân cỏ tự nhiên ẩm ướt và từ mềm đến rất mềm cũng có thể bị bùn hoặc úng nước. Được sử dụng trên toàn thế giới, chủ yếu trong những tháng mùa đông, giày làm cho nền đất yếu có đinh vít có thể tháo rời, thay thế được, có thể bằng nhựa, hoàn toàn bằng kim loại hoặc có đầu kim loại và thường có cấu hình sáu đinh (4 đinh ở chân trước, 2 đinh dài hơn một chút ở gót chân). Các đinh vít vào phải được kiểm tra và siết chặt trước khi sử dụng vì trong quá trình sản xuất chúng được lắp vào giày và có thể bị lỏng. </div>
                                        <div class="ground-type-guide__preview"><img src="/images/product/sg.png" alt="SG"></div>
                                    </li>
                                    <li class="carousel-content__item">
                                        <div class="ground-type-guide__title">Artificial Grass</div>
                                        <div class="ground-type-guide__description">Bề mặt Cỏ nhân tạo (còn được gọi là bề mặt trong mọi thời tiết) thường bao gồm 3G (vụn cao su) hoặc 4G (cọc dài hơn, kết hợp giữa cao su / cát chèn, gần giống với cỏ thực tế hơn). Cỏ nhân tạo thế hệ thứ năm vẫn chưa được sử dụng rộng rãi. Giày bóng đá làm cho mặt sân cỏ nhân tạo này được thiết kế đặc biệt, thường có ít nylon hơn để tăng độ bền chống mài mòn thêm liên quan đến cỏ tổng hợp và có nhiều đinh tán dày đặc hơn. Chúng cũng có thể thay đổi chiều cao để cải thiện lực kéo và hoặc làm rỗng để giảm trọng lượng và tăng cường đệm. Giày đinh AG cũng có thể được sử dụng trên nền đất chắc chắn (FG), mặc dù hiệu suất sẽ phụ thuộc vào độ khô và chắc của mặt sân.</div>
                                        <div class="ground-type-guide__preview"><img src="/images/product/ag.png" alt="AG"></div>
                                    </li>
                                    <li class="carousel-content__item">
                                        <div class="ground-type-guide__title">Turf</div>
                                        <div class="ground-type-guide__description">Turf (còn gọi là Astro Turf) là một loại bề mặt cỏ tổng hợp cũ hơn bao gồm cát hoặc thảm nước thường được trải trên bê tông. Sau đó là bề mặt cứng hơn và nhanh hơn, Giày để sử dụng trên sân cỏ (TF) thường có đế giữa có đệm và đế ngoài bằng cao su rất bền, phẳng, nhiều vấu hoặc lõm vì sân cỏ yêu cầu độ xuyên thấu nhẹ. Do tính chất cứng của bề mặt và độ ma sát mà nó tạo ra, không nên sử dụng loại đế ngoài nào khác trên sân cỏ và sẽ dẫn đến mài mòn đáng kể đối với các đinh tán và mép mặt đế và có thể gây thương tích. </div>
                                        <div class="ground-type-guide__preview"><img src="/images/product/tf.png" alt="TF"></div>
                                    </li>
                                    <li class="carousel-content__item">
                                        <div class="ground-type-guide__title">Street</div>
                                        <div class="ground-type-guide__description">Mặt sân đường phố thường mô tả cao độ hoặc bề mặt thường thấy trong các khu dân cư nội thành. Chúng bao gồm các bề mặt cứng khác nhau như đường băng, khu vực sân cứng lát đá hoặc bê tông và thường được chứa trong một 'lồng' được làm bằng thép hoặc lưới thép. Giày để chơi trên sân Street (ST) sẽ có đế ngoài làm bằng cao su cứng hơn với kiểu kéo nhiều rãnh tương tự như giày sân cỏ. Chúng cũng thường có đệm giữa để hấp thụ va chạm và thoải mái và được trang bị các miếng đệm ngón chân cao su mở rộng để đối phó với va chạm.</div>
                                        <div class="ground-type-guide__preview"><img src="/images/product/st.png" alt="ST"></div>
                                    </li>
                                    <li class="carousel-content__item">
                                        <div class="ground-type-guide__title">Indoor</div>
                                        <div class="ground-type-guide__description">Các bề mặt trong nhà dành cho các trò chơi có mặt nhỏ như 5 người một bên và Futsal thường bằng phẳng, cực kỳ cứng và không có rãnh và thường bao gồm gỗ đánh vecni, vải sơn hoặc vật liệu tổng hợp hoặc composite nhẵn, được sơn. Đối với độ bám, các bề mặt ngoài trong nhà (IN) thường phẳng để tối đa hóa tiếp xúc với mặt đất và bề ngoài bóng bẩy với kiểu kéo hoặc rãnh tối thiểu, không xâm thực để uốn cong và tản nhiệt bề mặt. Chúng thường sử dụng cao su gôm đúc không đánh dấu và thường có đệm ở giữa để hấp thụ va chạm và thoải mái. Không thể sử dụng giày đi trong nhà trên các bề mặt đường phố mài mòn như bê tông hoặc sỏi vì chúng sẽ nhanh bị mòn.</div>
                                        <div class="ground-type-guide__preview"><img src="/images/product/in.png" alt="IN"></div>
                                    </li>
                               </ul>
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
                            <span class="product-look_title--text">Giày bóng đá mới</span>
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