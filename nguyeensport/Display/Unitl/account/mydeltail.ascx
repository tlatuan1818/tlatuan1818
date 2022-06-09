<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="mydeltail.ascx.cs" Inherits="nguyeensport.Display.Unitl.account.mydeltail" %>
<div class="main">
        <div class="banner-account">
            <div class="banner-center">
                <div class="banner__main">
                    <img src="/images/unitl/my-account01.png" alt="Tài khoản của tôi" class="img768" />
                </div>
                <div class="banner--content">
                    <h2 class="banner-title">Tài khoản của tôi</h2>
                </div>
                <div class="banner-menu">
                    <div class="banner-menu__wrapper">
                        <div class="banner-menu__item banner-menu__item--active swiper-slide-active">
                            <a href="/my-account/thong-tin-cua-toi" class="banner-menu__link">Thông tin của tôi</a>
                        </div>       
                        <div class="banner-menu__item">
                            <a href="/my-account/cau-lac-bo-cua-toi" class="banner-menu__link">Câu lạc bộ của tôi</a>
                        </div>
                        <div class="banner-menu__item">
                            <a href="/my-account/lich-su-mua-hang" class="banner-menu__link">Lịch sử mua hàng</a>
                        </div>
                        <div class="banner-menu__item">
                            <a href="/my-account/so-thich-cua-toi" class="banner-menu__link">Sở thích của tôi</a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="account-container">
            <div class="my-account-block">
                <div>
                    <h2 class="my-account-block__title">Thông tin của tôi</h2>
                    <p class="my-account-block__description">Vui lòng nhập hoặc cập nhật thông tin chi tiết của bạn bên dưới</p>
                </div>
                <hr class="horizontal-rule">
            </div>
            <div class="account-details-form validator">
                <div class="form-item input-group">
                    <label class="input-validation-wrapper">
                        <span class="input-name required">Họ và tên:</span>
                        <asp:TextBox ID="txtFullname" runat="server" CssClass="custem-text-field required"></asp:TextBox>
                        
                    </label>
                </div>
               
                
                <div class="form-item input-group">
                    <label class="input-validation-wrapper">
                        <span class="input-name required">Email:</span>
                        <asp:TextBox ID="txtEmail" runat="server" CssClass="custem-text-field required"></asp:TextBox>
                    </label>
                </div>
                <div class="form-item input-group">
                    <label class="input-validation-wrapper">
                        <span class="input-name required">Địa chỉ:</span>
                        <asp:TextBox ID="txtDiaChi" runat="server" CssClass="custem-text-field required"></asp:TextBox>
                    </label>
                </div>
                <div class="account-details-form__raw">
                    <div class="form-item input-group">
                        <div class="input-validation-wrapper">
                            <span class="input-name">Số điện thoại:</span>
                            <asp:TextBox ID="txtSDT" runat="server" CssClass="custem-text-field required"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-item input-group">
                        <div class="input-validation-wrapper">
                            <span class="input-name">Ngày sinh:</span>
                           <asp:TextBox ID="txtNgaySinh" runat="server" CssClass="custem-text-field required"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-item input-group">
                        <div class="input-validation-wrapper">
                            <span class="input-name">Giới tính:</span>
                            <asp:TextBox ID="txtGioiTinh" runat="server" CssClass="custem-text-field required"></asp:TextBox>
                        </div>
                    </div>
                </div>
             
                    <asp:LinkButton ID="btnLuuThongTin" runat="server" CssClass="button button--submit account-details-form__submit" OnClick="btnLuuThongTin_Click">
                        <div class="button__title">
                            Lưu thông tin
                        </div>
                    </asp:LinkButton>
                
            </div>
            <div class="my-account-change-password-container">
                <hr class="horizontal-rule horizontal-rule--desktop">
                <div class="change-password my-account-block">
                    <div>
                        <h2 class="my-account-block__title">Thay đổi mật khẩu</h2>
                        <p class="my-account-block__description">Vui lòng nhập mật khẩu hiện có và mật khẩu mới để thay đổi mật khẩu</p>
                        <hr class="horizontal-rule">
                    </div>
                </div>
                <div class="account-details-form validator change-password-form">
                    <div class="form-item input-group">
                        <label class="input-validation-wrapper">
                            <span class="input-name required">Mật khẩu hiện tại:</span>
                            <asp:TextBox ID="txtPassword" runat="server" CssClass="custem-text-field required" TextMode="Password"></asp:TextBox>
                        </label>
                    </div>
                    <div class="form-item input-group">
                        <label class="input-validation-wrapper">
                            <span class="input-name required">Mật khẩu mới:</span>
                             <asp:TextBox ID="txtPasswordMoi" runat="server" CssClass="custem-text-field required" TextMode="Password"></asp:TextBox>
                        </label>
                    </div>
                    <asp:LinkButton ID="btnLuuMatKhau" runat="server" CssClass="button button--submit account-details-form__submit" OnClick="btnLuuMatKhau_Click">
                        <div class="button__title">
                            Lưu mật khẩu
                        </div>
                    </asp:LinkButton>
                    
                </div>
            </div>
        </div>
    </div>