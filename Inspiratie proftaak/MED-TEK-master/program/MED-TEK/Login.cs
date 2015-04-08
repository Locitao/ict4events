using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography; // Dit wordt gebruikt om gegevens te versleutelen

namespace MED_TEK
{
    public partial class Login : Form
    {
        Connect verbinding = new Connect();
        Miscellaneous overig = new Miscellaneous();

        public Login()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen; 
        }

        private void lblForgotPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Om uw wachtwoord opnieuw in te stellen, neemt u contact op met de programma beheerder.");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            scan scan = new scan(verbinding);

            string username = tbUsername.Text;
            string password = overig.versleutel(tbPassword.Text);
            string login = verbinding.login(username, password);

            if (verbinding.error != "")
            {
                MessageBox.Show(verbinding.error);
            }
            else if(login != "")
            {
               // De methode login() geeft een locatie terug
               // Controleer bij welke locatie wordt aangemeld en open het bijbehorende formulier
                if (login == "doctor")
                {
                    // Login locatie aanvullen zodat juiste formulier wordt geladen nadat pas is gescant
                    verbinding.login_locatie = login;

                    // Open formulier van doctor
                    this.Hide();
                    scan.Show();

                }
                else if (login == "ambulance")
                {
                    // Login locatie aanvullen zodat juiste formulier wordt geladen nadat pas is gescant
                    verbinding.login_locatie = login;

                    // Open formulier van ambulance
                    this.Hide();
                    scan.Show();
                }
                else if (login == "apotheek")
                {
                    // Login locatie aanvullen zodat juiste formulier wordt geladen nadat pas is gescant
                    verbinding.login_locatie = login;

                    // Open formulier van apotheek
                    this.Hide();
                    scan.Show();
                }
                else if(login == "beheer")
                {
                    // Login locatie aanvullen zodat juiste formulier wordt geladen nadat pas is gescant
                    verbinding.login_locatie = login;

                    // Open formulier van beheer   
                    this.Hide();
                    Beheer_Overview beheer = new Beheer_Overview();
                    beheer.FormClosed += beheer_FormClosed;
                    beheer.Show();

                }
            }
            else
            {
              tbUsername.Text = "";
                    tbPassword.Text = "";
                    MessageBox.Show(
                        "Het inloggen is mislukt. Controleer uw gebruikersnaam en wachtwoord. Wanneer dit probleem zich blijf voordoen, neem dan contact op met uw systeem beheerder.");
                
            }
        }

        private void beheer_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            // Deze code zorgt ervoor dat het wachtwoord niet zichtbaar is wanneer het wordt ingetypt
            tbPassword.PasswordChar = Convert.ToChar("*");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void lblCLose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
