using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace MED_TEK
{
    public class Connect
    {
        // Fields
        public MySqlConnection connection;
        private string server; // Hostname
        private string user; // Database user name
        private string password; // Database password
        private string database; // Database name
        private string prefix = "xxx";
        public string login_locatie;
        private string connectionstring;
        public string pasfoto;
        public int patientID;
        public string error = "";

        public string locatie;

        // Constructor
        public Connect()
        {
            Initialize();
        }

        public MySqlConnection Initialize()
        {
            server = "xxx";
            user = "xxx";
            password = "xxx";
            database = "xxx";

            connectionstring = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + user + ";" + "PASSWORD=" + password + ";";

            return connection = new MySqlConnection(connectionstring);
        }
        //open connection to database
        public bool Open_Connection()
        {
            try
            {
                connection.Open();
                return true; // verbinding gelukt
            }
            catch (MySqlException ex)
            {
                // Error handling voor verbinding met database
                switch (ex.Number)
                {
                    case 0:
                        error = "Verbinding met de database is mislukt!\n\nEr kon geen verbinding worden gemaakt met de database.\nDe oorzaak hiervan kan zijn dat de gebruikersnaam of het wachtwoord van de database niet correct zijn\nof dat het IP adres van deze computer niet bekend is bij de database.\n\nContacteer de systeembeheerder als dit probleem zich blijft voordoe.\n(Error code: 0)";
                        // Verbinding met database kon niet tot stand worden gebracht
                        Console.WriteLine("Verbinding mislukt! Kan niet verbinden met server, klopt de host en database naam?");
                        break;

                    case 1045:
                        error = "Verbinding met de database is mislukt!\n\nEr kon geen verbinding worden gemaakt met de database.\nDe oorzaak hiervan kan zijn dat de gebruikersnaam of het wachtwoord van de database niet correct zijn\nof dat het IP adres van deze computer niet bekend is bij de database.\n\nContacteer de systeembeheerder als dit probleem zich blijft voordoe.\n(Error code: 1045)";
                        // Verbinding met database is mislukt, verkeerd wachtwoord of gebruikersnaam
                        Console.WriteLine("Verbinding mislukt! Kan niet verbinden met server, klopt de gebruikersnaam en het wachtwoord?");
                        break;
                }
                return false; // verbinding mislukt
            }
        }

        //Close connection
        public bool Close_Connection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Sluiten van verbinding mislukt: " + ex);
                return false;
            }
        }

        public void Execute(string sql)
        {
            string query = sql;


            if(this.Open_Connection() == true)
            {
                // Command opzetten voor het uitvoeren van de query
                MySqlCommand cmd = new MySqlCommand(query, connection);

                // Query uitvoeren, er wordt geen waarde terug gegeven
                cmd.ExecuteNonQuery();
                this.Close_Connection();
            }
        }

        
       public List<string> Execute_values(string sql)
        {
            string query = sql;
            List<string> values = new List<string>();
           
           if(this.Open_Connection() == true)
           {
               MySqlCommand cmd = new MySqlCommand(query, connection);
               MySqlDataReader reader = cmd.ExecuteReader();

               reader.Read();

               for(int i = 0; i < reader.FieldCount; ++i)
               {
                   values.Add(reader.GetValue(i).ToString());
                   
               }
               
                   
               
               return values;
                    
           }
           return values;

           this.Close_Connection();
        }

       // <summary>
       /// Executes query and returns the result in a processable format. MySqlExceptions will be had.
       /// </summary>
       /// <returns>List&lt;Dictionary&lt;&lt;fieldName, value&gt;&gt; or null on failure</returns>
       public static List<Dictionary<string, object>> ExecuteQuery(string query)
       {
           List<Dictionary<string, object>> result = new List<Dictionary<string, object>>();

           Connect verbinding = new Connect();

           verbinding.Close_Connection();
           verbinding.Initialize();

           if (verbinding.Open_Connection() == true)
           {

               MySqlDataReader resultReader = new MySqlCommand(query, verbinding.connection).ExecuteReader();
               //loop through the rows and add them to the result
               while (resultReader.Read())
               {
                   Dictionary<string, object> row = new Dictionary<string, object>();

                   //loop through the fields and add them to the row
                   for (int fieldId = 0; fieldId < resultReader.FieldCount; fieldId++)
                       row.Add(resultReader.GetName(fieldId), resultReader.GetValue(fieldId));

                   result.Add(row);
               }

               return result;
           }
           else
           {
               return result;
           }
       }

        public string login(string username, string password)
        {

            // SQL-statement opstellen
            string sql = "SELECT locatienaam FROM " + prefix + "locatie, " + prefix + "login WHERE " + prefix + "login.username = '" + username + "' AND " + prefix + "login.password = '" + password + "' AND " + prefix + "login.locatieID = " + prefix + "locatie.locatieID"; 

            if(this.Open_Connection() == true)
            {
                // Command opzetten voor het uitvoeren van de query
                using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        StringBuilder sb = new StringBuilder();
                        while(reader.Read())
                        {
                            sb.Append(reader.GetString(0)).ToString();
                        }
                        locatie = sb.ToString();
                        this.Close_Connection();
                        return sb.ToString();
                    }
                }
                
            }
            else
            {
                string result = "Kon geen verbinding maken met database!";
                return result;
            }

        }
    }
}
