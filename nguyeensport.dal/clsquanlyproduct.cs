using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace nguyeensport.dal
{
    public class clsquanlyproduct
    {
        
        public static void insertProduct(string id_FB,string maSanPham,string tenSanPham,string motaSanPham,float giaInput, string giaDiscount,float giaOutput, int maDanhMuc, string titleSanPham, string metaDescriptionSanPham,string metaKeywordsSanPham,string linkSanPham,string avatarSanPham,string anh1, string anh2, string anh3, string anh4, string anh5, string anh6, string anh7, string anh8, string anh9,int luotOrder,int luotView,DateTime ngayTao,bool hienThi,bool Active)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spInsertProduct";
            cmd.Parameters.AddWithValue("@id_FB", id_FB);
            cmd.Parameters.AddWithValue("@maSanPham", maSanPham);
            cmd.Parameters.AddWithValue("@tenSanPham", tenSanPham);
            cmd.Parameters.AddWithValue("@motaSanPham", motaSanPham);
            cmd.Parameters.AddWithValue("@giaInput", giaInput);
            cmd.Parameters.AddWithValue("@giaDiscount", giaDiscount);
            cmd.Parameters.AddWithValue("@giaOutput", giaOutput);
            cmd.Parameters.AddWithValue("@maDanhMuc", maDanhMuc);
            cmd.Parameters.AddWithValue("@titleSanPham", titleSanPham);
            cmd.Parameters.AddWithValue("@metaDescriptionSanPham", metaDescriptionSanPham);
            cmd.Parameters.AddWithValue("@metaKeywordsSanPham", metaKeywordsSanPham);
            cmd.Parameters.AddWithValue("@linkSanPham", linkSanPham); 
            cmd.Parameters.AddWithValue("@avatarSanPham", avatarSanPham);
            cmd.Parameters.AddWithValue("@anh1", anh1);
            cmd.Parameters.AddWithValue("@anh2", anh2);
            cmd.Parameters.AddWithValue("@anh3", anh3);
            cmd.Parameters.AddWithValue("@anh4", anh4);
            cmd.Parameters.AddWithValue("@anh5", anh5);
            cmd.Parameters.AddWithValue("@anh6", anh6);
            cmd.Parameters.AddWithValue("@anh7", anh7);
            cmd.Parameters.AddWithValue("@anh8", anh8);
            cmd.Parameters.AddWithValue("@anh9", anh9);
            cmd.Parameters.AddWithValue("@luotOrder", luotOrder);
            cmd.Parameters.AddWithValue("@luotView", luotView);
            cmd.Parameters.AddWithValue("@ngayTao", ngayTao);
            cmd.Parameters.AddWithValue("@hienThi", hienThi);
            cmd.Parameters.AddWithValue("@Active", Active);
            SQLDB.SQLDB.ExecuteNoneQuery(cmd);
        }
        public static void insertProductSize(string maSanPham,string tenSize,int soLuong)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spInsertSize";
            cmd.Parameters.AddWithValue("@maSanPham", maSanPham);
            cmd.Parameters.AddWithValue("@tenSize", tenSize);
            cmd.Parameters.AddWithValue("@soLuong", soLuong);
            SQLDB.SQLDB.ExecuteNoneQuery(cmd);
        }
        public static void updateProduct(string maSanPham, string tenSanPham, string motaSanPham, float giaInput, string giaDiscount, float giaOutput, int maDanhMuc, string titleSanPham, string metaDescriptionSanPham, string metaKeywordsSanPham, string linkSanPham, string avatarSanPham, string anh1, string anh2, string anh3, string anh4, string anh5, string anh6, string anh7, string anh8, string anh9, DateTime ngayTao, bool hienThi,bool Active)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spUpdateProduct";
            cmd.Parameters.AddWithValue("@maSanPham", maSanPham);
            cmd.Parameters.AddWithValue("@tenSanPham", tenSanPham);
            cmd.Parameters.AddWithValue("@motaSanPham", motaSanPham);
            cmd.Parameters.AddWithValue("@giaInput", giaInput);
            cmd.Parameters.AddWithValue("@giaDiscount", giaDiscount);
            cmd.Parameters.AddWithValue("@giaOutput", giaOutput);
            cmd.Parameters.AddWithValue("@maDanhMuc", maDanhMuc);
            cmd.Parameters.AddWithValue("@titleSanPham", titleSanPham);
            cmd.Parameters.AddWithValue("@metaDescriptionSanPham", metaDescriptionSanPham);
            cmd.Parameters.AddWithValue("@metaKeywordsSanPham", metaKeywordsSanPham);
            cmd.Parameters.AddWithValue("@linkSanPham", linkSanPham);
            cmd.Parameters.AddWithValue("@avatarSanPham", avatarSanPham);
            cmd.Parameters.AddWithValue("@anh1", anh1);
            cmd.Parameters.AddWithValue("@anh2", anh2);
            cmd.Parameters.AddWithValue("@anh3", anh3);
            cmd.Parameters.AddWithValue("@anh4", anh4);
            cmd.Parameters.AddWithValue("@anh5", anh5);
            cmd.Parameters.AddWithValue("@anh6", anh6);
            cmd.Parameters.AddWithValue("@anh7", anh7);
            cmd.Parameters.AddWithValue("@anh8", anh8);
            cmd.Parameters.AddWithValue("@anh9", anh9);
            cmd.Parameters.AddWithValue("@ngayTao", ngayTao);
            cmd.Parameters.AddWithValue("@hienThi", hienThi);
            cmd.Parameters.AddWithValue("@Active", Active);
            SQLDB.SQLDB.ExecuteNoneQuery(cmd);
        }
        public static void updateProductSize(string maSanPham, string tenSize, int soLuong)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spUpdateProductSize";
            cmd.Parameters.AddWithValue("@maSanPham", maSanPham);
            cmd.Parameters.AddWithValue("@tenSize", tenSize);
            cmd.Parameters.AddWithValue("@soLuong", soLuong);
            SQLDB.SQLDB.ExecuteNoneQuery(cmd);
        }
        public static void deleteProduct(string maSanPham)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spDeleteProduct";
            cmd.Parameters.AddWithValue("@maSanPham", maSanPham);
            SQLDB.SQLDB.ExecuteNoneQuery(cmd);
        }
        public static void deleteProductSize(string maSanPham)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spDeleteProductSize";
            cmd.Parameters.AddWithValue("@maSanPham", maSanPham);
            SQLDB.SQLDB.ExecuteNoneQuery(cmd);
        }
        public static void updateHienThiProduct(int id, bool Active)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spUpdateHienThiProduct";
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@Active", Active);
            SQLDB.SQLDB.ExecuteNoneQuery(cmd);
        }
        public static DataTable laySizeOfProduct(string maSanPham)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spProductSize";
            cmd.Parameters.AddWithValue("@maSanPham", maSanPham);
            return SQLDB.SQLDB.GetData(cmd);
        }
        public static DataTable layProductSizeTheoMaSanPham(string maSanPham)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spLayProductSizeTheoMaSanPham";
            cmd.Parameters.AddWithValue("@maSanPham", maSanPham);
            return SQLDB.SQLDB.GetData(cmd);
        }

        #region UserDisplay
        public static DataTable layTop15ProductHot()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spLayTop15ProductHot";
            return SQLDB.SQLDB.GetData(cmd);
        }
        public static DataTable layTop15ProductTheoMaDanhMuc(int maDanhMuc)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spLayProductTheoMaDanhMuc";
            cmd.Parameters.AddWithValue("@maDanhMuc", maDanhMuc);
            return SQLDB.SQLDB.GetData(cmd);
        }

        #endregion
    }
}
