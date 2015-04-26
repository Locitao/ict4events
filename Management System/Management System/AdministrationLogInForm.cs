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
    
    public partial class AdministrationLogInForm : Form
    {
        DatabaseConnection connection = new DatabaseConnection();
        
        public AdministrationLogInForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Checks if the input is correct and if the user has access
        /// </summary>
        /// <returns>true if the user has access, false if the user hasn't</returns>
        private bool LoginAsEmployee()
        {
            string loginName = tbName.Text;
            string password = tbPassword.Text;
            string query = "SELECT employee_rights from pt_employee_acc WHERE LOGIN_NAME = '" + loginName + "' AND login_password = '" + password + "'";
            List<List<string>> output;
            Exception ex;
            if (connection.SQLQueryWithOutput(query, out output, out ex))
            {
                if (output.Count > 0)
                {
                    if (Convert.ToInt32(output[0][0]) >= 1)
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("The following error has occured:" + Environment.NewLine + ex.ToString());
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Checks if the input is correct and if the user has access as admin
        /// </summary>
        /// <returns>true if the user has access, false if the user hasn't</returns>
        private bool LoginAsAdmin()
        {
            string loginName = tbName.Text;
            string password = tbPassword.Text;
            string query = "SELECT employee_rights from pt_employee_acc WHERE LOGIN_NAME = '" + loginName + "' AND login_password = '" + password + "'";
            List<List<string>> output;
            Exception ex;
            if (connection.SQLQueryWithOutput(query, out output, out ex))
            {
                if (output.Count > 0)
                {
                    if (Convert.ToInt32(output[0][0]) >= 2)
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("The following error has occured:" + Environment.NewLine + ex.ToString());
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// start the management system form if the login is correct.
        /// </summary>
        private void btnLoginToManagementSystem_Click(object sender, EventArgs e)
        { 
            if (LoginAsEmployee())
            {
                EventManagementSystemForm form = new EventManagementSystemForm();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("UserName and password not recognized");
            }
        }

        /// <summary>
        /// start the material renting form if the login is correct.
        /// </summary>
        private void btnLogInMaterialRenting_Click(object sender, EventArgs e)
        {
            if (LoginAsEmployee())
            {
                MaterialRentingForm form = new MaterialRentingForm();
                form.ShowDialog();
            }
            else 
            {
                MessageBox.Show("UserName and password not recognized");
            }
        }

        /// <summary>
        /// start the create account form if the login is correct.
        /// </summary>
        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            if (LoginAsAdmin())
            {
                CreateAccountForm form = new CreateAccountForm();
                form.ShowDialog();
                if (form.saved)
                {
                    Exception exception;
                    string query = form.Query;
                    if(connection.SQLQueryNoOutput(query, out exception))
                    {
                        MessageBox.Show("New Account is Added. Don't forget the username and password!");
                    }
                    else
                    {
                        MessageBox.Show(exception.ToString());
                    }
                }
            }
            else
            {
                MessageBox.Show("UserName and password not recognized");
            }
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

        private void btnControlGuestAccount_Click(object sender, EventArgs e)
        {

        }
    }
}
