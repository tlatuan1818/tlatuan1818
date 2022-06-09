using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nguyeensport.dal
{
    public class clsquanlyproducttype
    {
        #region Quan ly ProductType
        public DataTable layProductType()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spLayProductType";
            return SQLDB.SQLDB.GetData(cmd);
        }
        public DataTable layProductTypeTheoID(int maProductType)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spLayProductTypeTheoID";
            cmd.Parameters.AddWithValue("@maProductType", maProductType);
            return SQLDB.SQLDB.GetData(cmd);
        }
        public DataTable layProductTypeTheoHienThi()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spLayProductTypeTheoHienThi";
           
            return SQLDB.SQLDB.GetData(cmd);
        }
        public void insertProductType(string tenProductType, string linkProductType,string iconProductType, string tenDanhMuc, bool hienThi, bool Active)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spInsertProductType";
            cmd.Parameters.AddWithValue("@tenProductType", tenProductType);
            cmd.Parameters.AddWithValue("@linkProductType", linkProductType);
            cmd.Parameters.AddWithValue("@iconProductType", iconProductType);
            cmd.Parameters.AddWithValue("@tenDanhMuc", tenDanhMuc);
            cmd.Parameters.AddWithValue("@hienThi", hienThi);
            cmd.Parameters.AddWithValue("@Active", Active);
            SQLDB.SQLDB.ExecuteNoneQuery(cmd);
        }
        public void updateProductType(int maProductType,string tenProductType, string linkProductType, string iconProductType, string tenDanhMuc, bool hienThi, bool Active)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spUpdateProductType";
            cmd.Parameters.AddWithValue("@maProductType", maProductType);
            cmd.Parameters.AddWithValue("@tenProductType", tenProductType);
            cmd.Parameters.AddWithValue("@linkProductType", linkProductType);
            cmd.Parameters.AddWithValue("@iconProductType", iconProductType);
            cmd.Parameters.AddWithValue("@tenDanhMuc", tenDanhMuc);
            cmd.Parameters.AddWithValue("@hienThi", hienThi);
            cmd.Parameters.AddWithValue("@Active", Active);
            SQLDB.SQLDB.ExecuteNoneQuery(cmd);
        }
        public void deleteProductType(int maProductType)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spDeleteProductType";
            cmd.Parameters.AddWithValue("@maProductType", maProductType);
            SQLDB.SQLDB.ExecuteNoneQuery(cmd);
        }
        #endregion
        #region Quan ly ProductSubType
        public DataTable layProductSubType()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spLaySubType";
            return SQLDB.SQLDB.GetData(cmd);
        }
        public DataTable layProductSubTypeTheoMaProductType(int maProductType)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spLaySubTypeTheoMaType";
            cmd.Parameters.AddWithValue("@maProductType", maProductType);
            return SQLDB.SQLDB.GetData(cmd);
        }
        public DataTable layProductSubTypeTheoID(int maProductSubType)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spLayProductSubTypeTheoID";
            cmd.Parameters.AddWithValue("@maProductSubType", maProductSubType);
            return SQLDB.SQLDB.GetData(cmd);
        }
        public void insertProductSubType(string tenProductSubType, string iconProductSubType,string tenProductType,string tenDanhMuc , bool hienThi, bool Active)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spInsertProductSubType";
            cmd.Parameters.AddWithValue("@tenProductSubType", tenProductSubType);
            cmd.Parameters.AddWithValue("@iconProductSubType", iconProductSubType);
            cmd.Parameters.AddWithValue("@tenProductType", tenProductType);
            cmd.Parameters.AddWithValue("@tenDanhMuc", tenDanhMuc);
            cmd.Parameters.AddWithValue("@hienThi", hienThi);
            cmd.Parameters.AddWithValue("@Active", Active);
            SQLDB.SQLDB.ExecuteNoneQuery(cmd);
        }
        public void updateProductSubType(int maProductSubType,string tenProductSubType, string iconProductSubType, string tenProductType, string tenDanhMuc, bool hienThi, bool Active)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spUpdateProductSubType";
            cmd.Parameters.AddWithValue("@maProductSubType", maProductSubType);
            cmd.Parameters.AddWithValue("@tenProductSubType", tenProductSubType);
            cmd.Parameters.AddWithValue("@iconProductSubType", iconProductSubType);
            cmd.Parameters.AddWithValue("@tenProductType", tenProductType);
            cmd.Parameters.AddWithValue("@tenDanhMuc", tenDanhMuc);
            cmd.Parameters.AddWithValue("@hienThi", hienThi);
            cmd.Parameters.AddWithValue("@Active", Active);
            SQLDB.SQLDB.ExecuteNoneQuery(cmd);
        }
        public void deleteProductSubType(int maProductSubType)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spDeleteProductSubType";
            cmd.Parameters.AddWithValue("@maProductSubType", maProductSubType);
            SQLDB.SQLDB.ExecuteNoneQuery(cmd);
        }
        #endregion
    }
}
