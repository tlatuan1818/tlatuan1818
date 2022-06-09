using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace nguyeensport.dal
{
    public class clsquanlyslider
    {
        public DataTable laySlider()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spLaySlider";
            return SQLDB.SQLDB.GetData(cmd);
        }
        public DataTable laySliderTheoID(int maSlider)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spLaySliderTheoID";
            cmd.Parameters.AddWithValue("@maSlider", maSlider);
            return SQLDB.SQLDB.GetData(cmd);
        }
        public DataTable layTop5Slider()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spLayTop5Slider";
            return SQLDB.SQLDB.GetData(cmd);
        }
        public DataTable layTop5SliderTheoMaDanhMuc(int maDanhMuc)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spLayTop5SliderTheoMaDanhMuc";
            cmd.Parameters.AddWithValue("@maDanhMuc", maDanhMuc);
            return SQLDB.SQLDB.GetData(cmd);
        }

        public void insertSlider(string tenSlider, string desSlider, string linkSlider, string imageSliderDesktop,string imageSliderMobile, int maDanhMuc, DateTime ngayTao, bool hienThi, bool Active)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spInsertSlider";
            cmd.Parameters.AddWithValue("@tenSlider", tenSlider);
            cmd.Parameters.AddWithValue("@desSlider", desSlider);
            cmd.Parameters.AddWithValue("@linkSlider", linkSlider);
            cmd.Parameters.AddWithValue("@imageSliderDesktop", imageSliderDesktop);
            cmd.Parameters.AddWithValue("@imageSliderMobile", imageSliderMobile);
            cmd.Parameters.AddWithValue("@maDanhMuc", maDanhMuc);
            cmd.Parameters.AddWithValue("@ngayTao", ngayTao);
            cmd.Parameters.AddWithValue("@hienThi", hienThi);
            cmd.Parameters.AddWithValue("@Active", Active);
            SQLDB.SQLDB.ExecuteNoneQuery(cmd);
        }
        public void updateSlider(int maSlider,string tenSlider, string desSlider, string linkSlider, string imageSliderDesktop, string imageSliderMobile, int maDanhMuc, bool hienThi, bool Active)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spUpdateSlider";
            cmd.Parameters.AddWithValue("@maSlider", maSlider);
            cmd.Parameters.AddWithValue("@tenSlider", tenSlider);
            cmd.Parameters.AddWithValue("@desSlider", desSlider);
            cmd.Parameters.AddWithValue("@linkSlider", linkSlider);
            cmd.Parameters.AddWithValue("@imageSliderDesktop", imageSliderDesktop);
            cmd.Parameters.AddWithValue("@imageSliderMobile", imageSliderMobile);
            cmd.Parameters.AddWithValue("@maDanhMuc", maDanhMuc);
            cmd.Parameters.AddWithValue("@hienThi", hienThi);
            cmd.Parameters.AddWithValue("@Active", Active);
            SQLDB.SQLDB.ExecuteNoneQuery(cmd);
        }
        public void deleteSlider(int maSlider)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spDeleteSlider";
            cmd.Parameters.AddWithValue("@maSlider", maSlider);
            SQLDB.SQLDB.ExecuteNoneQuery(cmd);
        }
    }
}
