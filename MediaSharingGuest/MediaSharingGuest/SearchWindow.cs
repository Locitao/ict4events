using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaSharingGuest
{
    public partial class SearchWindow : Form
    {
        List<Category> foundCategories;
        string type = "";

        public SearchWindow(List<Category> foundCategories, string type)
        {
            InitializeComponent();
            this.foundCategories = foundCategories;
        }

        public void ShowStaticInformation()
        {
            if (type == "Category")
            {
                foreach (Category category in foundCategories)
                {
                    lbResults.ValueMember = "CategoryId";
                    lbResults.DisplayMember = "Name";
                    lbResults.Items.Add(category);
                }
            }

            else if (type == "Media")
            {

            }
        }

        private void lblOpen_Click(object sender, EventArgs e)
        {
      
        }

        private void lbResults_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
