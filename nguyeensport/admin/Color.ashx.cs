using nguyeensport.dal;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;

namespace nguyeensport.admin
{
    /// <summary>
    /// Summary description for Color
    /// </summary>
    public class Color : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string term = context.Request["term"] ?? "";
            DataTable dtBrands = new DataTable();
          
            using (SqlConnection con = new SqlConnection(clsThuVien.getConnect()))
            {
                SqlCommand cmd = new SqlCommand("spLayColorTheoTen", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter()
                {
                    ParameterName = "@tenColor",
                    Value = term
                });
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dtBrands);

            }
            JavaScriptSerializer js = new JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in dtBrands.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dtBrands.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            context.Response.Write(js.Serialize(rows));
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}