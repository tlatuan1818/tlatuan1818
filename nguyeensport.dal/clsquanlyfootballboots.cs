using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace nguyeensport.dal
{
    public class clsquanlyfootballboots
    {
        public DataTable layFootballBoots()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spFootballboots";
            return SQLDB.SQLDB.GetData(cmd);
        }
        public DataTable layFootballBootsTheoID(string maSanPham)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spLayFootballBootsTheoID";
            cmd.Parameters.AddWithValue("@maSanPham", maSanPham);
            return SQLDB.SQLDB.GetData(cmd);
        }
        public void insertFootballBoots(string maSanPham, string brands, string collection, string model, string age, string groundType, string Lop, string color){
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spInsertFootballBoots";
            cmd.Parameters.AddWithValue("@maSanPham", maSanPham);
            cmd.Parameters.AddWithValue("@brands", brands);
            cmd.Parameters.AddWithValue("@collection", collection);
            cmd.Parameters.AddWithValue("@model", model);
            cmd.Parameters.AddWithValue("@age", age);
            cmd.Parameters.AddWithValue("@groundType", groundType);
            cmd.Parameters.AddWithValue("@class", Lop);
            cmd.Parameters.AddWithValue("@color", color);
            SQLDB.SQLDB.ExecuteNoneQuery(cmd);
        }
        public void updateFootballBoots(string maSanPham, string brands, string collection, string model, string age, string groundType, string Lop, string color)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spUpdateFootballBoots";
            cmd.Parameters.AddWithValue("@maSanPham", maSanPham);
            cmd.Parameters.AddWithValue("@brands", brands);
            cmd.Parameters.AddWithValue("@collection", collection);
            cmd.Parameters.AddWithValue("@model", model);
            cmd.Parameters.AddWithValue("@age", age);
            cmd.Parameters.AddWithValue("@groundType", groundType);
            cmd.Parameters.AddWithValue("@class", Lop);
            cmd.Parameters.AddWithValue("@color", color);
            SQLDB.SQLDB.ExecuteNoneQuery(cmd);
        }
        public void deleteFootballBoots(string maSanPham)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spDeleteFootballBoots";
            cmd.Parameters.AddWithValue("@maSanPham", maSanPham);
            SQLDB.SQLDB.ExecuteNoneQuery(cmd);
        }
    }
}
