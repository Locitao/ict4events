using System;
using Oracle.DataAccess.Client;

namespace Management_System
{
    public class Connection
    {
        OracleConnection conn = new OracleConnection();

        public bool NewConnection()
        {

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
