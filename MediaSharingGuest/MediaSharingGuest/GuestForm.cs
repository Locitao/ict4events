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

        public GuestForm(MediaSharingSystem medias)
        {
            InitializeComponent();
            this.medias = medias;
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

        public void LoadFolders(int parentCategoryID)
        {
            //SELECT query to select all folders from the selected folder.
            Categories.Clear();
            //foreach loop die elke terug gegeven categorie in een lijst plaatst
        }

        public void LoadClickedFolder(string foldername)
        {
            //SELECT query to select the folder content from the database
        }

        public void AddFolder(string categoryname, int categoryID, int parentCategoryID)
        {
            //INSERT query to Insert a category

        }

        private void btnAddFile_Click_1(object sender, EventArgs e)
        {
            UploadFile uploadfile = new UploadFile(medias);
            uploadfile.Show();
        }

        private void btnAddNewsFeedMessage_Click(object sender, EventArgs e)
        {
            AddMessageToNewsFeed(tbNewsFeed.Text, medias.MediaUser);
        }
    }
}
