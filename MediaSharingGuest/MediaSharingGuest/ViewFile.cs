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
    public partial class ViewFile : Form
    {
        MediaSharingSystem medias;
        Media mediaitem;
        bool isLiked = false;

        public ViewFile(MediaSharingSystem medias, Media mediaitem)
        {
            InitializeComponent();
            this.medias = medias;
            this.mediaitem = mediaitem;
            mediaitem.Update();
            IsLiked();
        }

        public void IsLiked()
        {
            string rfidCode = medias.MediaUser.RFIDcode;
            int mediaItemId = mediaitem.MediaID;
            //SELECT LikeID FROM LIKE WHERE RFIDCODE = RFIDCODE & mediaitemid = mediaitemid;
            //IF this query returns a value, isLiked becomes true;


            if (isLiked == true)
            {
                btnLikeThisFile.Text = "Unlike this File!";
            }
            else if (isLiked == false)
            {
                btnLikeThisFile.Text = "Like this File!";
            }
        }

        public void GetAllItemLikes()
        {
            int itemLikes = mediaitem.Likes.Count();
            lblLikesNumber.Text = Convert.ToString(itemLikes);
        }

        public void GetAllCommentLikes()
        {

        }

        public void RemoveItemLike()
        {
            mediaitem.Update();
            foreach (Like like in mediaitem.Likes)
            {
                if (like.RfidCode == medias.MediaUser.RFIDcode)
                {
                    mediaitem.RemoveLike(like);
                }
            }
        }

        public void RemoveCommentLike()
        {
            
        }

        public void ShowAllInformation()
        {
            //Shows the image.
            pbImage.ImageLocation = @mediaitem.Path;
            pbImage.SizeMode = PictureBoxSizeMode.StretchImage;

            //Shows the comments.
            mediaitem.Update();
            
            foreach (Reaction comment in mediaitem.Comments)
            {
                lbComments.Items.Add(comment);
                lbComments.DisplayMember = ToString();
            }

            //shows the name of the uploader.

            //SELECT statement to select the name of the creator.
            string rfidCreator = mediaitem.RfidCreator;
            string creator;

            lblName.Text = "";

            //Shows the desciption.
            tbDescription.Text = mediaitem.Description;

            //Shows the Location where the image was taken.
            lblLocation.Text = mediaitem.Location;
        }

        private void btnAddComment_Click(object sender, EventArgs e)
        {
            string content = tbYourComment.Text;
            Reaction comment = new Reaction(content, mediaitem.MediaID, medias.MediaUser);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLikeThisFile_Click(object sender, EventArgs e)
        {
            if (isLiked == false)
            {
                Like like = new Like(medias.MediaUser.RFIDcode, 0, mediaitem.MediaID);
                IsLiked();
            }
            else if (isLiked == true)
            {
                RemoveItemLike();
                isLiked = false;
            }
        }

        private void btnReportFile_Click(object sender, EventArgs e)
        {
            SendReport sendreport = new SendReport(medias, mediaitem, null, null);
            sendreport.Show();
        }

        private void btnLikeComment_Click(object sender, EventArgs e)
        {
            object selectedobject = lbComments.SelectedItem;
            Reaction selectedReaction = selectedobject as Reaction;
            Like like = new Like(medias.MediaUser.RFIDcode, selectedReaction.ReactionID, 0);
        }

        private void btnReportComment_Click(object sender, EventArgs e)
        {
            object selectedobject = lbComments.SelectedItem;
            Reaction selectedReaction = selectedobject as Reaction;
            SendReport sendreport = new SendReport(medias, null, selectedReaction, null);
            sendreport.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
