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

        public bool Delete_Reservation(string rfidCode)
        {
            try
            {            
                string query = "DELETE FROM PT_RESERVATION WHERE RFID_CODE = '" + rfidCode + "'";
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
