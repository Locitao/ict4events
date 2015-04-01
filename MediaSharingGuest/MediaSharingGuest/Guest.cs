using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaSharingGuest
{
    class Guest
    {
        public string Name { get; set; }
        public bool IsBanned { get; set; }
        public DateTime BannedDate { get; set; }
        public int WarningLvl { get; set; }

        public Guest()
        {

        }

        
    }
}
