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

        public string DeleteMediaItem(int mediaId)
        {
            string query = "DELETE FROM PT_MEDIA WHERE MEDIA_ID = " + "'" + mediaId + "'";
            return query;
        }

        public string DeleteReaction(int reactionId)
        {
            string query = "DELETE FROM PT_REACTION WHERE REACTION_ID = " + "'" + reactionId + "'";
            return query;
        }

        public string DeleteReportsWithReactionId (int reactionId)
        {
            string query = "DELETE FROM PT_REPORT WHERE REACTION_ID = " + "'" + reactionId + "'";
            return query;
        }

        public string DeleteLikesWithReactionId (int reactionId)
        {
            string query = "DELETE FROM PT_USER_LIKES WHERE REACTION_ID = " + "'" + reactionId + "'";
            return query;
        }

        public string DeleteReportsWithCategoryId(int categoryId)
        {
            string query = "DELETE FROM PT_REPORT WHERE REACTION_ID = " + "'" + categoryId + "'";
            return query;
        }

        public string DeleteReportsWithMediaId(int mediaId)
        {
            string query = "DELETE FROM PT_REPORT WHERE REACTION_ID = " + "'" + mediaId + "'";
            return query;
        }

        public string DeleteReportWithReportId(int reportId)
        {
            string query = "DELETE FROM PT_REPORT WHERE REPORT_ID = " + "'" + reportId + "'";
            return query;
        }

    }
}
