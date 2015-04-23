using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaSharingGuest
{
    /// <summary>
    /// This class contains all the insert statements
    /// </summary>
    class Insert
    {
        //Inserts image into database, uses category Id, media name, media location, media description, rfidcode.
        public string InsertImage(int categoryID, string medName, string medLocation, string medDescription, string rfidCode, string medPath)
        {
            string query = "INSERT INTO PT_MEDIA (MEDIA_ID, RFID_CODE, CATEGORY_ID, MED_NAME, MED_LOCATION, MED_PATH, MED_DESCRIPTION) VALUES (auto_inc_med.nextval, " + "'" + rfidCode + "', '" + categoryID + "' , '" + medName + "' ,'" + medLocation + "' , '" + medPath + "', '" + medDescription + "')";
            return query;
        }

        //Inserts a newsfeedmessage into the database, uses rfidCode, content.
        public string AddNewsFeedMessage(string rfidCode, string content)
        {
            string query = "INSERT INTO PT_REACTION (REACTION_ID, MEDIA_ID, RFID_CODE, REA_CONTENT) VALUES (auto_inc_rec.nextval, " + "NULL, '" + rfidCode + "' , '" + content + "')";
            return query;
        }

        //Inserts a category into the database, uses category name, parent category id, rfidcode.
        public string InsertCategory(string categoryName, int parentCategoryId, string Rfidcode)
        {
            string query = "INSERT INTO PT_MED_CATEGORY (CATEGORY_ID, CATEGORY_NAME, RFID_CODE, PARENT_CATEGORY_ID) VALUES (auto_inc_med.nextval, '" + categoryName + "', '" + Rfidcode + "', '" + parentCategoryId + "')";
            return query;
        }

        //Inserts a media report into the database, uses media id, rfidcode, description.
        public string InsertReportMedia(int mediaId, string rfidCode, string description)
        {
            string query = "INSERT INTO PT_REPORT (REPORT_ID, CATEGORY_ID, MEDIA_ID, REACTION_ID, RFID_CODE, REP_DESCRIPTION) VALUES (auto_inc_rep.nextval, " + "NULL, " + "'" + mediaId + "', " + "NULL," + "'" + rfidCode + "', '" + description + "')";        
            return query;
        }

        //Inserts a reaction into the database, uses mediaId, rfidcode, content.
        public string InsertReaction(int mediaId, string rfidCode, string content)
        {
            string query = "Insert into PT_REACTION (reaction_ID, media_ID, rfid_CODE, rea_content) Values (auto_inc_rec.nextval, '" + mediaId + "', '" + rfidCode + "', '" + content + "')";
            return query;
        }

        //Inserts a category report into the database, uses categoryid, rfidcode, description.
        public string InsertReportCategory(int categoryId, string rfidCode, string description)
        {
            string query = "INSERT INTO PT_REPORT (REPORT_ID, CATEGORY_ID, MEDIA_ID, REACTION_ID, RFID_CODE, REP_DESCRIPTION) VALUES (auto_inc_rep.nextval, " + categoryId + ", NULL, " + "NULL, '" + rfidCode + "', '" + description + "')"; ;

            return query;
        }

        //Inserts a reaction report into the database, uses reactionId, rfidCode, description.
        public string InsertReportReaction(int reactionId, string rfidCode, string description)
        {
            string query = "INSERT INTO PT_REPORT (REPORT_ID, CATEGORY_ID, MEDIA_ID, REACTION_ID, RFID_CODE, REP_DESCRIPTION) VALUES (auto_inc_rep.nextval, " + "NULL, NULL, " + "'" + reactionId + "', '" + rfidCode + "', '" + description + "')";
            return query;
        }

        //Inserts a reaction like into the database, uses reaction id, rfidcode.
        public string InsertLikeReaction(int reactionId, string rfidCode)
        {
                string query = "INSERT INTO PT_USER_LIKE (LIKE_ID, MEDIA_ID, REACTION_ID, RFID_CODE) VALUES (auto_inc_lke.nextval, NULL, " + "'" + reactionId +"', " +  "'" + rfidCode + "')";
                return query;
        }

        //Inserts a media like into the database, uses media id. rfidcode.
        public string InsertLikeMedia(int mediaId, string rfidCode)
        {
            string query = "INSERT INTO PT_USER_LIKE (LIKE_ID, MEDIA_ID, REACTION_ID, RFID_CODE) VALUES (auto_inc_lke.nextval, " + "'" + mediaId + "', NULL, " + "'" + rfidCode +"')";
            return query;
        }

    }
}
