<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListProduct.aspx.cs" Inherits="nguyeensport.ListProduct" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset='utf-8' />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <meta http-equiv='X-UA-Compatible' content='IE=edge' />
    <title><asp:Literal ID="ltTitle" runat="server"></asp:Literal></title>
    <meta name='viewport' content='width=device-width, initial-scale=1' />
    <asp:Literal ID="ltMetaKeyword" runat="server"></asp:Literal>
    <asp:Literal ID="ltMetaDescription" runat="server"></asp:Literal>

    <link rel="shortcut icon" href="/Icon/favicon256x256.png" type="image/x-icon" />
    <link rel='stylesheet' type='text/css' media='screen' href='/common/css/resert.css' />
    <link rel="stylesheet" type="text/css" media="screen" href="/common/css/common.css" />
    <link rel="stylesheet" href="/common/css/slideout-basket.css" media="screen" type="text/css" />
    <link rel="stylesheet" type="text/css" media="screen" href="/common/css/main.css" />
    <link rel="stylesheet" type="text/css" media="screen" href="/common/css/activityfootball.css" />
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
     <script src="/common/js/jquery.js"></script>
    <script src="/common/js/common.js"></script>
    <script>
        let btn = document.querySelector('.filter-menu');
        let div = document.querySelector('.lister-filters');
        let span = document.querySelector('.filter-menu');
        btn.addEventListener('click', function () {
            if (div.className == "lister-filters" && span.className =="filter-menu") {
                div.classList.add("add-slideUp");
                span.classList.add("addRemote");
            }
            else {
                div.classList.remove("add-slideUp");
                span.classList.remove("addRemote");
            }
        });
        $(".js-accordion-title").on("click", function () {
            $(".js-accordion-item").addClass("accordion__item--active");
        });
    </script>
</body>
</html>
