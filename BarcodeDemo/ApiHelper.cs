using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraBars;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BarcodeDemo
{
    public static class ApiHelper
    {
        public static string PostApi(Uri url, string value)
        {
            var request = HttpWebRequest.Create(url);
            var byteData = Encoding.ASCII.GetBytes(value);
            request.ContentType = "application/json";
            request.Method = "POST";

            try
            {
                using (var stream = request.GetRequestStream())
                {
                    stream.Write(byteData, 0, byteData.Length);
                }
                var response = (HttpWebResponse)request.GetResponse();
                var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

                return responseString;
            }
            catch (WebException e)
            {
                return null;
            }
        }

        public static string PostApiJ(Uri url, string value)
        {
            try
            {
                var httpWebRequest = (HttpWebRequest) WebRequest.Create(url);
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "POST";

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {

                    streamWriter.Write(value);
                    streamWriter.Flush();
                    streamWriter.Close();
                }

                var httpResponse = (HttpWebResponse) httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    return result;
                }
            }
            catch
            {
                return null;
            }
        }
        public static string GetApi(Uri url)
        {
            var request = HttpWebRequest.Create(url);
            request.Method = "GET";

            try
            {
                var response = (HttpWebResponse)request.GetResponse();
                var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

                return responseString;
            }
            catch (WebException e)
            {
                return null;
            }
        }
        

        public static List<T> ParseJsonObject<T>(string json) where T : class, new()
        {
            //JObject jobject = JObject.Parse(json);
            //return JsonConvert.DeserializeObject<T>(jobject.ToString());
            return JsonConvert.DeserializeObject<List<T>>(json);
        }

        public static  List<ProductLabelInfoOutput> getComboProductLabel(int ProdID)
        {
            List<ProductLabelInfoOutput> lst = new List<ProductLabelInfoOutput>();
            Uri url = new Uri("https://check.net.vn/plcservice/get_productlabel.aspx?Product_ID=" + ProdID.ToString());
            string jsonValues = ApiHelper.GetApi(url);
            if (jsonValues != null)
            {
                lst = ApiHelper.ParseJsonObject<ProductLabelInfoOutput>(jsonValues);
            }
            return lst;
        }

        public static class UserInfo
        {
            public static Guid LoginID { get; set; }
            public static string AccountType { get; set; }
            public static string UserName { get; set; }
            public static string FullName { get; set; }
            public static int Factory_ID { get; set; }
        }

        public static string CheckExistSerial(string SerialStart, string SerialEnd)
        {
            string url = String.Format("https://check.net.vn/plcservice/get_qrcodeduplicate.aspx?SerialNumberStart={0}&SerialNumberEnd={1}",SerialStart,SerialEnd);
            Uri urli = new Uri(url);
            return GetApi(urli);
        }
        public static string CheckExistSerial(string Serial)
        {
            string url = @"https://check.net.vn/plcservice/get_qrcodeduplicatebyrange.aspx";
            Uri urli = new Uri(url);
            return PostApiJ(urli,Serial);
        }
        public static string GetListstrSerial(string Serial)
        {
            string url = @"https://check.net.vn/plcservice/get_qrcodebyrange.aspx";
            Uri urli = new Uri(url);
            return PostApiJ(urli, Serial);
        }
    }
    

}
