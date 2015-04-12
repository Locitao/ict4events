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
    public partial class GuestForm : Form
    {
        MediaSharingSystem medias;
        Category currentCategory = new Category("Test:", 1, 0, "1111");

        public GuestForm(MediaSharingSystem medias)
        {
            InitializeComponent();
            this.medias = medias;

            if (currentCategory.ParentCategoryId == 0)
            {
                btnBack.Enabled = false;
            }
        }

        List<Category> Categories = new List<Category>();

        public void AddMessageToNewsFeed(string message, Guest mediauser)
        {
            string rfidcode = mediauser.RFIDcode;
            //INSERT query to insert a newsfeedmessage.
        }

        public void LoadNewsFeedMessages()
        {
            //SELECT query to select all messages without mediaID and display each of them.
        }

        public void LoadCategorys()
        {
            //SELECT query to select the starting folder and it's content.
        }

        public void LoadClickedCategory(int categoryID)
        {
            lbFolders.Items.Clear();
            //SELECT query to select the folder content from the database.
            
            //foreach code to update the listbox.
        }

        private void btnAddFile_Click_1(object sender, EventArgs e)
        {
            UploadFile uploadfile = new UploadFile(medias, currentCategory);
            uploadfile.Show();
        }

        private void btnAddNewsFeedMessage_Click(object sender, EventArgs e)
        {
            AddMessageToNewsFeed(tbNewsFeed.Text, medias.MediaUser);
        }

        private void btnAddFolder_Click(object sender, EventArgs e)
        {
            CreateFolder createfolder = new CreateFolder(medias, currentCategory);
            createfolder.Show();
        }

        private void lbFolders_SelectedIndexChanged(object sender, EventArgs e)
        {
            object selectedobject = lbFolders.SelectedItem;
            currentCategory = selectedobject as Category;
            LoadClickedCategory(currentCategory.CategoryId);

            if (currentCategory.ParentCategoryId == 0)
            {
                btnBack.Enabled = false;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            int parentCategoryID = currentCategory.ParentCategoryId;
            LoadClickedCategory(parentCategoryID);

            if (currentCategory.ParentCategoryId == 0)
            {
                btnBack.Enabled = false;
            }
        }
    }
}
