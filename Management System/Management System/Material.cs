using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_System
{
    class Material
    {
        public int MaterialID { get; set; }
        public string Name { get; set; }
        public MaterialStatus Status { get; set; }
        public int guarantor { get; set; }
        public DateTime LendTime { get; set; }
        public DateTime ReturnTime { get; set; }

        public Material()
        {
            
        }
    }
}
