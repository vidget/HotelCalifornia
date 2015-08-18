using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using HotelCalifornia.Models;


namespace HotelCalifornia.DAL
{
    public class HotelInitializer : System.Data.Entity. DropCreateDatabaseIfModelChanges<HotelContext>
    {

        protected override void Seed(HotelContext context)
        {
            // Employee MODEL:
            // employeeID,hireDate,firstName,lastName,address,city,state,zipCode,phone,ssNum,payRate,exemptions,grade,department
            
            var employee = new List<Employee>
            {
                new Employee
                {
                    EmployeeID = 1 ,
                    hireDate=DateTime.Parse("2005-09-01"),
                    firstName="Carson",
                    lastName="Alexander",
                    address="7324 St. Marys", 
                    city="Detroit",
                    state="Michigan",
                    ssNum="557-34-2143",
                    zipCode="48126",
                    phone="313-555-1212",
                    payRate=8.00M,
                    exemptions=1,
                    grade=2,
                    department="sales"
                },
   
                new Employee
                {
                    EmployeeID = 2 ,
                    hireDate=DateTime.Parse("2001-10-07"),
                    firstName="Butch",
                    lastName="Randolph",
                    address="321 Port St", 
                    city="Dearborn",
                    state="Michigan",
                    ssNum="357-32-1243",
                    zipCode="48126",
                    phone="313-555-1212",
                    payRate=8.50M,
                    exemptions=2,
                    department="finance"
                },
            
                 new Employee
                {
                    EmployeeID = 3 ,
                    hireDate=DateTime.Parse("1999-08-01"),
                    firstName="Tom",
                    lastName="Jones",
                    address="92312 Adams St", 
                    city="Inkster",
                    state="Michigan",
                    ssNum="379-12-6298",
                    zipCode="48141",
                    phone="313-555-1212",
                    payRate=9.50M,
                    exemptions=2,
                    department="legal"
                },

                 new Employee
                {
                    EmployeeID = 4 ,
                    hireDate=DateTime.Parse("1998-13-08"),
                    firstName="Elvis",
                    lastName="Jones",
                    address="2313 Boise St", 
                    city="Warren",
                    state="Michigan",
                    ssNum="232-11-8692",
                    zipCode="48088",
                    phone="313-555-1212",
                    payRate=15.50M,
                    exemptions=1,
                    department="legal"
                }
                       
            };

            employee.ForEach(s => context.Employees.Add(s));
            context.SaveChanges();

            //Customer MODEL:
            //customerID,firstName,lastName,address,city,state,zipCode,phone,email
            
            var customer = new List<Customer>
            {
                new Customer
                {
                   CustomerID = 1 ,
                    firstName="John",
                    lastName="Stark",
                    address="21345 Beech", 
                    city="Dearborn",
                    state="Michigan",
                    zipCode="48126",
                    phone="313-555-1212",
                    email="vidget@yahoo.com"
                    
                },

                new Customer
                {
                    CustomerID = 2 ,
                    firstName="Sally",
                    lastName="Wayneright",
                    address="2445 Allen Rd", 
                    city="Taylor",
                    state="Michigan",
                    zipCode="48180",
                    phone="313-555-1212",
                    email="sally@yahoo.com"
                    
                },

                new Customer
                {
                    CustomerID = 3 ,
                    firstName="Brandy",
                    lastName="Johnson",
                    address="21345 Hubbard", 
                    city="Troy",
                    state="Michigan",
                    zipCode="48007",
                    phone="313-555-1212",
                    email="vidget@yahoo.com"
                    
                },

                new Customer
                {
                    CustomerID = 4 ,
                    firstName="Stu",
                    lastName="Salamander",
                    address="245 Ellerude Rd", 
                    city="Birmingham",
                    state="Michigan",
                    zipCode="48009",
                    phone="313-555-1212",
                    email="stu@yahoo.com"
                    
                }


            };


            //Room MODEL:
            //roomID,type,rate

            customer.ForEach(s => context.Customers.Add(s));
            context.SaveChanges();

            var room = new List<Room> 
            
            { 
                new Room
                {
                     RoomID = 1,
                     type = "Penthouse",
                     rate = 400.00M
                },

                 new Room
                {
                     RoomID = 2,
                     type = "Suite",
                     rate = 300.00M
                },

                new Room
                {
                     RoomID = 3,
                     type = "King",
                     rate = 200.00M
                },

                 new Room
                {
                     RoomID = 4,
                     type = "Double",
                     rate = 150.00M
                },
                 new Room
                {
                     RoomID = 4,
                     type = "Single",
                     rate = 100.00M
                }
      
            };

            room.ForEach(s => context.Rooms.Add(s));
            context.SaveChanges();

            //Roomstyle Model:
            //StyleID,CustomerID,RoomID,wallPicture,lampType,rugStyle,drapeStyle,wallColor,beddingStyle

            var roomstyle = new List<RoomStyle>
            {

                new RoomStyle
                {
                    StyleID=1,
                    CustomerID=3,
                    RoomID=2,
                    wallPicture=1,
                    lampType=2,
                    rugStyle=1,
                    drapeStyle=4,
                    wallColor=3,
                    beddingStyle=3

                },

                new RoomStyle
                {
                    StyleID=2,
                    CustomerID=1,
                    RoomID=3,
                    wallPicture=2,
                    lampType=4,
                    rugStyle=3,
                    drapeStyle=4,
                    wallColor=3,
                    beddingStyle=2

                }



            };

            roomstyle.ForEach(s => context.RoomStyles.Add(s));
            context.SaveChanges();





            //Reservation MODEL:
            //reservationNumberID,customerID,roomID,roomNumber,dateBooked,dateCheckIn,dateCheckOut,employeeID,cost,discountRate



            var reservation = new List<Reservation>
            {
                new Reservation
                {
                reservationNumberID=1,
                customerID=2,
                roomID =2,
                roomNumber =212,
                dateBooked =DateTime.Parse("2015-13-08"),
                dateCheckIn =DateTime.Parse("2015-15-08"),
                dateCheckOut =DateTime.Parse("2015-17-08"),
                employeeID = 3,
                cost = 200.00M,
                discountRate = 0.05M
                },
                
                new Reservation
                {
                reservationNumberID=2,
                customerID=1,
                roomID =1,
                roomNumber =272,
                dateBooked =DateTime.Parse("2015-13-08"),
                dateCheckIn =DateTime.Parse("2015-15-08"),
                dateCheckOut =DateTime.Parse("2015-19-08"),
                employeeID = 2,
                cost = 400.00M,
                discountRate = 0.15M
                }

            };

            reservation.ForEach(s => context.Reservations.Add(s));
            context.SaveChanges();

        }
        
    }
}