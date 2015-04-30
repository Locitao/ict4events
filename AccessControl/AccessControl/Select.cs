using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessControl
{
    /// <summary>
    /// This class handles all the information gathering for the application.
    /// </summary>
    class Select
    {
        /// <summary>
        /// Finds the appropriate reservation.
        /// </summary>
        /// <returns></returns>
        public List<Dictionary<string, object>> Select_Reserves()
        {
            const string sql = "SELECT r.RESERVATION_ID AS RESERVE_CODE, u.RFID_CODE, u.USER_NAME, r.PAID, u.EVENT_ID FROM PT_RESERVATION r JOIN PT_USER_ACC u ON r.RESERVATION_ID = u.RESERVATION_ID";

            var data = Connection.ExecuteQuery(sql);
            return data;
        }
        /// <summary>
        /// Returns a list of people currently attending the terrain.
        /// </summary>
        /// <returns></returns>
        public List<Dictionary<string, object>> Select_peopleOnTerrain()
        {
            const string sql = "SELECT RFID_CODE, USER_NAME, EVENT_ID FROM PT_USER_ACC WHERE EVENT_ID IS NOT NULL";

            var data = Connection.ExecuteQuery(sql);
            return data;
        }

        /// <summary>
        /// Counts the amount of people on the terrain.
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// Returns the reservation associated with the RFID.
        /// </summary>
        /// <param name="rfid"></param>
        /// <returns></returns>
        public List<Dictionary<string, object>> Select_ReservesOnRFID(string rfid)
        {
            string sql = "SELECT r.RESERVATION_ID AS RESERVE_CODE, u.RFID_CODE, u.USER_NAME, r.PAID, u.EVENT_ID FROM PT_RESERVATION r JOIN PT_USER_ACC u ON r.RESERVATION_ID = u.RESERVATION_ID WHERE u.RFID_CODE = '" + rfid + "'";

            var data = Connection.ExecuteQuery(sql);
            return data;
        }
        /// <summary>
        /// Finds if the users 'paid' status
        /// </summary>
        /// <param name="RFID"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Checks on which event the RFID is present.
        /// </summary>
        /// <param name="rfid"></param>
        /// <returns></returns>
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
