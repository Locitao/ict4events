using System;
using System.Collections.Generic;
using Oracle.DataAccess.Client;


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



        

        public bool SQLQueryWithOutput(string query, out List<List<string>> output)
        {
            try
            {
                OpenConnection();
                OracleDataReader rdr = new OracleCommand(query, conn).ExecuteReader();
                output = new List<List<string>>();

                while (rdr.Read())
                {
                    List<string> temp = new List<string>();
                    for (int i = 0; i < rdr.FieldCount; i++)
                    {
                        object o = rdr.GetValue(i);
                        if (o is string)
                        {
                            temp.Add((string)rdr.GetValue(i));
                        }
                        else if (rdr.GetValue(i) is long)
                        {
                            long tempInt = (long)rdr.GetValue(i);
                            temp.Add(tempInt.ToString());
                        }
                        else if (rdr.GetValue(i) is DateTime)
                        {
                            DateTime tempDateTime = (DateTime)rdr.GetValue(i);
                            temp.Add(tempDateTime.ToString());
                        }
                        else if (rdr.GetValue(i) is DBNull)
                        {
                            temp.Add("");
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
                CloseConnection();
            }
        }
        public bool SQLQueryWithOutput(string query, out List<List<string>> output, out Exception exception)
        {
            try
            {
                OpenConnection();
                OracleDataReader rdr = new OracleCommand(query, conn).ExecuteReader();
                output = new List<List<string>>();

                while (rdr.Read())
                {
                    List<string> temp = new List<string>();
                    for (int i = 0; i < rdr.FieldCount; i++)
                    {
                        object o = rdr.GetValue(i);
                        if (o is string)
                        {
                            temp.Add((string)rdr.GetValue(i));
                        }
                        else if (rdr.GetValue(i) is long)
                        {
                            long tempInt = (long)rdr.GetValue(i);
                            temp.Add(tempInt.ToString());
                        }
                        else if (rdr.GetValue(i) is DateTime)
                        {
                            DateTime tempDateTime = (DateTime)rdr.GetValue(i);
                            temp.Add(tempDateTime.ToString());
                        }
                        else if (rdr.GetValue(i) is DBNull)
                        {
                            temp.Add("");
                        }
                    }
                    output.Add(temp);
                }
                exception = null;
                return true;

            }
            catch(Exception ex)
            {
                output = null;
                exception = ex;
                return false;
            }
            finally
            {
                CloseConnection();
            }
        }



        public bool SQLQueryNoOutput(string query)
        {
            try
            {
                OracleCommand cmd = new OracleCommand(query);
                OpenConnection();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                CloseConnection();
            }
        }
        public bool SQLQueryNoOutput(string query, out Exception exception)
        {
            try
            {
                OracleCommand cmd = new OracleCommand(query);
                OpenConnection();
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
                CloseConnection();
            }
        }

        

    }
}
