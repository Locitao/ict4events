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
    public partial class Apotheek : Form
    {
        Connect verbinding;
        int medicatieID;
        public Apotheek(Connect _verbinding)
        {
            InitializeComponent();
            verbinding = _verbinding;
            StartPosition = FormStartPosition.CenterScreen; 

        }

        private void Apotheek_Load(object sender, EventArgs e)
        {
            refresh_data();
        }

        Select select = new Select();
        Miscellaneous overig = new Miscellaneous();
        private Update update = new Update();
        private void refresh_data()
        {
            cbActieveAfspraken.Items.Clear();
            //benodigde patiëntgegevens ophalen en weergeven
            var patientgegevens = select.Select_Patient_Apotheek(verbinding.patientID);
            var medicatiegegevens = select.Select_Medicatie(verbinding.patientID);
            var medicijngegevens = select.Select_Medicijn();
            var afspraakgegevens = select.Select_Patient_Afspraken(verbinding.patientID);
            var medicatiegebruik = select.Select_MedicatieGebruik(verbinding.patientID);
            var medicatiebijwerkingen = select.Select_MedicatieBijwerking(verbinding.patientID);

            int i = 0;
            int j = 0;
            int a = 0;
            int z = 0;
            int x = 0;
            int l = 0;
            int b = 0;
            for (i = 0; i < 1; ++i)
            {
                for (j = 0; j < patientgegevens.Count; ++j)
                {
                    Dictionary<string, object> row = patientgegevens[j];
                    tbVoorNamen.Text = (string) row["voornamen"];
                    tbAchternaam.Text = (string) row["achternaam"];
                    string date = (string) row["geboortedatum"];
                    dtpGeboorte.Text = date;
                    tbAdres.Text = (string) row["adres"];
                    pbPasfoto.Load(verbinding.pasfoto);
                }

                for (a = 0; a < medicatiegegevens.Count; ++a)
                {
                    Dictionary<string, object> row = medicatiegegevens[a];
                    tbGebruiksStart.Text = (string) row["gebruikstart"];
                    tbGebruiksEinde.Text = (string) row["gebruikeind"];
                    tbHoeveelheid.Text = (string) row["hoeveelheid"];
                    medicatieID = Convert.ToInt32(row["medicatieID"]);


                }

                for (z = 0; z < medicijngegevens.Count; ++z)
                {
                    Dictionary<string, object> row = medicijngegevens[z];
                    tbNaamMedicijn.Text = (string) row["naam"];
                    

                    
                }

                for (x = 0; x < afspraakgegevens.Count; ++x)
                {
                    Dictionary<string, object> row = afspraakgegevens[x];
                    cbActieveAfspraken.Items.Add(" " + row["medicatieID"] + " - " + row["datum"] + " - " + row["naam"]);
                }

                for (l = 0; l < medicatiegebruik.Count; ++l)
                {
                    Dictionary<string, object> row = medicatiegebruik[l];
                    tbGebruik.Text = (string) row["gebruik"];
                }

                for (b = 0; b < medicatiebijwerkingen.Count; ++b)
                {
                    Dictionary<string, object> row = medicatiebijwerkingen[b];
                    tbBijwerkingen.Text = (string)row["bijwerking"];
                }
                
                // Pasfoto van patient laten zien in picturebox
                pbPasfoto.Load(verbinding.pasfoto);
                // pasfoto passend maken voor picturebox
                pbPasfoto.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void cbOpgehaald_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Apotheek_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void linkAfmelden_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Patient afmelden
            // Gegevens weghalen en scan form weergeven

            verbinding.patientID = 0; // int, dus null gaat niet
            verbinding.pasfoto = null;

            scan scan = new scan(verbinding);
            this.Hide();
            scan.Show();
        }

        private void linkProgramAfmelden_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            verbinding.locatie = null;
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void btnUpdateActief_Click(object sender, EventArgs e)
        {
            if (cbActiefUpdate.Checked)
            {
              //string actieveAfspraak = overig.GetSubstringByString("ID ", " -", Convert.ToString(cbActieveAfspraken.SelectedItem));
                string medicatieIDstring = overig.GetSubstringByString(" ", " -", Convert.ToString(cbActieveAfspraken.SelectedItem));
                int error = 0;

                if (cbActieveAfspraken.SelectedItem == null)
                {
                    ++error;
                    MessageBox.Show("Er is geen afspraak geselecteerd!");
                }
                else
                {
                    update.Update_Afspraak_actief(medicatieIDstring, "0");
                    cbActieveAfspraken.Items.Clear();
                    
                    cbActiefUpdate.Checked = false;
                    refresh_data();
                    cbActieveAfspraken.SelectedItem = null;
                    cbActieveAfspraken.SelectedIndex = 0;
                }
            }
           
        }
    }
}
