using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//database access
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace Management_System
{
    
    public partial class Form1 : Form
    {
        private OracleConnection conn;
        public Form1()
        {
            conn = new OracleConnection();
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
            String user = "dbi320839";
            String pw = "ioMMVpigPp";

            conn.ConnectionString = "User Id=" + user + ";Password=" + pw + ";Data Source=" +
                                    "//192.168.15.50:1521/fhictora" + ";";
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
            btnConnect.Enabled = false;
            MessageBox.Show("Connection succeeded!");
        }
    }
}
