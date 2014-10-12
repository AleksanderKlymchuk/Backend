using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lesson02_Startup.Models;

namespace Lesson02_Startup.Controllers
{
    public class Exercise02Controller : Controller
    {
        //
        // GET: /Exercise02/

        public ActionResult Index()
        {
            List<Person> person = new List<Person>();
            person.Add(new Person("Oleksandr","Klymchuk","Ankjær205","8300","Odder"));
            person.Add(new Person("Tanja","Klymchuk","Ankjæer205","8300","Odder"));
            ViewBag.me = person;
            return View();
           
        }

    }
}
