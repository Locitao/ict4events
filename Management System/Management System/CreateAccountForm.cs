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
        public string Query;

        /// <summary>
        /// this form is used to create a new employee account
        /// </summary>
        public CreateAccountForm()
        {
            InitializeComponent();
            saved = false;
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            if (tbPassword.Text == tbRepeatPassword.Text)
            {
                saved = true;
                Query = "INSERT INTO PT_EMPLOYEE_ACC(EMPLOYEE_ID, LOGIN_NAME, LOGIN_PASSWORD, EMPLOYEE_RIGHTS) VALUES (auto_inc_emp.nextval, '" + tbName.Text + "', '" + tbPassword.Text + "', '1')";
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Makes sure the user can only type letters and digits.
        /// </summary>
        private void tb_KeyPress_LettersAndDigits(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
