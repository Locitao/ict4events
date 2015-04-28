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
            cbRights.Items.Add("No rights");
            cbRights.Items.Add("Employee");
            cbRights.Items.Add("Admin");
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            if (tbPassword.Text == tbRepeatPassword.Text)
            {
                saved = true;
                string tempString;
                switch ((string)cbRights.SelectedItem)
                {
                    case "No Rights": { tempString = "0"; break; }
                    case "Employee": { tempString = "1"; break; }
                    case "Admin": { tempString = "2"; break; }
                    default: { tempString = "0"; break; }
                }
                Query = "Insert into PT_EMPLOYEE_ACC(employee_ID, login_name, login_password, employee_rights, acc_name, acc_address, phone_number) VALUES (auto_inc_emp.nextval, '" + tbName.Text + "', '" + tbPassword.Text + "', '" + tempString + "', '" +  tbName.Text +"', '" + tbAddress.Text + "', '" + tbPhoneNumber.Text + "')";
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

        /// <summary>
        /// makes sure the user can only type digits.
        /// </summary>
        private void tb_KeyPress_Digits(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
