using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_System
{
    class Material
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Deposit { get; set; }
        public DateTime LendTime { get; set; }
        public DateTime ReturnTime { get; set; }

        public Material()
        {
            
        }
    }
}
