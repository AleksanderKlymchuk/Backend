using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ViewModel.Models;


namespace ViewModel.ViewModels
{
    public class Reservation
    {
        public Customer Customer { get; set; } 
        public Invoices Invoice { get; set; } 
        public OrderItem OrderItem { get; set; } 
        //public Dictionary<string, decimal> Pricelist { get; set; }
        public Reservation() { 
        Customer = new Customer(); 
        Invoice = new Invoices(); 
        OrderItem = new OrderItem();
        //Pricelist = new Dictionary<string, decimal>();
        }


        public void PopulatePricelist()
        {
           
            OrderItem.Pricelist.Add("Dog", 200);
            OrderItem.Pricelist.Add("Cat", 140);
            OrderItem.Pricelist.Add("Canary", 60);
            OrderItem.Pricelist.Add("Chinchila", 180);
            OrderItem.Pricelist.Add("Iguana", 160);
            OrderItem.Pricelist.Add("Rabbit", 90);
            OrderItem.Pricelist.Add("Hamster", 80);



           }

    }
}