using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessControl
{
    /// <summary>
    /// This class has all the update statements, with which you can update the database with the
    /// appropriate information.
    /// </summary>
    class Update
    {
        Connection connect = new Connection();
        Select select = new Select();

        /// <summary>
        /// This method updates the paid status of an account.
        /// </summary>
        /// <param name="RFID"></param>
        /// <returns></returns>
        public string Update_Paid(string RFID)
         {
             try
             {
                 int paid = 0;
                 string currentStatus = select.GetPaid(RFID);

                 if (currentStatus == "1")
                 {
                     paid = 0;
                 }
                 else
                 {
                     paid = 1;
                 }
                 string query = "UPDATE PT_RESERVATION r SET r.PAID = '" + paid + "' WHERE r.RESERVATION_ID = (SELECT u.RESERVATION_ID FROM PT_USER_ACC u WHERE u.RFID_CODE = '" + RFID + "')";
                 connect.Execute(query);
                 
                 return "Update succsesfull";
             }
             catch
             {
                 return "Error, update failed";
             }
         }
        /// <summary>
        /// When a user checks into the event, event_ID is updated in the database.
        /// </summary>
        /// <param name="RFID_Code"></param>
        /// <returns></returns>
        public bool Update_CheckPresent(string RFID_Code)
        {
            string present = select.CheckPresent(RFID_Code);
            string status;
            if(present == "")
            {
                status = "2";
            }
            else
            {
                status = "null";
            }

            try
            {
                string query = "UPDATE PT_USER_ACC SET EVENT_ID = "+ status +" WHERE RFID_CODE = '" + RFID_Code + "'";
                connect.Execute(query);

                return true;
            }
            catch
            {
                return false;
            }
        }
        /// <summary>
        /// Updates a reservation ID
        /// </summary>
        /// <param name="reserveCode"></param>
        /// <returns></returns>
        public bool Update_location(string reserveCode)
        {
            try
            {
                string query = "UPDATE PT_USER_ACC SET RESERVATION_ID = null WHERE RESERVATION_ID = '" + reserveCode + "'";
                connect.Execute(query);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Update_user(string reserveCode)
        {
            try
            {
                string query = "UPDATE PT_USER_ACC SET RESERVATION_ID = null WHERE RESERVATION_ID = '" + reserveCode + "'";
                connect.Execute(query);

                return true;
            }
            catch
            {
                return false;
            }
        }
        /// <summary>
        /// Updates the material.
        /// </summary>
        /// <param name="reserveCode"></param>
        /// <returns></returns>
        public bool Update_Material(string reserveCode)
        {
            try
            {
                string query = "UPDATE PT_MATERIAL SET RESERVATION_ID = null WHERE RESERVATION_ID = '" + reserveCode + "'";
                connect.Execute(query);

                return true;
            }
            catch
            {
                return false;

            }
        }
    }
}
