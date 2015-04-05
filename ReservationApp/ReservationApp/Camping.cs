using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationApp
{
    class Camping
    {
        /// <summary>
        /// First the properties, then a constructor.
        /// </summary>
        public string Name { get; set; }
        public string Place { get; set; }
        public string MapPath { get; set; }

        public List<Location> locations = new List<Location>();

        public Camping(string name, string place, string mapPath)
        {
            name = Name;
            place = Place;
            mapPath = MapPath;
        }
    }
}
