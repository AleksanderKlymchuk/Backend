using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lesson01.Controllers
{
    public class Lesson01Controller : Controller
    {
        //
        // GET: /Lesson01/
        public ActionResult Index()
        {
            string name = "Oleksandr";
            int age = 28;
            DateTime birthday = new DateTime(1985, 12, 20);
            ViewBag.name = name;
            ViewBag.age = age;
            ViewBag.birthday = birthday.ToString("dd/MM/yyyy");
            return View();
        }
	}
}