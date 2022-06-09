using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nguyeensport.dal
{
    public class clsquanlygender
    {
        public DataTable layGender()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spLayGender";
            return SQLDB.SQLDB.GetData(cmd);
        }
        public DataTable layGenderTheoID(int maGender)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spLayGenderTheoID";
            cmd.Parameters.AddWithValue("@maGender", maGender);
            return SQLDB.SQLDB.GetData(cmd);
        }

        public void insertGender(string tenGender, bool hienThi, bool Active)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spInsertGender";
            cmd.Parameters.AddWithValue("@tenGender", tenGender);
            cmd.Parameters.AddWithValue("@hienThi", hienThi);
            cmd.Parameters.AddWithValue("@Active", Active);
            SQLDB.SQLDB.ExecuteNoneQuery(cmd);
        }
        public void updateGender(int maGender,string tenGender, bool hienThi, bool Active)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spUpdateGender";
            cmd.Parameters.AddWithValue("@maGender", maGender);
            cmd.Parameters.AddWithValue("@tenGender", tenGender);
            cmd.Parameters.AddWithValue("@hienThi", hienThi);
            cmd.Parameters.AddWithValue("@Active", Active);
            SQLDB.SQLDB.ExecuteNoneQuery(cmd);
        }
        public void deleteGender(int maGender)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spdeleteGender";
            cmd.Parameters.AddWithValue("@maGender", maGender);
            
            SQLDB.SQLDB.ExecuteNoneQuery(cmd);
        }
    }
}
