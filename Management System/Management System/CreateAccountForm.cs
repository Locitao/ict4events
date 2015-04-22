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
    public partial class CreateAccountForm : Form
    {
        public bool saved;
        public CreateAccountForm()
        {
            InitializeComponent();
            saved = false;
            connection = new DatabaseConnection();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            if (lblPassword.Text == lblRepeatPassword.Text)
            {
                saved = true;
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
