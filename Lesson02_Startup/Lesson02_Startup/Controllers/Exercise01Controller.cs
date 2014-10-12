using Lesson02_Startup.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lesson02_Startup.Controllers
{
    public class Exercise01Controller : Controller
    {
        

        public ActionResult Index()
        {
            // create a new product object with instance name glass
            Product glass = new Product("Wine glass", 160.50, "grandcru.jpg","Spain");
            ViewBag.Glass = glass;
            glass.Manufacturer = "Danmark";
            Product bin = new Product("knife", 120,"Spain");
            bin.Manufacturer = "Spain";

            Product knife = new Product("bin",134,"Ukraine");
            knife.Manufacturer = "Ukraine";
            ViewBag.Bin = bin;
            ViewBag.Knife = knife;
            
            List<Product> test = new List<Product>();
            List<string> f = new List<string>();
            f.Add("1");
            f.Add("2");
            f.Add("3");
            f.ElementAt(0);
            test.Add(knife);
          
            test.Select(r=>r.Manufacturer);
            Dictionary<string, string> names = new Dictionary<string, string>(); 


            
          
            return View();
        }

    }
}
