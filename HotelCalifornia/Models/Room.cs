using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelCalifornia.Models
{
    public class Room
    {

        public int RoomID { get; set; }
        public string type { get; set; }
        public decimal rate { get; set; }

        public Room()
        {
            RoomID = 0;
            type = "";
            rate = 0.00M;
        }



    }
}