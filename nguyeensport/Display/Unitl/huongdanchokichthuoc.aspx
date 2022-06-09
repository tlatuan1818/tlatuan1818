<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="huongdanchokichthuoc.aspx.cs" Inherits="nguyeensport.Display.Unitl.huongdanchokichthuoc" %>

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
    <link rel="stylesheet" type="text/css" media="screen" href="/common/css/size-guide.css" />
</head>
<body>
    <form id="form1" runat="server">
        <asp:PlaceHolder ID="loadheader" runat="server"></asp:PlaceHolder>
        <asp:PlaceHolder ID="loadMenuList1" runat="server"></asp:PlaceHolder>
        <asp:PlaceHolder ID="loadMenuList2" runat="server"></asp:PlaceHolder>
        <asp:PlaceHolder ID="loadSearch" runat="server"></asp:PlaceHolder>
        <asp:PlaceHolder ID="loadGioHang" runat="server"></asp:PlaceHolder>
        <div class="main">
            <div class="size-header">
                <h1>Hướng dẫn chọn kích thước</h1>
                <p>Bạn có thể tìm thấy tất cả thông tin hướng dẫn về kích thước trong này.</p>
            </div>
            <div class="size-guide-navigation_category">
                <ul>
                    <li class=""><a href="/kich-thuoc/nam/ao">Nam</a></li>
                    <li class=""><a href="/kich-thuoc/nu/ao">Phụ nữ</a></li>
                    <li class=""><a href="/kich-thuoc/tre-em/ao">Trẻ em</a></li>
                </ul>
            </div>
        </div>
        <asp:PlaceHolder ID="loadfooter" runat="server"></asp:PlaceHolder>

    </form>
     <!-- TrustBox script -->
        <script type="text/javascript" src="//widget.trustpilot.com/bootstrap/v5/tp.widget.bootstrap.min.js" async></script>
    <!-- End TrustBox script -->
    <script src="/common/js/jquery.js"></script>
    <script src="/common/js/common.js"></script>
    <script src="/common/js/menu.js" ></script>
    <script src="/common/js/hover-highlight.js"></script>
    <script>
        $("#openform").click(function () {
            $("#js-formaccount").slideToggle();
        });
        $("#openform1").click(function () {
            $("#js-formaccount").slideToggle();
        });
    </script>
</body>
</html>
