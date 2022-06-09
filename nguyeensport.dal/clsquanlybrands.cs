using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace nguyeensport.dal
{
    public class clsquanlybrands
    {
        public DataTable layBrands()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spLayBrands";
            return SQLDB.SQLDB.GetData(cmd);
        }
        public DataTable layBrandsTheoID(int idBrands)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spLayBrandsTheoID";
            cmd.Parameters.AddWithValue("@idBrands", idBrands);
            return SQLDB.SQLDB.GetData(cmd);
        }
        public DataTable layBrandsTheoHienThi()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spLayBrandsTheoHienThi";
           
            return SQLDB.SQLDB.GetData(cmd);
        }
        public void insertBrands(string tenBrands,string avatarBrands, string linkBrands,string titleBrands,string metaDescriptionBrands, string metaKeywordsBrands, DateTime ngayTao,bool hienThi,bool Active)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spInsertBrands";
            cmd.Parameters.AddWithValue("@tenBrands", tenBrands);
            cmd.Parameters.AddWithValue("@avatarBrands", avatarBrands);
            cmd.Parameters.AddWithValue("@linkBrands", linkBrands);
            cmd.Parameters.AddWithValue("@titleBrands", titleBrands);
            cmd.Parameters.AddWithValue("@metaDescriptionBrands", metaDescriptionBrands);
            cmd.Parameters.AddWithValue("@metaKeywordsBrands", metaKeywordsBrands);
            cmd.Parameters.AddWithValue("@ngayTao", ngayTao);
            cmd.Parameters.AddWithValue("@hienThi", hienThi);
            cmd.Parameters.AddWithValue("@Active", Active);
            SQLDB.SQLDB.ExecuteNoneQuery(cmd);
        }
        public void updateBrands(int idBrands,string tenBrands, string avatarBrands, string linkBrands, string titleBrands, string metaDescriptionBrands, string metaKeywordsBrands, DateTime ngayTao, bool hienThi, bool Active)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spUpdateBrands";
            cmd.Parameters.AddWithValue("@idBrands", idBrands);
            cmd.Parameters.AddWithValue("@tenBrands", tenBrands);
            cmd.Parameters.AddWithValue("@avatarBrands", avatarBrands);
            cmd.Parameters.AddWithValue("@linkBrands", linkBrands);
            cmd.Parameters.AddWithValue("@titleBrands", titleBrands);
            cmd.Parameters.AddWithValue("@metaDescriptionBrands", metaDescriptionBrands);
            cmd.Parameters.AddWithValue("@metaKeywordsBrands", metaKeywordsBrands);
            cmd.Parameters.AddWithValue("@ngayTao", ngayTao);
            cmd.Parameters.AddWithValue("@hienThi", hienThi);
            cmd.Parameters.AddWithValue("@Active", Active);
            SQLDB.SQLDB.ExecuteNoneQuery(cmd);
        }
        public void deleteBrands(int idBrands)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spDeleteBrands";
            cmd.Parameters.AddWithValue("@idBrands", idBrands);
            SQLDB.SQLDB.ExecuteNoneQuery(cmd);
        }
    }
}