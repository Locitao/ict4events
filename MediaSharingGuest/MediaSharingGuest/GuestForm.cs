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
        public GuestForm(MediaSharingSystem medias)
        {
            InitializeComponent();
        }

        private void btnAddNewsFeedMessage_Click(object sender, EventArgs e, MediaSharingSystem medias)
        {
            AddMessageToNewsFeed(tbNewsFeed.Text, medias); 
        }

        public void AddMessageToNewsFeed(string message, MediaSharingSystem medias)
        {
            //INSERT query to insert a newsfeedmessage.
        }

        public void LoadNewsFeedMessages()
        {
            //SELECT query to select all messages without mediaID and display each of them.
        }

        public void LoadFolders(int parentCategoryID)
        {
            //SELECT query to select all folders from the selected folder.
        }

        public void LoadClickedFolder(string foldername)
        {
            //SELECT query to select the folder content from the database
        }

        public void AddFolder(string foldername, int folderID, int parentfolderID)
        {
            //INSERT query to Insert a folder
        }

        private void btnAddNewsFeedMessage_Click(object sender, EventArgs e)
        {

        }
    }
}
