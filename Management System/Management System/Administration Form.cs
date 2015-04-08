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
        Connection connect = new Connection();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Login()
        {
            
        }

        private void LogOut()
        {
            
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            MessageBox.Show(connect.NewConnection()
                ? "Connection with database succeeded."
                : "Check your settings, connection to database failed!");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            connect.CloseConnection();
        }
    }
}
