using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ViewModel.Models
{
    public class OrderItem

    {
        public int C_id { get; set; }
        public string Spiece { get; set; }
        public string Petname { get; set; }
        public DateTime Arrival { get; set; }
        public DateTime Departure { get; set; }
        public decimal PricePerDay { get; set; }
        public Invoices Invoice { get; set; }
        private Dictionary<string, decimal> pricelist = new Dictionary<string, decimal>();
        public Dictionary<string, decimal> Pricelist { get { return pricelist; } }


        public OrderItem()
        {
           
           
        }



        public OrderItem (string spice,string petname,DateTime arrival, DateTime departure,decimal priceperday, Invoices invoice)
        {
            
           


        }


    }
}
/*Specie: string
- Petname: string
- Arrival: DateTime
- Departure: DateTime
- PricePerDay: decimal
- Invoice: Invoice*/