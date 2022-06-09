<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="myaccount.aspx.cs" Inherits="nguyeensport.Display.Unitl.myaccount" %>

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
    <asp:Literal ID="ltCSS" runat="server"></asp:Literal>
    
</head>
<body>
    <form id="form1" runat="server">
        <asp:PlaceHolder ID="loadheader" runat="server"></asp:PlaceHolder>
        <asp:PlaceHolder ID="loadMenuList1" runat="server"></asp:PlaceHolder>
        <asp:PlaceHolder ID="loadMenuList2" runat="server"></asp:PlaceHolder>
        <asp:PlaceHolder ID="loadSearch" runat="server"></asp:PlaceHolder>
        <asp:PlaceHolder ID="loadGioHang" runat="server"></asp:PlaceHolder>

        <asp:PlaceHolder ID="loadMain" runat="server"></asp:PlaceHolder>
        <asp:PlaceHolder ID="loadfooter" runat="server"></asp:PlaceHolder>
    </form>
     <!-- TrustBox script -->
        <script type="text/javascript" src="//widget.trustpilot.com/bootstrap/v5/tp.widget.bootstrap.min.js" async></script>
    <!-- End TrustBox script -->
    <script src="/common/js/jquery.js"></script>
    <script src="/common/js/common.js"></script>
    <script src="/common/js/menu.js"></script>
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
