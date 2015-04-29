using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessControl
{
    class Select
    {
        public List<Dictionary<string, object>> Select_Reserves()
        {
            const string sql = "SELECT r.RESERVATION_ID AS RESERVE_CODE, u.RFID_CODE, u.USER_NAME, r.PAID, u.EVENT_ID FROM PT_RESERVATION r JOIN PT_USER_ACC u ON r.RESERVATION_ID = u.RESERVATION_ID";

            var data = Connection.ExecuteQuery(sql);
            return data;
        }

        public List<Dictionary<string, object>> Select_peopleOnTerrain()
        {
            const string sql = "SELECT RFID_CODE, USER_NAME, EVENT_ID FROM PT_USER_ACC WHERE EVENT_ID IS NOT NULL";

            var data = Connection.ExecuteQuery(sql);
            return data;
        }

        public string Select_amountOfPeopleOnTerrain()
        {
            string amount ="";
            const string sql = "SELECT COUNT(RFID_CODE) FROM PT_USER_ACC WHERE EVENT_ID IS NOT NULL";

            var data = Connection.ExecuteQuery(sql);

            foreach (Dictionary<string, object> row in data)
            {
                amount = Convert.ToString(row["COUNT(RFID_CODE)"]);
            }

            return amount;
        }

        public List<Dictionary<string, object>> Select_ReservesOnRFID(string rfid)
        {
            string sql = "SELECT r.RESERVATION_ID AS RESERVE_CODE, u.RFID_CODE, u.USER_NAME, r.PAID, u.EVENT_ID FROM PT_RESERVATION r JOIN PT_USER_ACC u ON r.RESERVATION_ID = u.RESERVATION_ID WHERE u.RFID_CODE = '" + rfid + "'";

            var data = Connection.ExecuteQuery(sql);
            return data;
        }

        public string GetPaid(string RFID)
        {
            string paid = "";

            string sql = "SELECT r.PAID FROM PT_RESERVATION r JOIN PT_USER_ACC u ON r.RESERVATION_ID = u.RESERVATION_ID WHERE u.RFID_CODE = '" + RFID + "'";
            
            var data = Connection.ExecuteQuery(sql);

            foreach (Dictionary<string, object> row in data)
            {
                paid = Convert.ToString(row["PAID"]);
            }

            return paid;
        }

        public string CheckPresent(string rfid)
        {
            string eventId = "";

            string sql = "SELECT EVENT_ID FROM PT_USER_ACC WHERE RFID_CODE = '" + rfid + "'";
            var data = Connection.ExecuteQuery(sql);

            foreach (Dictionary<string, object> row in data)
            {
                eventId = Convert.ToString(row["EVENT_ID"]);
            }

            return eventId;
        }
    }
}
