using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationApp
{
    /// <summary>
    /// This class will be used to insert reservations into the database.
    /// </summary>
    class Insert
    {
        Connection conn = new Connection();
        public string Insert_Reservation(string rfid_Code, string event_ID, string location_ID,
            string person_amount, string paid)
        {
            try
            {
                string query =
                "INSERT INTO PT_RESERVATION (reservation_ID, rfid_CODE, event_ID, location_ID, person_amount, paid) VALUES (auto_inc_res.nextval, " +
                rfid_Code + ", " + event_ID + ", " + location_ID + ", " + person_amount + ", " + paid + ");";

                conn.Execute(query);
                string succes = "Reservation created!";
                return succes;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            
        }
    }
}
