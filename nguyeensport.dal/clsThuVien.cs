using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using System.Text.RegularExpressions;

namespace nguyeensport.dal
{
    public static class clsThuVien
    {
        private static Account account = new Account("nguyeensport", "324888837625318", "KvT6W4BgOZo2SfMmTTun9U0vYdc");
        private static Cloudinary cloudinary = new Cloudinary(account);

        public static string utf8Convert3(string s)
        {
            Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string temp = s.Normalize(NormalizationForm.FormD);
            return regex.Replace(temp, string.Empty).Replace('\u0111', 'd').Replace('\u0111', 'D');
        }
        public static DataTable dLookUp (string tenFiled, string tenTable, string tenBien)
        {      
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select "+tenFiled +" from "+tenTable+" where "+tenFiled+ " = "+tenBien+"";
            return SQLDB.SQLDB.GetData(cmd);
        }
        public static void updateHienThi(string tenTable, string tenField, int ma, bool hienThi)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update " + tenTable + " set hienThi = '" + hienThi + "' where " + tenField + "= " + ma + "";
            SQLDB.SQLDB.ExecuteNoneQuery(cmd);
        }
        public static void updateActive(string tenTable, string tenField, int ma, bool hienThi)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update " + tenTable + " set Active = '" + hienThi + "' where " + tenField + "= " + ma + "";
            SQLDB.SQLDB.ExecuteNoneQuery(cmd);
        }

        public static string uploadImage(string path, HttpPostedFile hpf)
        {
            cloudinary.Api.Secure = true;
            var uploadParams = new ImageUploadParams()
            {
                File = new FileDescription(path, hpf.InputStream),
                PublicId = path,
                Overwrite = true,
            };
            var uploadResult = cloudinary.Upload(uploadParams);

            return cloudinary.Api.UrlImgUp.Transform(new Transformation().FetchFormat("webp").Quality("80")).UseRootPath(true).BuildUrl(path + ".jpg");
        }

        public static void deleteImage(string PublicId)
        {
            cloudinary.Api.Secure = true;
            DeletionParams deletionParams = new DeletionParams(PublicId)
            {
                ResourceType = ResourceType.Image
            };
            var deletionResult = cloudinary.Destroy(deletionParams);
        }
       
    }
}
