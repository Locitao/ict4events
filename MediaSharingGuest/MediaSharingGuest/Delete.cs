using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaSharingGuest
{
    class Delete
    {
        public string DeleteLikeMedia(int mediaId)
        {
            string query = "DELETE FROM PT_USER_LIKE WHERE MEDIA_ID = " + "'" + mediaId + "'";
            return query;
        }

        public string DeleteLikeReaction(int reactionId)
        {
            string query = "DELETE FROM PT_USER_LIKE WHERE REACTION_ID = " + "'" + reactionId + "'";
            return query;
        }
    }
}
