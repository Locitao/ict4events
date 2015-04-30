using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessControl
{
    class Delete
    {
        /// <summary>
        /// This class takes care of all the deletions that have to happen in the database.
        /// </summary>
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
