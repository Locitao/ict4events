namespace MediaSharingGuest
{
    partial class GuestForm
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
            this.components = new System.ComponentModel.Container();
            this.timerNewsFeed = new System.Windows.Forms.Timer(this.components);
            this.gbNewsfeed = new System.Windows.Forms.GroupBox();
            this.lblNewsMessage = new System.Windows.Forms.Label();
            this.tbNewsFeed = new System.Windows.Forms.TextBox();
            this.lblNewsFeedMessage = new System.Windows.Forms.Label();
            this.btnAddNewsFeedMessage = new System.Windows.Forms.Button();
            this.lbFolders = new System.Windows.Forms.ListBox();
            this.lblParentFolder = new System.Windows.Forms.Label();
            this.gbFiles = new System.Windows.Forms.GroupBox();
            this.lbMediaItems = new System.Windows.Forms.ListBox();
            this.btnAddFolder = new System.Windows.Forms.Button();
            this.btnAddFile = new System.Windows.Forms.Button();
            this.gbFolders = new System.Windows.Forms.GroupBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lblLoggedInAs = new System.Windows.Forms.Label();
            this.btnReportCategory = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnSearchCategory = new System.Windows.Forms.Button();
            this.btnSearchMedia = new System.Windows.Forms.Button();
            this.gbNewsfeed.SuspendLayout();
            this.gbFiles.SuspendLayout();
            this.gbFolders.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerNewsFeed
            // 
            this.timerNewsFeed.Interval = 3000;
            this.timerNewsFeed.Tick += new System.EventHandler(this.timerNewsFeed_Tick);
            // 
            // gbNewsfeed
            // 
            this.gbNewsfeed.Controls.Add(this.lblNewsMessage);
            this.gbNewsfeed.Location = new System.Drawing.Point(13, 13);
            this.gbNewsfeed.Margin = new System.Windows.Forms.Padding(4);
            this.gbNewsfeed.Name = "gbNewsfeed";
            this.gbNewsfeed.Padding = new System.Windows.Forms.Padding(4);
            this.gbNewsfeed.Size = new System.Drawing.Size(1264, 166);
            this.gbNewsfeed.TabIndex = 1;
            this.gbNewsfeed.TabStop = false;
            this.gbNewsfeed.Text = "Newsfeed";
            // 
            // lblNewsMessage
            // 
            this.lblNewsMessage.AutoSize = true;
            this.lblNewsMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewsMessage.Location = new System.Drawing.Point(23, 67);
            this.lblNewsMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNewsMessage.Name = "lblNewsMessage";
            this.lblNewsMessage.Size = new System.Drawing.Size(549, 54);
            this.lblNewsMessage.TabIndex = 0;
            this.lblNewsMessage.Text = "Jan: Newsfeed bericht!!!";
            // 
            // tbNewsFeed
            // 
            this.tbNewsFeed.Location = new System.Drawing.Point(155, 199);
            this.tbNewsFeed.Margin = new System.Windows.Forms.Padding(4);
            this.tbNewsFeed.MaxLength = 30;
            this.tbNewsFeed.Name = "tbNewsFeed";
            this.tbNewsFeed.Size = new System.Drawing.Size(991, 22);
            this.tbNewsFeed.TabIndex = 2;
            // 
            // lblNewsFeedMessage
            // 
            this.lblNewsFeedMessage.AutoSize = true;
            this.lblNewsFeedMessage.Location = new System.Drawing.Point(9, 202);
            this.lblNewsFeedMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNewsFeedMessage.Name = "lblNewsFeedMessage";
            this.lblNewsFeedMessage.Size = new System.Drawing.Size(135, 17);
            this.lblNewsFeedMessage.TabIndex = 1;
            this.lblNewsFeedMessage.Text = "Newsfeed message:";
            // 
            // btnAddNewsFeedMessage
            // 
            this.btnAddNewsFeedMessage.Location = new System.Drawing.Point(1155, 195);
            this.btnAddNewsFeedMessage.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddNewsFeedMessage.Name = "btnAddNewsFeedMessage";
            this.btnAddNewsFeedMessage.Size = new System.Drawing.Size(123, 28);
            this.btnAddNewsFeedMessage.TabIndex = 3;
            this.btnAddNewsFeedMessage.Text = "Add Message";
            this.btnAddNewsFeedMessage.UseVisualStyleBackColor = true;
            this.btnAddNewsFeedMessage.Click += new System.EventHandler(this.btnAddNewsFeedMessage_Click);
            // 
            // lbFolders
            // 
            this.lbFolders.FormattingEnabled = true;
            this.lbFolders.ItemHeight = 16;
            this.lbFolders.Location = new System.Drawing.Point(12, 59);
            this.lbFolders.Margin = new System.Windows.Forms.Padding(4);
            this.lbFolders.Name = "lbFolders";
            this.lbFolders.Size = new System.Drawing.Size(341, 500);
            this.lbFolders.TabIndex = 4;
            this.lbFolders.SelectedIndexChanged += new System.EventHandler(this.lbFolders_SelectedIndexChanged);
            // 
            // lblParentFolder
            // 
            this.lblParentFolder.AutoSize = true;
            this.lblParentFolder.Location = new System.Drawing.Point(8, 33);
            this.lblParentFolder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblParentFolder.Name = "lblParentFolder";
            this.lblParentFolder.Size = new System.Drawing.Size(86, 17);
            this.lblParentFolder.TabIndex = 5;
            this.lblParentFolder.Text = "Parentfolder";
            // 
            // gbFiles
            // 
            this.gbFiles.Controls.Add(this.btnSearch);
            this.gbFiles.Controls.Add(this.lbMediaItems);
            this.gbFiles.Controls.Add(this.btnReportCategory);
            this.gbFiles.Controls.Add(this.btnLogOut);
            this.gbFiles.Location = new System.Drawing.Point(432, 236);
            this.gbFiles.Margin = new System.Windows.Forms.Padding(4);
            this.gbFiles.Name = "gbFiles";
            this.gbFiles.Padding = new System.Windows.Forms.Padding(4);
            this.gbFiles.Size = new System.Drawing.Size(845, 626);
            this.gbFiles.TabIndex = 6;
            this.gbFiles.TabStop = false;
            this.gbFiles.Text = "Files";
            // 
            // lbMediaItems
            // 
            this.lbMediaItems.FormattingEnabled = true;
            this.lbMediaItems.ItemHeight = 16;
            this.lbMediaItems.Location = new System.Drawing.Point(8, 59);
            this.lbMediaItems.Margin = new System.Windows.Forms.Padding(4);
            this.lbMediaItems.Name = "lbMediaItems";
            this.lbMediaItems.Size = new System.Drawing.Size(828, 500);
            this.lbMediaItems.TabIndex = 10;
            this.lbMediaItems.SelectedIndexChanged += new System.EventHandler(this.lbMediaItems_SelectedIndexChanged);
            // 
            // btnAddFolder
            // 
            this.btnAddFolder.Location = new System.Drawing.Point(12, 567);
            this.btnAddFolder.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddFolder.Name = "btnAddFolder";
            this.btnAddFolder.Size = new System.Drawing.Size(169, 46);
            this.btnAddFolder.TabIndex = 7;
            this.btnAddFolder.Text = "Add Folder";
            this.btnAddFolder.UseVisualStyleBackColor = true;
            this.btnAddFolder.Click += new System.EventHandler(this.btnAddFolder_Click);
            // 
            // btnAddFile
            // 
            this.btnAddFile.Location = new System.Drawing.Point(189, 567);
            this.btnAddFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddFile.Name = "btnAddFile";
            this.btnAddFile.Size = new System.Drawing.Size(165, 46);
            this.btnAddFile.TabIndex = 8;
            this.btnAddFile.Text = "Add File";
            this.btnAddFile.UseVisualStyleBackColor = true;
            this.btnAddFile.Click += new System.EventHandler(this.btnAddFile_Click_1);
            // 
            // gbFolders
            // 
            this.gbFolders.Controls.Add(this.btnStart);
            this.gbFolders.Controls.Add(this.btnBack);
            this.gbFolders.Controls.Add(this.lblParentFolder);
            this.gbFolders.Controls.Add(this.btnAddFile);
            this.gbFolders.Controls.Add(this.lbFolders);
            this.gbFolders.Controls.Add(this.btnAddFolder);
            this.gbFolders.Location = new System.Drawing.Point(13, 236);
            this.gbFolders.Margin = new System.Windows.Forms.Padding(4);
            this.gbFolders.Name = "gbFolders";
            this.gbFolders.Padding = new System.Windows.Forms.Padding(4);
            this.gbFolders.Size = new System.Drawing.Size(396, 626);
            this.gbFolders.TabIndex = 9;
            this.gbFolders.TabStop = false;
            this.gbFolders.Text = "Folders";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(255, 27);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 28);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "<<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(669, 567);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(167, 46);
            this.btnLogOut.TabIndex = 10;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            // 
            // lblLoggedInAs
            // 
            this.lblLoggedInAs.AutoSize = true;
            this.lblLoggedInAs.Location = new System.Drawing.Point(1285, 24);
            this.lblLoggedInAs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoggedInAs.Name = "lblLoggedInAs";
            this.lblLoggedInAs.Size = new System.Drawing.Size(94, 17);
            this.lblLoggedInAs.TabIndex = 11;
            this.lblLoggedInAs.Text = "Logged in as:";
            // 
            // btnReportCategory
            // 
            this.btnReportCategory.Location = new System.Drawing.Point(8, 567);
            this.btnReportCategory.Margin = new System.Windows.Forms.Padding(4);
            this.btnReportCategory.Name = "btnReportCategory";
            this.btnReportCategory.Size = new System.Drawing.Size(167, 46);
            this.btnReportCategory.TabIndex = 13;
            this.btnReportCategory.Text = "Report Category";
            this.btnReportCategory.UseVisualStyleBackColor = true;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(1285, 41);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(73, 17);
            this.lblUsername.TabIndex = 14;
            this.lblUsername.Text = "Username";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(325, 567);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(167, 46);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(142, 27);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 28);
            this.btnStart.TabIndex = 10;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(500, 869);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(443, 22);
            this.tbSearch.TabIndex = 15;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(437, 869);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(57, 17);
            this.lblSearch.TabIndex = 16;
            this.lblSearch.Text = "Search:";
            // 
            // btnSearchCategory
            // 
            this.btnSearchCategory.Location = new System.Drawing.Point(500, 897);
            this.btnSearchCategory.Name = "btnSearchCategory";
            this.btnSearchCategory.Size = new System.Drawing.Size(171, 35);
            this.btnSearchCategory.TabIndex = 17;
            this.btnSearchCategory.Text = "Search Category";
            this.btnSearchCategory.UseVisualStyleBackColor = true;
            this.btnSearchCategory.Click += new System.EventHandler(this.btnSearchCategory_Click);
            // 
            // btnSearchMedia
            // 
            this.btnSearchMedia.Location = new System.Drawing.Point(677, 897);
            this.btnSearchMedia.Name = "btnSearchMedia";
            this.btnSearchMedia.Size = new System.Drawing.Size(171, 35);
            this.btnSearchMedia.TabIndex = 19;
            this.btnSearchMedia.Text = "Search Media Item";
            this.btnSearchMedia.UseVisualStyleBackColor = true;
            // 
            // GuestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1503, 967);
            this.Controls.Add(this.btnSearchMedia);
            this.Controls.Add(this.btnSearchCategory);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblLoggedInAs);
            this.Controls.Add(this.gbFolders);
            this.Controls.Add(this.gbFiles);
            this.Controls.Add(this.btnAddNewsFeedMessage);
            this.Controls.Add(this.lblNewsFeedMessage);
            this.Controls.Add(this.tbNewsFeed);
            this.Controls.Add(this.gbNewsfeed);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GuestForm";
            this.Text = "Mediasharing";
            this.gbNewsfeed.ResumeLayout(false);
            this.gbNewsfeed.PerformLayout();
            this.gbFiles.ResumeLayout(false);
            this.gbFolders.ResumeLayout(false);
            this.gbFolders.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerNewsFeed;
        private System.Windows.Forms.GroupBox gbNewsfeed;
        private System.Windows.Forms.Label lblNewsMessage;
        private System.Windows.Forms.TextBox tbNewsFeed;
        private System.Windows.Forms.Label lblNewsFeedMessage;
        private System.Windows.Forms.Button btnAddNewsFeedMessage;
        private System.Windows.Forms.ListBox lbFolders;
        private System.Windows.Forms.Label lblParentFolder;
        private System.Windows.Forms.GroupBox gbFiles;
        private System.Windows.Forms.Button btnAddFolder;
        private System.Windows.Forms.Button btnAddFile;
        private System.Windows.Forms.GroupBox gbFolders;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label lblLoggedInAs;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnReportCategory;
        private System.Windows.Forms.ListBox lbMediaItems;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnSearchCategory;
        private System.Windows.Forms.Button btnSearchMedia;
    }
}

