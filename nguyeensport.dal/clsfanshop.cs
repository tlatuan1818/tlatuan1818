using System.Data;

namespace nguyeensport.dal
{
    public class clsfanshop
    {
        static void ShoppingCart_CreateCart()
        {

            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(string));
            dt.Columns.Add("Nameset", typeof(string));
            dt.Columns.Add("SoAo", typeof(string));
            dt.Columns.Add("PatchLeft", typeof(string));
            dt.Columns.Add("PatchRight", typeof(string));
            dt.Columns.Add("Font", typeof(string));
            dt.Columns.Add("In", typeof(string));
            dt.Columns.Add("DanhMuc", typeof(string));
            System.Web.HttpContext.Current.Session["fanshop"] = dt;

        }
        public void ShoppingCart_addCart(string ID,string Nameset,string SoAo,string PatchLeft,string PatchRight,string Font,string In,string DanhMuc)
        {
            if (System.Web.HttpContext.Current.Session["fanshop"] == null)
            {
                ShoppingCart_CreateCart();
                ShoppingCart_addCart(ID, Nameset, SoAo, PatchLeft,PatchRight,Font,In,DanhMuc);
            }
            else
            {
                DataTable dt = new DataTable();
                //dt = new clsquanlysanpham().timSanPhamTheoID(ID);
                if (dt.Rows.Count > 0)
                {

                    DataTable dtfanshop = new DataTable();
                    dtfanshop = (DataTable)System.Web.HttpContext.Current.Session["fanshop"];

                    bool hdInsert = false;
                    
                    if (hdInsert == false)
                    {
                        if (dtfanshop != null)
                        {
                            DataRow dr = dtfanshop.NewRow();
                            dr["ID"] = ID;
                            dr["Nameset"] = Nameset;
                            dr["SoAo"] = SoAo;
                            dr["PatchLeft"] = PatchLeft;
                            dr["PatchRight"] = PatchRight;
                            dr["Font"] = Font;
                            dr["In"] = In;
                            dr["DanhMuc"] = DanhMuc;
                            dtfanshop.Rows.Add(dr);
                            System.Web.HttpContext.Current.Session["fanshop"] = dtfanshop;
                        }
                    }
                }
            }
        }
    }
}
