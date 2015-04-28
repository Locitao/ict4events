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
    public partial class ControlEmployeeAccountsForm : Form
    {
        DatabaseConnection connection = new DatabaseConnection();
        public ControlEmployeeAccountsForm()
        {
            InitializeComponent();
            cbRights.Items.Add("No rights");
            cbRights.Items.Add("Employee");
            cbRights.Items.Add("Admin");
            RefreshEmployeeListbox();
        }

        private void RefreshEmployeeListbox()
        {
            lbEmployeeAccounts.Items.Clear();
            List<List<string>> output;
            Exception exception;
            if (connection.SQLQueryWithOutput("SELECT EMPLOYEE_ID, LOGIN_NAME, LOGIN_PASSWORD, EMPLOYEE_RIGHTS, ACC_NAME, ACC_ADDRESS, PHONE_NUMBER FROM PT_EMPLOYEE_ACC", out output, out exception))
            {
                foreach (List<string> list in output)
                {
                    Employee tempEmployee = new Employee(Convert.ToInt32(list[0]), list[1], list[2], Convert.ToInt32(list[3]), list[4], list[5], list[6]);
                    lbEmployeeAccounts.Items.Add(tempEmployee);
                }
            }
            else
            {
                MessageBox.Show("This error occured:" + Environment.NewLine + exception.ToString());
            }
            if (lbEmployeeAccounts.Items.Count > 0)
            {
                lbEmployeeAccounts.SelectedIndex = 0;
            }
            RefreshTextboxes();
        }
        
        private void RefreshTextboxes()
        {
            if (lbEmployeeAccounts.Items.Count > 0)
            {
                Employee tempEmployee = (Employee)lbEmployeeAccounts.SelectedItem;
                tbLoginName.Text = tempEmployee.LoginName;
                tbEmployeeName.Text = tempEmployee.EmployeeName;
                tbAddress.Text = tempEmployee.EmployeeAddress;
                tbPhoneNumber.Text = tempEmployee.PhoneNumber;
                if (tempEmployee.EmployeeRights == 1)
                {
                    cbRights.SelectedItem = "Employee";
                }
                else if (tempEmployee.EmployeeRights == 2)
                {
                    cbRights.SelectedItem = "Admin";
                }
                else
                {
                    cbRights.SelectedItem = "No rights";
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbEmployeeAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshTextboxes();
        }

        private void btnChangeInfo_Click(object sender, EventArgs e)
        {
            Employee tempEmployee = (Employee)lbEmployeeAccounts.SelectedItem;
            string tempString;
            switch ((string)cbRights.SelectedItem)
            {
                case "No Rights":   { tempString = "0"; break; }
                case "Employee":    { tempString = "1"; break; }
                case "Admin":       { tempString = "2"; break; }
                default:            { tempString = "0"; break; } 
            }
            string query = "UPDATE PT_EMPLOYEE_ACC SET LOGIN_NAME = '" + tbLoginName.Text + "', EMPLOYEE_RIGHTS = '" + tempString + "', ACC_NAME = '" + tbEmployeeName.Text + "', ACC_ADDRESS = '" + tbAddress.Text + "', PHONE_NUMBER = '" + tbPhoneNumber.Text + "' WHERE EMPLOYEE_ID = '" + tempEmployee.EmployeeID + "'";
            Exception exception;
            if (connection.SQLQueryNoOutput(query, out exception))
            {
                MessageBox.Show("Changes to " + tempEmployee.EmployeeName + " are succesfully processed");
            }
            else
            {
                MessageBox.Show("The following error has occured:" + Environment.NewLine + exception.ToString());
            }
            RefreshEmployeeListbox();
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            Employee tempEmployee = (Employee)lbEmployeeAccounts.SelectedItem;
            string query = "DELETE FROM PT_EMPLOYEE_ACC WHERE EMPLOYEE_ID = '" + tempEmployee.EmployeeID + "'";
            Exception exception;
            if (connection.SQLQueryNoOutput(query, out exception))
            {
                MessageBox.Show(tempEmployee.EmployeeName + " is sucessfully deleted");
            }
            else
            {
                MessageBox.Show("The following error has occured:" + Environment.NewLine + exception.ToString());
            }
            RefreshEmployeeListbox();
        }
    }
}
