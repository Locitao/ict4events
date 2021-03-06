﻿namespace MediaSharingGuest
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
            this.btnReportCategory = new System.Windows.Forms.Button();
            this.btnSearchMedia = new System.Windows.Forms.Button();
            this.btnSearchCategory = new System.Windows.Forms.Button();
            this.lbMediaItems = new System.Windows.Forms.ListBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnAddFolder = new System.Windows.Forms.Button();
            this.btnAddFile = new System.Windows.Forms.Button();
            this.gbFolders = new System.Windows.Forms.GroupBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblLoggedInAs = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
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
            this.gbNewsfeed.Size = new System.Drawing.Size(881, 166);
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
            this.lblNewsMessage.Size = new System.Drawing.Size(412, 54);
            this.lblNewsMessage.TabIndex = 0;
            this.lblNewsMessage.Text = "User: Testbericht!";
            // 
            // tbNewsFeed
            // 
            this.tbNewsFeed.Location = new System.Drawing.Point(155, 199);
            this.tbNewsFeed.Margin = new System.Windows.Forms.Padding(4);
            this.tbNewsFeed.MaxLength = 50;
            this.tbNewsFeed.Name = "tbNewsFeed";
            this.tbNewsFeed.Size = new System.Drawing.Size(621, 22);
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
            this.btnAddNewsFeedMessage.Location = new System.Drawing.Point(784, 199);
            this.btnAddNewsFeedMessage.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddNewsFeedMessage.Name = "btnAddNewsFeedMessage";
            this.btnAddNewsFeedMessage.Size = new System.Drawing.Size(110, 28);
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
            this.lbFolders.Size = new System.Drawing.Size(169, 276);
            this.lbFolders.TabIndex = 4;
            this.lbFolders.SelectedIndexChanged += new System.EventHandler(this.lbFolders_SelectedIndexChanged);
            this.lbFolders.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbFolders_MouseDoubleClick);
            // 
            // lblParentFolder
            // 
            this.lblParentFolder.AutoSize = true;
            this.lblParentFolder.Location = new System.Drawing.Point(8, 33);
            this.lblParentFolder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblParentFolder.Name = "lblParentFolder";
            this.lblParentFolder.Size = new System.Drawing.Size(55, 17);
            this.lblParentFolder.TabIndex = 5;
            this.lblParentFolder.Text = "Folders";
            // 
            // gbFiles
            // 
            this.gbFiles.Controls.Add(this.btnReportCategory);
            this.gbFiles.Controls.Add(this.btnSearchMedia);
            this.gbFiles.Controls.Add(this.btnSearchCategory);
            this.gbFiles.Controls.Add(this.lbMediaItems);
            this.gbFiles.Controls.Add(this.tbSearch);
            this.gbFiles.Controls.Add(this.lblSearch);
            this.gbFiles.Controls.Add(this.btnLogOut);
            this.gbFiles.Location = new System.Drawing.Point(212, 236);
            this.gbFiles.Margin = new System.Windows.Forms.Padding(4);
            this.gbFiles.Name = "gbFiles";
            this.gbFiles.Padding = new System.Windows.Forms.Padding(4);
            this.gbFiles.Size = new System.Drawing.Size(682, 399);
            this.gbFiles.TabIndex = 6;
            this.gbFiles.TabStop = false;
            this.gbFiles.Text = "Files";
            // 
            // btnReportCategory
            // 
            this.btnReportCategory.Location = new System.Drawing.Point(18, 343);
            this.btnReportCategory.Margin = new System.Windows.Forms.Padding(4);
            this.btnReportCategory.Name = "btnReportCategory";
            this.btnReportCategory.Size = new System.Drawing.Size(167, 46);
            this.btnReportCategory.TabIndex = 20;
            this.btnReportCategory.Text = "Report Category";
            this.btnReportCategory.UseVisualStyleBackColor = true;
            this.btnReportCategory.Click += new System.EventHandler(this.btnReportCategory_Click);
            // 
            // btnSearchMedia
            // 
            this.btnSearchMedia.Location = new System.Drawing.Point(528, 22);
            this.btnSearchMedia.Name = "btnSearchMedia";
            this.btnSearchMedia.Size = new System.Drawing.Size(132, 35);
            this.btnSearchMedia.TabIndex = 19;
            this.btnSearchMedia.Text = "Search Media";
            this.btnSearchMedia.UseVisualStyleBackColor = true;
            this.btnSearchMedia.Click += new System.EventHandler(this.btnSearchMedia_Click);
            // 
            // btnSearchCategory
            // 
            this.btnSearchCategory.Location = new System.Drawing.Point(390, 22);
            this.btnSearchCategory.Name = "btnSearchCategory";
            this.btnSearchCategory.Size = new System.Drawing.Size(132, 35);
            this.btnSearchCategory.TabIndex = 17;
            this.btnSearchCategory.Text = "Search Category";
            this.btnSearchCategory.UseVisualStyleBackColor = true;
            this.btnSearchCategory.Click += new System.EventHandler(this.btnSearchCategory_Click);
            // 
            // lbMediaItems
            // 
            this.lbMediaItems.FormattingEnabled = true;
            this.lbMediaItems.ItemHeight = 16;
            this.lbMediaItems.Location = new System.Drawing.Point(18, 64);
            this.lbMediaItems.Margin = new System.Windows.Forms.Padding(4);
            this.lbMediaItems.Name = "lbMediaItems";
            this.lbMediaItems.Size = new System.Drawing.Size(642, 276);
            this.lbMediaItems.TabIndex = 10;
            this.lbMediaItems.SelectedIndexChanged += new System.EventHandler(this.lbMediaItems_SelectedIndexChanged);
            this.lbMediaItems.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbMediaItems_MouseDoubleClick);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(68, 33);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(316, 22);
            this.tbSearch.TabIndex = 15;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(7, 38);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(57, 17);
            this.lblSearch.TabIndex = 16;
            this.lblSearch.Text = "Search:";
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(193, 343);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(167, 46);
            this.btnLogOut.TabIndex = 10;
            this.btnLogOut.Text = "Close";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnAddFolder
            // 
            this.btnAddFolder.Location = new System.Drawing.Point(12, 343);
            this.btnAddFolder.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddFolder.Name = "btnAddFolder";
            this.btnAddFolder.Size = new System.Drawing.Size(87, 46);
            this.btnAddFolder.TabIndex = 7;
            this.btnAddFolder.Text = "Add Folder";
            this.btnAddFolder.UseVisualStyleBackColor = true;
            this.btnAddFolder.Click += new System.EventHandler(this.btnAddFolder_Click);
            // 
            // btnAddFile
            // 
            this.btnAddFile.Location = new System.Drawing.Point(98, 343);
            this.btnAddFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddFile.Name = "btnAddFile";
            this.btnAddFile.Size = new System.Drawing.Size(83, 46);
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
            this.gbFolders.Size = new System.Drawing.Size(191, 399);
            this.gbFolders.TabIndex = 9;
            this.gbFolders.TabStop = false;
            this.gbFolders.Text = "Folders";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(71, 27);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(60, 28);
            this.btnStart.TabIndex = 10;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(139, 27);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(42, 28);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "<<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblLoggedInAs
            // 
            this.lblLoggedInAs.AutoSize = true;
            this.lblLoggedInAs.Location = new System.Drawing.Point(902, 22);
            this.lblLoggedInAs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoggedInAs.Name = "lblLoggedInAs";
            this.lblLoggedInAs.Size = new System.Drawing.Size(94, 17);
            this.lblLoggedInAs.TabIndex = 11;
            this.lblLoggedInAs.Text = "Logged in as:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(902, 39);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(73, 17);
            this.lblUsername.TabIndex = 14;
            this.lblUsername.Text = "Username";
            // 
            // GuestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 657);
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
            this.gbFiles.PerformLayout();
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
        private System.Windows.Forms.ListBox lbMediaItems;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnSearchCategory;
        private System.Windows.Forms.Button btnSearchMedia;
        private System.Windows.Forms.Button btnReportCategory;
    }
}

