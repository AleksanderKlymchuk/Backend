using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lesson02_Startup.Models
{
    public class Person
    {
        private string firstname;
        public  string Firstname
        {
            get {

                return firstname; 
            }
            set {
                firstname = value;
            }
        }
        private string lastname;
        public string Lastname
        {
            get
            {

                return lastname;
            }
            set
            {
                lastname = value;
            }
        }
        private string address;
        public string Address
        {
            get
            {

                return address;
            }
            set
            {
                address = value;
            }
        }
        private string zip;
        public string Zip
        {
            get
            {

                return zip;
            }
            set
            {
                zip= value;
            }
        }
        private string city;
        public string City
        {
            get
            {

                return city;
            }
            set
            {
                city= value;
            }
        }
        public Person(string firstname,string lastname,string address, string zip,string city)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.address = address;
            this.zip = zip;
            this.city =city;
         
        }

      

    }
}