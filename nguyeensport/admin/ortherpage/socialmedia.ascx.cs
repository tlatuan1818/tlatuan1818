using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Facebook;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace nguyeensport.admin.ortherpage
{
    public partial class socialmedia : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CheckAuthorization();
        }
        public DataTable  Tabulate(string json)
        {
            var jsonLinq = JObject.Parse(json);

            // Find the first array using Linq
            var srcArray = jsonLinq.Descendants().Where(d => d is JArray).First();
            var trgArray = new JArray();
            foreach (JObject row in srcArray.Children<JObject>())
            {
                var cleanRow = new JObject();
                foreach (JProperty column in row.Properties())
                {
                    // Only include JValue types
                    if (column.Value is JValue)
                    {
                        cleanRow.Add(column.Name, column.Value);
                    }
                }

                trgArray.Add(cleanRow);
            }

            return JsonConvert.DeserializeObject<DataTable>(trgArray.ToString());
        }
        private void CheckAuthorization()
        {
            string app_id = "828465094768129";
            string app_secret = "0f5c7dc339e587e354c8131ba1a32adf";
            string scope = " publish_actions,pages_show_list, pages_read_engagement, pages_manage_metadata, pages_read_user_content,  pages_manage_posts, pages_manage_engagement, public_profile";
            if (Request["code"] == null)
            {
                Response.Redirect(string.Format("https://www.facebook.com/v13.0/dialog/oauth?client_id={0}&redirect_uri={1}&state={2}"
                    , app_id, Request.Url.AbsoluteUri, scope));
            }
            else
            {
                Dictionary<string, string> tokens = new Dictionary<string, string>();
                //string url = string.Format("https://graph.facebook.com/oauth/access_token?client_id={0}&redirect_uri={1}&scope={2}&code={3}&client_secret={4}",app_id, Request.Url.AbsoluteUri,scope,Request["code"].ToString(),app_secret);

                //HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
                //string token;
                //using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                //{
                //    StreamReader reader = new StreamReader(response.GetResponseStream());
                //    var vals = reader.ReadToEnd();
                //    var arr = vals.Split(':').ToArray();
                //    token = arr[1].Split(',').First();
                //    token = token.Substring(1);
                //    token = token.Substring(0, token.Length - 1);
                //}
                var client = new FacebookClient("EAABsbCS1iHgBAEfNe7ftczrMp3LyZBY46v8ZB1ZCVAv9OMAkwvgfZAUJg4hhVny510gDcvYbeBemcCVx53BPg7OXwo3Q3bIn1jVl32ticZASndRRt4WONLF95So7VmT9hZAqmELhfQF4sWgRNyPPQQ5UBhoQCgtU9yiP7YINsZBCAZDZD");
                dynamic d = client.Get("me/accounts", new { fields = "id" });
                string id = d.data[2].id;
            

                rptPost.DataSource = Tabulate(client.Get("" + id + "/feed", new { fields = "message,full_picture" }).ToString());
                rptPost.DataBind();

            }
        }
    }
}