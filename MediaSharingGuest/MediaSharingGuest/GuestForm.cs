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
        NewsFeed newsfeed = new NewsFeed();
        List<string> NewsFeedMessages = new List<string>();
        Random RNG = new Random();
        int startingCategoryId = 0;

        Select select = new Select();
        Connection connection = new Connection();

        List<List<string>> output = new List<List<string>>();

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
            btnBack.Enabled = false;

        }


        public void LoadNewsFeedMessages()
        {
            //Query that returns all newsfeedmessages plus the creator of the message.
            connection.SQLQueryWithOutput(select.GetNewsFeedMessages(), out output);

            NewsFeedMessages.Clear();

            string newsFeedMessage ="";

            foreach (List<string> stringList in output)
            {
                foreach (string message in stringList)
                {
                    newsFeedMessage = message + newsFeedMessage;
                }
                NewsFeedMessages.Add(newsFeedMessage);
            }
        }

        public void LoadCategories(int categoryID)
        {
            lbFolders.Items.Clear();
            List<Category> Categories = new List<Category>();

            //SELECT query to select the folder content from the database.
            connection.SQLQueryWithOutput(select.GetCategories(categoryID), out output);
            
            //CODE TO UPDATE LISTBOX
            foreach (List<string> stringList in output)
            {
                int categoryId = Convert.ToInt32(stringList[0]);
                string categoryName = stringList[1];
                int parentCategoryId = Convert.ToInt32(stringList[2]);

                Category category = new Category(categoryName, categoryId, parentCategoryId, rfidCodeUser);

                Categories.Add(category);

                lbFolders.Items.Add(category);
                lbFolders.DisplayMember = category.Name;
                lbFolders.ValueMember = Convert.ToString(category.CategoryId);
            }
        }

        public void LoadMediaItems(int categoryId)
        {
            lbMediaItems.Items.Clear();
            List<Media> MediaItems = new List<Media>();

            //SELECT query to select all media items in given category.
            connection.SQLQueryWithOutput(select.GetAllMediaItems(categoryId), out output);

            //CODE TO UPDATE LISTBOX
            foreach (List<string> stringList in output)
            {
                string medName = stringList[0];
                int medId = Convert.ToInt32(stringList[1]);

                Media mediaItem = new Media(medName, "", "", "", "", medId);

                MediaItems.Add(mediaItem);

                lbMediaItems.Items.Add(mediaItem);
                lbMediaItems.DisplayMember = mediaItem.Name;
                lbMediaItems.ValueMember = Convert.ToString(mediaItem.MediaID);
            }
        }
          

        private void btnAddFile_Click_1(object sender, EventArgs e)
        {
            UploadFile uploadfile = new UploadFile(medias, CurrentCategoryId);
            uploadfile.Show();
        }

        private void btnAddNewsFeedMessage_Click(object sender, EventArgs e)
        {
            Reaction message = new Reaction(tbNewsFeed.Text, 0, rfidCodeUser);
            newsfeed.AddMessage(message);
        }

        private void btnAddFolder_Click(object sender, EventArgs e)
        {
            CreateFolder createfolder = new CreateFolder(medias, CurrentCategoryId);
            createfolder.Show();
        }

        private void lbFolders_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentCategoryId = Convert.ToInt32(lbFolders.ValueMember);
            LoadCategories(CurrentCategoryId);

            if (CurrentCategoryId == startingCategoryId)
            {
                btnBack.Enabled = false;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            connection.SQLQueryWithOutput(select.GetParentCategoryId(CurrentCategoryId), out output);

            int parentCategoryId = 0;

            foreach (List<string> stringList in output)
            {
                parentCategoryId = Convert.ToInt32(stringList[0]);
            }

            LoadCategories(parentCategoryId);
        }

        private void timerNewsFeed_Tick(object sender, EventArgs e)
        {
            int max = NewsFeedMessages.Count();

            if (max > 0)
            {
                int number = RNG.Next(0, max);
                lblNewsMessage.Text = NewsFeedMessages[number];
                LoadNewsFeedMessages();
            }
        }

        private void lbMediaItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            int mediaId = Convert.ToInt32(lbMediaItems.ValueMember);
            ViewFile viewFile = new ViewFile(medias, mediaId);
        }
    }
}
