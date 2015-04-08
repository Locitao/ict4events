using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaSharingGuest
{
    class Select
    {
        Connection connect = new Connection();

        //Now a method that returns a list of locations that are not reserved yet

        public List<Dictionary<string, object>> Select_locations()
        {
            const string sql = "SELECT loc.loc_type, loc.max_people, loc.price, loc.location_ID FROM PT_EVENT_LOCATION loc, PT_RESERVATION WHERE loc.location_ID NOT IN PT_RESERVATION.location_ID";

            var data = Connection.ExecuteQuery(sql);
            return data;
        }
    }
}
