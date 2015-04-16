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
        int startingCategoryId = 2;

        Select select = new Select();
        Connection connection = new Connection();

        List<List<string>> output = new List<List<string>>();
        List<Category> Categories = new List<Category>();
        List<Media> MediaItems = new List<Media>();

        public int CurrentCategoryId { get; set; }
        public int PreviousCategoryId { get; set; }
        public string rfidCodeUser { get; set; }

        public GuestForm(MediaSharingSystem medias)
        {
            LoadNewsFeedMessages();
            InitializeComponent();
            this.medias = medias;
            timerNewsFeed.Start();
            rfidCodeUser = medias.RfidCode;
            PreviousCategoryId = 2;

            LoadCategories(startingCategoryId);
            LoadMediaItems(startingCategoryId);
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
                lbFolders.DisplayMember = "Name";
                lbFolders.ValueMember = "CategoryId";
                lbFolders.Items.Add(category);

                if (category.ParentCategoryId == startingCategoryId)
                {
                    btnBack.Enabled = false;
                }
                else if (category.ParentCategoryId != startingCategoryId)
                {
                    btnBack.Enabled = true;
                }
            }
            
        }

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
                string name = stringList[3];
                string rfid_Code = stringList[4];

                Media mediaItem = new Media(medName, "", "", "", rfid_Code, medId);

                MediaItems.Add(mediaItem);

                MediaItems.Add(mediaItem);
                lbMediaItems.DisplayMember = "Name";
                lbMediaItems.ValueMember = "MediaId";
                lbMediaItems.Items.Add(mediaItem);
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
            object cat = lbFolders.SelectedItem;
            Category catt = cat as Category;
            LoadCategories(catt.CategoryId);
            LoadMediaItems(catt.ParentCategoryId);
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
            object med = lbMediaItems.SelectedItem;
            Media medd = med as Media;

            ViewFile viewFile = new ViewFile(medias, medd.MediaId);  
        }
    }
}
