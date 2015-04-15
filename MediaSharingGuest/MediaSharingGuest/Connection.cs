using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using Oracle.DataAccess;

namespace MediaSharingGuest
{
    public class Connection
    {
        OracleConnection conn = new OracleConnection();

        public bool OpenConnection()
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
    }
}
