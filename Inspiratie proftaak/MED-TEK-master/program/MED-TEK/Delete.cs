using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MED_TEK
{
    class Delete
    {

        Connect verbinding = new Connect();
        string prefix = "rhbj_";

        public void Delete_Medicijn(int medicijnID)
        {
            // Verwijder een medicijn wat gelijk is aan het opgegeven medicijnID

            string query = " DELETE FROM " + prefix + "medicijn WHERE medicijnID = '" + medicijnID + "'";

            verbinding.Execute(query);


        }

        public void Delete_Afspraak(int medicatieID)
        {
            // verwijder een afspraak wat gelijk is aan het opgegeven medicatieID, patientID en datum

            string query = "DELETE FROM " + prefix + "afspraak WHERE " + prefix + "afspraak.medicatieID = '" + medicatieID + "'";

            verbinding.Execute(query);

        }

        public void Delete_Ziekte(int ziekteID)
        {
            // Verwijder een ziekte wat gelijk is aan het opgegeven ziekteID

            string query = " DELETE FROM " + prefix + "ziekte WHERE ziekteID = '" + ziekteID + "'";

            verbinding.Execute(query);

        }

        public void Delete_Ziekteoverzicht(int ziekteID)
        {
            // Verwijder een ziekteoverzicht wat gelijk is aan de opgegeven waarden

            string query = "DELETE FROM " + prefix + "ziekteoverzicht WHERE ziekteID = '" + ziekteID + "'";

            verbinding.Execute(query);

        }

    }
}
