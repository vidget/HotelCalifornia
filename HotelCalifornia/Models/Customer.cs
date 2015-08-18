using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelCalifornia.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zipCode { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        
        
        public Customer()
        {
            CustomerID = 0;
            firstName = "";
            lastName = "";
            address = "";
            city = "";
            state = "";
            zipCode = "";
            phone = "";
            email = "";
            
        }

        //public Customer( int _customerID, string _firstName, string _lastName, string _address, string _state, string _zip, string _phone )
        //{
        //    customerID = _customerID;
        //    firstName = _firstName;
        //    lastName = _lastName;
        //    address = _address;
        //    state = _state;
        //    zip = _zip;
        //    phone = _phone;
        //}


    }
}