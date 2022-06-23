using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using nguyeensport.Model;
using nguyeensport.dal;
using System.Web.Script.Services;

namespace nguyeensport.Service
{
    /// <summary>
    /// Summary description for ProductService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ScriptService]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ProductService : System.Web.Services.WebService
    {
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        [WebMethod]
        
        public string InsertProduct(ProductModel product)
        {
            try
            {
                clsquanlyproduct.insertProduct(product.id_FB, product.maSanPham, product.tenSanPham, product.motaSanPham,1, product.giaDiscount, (float)product.giaOutput, product.maDanhMuc, product.titleSanPham, product.metaDescriptionSanPham, product.metaKeywordsSanPham, product.linkSanPham, product.avatarSanPham, product.anh1, product.anh2, product.anh3, product.anh4, product.anh5, product.anh6, product.anh7, product.anh8, product.anh9, product.luotOrder, product.luotView, product.ngayTao, product.hienThi, product.Active);
                return "Thêm thành công";
            }
            catch(Exception ex) {

                return ex.ToString();
            }
        }
    }
}
