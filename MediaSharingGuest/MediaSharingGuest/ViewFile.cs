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
        bool isLiked = false;
        bool isLikedComment = false;
        object selectedobject;
        Select select = new Select();
        Delete delete = new Delete();

        public int MediaId { get; set; }
        public int SelectedReactionId { get; set; }
        public int SelectedCommentId { get; set; }

        //CONSTRUCTOR-------------------------------------------------------------------------------------------------------------------------
        public ViewFile(MediaSharingSystem medias, int mediaId)
        {
            InitializeComponent();
            this.medias = medias;
            MediaId = mediaId;
            IsLikedMedia();
        }

        //METHODS-----------------------------------------------------------------------------------------------------------------------------
        public bool IsLikedMedia()
        {
            string rfidCode = medias.RfidCode;

            //Query that checks if the file is liked by the current user.
            //IF this query returns a value, isLiked becomes true;
            select.GetFileLikedByUser(rfidCode, MediaId);


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
            string rfidCode = medias.RfidCode;
            int reactionItemId = 0;

            //Query that checks if the selected reaction is liked by the current user.
            //IF this query returns a value, isLikedComment becomes true;
            select.GetReactionLikedByUser(rfidCode, SelectedReactionId);

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

        public void DeleteLike(int reactionId, int mediaId, string rfidCode)
        {
            //Query that deletes the users like.
            delete.DeleteLike(reactionId, mediaId, rfidCode);
        }

        public void ShowAllInformation()
        {
            int mediaId = mediaitem.MediaID;

            //Queries that get all the information on the mediafile, and the reactions on this file plus additional information.
            select.GetMediaItemInfo(mediaId);
            select.GetAllReactionsData(mediaId);
        }

        //EVENTS-----------------------------------------------------------------------------------------------------------------------------

        private void btnAddComment_Click(object sender, EventArgs e)
        {
            string content = tbYourComment.Text;
            Reaction comment = new Reaction(content, mediaitem.MediaID, medias.RfidCode);
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
                Like like = new Like(medias.RfidCode, 0, mediaitem.MediaID);
            }
            else
            {
                DeleteLike(SelectedReactionId, MediaId, medias.RfidCode);
            }
            ShowAllInformation();
        }

        private void btnReportFile_Click(object sender, EventArgs e)
        {
            SendReport sendreport = new SendReport(medias, MediaId, 0, 0);
            sendreport.Show();
        }

        private void btnLikeComment_Click(object sender, EventArgs e)
        {
            if (IsLikedComment() == false)
            {
            Reaction selectedReaction = selectedobject as Reaction;
            Like like = new Like(medias.RfidCode, selectedReaction.ReactionID, 0);
            }
            else
            {
                delete.DeleteLike(MediaId, SelectedReactionId, medias.RfidCode);
            }
            ShowAllInformation();
        }

        private void btnReportComment_Click(object sender, EventArgs e)
        {
            Reaction selectedReaction = selectedobject as Reaction;
            SendReport sendreport = new SendReport(medias, 0, SelectedReactionId, 0);
            sendreport.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbComments_SelectedIndexChanged(object sender, EventArgs e)
        {
            IsLikedComment();

            SelectedReactionId = Convert.ToInt32(lbComments.ValueMember);
            selectedobject = lbComments.SelectedItem;
            if (selectedobject != null)
            {
                btnLikeComment.Enabled = true;
                btnReportComment.Enabled = true;

            }
        }
    }
}
