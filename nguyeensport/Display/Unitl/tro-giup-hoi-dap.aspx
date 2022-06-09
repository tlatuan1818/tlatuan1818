<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="tro-giup-hoi-dap.aspx.cs" Inherits="nguyeensport.Display.Unitl.tro_giup_hoi_dap" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset='utf-8' />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <meta http-equiv='X-UA-Compatible' content='IE=edge' />
    <title><asp:Literal ID="ltTitle" runat="server"></asp:Literal></title>
    <meta name='viewport' content='width=device-width, initial-scale=1' />
    <meta name="keywords" content="" />
    <meta name="description" content="" />

    <link rel="shortcut icon" href="/images/common/NGUYEEN.svg" type="image/x-icon" />
    <link rel='stylesheet' type='text/css' media='screen' href='/common/css/resert.css' />
    <link rel="stylesheet" type="text/css" media="screen" href="/common/css/common.css" /> 
    <link rel="stylesheet" href="/common/css/slideout-basket.css" media="screen" type="text/css" />
    <link rel="stylesheet" type="text/css" media="screen" href="/common/css/main.css" />
    <link rel="stylesheet" type="text/css" media="screen" href="/common/css/help.css" />
</head>
<body>
    <form id="form1" runat="server">
       <asp:PlaceHolder ID="loadheader" runat="server"></asp:PlaceHolder>
        <asp:PlaceHolder ID="loadMenuList1" runat="server"></asp:PlaceHolder>
        <asp:PlaceHolder ID="loadMenuList2" runat="server"></asp:PlaceHolder>
        <asp:PlaceHolder ID="loadSearch" runat="server"></asp:PlaceHolder>
        <asp:PlaceHolder ID="loadGioHang" runat="server"></asp:PlaceHolder>
    <div class="main">
        <asp:PlaceHolder ID="loadContent" runat="server"></asp:PlaceHolder>
        <div class="contact-us">
            <h2 class="contact-name">Liên hệ chúng tôi</h2>
            <div class="contact-box">
                <div class="contact-item">
                    <div class="form-item">
                        <label class="input-validation-wrapper">
                            <span class="input-name">Họ và tên:</span>
                            <input type="text" name="fullname" id="" class="custem-text-field" placeholder="Ví dụ: Nguyễn Văn A" />
                        </label>
                    </div>
                    <div class="form-item">
                        <label class="input-validation-wrapper">
                            <span class="input-name">Email:</span>
                            <input type="text" name="fullname" id="" class="custem-text-field" placeholder="Ví dụ: nguyeensport@gmail.com" />
                        </label>
                    </div>
                    <div class="form-item">
                        <label class="input-validation-wrapper">
                            <span class="input-name">Chủ đề:</span>
                            <input type="text" name="fullname" id="" class="custem-text-field" placeholder="Ví dụ: Đơn hàng không chính xác.." />
                        </label>
                    </div>
                    <div class="form-item">
                        <label class="input-validation-wrapper">
                            <span class="input-name">Nội dung:</span>
                            <textarea name="fullname" id="" class="custem-textarea-field"></textarea>
                        </label>
                    </div>
                    <button class="contact-btn">
                        <div class="button-title">Gửi tin nhắn</div>
                    </button>
                </div>
                <div class="contact-item">
                    <a href="/" class="contact-logo"><figure><img src="/images/common/NGUYEEN.svg" alt="nguyeensport" /></figure></a>
                    <div class="contact-wrapper">
                        <div class="contact-content">
                            <div class="contact-content_name">Giờ mở cửa</div>
                            <p class="contact-time"><stong>Thứ 2: </stong> 9H:00 - 17H00</p>
                            <p class="contact-time"><stong>Thứ 3: </stong> 9H:00 - 17H00</p>
                            <p class="contact-time"><stong>Thứ 4: </stong> 9H:00 - 17H00</p>
                            <p class="contact-time"><stong>Thứ 5: </stong> 9H:00 - 17H00</p>
                            <p class="contact-time"><stong>Thứ 6: </stong> 9H:00 - 17H00</p>
                            <p class="contact-time"><stong>Thứ 7: </stong> 13H:00 - 17H00</p>
                            <p class="contact-time"><stong>Chủ nhật: </stong> 13H:00 - 17H00</p>
                        </div>
                        <div class="contact-content">
                            <iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d539.4905663799584!2d106.67790599765517!3d10.749783533456714!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x0%3A0x420044315b993aad!2sNGUYEENSPORT!5e0!3m2!1svi!2s!4v1609262642283!5m2!1svi!2s"  frameborder="0" style="border:0;" allowfullscreen="" aria-hidden="false" tabindex="0"></iframe>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <asp:PlaceHolder ID="loadfooter" runat="server"></asp:PlaceHolder>
    <!-- TrustBox script -->
        <script type="text/javascript" src="//widget.trustpilot.com/bootstrap/v5/tp.widget.bootstrap.min.js" async></script>
    <!-- End TrustBox script -->
    <script src="/common/js/jquery.js"></script>
    <script src="/common/js/common.js"></script>
    <script src="/common/js/menu.js" ></script>
    <script>
        $("#openform").click(function () {
            $("#js-formaccount").slideToggle();
        });
        $("#openform1").click(function () {
            $("#js-formaccount").slideToggle();
        });
        var show = document.getElementById("show");
        var hidden = document.getElementById("hidden");
        show.style.display = "block";
        hidden.style.display = "none";
        function showhide() {
            if (show.style.display == "block") {
                hidden.style.display = "block";
                show.style.display = "none";
                hidden.style.transitionDelay = "5s";
                show.style.transitionDelay = "5s";
            }
            else {
                hidden.style.display = "none";
                show.style.display = "block";
                hidden.style.transitionDelay = "5s";
                show.style.transitionDelay = "5s";
            }
        }
        var show1 = document.getElementById("show1");
        var hidden1 = document.getElementById("hidden1");
        show1.style.display = "block";
        hidden1.style.display = "none";
        function showhide1() {
            if (show1.style.display == "block") {
                hidden1.style.display = "block";
                show1.style.display = "none";
                hidden1.style.transitionDelay = "5s";
                show1.style.transitionDelay = "5s";
            }
            else {
                hidden1.style.display = "none";
                show1.style.display = "block";
                hidden1.style.transitionDelay = "5s";
                show1.style.transitionDelay = "5s";
            }
        }
        var show2 = document.getElementById("show2");
        var hidden2 = document.getElementById("hidden2");
        show2.style.display = "block";
        hidden2.style.display = "none";
        function showhide2() {
            if (show2.style.display == "block") {
                hidden2.style.display = "block";
                show2.style.display = "none";
                hidden2.style.transitionDelay = "5s";
                show2.style.transitionDelay = "5s";
            }
            else {
                hidden2.style.display = "none";
                show2.style.display = "block";
                hidden2.style.transitionDelay = "5s";
                show2.style.transitionDelay = "5s";
            }
        }
    </script>
    </form>
</body>
</html>
