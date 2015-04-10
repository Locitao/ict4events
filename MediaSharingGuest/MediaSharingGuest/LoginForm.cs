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

        public void LogIn(string Username, string Password)
        {

        }

        public void LogIn(string Rfidcode)
        {

        }

        public void LogOut()
        {
            Password = null;
            Username = null;
            Rfidcode = null;
        }
    }
}
