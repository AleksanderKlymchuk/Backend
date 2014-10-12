using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ViewModel.Controllers
{
    public class pricelistController : Controller
    {
        private Dictionary<string, decimal> priceList = new Dictionary<string, decimal>();

         
        //
        // GET: /pricelist/
      
        public ActionResult Index()
        {

            priceList.Add("Dog",200);
            priceList.Add("Cat", 140);
            priceList.Add("Canary", 60);
            priceList.Add("Chinchila", 180);
            priceList.Add("Iguana", 160);
            priceList.Add("Rabbit", 90);
            priceList.Add("Hamster", 80);
            ViewBag.pricelist = priceList;
            return View();
        }
	}
}