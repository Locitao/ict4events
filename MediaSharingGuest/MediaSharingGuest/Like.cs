using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaSharingGuest
{
    class Like
    {
        public string RfidCode { get; set; }
        public int LikeID { get; set; }
        public int ReactionID { get; set; }
        public int MediaID { get; set; }

        public Like (string rfidcode, int likeid, int reactionid, int mediaid)
        {
            RfidCode = rfidcode;
            LikeID = likeid;
            ReactionID = reactionid;
            MediaID = mediaid;
        }

    }
}
