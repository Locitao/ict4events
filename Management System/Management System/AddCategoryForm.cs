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
    public partial class AddCategoryForm : Form
    {
        public bool saved;
        public string Name;
        public int Price;
        public AddCategoryForm()
        {
            InitializeComponent();
            saved = false;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (tbName.Text != "")
            {
                Name = tbName.Text;
                Price = Convert.ToInt32(nudPrice.Value);
                saved = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("the name can't be empty");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
