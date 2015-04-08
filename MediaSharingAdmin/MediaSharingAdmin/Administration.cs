using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaSharingAdmin
{
    public partial class Administration : Form
    {
        Connection connect = new Connection();
        public Administration()
        {
            InitializeComponent();
        }

        private void Administration_Load(object sender, EventArgs e)
        {

        }

        public void Login()
        {
            
        }

        public void ShowReports()
        {
            
        }


        private void btnConnect_Click(object sender, EventArgs e)
        {
            MessageBox.Show(connect.NewConnection()
                ? "Connection with database succeeded."
                : "Check your settings, connection to database failed!");
        }

        private void Administration_FormClosing(object sender, FormClosingEventArgs e)
        {
            connect.CloseConnection();
        }
    }
}
