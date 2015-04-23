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

        /// <summary>
        /// This class is similar to a row in the database table PT_EVENT_LOCATION
        /// </summary>
        /// <param name="locationID">The ID of this location</param>
        /// <param name="campingID">The ID of the camping this location is on</param>
        /// <param name="reservationID">The ID from the reservation that includes this location</param>
        /// <param name="locationType">The locationType of this location</param>
        /// <param name="price">The price of this location</param>
        /// <param name="maxPeople">The maximum amount of people that can sleep on this location</param>
        public Location(int locationID, int campingID, int reservationID, LocationType locationType, int price, int maxPeople)
        {
            LocationID = locationID;
            CampingID = campingID;
            ReservationID = reservationID;
            Type = locationType;
            Price = price;
            MaxPeople = maxPeople;
        }

        public override string ToString()
        {
            return "LocationID: " + LocationID.ToString() + ", Price: " + Price.ToString() + ", Max People: " + MaxPeople.ToString() + ", Type: " +Type.ToString();
        }
    }
}
