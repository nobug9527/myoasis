﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using my.BLL;
using System.Data;

namespace MvcApplication1.Controllers
{
    public class NoteController : Controller
    {
        //
        // GET: /Note/
        my.BLL.Note bll = new Note();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Note()
        {
            return View();
        }

        public ActionResult NoteTypeList() 
        {
            DataTable list = bll.GetNoteTypeList();
            return PartialView(list);
        }

        public ActionResult AddNoteTypeModal() 
        {
            return PartialView();
        }

        public ActionResult AddNoteType() 
        {
            string name = Request.Form.Get("name");
            bll.AddNoteType(name);
            return RedirectToAction("NoteTypeList");
        }

        [ValidateInput(false)]
        public ActionResult NoteList(int typeid) 
        {
            string content = Request.Form.Get("notecontent");
            if (content != "" && content != null) {
                bll.AddNote(typeid, content);
            }
            DataTable list = bll.GetNoteContentBytypeid(typeid);
            ViewBag.typeid = typeid;
            return PartialView(list);
        }

        [HttpGet]
        public ActionResult editnote(int id) {
            string str = bll.GetEditContentById(id);
            ViewBag.noteid = id;
            return PartialView();
        }

        [HttpPost]
        [ActionName("editnote")]
        [ValidateInput(false)]
        public ActionResult editnote1() {
            int id = Convert.ToInt32(Request.Form.Get("id"));
            string content = Request.Form.Get("notecontent");
            bll.ModifyNoteContent(id, content);
            return RedirectToAction("Index","Home");
        }

        public JsonResult getcontentedit(int id) { 
            string str = bll.GetEditContentById(id);
            return Json(str);
        }


    }
}
