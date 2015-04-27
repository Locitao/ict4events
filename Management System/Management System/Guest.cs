using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_System
{
    class Guest
    {
        public string RFIDCode{get; set;}
        public string UserName { get; set; }
        public string Adress { get; set; }
        public string PhoneNumber { get; set; }
        public string BankNumber { get; set; }
        public bool Banned { get; set; }
        public Guest(string RFIDcode, string userName, string adress, string phoneNumber, string bankNumber, bool banned)
        {
            RFIDCode = RFIDcode;
            UserName = userName;
            Adress = adress;
            PhoneNumber = phoneNumber;
            BankNumber = bankNumber;
            Banned = banned;
        }

        public override string ToString()
        {
            if (Banned)
            {
                return UserName + ", RFID: " + RFIDCode + ", banned.";
            }
            else
            {
                return UserName + ", RFID: " + RFIDCode + ", not banned.";
            }
        }
    }
}
