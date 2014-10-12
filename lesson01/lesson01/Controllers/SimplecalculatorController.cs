using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lesson01.Controllers
{
    public class SimplecalculatorController : Controller
    {
        //
        // GET: /Simplecalculator/
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(FormCollection formcollection)
        {  
             int v1;
             int v2;
             int sum = 0;
             string result = null;



             if (formcollection["firstvalue"] != "" && formcollection["secondvalue"] != "" && formcollection!=null)
        {
           v1 = Convert.ToInt32(formcollection["firstvalue"]);
           v2 = Convert.ToInt32(formcollection["secondvalue"]);
          
           string oper = formcollection["operator"];
           if (oper == "+")
           {
               sum = v1 + v2;
           }
           else if (oper == "-")
           {
               sum = v1 - v2;
           }
           else if (oper == "*")
           {
               sum = v1 * v2;

           }
           else if (oper == "/")
           {
               sum = v1 / v2;

           }
           result = sum.ToString();
        }

            
            
            ViewBag.test=result;
            return View();
        }
	}
}