﻿using System;
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
    
    public partial class AdministrationLogInForm : Form
    {
        private bool loggedIn = false;
        DatabaseConnection connection = new DatabaseConnection();
        
        public AdministrationLogInForm()
        {
            InitializeComponent();
        }


        private bool Login(string username, string password)
        {
            return false;
        }

        private void LogOut()
        {
            loggedIn = false;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            /*MessageBox.Show(connection.OpenConnection()
                ? "Connection with database succeeded."
                : "Check your settings, connection to database failed!");
            connection.CloseConnection();*/
            List<List<string>> listtest;
            connection.SQLQueryWithOutput("", out listtest);
        }

        

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login(tbame.Text, tbPassword.Text);
        }

        private void btnLoginToManagementSystem_Click(object sender, EventArgs e)
        {

        }

        private void btnLogInMaterialRenting_Click(object sender, EventArgs e)
        {

        }
    }
}
