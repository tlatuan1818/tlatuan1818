using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace nguyeensport.dal
{
    public class clsquanlyteamwear
    {
        public DataTable layTeamwear()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spTeamwear";
            return SQLDB.SQLDB.GetData(cmd);
        }
        public DataTable layTeamwearTheoID(string maSanPham)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spLayTeamwearTheoID";
            cmd.Parameters.AddWithValue("@maSanPham", maSanPham);
            return SQLDB.SQLDB.GetData(cmd);
        }
        public void insertTeamwear(string maSanPham, string productType, string subType, string gender, string brands,string collection,string color) 
        { 
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spInsertTeamwear";
            cmd.Parameters.AddWithValue("@maSanPham", maSanPham);
            cmd.Parameters.AddWithValue("@productType", productType);
            cmd.Parameters.AddWithValue("@subType", subType);
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@brands", brands);
            cmd.Parameters.AddWithValue("@collection", collection);
            cmd.Parameters.AddWithValue("@color", color);
            SQLDB.SQLDB.ExecuteNoneQuery(cmd);
        }
        public void updateTeamwear(string maSanPham, string productType, string subType, string gender, string brands, string collection, string color)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spUpdateTeamwear";
            cmd.Parameters.AddWithValue("@maSanPham", maSanPham);
            cmd.Parameters.AddWithValue("@productType", productType);
            cmd.Parameters.AddWithValue("@subType", subType);
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@brands", brands);
            cmd.Parameters.AddWithValue("@collection", collection);
            cmd.Parameters.AddWithValue("@color", color);
            SQLDB.SQLDB.ExecuteNoneQuery(cmd);
        }
        public void deleteTeamwear(string maSanPham)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spDeleteTeamwear";
            cmd.Parameters.AddWithValue("@maSanPham", maSanPham);
            SQLDB.SQLDB.ExecuteNoneQuery(cmd);
        }
    }
}
