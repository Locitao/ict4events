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
    public partial class AddItemForm : Form
    {
        public bool saved;
        public int selectedItem;
        List<List<string>> List;
        public AddItemForm(List<List<string>> list)
        {
            InitializeComponent();
            foreach(List<string> l in list)
            {
                cbItem.Items.Add(l[1]);
            }
            List = list;
            saved = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (cbItem.SelectedItem != null)
            {
                foreach (List<string> list in List)
                {
                    if ((string)cbItem.SelectedItem == list[1])
                    {
                        this.selectedItem = Convert.ToInt32(list[0]);
                        saved = true;
                        this.Close();
                    }
                }

            }
            else
            {
                MessageBox.Show("Please select an Item.");
            }
        }
    }
}
