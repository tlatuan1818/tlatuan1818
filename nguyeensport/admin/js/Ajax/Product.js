
function InsertProduct(maSanPham, tenSanPham, motaSanPham, avatarSanPham, giaInput, giaDiscount, giaOutput, maDanhMuc, luotView, ngayTao, hienThi, Active) {
    var products = {};
    products.Id_FB = "";
    products.maSanPham = maSanPham;
    products.tenSanPham = tenSanPham;
    products.motaSanPham = motaSanPham;
    products.giaInput = giaInput;
    products.giaDiscount = giaDiscount;
    products.giaOutput = giaOutput;
    products.maDanhMuc = maDanhMuc;
    products.titleSanPham = "";
    products.metaDescriptionSanPham = "";
    products.metaKeywordsSanPham = "";
    products.linkSanPham = "";
    products.AvatarSanPham = avatarSanPham;
    products.Anh1 = "";
    products.Anh2 = "";
    products.Anh3 = "";
    products.Anh4 = "";
    products.Anh5 = "";
    products.Anh6 = "";
    products.Anh7 = "";
    products.Anh8 = "";
    products.Anh9 = "";
    products.luotView = luotView;
    products.ngayTao = ngayTao;
    products.hienThi = hienThi
    products.Active = Active;
    $.ajax({
        url: '/Service/ProductService.asmx/InsertProduct',
        method: 'post',
        data: '{product: ' + JSON.stringify(products) + '}',
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {
            
            console.log(data);
        },
        error: function (err) {
            console.log(err);
        }
    });
}  