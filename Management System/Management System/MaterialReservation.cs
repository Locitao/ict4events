using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_System
{
    class MaterialReservation
    {
        public DateTime Date { get; set; }
        public Guest Reserver = new Guest();

        public MaterialReservation()
        {
            
        }
    }
}
