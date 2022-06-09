using nguyeensport.dal;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace nguyeensport.Display.Unitl.account
{
    public partial class mydeltail : System.Web.UI.UserControl
    {
        //clsquanlytaikhoan _quanlytaikhoan = new clsquanlytaikhoan();
        //protected void Page_Load(object sender, EventArgs e)
        //{
        //    if(Session["username"]!= null)
        //    {
        //        DataTable dt = new DataTable();
        //        dt = _quanlytaikhoan.timAccountTheoTen(Session["email"].ToString());
        //        if(dt.Rows.Count > 0)
        //        {
        //            txtFullname.Text = dt.Rows[0]["Fullname"].ToString();
        //            txtEmail.Text = dt.Rows[0]["Email"].ToString();
        //            txtGioiTinh.Text = dt.Rows[0]["GioiTinh"].ToString();
        //            txtDiaChi.Text = dt.Rows[0]["DiaChi"].ToString();
        //            txtNgaySinh.Text = dt.Rows[0]["NgaySinh"].ToString();
        //            txtPassword.Text = dt.Rows[0]["Password"].ToString();
        //            txtSDT.Text = dt.Rows[0]["Phone"].ToString();
        //        }
        //    }
        //}

        //protected void btnLuuThongTin_Click(object sender, EventArgs e)
        //{
        //    DataTable dt = new DataTable();
        //    dt  = _quanlytaikhoan.timAccountTheoTen(Session["email"].ToString());
        //    if(dt.Rows.Count > 0)
        //    {
                
        //        _quanlytaikhoan.UpdateAccount2(int.Parse(dt.Rows[0]["ID"].ToString()), txtEmail.Text.Trim(), txtFullname.Text.Trim(), txtDiaChi.Text.Trim(),txtSDT.Text.Trim(), DateTime.Parse(txtNgaySinh.Text.Trim()), txtGioiTinh.Text.Trim());
        //    }
        //}

        //[Obsolete]
        //protected void btnLuuMatKhau_Click(object sender, EventArgs e)
        //{
        //    DataTable dt = new DataTable();
        //    string maHoa1 = FormsAuthentication.HashPasswordForStoringInConfigFile(txtPassword.Text, "SHA1");
        //    dt = _quanlytaikhoan.Login(Session["email"].ToString(),maHoa1);
        //    string maHoa2 = FormsAuthentication.HashPasswordForStoringInConfigFile(txtPasswordMoi.Text, "SHA1");
        //    if (dt.Rows.Count > 0)
        //    {
        //        _quanlytaikhoan.UpdateAccount3(int.Parse(dt.Rows[0]["ID"].ToString()), maHoa2);
        //    }
        //}
    }
}