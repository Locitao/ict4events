using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaSharingGuest
{
    public class Like
    {
        //Properties---------------------------
        public string RfidCode { get; set; }
        public int ReactionID { get; set; }
        public int MediaID { get; set; }

        //Contructor---------------------------
        public Like (string rfidcode, int reactionid, int mediaid)
        {
            RfidCode = rfidcode;
            ReactionID = reactionid;
            MediaID = mediaid;
        }
    }
}
