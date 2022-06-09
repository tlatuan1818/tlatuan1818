using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace nguyeensport.dal
{
    public class clsquanlyclass
    {
        public DataTable layClass()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spLayClass";
            return SQLDB.SQLDB.GetData(cmd);

        }
        public DataTable layClassTheoID(int maClass)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spLayClassTheoID";
            cmd.Parameters.AddWithValue("@maClass", maClass);
            return SQLDB.SQLDB.GetData(cmd);
        }
        public void insertClass(string tenClass, bool hienThi, bool Active)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spInsertClass";
            cmd.Parameters.AddWithValue("@tenClass", tenClass);
            cmd.Parameters.AddWithValue("@hienThi", hienThi);
            cmd.Parameters.AddWithValue("@Active", Active);
            SQLDB.SQLDB.ExecuteNoneQuery(cmd);
        }
        public void updateClass(int maClass, string tenClass, bool hienThi, bool Active)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spUpdateClass";
            cmd.Parameters.AddWithValue("@maClass", maClass);
            cmd.Parameters.AddWithValue("@tenClass", tenClass);
            cmd.Parameters.AddWithValue("@hienThi", hienThi);
            cmd.Parameters.AddWithValue("@Active", Active);
            SQLDB.SQLDB.ExecuteNoneQuery(cmd);
        }
        public void deleteClass(int maClass)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spDeleteClass";
            cmd.Parameters.AddWithValue("@maClass", maClass);
            SQLDB.SQLDB.ExecuteNoneQuery(cmd);
        }

    }
}
