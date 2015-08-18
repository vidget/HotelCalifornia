using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelCalifornia.Models
{
    public class RoomStyle
    {
        public int styleID { get; set; }
        public int customerID { get; set; }
        public int roomID { get; set; }
        public int wallPicture { get; set; }
        public int lampType { get; set; }
        public int rugStyle { get; set; }
        public int drapeStyle { get; set; }
        public int wallColor { get; set; }
        public int beddingStyle { get; set; } 


        public RoomStyle()
        {
            styleID = 0;
            customerID = 0;
            roomID = 0;
            wallPicture = 0;
            lampType = 0;
            rugStyle = 0;
            drapeStyle = 0;
            wallColor = 0;
            beddingStyle = 0;

        }





    }
}