using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaSharingGuest
{
    public class Guest
    {
        public string Name { get; set; }
        public bool IsBanned { get; set; }
        public DateTime BannedDate { get; set; }
        public int WarningLvl { get; set; }
        public string RFIDcode { get; set; }

        public Guest(string name, string rfidcode)
        {
            Name = name;
            RFIDcode = rfidcode;
        }

        
    }
}
