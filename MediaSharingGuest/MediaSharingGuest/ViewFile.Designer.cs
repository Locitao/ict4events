namespace MediaSharingGuest
{
    partial class ViewFile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewFile));
            this.btnReportFile = new System.Windows.Forms.Button();
            this.btnReportComment = new System.Windows.Forms.Button();
            this.btnLikeComment = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddComment = new System.Windows.Forms.Button();
            this.btnLikeThisFile = new System.Windows.Forms.Button();
            this.lblLikes = new System.Windows.Forms.Label();
            this.lblYourComment = new System.Windows.Forms.Label();
            this.tbYourComment = new System.Windows.Forms.TextBox();
            this.lblComments = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.lbComments = new System.Windows.Forms.ListBox();
            this.lblUploadedBy = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblTakenAt = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblLikesNumber = new System.Windows.Forms.Label();
            this.windowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowsMediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReportFile
            // 
            this.btnReportFile.Location = new System.Drawing.Point(170, 496);
            this.btnReportFile.Name = "btnReportFile";
            this.btnReportFile.Size = new System.Drawing.Size(61, 40);
            this.btnReportFile.TabIndex = 27;
            this.btnReportFile.Text = "Report this file";
            this.btnReportFile.UseVisualStyleBackColor = true;
            this.btnReportFile.Click += new System.EventHandler(this.btnReportFile_Click);
            // 
            // btnReportComment
            // 
            this.btnReportComment.Location = new System.Drawing.Point(450, 497);
            this.btnReportComment.Name = "btnReportComment";
            this.btnReportComment.Size = new System.Drawing.Size(146, 40);
            this.btnReportComment.TabIndex = 26;
            this.btnReportComment.Text = "Report selected comment";
            this.btnReportComment.UseVisualStyleBackColor = true;
            this.btnReportComment.Click += new System.EventHandler(this.btnReportComment_Click);
            // 
            // btnLikeComment
            // 
            this.btnLikeComment.Location = new System.Drawing.Point(298, 496);
            this.btnLikeComment.Name = "btnLikeComment";
            this.btnLikeComment.Size = new System.Drawing.Size(146, 40);
            this.btnLikeComment.TabIndex = 25;
            this.btnLikeComment.Text = "Like selected comment!";
            this.btnLikeComment.UseVisualStyleBackColor = true;
            this.btnLikeComment.Click += new System.EventHandler(this.btnLikeComment_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(82, 497);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(61, 40);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddComment
            // 
            this.btnAddComment.Location = new System.Drawing.Point(3, 496);
            this.btnAddComment.Name = "btnAddComment";
            this.btnAddComment.Size = new System.Drawing.Size(61, 40);
            this.btnAddComment.TabIndex = 23;
            this.btnAddComment.Text = "Add Comment";
            this.btnAddComment.UseVisualStyleBackColor = true;
            this.btnAddComment.Click += new System.EventHandler(this.btnAddComment_Click);
            // 
            // btnLikeThisFile
            // 
            this.btnLikeThisFile.Location = new System.Drawing.Point(115, 272);
            this.btnLikeThisFile.Name = "btnLikeThisFile";
            this.btnLikeThisFile.Size = new System.Drawing.Size(116, 21);
            this.btnLikeThisFile.TabIndex = 22;
            this.btnLikeThisFile.Text = "Like this file!";
            this.btnLikeThisFile.UseVisualStyleBackColor = true;
            this.btnLikeThisFile.Click += new System.EventHandler(this.btnLikeThisFile_Click);
            // 
            // lblLikes
            // 
            this.lblLikes.AutoSize = true;
            this.lblLikes.Location = new System.Drawing.Point(4, 269);
            this.lblLikes.Name = "lblLikes";
            this.lblLikes.Size = new System.Drawing.Size(35, 13);
            this.lblLikes.TabIndex = 21;
            this.lblLikes.Text = "Likes:";
            // 
            // lblYourComment
            // 
            this.lblYourComment.AutoSize = true;
            this.lblYourComment.Location = new System.Drawing.Point(1, 379);
            this.lblYourComment.Name = "lblYourComment";
            this.lblYourComment.Size = new System.Drawing.Size(78, 13);
            this.lblYourComment.TabIndex = 20;
            this.lblYourComment.Text = "Your comment:";
            // 
            // tbYourComment
            // 
            this.tbYourComment.Location = new System.Drawing.Point(3, 396);
            this.tbYourComment.Multiline = true;
            this.tbYourComment.Name = "tbYourComment";
            this.tbYourComment.Size = new System.Drawing.Size(229, 95);
            this.tbYourComment.TabIndex = 19;
            // 
            // lblComments
            // 
            this.lblComments.AutoSize = true;
            this.lblComments.Location = new System.Drawing.Point(466, 82);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(59, 13);
            this.lblComments.TabIndex = 18;
            this.lblComments.Text = "Comments:";
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(2, 300);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.ReadOnly = true;
            this.tbDescription.Size = new System.Drawing.Size(230, 76);
            this.tbDescription.TabIndex = 16;
            this.tbDescription.TabStop = false;
            this.tbDescription.Text = "Description";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(6, 42);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 15;
            this.lblTitle.Text = "Title";
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(6, 59);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(225, 207);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 14;
            this.pbImage.TabStop = false;
            // 
            // lbComments
            // 
            this.lbComments.FormattingEnabled = true;
            this.lbComments.Location = new System.Drawing.Point(298, 58);
            this.lbComments.Name = "lbComments";
            this.lbComments.Size = new System.Drawing.Size(339, 433);
            this.lbComments.TabIndex = 28;
            this.lbComments.SelectedIndexChanged += new System.EventHandler(this.lbComments_SelectedIndexChanged);
            // 
            // lblUploadedBy
            // 
            this.lblUploadedBy.AutoSize = true;
            this.lblUploadedBy.Location = new System.Drawing.Point(4, 8);
            this.lblUploadedBy.Name = "lblUploadedBy";
            this.lblUploadedBy.Size = new System.Drawing.Size(70, 13);
            this.lblUploadedBy.TabIndex = 29;
            this.lblUploadedBy.Text = "Uploaded by:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(80, 8);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 30;
            this.lblName.Text = "Name";
            // 
            // lblTakenAt
            // 
            this.lblTakenAt.AutoSize = true;
            this.lblTakenAt.Location = new System.Drawing.Point(4, 21);
            this.lblTakenAt.Name = "lblTakenAt";
            this.lblTakenAt.Size = new System.Drawing.Size(53, 13);
            this.lblTakenAt.TabIndex = 31;
            this.lblTakenAt.Text = "Taken at:";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(80, 21);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(48, 13);
            this.lblLocation.TabIndex = 32;
            this.lblLocation.Text = "Location";
            // 
            // lblLikesNumber
            // 
            this.lblLikesNumber.AutoSize = true;
            this.lblLikesNumber.Location = new System.Drawing.Point(40, 270);
            this.lblLikesNumber.Name = "lblLikesNumber";
            this.lblLikesNumber.Size = new System.Drawing.Size(16, 13);
            this.lblLikesNumber.TabIndex = 34;
            this.lblLikesNumber.Text = " 0";
            // 
            // windowsMediaPlayer
            // 
            this.windowsMediaPlayer.Enabled = true;
            this.windowsMediaPlayer.Location = new System.Drawing.Point(8, 59);
            this.windowsMediaPlayer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.windowsMediaPlayer.Name = "windowsMediaPlayer";
            this.windowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("windowsMediaPlayer.OcxState")));
            this.windowsMediaPlayer.Size = new System.Drawing.Size(223, 207);
            this.windowsMediaPlayer.TabIndex = 35;
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(236, 58);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(56, 32);
            this.btnPlay.TabIndex = 36;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(236, 133);
            this.btnPause.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(56, 32);
            this.btnPause.TabIndex = 37;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(236, 96);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(56, 32);
            this.btnStart.TabIndex = 38;
            this.btnStart.Text = "Stop";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // ViewFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 555);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.windowsMediaPlayer);
            this.Controls.Add(this.lblLikesNumber);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblTakenAt);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblUploadedBy);
            this.Controls.Add(this.lbComments);
            this.Controls.Add(this.btnReportFile);
            this.Controls.Add(this.btnReportComment);
            this.Controls.Add(this.btnLikeComment);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddComment);
            this.Controls.Add(this.btnLikeThisFile);
            this.Controls.Add(this.lblLikes);
            this.Controls.Add(this.lblYourComment);
            this.Controls.Add(this.tbYourComment);
            this.Controls.Add(this.lblComments);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pbImage);
            this.Name = "ViewFile";
            this.Text = "View File";
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowsMediaPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReportFile;
        private System.Windows.Forms.Button btnReportComment;
        private System.Windows.Forms.Button btnLikeComment;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddComment;
        private System.Windows.Forms.Button btnLikeThisFile;
        private System.Windows.Forms.Label lblLikes;
        private System.Windows.Forms.Label lblYourComment;
        private System.Windows.Forms.TextBox tbYourComment;
        private System.Windows.Forms.Label lblComments;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.ListBox lbComments;
        private System.Windows.Forms.Label lblUploadedBy;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTakenAt;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblLikesNumber;
        private AxWMPLib.AxWindowsMediaPlayer windowsMediaPlayer;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStart;
    }
}