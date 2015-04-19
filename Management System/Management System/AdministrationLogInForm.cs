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


        private void btnLoginToManagementSystem_Click(object sender, EventArgs e)
        {
            EventManagementSystemForm form = new EventManagementSystemForm();
            form.ShowDialog();
        }

        private void btnLogInMaterialRenting_Click(object sender, EventArgs e)
        {
            MaterialRentingForm form = new MaterialRentingForm();
            form.ShowDialog();
        }
    }
}
