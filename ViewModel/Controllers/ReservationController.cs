using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewModel.ViewModels;

namespace ViewModel.Controllers
{
    public class ReservationController : Controller
    {
        //
        // GET: /Reservation/
        public ActionResult Index()
        {

            Reservation reserv = new Reservation();
            reserv.PopulatePricelist();

            return View(reserv);
        }
        [HttpPost]
        public ActionResult MakeReservation(Reservation reserv)
        {
           

            return View(reserv);

           
          

        }
      
    }
}