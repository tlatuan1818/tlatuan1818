using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nguyeensport.dal
{
    public class clsquanlydanhmuc
    {
        public DataTable layCategories() {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spLayCategories";
            return SQLDB.SQLDB.GetData(cmd);
        }
        public DataTable layCategoriesTheoID(int maDanhMuc)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spLayCategoriesTheoID";
            cmd.Parameters.AddWithValue("@maDanhMuc", maDanhMuc);
            return SQLDB.SQLDB.GetData(cmd);
        }
        public DataTable layCategoriesTheoHienThi()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spLayCategoriesTheoHienThi";
            return SQLDB.SQLDB.GetData(cmd);
        }
        public DataTable laySubPanertCategoriesTheoMaDanhMucCon(int maDanhMucCon) {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spLayPanertCategoriesTheoMaDanhMucCon";
            cmd.Parameters.AddWithValue("@maDanhMucCon", maDanhMucCon);
            return SQLDB.SQLDB.GetData(cmd);
        }
        public DataTable laySubPanertCategoriesTheoLink(string linkDanhMucCon)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spLaySubPanertCategoriesTheoLink";
            cmd.Parameters.AddWithValue("@linkDanhMucCon", linkDanhMucCon);
            return SQLDB.SQLDB.GetData(cmd);
        }
        public DataTable laySubChildCategoriesTheoMaDanhMucConCap1(int maDanhMucConCap1)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spLayChildCategoriesTheoMaDanhMucConCap1";
            cmd.Parameters.AddWithValue("@maDanhMucConCap1", maDanhMucConCap1);
            return SQLDB.SQLDB.GetData(cmd);
        }
        public DataTable laySubPanertCategoriesTheoMaDanhMucHienThi(int maDanhMuc)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spLaySubPanertCategoriesTheoMaDanhMucAndHienThi";
            cmd.Parameters.AddWithValue("@maDanhMuc", maDanhMuc);
            return SQLDB.SQLDB.GetData(cmd);
        }
        public DataTable laySubChildCategoriesTheoMaDanhMucHienThi(int maDanhMucCon , int viTri)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spLaySubChildCategoriesTheoMaDanhMucConAndViTriAndHienThi";
            cmd.Parameters.AddWithValue("@maDanhMucCon", maDanhMucCon);
            cmd.Parameters.AddWithValue("@viTri", viTri);
            return SQLDB.SQLDB.GetData(cmd);
        }
        


        public void insertCategories(string tenDanhMuc, string linkDanhMuc, string titleDanhMuc, string metaDescriptionDanhMuc, string metaKeywordsDanhMuc, DateTime ngayTao, bool hienThi, bool Active) 
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spInsertCategories";
            cmd.Parameters.AddWithValue("@tenDanhMuc", tenDanhMuc);
            cmd.Parameters.AddWithValue("@linkDanhMuc", linkDanhMuc);
            cmd.Parameters.AddWithValue("@titleDanhMuc", titleDanhMuc);
            cmd.Parameters.AddWithValue("@metaDescriptionDanhMuc", metaDescriptionDanhMuc);
            cmd.Parameters.AddWithValue("@metaKeywordsDanhMuc", metaKeywordsDanhMuc);
            cmd.Parameters.AddWithValue("@ngayTao", ngayTao);
            cmd.Parameters.AddWithValue("@hienThi", hienThi);
            cmd.Parameters.AddWithValue("@Active", Active);
            SQLDB.SQLDB.ExecuteNoneQuery(cmd);
        }
        public void updateCategories(int maDanhMuc,string tenDanhMuc, string linkDanhMuc, string titleDanhMuc, string metaDescriptionDanhMuc, string metaKeywordsDanhMuc, DateTime ngayTao, bool hienThi, bool Active)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spUpdateCategories";
            cmd.Parameters.AddWithValue("@maDanhMuc", maDanhMuc);
            cmd.Parameters.AddWithValue("@tenDanhMuc", tenDanhMuc);
            cmd.Parameters.AddWithValue("@linkDanhMuc", linkDanhMuc);
            cmd.Parameters.AddWithValue("@titleDanhMuc", titleDanhMuc);
            cmd.Parameters.AddWithValue("@metaDescriptionDanhMuc", metaDescriptionDanhMuc);
            cmd.Parameters.AddWithValue("@metaKeywordsDanhMuc", metaKeywordsDanhMuc);
            cmd.Parameters.AddWithValue("@ngayTao", ngayTao);
            cmd.Parameters.AddWithValue("@hienThi", hienThi);
            cmd.Parameters.AddWithValue("@Active", Active);
            SQLDB.SQLDB.ExecuteNoneQuery(cmd);
        }
        public void updateCatagoriesHienThi(int maDanhMuc, bool hienThi)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spUpdateHienThiCategories";
            cmd.Parameters.AddWithValue("@maDanhMuc", maDanhMuc);
            cmd.Parameters.AddWithValue("@hienThi", hienThi);
            SQLDB.SQLDB.ExecuteNoneQuery(cmd);
        }
     
        public void deleteDanhMuc(int maDanhMuc)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spDeleteCategories";
            cmd.Parameters.AddWithValue("@maDanhMuc", maDanhMuc);
            SQLDB.SQLDB.ExecuteNoneQuery(cmd);

        }

        public void insertPanertCategories(int maDanhMuc, string tenDanhMucCon,int viTri,string anhBiaDesktop,string anhBiaMobile, string linkDanhMucCon, string titleDanhMucCon, string metaDescriptionDanhMucCon, string metaKeywordsDanhMucCon, DateTime ngayTao, bool hienThi, bool Active) 
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spInsertCategoriesPanert";
            cmd.Parameters.AddWithValue("@maDanhMuc", maDanhMuc);
            cmd.Parameters.AddWithValue("@tenDanhMucCon", tenDanhMucCon);
            cmd.Parameters.AddWithValue("@viTri", viTri);
            cmd.Parameters.AddWithValue("@anhBiaDesktop", anhBiaDesktop);
            cmd.Parameters.AddWithValue("@anhBiaMobile", anhBiaMobile);
            cmd.Parameters.AddWithValue("@linkDanhMucCon", linkDanhMucCon);
            cmd.Parameters.AddWithValue("@titleDanhMucCon", titleDanhMucCon);
            cmd.Parameters.AddWithValue("@metaDescriptionDanhMucCon", metaDescriptionDanhMucCon);
            cmd.Parameters.AddWithValue("@metaKeywordsDanhMucCon", metaKeywordsDanhMucCon);
            cmd.Parameters.AddWithValue("@ngayTao", ngayTao);
            cmd.Parameters.AddWithValue("@hienThi", hienThi);
            cmd.Parameters.AddWithValue("@Active", Active);
            SQLDB.SQLDB.ExecuteNoneQuery(cmd);
        }

        public void updatePanertCategories(int maDanhMucCon,int maDanhMuc, string tenDanhMucCon, int viTri, string anhBiaDesktop, string anhBiaMobile, string linkDanhMucCon, string titleDanhMucCon, string metaDescriptionDanhMucCon, string metaKeywordsDanhMucCon, DateTime ngayTao, bool hienThi, bool Active)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spUpdateCategoriesPanert";
            cmd.Parameters.AddWithValue("@maDanhMucCon", maDanhMucCon);
            cmd.Parameters.AddWithValue("@maDanhMuc", maDanhMuc);
            cmd.Parameters.AddWithValue("@tenDanhMucCon", tenDanhMucCon);
            cmd.Parameters.AddWithValue(@"viTri", viTri);
            cmd.Parameters.AddWithValue("@anhBiaDesktop", anhBiaDesktop);
            cmd.Parameters.AddWithValue("@anhBiaMobile", anhBiaMobile);
            cmd.Parameters.AddWithValue("@linkDanhMucCon", linkDanhMucCon);
            cmd.Parameters.AddWithValue("@titleDanhMucCon", titleDanhMucCon);
            cmd.Parameters.AddWithValue("@metaDescriptionDanhMucCon", metaDescriptionDanhMucCon);
            cmd.Parameters.AddWithValue("@metaKeywordsDanhMucCon", metaKeywordsDanhMucCon);
            cmd.Parameters.AddWithValue("@ngayTao", ngayTao);
            cmd.Parameters.AddWithValue("@hienThi", hienThi);
            cmd.Parameters.AddWithValue("@Active", Active);
            SQLDB.SQLDB.ExecuteNoneQuery(cmd);
        }
        public void deletePanertCategories(int maDanhMucCon) {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spDeleteCategoriesPanert";
            cmd.Parameters.AddWithValue("@maDanhMucCon", maDanhMucCon);
            SQLDB.SQLDB.ExecuteNoneQuery(cmd);
        }
        public void insertChildCategories(int maDanhMucCon, string tenDanhMucConCap1, int viTri, string anhBiaDesktop, string anhBiaMobile, string linkDanhMucConCap1, string titleDanhMucConCap1, string metaDescriptionDanhMucConCap1, string metaKeywordsDanhMucConCap1,DateTime ngayTao, bool hienThi, bool Active)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spInsertCategoriesChild";
            cmd.Parameters.AddWithValue("@maDanhMucCon", maDanhMucCon);
            cmd.Parameters.AddWithValue("@tenDanhMucConCap1", tenDanhMucConCap1);
            cmd.Parameters.AddWithValue("@viTri", viTri);
            cmd.Parameters.AddWithValue("@anhBiaDesktop", anhBiaDesktop);
            cmd.Parameters.AddWithValue("@anhBiaMobile", anhBiaMobile);
            cmd.Parameters.AddWithValue("@linkDanhMucConCap1", linkDanhMucConCap1);
            cmd.Parameters.AddWithValue("@titleDanhMucConCap1", titleDanhMucConCap1);
            cmd.Parameters.AddWithValue("@metaDescriptionDanhMucConCap1", metaDescriptionDanhMucConCap1);
            cmd.Parameters.AddWithValue("@metaKeywordsDanhMucConCap1", metaKeywordsDanhMucConCap1);
            cmd.Parameters.AddWithValue("@ngayTao", ngayTao);
            cmd.Parameters.AddWithValue("@hienThi", hienThi);
            cmd.Parameters.AddWithValue("@Active", Active);
            SQLDB.SQLDB.ExecuteNoneQuery(cmd);
        }
        public void updateChildCategories(int maDanhMucConCap1,int maDanhMucCon, string tenDanhMucConCap1, int viTri, string anhBiaDesktop, string anhBiaMobile, string linkDanhMucConCap1, string titleDanhMucConCap1, string metaDescriptionDanhMucConCap1, string metaKeywordsDanhMucConCap1, DateTime ngayTao, bool hienThi, bool Active)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spUpdateCategoriesChild";
            cmd.Parameters.AddWithValue("@maDanhMucConCap1", maDanhMucConCap1);
            cmd.Parameters.AddWithValue("@maDanhMucCon", maDanhMucCon);
            cmd.Parameters.AddWithValue("@tenDanhMucConCap1", tenDanhMucConCap1);
            cmd.Parameters.AddWithValue("@viTri", viTri);
            cmd.Parameters.AddWithValue("@anhBiaDesktop", anhBiaDesktop);
            cmd.Parameters.AddWithValue("@anhBiaMobile", anhBiaMobile);
            cmd.Parameters.AddWithValue("@linkDanhMucConCap1", linkDanhMucConCap1);
            cmd.Parameters.AddWithValue("@titleDanhMucConCap1", titleDanhMucConCap1);
            cmd.Parameters.AddWithValue("@metaDescriptionDanhMucConCap1", metaDescriptionDanhMucConCap1);
            cmd.Parameters.AddWithValue("@metaKeywordsDanhMucConCap1", metaKeywordsDanhMucConCap1);
            cmd.Parameters.AddWithValue("@ngayTao", ngayTao);
            cmd.Parameters.AddWithValue("@hienThi", hienThi);
            cmd.Parameters.AddWithValue("@Active", Active);
            SQLDB.SQLDB.ExecuteNoneQuery(cmd);
        }
        public void deleteChildCategories(int maDanhMucConCap1)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spDeleteCategoriesChild";
            cmd.Parameters.AddWithValue("@maDanhMucConCap1", maDanhMucConCap1);
            SQLDB.SQLDB.ExecuteNoneQuery(cmd);
        }

       
    }
}
