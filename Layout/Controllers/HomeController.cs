using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Layout.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            return View();
        }
        [ChildActionOnly]
       public ActionResult _MainMenu()
        {
            string[] menu = { "Home", "Contact", "Service", "Reservation" };

            return PartialView(menu);
        }
        [ChildActionOnly]
        public ActionResult ret()
    {
         return View()

    }



	}
}