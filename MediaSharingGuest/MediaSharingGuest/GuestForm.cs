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
        //TESTDATA INSERT
        Category currentCategory = new Category("Test:", 1, 0, "1111");
        Guest guest1 = new Guest("jaap", "1111");
        //


        MediaSharingSystem medias;
        NewsFeed newsfeed = new NewsFeed();
        List<string> NewsFeedMessages = new List<string>();
        Random RNG = new Random();
        Select select = new Select();
        int startingCategoryId = 0;

        public GuestForm(MediaSharingSystem medias)
        {
            //TEST DATA
            Reaction message = new Reaction("hallo", 0, guest1);
            newsfeed.UpdateMessages(message);
            LoadNewsFeedMessages();
            //

            InitializeComponent();
            this.medias = medias;
            timerNewsFeed.Start();
            
            LoadCategories(startingCategoryId);

            if (currentCategory.ParentCategoryId == 0)
            {
                btnBack.Enabled = false;
            }
        }

        List<Category> Categories = new List<Category>();

        public void LoadNewsFeedMessages()
        {
            //newsfeed.UpdateMessages();
            NewsFeedMessages = newsfeed.ReturnNewsFeedMessages();
        }

        public void LoadCategories(int categoryID)
        {
            lbFolders.Items.Clear();
            //SELECT query to select the folder content from the database.
            select.GetCategories(categoryID);
            
            //foreach code to update the listbox.
        }

        private void btnAddFile_Click_1(object sender, EventArgs e)
        {
            UploadFile uploadfile = new UploadFile(medias, currentCategory);
            uploadfile.Show();
        }

        private void btnAddNewsFeedMessage_Click(object sender, EventArgs e)
        {
            Reaction message = new Reaction(tbNewsFeed.Text, 0, medias.MediaUser);
            newsfeed.AddMessage(message);
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
            LoadCategories(currentCategory.CategoryId);

            if (currentCategory.ParentCategoryId == startingCategoryId)
            {
                btnBack.Enabled = false;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            int parentCategoryID = currentCategory.ParentCategoryId;
            LoadCategories(parentCategoryID);

            if (currentCategory.ParentCategoryId == startingCategoryId)
            {
                btnBack.Enabled = false;
            }
        }

        private void timerNewsFeed_Tick(object sender, EventArgs e)
        {
            //Puts a random message in the NewsFeed
            int max = NewsFeedMessages.Count();
            int number = RNG.Next(0, max);
            lblNewsMessage.Text = NewsFeedMessages[number];
            //newsfeed.UpdateMessages();
        }
    }
}
