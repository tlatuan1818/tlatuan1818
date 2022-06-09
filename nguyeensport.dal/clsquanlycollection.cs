using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace nguyeensport.dal
{
    public class clsquanlycollection
    {
        public DataTable layCollection()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spLayCollection";
            return SQLDB.SQLDB.GetData(cmd);
        }
        public DataTable layCollectionTheoID(int maCollection)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spLayCollectionTheoID";
            cmd.Parameters.AddWithValue("@maCollection", maCollection);
            return SQLDB.SQLDB.GetData(cmd);
        }
        public void insertCollection(string tenCollection, string tenBrands,bool hienThi,bool Active)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spInsertCollection";
            cmd.Parameters.AddWithValue("@tenCollection", tenCollection);
            cmd.Parameters.AddWithValue("@tenBrands", tenBrands);
            cmd.Parameters.AddWithValue("@hienThi", hienThi);
            cmd.Parameters.AddWithValue("@Active", Active);
            SQLDB.SQLDB.ExecuteNoneQuery(cmd);
        }
        public void updateCollection(int maCollection,string tenCollection, string tenBrands, bool hienThi, bool Active)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spUpdateCollection";
            cmd.Parameters.AddWithValue("@maCollection", maCollection);
            cmd.Parameters.AddWithValue("@tenCollection", tenCollection);
            cmd.Parameters.AddWithValue("@tenBrands", tenBrands);
            cmd.Parameters.AddWithValue("@hienThi", hienThi);
            cmd.Parameters.AddWithValue("@Active", Active);
            SQLDB.SQLDB.ExecuteNoneQuery(cmd);
        }
        public void deleteCollection(int maCollection)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spDeleteCollection";
            cmd.Parameters.AddWithValue("@maCollection", maCollection);
            SQLDB.SQLDB.ExecuteNoneQuery(cmd);
        }
    }
}
