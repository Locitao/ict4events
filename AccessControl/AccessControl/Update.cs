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

        public string Update_Paid(string rfidCode)
        {
            try
            {
                int paid = 0;
                string currentStatus = select.getPaid(rfidCode);

                if (currentStatus == "1")
                {
                    paid = 0;
                }
                else
                {
                    paid = 1;
                }
                string query = "UPDATE PT_RESERVATION r SET r.PAID = '" + paid +"' WHERE r.RFID_CODE = '" + rfidCode + "'";
                connect.Execute(query);

                return "Update succsesfull";
            }
            catch
            {
                return "Error, update failed";
            }
        }

        public bool Update_location(string rfidCode)
        {
            try
            {                
                string query = "UPDATE PT_LOCATION SET RESERVATION_ID = NULL WHERE RESERVATION_ID = '" + rfidCode + "'";
                connect.Execute(query);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Update_user(string rfidCode)
        {
            try
            {
                string query = "UPDATE PT_USER_ACC SET RESERVATION_ID = NULL WHERE RESERVATION_ID = '" + rfidCode + "'";
                connect.Execute(query);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Update_Material(string rfidCode)
        {
            try
            {
                string query = "UPDATE PT_MATERIAL SET RESERVATION_ID = NULL WHERE RESERVATION_ID = '" + rfidCode + "'";
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
