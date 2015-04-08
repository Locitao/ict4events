using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationApp
{
    /// <summary>
    /// This class uses select statements to get all the required information
    /// such as available spots.
    /// </summary>
    public class Select
    {
        Connection connect = new Connection();

        //Now a method that returns a list of locations that are not reserved yet

        public List<Dictionary<string, object>> Select_locations()
        {
            string sql =
                "SELECT * FROM PT_EVENT_LOCATION, PT_RESERVATION WHERE PT_EVENT_LOCATION.location_ID NOT IN PT_RESERVATION.location_ID";

            var data = Connection.ExecuteQuery(sql);
            return data;
        }
        
    }
}
