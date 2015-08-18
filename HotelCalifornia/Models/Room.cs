using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelCalifornia.Models
{
    public class Room
    {

        public int roomID { get; set; }
        public string type { get; set; }
        public decimal rate { get; set; }

        public Room()
        {
            roomID = 0;
            type = "";
            rate = 0.00M;
        }



    }
}