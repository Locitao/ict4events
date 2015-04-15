using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaSharingGuest
{
    class Insert
    {
        public void InsertImage(int categoryID, string medName, string medLocation, string medDescription, string rfidCode)
        {
            string query =
                    "INSERT INTO PT_MEDIA (MEDIA_ID, RFID_CODE, CATEGORY_ID, MED_NAME, MED_LOCATION, MED_DESCRIPTION) VALUES (auto_inc_med.nextval," + "', '" + rfidCode + "', '" + categoryID + "' , '" + medName + "' , '" + medLocation + "' , '" + medDescription + "')";

        }

        public void AddReaction(int mediaId, string rfidCode, string content)
        {
            string query =
                    "INSERT INTO PT_REACTION (REACTION_ID, MEDIA_ID, RFID_CODE, REA_CONTENT) VALUES (auto_inc_rec.nextval, " + "', '" + mediaId + "', '" + rfidCode + "' , '" + content + "')";
        }

        public void InsertCategory(string categoryName, int parentCategoryId, string Rfidcode)
        {
            string query =
                    "INSERT INTO PT_MED_CATEGORY (CATEGORY_ID, RFID_CODE, PARENT_CATEGORY_ID) VALUES (auto_inc_med.nextval, " + "', '" + Rfidcode + "', '" + parentCategoryId + "')";
        }

    }
}
