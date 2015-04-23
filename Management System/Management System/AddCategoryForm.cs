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
        public string CategoryName;
        public int Price;

        /// <summary>
        /// this form is used to add a category to the database
        /// </summary>
        public AddCategoryForm()
        {
            InitializeComponent();
            saved = false;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (tbName.Text != "")
            {
                CategoryName = tbName.Text;
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
