using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace ReservationApp
{
    public class Connection
    {
        private OracleConnection conn;

        public bool NewConnection()
        {
            conn = new OracleConnection();

            const string user = "dbi320839";
            const string pw = "ioMMVpigPp";

            conn.ConnectionString = "User Id=" + user + ";Password=" + pw + ";Data Source=" +
                                    "//192.168.15.50:1521/fhictora" + ";";
            try
            {
                conn.Open();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

            
        }

        public void CloseConnection()
        {
            conn.Close();
        }
    }
}
