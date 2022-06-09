using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nguyeensport.dal
{
    public class clsquanlydanhmuctintuc
    {
        public DataTable layNews()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spLayNews";
            return SQLDB.SQLDB.GetData(cmd);
        }
        public DataTable layNewsTheoID(int maNews)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spLayNewstheoID";
            cmd.Parameters.AddWithValue("@maNews", maNews);
            return SQLDB.SQLDB.GetData(cmd);
        }
        public DataTable layNewsDeltailTheoHienThi()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spLayNewsDeltailTheoHienThi";
            return SQLDB.SQLDB.GetData(cmd);
        }
        public DataTable layTop6NewsDeltailTheoHienThi() {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spLayTop6NewsDeltailTheoHienThi";
            return SQLDB.SQLDB.GetData(cmd);
        }
        public DataTable layNewDeltail()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spLayNewsDeltail";
            return SQLDB.SQLDB.GetData(cmd);
        }
        public DataTable layNewsDeltailTheoID(int maNewsDeltail)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spLayNewsDeltailTheoID";
            cmd.Parameters.AddWithValue("@maNewsDeltail", maNewsDeltail);
            return SQLDB.SQLDB.GetData(cmd);
        }
        public DataTable layNewsDeltailKhac(int maNewsDeltail)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spLayNewsDeltailKhac";
            cmd.Parameters.AddWithValue("@maNewsDeltail", maNewsDeltail);
            return SQLDB.SQLDB.GetData(cmd);
        }
        public DataTable layNewsDeltailTheoLinkNewsDeltail(string linkNewsDeltail)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spLayNewsDeltailTheoLink";
            cmd.Parameters.AddWithValue("@linkNewsDeltail", linkNewsDeltail);
            return SQLDB.SQLDB.GetData(cmd);
        }
        public DataTable layNewsDeltailTheoLinkNews(string linkNews)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spLayNewsDeltailTheoLinkNews";
            cmd.Parameters.AddWithValue("@linkNews", linkNews);
            return SQLDB.SQLDB.GetData(cmd);
        }

        public void insertNews(string tenNews, string linkNews, string titleNews, string metaDescriptionNews, string metaKeyword, bool hienThi, bool Active)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spInsertNews";
            cmd.Parameters.AddWithValue("@tenNews", tenNews);
            cmd.Parameters.AddWithValue("@linkNews", linkNews);
            cmd.Parameters.AddWithValue("@titleNews", titleNews);
            cmd.Parameters.AddWithValue("@metaDescriptionNews", metaDescriptionNews);
            cmd.Parameters.AddWithValue("@metaKeyword", metaKeyword);
            cmd.Parameters.AddWithValue("@hienThi", hienThi);
            cmd.Parameters.AddWithValue("@Active", Active);
            SQLDB.SQLDB.ExecuteNoneQuery(cmd);
        }
        public void updateNews(int maNews,string tenNews, string linkNews, string titleNews, string metaDescriptionNews, string metaKeyword, bool hienThi, bool Active)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spUpdateNews";
            cmd.Parameters.AddWithValue("@maNews", maNews);
            cmd.Parameters.AddWithValue("@tenNews", tenNews);
            cmd.Parameters.AddWithValue("@linkNews", linkNews);
            cmd.Parameters.AddWithValue("@titleNews", titleNews);
            cmd.Parameters.AddWithValue("@metaDescriptionNews", metaDescriptionNews);
            cmd.Parameters.AddWithValue("@metaKeyword", metaKeyword);
            cmd.Parameters.AddWithValue("@hienThi", hienThi);
            cmd.Parameters.AddWithValue("@Active", Active);
            SQLDB.SQLDB.ExecuteNoneQuery(cmd);
        }
        public void deleteNews(int maNews)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spDeteleNews";
            cmd.Parameters.AddWithValue("@maNews", maNews);
            SQLDB.SQLDB.ExecuteNoneQuery(cmd);
        }
        public void insertNewsDeltail(string tenNews, string tenNewsDeltail, string noiDung, string linkNewsDeltail, string titleNewsDeltail, string metaDescriptionNews,string metaKeyword, string avatarNewsDeltail,string avatarNewsDeltailHome, string images1, string images2, string images3, string images4, string images5, string images6, string images7, string linkProduct, string imagesProductQC,string imagesProductQCMobile, int luotView, DateTime ngayTao, bool hienThi, bool Active)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spInsertNewsDeltail";
            cmd.Parameters.AddWithValue("@tenNews", tenNews);
            cmd.Parameters.AddWithValue("@tenNewsDeltail", tenNewsDeltail);
            cmd.Parameters.AddWithValue("@noiDung", noiDung);
            cmd.Parameters.AddWithValue("@linkNewsDeltail",linkNewsDeltail);
            cmd.Parameters.AddWithValue("@titleNewsDeltail", titleNewsDeltail);
            cmd.Parameters.AddWithValue("@metaDescriptionNews", metaDescriptionNews);
            cmd.Parameters.AddWithValue("@metaKeyword", metaKeyword);
            cmd.Parameters.AddWithValue("@avatarNewsDeltail", avatarNewsDeltail);
            cmd.Parameters.AddWithValue("@avatarNewsDeltailHome",avatarNewsDeltailHome);
            cmd.Parameters.AddWithValue("@images1", images1);
            cmd.Parameters.AddWithValue("@images2", images2);
            cmd.Parameters.AddWithValue("@images3", images3);
            cmd.Parameters.AddWithValue("@images4", images4);
            cmd.Parameters.AddWithValue("@images5", images5);
            cmd.Parameters.AddWithValue("@images6", images6);
            cmd.Parameters.AddWithValue("@images7", images7);
            cmd.Parameters.AddWithValue("@linkProduct", linkProduct);
            cmd.Parameters.AddWithValue("@imagesProductQC", imagesProductQC);
            cmd.Parameters.AddWithValue("@imagesProductQCMobile", imagesProductQCMobile);
            cmd.Parameters.AddWithValue("@luotView", luotView);
            cmd.Parameters.AddWithValue("@ngayTao", ngayTao);
            cmd.Parameters.AddWithValue("@hienThi", hienThi);
            cmd.Parameters.AddWithValue("@Active", Active);
            SQLDB.SQLDB.ExecuteNoneQuery(cmd);
        }
        public void updateNewsDeltail(int maNewsDeltail,string tenNews, string tenNewsDeltail, string noiDung, string linkNewsDeltail, string titleNewsDeltail, string metaKeyword,string metaDescriptionNews, string avatarNewsDeltail, string avatarNewsDeltailHome, string images1, string images2, string images3, string images4, string images5, string images6, string images7, string linkProduct, string imagesProductQC,string imagesProductQCMobile, int luotView, DateTime ngayTao, bool hienThi, bool Active)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spUpdateNewsDeltail";
            cmd.Parameters.AddWithValue("@maNewsDeltail", maNewsDeltail);
            cmd.Parameters.AddWithValue("@tenNews", tenNews);
            cmd.Parameters.AddWithValue("@tenNewsDeltail", tenNewsDeltail);
            cmd.Parameters.AddWithValue("@noiDung", noiDung);
            cmd.Parameters.AddWithValue("@linkNewsDeltail", linkNewsDeltail);
            cmd.Parameters.AddWithValue("@titleNewsDeltail", titleNewsDeltail);
            cmd.Parameters.AddWithValue("@metaDescriptionNews", metaDescriptionNews);
            cmd.Parameters.AddWithValue("@metaKeyword", metaKeyword);
            cmd.Parameters.AddWithValue("@avatarNewsDeltail", avatarNewsDeltail);
            cmd.Parameters.AddWithValue("@avatarNewsDeltailHome", avatarNewsDeltailHome);
            cmd.Parameters.AddWithValue("@images1", images1);
            cmd.Parameters.AddWithValue("@images2", images2);
            cmd.Parameters.AddWithValue("@images3", images3);
            cmd.Parameters.AddWithValue("@images4", images4);
            cmd.Parameters.AddWithValue("@images5", images5);
            cmd.Parameters.AddWithValue("@images6", images6);
            cmd.Parameters.AddWithValue("@images7", images7);
            cmd.Parameters.AddWithValue("@linkProduct", linkProduct);
            cmd.Parameters.AddWithValue("@imagesProductQC", imagesProductQC);
            cmd.Parameters.AddWithValue("@imagesProductQCMobile", imagesProductQCMobile);
            cmd.Parameters.AddWithValue("@luotView", luotView);
            cmd.Parameters.AddWithValue("@ngayTao", ngayTao);
            cmd.Parameters.AddWithValue("@hienThi", hienThi);
            cmd.Parameters.AddWithValue("@Active", Active);
            SQLDB.SQLDB.ExecuteNoneQuery(cmd);
        }
        public void updateLuotViewNewsDeltail(int maNewsDeltail, int luotView) {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spUpdateLuotViewsNewsDetail";
            cmd.Parameters.AddWithValue("@maNewsDeltail", maNewsDeltail);
            cmd.Parameters.AddWithValue("@luotView", luotView);
            SQLDB.SQLDB.ExecuteNoneQuery(cmd);
        }
        public void deleteNewsDeltail(int maNewsDeltail)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spDeleteNewsDeltail";
            cmd.Parameters.AddWithValue("@maNewsDeltail", maNewsDeltail);
            SQLDB.SQLDB.ExecuteNoneQuery(cmd);
        }


    }
}
