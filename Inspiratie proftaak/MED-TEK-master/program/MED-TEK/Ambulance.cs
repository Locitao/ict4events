using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace MED_TEK
{
    public partial class Ambulance : Form
    {
        Connect verbinding;
        public Ambulance(Connect _verbinding)
        {
            InitializeComponent();
            verbinding = _verbinding;
            StartPosition = FormStartPosition.CenterScreen; 

        }

        Select select = new Select();
        Miscellaneous overig = new Miscellaneous();

        private void refresh_data()
        {
            // Benodigde patientgegevens voor ambulance ophalen en weergeven
            var patientgegevens = select.Select_Patient_Auto(verbinding.patientID);
            var ziektegegevens = select.Select_Ziekteoverzicht(verbinding.patientID);
            var medicatiegegevens = select.Select_Medicatie(verbinding.patientID);
            int i = 0;
            int j = 0;
            int a = 0;
            int x = 0;

            for (j = 0; j < 1; ++j)
            {
                for (i = 0; i < patientgegevens.Count; ++i)
                {
                    Dictionary<string, object> row = patientgegevens[i];
                    tbVoornamen.Text = (string)row["voornamen"];
                    tbAchternaam.Text = (string)row["achternaam"];
                    tbBloedgroep.Text = (string)row["bloedgroep"];
                    string date = (string)row["geboortedatum"];
                    dtpDoB.Text = date;
                }

                for (a = 0; a < ziektegegevens.Count; ++a)
                {
                    Dictionary<string, object> row = ziektegegevens[a];
                    lbZiektes.Items.Add(row["naam"]);
                    
                }

                for (x = 0; x < medicatiegegevens.Count; ++x)
                {
                    Dictionary<string, object> row = medicatiegegevens[x];
                    lbMedicatie.Items.Add(row["naam"]);
                }
            }

            // Pasfoto van patient laten zien in picturebox
            pbPasfoto.Load(verbinding.pasfoto);
            // pasfoto passend maken voor picturebox
            pbPasfoto.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void Ambulance_Load(object sender, EventArgs e)
        {
            tbVoornamen.Enabled = false;
            tbAchternaam.Enabled = false;
            tbBloedgroep.Enabled = false;
            dtpDoB.Enabled = false;
            pbPasfoto.Enabled = false;
            lbZiektes.Enabled = false;
            lbMedicatie.Enabled = false;

            refresh_data();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void Ambulance_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

     

       

       

        private void llPatientAfmelden_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            verbinding.patientID = 0;
            verbinding.pasfoto = null;

            scan scan = new scan(verbinding);
            this.Hide();
            scan.Show();
        }

        private void llAfmelden_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            verbinding.locatie = null;

            Login login = new Login();
            this.Hide();
            login.Show();

            //MessageBox.Show("Gebruik de knop 'patient afmelden' en klik vervolgens op afmelden om u volledig bij het programma af te melden.");
        }
    }
}
