using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_System
{
    class Camping
    {
        public string CampingID { get; set; }
        public string Name { get; set; }
        public string MapPath { get; set; }

        public Camping(string campingID, string name, string mapPath)
        {
            CampingID = campingID;
            Name = name;
            MapPath = mapPath;
        }

        public override string ToString()
        {
            return CampingID + Name;
        }
    }
}
