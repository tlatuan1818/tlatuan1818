<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="404.aspx.cs" Inherits="nguyeensport._404" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset='utf-8' />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <meta http-equiv='X-UA-Compatible' content='IE=edge' />
    <title>Page 404</title>
    <meta name='viewport' content='width=device-width, initial-scale=1' />
    <link rel="shortcut icon" href="/images/common/NGUYEEN.svg" type="image/x-icon" />
    <link rel='stylesheet' type='text/css' media='screen' href='/common/css/resert.css' />
    <link rel='stylesheet' type='text/css' media='screen' href='/common/css/404.css' />
</head>
<body>
    <form id="form1" runat="server">
        <div class="bg-container">
            <img src="/images/common/desktop404.jpg" alt="nguyeensport" />
            <div class="bg-content">
                <h1>Trang không tồn tại</h1>
                <asp:HyperLink ID="link" NavigateUrl="/" runat="server">Quay về trang chủ</asp:HyperLink>
            </div>
        </div>
    </form>
</body>
</html>
