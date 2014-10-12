using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lesson3.Models
{
    public class Book:Product
    {
      
        public string Author { get; set; }
        public string Publisher { get; set; }
        public string Isbn { get; set; }
        public short Published { get; set; }

       
        
    }
}