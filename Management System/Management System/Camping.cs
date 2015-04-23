using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_System
{
    class Camping
    {
        public int CampingID { get; set; }
        public string Name { get; set; }
        public string MapPath { get; set; }

        /// <summary>
        /// A class similar to a row in the database PT_CAMPING
        /// </summary>
        /// <param name="campingID">The ID from the camping</param>
        /// <param name="name">The name from the camping</param>
        /// <param name="mapPath">The path from the camping map</param>
        public Camping(int campingID, string name, string mapPath)
        {
            CampingID = campingID;
            Name = name;
            MapPath = mapPath;
        }

        public override string ToString()
        {
            return "Camping: " + Name + ", ID: " + CampingID.ToString();
        }
    }
}
