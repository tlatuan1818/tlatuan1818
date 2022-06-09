using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nguyeensport.dal
{
    public class clsquanlyfanshop
    {
        #region Admin Quản lý Fan Shop

        public DataTable layAllFanshop()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spFanshop";
            return SQLDB.SQLDB.GetData(cmd);
        }
        public DataTable layFanShopTheoID(string maSanPham)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spLayFanShopTheoID";
            cmd.Parameters.AddWithValue("@maSanPham", maSanPham);
            return SQLDB.SQLDB.GetData(cmd);
        }
        public void insertFanShop(string maSanPham,string productType,string subType,string gender, string brands, string league,string team, string range,string version)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spInsertFanShop";
            cmd.Parameters.AddWithValue("@maSanPham", maSanPham);
            cmd.Parameters.AddWithValue("@productType", productType);
            cmd.Parameters.AddWithValue("@subType", subType);
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@brands", brands);
            cmd.Parameters.AddWithValue("@league", league);
            cmd.Parameters.AddWithValue("@team", team);
            cmd.Parameters.AddWithValue("@range", range);
            cmd.Parameters.AddWithValue("@version", version);
            SQLDB.SQLDB.ExecuteNoneQuery(cmd);
        }
        public void updateFanShop(string maSanPham, string productType, string subType, string gender, string brands, string league, string team, string range, string version)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spUpdateFanShop";
            cmd.Parameters.AddWithValue("@maSanPham", maSanPham);
            cmd.Parameters.AddWithValue("@productType", productType);
            cmd.Parameters.AddWithValue("@subType", subType);
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@brands", brands);
            cmd.Parameters.AddWithValue("@league", league);
            cmd.Parameters.AddWithValue("@team", team);
            cmd.Parameters.AddWithValue("@range", range);
            cmd.Parameters.AddWithValue("@version", version);
            SQLDB.SQLDB.ExecuteNoneQuery(cmd);
        }
        public void deleteFanShop(string maSanPham)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spDeleteFanShop";
            cmd.Parameters.AddWithValue("@maSanPham", maSanPham);
            SQLDB.SQLDB.ExecuteNoneQuery(cmd);
        }
        #endregion
    }
}
