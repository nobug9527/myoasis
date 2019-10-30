using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using my.BLL;
using Modle;
using Common;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.IO;
using System.Text;
using System.Data;
using System.Collections;
using System.ComponentModel;
using System.Collections.Generic;
using System.Web.Script.Serialization;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
using Modle;
using Newtonsoft.Json;
namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        my.BLL.Collect bll = new my.BLL.Collect();
        public ActionResult Index()
        {
            string token = Utils.getcookie("token");
            if (token == "")
            {
                return View("Login");
            }
            else {
                return PartialView();
            }
            
        }

        [HttpGet]
        public ActionResult Login() {
            return View();
        }

        [HttpPost]
        [ActionName("Login")]
        public ActionResult Login1(string name,string pwd) {
            if (name == "administrator" && pwd == "kexinizaoyiyuanqu")
            {
                Utils.writecookie("token", "true", 14400);
                return RedirectToAction("Index");

            }
            else {
                return View();
            }
        }

        public ActionResult LogOut() {
            Utils.writecookie("token", null, -14400);
            return RedirectToAction("Login", "Home");
        }

        public ActionResult Live2DTest() {
            return View();
        }

    }
}
