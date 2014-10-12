using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ViewModel.Models
{
    public class Invoices
    {
        public int InvoiceId { get; set; }
        public DateTime OrderDate { get; set; }
        public Invoices Invoice { get; set; }
        public Customer Customer { get; set; }
        private decimal totalprice;
        public decimal TotalPrice { get { return totalprice; } }
        public List<OrderItem> OrderItems = new List<OrderItem>();


        public Invoices()
        {



        }



        public  Invoices (DateTime orderdate, Invoices invoice, Customer customer, decimal tPrice, List<OrderItem> orderitmes)
        {
            this.Customer = customer;
            this.Invoice = invoice;
            this.OrderDate = orderdate;
            this.OrderItems = orderitmes;


        }


    }
}
/*- InvoiceId: int
- OrderDate: DateTime
- Customer: Customer
- OrderItems: List<OrderItem>
- TotalPrice: decimal (read-only)*/