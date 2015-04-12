using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaSharingGuest
{
    public class Like
    {
        public string RfidCode { get; set; }
        public int LikeID { get; set; }
        public int ReactionID { get; set; }
        public int MediaID { get; set; }

        public Like (string rfidcode, int reactionid, int mediaid)
        {
            RfidCode = rfidcode;
            ReactionID = reactionid;
            MediaID = mediaid;

            //INSERT to add LIKE to database, RETURNS LIKE ID

            LikeID = 0;
        }

    }
}
