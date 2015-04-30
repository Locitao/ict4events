using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using Oracle.DataAccess;


namespace ReservationApp
{
    /// <summary>
    /// This class does everything regarding the connection; creates it, opens it and closes it.
    /// </summary>
    public class Connection
    {
        readonly OracleConnection conn = new OracleConnection();
        /// <summary>
        /// Tries to open a connection with the database, returns true if succeeded, false if failed.
        /// </summary>
        /// <returns></returns>
        public bool NewConnection()
        {
            
            //const string user2 = "dbi320839";
            //const string pw2 = "ioMMVpigPp";
            //const string test2 = "fhictora";
            //172.19.180.2:1521
            const string user = "system";
            const string pw = "wachtwoord";
            const string test = "xe";

            conn.ConnectionString = "User Id=" + user + ";Password=" + pw + ";Data Source=" +
                                    "//172.19.180.2:1521/" + test + ";";
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
        /// <summary>
        /// CloseConnection() does what it says.
        /// </summary>
        public void CloseConnection()
        {
            conn.Close();
        }
        /// <summary>
        /// Sends the given query to the database, returns it's result as a List of dictionary objects.
        /// Most commonly used with SELECT statements
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public static List<Dictionary<string, object>> ExecuteQuery(string query)
        {
            List<Dictionary<string, object>> result = new List<Dictionary<string, object>>();

            Connection connection = new Connection();
            connection.CloseConnection();
            

            if (connection.NewConnection())
            {
                try
                {
                    OracleDataReader resultReader = new OracleCommand(query, connection.conn).ExecuteReader();

                    while (resultReader.Read())
                    {
                        Dictionary<string, object> row = new Dictionary<string, object>();

                         //Loop through fields, add them to the row

                        for (int fieldId = 0; fieldId < resultReader.FieldCount; fieldId++)
                            row.Add(resultReader.GetName(fieldId), resultReader.GetValue(fieldId));

                        result.Add(row);

                    }
                    connection.conn.Close();
                    return result;
                }
                catch (Exception ex)
                {
                    throw;
                }
                

                //Loop through files, add them to result

                
                
            }
            connection.conn.Close();
            return result;
        }
        /// <summary>
        /// Execute is for every query that shouldn't return something, so insert and update statements go
        /// through this method.
        /// </summary>
        /// <param name="sql"></param>
        public void Execute(string sql)
        {
            string query = sql;


            if (!NewConnection()) return;
            // Command opzetten voor het uitvoeren van de query
            OracleCommand cmd = new OracleCommand(query, conn);

            // Query uitvoeren, er wordt geen waarde terug gegeven
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
