using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaSharingGuest
{
    class Insert
    {
        public void InsertImage(string mediaID, string categoryID, string medName, string medLocation, string medDescription, string rfidCode)
        {
            string query =
                    "INSERT INTO PT_USER_ACC (MEDIA_ID, RFID_CODE, CATEGORY_ID, MED_NAME, MED_LOCATION, MED_DESCRIPTION) VALUES (auto_inc_med.nextval, '" +
                    mediaID + "', '" + rfidCode + "', '" + categoryID + "' , '" + medName + "' , '" + medLocation + "' , '" + medDescription + "')";


        }

    }
}
