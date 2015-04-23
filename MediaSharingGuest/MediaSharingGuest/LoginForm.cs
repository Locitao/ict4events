using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaSharingGuest
{
    /// <summary>
    /// This form handles logging in to the mediasharing application.
    /// </summary>
    public partial class LoginForm : Form
    {
        //Fields-----------------------------
        Connection connect = new Connection();
        Select select = new Select();
        Protection protection = new Protection();
        List<List<string>> output = new List<List<string>>();

        //Constructor-----------------------
        public LoginForm()
        {
            InitializeComponent();
            rbUser.Checked = true;
        }

        //Methods---------------------------
        /// <summary>
        /// Login method. this method get's the users password out of the database and compares it to the given password.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        public void LogIn(string username, string password)
        {
            //Query that returns password of the username.
            connect.SQLQueryWithOutput(select.GetPassword(username), out output);

            if (output.Count > 0)
            {
                string tablePassword = output[0][0];

                if (password == tablePassword)
                {
                    ViewReports viewReports = new ViewReports();
                    this.Hide();
                    viewReports.Show();
                }
                else MessageBox.Show("Wrong password!");
            }
            else MessageBox.Show("Wrong username!");
        }

        /// <summary>
        /// Login method. this method checks if the user's rfid exists, and logs you in if it does.
        /// </summary>
        /// <param name="rfidcode"></param>
        public void LogIn(string rfidcode)
        {
            //Query that returns Name of the user, if no name then no login.
            connect.SQLQueryWithOutput(select.GetName(rfidcode), out output);

            if (output.Count > 0)
            {
                string Username = output[0][0];
                string RfidCode = output[0][1];
                
                    MediaSharingSystem ms = new MediaSharingSystem(RfidCode, Username);
                    GuestForm guestform = new GuestForm(ms, 2);
                    this.Hide();
                    guestform.Show();
            }

            else
            {
                MessageBox.Show("Wrong RFID Code!");
            }
        }

        ///Events------------------------------------

        /// <summary>
        ///  this button click calls the login events and logs you in when the data matches.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (rbUser.Checked == true)
            {
                LogIn(protection.ProtectAgainstSQLInjection(tbUserOrRFID.Text));
            }
            else if (rbAdmin.Checked == true)
            {
                LogIn(protection.ProtectAgainstSQLInjection(tbUserOrRFID.Text), protection.ProtectAgainstSQLInjection(tbPassword.Text));
            }
        }

        /// <summary>
        /// Closes the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Event that changes the login settings when the admin checkbox is changed.
        private void rbAdmin_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAdmin.Checked == true)
            {
                lblUserOrRFID.Text = "Username:";
                lblPassword.Visible = true;
                tbPassword.Visible = true;
            }
            else if (rbAdmin.Checked == false)
            {
                lblUserOrRFID.Text = "RFID code:";
                lblPassword.Visible = false;
                tbPassword.Visible = false;
            }
        }

        //Event that changes the login settings when the user checkbox is changed.
        private void rbUser_CheckedChanged(object sender, EventArgs e)
        {
            if (rbUser.Checked == true)
            {
                lblUserOrRFID.Text = "RFID code:";
                lblPassword.Visible = false;
                tbPassword.Visible = false;
            }
            else if (rbUser.Checked == false)
            {
                lblUserOrRFID.Text = "Username:";
                lblPassword.Visible = true;
                tbPassword.Visible = true;
            }
        }
    }
}
