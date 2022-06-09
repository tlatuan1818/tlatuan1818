<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DanhSachTinTuc.aspx.cs" Inherits="nguyeensport.Display.TinTuc.DanhSachTinTuc" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <meta http-equiv='X-UA-Compatible' content='IE=edge' />
    
    <meta name='viewport' content='width=device-width, initial-scale=1' />
    <meta name="keywords" content="football, boots, news, videos, equipment, apparel, goalkeeper, gloves, adidas, nike, puma, umbro, mizuno, pantofola doro, under, armour, warrior, lotto, joma, hummel, pele, uhlsport, concave, cruyff, penalty, asics" />
    <meta name="description" content="" />

    <title><asp:Literal ID="ltTitle" runat="server"></asp:Literal></title>
    
    <link rel="shortcut icon" href="~/images/common/NGUYEEN.svg" type="image/x-icon" />
    
    <link href="~/common/css/resert.css" rel="stylesheet" />
    <link href="~/common/css/tintuc.css" rel="stylesheet" />
    
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
    <script src="https://ajax.aspnetcdn.com/ajax/jQuery/jquery-3.2.1.min.js"></script>
   
</head>
<body>
    <form id="form1" runat="server">
        <nav id="navigation">
            <div id="mobile-search">
                <div class="icon">
                    <svg version="1.1" xmlns="http://www.w3.org/2000/svg" xmlns:xlink="http://www.w3.org/1999/xlink" x="0px" y="0px" viewBox="0 0 200 200" style="enable-background:new 0 0 200 200;" xml:space="preserve">
                        <path style="fill: #fff;" d="M100,10c49.6,0,90,40.4,90,90s-40.4,90-90,90s-90-40.4-90-90S50.4,10,100,10 M100,0C44.8,0,0,44.8,0,100s44.8,100,100,100
                                        s100-44.8,100-100S155.2,0,100,0L100,0z" />
                        <circle style="fill: none; stroke: #fff; stroke-width: 10; stroke-miterlimit: 10;" cx="82.2" cy="84.7" r="32.8" />
                        <line style="fill: none; stroke: #fff; stroke-width: 10; stroke-linecap: round; stroke-miterlimit: 10;" x1="105.1" y1="108.7" x2="138.6" y2="142.1" />
                    </svg>
                </div>
                 <input type="text" name="" placeholder="Bạn tìm gì hôm nay ?" />
            </div>
            <div class="nav-wrap">
                    <ul>
                        <li id="store-link-mobile"><a href="/" target="_blank">Cửa hàng</a></li>
                        <li id="click1" class="current has-children" >
                            <a >Bóng đá</a>
                            <ul id="js-click">
                                <li>
                                    <a href="/tin-tuc/giay-bong-da">Giày bóng đá</a>
                                </li>
                                <li>
                                    <a href="/tin-tuc/ao-bong-da">Áo bóng đá</a>
                                </li>
                                
                            </ul>
                        </li>
                        <li class="has-children" id="click2" >
                             <a>Giải đấu</a>
                            <ul id="js-click2">
                                 <li>
                                    <a href="/tin-tuc/premier-league">Premier League</a>
                                </li>
                                <li>
                                    <a href="/tin-tuc/la-liga">La Liga</a>
                                </li>
                                <li>
                                    <a href="/tin-tuc/bundesliga">Bundesliga</a>
                                </li>
                                <li>
                                    <a href="/tin-tuc/ligue-1">Ligue 1</a>
                                </li>
                                <li>
                                    <a href="/tin-tuc/ligue-1">Serie A</a>
                                </li>
                            </ul>
                        </li>
                         <li class="has-children" id="click3">
                            <a href="#">Thiết kế</a>
                            <ul id="js-click3">
                                <li>
                                    <a href="/tin-tuc/san-pham-thiet-ke/">Sản phẩm thiết kế</a>
                                </li>
                                <li>
                                    <a href="/tin-tuc/y-tuong-thiet-ke/">Ý thưởng thiết kế</a>
                                </li>
                            </ul>
                        </li>
                        <li>
                            <a href="/tin-tuc/boot-spotting/">Boot Spotting</a>
                        </li>
                    </ul>
                    <div class="nav-bottom">
                        <div class="information-pages">
                                    <a href="/information/about/">About</a>
                                    <a href="/information/contact/">Contact</a>
                                    <a href="/information/privacy-policy/">Privacy Policy</a>
                                    <a href="/information/terms-and-conditions/">Terms and Conditions</a>

                        </div>
                        <div class="social">
                            <a href="https://www.instagram.com/soccerbible/" title="Instagram" class="icon-social" target="_blank">
                                 <svg id="Layer_1" data-name="Layer 1" xmlns="http://www.w3.org/2000/svg" viewBox="0 0 31 31">
                                        <defs>
                                            <style>
                                                .cls-1 {
                                                    fill: #fff;
                                                }
                                            </style>
                                        </defs><circle class="cls-1" cx="15.5" cy="15.52" r="15" /><path d="M15.5,9.07c2.1,0,2.35,0,3.18,0a4.36,4.36,0,0,1,1.46.27,2.65,2.65,0,0,1,.91.59,2.39,2.39,0,0,1,.59.91,4.12,4.12,0,0,1,.27,1.46c0,.83.05,1.08.05,3.18s0,2.36-.05,3.19a4.23,4.23,0,0,1-.27,1.46,2.28,2.28,0,0,1-.59.9,2.39,2.39,0,0,1-.91.59,4.12,4.12,0,0,1-1.46.27c-.83,0-1.08.05-3.18.05s-2.35,0-3.18-.05a4.24,4.24,0,0,1-1.47-.27,2.35,2.35,0,0,1-.9-.59,2.28,2.28,0,0,1-.59-.9,4.23,4.23,0,0,1-.27-1.46c0-.83-.05-1.08-.05-3.19s0-2.35.05-3.18a4.12,4.12,0,0,1,.27-1.46A2.39,2.39,0,0,1,10,10a2.61,2.61,0,0,1,.9-.59,4.5,4.5,0,0,1,1.47-.27c.83,0,1.08,0,3.18,0m0-1.42c-2.14,0-2.41,0-3.25,0a5.65,5.65,0,0,0-1.91.37A3.84,3.84,0,0,0,8.94,9,4,4,0,0,0,8,10.36a5.72,5.72,0,0,0-.37,1.92c0,.84,0,1.1,0,3.24s0,2.41,0,3.25A5.65,5.65,0,0,0,8,20.68,4,4,0,0,0,10.34,23a5.94,5.94,0,0,0,1.91.36c.84,0,1.11,0,3.25,0s2.41,0,3.25,0A6,6,0,0,0,20.66,23,4,4,0,0,0,23,20.68a5.65,5.65,0,0,0,.37-1.91c0-.84.05-1.11.05-3.25s0-2.4-.05-3.24A5.72,5.72,0,0,0,23,10.36,3.89,3.89,0,0,0,22.05,9a3.72,3.72,0,0,0-1.39-.91,5.71,5.71,0,0,0-1.91-.37c-.84,0-1.11,0-3.25,0Z" /><path d="M15.5,11.48a4,4,0,1,0,4,4A4,4,0,0,0,15.5,11.48Zm0,6.67a2.63,2.63,0,1,1,2.62-2.63A2.63,2.63,0,0,1,15.5,18.15Z" /><circle cx="19.7" cy="11.32" r="0.95" /></svg>
                                
                            </a>
                            <a href="https://twitter.com/SoccerBible" title="Twitter" class="icon-social" target="_blank">
                                <svg id="Layer_1" data-name="Layer 1" xmlns="http://www.w3.org/2000/svg" viewBox="0 0 31 31">
                                        <defs>
                                            <style>
                                                .cls-1 {
                                                    fill: #fff;
                                                }
                                            </style>
                                        </defs><circle class="cls-1" cx="15.5" cy="15.55" r="15" /><g id="Logo_FIXED" data-name="Logo — FIXED"><path d="M12.58,21.93a9.11,9.11,0,0,0,9.17-9.17c0-.14,0-.28,0-.41a6.59,6.59,0,0,0,1.61-1.68,6.42,6.42,0,0,1-1.85.51A3.27,3.27,0,0,0,22.92,9.4a6.6,6.6,0,0,1-2.05.78,3.23,3.23,0,0,0-5.58,2.2,3.57,3.57,0,0,0,.08.74A9.15,9.15,0,0,1,8.73,9.75a3.19,3.19,0,0,0-.43,1.62,3.24,3.24,0,0,0,1.43,2.69,3.29,3.29,0,0,1-1.46-.41v0a3.23,3.23,0,0,0,2.59,3.16A3.41,3.41,0,0,1,10,17a4.07,4.07,0,0,1-.61,0,3.22,3.22,0,0,0,3,2.23,6.43,6.43,0,0,1-4,1.39,6.64,6.64,0,0,1-.77-.05,9.14,9.14,0,0,0,4.94,1.44" /></g></svg>
                                
                            </a>
                            <a href="https://www.facebook.com/NGUYEENSPORT" title="Facebook" class="icon-social " target="_blank"> <svg id="Layer_1" data-name="Layer 1" xmlns="http://www.w3.org/2000/svg" viewBox="0 0 31 31">
                                        <defs>
                                            <style>
                                                .cls-1 {
                                                    fill: #fff;
                                                }
                                            </style>
                                        </defs><circle class="cls-1" cx="15.47" cy="15.51" r="15" /><path d="M16.66,23.2v-7H19l.36-2.75H16.66V11.69c0-.79.22-1.33,1.35-1.33h1.45V7.92a18.52,18.52,0,0,0-2.11-.1,3.29,3.29,0,0,0-3.52,3.61v2H11.47v2.74h2.36v7Z" /></svg></a>
                        </div>
                        <div id="google_translate_element"></div>
                        <script type="text/javascript">
                            function googleTranslateElementInit() {
                                new google.translate.TranslateElement({ pageLanguage: 'en', layout: google.translate.TranslateElement.InlineLayout.HORIZONTAL, autoDisplay: false }, 'google_translate_element');
                            }
                        </script>
                        <script async type="text/javascript" src="//translate.google.com/translate_a/element.js?cb=googleTranslateElementInit"></script>
                    </div>
             </div>

        </nav>
       
        <div id="content">
            <header>
                <a id="navigation-button">
                    <span></span>
                    <span></span>
                    <span></span>
                </a>
                <asp:Literal ID="ltheaderCategory" runat="server"></asp:Literal>
                
                <a id="logo" href="/"><img src="/images/common/logo-nguyeensport.svg" /></a>
                <div class="header-right">
                    <div id="header-search" class="hidden-xs hidden-sm">
                        <a class="open-search" href="#" id="search-open">
                            <svg version="1.1" xmlns="http://www.w3.org/2000/svg" xmlns:xlink="http://www.w3.org/1999/xlink" x="0px" y="0px" viewBox="0 0 200 200" style="enable-background: new 0 0 200 200;" xml:space="preserve">
                                <path style="fill: #fff;" d="M100,10c49.6,0,90,40.4,90,90s-40.4,90-90,90s-90-40.4-90-90S50.4,10,100,10 M100,0C44.8,0,0,44.8,0,100s44.8,100,100,100
                                        s100-44.8,100-100S155.2,0,100,0L100,0z" />
                                <circle style="fill: none; stroke: #fff; stroke-width: 10; stroke-miterlimit: 10;" cx="82.2" cy="84.7" r="32.8" />
                                <line style="fill: none; stroke: #fff; stroke-width: 10; stroke-linecap: round; stroke-miterlimit: 10;" x1="105.1" y1="108.7" x2="138.6" y2="142.1" />
                            </svg>
                        </a>

                        <input type="text" placeholder="Bạn tìm tin tức nào hôm nay ?" />

                        <a href="#" id="search-close">
                            <span></span>
                            <span></span>
                        </a>
                    </div>
                    <a href="/" target="_blank" id="store-link">Cửa hàng</a>
                </div>
            </header>
            <div class="clearfix">

            </div>
            <div id="masonry-container">
                <asp:Repeater ID="rptContent" runat="server">
                    <ItemTemplate>
                        <a href="/tin-tuc/<%#: Eval("linkNews")+ "/" +Eval("linkNewsDeltail") %>" class="link-item">
                            <img src="<%#: Eval("avatarNewsDeltail") %>" alt="<%#: Eval("tenNewsDeltail") %>"/>
                            <div class="item-text">
                                <h2><%#: Eval("tenNewsDeltail") %></h2>
                                <p class="info"><%#: Eval("tenNews") %> | <span><%#:DateTime.Parse(Eval("NgayTao").ToString()).ToString("dd/MM/yyyy hh:mm tt") %></span></p>
                            </div>
                        </a>
                
                    </ItemTemplate>
                </asp:Repeater>   
            </div>
            
            <footer>
            <div id="newsletter-signup">   
                <input id="email" type="text"  name="Email" placeholder="Email Address" />
                <input type="submit" class="button button-black" value="SUBSCRIBE" />
            </div>
        </footer>
        </div>
        
    </form>
    
    <script type="text/javascript">
        $(document).ready(function () {
            $('#navigation-button').click(function () {
                $('body').toggleClass('nav-open');
            });
            $('#click1').click(function () {
                $("#click1").toggleClass("open");
                $("#js-click").slideToggle();
            });
            $("#click2").click(function () {
                $("#click2").toggleClass("open");
                $("#js-click2").slideToggle();
            });
            $("#click3").click(function () {
                $("#click3").toggleClass("open");
                $("#js-click3").slideToggle();
            });
            $("#search-open").click(function () {
                $("#header-search").addClass("open");
            });
            $("#search-close").click(function () {
                $("#header-search").removeClass("open");
            });
        });
    </script>
</body>
</html>
