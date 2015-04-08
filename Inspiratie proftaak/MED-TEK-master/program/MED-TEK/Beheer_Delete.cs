using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MED_TEK
{
    public partial class Beheer_Delete : Form
    {
        Select select = new Select();
        Connect verbinding = new Connect();
        Miscellaneous overig = new Miscellaneous();
        Delete delete = new Delete();

        public Beheer_Delete()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        private void Beheer_Delete_Load(object sender, EventArgs e)
        {
            cbSelecteerZiektePatient.Enabled = false;
            btnVerwijderZiektePatient.Enabled = false;

            // Gegevens in formulier verversen
            refresh();

        }

        private void refresh()
        {
            // gegevens van comboboxes verwijderen om het weergegeven van dubbele data te voorkomen
            cbSelectAfspraak.Items.Clear();
            cbSelectMedicijn.Items.Clear();
            cbSelectZiekte.Items.Clear();

            var medicijnen = select.Select_Medicijn();
            var ziekte = select.Select_Ziekte();
            var afspraak = select.Select_Afspraak_All();

            lbOverzichtZiektePatient.Items.Clear();
            lbOverzichtAfspraken.Items.Clear();
            lbOverzichtMedicijnen.Items.Clear();
            lbOverzichtZiekte.Items.Clear();


            for(int i = 0; i < 1; ++i)
            {
                for(int a = 0; a < medicijnen.Count; ++a)
                {
                    Dictionary<string, object> row = medicijnen[a];
                    lbOverzichtMedicijnen.Items.Add(row["naam"]);
                    cbSelectMedicijn.Items.Add("ID " + row["medicijnID"] + " - " + row["naam"]);
                }
                for(int b = 0; b < ziekte.Count; ++b)
                {
                    Dictionary<string, object> row = ziekte[b];
                    lbOverzichtZiekte.Items.Add(row["naam"]);
                    cbSelectZiekte.Items.Add("ID " + row["ziekteID"] + " - " + row["naam"]);
                }
                for(int c = 0; c < afspraak.Count; ++c)
                {
                    Dictionary<string, object> row = afspraak[c];
                    cbSelectAfspraak.Items.Add("ID " + row["medicatieID"] + " - " + row["voornamen"] + " " + row["achternaam"]);
                    lbOverzichtAfspraken.Items.Add("ID " + row["medicatieID"] + " - " + row["voornamen"] + " " + row["achternaam"]);
                }
            }
        }

        private void btnZoekZiektePatient_Click(object sender, EventArgs e)
        {
            string pascode = tbPascode.Text;
            var ziektePatient = select.Select_Ziekteoverzicht_Pascode(pascode);

            if (pascode != "")
            {
                for (int i = 0; i < ziektePatient.Count; ++i)
                {
                    Dictionary<string, object> row = ziektePatient[i];
                    cbSelecteerZiektePatient.Items.Add("ID " + row["ziekteID"] + " - " + row["naam"]);
                    lbOverzichtZiektePatient.Items.Add(row["naam"]);
                }

                tbPascode.Enabled = false;
                btnZoekZiektePatient.Enabled = false;

                cbSelecteerZiektePatient.Enabled = true;
                btnVerwijderZiektePatient.Enabled = true;
            }
            else
            {
                MessageBox.Show("Geef pascode op!");
            }
        }

        private void btnVerwijderZiektePatient_Click(object sender, EventArgs e)
        {
            string ziekteIDstring = overig.GetSubstringByString("ID ", " -", Convert.ToString(cbSelecteerZiektePatient.SelectedItem));

            if (ziekteIDstring == "")
            {
                MessageBox.Show("Selecteer een ziekte van de patient!");
            }
            else
            {
                int ziekteID = Convert.ToInt32(ziekteIDstring);
                delete.Delete_Ziekteoverzicht(ziekteID);
                MessageBox.Show("Ziekte succesvol verwijderd van patient!");
                refresh();
            }
        }

        private void btnVerwijderZiekte_Click(object sender, EventArgs e)
        {
            string ziekteIDstring = overig.GetSubstringByString("ID ", " -", Convert.ToString(cbSelectZiekte.SelectedItem));

            if(ziekteIDstring == "")
            {
                MessageBox.Show("Selecteer een ziekte om te verwijderen");
            }
            else
            {
                int ziekteID = Convert.ToInt32(ziekteIDstring);
                delete.Delete_Ziekte(ziekteID);
                MessageBox.Show("De ziekte is succesvol verwijderd!");

                refresh();

                cbSelectZiekte.SelectedItem = null;
                cbSelectZiekte.SelectedIndex = 0;
            }
        }

        private void btnVerwijderAfspraak_Click(object sender, EventArgs e)
        {
            string afspraakIDstring = overig.GetSubstringByString("ID ", " -", Convert.ToString(cbSelectAfspraak.SelectedItem));

            if(afspraakIDstring == "")
            {
                MessageBox.Show("Selecteer een afspraak om te verwijderen!");
            }
            else
            {
                int afspraakID = Convert.ToInt32(afspraakIDstring);
                delete.Delete_Afspraak(afspraakID);
                MessageBox.Show("De afspraak is succesvol verwijderd!");

                refresh();

                cbSelectAfspraak.SelectedItem = null;
                cbSelectAfspraak.SelectedIndex = 0;

            }
        }

        private void btnVerwijderMedicijn_Click(object sender, EventArgs e)
        {
            string medicijnIDstring = overig.GetSubstringByString("ID ", " -", Convert.ToString(cbSelectMedicijn.SelectedItem));

            if(medicijnIDstring == "")
            {
                MessageBox.Show("Selecteer een medicijn om te verwijderen!");
            }
            else
            {
                int medicijnID = Convert.ToInt32(medicijnIDstring);
                delete.Delete_Medicijn(medicijnID);
                MessageBox.Show("Het medicijn is succesvol verwijderd!");

                refresh();

                cbSelectMedicijn.SelectedItem = null;
                cbSelectMedicijn.SelectedIndex = 0;
            }
        }
    }
}
