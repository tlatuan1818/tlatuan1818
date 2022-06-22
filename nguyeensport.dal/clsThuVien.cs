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
using System.IO;
using System.Drawing.Imaging;
using ImageProcessor;
using ImageProcessor.Imaging.Formats;
using ImageProcessor.Plugins.WebP;
using ImageProcessor.Imaging;
using System.Drawing;
using TextLayer = ImageProcessor.Imaging.TextLayer;

using ImageProcessor.Plugins.WebP.Imaging.Formats;

namespace nguyeensport.dal
{
    public static class clsThuVien
    {
        private static Account account = new Account("nguyeensport", "324888837625318", "KvT6W4BgOZo2SfMmTTun9U0vYdc");
        private static Cloudinary cloudinary = new Cloudinary(account);
        public static string getConnect() {
            string cs = System.Configuration.ConfigurationManager.ConnectionStrings[@"DESKTOP-BK7A3DM\SQLEXPRESS"].ConnectionString; //"DESKTOP-BK7A3DM\SQLEXPRESS":"DESKTOP-36K6BVB\SQLEXPRESS"

            return cs;
        }
        public static string utf8Convert3(string s)
        {
            Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string temp = s.Normalize(NormalizationForm.FormD);
            return regex.Replace(temp, string.Empty).Replace('\u0111', 'd').Replace('\u0111', 'D');
        }
        public static DataTable dLookUp(string tenFiled, string tenTable, string tenBien)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select " + tenFiled + " from " + tenTable + " where " + tenFiled + " = " + tenBien + "";
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
        public static object uploadImagePorcess(string path, string outputPath, int width, int height)
        {
            string[] list = outputPath.Split('.');
            byte[] photoBytes = File.ReadAllBytes(System.Web.HttpContext.Current.Server.MapPath(path));
            // Format is automatically detected though can be changed.
            ISupportedImageFormat format = new WebPFormat();
            System.Drawing.Size size = new System.Drawing.Size(width, height);
            using (MemoryStream inStream = new MemoryStream(photoBytes))
            {

                // Initialize the ImageFactory using the overload to preserve EXIF metadata.
                using (ImageFactory imageFactory = new ImageFactory(preserveExifData: true))
                {
                    // Load, resize, set the format and quality and save an image.
                    imageFactory.Load(inStream)
                         .Rotate(0)
                         .RoundedCorners(new RoundedCornerLayer(10, false, false, false, false))
                         .Resize(size)
                         .Format(format)
                         .Quality(80)
                         .Save(System.Web.HttpContext.Current.Server.MapPath(list[0].ToString() + "-" + width.ToString() + "x" + height.ToString() + ".webp"));
                }
            }
            return list[0].ToString() + "-" + width.ToString() + "x" + height.ToString() + ".webp";

        }
 
