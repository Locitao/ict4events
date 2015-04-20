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
    /// <summary>
    /// this form shows the matching results for the inserted search query.
    /// </summary>
    public partial class SearchWindow : Form
    {
        //Fields--------------------------------
        string type = "";

        List<Category> foundCategories;
        List<Media> foundMediaItems;

        Category selectedCategory;
        Media selectedMedia;
        MediaSharingSystem medias;

        //Constructor--------------------------
        public SearchWindow(MediaSharingSystem medias, List<Category> foundCategories, string type, List<Media> foundMediaItems)
        {
            InitializeComponent();
            this.foundCategories = foundCategories;
            this.foundMediaItems = foundMediaItems;
            this.type = type;
            this.medias = medias;
            ShowStaticInformation();
        }

        /// <summary>
        /// Shows the static information about the search results, such as category/media name.
        /// </summary>
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

        //Opens the selected media item or category.
        private void lblOpen_Click(object sender, EventArgs e)
        {
            if (type == "Category")
            {
                GuestForm guestForm = new GuestForm(medias, selectedCategory.CategoryId);
                this.Close();
                guestForm.Show();
            }
            else if (type == "Media")
            {
                ViewFile viewFile = new ViewFile(medias, selectedMedia.MediaId);
                this.Close();
            }
        }

        //Sets the selected category datatype as the selected object.
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
