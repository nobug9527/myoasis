using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
//using Newtonsoft.Json;
using System.Data;
//using System.Runtime.Serialization.Json;

namespace MvcApplication1.tools
{
    /// <summary>
    /// tools 的摘要说明
    /// </summary>
    public class tools:IHttpHandler
    {
        
        public void ProcessRequest(HttpContext context)
        {
            
            context.Response.ContentType = "text/plain";
            string action = HttpContext.Current.Request.QueryString["action"];
            //switch (action) 
            //{
            //    case "ckeditoruploadimage"
            //}
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }

        public JsonResult ckeditoruploadimage(HttpPostedFileBase upload) {
            string savePath = "/upload/";
            string dirPath = System.Web.HttpContext.Current.Server.MapPath(savePath);
            if (Directory.Exists(dirPath))
                Directory.CreateDirectory(dirPath);

            var fileName = Path.GetFileName(upload.FileName);
            //获取文件后缀名
            string fileExt = Path.GetExtension(fileName).ToLower();
            string newFileName = DateTime.Now.ToString("yyyyMMddHHmmss_ffff") + fileExt;
            upload.SaveAs(dirPath + "/" + newFileName);
            var returnjson = new JsonResult();

            returnjson.Data = new object[]{ new{upload=1},new{ fileName=newFileName},new{url=savePath+newFileName}};
            //{
            //    upload = 1,
            //    fileName = newFileName,
            //    url = savePath + newFileName
            //};
            returnjson.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            return returnjson;
        }

    }
}