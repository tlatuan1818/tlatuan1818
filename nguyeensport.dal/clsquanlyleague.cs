using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace nguyeensport.dal
{
    public class clsquanlyleague
    {
        public DataTable layLeague()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spLayLeague";
            return SQLDB.SQLDB.GetData(cmd);
        }
        public DataTable layLeagueTheoID(int maLeague)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spLayLeagueTheoID";
            cmd.Parameters.AddWithValue("@maLeague", maLeague);
            return SQLDB.SQLDB.GetData(cmd);
        }
        public DataTable layLeagueTheoHienThi()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spLayLeagueTheoHienThi";
            return SQLDB.SQLDB.GetData(cmd);
        }
        public void insertLeague(string tenLeague,string linkLeague,string iconLeague,bool hienThi,bool Active)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spInsertLeague";
            cmd.Parameters.AddWithValue("@tenLeague", tenLeague);
            cmd.Parameters.AddWithValue("@linkLeague", linkLeague);
            cmd.Parameters.AddWithValue("@iconLeague", iconLeague);
            cmd.Parameters.AddWithValue("@hienThi", hienThi);
            cmd.Parameters.AddWithValue("@Active", Active);
            SQLDB.SQLDB.ExecuteNoneQuery(cmd);
        }
        public void updateLeague(int maLeague,string tenLeague, string linkLeague, string iconLeague, bool hienThi, bool Active)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spUpdateLeague";
            cmd.Parameters.AddWithValue("@maLeague", maLeague);
            cmd.Parameters.AddWithValue("@tenLeague", tenLeague);
            cmd.Parameters.AddWithValue("@linkLeague", linkLeague);
            cmd.Parameters.AddWithValue("@iconLeague", iconLeague);
            cmd.Parameters.AddWithValue("@hienThi", hienThi);
            cmd.Parameters.AddWithValue("@Active", Active);
            SQLDB.SQLDB.ExecuteNoneQuery(cmd);
        }
        public void deleteLeague(int maLeague)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spDeleteLeague";
            cmd.Parameters.AddWithValue("@maLeague", maLeague);
            SQLDB.SQLDB.ExecuteNoneQuery(cmd);
        }

    }
}
