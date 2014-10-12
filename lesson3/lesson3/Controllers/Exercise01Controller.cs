using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using lesson3.Models;

namespace lesson3.Controllers
{
    public class Exercise01Controller : Controller
    {
        
        //
        // GET: /Exercise01/
        public ActionResult Index()
        {

            MusicCD music = new MusicCD(1, "Music","Riky");
            music.AddTrack("1");
            Book book = new Book();
            Product product = new Product();
            book.Author = "Dot";
            book.Isbn = "is34345";
            book.Published = 2014;
            List<Product> pr = new List<Product>();
            pr.Add(book);
            pr.Add(music);
            ViewBag.prod=pr;
            return View();
        }
	}
}