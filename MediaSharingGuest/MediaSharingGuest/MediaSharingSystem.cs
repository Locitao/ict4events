using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaSharingGuest
{
    /// <summary>
    /// The mediasharing system the user creates when logging in.
    /// </summary>
    public class MediaSharingSystem
    {
        //Properties-------------------------------
        public string RfidCode {get; set;}
        public string Username {get; set;}

        //Constructor-------------------------------
        public MediaSharingSystem(string rfidCode, string username)
        {
            RfidCode = rfidCode;
            Username = username;
        }
    }
}
