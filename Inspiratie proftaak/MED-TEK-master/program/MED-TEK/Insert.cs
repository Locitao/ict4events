using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace MED_TEK
{
    class Insert
    {
        // Instantie aanmaken voor verbinding met database
        Connect verbinding = new Connect();
        // Elke databasetabel heeft een prefix
        string prefix = "rhbj_";


        //Nieuwe patient toevoegen in database
        public void Insert_Patient(string voornamen, string achternaam, string geboortedatum, string bsn, string bloedgroep, string pasfoto, string email, string telefoon, string mobiel, string adres, string gemeente, string provincie, string pascode)
        {
            // Sql statement opstellen
            string query = "INSERT INTO " + prefix + "patient (voornamen, achternaam, geboortedatum, bsn, bloedgroep, pasfoto, email, telefoon, mobiel, adres, gemeente, provincie, pascode) VALUES ('" + voornamen + "','" + achternaam + "','" + geboortedatum + "','" + bsn + "','" + bloedgroep + "','" + pasfoto + "','" + email + "','" + telefoon + "','" + mobiel + "','" + adres + "','" + gemeente + "','" + provincie + "','" + pascode + "')";

            // Sql statement uitvoeren dmv methode execute
            verbinding.Execute(query);
            
        }

        public void Insert_Ziekte(string naam)
        {
            // Sql statement opstellen
            string query = "INSERT INTO " + prefix + "ziekte (naam) VALUES ('" + naam + "')";

            // Sql statement uitvoeren dmv methode execute
            verbinding.Execute(query);
        }

        public void Insert_Medicijn(string naam, string gebruik, string bijwerking)
        {
            // Deze methode voegt een medicijn toe aan de database.
            // De velden die moeten worden ingevuld zijn naam, gebruik, bijwerking
            string query = "INSERT INTO " + prefix + "medicijn (naam, gebruik, bijwerking) VALUES ('" + naam + "','" + gebruik + "','" + bijwerking + "')";
            verbinding.Execute(query);
        }

        public void Insert_Afspraak(int medicatieID, int locatieID, string datum, string tijd, int actief)
        {
            // Deze methode voegt een nieuwe afspraak toe aan de database
            // Velden die verplicht moeten worden opgegeven zijn medicatieID, locatieID en datum
            // actief geeft aan of afspraak al is geweest of niet, 0 = niet actief / 1 = actief
            string query = "INSERT INTO " + prefix + "afspraak (medicatieID, locatieID, datum, tijd, actief) VALUES ('" + medicatieID + "','" + locatieID + "','" + datum + "','" + tijd + "','" + actief + "')";
            verbinding.Execute(query);

        }

        public void Insert_Medicatie(int patientID, int medicijnID, string gebruikStart, string gebruikEind, string hoeveelheid)
        {
            // Deze methode voegt een nieuwe medicatie voor een patient toe
            // PatientID en medicijnID moeten worden opgegeven
            string query = "INSERT INTO " + prefix + "medicatie (patientID, medicijnID, gebruikstart, gebruikeind, hoeveelheid) VALUES ('" + patientID + "','" + medicijnID + "','" + gebruikStart + "','" + gebruikEind + "','" + hoeveelheid + "')";
            verbinding.Execute(query);
        }

        public void Insert_Ziekteoverzicht(int ziekteID, int patientID, string symptomen)
        {
            // Deze methode wijst een bepaalde ziekte toe aan een bepaalde patient
            // De velden ziekteID en patientID zijn dus verplicht
            string query = "INSERT INTO " + prefix + "ziekteoverzicht (ziekteID, patientID, symptomen) VALUES ('" + ziekteID + "','" + patientID + "', '" + symptomen + "')";
            verbinding.Execute(query);
        }

        public void Insert_User(string username, string password, int locatieID)
        {
            string sql = "INSERT INTO " + prefix + "login (username, password, locatieID) VALUES ('" + username + "','" + password + "','" + locatieID + "')";

            verbinding.Execute(sql);
        }
    }
}
