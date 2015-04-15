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
            //SELECT query to select the folder content from the database.
            connection.SQLQueryWithOutput(select.GetCategories(categoryID), out output);
            
            //CODE TO UPDATE LISTBOX
            foreach (List<string> stringList in output)
            {
                string categoryId = stringList[1];
                string categoryName = stringList[2];
                lbFolders.DisplayMember = categoryName;
                lbFolders.ValueMember = categoryId;
            }
        }

        public void LoadMediaItems(int categoryId)
        {
            //SELECT query to select all media items in given category.
            connection.SQLQueryWithOutput(select.GetAllMediaItems(categoryId), out output);

            //CODE TO UPDATE LISTBOX
            foreach (List<string> stringList in output)
            {
                //
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
            select.GetParentCategoryId(CurrentCategoryId);
            int parentCategoryId = 0;
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
    }
}
