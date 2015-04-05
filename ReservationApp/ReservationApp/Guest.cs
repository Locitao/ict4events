using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationApp
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
        public Guest Reserver { get; set; }
        public bool Paid { get; set; }

        public Guest(string name, bool paid, string rfidCode)
        {
            name = Name;
            paid = Paid;
            rfidCode = RfidCode;
        }

        public Guest(string name, string rfidCode, string postalCode, string city, string street, int streetNumber, string eMail, Guest reserver, bool paid)
        {
            name = Name;
            rfidCode = RfidCode;
            postalCode = PostalCode;
            city = City;
            street = Street;
            streetNumber = StreetNumber;
            eMail = Email;
            reserver = Reserver;
            paid = Paid;
        }
    }
}
