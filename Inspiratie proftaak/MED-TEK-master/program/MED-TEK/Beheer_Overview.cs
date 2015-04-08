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
    public partial class Beheer_Overview : Form
    {

        Connect verbinding = new Connect();
        public Beheer_Overview()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen; 

        }

        private void Beheer_Overview_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(255, 255, 255);
        }


        // Onderstaande event handlers roepen een nieuw formulier aan. Afhankelijk van wat de gebruiker wilt doen
        // Er zijn 3 verschillende formulieren
        // Beheer_Insert -> Dit formulier maakt het mogelijk om gegevens toe te voegen in de database
        // Beheer_Update -> Dit formulier maakt het mogelijk om gegevens te wijzigen in de database
        // Beheer_Delete -> Dit formulier maakt het mogelijk om gegevens te verwijderen in de database
        private void btnInsert_Click(object sender, EventArgs e)
        {
            Beheer_Insert insert = new Beheer_Insert();
            insert.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Beheer_Update update = new Beheer_Update();
            update.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Beheer_Delete delete = new Beheer_Delete();
            delete.Show();
        }

        private void lblAfmelden_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Locatie van gebruiker op null zetten
            verbinding.locatie = null;

            // Huidig venster sluiten
            this.Hide();

            // Login venster tonen
            Login login = new Login();
            login.Show();

        }

        private void Beheer_Overview_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void Beheer_Overview_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
