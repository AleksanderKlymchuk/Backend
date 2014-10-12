using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lesson01.Controllers
{
    public class TimecalculatorController : Controller
    {
        //
        // GET: /Timecalculator/
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult calculate(FormCollection formcollection)
        {

            int hr =Convert.ToInt32( formcollection["Hours"]);
            
            int min = Convert.ToInt32(formcollection["Minutes"]);
            int sec = Convert.ToInt32(formcollection["Seconds"]);
            int resultinseconds=(hr*60*60)+(min*60)+sec;
           /* TimeSpan cal = TimeSpan.FromSeconds(resultinseconds);*/
            ViewBag.result = resultinseconds;
            ViewBag.hours = formcollection["Hours"];
            ViewBag.minutes = formcollection["Minutes"];
            ViewBag.seconds=formcollection["Seconds"];
            return View();
        }
	}
}