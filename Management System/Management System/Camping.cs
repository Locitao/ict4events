using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_System
{
    class Camping
    {
        public string Name { get; set; }
        public string MapPath { get; set; }

        public Camping(string name, string mapPath)
        {
            Name = name;
            mapPath = MapPath;
        }
    }
}
