using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace nguyeensport.dal
{
    public class clsquanlygroundtype
    {
        public DataTable layGroundType()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spLayGroundType";
            return SQLDB.SQLDB.GetData(cmd);
        }
        public DataTable layGroundTypeTheoID(int maGroundType)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spLayGroundTypeTheoID";
            cmd.Parameters.AddWithValue("@maGroundType", maGroundType);
            return SQLDB.SQLDB.GetData(cmd);
        }
        public void insertGroundType(string maGroundType,string tenGroundType,bool hienThi, bool Active)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spInsertGroundType";
            cmd.Parameters.AddWithValue("@maGroundType", maGroundType);
            cmd.Parameters.AddWithValue("@tenGroundType", tenGroundType);
            cmd.Parameters.AddWithValue("@hienThi", hienThi);
            cmd.Parameters.AddWithValue("@Active", Active);
            SQLDB.SQLDB.ExecuteNoneQuery(cmd);
        }
        public void updateGroundType(string maGroundType,string tenGroundType, bool hienThi, bool Active)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spUpdateGroundType";
            cmd.Parameters.AddWithValue("@maGroundType", maGroundType);
            cmd.Parameters.AddWithValue("@tenGroundType", tenGroundType);
            cmd.Parameters.AddWithValue("@hienThi", hienThi);
            cmd.Parameters.AddWithValue("@Active", Active);
            SQLDB.SQLDB.ExecuteNoneQuery(cmd);
        }
        public void deleteGroundType(string maGroundType)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spDeleteGroundType";
            cmd.Parameters.AddWithValue("@maGroundType", maGroundType);
            SQLDB.SQLDB.ExecuteNoneQuery(cmd);
        }

    }
}
