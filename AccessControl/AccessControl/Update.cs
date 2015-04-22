using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessControl
{
    class Update
    {
        Connection connect = new Connection();
        Select select = new Select();

        public string Update_Paid(string reserveID)
         {
             try
             {
                 int paid = 0;
                 string currentStatus = select.GetPaid(reserveID);

                 if (currentStatus == "1")
                 {
                     paid = 0;
                 }
                 else
                 {
                     paid = 1;
                 }
                 string query = "UPDATE PT_RESERVATION r SET r.PAID = '" + paid + "' WHERE r.RESERVATION_ID = '" + reserveID + "'";
                 connect.Execute(query);

                 return "Update succsesfull";
             }
             catch
             {
                 return "Error, update failed";
             }
         }

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
