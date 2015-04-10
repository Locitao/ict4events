using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Management_System
{
    
    public partial class Form1 : Form
    {
        private bool loggedIn = false;
        Connection connection = new Connection();
        
        public Form1()
        {
            InitializeComponent();
        }


        private bool Login(string username, string password)
        {
            if (connection.LogIn(username, password))
            {
                loggedIn = true;
                return true;
            }
            else { return false; }
        }

        private void LogOut()
        {
            loggedIn = false;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            MessageBox.Show(connection.OpenConnection()
                ? "Connection with database succeeded."
                : "Check your settings, connection to database failed!");
            connection.CloseConnection();
        }

        

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login(tbame.Text, tbPassword.Text);
        }
    }
}
