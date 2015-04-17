using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessControl
{
    class Delete
    {
        Connection connect = new Connection();

        public bool Delete_Reservation(string ReserveID)
        {
            try
            {
                string query = "DELETE FROM PT_RESERVATION WHERE RESERVATION_ID = '" + ReserveID + "'";
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
