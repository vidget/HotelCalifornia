using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelCalifornia.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; } 
        public DateTime hireDate { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zipCode { get; set; }
        public string phone { get; set; }
        public string ssNum { get; set; }
        public decimal payRate { get; set; }
        public int grade { get; set; }
        public string department { get; set; }
        public int exemptions { get; set; }
        
            public Employee()
            {
             EmployeeID = 0;
             hireDate = DateTime.Parse("0000-00-00");
             firstName ="";
             lastName ="";
             address ="";
             city = "";
             state = "";
             zipCode = "";
             phone = "";
             ssNum = "";
             payRate = 0.00M;
             grade = 0;
             department = "";
             exemptions = 0;
            }


        //public Employee(int _employeeID, string _firstName,string _lastName,string _address, int _userID)
        //{
        //    employeeID = _employeeID;
        //    firstName = _firstName;
        //    lastName = _lastName;
        //    address = _address;
        //    userID = _userID;
        //}

    }
}