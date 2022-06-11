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
        public static string uploadImagePorcess(string path) 
        {

            byte[] photoBytes = File.ReadAllBytes(path);
            // Format is automatically detected though can be changed.
            ISupportedImageFormat format = new JpegFormat { Quality = 70 };
            System.Drawing.Size size = new System.Drawing.Size(150, 150);
            using (MemoryStream inStream = new MemoryStream(photoBytes))
            {
                using (MemoryStream outStream = new MemoryStream())
                {
                    // Initialize the ImageFactory using the overload to preserve EXIF metadata.
                    using (ImageFactory imageFactory = new ImageFactory(preserveExifData: true))
                    {
                        // Load, resize, set the format and quality and save an image.
                        imageFactory.Load(inStream)
                                    .Resize(size)
                                    .Format(format)
                                    .Save(outStream);
                        return imageFactory.ToString();
                    }
                   
                    // Do something with the stream.
                }
            }
          
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
        public static List<string> getImages(string image1, string image2, string image3, string image4, string image5, string image6, string image7, string image8, string image9, string image10, string TenSanPham)
        {
            String path = "";
            List<string> strPath = new List<string>();
            HttpFileCollection hfc = HttpContext.Current.Request.Files;
            strPath.Insert(0, uploadImagePorcess(HttpContext.Current.Server.MapPath(@"~"+ image1)));
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
                     path = utf8Convert3(TenSanPham).ToLower().Replace(" ", "-").Replace("/", "-") + "-" + i;

                     if (i == 0)
                     {
                         strPath.RemoveAt(i);
                         strPath.Insert(i, uploadImagePorcess(hpf.FileName));
                     }
                     if (i == 1)
                     {
                        strPath.RemoveAt(i);
                        strPath.Insert(i, uploadImage(path, hpf));
                     }
                     if (i == 2)
                     {
                        strPath.RemoveAt(i);
                        strPath.Insert(i, uploadImage(path, hpf));
                     }
                     if (i == 3)
                     {
                        strPath.RemoveAt(i);
                        strPath.Insert(i, uploadImage(path, hpf));
                     }
                     if (i == 4)
                     {
                        strPath.RemoveAt(i);
                        strPath.Insert(i, uploadImage(path, hpf));
                     }
                     if (i == 5)
                     {
                        strPath.RemoveAt(i);
                        strPath.Insert(i, uploadImage(path, hpf));
                     }
                     if (i == 6)
                     {
                        strPath.RemoveAt(i);
                        strPath.Insert(i, uploadImage(path, hpf));
                     }
                     if (i == 7)
                     {
                        strPath.RemoveAt(i);
                        strPath.Insert(i, uploadImage(path, hpf));
                     }
                     if (i == 8)
                     {
                        strPath.RemoveAt(i);
                        strPath.Insert(i, uploadImage(path, hpf));
                     }
                     if (i == 9)
                     {
                        strPath.RemoveAt(i);
                        strPath.Insert(i, uploadImage(path, hpf));
                     }
                }
              
            }
            
           
            return strPath;
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
