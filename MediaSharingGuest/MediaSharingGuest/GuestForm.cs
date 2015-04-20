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
    /// This form is the main interface for users. It shows data about folders, media items, the newsfeed, and has a search option.
    /// </summary>
    public partial class GuestForm : Form
    {
        //Fields------------------------------------
        MediaSharingSystem medias;
        int startingCategoryId = 2;

        Select select = new Select();
        Connection connection = new Connection();
        Insert insert = new Insert();
        Protection protection = new Protection();
        NewsFeed newsfeed = new NewsFeed();
        Random RNG = new Random();

        List<string> NewsFeedMessages = new List<string>();
        List<List<string>> output = new List<List<string>>();
        List<Category> Categories = new List<Category>();
        List<Media> MediaItems = new List<Media>();

        //Properties--------------------------------
        public int CurrentCategoryId { get; set; }
        public int PreviousCategoryId { get; set; }
        public string rfidCodeUser { get; set; }

        //Contructor--------------------------------
        public GuestForm(MediaSharingSystem medias, int startingCategoryId)
        {
            InitializeComponent();
            lblUsername.Text = medias.Username;
            PreviousCategoryId = 2;

            this.medias = medias;
            this.startingCategoryId = startingCategoryId;
            timerNewsFeed.Start();
            
            timerNewsFeed.Start();
            LoadNewsFeedMessages();
            LoadCategories(startingCategoryId);
            LoadMediaItems(startingCategoryId);
        }

        //Methods-----------------------------------------------

        /// <summary>
        /// Loads the messages that get displayed in the newsfeed.
        /// </summary>
        public void LoadNewsFeedMessages()
        {
            NewsFeedMessages.Clear();

            //Query that returns all newsfeedmessages plus the creator of the message.
            connection.SQLQueryWithOutput(select.GetNewsFeedMessages(), out output);

            string newsFeedMessage;
            if (output == null)
            {
                return;
            }

            foreach (List<string> stringList in output)
            {
                newsFeedMessage = "";
                newsFeedMessage = stringList[0] + ": " + stringList[1];
                NewsFeedMessages.Add(newsFeedMessage);
            }
        }

        /// <summary>
        /// Loads all the categories displayed in the category listbox.
        /// </summary>
        /// <param name="categoryId"></param>
        public void LoadCategories(int categoryId)
        {
            CurrentCategoryId = categoryId;
            lbFolders.Items.Clear();
            Categories.Clear();
            
            //SELECT query to select the folder content from the database.
            connection.SQLQueryWithOutput(select.GetCategories(categoryId), out output);
            
            //CODE TO UPDATE LISTBOX
            foreach (List<string> stringList in output)
            {
                int categoryIdLoad = Convert.ToInt32(stringList[0]);
                string categoryNameLoad = stringList[1];
                int parentCategoryIdLoad = Convert.ToInt32(stringList[2]);

                Category category = new Category(categoryNameLoad, categoryIdLoad, parentCategoryIdLoad, rfidCodeUser);

                Categories.Add(category);
                lbFolders.DisplayMember = "Name";
                lbFolders.ValueMember = "CategoryId";
                lbFolders.Items.Add(category);
            }

            if (Categories.Count > 0)
            {
                if (Categories[0].ParentCategoryId == startingCategoryId)
                {
                    btnBack.Enabled = false;
                }
                else if (Categories[0].ParentCategoryId != startingCategoryId)
                {
                    btnBack.Enabled = true;
                }
            }

            }

        /// <summary>
        /// Loads all media items and displays them in the media listbox.
        /// </summary>
        /// <param name="categoryId"></param>

        public void LoadMediaItems(int categoryId)
        {
            lbMediaItems.Items.Clear();
            
            //SELECT query to select all media items in given category.
            connection.SQLQueryWithOutput(select.GetAllMediaItems(categoryId), out output);

            //CODE TO UPDATE LISTBOX
            foreach (List<string> stringList in output)
            {
                string medName = stringList[0];
                int medId = Convert.ToInt32(stringList[1]);
                string name = stringList[2];
                string rfidCode = stringList[3];

                Media mediaItem = new Media(medName, "", "", rfidCode, "", '0', medId);

                MediaItems.Add(mediaItem);
                lbMediaItems.DisplayMember = "Name";
                lbMediaItems.ValueMember = "MediaId";
                lbMediaItems.Items.Add(mediaItem);
            }
        }
          
        //Events-----------------------------------------

        //This buttonopens the upload file window.
        private void btnAddFile_Click_1(object sender, EventArgs e)
        {
            UploadFile uploadfile = new UploadFile(medias, CurrentCategoryId);
            uploadfile.Show();
        }

        //This button adds a newsfeedmessage.
        private void btnAddNewsFeedMessage_Click(object sender, EventArgs e)
        {
            connection.SQLQueryNoOutput(insert.AddNewsFeedMessage(medias.RfidCode, protection.ProtectAgainstSQLInjection(tbNewsFeed.Text)));
            LoadNewsFeedMessages();
        }

        //This button opens the create category window.
        private void btnAddFolder_Click(object sender, EventArgs e)
        {
            CreateFolder createFolder = new CreateFolder(medias, CurrentCategoryId);
            createFolder.Show();
        }

        //This event loads the new folders inside the selected folder.
        private void lbFolders_SelectedIndexChanged(object sender, EventArgs e)
        {
            object cat = lbFolders.SelectedItem;
            Category catt = cat as Category;

            LoadCategories(catt.CategoryId);
            LoadMediaItems(catt.CategoryId);
            CurrentCategoryId = catt.CategoryId;
            PreviousCategoryId = catt.ParentCategoryId;

            if (CurrentCategoryId == startingCategoryId)
            {
                btnBack.Enabled = false;
            }
            else if (CurrentCategoryId != startingCategoryId)
            {
                btnBack.Enabled = true;
            }
        }

        //this button returns you to the parentfolder of the current folder.
        private void btnBack_Click(object sender, EventArgs e)
        {
            int parentCategoryId = 0;

            connection.SQLQueryWithOutput(select.GetParentCategoryId(CurrentCategoryId), out output);

            foreach (List<string> stringList in output)
            {
                parentCategoryId = Convert.ToInt32(stringList[0]);
            }

            LoadCategories(parentCategoryId);
            LoadMediaItems(parentCategoryId);
        }

        //this timer updates the shown newsfeed message.
        private void timerNewsFeed_Tick(object sender, EventArgs e)
        {
            int max = NewsFeedMessages.Count;

            if (max > 0)
            {
                int number = RNG.Next(0, max);
                lblNewsMessage.Text = NewsFeedMessages[number];
                LoadNewsFeedMessages();
            }
        }

        //this event opens the selected media item in a new window.
        private void lbMediaItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            Media medd = lbMediaItems.SelectedItem as Media;

            if (medd != null)
            {
                ViewFile viewFile = new ViewFile(medias, medd.MediaId);
                viewFile.Show();
            }
        }

        //this event returns you to the root folder.
        private void btnStart_Click(object sender, EventArgs e)
        {
            LoadCategories(startingCategoryId);
            LoadMediaItems(startingCategoryId);
        }

        //this button shows you the found search results for matching categories.
        private void btnSearchCategory_Click(object sender, EventArgs e)
        {

            List<Category> foundCategories = new List<Category>();
            List<Media> foundMediaItems = new List<Media>();
            connection.SQLQueryWithOutput(select.SearchCategories(protection.ProtectAgainstSQLInjection(tbSearch.Text)), out output);

            if (output.Count == 0)
            {
                MessageBox.Show("No matching results.");
            }
            else
            {
                foreach (List<string> stringList in output)
                {
                    int categoryId = Convert.ToInt32(stringList[0]);
                    string categoryName = stringList[1];

                    Category category = new Category(categoryName, categoryId, 0, "");
                    foundCategories.Add(category);
                }
                SearchWindow searchWindow = new SearchWindow(medias, foundCategories, "Category", foundMediaItems);
                searchWindow.Show();
            }
        }

        //this button shows you the found search results for matching media items.
        private void btnSearchMedia_Click(object sender, EventArgs e)
        {
            List<Category> foundCategories = new List<Category>();
            List<Media> foundMediaItems = new List<Media>();
            connection.SQLQueryWithOutput(select.SearchMediaItems(protection.ProtectAgainstSQLInjection(tbSearch.Text)), out output);

            if (output.Count == 0)
            {
                MessageBox.Show("No matching results.");
            }
            else
            {
                foreach (List<string> stringList in output)
                {
                    int mediaId = Convert.ToInt32(stringList[0]);
                    string mediaName = stringList[1];

                    Media media = new Media(mediaName, "", "", medias.RfidCode, "", 0, mediaId);
                    foundMediaItems.Add(media);
                }
                SearchWindow searchWindow = new SearchWindow(medias, foundCategories, "Media", foundMediaItems);
                searchWindow.Show();
            }
        }
    }
}
