using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class CollectController : Controller
    {
        //
        // GET: /Collect/

        my.BLL.Collect bll = new my.BLL.Collect();

        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Collect()
        {
            return View();
        }

        public ActionResult CollectList()
        {
            List<Modle.Collect> list = bll.GetList();
            return PartialView(list);
        }

        public ActionResult AddCollectModal()
        {
            return PartialView();
        }

        public ActionResult CollectAdd(Modle.Collect modle)
        {
            bll.Add(modle.name, modle.url);
            return RedirectToAction("CollectList");
        }

        public ActionResult delete(int id) 
        {
            bll.delete(id);
            return RedirectToAction("CollectList");
        }
    }
}
