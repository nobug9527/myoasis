using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using my.BLL;
using System.Data;
using Newtonsoft.Json;
using System.IO;
using System.Text;
using System.Net;
using System.Net.Security;
using Modle;
using System.Security.Cryptography.X509Certificates;
namespace MvcApplication1.Controllers
{
    public class DiaryController : Controller
    {
        //
        // GET: /Diary/
        my.BLL.Diary bll = new Diary();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Diary() {
            return PartialView();
        }

        public ActionResult AddMonthModal() {
            return PartialView();
        }

        public ActionResult DiaryMonthList() {
            DataTable list = bll.GetMonthList();
            return PartialView(list);
        }

        [ValidateInput(false)]
        public ActionResult ShowDiary(int monthid) {
            
            string diarycontent = Request.Form.Get("diarycontent");
            if (diarycontent != "" && diarycontent != null)
            {
                string host = "https://iweather.market.alicloudapi.com";
                string path = "/address";
                string method = "GET";
                string appcode = "fe56f02cfff64b699dba44ed98547c51";
                string querys = "city=%e9%83%91%e5%b7%9e&needday=1&prov=%e6%b2%b3%e5%8d%97";
                string url = host + path + "?" + querys;
                HttpWebRequest httpRequest = null;
                HttpWebResponse httpResponse = null;
                ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(CheckValidationResult);
                httpRequest = (HttpWebRequest)WebRequest.CreateDefault(new Uri(url));
                httpRequest.Method = method;
                httpRequest.Headers.Add("Authorization", "APPCODE " + appcode);
                try
                {
                    httpResponse = (HttpWebResponse)httpRequest.GetResponse();
                }
                catch (WebException ex)
                {
                    httpResponse = (HttpWebResponse)ex.Response;
                }
                Stream st = httpResponse.GetResponseStream();
                StreamReader reader = new StreamReader(st, Encoding.GetEncoding("utf-8"));
                string json = reader.ReadToEnd().ToString();
                Root rt = JsonConvert.DeserializeObject<Root>(json);
                //Response.Write(json);
                string weather = rt.data.now.detail.weather;
                string date = DateTime.Now.ToString("D");
                bll.AddDiary(monthid, diarycontent, date,weather);
            }
            DataTable list = bll.GetDiaryByMonthId(monthid);
            ViewBag.monthid = monthid;
            return PartialView(list); 
        }

        public ActionResult AddMonth() {
            string monthname = Request.Form.Get("monthname");
            bll.AddMonth(monthname);
            return RedirectToAction("DiaryMonthList");
        }

        public static bool CheckValidationResult(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors errors)
        {
            return true;
        }

    }
}
