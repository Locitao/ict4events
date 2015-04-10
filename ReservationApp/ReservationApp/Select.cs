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
            const string sql = "SELECT loc.loc_type, loc.max_people, loc.price, loc.location_ID FROM PT_EVENT_LOCATION loc, PT_RESERVATION WHERE loc.location_ID NOT IN PT_RESERVATION.location_ID";

            var data = Connection.ExecuteQuery(sql);
            return data;
        }

        //A method that returns a list of events.
        public List<Dictionary<string, object>> Select_Events()
        {
            const string sql = "SELECT * FROM PT_EVENT";

            var data = Connection.ExecuteQuery(sql);
            return data;
        }

        public List<Dictionary<string, object>> Select_Materials()
        {
            const string sql =
                "SELECT PT_MAT_CATEGORY.mat_name, PT_MAT_CATEGORY.price FROM PT_MAT_CATEGORY, PT_MATERIAL WHERE PT_MATERIAL.mat_category = PT_MAT_CATEGORY.mat_category_ID AND PT_MATERIAL.rfid_CODE IS NULL";

            var data = Connection.ExecuteQuery(sql);
            return data;
        }

    }
 
}
