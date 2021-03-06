﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using Oracle.DataAccess;

namespace AccessControl
{
    class Connection
    {
        OracleConnection conn = new OracleConnection();

        public bool NewConnection()
        {
            // -- Athena login

            //const string user = "dbi320839";
            //const string pw = "ioMMVpigPp";

            //conn.ConnectionString = "User Id=" + user + ";Password=" + pw + ";Data Source=" +
            //                        "//192.168.15.50:1521/fhictora" + ";";

            // -- Vmware server login

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

        public void CloseConnection()
        {
            conn.Close();
        }

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

        public void Execute(string sql)
        {
            string query = sql;

            if (NewConnection())
            {
                // Command opzetten voor het uitvoeren van de query
                OracleCommand cmd = new OracleCommand(query, conn);

                // Query uitvoeren, er wordt geen waarde terug gegeven
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}
