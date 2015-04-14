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
        //


        MediaSharingSystem medias;
        NewsFeed newsfeed = new NewsFeed();
        List<string> NewsFeedMessages = new List<string>();
        Random RNG = new Random();
        Select select = new Select();
        int startingCategoryId = 0;

        public int CurrentCategoryId { get; set; }
        public string rfidCodeUser { get; set; }

        public GuestForm(MediaSharingSystem medias)
        {
            //TEST DATA
            Reaction message = new Reaction("hallo", 0, "1111");
            newsfeed.UpdateMessages(message);
            LoadNewsFeedMessages();
            //

            InitializeComponent();
            this.medias = medias;
            timerNewsFeed.Start();
            rfidCodeUser = medias.RfidCode;
            
            LoadCategories(startingCategoryId);

            if (currentCategory.ParentCategoryId == 0)
            {
                btnBack.Enabled = false;
            }
        }


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
            
            //CODE TO UPDATE LISTBOX
        }

        public void LoadMediaItems(int categoryId)
        {
            //SELECT query to select all media items in given category.
            select.GetAllMediaItems(categoryId);

            //CODE TO UPDATE LISTBOX
        }
          

        private void btnAddFile_Click_1(object sender, EventArgs e)
        {
            UploadFile uploadfile = new UploadFile(medias, currentCategory);
            uploadfile.Show();
        }

        private void btnAddNewsFeedMessage_Click(object sender, EventArgs e)
        {
            Reaction message = new Reaction(tbNewsFeed.Text, 0, rfidCodeUser);
            newsfeed.AddMessage(message);
        }

        private void btnAddFolder_Click(object sender, EventArgs e)
        {
            CreateFolder createfolder = new CreateFolder(medias, currentCategory);
            createfolder.Show();
        }

        private void lbFolders_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentCategoryId = Convert.ToInt32(lbFolders.ValueMember);
            LoadCategories(CurrentCategoryId);

            if (currentCategory.ParentCategoryId == startingCategoryId)
            {
                btnBack.Enabled = false;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            select.GetParentCategoryId(CurrentCategoryId);
            int parentCategoryId = 0;
            LoadCategories(parentCategoryId);
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
