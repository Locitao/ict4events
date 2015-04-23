using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaSharingGuest
{
    /// <summary>
    /// This class contains all the delete statements used by this program to delete data from the database.
    /// </summary>
    class Delete
    {
        //Deletes a media item like, uses media Id.
        public string DeleteLikeMedia(int mediaId)
        {
            string query = "DELETE FROM PT_USER_LIKE WHERE MEDIA_ID = " + "'" + mediaId + "'";
            return query;
        }

        //Deletes a reaction like, uses reaction Id.
        public string DeleteLikeReaction(int reactionId)
        {
            string query = "DELETE FROM PT_USER_LIKE WHERE REACTION_ID = " + "'" + reactionId + "'";
            return query;
        }

        //Deletes a media item, uses media Id.
        public string DeleteMediaItem(int mediaId)
        {
            string query = "DELETE FROM PT_MEDIA WHERE MEDIA_ID = " + "'" + mediaId + "'";
            return query;
        }

        //Deletes a reaction, uses reaction Id.
        public string DeleteReaction(int reactionId)
        {
            string query = "DELETE FROM PT_REACTION WHERE REACTION_ID = " + "'" + reactionId + "'";
            return query;
        }

        //Deletes a report about a category, using category Id.
        public string DeleteReportsWithCategoryId(int categoryId)
        {
            string query = "DELETE FROM PT_REPORT WHERE REACTION_ID = " + "'" + categoryId + "'";
            return query;
        }

        //Deletes a report, using report Id.
        public string DeleteReportWithReportId(int reportId)
        {
            string query = "DELETE FROM PT_REPORT WHERE REPORT_ID = " + "'" + reportId + "'";
            return query;
        }

        //Delete all newsfeedmessages
        public string DeleteAllNewsFeedMessages()
        {
            string query = "DELETE FROM PT_REACTION WHERE MEDIA_ID IS NULL";
            return query;
        }

    }
}
