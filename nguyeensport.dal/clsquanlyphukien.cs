using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace nguyeensport.dal
{
    public class clsquanlyphukien
    {
        public DataTable layPhuKien()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spPhuKien";
            return SQLDB.SQLDB.GetData(cmd);
        }
        public DataTable layPhuKienTheoID(string maSanPham)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spLayPhuKienTheoID";
            cmd.Parameters.AddWithValue("@maSanPham", maSanPham);
            return SQLDB.SQLDB.GetData(cmd);
        }
        public void insertPhuKien(string maSanPham,string productType, string subType, string brands, string color)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spInsertPhuKien";
            cmd.Parameters.AddWithValue("@maSanPham", maSanPham);
            cmd.Parameters.AddWithValue("@productType", productType);
            cmd.Parameters.AddWithValue("@subType", subType);
            cmd.Parameters.AddWithValue("@brands", brands);
            cmd.Parameters.AddWithValue("@color", color);
            SQLDB.SQLDB.ExecuteNoneQuery(cmd);
        }
        public void updatePhuKien(string maSanPham, string productType, string subType, string brands, string color)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spUpdateTeamwear";
            cmd.Parameters.AddWithValue("@maSanPham", maSanPham);
            cmd.Parameters.AddWithValue("@productType", productType);
            cmd.Parameters.AddWithValue("@subType", subType);
            cmd.Parameters.AddWithValue("@brands", brands);
            cmd.Parameters.AddWithValue("@color", color);
            SQLDB.SQLDB.ExecuteNoneQuery(cmd);
        }
        public void deletePhuKien(string maSanPham)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spDeletePhuKien";
            cmd.Parameters.AddWithValue("@maSanPham", maSanPham);
            SQLDB.SQLDB.ExecuteNoneQuery(cmd);
        }
    }
}
