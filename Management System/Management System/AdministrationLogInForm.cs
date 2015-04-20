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

        private bool Login()
        {
            string loginName = tbame.Text;
            string password = tbPassword.Text;
            string query = "SELECT employee_rights from pt_employee_acc WHERE LOGIN_NAME = '" + loginName + "' AND login_password = '" + password + "'";
            List<List<string>> output;
            Exception ex;
            if (connection.SQLQueryWithOutput(query, out output, out ex))
            {
                if (output.Count > 0)
                {
                    if (Convert.ToInt32(output[0][0]) > 0)
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

        private void btnLoginToManagementSystem_Click(object sender, EventArgs e)
        {
            if (Login())
            {
                EventManagementSystemForm form = new EventManagementSystemForm();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("UserName and password not recognized");
            }
        }

        private void btnLogInMaterialRenting_Click(object sender, EventArgs e)
        {
            if (Login())
            {
                MaterialRentingForm form = new MaterialRentingForm();
                form.ShowDialog();
            }
            else 
            {
                MessageBox.Show("UserName and password not recognized");
            }
        }
    }
}
