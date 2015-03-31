using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_System
{
    class Guest
    {
        /// <summary>
        /// First some properties, to show who/what this guest is. Then the constructor.
        /// </summary>
        public string Name { get; set; }
        public string RfidCode { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int StreetNumber { get; set; }
        public string Email { get; set; }
        public bool Reserver { get; set; }
        public bool Paid { get; set; }

        public Guest()
        {

        }
    }
}
