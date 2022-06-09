using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace nguyeensport.dal
{
    public class clsquanlymodel
    {
        public DataTable layModel()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spLayModel";
            return SQLDB.SQLDB.GetData(cmd);
        }
        public DataTable layModelTheoID(int maModel)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spLayModelTheoID";
            cmd.Parameters.AddWithValue("@maModel", maModel);
            return SQLDB.SQLDB.GetData(cmd);
        }
        public void insertModel(string tenModel, string tenCollection, bool hienThi, bool Active)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spInsertModel";
            cmd.Parameters.AddWithValue("@tenModel", tenModel);
            cmd.Parameters.AddWithValue("@tenCollection", tenCollection);
            cmd.Parameters.AddWithValue("@hienThi", hienThi);
            cmd.Parameters.AddWithValue("@Active", Active);
            SQLDB.SQLDB.ExecuteNoneQuery(cmd);
        }
        public void updateModel(int maModel,string tenModel, string tenCollection, bool hienThi, bool Active)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spUpdateModel";
            cmd.Parameters.AddWithValue("@maModel", maModel);
            cmd.Parameters.AddWithValue("@tenModel", tenModel);
            cmd.Parameters.AddWithValue("@tenCollection", tenCollection);
            cmd.Parameters.AddWithValue("@hienThi", hienThi);
            cmd.Parameters.AddWithValue("@Active", Active);
            SQLDB.SQLDB.ExecuteNoneQuery(cmd);
        }
        public void deleteModel(int maModel)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spDeleteModel";
            cmd.Parameters.AddWithValue("@maModel", maModel);
            SQLDB.SQLDB.ExecuteNoneQuery(cmd);
        }
    }
}
