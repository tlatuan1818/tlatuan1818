using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace nguyeensport.dal
{
    public class clsquanlyrange
    {
        #region Range
        public DataTable layRange()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spLayRange";
            return SQLDB.SQLDB.GetData(cmd);
        }

        public DataTable layRangeTheoID(int maRange)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spLayRangeTheoID";
            cmd.Parameters.AddWithValue("@maRange", maRange);
            return SQLDB.SQLDB.GetData(cmd);
        }
        public DataTable layRangeTheoHienThi()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spLayRangeTheoHienThi";
            
            return SQLDB.SQLDB.GetData(cmd);
        }
        public void insertRange(string tenRange,string linkRange, bool hienThi, bool Active)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spInsertRange";
            cmd.Parameters.AddWithValue("@tenRange", tenRange);
            cmd.Parameters.AddWithValue("@linkRange", linkRange);
            cmd.Parameters.AddWithValue("@hienThi", hienThi);
            cmd.Parameters.AddWithValue("@Active", Active);
            SQLDB.SQLDB.ExecuteNoneQuery(cmd);
        }

        public void updateRange(int maRange, string tenRange,string linkRange, bool hienThi, bool Active)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spUpdateRange";
            cmd.Parameters.AddWithValue("@maRange", maRange);
            cmd.Parameters.AddWithValue("@tenRange", tenRange);
            cmd.Parameters.AddWithValue("@linkRange", linkRange);
            cmd.Parameters.AddWithValue("@hienThi", hienThi);
            cmd.Parameters.AddWithValue("@Active", Active);
            SQLDB.SQLDB.ExecuteNoneQuery(cmd);
        }

        public void deleteRange(int maRange)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spDeleteRange";
            cmd.Parameters.AddWithValue("@maRange", maRange);
            SQLDB.SQLDB.ExecuteNoneQuery(cmd);
        }
        #endregion



        #region Version
        public DataTable layVersion()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spLayVersion";
            return SQLDB.SQLDB.GetData(cmd);
        }
        public DataTable layVersionTheoID(int maVersion)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spLayVersionTheoID";
            cmd.Parameters.AddWithValue("@maVersion", maVersion);
            return SQLDB.SQLDB.GetData(cmd);
        }
        public void insertVersion(string tenVersion, bool hienThi, bool Active)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spInsertVersion";
            cmd.Parameters.AddWithValue("@tenVersion", tenVersion);
            cmd.Parameters.AddWithValue("@hienThi", hienThi);
            cmd.Parameters.AddWithValue("@Active", Active);
            SQLDB.SQLDB.ExecuteNoneQuery(cmd);
        }
        public void updateVersion(int maVersion,string tenVersion, bool hienThi, bool Active)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spUpdateVersion";
            cmd.Parameters.AddWithValue("@maVersion", maVersion);
            cmd.Parameters.AddWithValue("@tenVersion", tenVersion);
            cmd.Parameters.AddWithValue("@hienThi", hienThi);
            cmd.Parameters.AddWithValue("@Active", Active);
            SQLDB.SQLDB.ExecuteNoneQuery(cmd);
        }

        public void deleteVersion(int maVersion)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spDeleteVersion";
            cmd.Parameters.AddWithValue("@maVersion", maVersion);
            SQLDB.SQLDB.ExecuteNoneQuery(cmd);
        }
        #endregion
    }
}
