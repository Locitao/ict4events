using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationApp
{
    class Event
    {
        /// <summary>
        /// First the properties, then a constructor.
        /// </summary>
        public int EventID { get; set; }
        public string Name { get; set; }


        /// <summary>
        /// Two lists, one to keep track of reservations
        /// and one to keep track of all the material available at the event
        /// </summary>
        public List<Reservation> Reservations = new List<Reservation>();
        public List<Material> allMaterials = new List<Material>(); 
         

        public Event(string name, int eventId, Camping camping)
        {
            name = Name;
            eventId = EventID;
            camping = new Camping("Test name", "Groesbeek", "google it");

        }
        /// <summary>
        /// Reserve lets the user reserve a location and possibly materials.
        /// </summary>
        public void Reserve(Location location)
        {
            int locationId;
            string type;
            bool reserved;
            Reservations.Add(new Reservation(1));
        }
    }
}
