using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace nguyeensport.dal
{
    public class clsquanlyage
    {
        public DataTable layAge()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spLayAge";
            return SQLDB.SQLDB.GetData(cmd);
        }
        public DataTable layAgeTheoID(int maAge)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spLayAgeTheoID";
            cmd.Parameters.AddWithValue("@maAge", maAge);
            return SQLDB.SQLDB.GetData(cmd);
        }

        public void insertAge(string tenAge,bool hienThi, bool Active)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spInsertAge";
            cmd.Parameters.AddWithValue("@tenAge", tenAge);
            cmd.Parameters.AddWithValue("@hienThi", hienThi);
            cmd.Parameters.AddWithValue("@Active", Active);
            SQLDB.SQLDB.ExecuteNoneQuery(cmd);
        }
        public void updateAge(int maAge,string tenAge, bool hienThi, bool Active)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spUpdateAge";
            cmd.Parameters.AddWithValue("@maAge", maAge);
            cmd.Parameters.AddWithValue("@tenAge", tenAge);
            cmd.Parameters.AddWithValue("@hienThi", hienThi);
            cmd.Parameters.AddWithValue("@Active", Active);
            SQLDB.SQLDB.ExecuteNoneQuery(cmd);
        }
        public void deleteAge(int maAge)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spDeleteAge";
            cmd.Parameters.AddWithValue("@maAge", maAge);
            SQLDB.SQLDB.ExecuteNoneQuery(cmd);
        }
    }
}
