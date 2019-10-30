using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Common
{
    public static class Utils
    {
        public static void writecookie(string strname, string value, int expires)
        {
            HttpCookie cookie = HttpContext.Current.Request.Cookies["strname"];
            if (cookie == null)
            {
                cookie = new HttpCookie(strname);
            }
            cookie.Value = HttpContext.Current.Server.UrlEncode(value);
            //cookie.Value = value;
            cookie.Expires = DateTime.Now.AddMinutes(expires);
            HttpContext.Current.Response.AppendCookie(cookie);
        }

        public static string getcookie(string strname)
        {
            if (HttpContext.Current.Request.Cookies != null && HttpContext.Current.Request.Cookies[strname] != null)
            {
                return HttpContext.Current.Server.UrlDecode(HttpContext.Current.Request.Cookies[strname].Value.ToString());
                //return HttpContext.Current.Request.Cookies[strname].Value.ToString();
            }
            return "";
        }
    }
}
