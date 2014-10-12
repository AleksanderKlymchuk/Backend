using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lesson02_Startup.Models
{
    public class Inherit:Product
    {
        public Inherit(string name, double price, string manufacturer):base(name,price,manufacturer)
        {



        }



    }
}