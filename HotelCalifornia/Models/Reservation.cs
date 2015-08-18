using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelCalifornia.Models
{
    public class Reservation
    {

        public int reservationNumberID   { get; set; }
        public int customerID { get; set; }
        public int roomID { get; set; }
        public DateTime dateBooked { get; set; }
        public DateTime dateCheckIn { get; set; }
        public DateTime dateCheckOut { get; set; }
        public int employeeID { get; set; }
        public decimal cost { get; set; }
        public decimal discountRate { get; set; }


        public Reservation()
        {
            reservationNumberID = 0;
            customerID = 0;
            roomID = 0;
            dateBooked = DateTime.Parse("0000-00-00");
            dateCheckIn = DateTime.Parse("0000-00-00");
            dateCheckOut = DateTime.Parse("0000-00-00");
            employeeID = 0;
            cost = 0.00M;
            discountRate = 0.00M;

        }





    }
}