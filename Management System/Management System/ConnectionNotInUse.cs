using System;
using System.Collections.Generic;
using Oracle.DataAccess.Client;



/* this class is currently not in use
 * I wanted to improve our current connection class
 * but we keep using the old one because adjusting to another one would cost too much time
 * maybe in the future.
*/

namespace Management_System
{
    public class ConnectionNotInUse
    {
        private OracleConnection conn;


        public ConnectionNotInUse()
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

        public bool LogIn(string username, string password)
        {





            return false;
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

        public bool SQLQueryWithOutput(string query, out List<List<string>> output)
        {
            try
            {
                OracleDataReader rdr = new OracleCommand(query, conn).ExecuteReader();
                conn.Open();
                output = new List<List<string>>();

                while (rdr.Read())
                {
                    List<string> temp = new List<string>();
                    for (int i = 0; i < rdr.FieldCount; i++)
                    {
                        if (rdr.GetValue(i) is string)
                        {
                            temp.Add((string)rdr.GetValue(i));
                        }
                        else if (rdr.GetValue(i) is int)
                        {
                            int tempInt = (int)rdr.GetValue(i);
                            temp.Add(tempInt.ToString());
                        }
                    }
                    output.Add(temp);
                }
                return true;

            }
            catch
            {
                output = null;
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public bool SQLQueryNoOutput(string query, out Exception exception)
        {
            try
            {
                OracleCommand cmd = new OracleCommand(query);
                conn.Open();
                cmd.ExecuteNonQuery();
                exception = null;
                return true;
            }
            catch (Exception ex)
            {
                exception = ex;
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public bool SQLQueryNoOutput(string query)
        {
            try
            {
                OracleCommand cmd = new OracleCommand(query);
                conn.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
        }


    }
}
