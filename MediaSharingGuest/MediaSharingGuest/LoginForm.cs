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
    public partial class LoginForm : Form
    {
        Connection connect = new Connection();
        Select select = new Select();
        List<List<string>> output = new List<List<string>>();

        public LoginForm()
        {
            InitializeComponent();
            rbUser.Checked = true;
           
        }

        public string Rfidcode { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

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

        public void LogIn(string username, string password)
        {
            //Query that returns password of the username.
            select.GetPassword(username);

            string tablePassword;

            if (password == Password)
            {
                //MediaSharingSystem ms = new MediaSharingSystem(username);
                //GuestForm guestform = new GuestForm(ms);
            }

            else
            {
                MessageBox.Show("Wrong password or username");
            }
        }

        public void LogIn(string rfidcode)
        {
            //Query that returns Name of the user, if no name then no login.
            connect.SQLQueryWithOutput(select.GetName(rfidcode), out output);

            if (output == null)
            {
                output[0][0] = "";
            }

            Username = output[0][0];

            if (Username != "")
            {
                //Query that returns the warnlv 
                string rfidCode = "";
                MediaSharingSystem ms = new MediaSharingSystem(rfidCode, Username);
                GuestForm guestform = new GuestForm(ms);
                this.Hide();
                guestform.Show();
            }

            else
            {
                MessageBox.Show("Wrong password or username");
            }
        }

        public void LogOut()
        {
            Password = null;
            Username = null;
            Rfidcode = null;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (rbUser.Checked == true)
            {
                LogIn(tbUserOrRFID.Text);
            }
            else if (rbAdmin.Checked == true)
            {
                LogIn(tbUserOrRFID.Text, tbPassword.Text);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
