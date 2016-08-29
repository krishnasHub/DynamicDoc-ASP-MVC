using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DynamicDoc2.Controllers
{
    public class DynamicDocumentController : Controller
    {
        public JsonResult GetDynamicJson(bool isSuccess)
        {
            return GetDynamicJson(null, true, "", "");
        }
        public JsonResult GetDynamicJson(bool isSuccess, string error)
        {
            return GetDynamicJson(null, isSuccess, error, "");
        }

        public JsonResult GetDynamicJson(object obj)
        {
            return GetDynamicJson(obj, true, "", "");
        }

        public JsonResult GetDynamicJson(object obj, bool isSuccess, string error, string warning)
        {
            var ret = new Dictionary<string, object>();
            ret["isSuccess"] = isSuccess;
            ret["error"] = error;
            ret["warning"] = warning;

            if (obj != null)
            {
                Type t = obj.GetType();
                var p = t.GetProperties();

                for (int i = 0; i < p.Length; ++i)
                    ret[p[i].Name] = p[i].GetValue(obj);
            }
            


            return Json(ret, JsonRequestBehavior.AllowGet);
        }
    }
}