        public static List<string> getImages(string image1, string image2, string image3, string image4, string image5, string image6, string image7, string image8, string image9, string image10, string TenSanPham, string fordelName)
        {
            String path = "";
            
            List<string> strPath = new List<string>();
            HttpFileCollection hfc = System.Web.HttpContext.Current.Request.Files;
            strPath.Insert(0,image1);
            strPath.Insert(1,image2);
            strPath.Insert(2,image3);
            strPath.Insert(3,image4);
            strPath.Insert(4,image5);
            strPath.Insert(5,image6);
            strPath.Insert(6,image7);
            strPath.Insert(7,image8);
            strPath.Insert(8,image9);
            strPath.Insert(9,image10);
            for (int i = 0; i < hfc.Count; i++)
            {
                HttpPostedFile hpf = hfc[i];

                if (hpf.ContentLength > 0)
                {
                     path = utf8Convert3(TenSanPham).ToLower().Replace(" ", "-").Replace("/", "-").Replace(".","") + "-" + i + Path.GetExtension(hpf.FileName);
                     //hpf.SaveAs(System.Web.HttpContext.Current.Server.MapPath("/images/"+fordelName+"/") + path);
                     
                    if (i == 0)
                     {
                         strPath.RemoveAt(i);
                         strPath.Insert(i, "/images/" + fordelName + "/" + path);
                     }
                     if (i == 1)
                     {
                        strPath.RemoveAt(i);
                        strPath.Insert(i, "/images/" + fordelName + "/" + path);
                     }
                     if (i == 2)
                     {
                        strPath.RemoveAt(i);
                        strPath.Insert(i, "/images/" + fordelName + "/" + path);
                     }
                     if (i == 3)
                     {
                        strPath.RemoveAt(i);
                        strPath.Insert(i, "/images/" + fordelName + "/" + path);
                     }
                     if (i == 4)
                     {
                        strPath.RemoveAt(i);
                        strPath.Insert(i, "/images/" + fordelName + "/" + path);
                     }
                     if (i == 5)
                     {
                        strPath.RemoveAt(i);
                        strPath.Insert(i, "/images/" + fordelName + "/" + path);
                     }
                     if (i == 6)
                     {
                        strPath.RemoveAt(i);
                        strPath.Insert(i, "/images/" + fordelName + "/" + path);
                     }
                     if (i == 7)
                     {
                        strPath.RemoveAt(i);
                        strPath.Insert(i, "/images/" + fordelName + "/" + path);
                     }
                     if (i == 8)
                     {
                        strPath.RemoveAt(i);
                        strPath.Insert(i, "/images/" + fordelName + "/" + path);
                     }
                     if (i == 9)
                     {
                        strPath.RemoveAt(i);
                        strPath.Insert(i, "/images/" + fordelName + "/" + path);
                     }
                }
              
            }
            if (!strPath[0].Equals(image1))
            {
                if (!image1.Equals(""))
                {
                    if (System.IO.File.Exists(System.Web.HttpContext.Current.Server.MapPath("~/images/"+fordelName+ image1)) == true)
                    {
                        System.IO.File.Exists(System.Web.HttpContext.Current.Server.MapPath("~/images/"+fordelName + image1));
                    }
                }
            }
            if (!strPath[1].Equals(image2))
            {
                if (!image2.Equals(""))
                {
                    if (System.IO.File.Exists(System.Web.HttpContext.Current.Server.MapPath("~/images/" + fordelName + image2)) == true)
                    {
                        System.IO.File.Exists(System.Web.HttpContext.Current.Server.MapPath("~/images/" + fordelName + image2));
                    }
                }
            }
            if (!strPath[2].Equals(image3))
            {
                if (!image3.Equals(""))
                {
                    if (System.IO.File.Exists(System.Web.HttpContext.Current.Server.MapPath("~/images/" + fordelName + image3)) == true)
                    {
                        System.IO.File.Exists(System.Web.HttpContext.Current.Server.MapPath("~/images/" + fordelName + image3));
                    }
                }
            }
            if (!strPath[3].Equals(image4))
            {
                if (!image4.Equals(""))
                {
                    if (System.IO.File.Exists(System.Web.HttpContext.Current.Server.MapPath("~/images/" + fordelName + image4)) == true)
                    {
                        System.IO.File.Exists(System.Web.HttpContext.Current.Server.MapPath("~/images/" + fordelName + image4));
                    }
                }
            }
            if (!strPath[4].Equals(image5))
            {
                if (!image5.Equals(""))
                {
                    if (System.IO.File.Exists(System.Web.HttpContext.Current.Server.MapPath("~/images/" + fordelName + image5)) == true)
                    {
                        System.IO.File.Exists(System.Web.HttpContext.Current.Server.MapPath("~/images/" + fordelName + image5));
                    }
                }
            }
            if (!strPath[5].Equals(image6))
            {
                if (!image6.Equals(""))
                {
                    if (System.IO.File.Exists(System.Web.HttpContext.Current.Server.MapPath("~/images/" + fordelName + image6)) == true)
                    {
                        System.IO.File.Exists(System.Web.HttpContext.Current.Server.MapPath("~/images/" + fordelName + image6));
                    }
                }
            }
            if (!strPath[6].Equals(image7))
            {
                if (!image7.Equals(""))
                {
                    if (System.IO.File.Exists(System.Web.HttpContext.Current.Server.MapPath("~/images/" + fordelName + image7)) == true)
                    {
                        System.IO.File.Exists(System.Web.HttpContext.Current.Server.MapPath("~/images/" + fordelName + image7));
                    }
                }
            }
            if (!strPath[7].Equals(image8))
            {
                if (!image8.Equals(""))
                {
                    if (System.IO.File.Exists(System.Web.HttpContext.Current.Server.MapPath("~/images/" + fordelName + image8)) == true)
                    {
                        System.IO.File.Exists(System.Web.HttpContext.Current.Server.MapPath("~/images/" + fordelName + image8));
                    }
                }
            }
            if (!strPath[8].Equals(image9))
            {
                if (!image9.Equals(""))
                {
                    if (System.IO.File.Exists(System.Web.HttpContext.Current.Server.MapPath("~/images/" + fordelName + image9)) == true)
                    {
                        System.IO.File.Exists(System.Web.HttpContext.Current.Server.MapPath("~/images/" + fordelName + image9));
                    }
                }
            }
            if (!strPath[9].Equals(image10))
            {
                if (!image10.Equals(""))
                {
                    if (System.IO.File.Exists(System.Web.HttpContext.Current.Server.MapPath("~/images/" + fordelName + image10)) == true)
                    {
                        System.IO.File.Exists(System.Web.HttpContext.Current.Server.MapPath("~/images/" + fordelName + image10));
                    }
                }
            }
            return strPath;
        }
        public static void deleteImage(string path)
        {

            if (System.IO.File.Exists(System.Web.HttpContext.Current.Server.MapPath("~/" + path)) == true)
            {
                System.IO.File.Delete(System.Web.HttpContext.Current.Server.MapPath("~/" + path));
            }
            string[] strPath = path.Split('.');
            if (System.IO.File.Exists(System.Web.HttpContext.Current.Server.MapPath("~/" + strPath[0].ToString() + "-123x123" + strPath[1].ToString())) == true);
            {
                System.IO.File.Delete(System.Web.HttpContext.Current.Server.MapPath("~/" + strPath[0].ToString() + "-123x123" + strPath[1].ToString()));
            }
        }
       
    }
}
