using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationApp
{
    class Location
    {
        /// <summary>
        /// Again, first the properties then a constructor.
        /// </summary>
        public int LocationId { get; set; }
        public string Type { get; set; }
        public bool Reserved { get; set; }

        public Location(int locationId, string type, bool reserved)
        {
            locationId = LocationId;
            type = Type;
            reserved = Reserved;
        }
    }
}
