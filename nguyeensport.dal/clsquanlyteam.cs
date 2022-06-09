using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace nguyeensport.dal
{
    public class clsquanlyteam
    {
        public DataTable layTeam()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spLayTeam";
            return SQLDB.SQLDB.GetData(cmd);
        }
        public DataTable layTeamTheoLeague(int maLeague)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spLayTeamTheoLeague";
            cmd.Parameters.AddWithValue("@maLeague", maLeague);
            return SQLDB.SQLDB.GetData(cmd);
        }

        public DataTable layTeamTheoID(int maTeam)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spLayTeamTheoID";
            cmd.Parameters.AddWithValue("@maTeam", maTeam);
            return SQLDB.SQLDB.GetData(cmd);
        }
        public DataTable layTeamTheoHienThi()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spLayTeamTheoHienThi";
           
            return SQLDB.SQLDB.GetData(cmd);
        }
        public void insertTeam(string tenTeam,string linkTeam, string iconTeam, string tenLeague, bool hienThi, bool Active)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spInsertTeam";
            cmd.Parameters.AddWithValue("@tenTeam", tenTeam);
            cmd.Parameters.AddWithValue("@linkTeam", linkTeam);
            cmd.Parameters.AddWithValue("@iconTeam", iconTeam);
            cmd.Parameters.AddWithValue("@tenLeague", tenLeague);
            cmd.Parameters.AddWithValue("@hienThi", hienThi);
            cmd.Parameters.AddWithValue("@Active", Active);
            SQLDB.SQLDB.ExecuteNoneQuery(cmd);
        }
        public void updateTeam(int maTeam, string tenTeam, string linkTeam, string iconTeam, string tenLeague, bool hienThi, bool Active)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spUpdateTeam";
            cmd.Parameters.AddWithValue("@maTeam", maTeam);
            cmd.Parameters.AddWithValue("@tenTeam", tenTeam);
            cmd.Parameters.AddWithValue("@linkTeam", linkTeam);
            cmd.Parameters.AddWithValue("@iconTeam", iconTeam);
            cmd.Parameters.AddWithValue("@tenLeague", tenLeague);
            cmd.Parameters.AddWithValue("@hienThi", hienThi);
            cmd.Parameters.AddWithValue("@Active", Active);
            SQLDB.SQLDB.ExecuteNoneQuery(cmd);
        }
        public void deleteTeam(int maTeam)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spDeleteTeam";
            cmd.Parameters.AddWithValue("@maTeam", maTeam);
            SQLDB.SQLDB.ExecuteNoneQuery(cmd);
        }
    }
}
