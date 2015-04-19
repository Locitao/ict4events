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
        List<Media> foundMediaItems;
        string type = "";
        Category selectedCategory;
        Media selectedMedia;
        MediaSharingSystem medias;

        public SearchWindow(MediaSharingSystem medias, List<Category> foundCategories, string type, List<Media> foundMediaItems)
        {
            InitializeComponent();
            this.foundCategories = foundCategories;
            this.foundMediaItems = foundMediaItems;
            this.type = type;
            this.medias = medias;
            ShowStaticInformation();
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
                foreach (Media media in foundMediaItems)
                {
                    lbResults.ValueMember = "MediaId";
                    lbResults.DisplayMember = "Name";
                    lbResults.Items.Add(media);
                }

            }
        }

        private void lblOpen_Click(object sender, EventArgs e)
        {
            if (type == "Category")
            {
                //code
            }
            else if (type == "Media")
            {
                //code
            }
        }

        private void lbResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (type == "Category")
            {
                selectedCategory = lbResults.SelectedItem as Category;
            }
            else if (type == "Media")
            {
                selectedMedia = lbResults.SelectedItem as Media;
            }
        }
    }
}
