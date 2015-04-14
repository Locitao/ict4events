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

        public void GetRFID(string Rfidcode)
        {
            string query = "SELECT Name FROM PT_USER_ACC WHERE RFID_CODE = " + Rfidcode;
        }

        public void SelectImageNoMediaID(int categoryID, string medName, string medLocation, string medDescription, string rfidCode)
        {
            string query = "SELECT MEDIA_ID FROM MEDIA WHERE RFID_CODE = " + rfidCode + "AND CATEGORY_ID = " + categoryID + "MED_NAME = " + medName + "AND MED_LOCATION = " + medLocation + "AND MED_DESCRIPTION = " + medDescription;
        }

        public void GetLikesMediaItem(int mediaID)
        {
            string query = "SELECT COUNT(*) FROM LIKES WHERE MEDIA_ID = " + mediaID;
        }

        public void GetAllReactionsData (int mediaID)
        {
            string query = "SELECT u.USER_NAME, r.REA_CONTENT, (SELECT COUNT(LIKE_ID) FROM PT_USER_LIKE WHERE MEDIA_ID = " + "'" + mediaID + "')" + " AS LIKES FROM PT_USER_ACC u JOIN PT_REACTION r ON u.RFID_CODE = r.RFID_CODE WHERE r.MEDIA_ID = " + "'" + mediaID + "'";
        }
    }
}
