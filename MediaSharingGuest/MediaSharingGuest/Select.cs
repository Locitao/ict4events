using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaSharingGuest
{
    class Select
    {
        Connection connect = new Connection();

        public void GetName(string Rfidcode)
        {
            string query = "SELECT Name FROM PT_USER_ACC WHERE RFID_CODE = " + Rfidcode;
        }

        public void SelectImageNoMediaID(int categoryID, string medName, string medLocation, string medDescription, string rfidCode)
        {
            string query = "SELECT MEDIA_ID FROM MEDIA WHERE RFID_CODE = " + rfidCode + "AND CATEGORY_ID = " + categoryID + "MED_NAME = " + medName + "AND MED_LOCATION = " + medLocation + "AND MED_DESCRIPTION = " + medDescription;
        }

        public void GetAllReactionsData (int mediaID)
        {
            string query = "SELECT r.REACTION_ID, u.USER_NAME, r.REA_CONTENT, (SELECT COUNT(LIKE_ID) FROM PT_USER_LIKE WHERE REACTION_ID IN (SELECT REACTION_ID FROM PT_REACTION WHERE MEDIA_ID = " + "'" + mediaID + "')) AS LIKES FROM PT_USER_ACC u JOIN PT_REACTION r ON u.RFID_CODE = r.RFID_CODE WHERE r.MEDIA_ID = " + "'" + mediaID + "'";
        }

        public void GetNewsFeedMessages()
        {
            string query = "SELECT u.USER_NAME, r.REA_CONTENT FROM PT_REACTION r JOIN PT_USER_ACC u ON r.RFID_CODE = u.RFID_CODE WHERE MEDIA_ID = '0'";
        }

        public void GetPassword(string Username)
        {
            string query = "SELECT LOGIN_PASSWORD FROM PT_EMPLOYEE_ACC WHERE EMPLOYEE_ID = " + "'" + Username + "'";
        }

        public void GetCategories(int parentCategoryId)
        {
            string query = "SELECT CATEGORY_ID, CATEGORY_NAME FROM PT_MED_CATEGORY WHERE PARENT_CATEGORY_ID = " + "'" + parentCategoryId + "'";
        }

        public void GetAllMediaItems(int CategoryId)
        {
            string query = "SELECT m.MED_NAME, m.MEDIA_ID,  u.USER_NAME FROM PT_MEDIA m JOIN PT_USER_ACC u ON m.RFID_CODE = u.RFID_CODE WHERE m.CATEGORY_ID = " + "'" + CategoryId + "'";
        }

        public void GetMediaItemInfo(int mediaId)
        {
            string query = "SELECT m.MED_NAME, m.MED_LOCATION, m.MED_DESCRIPTION, m.MED_PATH, u.USER_NAME, (SELECT COUNT(LIKE_ID) FROM PT_USER_LIKE WHERE MEDIA_ID = " + "'" + mediaId + "'" + ") AS LIKES FROM PT_MEDIA m JOIN PT_USER_ACC u ON m.RFID_CODE = u.RFID_CODE WHERE MEDIA_ID = " + "'" + mediaId + "'";
        }

        public void GetFileLikedByUser(string rfidCode, int mediaId)
        {
            string query = "SELECT LIKE_ID FROM PT_USER_LIKE WHERE RFID_CODE = " + "'" + rfidCode + "'" + "AND mediaId = " + "'" + mediaId;
        }

        public void GetReactionLikedByUser(string rfidCode, int reactionId)
        {
            string query = "SELECT REACTION_ID FROM PT_REACTION WHERE RFID_CODE = " + "'" + rfidCode + "'" + "AND REACTION_ID = " + "'" + reactionId;
        }

        public void GetReactor(int reactionId)
        {
            string query = "SELECT u.USER_NAME FROM PT_USER_ACC u JOIN PT_REACTION r ON u.RFID_CODE = r.RFID_CODE WHERE r.REACTION_ID = " + "'" + reactionId + "'";
        }

        public void GetParentCategoryId(int categoryID)
        {
            string query = "SELECT PARENT_CATEGORY_ID FROM PT_MED_CATEGORY WHERE CATEGORY_ID = " + "'" + categoryID + "'";
        }
    }
}
