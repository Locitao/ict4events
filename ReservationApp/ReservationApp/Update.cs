using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationApp
{
    class Update
    {
        Connection conn = new Connection();

        public string Update_Location(string locationId, string reservation_ID)
        {
            try
            {
                string query = "UPDATE PT_EVENT_LOCATION SET reservation_ID = '" + reservation_ID +
                               "' WHERE location_ID = '" + locationId + "'";

                
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
