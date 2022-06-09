<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="delClubs.aspx.cs" Inherits="nguyeensport.Display.Unitl.account.clubs.delClubs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset='utf-8' />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <meta http-equiv='X-UA-Compatible' content='IE=edge' />
    <title><asp:Literal ID="ltTitle" runat="server"></asp:Literal> | NGUYEENSPORT</title>
    <meta name='viewport' content='width=device-width, initial-scale=1' />
    <meta name="keywords" content="nguyeensport, nguyen sport, nguyeensport.com, NGUYEEN SPORT, NGUYEENSPORT" />
    <meta name="description" content="Chào mừng bạn đã đến với cửa hàng bóng đá trực tuyến! Nhận các sản phẩm bóng đá mới của bạn từ nguyeensport.com - giao hàng trên toàn quốc và giá tốt" />

    <link rel="shortcut icon" href="/images/common/NGUYEEN.svg" type="image/x-icon" />
    <link rel='stylesheet' type='text/css' media='screen' href='/common/css/resert.css' />
    <link rel="stylesheet" type="text/css" media="screen" href="/common/css/common.css" />
    <link rel="stylesheet" href="/common/css/slideout-basket.css" media="screen" type="text/css" />
    <link rel="stylesheet" type="text/css" media="screen" href="/common/css/main.css" />
    <link rel="stylesheet" type="text/css" media="screen" href="/common/css/my-clubs-kits.css" />
</head>
<body>
    <form id="form1" runat="server">
        <asp:PlaceHolder ID="loadheader" runat="server"></asp:PlaceHolder>
        <asp:PlaceHolder ID="loadMenuList1" runat="server"></asp:PlaceHolder>
        <asp:PlaceHolder ID="loadMenuList2" runat="server"></asp:PlaceHolder>
        <asp:PlaceHolder ID="loadSearch" runat="server"></asp:PlaceHolder>
        <asp:PlaceHolder ID="loadGioHang" runat="server"></asp:PlaceHolder>
        <div class="main">
        <div class="container-inner">
            <div class="my-club-kits">
                <div class="club-members__header">
                    <h3 class="club-members__title"><asp:Literal ID="ltHeaderTitle" runat="server"></asp:Literal></h3>
                    <h4 class="club-members__role">Tài khoản quản trị</h4>
                </div>
                <ul class="base-accordion__list">
                    <li class="base-accordion__item">
                        <hr class="base-accordion__horizontal-line" />
                        <div class="base-accordion__expander">
                            <span class="base-accordion__expander-name">HOME</span>
                            <span class="base-accordion__expander-state">Hiện thị chi tiết</span>
                        </div>
                        <div>
                            <ul class="kit-line js-show">
                                <li class="kit-line__list-item">
                                    <div class="kit-line__product-wrapper">
                                        <div class="kit-line__image-wrapper">
                                            <img src="/images/top/img09.png" alt="" class="kit-line__image" />
                                            <img src="/images/common/NGUYEEN.svg" alt="" class="kit-line__logo-image" />
                                        </div>
                                        <div class="kit-line__details">
                                            <span class="kit-line__item-name">adidas Entrada 18</span>
                                            <div class="kit-line__buttons">
                                                <button class="button button--submit button--submit">
                                                    <div class="button__title">Xem ngay</div>
                                                </button>
                                                <button class="button button--white-with-border ">
                                                    <div class="button__title">Sửa</div>
                                                </button>
                                            </div>
                                            <a class="kit-line__customisation-link">Hiển thị tùy chỉnh</a>
                                        </div>
                                        <div class="kit-line__customisation-wrapper">
                                            <h2 class="kit-line__customisation-title">Tùy chọn tùy chỉnh của bạn</h2>
                                            <table class="kit-line__customisation-table">
                                                <colgroup>
                                                    <col class="kit-line__table-column--first" span="1" />
                                                </colgroup>
                                                <thead>
                                                    <tr>
                                                        <th>Mục</th>
                                                        <th>Vị trí</th>
                                                        <th>Màu/Hình dạng/Hình ảnh</th>
                                                        <th>Kiểu in</th>
                                                        <th>Giá</th>
                                                    </tr>
                                                </thead>
                                                <tbody>
                                                    <tr>
                                                        <td>
                                                            <p class="kit-line__customisation-table-name">Logo</p>
                                                        </td>
                                                        <td>Trái</td>
                                                        <td></td>
                                                        <td>In chuyển nhiệt</td>
                                                        <td>50.000 VNĐ</td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <p class="kit-line__customisation-table-name">Tên cầu thủ</p>
                                                        </td>
                                                        <td>Trên</td>
                                                        <td>Trắng</td>
                                                        <td>In chuyển nhiệt</td>
                                                        <td>50.000 VNĐ</td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <p class="kit-line__customisation-table-name">Nhà tài trợ</p>
                                                        </td>
                                                        <td>Giữa</td>
                                                        <td></td>
                                                        <td>In chuyển nhiệt</td>
                                                        <td>50.000 VNĐ</td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <p class="kit-line__customisation-table-name">Số</p>
                                                        </td>
                                                        <td>Giữa</td>
                                                        <td>Trắng</td>
                                                        <td>In chuyển nhiệt</td>
                                                        <td>50.000 VNĐ</td>
                                                    </tr>
                                                </tbody>
                                                <tfoot>
                                                    <tr>
                                                        <td></td>
                                                        <td></td>
                                                        <td></td>
                                                        <td class="kit-line__total-price">Tổng cộng:</td>
                                                        <td>100.000 VNĐ</td>
                                                    </tr>
                                                </tfoot>
                                            </table>
                                        </div>
                                    </div>
                                </li>
                            </ul>
                            <hr class="base-accordion__horizontal-line" />
                        </div>
                    </li>
                    
                </ul>
            </div>
        </div>
    </div>
        <asp:PlaceHolder ID="loadfooter" runat="server"></asp:PlaceHolder>
    </form>
    <!-- TrustBox script -->
    <script type="text/javascript" src="//widget.trustpilot.com/bootstrap/v5/tp.widget.bootstrap.min.js" async></script>
    <!-- End TrustBox script -->
    <script src="/common/js/jquery.js"></script>
    <script src="/common/js/common.js"></script>
    <script src="/common/js/menu.js"></script>
    <script>
            var btn = document.querySelector('.kit-line__customisation-link');
            var content = document.querySelector('.kit-line__customisation-wrapper');
            btn.addEventListener('click', function()
            {
                if(content.style.display == 'block'){
                    content.style.display = "none";
                }
                else{
                    content.style.display = 'block';
                }
            });

            var btnshow = document.querySelector('.base-accordion__expander-state');
            var content1 = document.querySelector('.js-show');
            btnshow.addEventListener('click', function(){
                if(content1.style.display == "block"){
                    content1.style.display = "none";
                }
                else{
                    content1.style.display = "block";
                }
            })
    </script>
</body>
</html>
