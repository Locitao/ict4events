﻿using System;
using System.Collections.Generic;
using Oracle.DataAccess.Client;


namespace Management_System
{
    /// <summary>
    /// This class has hardcoded connection login data and is used to submit and submit and receive data from the database
    /// </summary>
    public class DatabaseConnection
    {
        private OracleConnection conn;

        /// <summary>
        /// login data is hardcoded
        /// </summary>
        public DatabaseConnection()
        {
            conn = new OracleConnection();
            
            /*
            // this are the old athena connection specs just in case we need them back.
            string user = "dbi320839";
            string pw = "ioMMVpigPp";
            string ip = "//192.168.15.50:1521/fhictora";
             */
            
            
             // this are the connection specs for connection to the database in the VMware
            string user = "system";
            string pw = "wachtwoord";
            string ip = "172.19.180.2:1521/xe";
             
            conn.ConnectionString = "User Id=" + user + ";Password=" + pw + ";Data Source=" + ip + ";";
        }

        /// <summary>
        /// Tries to open a connoction with the database
        /// </summary>
        /// <returns>true if a connection has been opened, false if an error has occured</returns>
        private bool OpenConnection()
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
        /// <summary>
        /// Closes the connection with the database if it was open
        /// </summary>
        private void CloseConnection()
        {
            conn.Close();
        }


        
        /// <summary>
        /// This method uses a query to receive data from the oracle database
        /// </summary>
        /// <param name="query">The SQL query that specifies what you want to receive from the database</param>
        /// <param name="output">outputs an 2D list with all received data</param>
        /// <returns>true if the query is succesfull, false if an error has occured</returns>
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
                        else if (rdr.GetValue(i) is short)
                        {
                            short tempInt = (short)rdr.GetValue(i);
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
        /// <summary>
        /// This method uses a query to receive data from the oracle database
        /// </summary>
        /// <param name="query">The SQL query that specifies what you want to receive from the database</param>
        /// <param name="output">outputs an 2D list with all received data</param>
        /// <param name="exception">outputs the exception if there was one, if not this outputs null</param>
        /// <returns>true if the query is succesfull, false if an error has occured</returns>
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
                        else if (rdr.GetValue(i) is short)
                        {
                            short tempInt = (short)rdr.GetValue(i);
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

        /// <summary>
        /// This method uses a query to submit data to the oracle database
        /// </summary>
        /// <param name="query">the SQL query that contais what you want to submit to the database</param>
        /// <returns>true if the query is succesfull, false if an error has occured</returns>
        public bool SQLQueryNoOutput(string query)
        {
            try
            {
                OracleCommand cmd = new OracleCommand(query, conn);
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
        /// <summary>
        /// This method uses a query to submit data to the oracle database
        /// </summary>
        /// <param name="query">the SQL query that contais what you want to submit to the database</param>
        /// <param name="exception">outputs the exception if there was one, if not this outputs null</param>
        /// <returns>true if the query is succesfull, false if an error has occured</returns>
        public bool SQLQueryNoOutput(string query, out Exception exception)
        {
            try
            {
                OracleCommand cmd = new OracleCommand(query, conn);
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
