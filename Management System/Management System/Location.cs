using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_System
{
    class Location
    {
        public int LocationID { get; set; }
        public int CampingID { get; set; }
        public int ReservationID { get; set; } // this int = 0 means that the location has not yet been reserved
        public LocationType Type { get; set; }
        public int Price { get; set; }
        public int MaxPeople { get; set; }

        public Location(int locationID, int campingID, int reservationID/*, LocationType locationType*/, int price, int maxPeople)
        {
            LocationID = locationID;
            CampingID = campingID;
            ReservationID = reservationID;
            //Type = locationType;
            Price = price;

        }

        public override string ToString()
        {
            return "LocationID: " + LocationID.ToString() + ", Price: " + Price.ToString() + ", Max People: " + MaxPeople.ToString();
        }
    }
}
