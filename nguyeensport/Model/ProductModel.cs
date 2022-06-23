using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace nguyeensport.Model
{
    public class ProductModel
    {
        public int id { get; set; }
        public string id_FB { get; set; }
        public string maSanPham { get; set; }
        public string tenSanPham { get; set; }
        public string motaSanPham { get; set; }
        public Nullable<decimal> giaInput { get; set; }
        public string giaDiscount { get; set; }
        public Nullable<decimal> giaOutput { get; set; }
        public int maDanhMuc { get; set; }
        public string titleSanPham { get; set; }
        public string metaDescriptionSanPham { get; set; }
        public string metaKeywordsSanPham { get; set; }
        public string linkSanPham { get; set; }
        public string avatarSanPham { get; set; }
        public string anh1 { get; set; }
        public string anh2 { get; set; }
        public string anh3 { get; set; }
        public string anh4 { get; set; }
        public string anh5 { get; set; }
        public string anh6 { get; set; }
        public string anh7 { get; set; }
        public string anh8 { get; set; }
        public string anh9 { get; set; }
        public int luotOrder { get; set; }
        public int luotView { get; set; }
        public DateTime ngayTao { get; set; }
        public bool hienThi { get; set; }
        public bool Active { get; set; }

    }
}