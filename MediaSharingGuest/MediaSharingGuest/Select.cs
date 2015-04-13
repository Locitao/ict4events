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

        public void GetRFID(string Rfidcode)
        {
            string query = "SELECT Name FROM PT_USER_ACC WHERE RFID_CODE = " + Rfidcode;
        }
    }
}
