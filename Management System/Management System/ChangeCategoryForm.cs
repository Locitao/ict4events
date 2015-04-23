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
    public partial class ChangeCategoryForm : Form
    {
        public Material Mat { get; set; }
        public bool saved;
        public ChangeCategoryForm(Material material)
        {
            InitializeComponent();
            tbName.Text = material.Name;
            nudPrice.Value = material.Price;
            Mat = material;
            saved = false;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (tbName.Text != "")
            {
                Mat.Name = tbName.Text;
                Mat.Price = Convert.ToInt32(nudPrice.Value);
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
