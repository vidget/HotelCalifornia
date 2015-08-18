using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelCalifornia.Models
{
    public class RoomStyle
    {
        public int StyleID { get; set; }
        public int CustomerID { get; set; }
        public int RoomID { get; set; }
        public int wallPicture { get; set; }
        public int lampType { get; set; }
        public int rugStyle { get; set; }
        public int drapeStyle { get; set; }
        public int wallColor { get; set; }
        public int beddingStyle { get; set; } 


        public RoomStyle()
        {
            StyleID = 0;
            CustomerID = 0;
            RoomID = 0;
            wallPicture = 0;
            lampType = 0;
            rugStyle = 0;
            drapeStyle = 0;
            wallColor = 0;
            beddingStyle = 0;

        }





    }
}