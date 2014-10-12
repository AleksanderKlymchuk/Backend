using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lesson01.Controllers
{
    public class RockbandsController : Controller
    {
        //
        // GET: /Rockbands/
        public ActionResult Index()
        {
            string []Rockbands= {"The Beatles","OkeanElsu","Acheron","Absu","Aes Danna","Argent","The doors","Queen","Sex Pistols"};
            ViewBag.Rockbands = Rockbands;
            return View();
        }   
	}
}