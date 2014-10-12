using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ViewModel.Models
{
    public class Customer
    {
        public int C_id { get; set; }
        [Required]
      
        public string FirstName { get; set; }


         [Required]
        public string LastName { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string City { get; set; }
         [Required]
        public string Zip { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DataType(DataType.PhoneNumber)]
        [StringLength(8), Required]
        public string Phone { get; set; }


        public Customer()
        { }


        public Customer(string firstname, string lastname, string address, string city, string email, string phone)
        {
            this.Address = address;
            this.City = city;
            this.Email = email;
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Phone = phone;



        }



    }
}