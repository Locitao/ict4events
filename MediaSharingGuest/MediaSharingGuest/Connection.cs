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

            //Athena Connection data
            //const string user = "dbi320839";
            //const string pw = "ioMMVpigPp";
            //const string test = "fhictora";
            //Athena ip //192.168.15.50:1521/

            //VMware connection data
            //local ip vmware: 172.19.180.2:1521

           
            //const string user = "SYSTEM";
            //const string pw = "wachtwoord";
            //const string test = "xe";

            conn.ConnectionString = "User Id=" + user + ";Password=" + pw + ";Data Source=" +
                                    "//172.19.180.2:1521/" + test + ";";

            //Local connection data
            //conn.ConnectionString = "User Id=" + user + ";Password=" + pw + ";Data Source=" + " //localhost:1521/xe" + ";";

<<<<<<< HEAD
            //conn.ConnectionString = "User Id=" + user + ";Password=" + pw + ";Data Source=" + " //localhost:1521/xe" + ";";
            conn.ConnectionString = "User Id=system;Password=wachtwoord;Data Source=172.19.180.2:1521/xe;";
=======
>>>>>>> origin/master
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
