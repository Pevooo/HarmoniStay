﻿namespace MainProject.Models
{
    public class Room
    {
        public int RoomID { get; set; }

        public int RoomBuildingNumber { get; set; }

        public string RoomType { get; set; } // Regular Room / Suite / Chalet / etc...

        public string RoomCategory { get; set; } // Single / Double / Triple / etc...

        public virtual ICollection<Transaction> RoomTransactionts { get; set; }
        
        public virtual ICollection<Booking> RoomBookings { get; set; }
    }
}
