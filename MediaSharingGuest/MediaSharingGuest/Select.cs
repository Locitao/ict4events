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

        public void InsertImage(string mediaID, string categoryID, string medName, string medLocation, string medDescription)
        {
            string query = "INSERT INTO MEDIA(media_ID, category_ID, med_name, med_location, med_description, photo) values(" + mediaID + "," + "'" + categoryID + "'," + "'" + medName + "," + "'" + medLocation + "'," + "'" + medDescription + "'," + " :BlobParameter )";
        }

        public void GetRFID(string Rfidcode)
        {
            string query = "SELECT Name FROM PT_USER_ACC WHERE RFID_CODE = " + Rfidcode;
        }
    }
}
