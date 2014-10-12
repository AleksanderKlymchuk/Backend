using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Lesson02_Startup;


namespace Lesson02_Startup.Models {
    public class Product {
        private string name; // field
        private string manufacturer;
        public string Name // property
        {
            get { return name; }
            //set { name = value; }
        }

        
       
        
        public string Manufacturer
        {
            get { return manufacturer; }
            set { manufacturer = value; }
          
        }

        private double price; // field
        public double Price // property
        {
            // 
            set {
                if (value <= 0) {
                    throw new Exception("Price is not accepted");
                }
                else {
                    price = value;
                }
            }
            get { return price; }
        }


        private string imageUrl; // field
        public string ImageUrl // property
        {
            get { return imageUrl; }
            set { imageUrl = value; }
        }

        // constructor 1
        public Product(string name, double price, string manufacturer) {
            this.name = name;
            this.price = price;
            this.manufacturer = manufacturer;
            
        }

        // constructor 2
        public Product(string name, double price, string imageUrl,string manufacture) {
            this.name = name;
            this.price = price;
            this.imageUrl = imageUrl;
            this.manufacturer = manufacture;
        }
    }
}