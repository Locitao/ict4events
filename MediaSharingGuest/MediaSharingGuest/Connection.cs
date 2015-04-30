using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using Oracle.DataAccess;
using System.Windows.Forms;

namespace MediaSharingGuest
{
    public class Connection
    {
        OracleConnection conn = new OracleConnection();

        /// <summary>
        /// Opens the connection to the database
        /// </summary>
        /// <returns></returns>
        public bool OpenConnection()
        {

            //Barts local database for testing purpose
            //conn.ConnectionString = "User Id=system;Password=wachtwoord;Data Source=//localhost:1521/xe;";

            // athea database from rick
            //conn.ConnectionString = "User Id=dbi320839;Password=ioMMVpigPp;Data Source=//192.168.15.50:1521/fhictora;";

            // local database string for WMware
            conn.ConnectionString = "User Id=system;Password=wachtwoord;Data Source=172.19.180.2:1521/xe;";
            try
            {
                conn.Open();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }


        }

        /// <summary>
        /// Closes the connection to the database.
        /// </summary>
        public void CloseConnection()
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
                        else if (rdr.GetValue(i) is decimal)
                        {
                            decimal tempInt = (decimal)rdr.GetValue(i);
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                output = null;
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
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(Convert.ToString(ex));
                return false;
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}
