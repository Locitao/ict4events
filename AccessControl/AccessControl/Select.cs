using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessControl
{
    class Select
    {
        public List<Dictionary<string, object>> Select_reserves()
        {
            string sql = "SELECT r.RFID_CODE, u.RFID_CODE AS USER_CODE, u.USER_NAME, r.PERSON_AMOUNT, r.PAID FROM PT_USER_ACC u JOIN PT_RESERVATION r ON u.RESERVATION_ID = r.RESERVATION_ID";

            var data = Connection.ExecuteQuery(sql);
            return data;
        }

        public List<Dictionary<string, object>> Select_reservesOnRFID(string RFID)
        {
            string sql = "SELECT r.RFID_CODE, u.RFID_CODE AS USER_CODE, u.USER_NAME, r.PERSON_AMOUNT, r.PAID FROM PT_USER_ACC u JOIN PT_RESERVATION r ON u.RESERVATION_ID = r.RESERVATION_ID WHERE u.RFID_CODE = '" + RFID + "'";

            var data = Connection.ExecuteQuery(sql);
            return data;
        }

        public string getPaid(string RFID)
        {
            string returnValue = "";
            string query = "SELECT PAID FROM PT_RESERVATION WHERE RFID_CODE = '" + RFID + "'";
            var data = Connection.ExecuteQuery(query);

            foreach (var row in data)
            {
                returnValue = Convert.ToString(row["PAID"]);
            }
            return returnValue;
        }
    }
}
