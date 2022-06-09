using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace nguyeensport.dal
{
    public class clsquanlycolor
    {
        public DataTable layColor()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spLayColor";
            return SQLDB.SQLDB.GetData(cmd);
        }
        public DataTable layColorTheoID(int maColor)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spLayColorTheoID";
            cmd.Parameters.AddWithValue("@maColor", maColor);
            return SQLDB.SQLDB.GetData(cmd);
        }

        public void insertColor(string tenColor,bool hienThi, bool Active)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spInsertColor";
            cmd.Parameters.AddWithValue("@tenColor", tenColor);
            cmd.Parameters.AddWithValue("@hienThi", hienThi);
            cmd.Parameters.AddWithValue("@Active", Active);
            SQLDB.SQLDB.ExecuteNoneQuery(cmd);
        }
        public void updateColor(int maColor,string tenColor, bool hienThi, bool Active)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spUpdateColor";
            cmd.Parameters.AddWithValue("@maColor", maColor);
            cmd.Parameters.AddWithValue("@tenColor", tenColor);
            cmd.Parameters.AddWithValue("@hienThi", hienThi);
            cmd.Parameters.AddWithValue("@Active", Active);
            SQLDB.SQLDB.ExecuteNoneQuery(cmd);
        }
        public void deleteColor(int maColor)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spDeleteColor";
            cmd.Parameters.AddWithValue("@maColor", maColor);
            SQLDB.SQLDB.ExecuteNoneQuery(cmd);
        }
    }
}
