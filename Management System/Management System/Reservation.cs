using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_System
{
    class Reservation
    {
        public Guest reserver = new Guest();

        public bool Paid { get; set; }
        public decimal Amount { get; set; }
    }
}
