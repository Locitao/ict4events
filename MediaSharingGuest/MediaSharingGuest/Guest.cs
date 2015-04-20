using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaSharingGuest
{
    public class Guest
    {
        //Properties--------------------------
        public string Name { get; set; }
        public bool IsBanned { get; set; }
        public string RFIDcode { get; set; }

        //Constructor-------------------------
        public Guest(string name, string rfidcode)
        {
            Name = name;
            RFIDcode = rfidcode;
        }
    }
}
