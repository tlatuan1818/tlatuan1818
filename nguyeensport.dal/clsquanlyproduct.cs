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
        static void ProductSize_Create()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("tenSize", typeof(string));
            dt.Columns.Add("soLuong", typeof(int));
            System.Web.HttpContext.Current.Session["productsize"] = dt;
        }
        public void ProductSize_addSize(string tenSize, int soLuong)
        {
            if (System.Web.HttpContext.Current.Session["productsize"] == null)
            {
                ProductSize_Create();
                ProductSize_addSize(tenSize, soLuong);
            }
            else
            {
                DataTable dt = new DataTable();
                dt = (DataTable)System.Web.HttpContext.Current.Session["productsize"];
                bool hdInsert = false;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["tenSize"].ToString() == tenSize)
                    {
                        hdInsert = true;
                        dt.Rows[i]["soLuong"] = soLuong;
                        System.Web.HttpContext.Current.Session["productsize"] = dt;
                    }
                }
                if (hdInsert == false)
                {
                    DataRow dr = dt.NewRow();
                    dr["tenSize"] = tenSize;
                    dr["soLuong"] = soLuong;
                    dt.Rows.Add(dr);
                    System.Web.HttpContext.Current.Session["productsize"] = dt;
                }
            }
        }
        public void ProductSize_RemoveSize(string tenSize)
        {
            DataTable dt = new DataTable();
            dt = (DataTable)System.Web.HttpContext.Current.Session["productsize"];

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["tenSize"].ToString() == tenSize.ToString())
                {
                    dt.Rows.RemoveAt(i);
                    break;
                }
            }
            System.Web.HttpContext.Current.Session["productsize"] = dt;
        }
        public void insertProduct(string id_FB,string maSanPham,string tenSanPham,string motaSanPham,float giaInput, string giaDiscount,float giaOutput, int maDanhMuc, string titleSanPham, string metaDescriptionSanPham,string metaKeywordsSanPham,string linkSanPham,string avatarSanPham,string anh1, string anh2, string anh3, string anh4, string anh5, string anh6, string anh7, string anh8, string anh9,int luotOrder,int luotView,DateTime ngayTao,bool hienThi,bool Active)
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
        public void insertProductSize(string maSanPham,string tenSize,int soLuong)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spInsertSize";
            cmd.Parameters.AddWithValue("@maSanPham", maSanPham);
            cmd.Parameters.AddWithValue("@tenSize", tenSize);
            cmd.Parameters.AddWithValue("@soLuong", soLuong);
            SQLDB.SQLDB.ExecuteNoneQuery(cmd);
        }
        public void updateProduct(string maSanPham, string tenSanPham, string motaSanPham, float giaInput, string giaDiscount, float giaOutput, int maDanhMuc, string titleSanPham, string metaDescriptionSanPham, string metaKeywordsSanPham, string linkSanPham, string avatarSanPham, string anh1, string anh2, string anh3, string anh4, string anh5, string anh6, string anh7, string anh8, string anh9, DateTime ngayTao, bool hienThi,bool Active)
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
        public void updateProductSize(string maSanPham, string tenSize, int soLuong)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spUpdateProductSize";
            cmd.Parameters.AddWithValue("@maSanPham", maSanPham);
            cmd.Parameters.AddWithValue("@tenSize", tenSize);
            cmd.Parameters.AddWithValue("@soLuong", soLuong);
            SQLDB.SQLDB.ExecuteNoneQuery(cmd);
        }
        public void deleteProduct(string maSanPham)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spDeleteProduct";
            cmd.Parameters.AddWithValue("@maSanPham", maSanPham);
            SQLDB.SQLDB.ExecuteNoneQuery(cmd);
        }
        public void deleteProductSize(string maSanPham)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spDeleteProductSize";
            cmd.Parameters.AddWithValue("@maSanPham", maSanPham);
            SQLDB.SQLDB.ExecuteNoneQuery(cmd);
        }
        public void updateHienThiProduct(int id, bool Active)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spUpdateHienThiProduct";
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@Active", Active);
            SQLDB.SQLDB.ExecuteNoneQuery(cmd);
        }
        public DataTable laySizeOfProduct(string maSanPham)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spProductSize";
            cmd.Parameters.AddWithValue("@maSanPham", maSanPham);
            return SQLDB.SQLDB.GetData(cmd);
        }
        public DataTable layProductSizeTheoMaSanPham(string maSanPham)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spLayProductSizeTheoMaSanPham";
            cmd.Parameters.AddWithValue("@maSanPham", maSanPham);
            return SQLDB.SQLDB.GetData(cmd);
        }

        #region UserDisplay
        public DataTable layTop15ProductHot()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spLayTop15ProductHot";
            return SQLDB.SQLDB.GetData(cmd);
        }
        public DataTable layTop15ProductTheoMaDanhMuc(int maDanhMuc)
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
