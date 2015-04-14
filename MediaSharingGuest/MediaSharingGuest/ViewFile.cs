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
        //FIELDS------------------------------------------------------------------------------------------------------------------------------
        MediaSharingSystem medias;
        Media mediaitem;
        int mediaId;
        int selectedReactionId;
        string rfidCode;
        bool isLiked = false;
        bool isLikedComment = false;
        object selectedobject;
        Select select = new Select();
        Delete delete = new Delete();

        //CONSTRUCTOR-------------------------------------------------------------------------------------------------------------------------
        public ViewFile(MediaSharingSystem medias, Media mediaitem)
        {
            InitializeComponent();
            this.medias = medias;
            this.mediaitem = mediaitem;
            mediaitem.Update();
            IsLiked();
        }

        //METHODS-----------------------------------------------------------------------------------------------------------------------------
        public bool IsLikedMedia()
        {
            string rfidCode = medias.MediaUser.RFIDcode;
            int mediaItemId = mediaitem.MediaID;

            //Query that checks if the file is liked by the current user.
            //IF this query returns a value, isLiked becomes true;
            select.GetFileLikedByUser(rfidCode, mediaItemId);


            if (isLiked == true)
            {
                btnLikeThisFile.Text = "Unlike this File!";
                return true;
            }
            else
            {
                btnLikeThisFile.Text = "Like this File!";
                return false;
            }
        }


        public bool IsLikedComment()
        {
            string rfidCode = medias.MediaUser.RFIDcode;
            Reaction comment = selectedobject as Reaction;
            int reactionItemId = comment.ReactionID;

            //Query that checks if the selected reaction is liked by the current user.
            //IF this query returns a value, isLikedComment becomes true;
            select.GetReactionLikedByUser(rfidCode, reactionItemId);

            if (isLikedComment == true)
            {
                btnLikeComment.Text = "Unlike this Comment!";
                return true;
            }
            else 
            {
                btnLikeComment.Text = "Like this Comment!";
                return false;
            }
        }

        public void GetAllItemLikes()
        {
            int itemLikes = mediaitem.Likes.Count();
            lblLikesNumber.Text = Convert.ToString(itemLikes);
        }

        public void DeleteLike(int reactionId, int mediaId, string rfidCode)
        {
            //Query that deletes the users like.
            delete.DeleteLike(reactionId, mediaId, rfidCode);
        }

        public void ShowAllInformation()
        {
            int mediaId = mediaitem.MediaID;

            //Queries that get all the information about the mediafile, and the reactions on this file plus additional information.
            select.GetMediaItemInfo(mediaId);
            select.GetAllReactionsData(mediaId);
        }

        //EVENTS-----------------------------------------------------------------------------------------------------------------------------

        private void btnAddComment_Click(object sender, EventArgs e)
        {
            string content = tbYourComment.Text;
            Reaction comment = new Reaction(content, mediaitem.MediaID, medias.MediaUser);
            ShowAllInformation();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLikeThisFile_Click(object sender, EventArgs e)
        {
            if (IsLikedMedia() == false)
            {
                Like like = new Like(medias.MediaUser.RFIDcode, 0, mediaitem.MediaID);
            }
            else
            {
                DeleteLike(selectedReactionId, mediaId, rfidCode);
            }
            ShowAllInformation();
        }

        private void btnReportFile_Click(object sender, EventArgs e)
        {
            SendReport sendreport = new SendReport(medias, mediaitem, null, null);
            sendreport.Show();
        }

        private void btnLikeComment_Click(object sender, EventArgs e)
        {
            if (IsLikedComment() == false)
            {
            Reaction selectedReaction = selectedobject as Reaction;
            Like like = new Like(medias.MediaUser.RFIDcode, selectedReaction.ReactionID, 0);
            }
            else
            {
                Reaction message = selectedobject as Reaction;
                message.DeleteLike(message, medias.MediaUser);
            }
            ShowAllInformation();
        }

        private void btnReportComment_Click(object sender, EventArgs e)
        {
            Reaction selectedReaction = selectedobject as Reaction;
            SendReport sendreport = new SendReport(medias, null, selectedReaction, null);
            sendreport.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbComments_SelectedIndexChanged(object sender, EventArgs e)
        {
            IsLikedComment();

            selectedobject = lbComments.SelectedItem;
            if (selectedobject != null)
            {
                btnLikeComment.Enabled = true;
                btnReportComment.Enabled = true;

            }
        }
    }
}
