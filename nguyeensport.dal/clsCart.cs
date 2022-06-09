using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nguyeensport.dal
{
    public class clsCart
    {
        static void ShoppingCart_CreateCart()
        { 
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(string));
            dt.Columns.Add("TenSanPham", typeof(string));
            dt.Columns.Add("urlSanPham", typeof(string));
            dt.Columns.Add("Avatar", typeof(string));
            dt.Columns.Add("Size", typeof(string));
            dt.Columns.Add("Nameset", typeof(string));
            dt.Columns.Add("Custom1", typeof(string));
            dt.Columns.Add("Custom2", typeof(string));
            dt.Columns.Add("DanhMuc", typeof(string));
            dt.Columns.Add("SoAo", typeof(string));
            dt.Columns.Add("Gia", typeof(float));
            dt.Columns.Add("In", typeof(string));
            dt.Columns.Add("SoLuong", typeof(int));
            dt.Columns.Add("Total", typeof(float));
            System.Web.HttpContext.Current.Session["cart"] = dt;
        }
        public void ShoppingCart_addCart(string ID, string urlSanPham,int Quantity, string Size,string Nameset, string SoAo,string Custom1,string Custom2,string DanhMuc,string In)
        {
            if (System.Web.HttpContext.Current.Session["cart"] == null)
            {
                ShoppingCart_CreateCart();
                ShoppingCart_addCart(ID, urlSanPham,Quantity, Size,Nameset,SoAo,Custom1, Custom2,DanhMuc,In);
            }
            else
            {
                DataTable dt = new DataTable();
                //dt = new clsquanlysanpham().timSanPhamTheoID(ID);
                if (dt.Rows.Count > 0)
                {
                    string name = dt.Rows[0]["TenSanPham"].ToString();
                    float gia = float.Parse(dt.Rows[0]["GiaCuoi"].ToString());
                    string img = dt.Rows[0]["Avatar"].ToString();


                    DataTable dtCart = new DataTable();
                    dtCart = (DataTable)System.Web.HttpContext.Current.Session["cart"];

                    bool hdInsert = false;
                    for (int i = 0; i < dtCart.Rows.Count; i++)
                    {
                        if (dtCart.Rows[i]["Nameset"].ToString() == Nameset.ToString() && dtCart.Rows[i]["SoAo"].ToString() == SoAo.ToString())
                        {
                            if (dtCart.Rows[i]["ID"].ToString() == ID.ToString() && dtCart.Rows[i]["Size"].ToString() == Size.ToString())
                            {
                                hdInsert = true;
                                Quantity += Convert.ToInt32(dtCart.Rows[i]["SoLuong"].ToString());
                                dtCart.Rows[i]["Size"] = Size;
                                dtCart.Rows[i]["SoLuong"] = Quantity;
                                dtCart.Rows[i]["Total"] = Quantity * Convert.ToSingle(dtCart.Rows[0]["Gia"].ToString());
                                System.Web.HttpContext.Current.Session["cart"] = dtCart;
                                break;
                            }
                        }
                    }
                    if (hdInsert == false)
                    {
                        if (dtCart != null)
                        {
                            if (Nameset != "" && SoAo != "")
                            {
                                if(Custom1 != "" || Custom2 !="")
                                {
                                    if (Custom1 !="" && Custom2 != "")
                                    {
                                        float kieuin;
                                        if (In == "In lụa")
                                        {
                                            kieuin = 15000;
                                            float total = (gia + kieuin + 40000) * Quantity;
                                            DataRow dr = dtCart.NewRow();
                                            dr["ID"] = ID;
                                            dr["TenSanPham"] = name;
                                            dr["urlSanPham"] = urlSanPham;
                                            dr["Avatar"] = img;
                                            dr["Size"] = Size;
                                            dr["SoLuong"] = Quantity;
                                            dr["Gia"] = gia;
                                            dr["Nameset"] = Nameset;
                                            dr["SoAo"] = SoAo;
                                            dr["Custom1"] = Custom1;
                                            dr["Custom2"] = Custom2;
                                            dr["In"] = In;
                                            dr["DanhMuc"] = DanhMuc;
                                            dr["Total"] = total;
                                            dtCart.Rows.Add(dr);
                                            System.Web.HttpContext.Current.Session["cart"] = dtCart;
                                        }
                                        else if (In == "Decal thường")
                                        {
                                            kieuin = 45000;
                                            float total = (gia + kieuin + 40000) * Quantity;
                                            DataRow dr = dtCart.NewRow();
                                            dr["ID"] = ID;
                                            dr["TenSanPham"] = name;
                                            dr["urlSanPham"] = urlSanPham;
                                            dr["Avatar"] = img;
                                            dr["Size"] = Size;
                                            dr["SoLuong"] = Quantity;
                                            dr["Gia"] = gia;
                                            dr["Nameset"] = Nameset;
                                            dr["SoAo"] = SoAo;
                                            dr["Custom1"] = Custom1;
                                            dr["Custom2"] = Custom2;
                                            dr["In"] = In;
                                            dr["DanhMuc"] = DanhMuc;
                                            dr["Total"] = total;
                                            dtCart.Rows.Add(dr);
                                            System.Web.HttpContext.Current.Session["cart"] = dtCart;
                                        }
                                        else if (In == "Decal xịn")
                                        {
                                            kieuin = 100000;
                                            float total = (gia + kieuin + 40000) * Quantity;
                                            DataRow dr = dtCart.NewRow();
                                            dr["ID"] = ID;
                                            dr["TenSanPham"] = name;
                                            dr["urlSanPham"] = urlSanPham;
                                            dr["Avatar"] = img;
                                            dr["Size"] = Size;
                                            dr["SoLuong"] = Quantity;
                                            dr["Gia"] = gia;
                                            dr["Nameset"] = Nameset;
                                            dr["SoAo"] = SoAo;
                                            dr["Custom1"] = Custom1;
                                            dr["Custom2"] = Custom2;
                                            dr["In"] = In;
                                            dr["DanhMuc"] = DanhMuc;
                                            dr["Total"] = total;
                                            dtCart.Rows.Add(dr);
                                            System.Web.HttpContext.Current.Session["cart"] = dtCart;
                                        }
                                    }
                                    else
                                    {
                                        float kieuin;
                                        if (In == "In lụa")
                                        {
                                            kieuin = 15000;
                                            float total = (gia + kieuin + 20000) * Quantity;
                                            DataRow dr = dtCart.NewRow();
                                            dr["ID"] = ID;
                                            dr["TenSanPham"] = name;
                                            dr["urlSanPham"] = urlSanPham;
                                            dr["Avatar"] = img;
                                            dr["Size"] = Size;
                                            dr["SoLuong"] = Quantity;
                                            dr["Gia"] = gia;
                                            dr["Nameset"] = Nameset;
                                            dr["SoAo"] = SoAo;
                                            dr["Custom1"] = Custom1;
                                            dr["Custom2"] = Custom2;
                                            dr["In"] = In;
                                            dr["DanhMuc"] = DanhMuc;
                                            dr["Total"] = total;
                                            dtCart.Rows.Add(dr);
                                            System.Web.HttpContext.Current.Session["cart"] = dtCart;
                                        }
                                        else if (In == "Decal thường")
                                        {
                                            kieuin = 45000;
                                            float total = (gia + kieuin + 20000) * Quantity;
                                            DataRow dr = dtCart.NewRow();
                                            dr["ID"] = ID;
                                            dr["TenSanPham"] = name;
                                            dr["urlSanPham"] = urlSanPham;
                                            dr["Avatar"] = img;
                                            dr["Size"] = Size;
                                            dr["SoLuong"] = Quantity;
                                            dr["Gia"] = gia;
                                            dr["Nameset"] = Nameset;
                                            dr["SoAo"] = SoAo;
                                            dr["Custom1"] = Custom1;
                                            dr["Custom2"] = Custom2;
                                            dr["In"] = In;
                                            dr["DanhMuc"] = DanhMuc;
                                            dr["Total"] = total;
                                            dtCart.Rows.Add(dr);
                                            System.Web.HttpContext.Current.Session["cart"] = dtCart;
                                        }
                                        else if (In == "Decal xịn")
                                        {
                                            kieuin = 100000;
                                            float total = (gia + kieuin + 20000) * Quantity;
                                            DataRow dr = dtCart.NewRow();
                                            dr["ID"] = ID;
                                            dr["TenSanPham"] = name;
                                            dr["urlSanPham"] = urlSanPham;
                                            dr["Avatar"] = img;
                                            dr["Size"] = Size;
                                            dr["SoLuong"] = Quantity;
                                            dr["Gia"] = gia;
                                            dr["Nameset"] = Nameset;
                                            dr["SoAo"] = SoAo;
                                            dr["Custom1"] = Custom1;
                                            dr["Custom2"] = Custom2;
                                            dr["In"] = In;
                                            dr["DanhMuc"] = DanhMuc;
                                            dr["Total"] = total;
                                            dtCart.Rows.Add(dr);
                                            System.Web.HttpContext.Current.Session["cart"] = dtCart;
                                        }
                                        
                                    }
                                    
                                }
                                else
                                {
                                    float kieuin;
                                    if(In == "In lụa")
                                    {
                                        kieuin = 15000;
                                        float total = (gia + kieuin) * Quantity;
                                        DataRow dr = dtCart.NewRow();
                                        dr["ID"] = ID;
                                        dr["TenSanPham"] = name;
                                        dr["urlSanPham"] = urlSanPham;
                                        dr["Avatar"] = img;
                                        dr["Size"] = Size;
                                        dr["SoLuong"] = Quantity;
                                        dr["Gia"] = gia;
                                        dr["Nameset"] = Nameset;
                                        dr["SoAo"] = SoAo;
                                        dr["Custom1"] = Custom1;
                                        dr["Custom2"] = Custom2;
                                        dr["In"] = In;
                                        dr["DanhMuc"] = DanhMuc;
                                        dr["Total"] = total;
                                        dtCart.Rows.Add(dr);
                                        System.Web.HttpContext.Current.Session["cart"] = dtCart;
                                    }
                                    else if(In == "Decal thường")
                                    {
                                        kieuin = 45000;
                                        float total = (gia + kieuin) * Quantity;
                                        DataRow dr = dtCart.NewRow();
                                        dr["ID"] = ID;
                                        dr["TenSanPham"] = name;
                                        dr["urlSanPham"] = urlSanPham;
                                        dr["Avatar"] = img;
                                        dr["Size"] = Size;
                                        dr["SoLuong"] = Quantity;
                                        dr["Gia"] = gia;
                                        dr["Nameset"] = Nameset;
                                        dr["SoAo"] = SoAo;
                                        dr["Custom1"] = Custom1;
                                        dr["Custom2"] = Custom2;
                                        dr["In"] = In;
                                        dr["DanhMuc"] = DanhMuc;
                                        dr["Total"] = total;
                                        dtCart.Rows.Add(dr);
                                        System.Web.HttpContext.Current.Session["cart"] = dtCart;
                                    }
                                    else if(In == "Decal xịn")
                                    {
                                        kieuin = 100000;
                                        float total = (gia + kieuin) * Quantity;
                                        DataRow dr = dtCart.NewRow();
                                        dr["ID"] = ID;
                                        dr["TenSanPham"] = name;
                                        dr["urlSanPham"] = urlSanPham;
                                        dr["Avatar"] = img;
                                        dr["Size"] = Size;
                                        dr["SoLuong"] = Quantity;
                                        dr["Gia"] = gia;
                                        dr["Nameset"] = Nameset;
                                        dr["SoAo"] = SoAo;
                                        dr["Custom1"] = Custom1;
                                        dr["Custom2"] = Custom2;
                                        dr["In"] = In;
                                        dr["DanhMuc"] = DanhMuc;
                                        dr["Total"] = total;
                                        dtCart.Rows.Add(dr);
                                        System.Web.HttpContext.Current.Session["cart"] = dtCart;
                                    }
                                }
                                 
                            }
                            else
                            {
                                float total = gia * Quantity;
                                DataRow dr = dtCart.NewRow();
                                dr["ID"] = ID;
                                dr["TenSanPham"] = name;
                                dr["urlSanPham"] = urlSanPham;
                                dr["Avatar"] = img;
                                dr["Size"] = Size;
                                dr["SoLuong"] = Quantity;
                                dr["Gia"] = gia;
                                dr["Nameset"] = Nameset;
                                dr["SoAo"] = SoAo;
                                dr["Custom1"] = Custom1;
                                dr["Custom2"] = Custom2;
                                dr["DanhMuc"] = DanhMuc;
                                
                                dr["Total"] = total;
                                dtCart.Rows.Add(dr);
                                System.Web.HttpContext.Current.Session["cart"] = dtCart;
                            }
                        }
                    }
                }
            }
        }
        public void ShoppingCart_UpdateCart(string ID, int Quantity)
        {
            DataTable dtCart = new DataTable();
            dtCart = (DataTable)System.Web.HttpContext.Current.Session["cart"];
            for (int i = 0; i < dtCart.Rows.Count; i++)
            {
                if (dtCart.Rows[i]["ID"].ToString() == ID.ToString())
                {

                    dtCart.Rows[i]["SoLuong"] = Quantity;
                    dtCart.Rows[i]["Total"] = Quantity * Convert.ToSingle(dtCart.Rows[0]["Gia"].ToString());
                    break;
                }
            }
            System.Web.HttpContext.Current.Session["cart"] = dtCart;

        }
        public void ShoppingCart_RemoveCart(string ID)
        {
            DataTable dtCart = new DataTable();
            dtCart = (DataTable)System.Web.HttpContext.Current.Session["cart"];

            for (int i = 0; i < dtCart.Rows.Count; i++)
            {
                if (dtCart.Rows[i]["ID"].ToString() == ID.ToString())
                {
                    dtCart.Rows.RemoveAt(i);
                    break;
                }
            }
            System.Web.HttpContext.Current.Session["cart"] = dtCart;
        }
    }
}
