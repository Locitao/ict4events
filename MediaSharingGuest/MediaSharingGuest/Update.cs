using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaSharingGuest
{
    /// <summary>
    /// This class contains all the update statements to send to the database.
    /// </summary>
    class Update
    {
        //Edits category name, uses category Id and new category name.
        public string EditCategoryName (int CategoryId, string newName)
        {
            string query = "UPDATE PT_MED_CATEGORY SET CATEGORY_NAME = " + "'" + newName + "'" + "WHERE CATEGORY_ID = " + "'" + CategoryId + "'";
            return query;
        }

        //Bans user, uses rfid code.
        public string BanUser (string rfidCode)
        {
            string query = "UPDATE PT_USER_ACC SET USER_BAN_STATE = '1' WHERE RFID_CODE = '" + rfidCode + "'";
            return query;
        }

        //Unbans user, uses rfidcode.
        public string UnbanUser(string rfidCode)
        {
            string query = "UPDATE PT_USER_ACC SET USER_BAN_STATE = '0' WHERE RFID_CODE = '" + rfidCode + "'";
            return query;
        }
    }
}
