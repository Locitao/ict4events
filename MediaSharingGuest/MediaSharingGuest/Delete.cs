using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaSharingGuest
{
    class Delete
    {
        public void DeleteLike(int mediaId, int reactionId, string rfidCode)
        {
            if (mediaId == 0)
            {
                string query = "DELETE FROM PT_USER_LIKE WHERE REACTION_ID = " + "'" + reactionId + "'";
            }
            else if (reactionId == 0)
            {
                string query = "DELETE FROM PT_USER_LIKE WHERE MEDIA_ID = " + "'" + mediaId + "'";
            }
        }
    }
}
