using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lesson02_Startup.Models;
using System.Threading;

namespace Lesson02_Startup.Controllers
{
    public class DiceController : Controller
    {
        //
        // GET: /Dice/
        [HttpGet]
        public ActionResult Index()
        {
            int[] start = new int[] { };
            ViewBag.distribution = start;
            ViewBag.distribution1 = start;
            ViewBag.distribution2 = start;
            
            return View("index");
        }
        [HttpGet]
        public ActionResult Clear()
    {

        Session.RemoveAll();
        return View("index");

    }
        
        [HttpGet]
        public ActionResult Roll()
        {

           
            Random rnd = new Random();
            int i = rnd.Next(1, 7);
            double d = rnd.NextDouble();
            if (Session["dice"] == null)
            {

                Dice dice = new Dice();
                dice.Roll(i);
                Session["dice"] = dice;
                ViewBag.outcome = dice.Eyes;
                ViewBag.numroll = dice.NumRoll;
                ViewBag.totalsum = dice.TotalSum;
                ViewBag.evaragescore = dice.TotalSum / dice.NumRoll;
               
                ViewBag.distribution = dice.Distribution;

            }
            else
            {
                Dice dice = (Dice)Session["dice"];
                dice.Roll(i);
                ViewBag.outcome = dice.Eyes;
                ViewBag.numroll = dice.NumRoll;
                ViewBag.totalsum = dice.TotalSum;
                ViewBag.evaragescore = dice.TotalSum / dice.NumRoll;
               
                ViewBag.distribution = dice.Distribution;
            
            }
            
            //List<Dice> getdiceinfo = new List<Dice>();

            // 
           
        

            return View("index");
        }



        [HttpGet]
        public ActionResult TwoRoll()
        {

            Random rnd1 = new Random();
            int i = rnd1.Next(1, 7);
            Thread.Sleep(2000);
            Random rnd2 = new Random();
            int b = rnd2.Next(1,7);
           
            if (Session["dice1"] == null && Session["dice2"]==null)
            {

                Dice dice1 = new Dice();
                dice1.Roll(i);
                Session["dice1"] = dice1;
                ViewBag.outcome1 = dice1.Eyes;
                ViewBag.numroll1 = dice1.NumRoll;
                
                ViewBag.distribution1 = dice1.Distribution;

                Dice dice2 = new Dice();
                dice2.Roll(b);
                Session["dice2"] = dice2;
                ViewBag.outcome2 = dice2.Eyes;
                ViewBag.numroll2 = dice2.NumRoll;
                

                ViewBag.totalsum1 = dice1.TotalSum + dice2.TotalSum;
                ViewBag.evaragescore1 = (dice1.TotalSum + dice2.TotalSum) / dice1.NumRoll;
                ViewBag.distribution2 = dice2.Distribution;

            }
            else
            {
                Dice dice1 = (Dice)Session["dice1"];
                dice1.Roll(i);
                ViewBag.outcome1 = dice1.Eyes;
                ViewBag.numroll1 = dice1.NumRoll;
                
                

                ViewBag.distribution1 = dice1.Distribution;
                Dice dice2 = (Dice)Session["dice2"];
                dice2.Roll(b);
                ViewBag.outcome2 = dice2.Eyes;
                ViewBag.numroll2 = dice2.NumRoll;
                


                ViewBag.totalsum1 = dice1.TotalSum + dice2.TotalSum;
                ViewBag.evaragescore1 = (dice1.TotalSum + dice2.TotalSum) / dice1.NumRoll;

                ViewBag.distribution2 = dice2.Distribution;

            }


            return View("index");
        }
        
    }
}
