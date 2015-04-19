using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;

namespace MediaSharingGuest
{
    class Select
    {
        public string GetName(string Rfidcode)
        {
            string query = "SELECT User_Name, RFID_CODE FROM PT_USER_ACC WHERE RFID_CODE = '" + Rfidcode + "'";
            return query;
        }

        public string GetNameWithCategoryId(int categoryId)
        {
            string query = "SELECT u.USER_NAME FROM PT_USER_ACC u JOIN PT_MED_CATEGORY c ON u.RFID_CODE = c.RFID_CODE WHERE CATEGORY_ID = '" + categoryId + "'";
            return query;
        }

        public string GetNameWithMediaId(int mediaId)
        {
            string query = "SELECT u.USER_NAME FROM PT_USER_ACC u JOIN PT_MEDIA c ON u.RFID_CODE = c.RFID_CODE WHERE MEDIA_ID = '" + mediaId + "'";
            return query;
        }

        public string GetNameWithReactionId(int reactionId)
        {
            string query = "SELECT u.USER_NAME FROM PT_USER_ACC u JOIN PT_REACTION c ON u.RFID_CODE = c.RFID_CODE WHERE REACTION_ID = '" + reactionId + "'";
            return query;
        }
        public string SelectImageNoMediaID(int categoryID, string medName, string medLocation, string medDescription, string rfidCode)
        {
            string query = "SELECT MEDIA_ID FROM MEDIA WHERE RFID_CODE = " + rfidCode + "AND CATEGORY_ID = " + categoryID + "MED_NAME = " + medName + "AND MED_LOCATION = " + medLocation + "AND MED_DESCRIPTION = " + medDescription;
            return query;
        }

        public string SelectReactionNoReactionID(int mediaId, string rfidCode, string content)
        {
            string query = "SELECT REACTION_ID FROM PT_REACTION WHERE RFID_CODE = " + "'" + rfidCode + "'" + "AND MEDIA_ID = " + "'" + mediaId + "'" + "AND REA_CONTENT = " + "'" + content + "'";
            return query;
        }

        public string GetAllReactionsData (int mediaId)
        {
            string query = "SELECT r.REACTION_ID, u.USER_NAME, u.RFID_CODE, r.REA_CONTENT FROM PT_USER_ACC u JOIN PT_REACTION r ON u.RFID_CODE = r.RFID_CODE WHERE r.MEDIA_ID = " + "'" + mediaId + "'";
            return query;
        }

        public string GetReactionLikes (int reactionId)
        {
            string query = "SELECT RFID_CODE FROM PT_USER_LIKE WHERE REACTION_ID = " + "'" + reactionId + "'";
            return query;
        }

        public string GetNewsFeedMessages()
        {
            string query = "SELECT u.USER_NAME, r.REA_CONTENT FROM PT_REACTION r JOIN PT_USER_ACC u ON r.RFID_CODE = u.RFID_CODE WHERE MEDIA_ID IS NULL";
            return query;
        }

        public string GetPassword(string Username)
        {
            string query = "SELECT LOGIN_PASSWORD FROM PT_EMPLOYEE_ACC WHERE LOGIN_NAME = " + "'" + Username + "'";
            return query;
        }

        public string GetCategories(int parentCategoryId)
        {
            string query = "SELECT CATEGORY_ID, CATEGORY_NAME, PARENT_CATEGORY_ID FROM PT_MED_CATEGORY WHERE PARENT_CATEGORY_ID = " + "'" + parentCategoryId + "'";
            return query;
        }

        public string GetAllMediaItems(int CategoryId)
        {
            string query = "SELECT m.MED_NAME, m.MEDIA_ID,  u.USER_NAME, u.RFID_CODE FROM PT_MEDIA m JOIN PT_USER_ACC u ON m.RFID_CODE = u.RFID_CODE WHERE m.CATEGORY_ID = " + "'" + CategoryId + "'";
            return query;
        }

        public string GetMediaItemInfo(int mediaId)
        {
            string query = "SELECT m.MED_NAME, m.MED_LOCATION, m.MED_DESCRIPTION, m.MED_PATH, u.USER_NAME, u.RFID_CODE FROM PT_MEDIA m JOIN PT_USER_ACC u ON m.RFID_CODE = u.RFID_CODE WHERE MEDIA_ID = " + "'" + mediaId + "'";
            return query;
        }

        public string GetMediaLikes (int mediaId)
        {
            string query = "SELECT RFID_CODE FROM PT_USER_LIKE WHERE MEDIA_ID = " + "'" + mediaId + "'";
            return query;
        }

        public string GetFileLikedByUser(string rfidCode, int mediaId)
        {
            string query = "SELECT LIKE_ID FROM PT_USER_LIKE WHERE RFID_CODE = " + "'" + rfidCode + "'" + "AND MEDIA_ID = " + "'" + mediaId;
            return query;
        }

        public string GetReactionLikedByUser(string rfidCode, int reactionId)
        {
            string query = "SELECT REACTION_ID FROM PT_REACTION WHERE RFID_CODE = " + "'" + rfidCode + "'" + "AND REACTION_ID = " + "'" + reactionId;
            return query;
        }

        public string GetReactor(int reactionId)
        {
            string query = "SELECT u.USER_NAME FROM PT_USER_ACC u JOIN PT_REACTION r ON u.RFID_CODE = r.RFID_CODE WHERE r.REACTION_ID = " + "'" + reactionId + "'";
            return query;
        }

        public string GetParentCategoryId(int categoryID)
        {
            string query = "SELECT PARENT_CATEGORY_ID FROM PT_MED_CATEGORY WHERE CATEGORY_ID = " + "'" + categoryID + "'";
            return query;
        }

        public string GetReportComment(string rfidCode, int reactionId)
        {
            string query = "SELECT RFID_CODE, REPORT_ID FROM PT_REPORT WHERE RFID_CODE = " + "'" + rfidCode + "' AND REACTION_ID = '" + reactionId + "'";
            return query;
        }

        public string GetReportMediaItem(string rfidCode, int mediaId)
        {
            string query = "SELECT RFID_CODE, REPORT_ID FROM PT_REPORT WHERE RFID_CODE = " + "'" + rfidCode + "' AND MEDIA_ID = '" + mediaId + "'";
            return query;
        }

        public string GetAllReports()
        {
            string query = "SELECT * FROM PT_REPORT WHERE HANDLED = '0'";
            return query;
        }

        public string GetReporter(int reportId)
        {
            string query = "SELECT u.RFID_CODE, u.USER_NAME FROM PT_USER_ACC u JOIN PT_REPORT r ON r.RFID_CODE = u.RFID_CODE WHERE REPORT_ID = ' " + reportId + "'";
            return query;
        }

        public string GetMediaPath(int mediaId)
        {
            string query = "SELECT MED_PATH FROM PT_MEDIA WHERE MEDIA_ID = " + "'" + mediaId + "'";
            return query;
        }

        public string GetReactionContent(int reactionId)
        {
            string query = "SELECT REA_CONTENT FROM PT_REACTION WHERE REACTION_ID = " + "'" + reactionId + "'";
            return query;
        }
    }
}
