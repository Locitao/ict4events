using System;
using Oracle.DataAccess.Client;

namespace Management_System
{
    public class Connection
    {
        OracleConnection conn;


        public Connection()
        {
            conn = new OracleConnection();
            const string user = "dbi320839";
            const string pw = "ioMMVpigPp";
            conn.ConnectionString = "User Id=" + user + ";Password=" + pw + ";Data Source=" +
                                    "//192.168.15.50:1521/fhictora" + ";";
        }

        public bool OpenConnection()
        {
            try
            {
                conn.Open();
                return true;
            }
            catch
            {
                return false;
            }


        }

        public void CloseConnection()
        {
            conn.Close();
        }

        public void TestSQLquery() // example of how to run a query
        {
            OracleCommand command = new OracleCommand("CREATE TABLE test(ID int, name VARCHAR(10), password VARCHAR(5));");
            try
            {
                conn.Open();
                command.ExecuteNonQuery();
            }
            catch { }
            conn.Close();
        }


    }
}
