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
            this.btnBack = new System.Windows.Forms.Button();
            this.lblLikesNumber = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReportFile
            // 
            this.btnReportFile.Location = new System.Drawing.Point(448, 880);
            this.btnReportFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnReportFile.Name = "btnReportFile";
            this.btnReportFile.Size = new System.Drawing.Size(155, 49);
            this.btnReportFile.TabIndex = 27;
            this.btnReportFile.Text = "Report this file";
            this.btnReportFile.UseVisualStyleBackColor = true;
            this.btnReportFile.Click += new System.EventHandler(this.btnReportFile_Click);
            // 
            // btnReportComment
            // 
            this.btnReportComment.Location = new System.Drawing.Point(883, 880);
            this.btnReportComment.Margin = new System.Windows.Forms.Padding(4);
            this.btnReportComment.Name = "btnReportComment";
            this.btnReportComment.Size = new System.Drawing.Size(195, 49);
            this.btnReportComment.TabIndex = 26;
            this.btnReportComment.Text = "Report selected comment";
            this.btnReportComment.UseVisualStyleBackColor = true;
            this.btnReportComment.Click += new System.EventHandler(this.btnReportComment_Click);
            // 
            // btnLikeComment
            // 
            this.btnLikeComment.Location = new System.Drawing.Point(625, 880);
            this.btnLikeComment.Margin = new System.Windows.Forms.Padding(4);
            this.btnLikeComment.Name = "btnLikeComment";
            this.btnLikeComment.Size = new System.Drawing.Size(195, 49);
            this.btnLikeComment.TabIndex = 25;
            this.btnLikeComment.Text = "Like selected comment!";
            this.btnLikeComment.UseVisualStyleBackColor = true;
            this.btnLikeComment.Click += new System.EventHandler(this.btnLikeComment_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(179, 880);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(155, 49);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddComment
            // 
            this.btnAddComment.Location = new System.Drawing.Point(16, 880);
            this.btnAddComment.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddComment.Name = "btnAddComment";
            this.btnAddComment.Size = new System.Drawing.Size(155, 49);
            this.btnAddComment.TabIndex = 23;
            this.btnAddComment.Text = "Add Comment";
            this.btnAddComment.UseVisualStyleBackColor = true;
            this.btnAddComment.Click += new System.EventHandler(this.btnAddComment_Click);
            // 
            // btnLikeThisFile
            // 
            this.btnLikeThisFile.Location = new System.Drawing.Point(503, 684);
            this.btnLikeThisFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnLikeThisFile.Name = "btnLikeThisFile";
            this.btnLikeThisFile.Size = new System.Drawing.Size(100, 64);
            this.btnLikeThisFile.TabIndex = 22;
            this.btnLikeThisFile.Text = "Like this file!";
            this.btnLikeThisFile.UseVisualStyleBackColor = true;
            this.btnLikeThisFile.Click += new System.EventHandler(this.btnLikeThisFile_Click);
            // 
            // lblLikes
            // 
            this.lblLikes.AutoSize = true;
            this.lblLikes.Location = new System.Drawing.Point(16, 697);
            this.lblLikes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLikes.Name = "lblLikes";
            this.lblLikes.Size = new System.Drawing.Size(45, 17);
            this.lblLikes.TabIndex = 21;
            this.lblLikes.Text = "Likes:";
            // 
            // lblYourComment
            // 
            this.lblYourComment.AutoSize = true;
            this.lblYourComment.Location = new System.Drawing.Point(16, 736);
            this.lblYourComment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYourComment.Name = "lblYourComment";
            this.lblYourComment.Size = new System.Drawing.Size(103, 17);
            this.lblYourComment.TabIndex = 20;
            this.lblYourComment.Text = "Your comment:";
            // 
            // tbYourComment
            // 
            this.tbYourComment.Location = new System.Drawing.Point(16, 756);
            this.tbYourComment.Margin = new System.Windows.Forms.Padding(4);
            this.tbYourComment.Multiline = true;
            this.tbYourComment.Name = "tbYourComment";
            this.tbYourComment.Size = new System.Drawing.Size(585, 116);
            this.tbYourComment.TabIndex = 19;
            // 
            // lblComments
            // 
            this.lblComments.AutoSize = true;
            this.lblComments.Location = new System.Drawing.Point(621, 101);
            this.lblComments.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(78, 17);
            this.lblComments.TabIndex = 18;
            this.lblComments.Text = "Comments:";
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(16, 532);
            this.tbDescription.Margin = new System.Windows.Forms.Padding(4);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.ReadOnly = true;
            this.tbDescription.Size = new System.Drawing.Size(589, 149);
            this.tbDescription.TabIndex = 16;
            this.tbDescription.TabStop = false;
            this.tbDescription.Text = "Description";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(16, 98);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(35, 17);
            this.lblTitle.TabIndex = 15;
            this.lblTitle.Text = "Title";
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(16, 118);
            this.pbImage.Margin = new System.Windows.Forms.Padding(4);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(591, 406);
            this.pbImage.TabIndex = 14;
            this.pbImage.TabStop = false;
            // 
            // lbComments
            // 
            this.lbComments.FormattingEnabled = true;
            this.lbComments.ItemHeight = 16;
            this.lbComments.Location = new System.Drawing.Point(625, 121);
            this.lbComments.Margin = new System.Windows.Forms.Padding(4);
            this.lbComments.Name = "lbComments";
            this.lbComments.Size = new System.Drawing.Size(451, 756);
            this.lbComments.TabIndex = 28;
            this.lbComments.SelectedIndexChanged += new System.EventHandler(this.lbComments_SelectedIndexChanged);
            // 
            // lblUploadedBy
            // 
            this.lblUploadedBy.AutoSize = true;
            this.lblUploadedBy.Location = new System.Drawing.Point(5, 11);
            this.lblUploadedBy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUploadedBy.Name = "lblUploadedBy";
            this.lblUploadedBy.Size = new System.Drawing.Size(92, 17);
            this.lblUploadedBy.TabIndex = 29;
            this.lblUploadedBy.Text = "Uploaded by:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(107, 11);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 17);
            this.lblName.TabIndex = 30;
            this.lblName.Text = "Name";
            // 
            // lblTakenAt
            // 
            this.lblTakenAt.AutoSize = true;
            this.lblTakenAt.Location = new System.Drawing.Point(5, 27);
            this.lblTakenAt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTakenAt.Name = "lblTakenAt";
            this.lblTakenAt.Size = new System.Drawing.Size(68, 17);
            this.lblTakenAt.TabIndex = 31;
            this.lblTakenAt.Text = "Taken at:";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(107, 27);
            this.lblLocation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(62, 17);
            this.lblLocation.TabIndex = 32;
            this.lblLocation.Text = "Location";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(9, 47);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(101, 49);
            this.btnBack.TabIndex = 33;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblLikesNumber
            // 
            this.lblLikesNumber.AutoSize = true;
            this.lblLikesNumber.Location = new System.Drawing.Point(64, 697);
            this.lblLikesNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLikesNumber.Name = "lblLikesNumber";
            this.lblLikesNumber.Size = new System.Drawing.Size(20, 17);
            this.lblLikesNumber.TabIndex = 34;
            this.lblLikesNumber.Text = " 0";
            // 
            // ViewFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 958);
            this.Controls.Add(this.lblLikesNumber);
            this.Controls.Add(this.btnBack);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ViewFile";
            this.Text = "ViewFile";
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
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
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblLikesNumber;
    }
}