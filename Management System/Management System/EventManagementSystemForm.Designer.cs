﻿namespace Management_System
{
    partial class EventManagementSystemForm
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
            this.btnNewCamping = new System.Windows.Forms.Button();
            this.lblMaxVisitors = new System.Windows.Forms.Label();
            this.lbCampings = new System.Windows.Forms.ListBox();
            this.lblCampingName = new System.Windows.Forms.Label();
            this.tbCampingName = new System.Windows.Forms.TextBox();
            this.lbLocations = new System.Windows.Forms.ListBox();
            this.btnAddLocation = new System.Windows.Forms.Button();
            this.lblMaxGuests = new System.Windows.Forms.Label();
            this.numMaxGuests = new System.Windows.Forms.NumericUpDown();
            this.tbMaxVisitors = new System.Windows.Forms.TextBox();
            this.btnDeleteCamping = new System.Windows.Forms.Button();
            this.lbEvents = new System.Windows.Forms.ListBox();
            this.lblCamping = new System.Windows.Forms.Label();
            this.lblLocations = new System.Windows.Forms.Label();
            this.btnDeleteLocation = new System.Windows.Forms.Button();
            this.lblEvents = new System.Windows.Forms.Label();
            this.dateTimePickerStartingDate = new System.Windows.Forms.DateTimePicker();
            this.lblStartingDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.dateTimePickerEndingDate = new System.Windows.Forms.DateTimePicker();
            this.btnCreateEvent = new System.Windows.Forms.Button();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.lblLocationType = new System.Windows.Forms.Label();
            this.numPrice = new System.Windows.Forms.NumericUpDown();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblmap = new System.Windows.Forms.Label();
            this.tbMapPath = new System.Windows.Forms.TextBox();
            this.tbEventName = new System.Windows.Forms.TextBox();
            this.lblEventName = new System.Windows.Forms.Label();
            this.lblDesctiption = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxGuests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNewCamping
            // 
            this.btnNewCamping.Location = new System.Drawing.Point(119, 202);
            this.btnNewCamping.Name = "btnNewCamping";
            this.btnNewCamping.Size = new System.Drawing.Size(108, 23);
            this.btnNewCamping.TabIndex = 4;
            this.btnNewCamping.Text = "Add new camping";
            this.btnNewCamping.UseVisualStyleBackColor = true;
            this.btnNewCamping.Click += new System.EventHandler(this.btnNewCamping_Click);
            // 
            // lblMaxVisitors
            // 
            this.lblMaxVisitors.AutoSize = true;
            this.lblMaxVisitors.Location = new System.Drawing.Point(12, 149);
            this.lblMaxVisitors.Name = "lblMaxVisitors";
            this.lblMaxVisitors.Size = new System.Drawing.Size(67, 13);
            this.lblMaxVisitors.TabIndex = 5;
            this.lblMaxVisitors.Text = "max. visitors:";
            // 
            // lbCampings
            // 
            this.lbCampings.FormattingEnabled = true;
            this.lbCampings.Location = new System.Drawing.Point(12, 30);
            this.lbCampings.Name = "lbCampings";
            this.lbCampings.Size = new System.Drawing.Size(215, 82);
            this.lbCampings.TabIndex = 0;
            this.lbCampings.SelectedIndexChanged += new System.EventHandler(this.lbCampings_SelectedIndexChanged);
            // 
            // lblCampingName
            // 
            this.lblCampingName.AutoSize = true;
            this.lblCampingName.Location = new System.Drawing.Point(12, 121);
            this.lblCampingName.Name = "lblCampingName";
            this.lblCampingName.Size = new System.Drawing.Size(79, 13);
            this.lblCampingName.TabIndex = 6;
            this.lblCampingName.Text = "name camping:";
            // 
            // tbCampingName
            // 
            this.tbCampingName.Location = new System.Drawing.Point(97, 118);
            this.tbCampingName.Name = "tbCampingName";
            this.tbCampingName.Size = new System.Drawing.Size(130, 20);
            this.tbCampingName.TabIndex = 0;
            this.tbCampingName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress_LettersAndDigits);
            // 
            // lbLocations
            // 
            this.lbLocations.FormattingEnabled = true;
            this.lbLocations.Location = new System.Drawing.Point(270, 30);
            this.lbLocations.Name = "lbLocations";
            this.lbLocations.Size = new System.Drawing.Size(341, 82);
            this.lbLocations.TabIndex = 7;
            // 
            // btnAddLocation
            // 
            this.btnAddLocation.Location = new System.Drawing.Point(450, 201);
            this.btnAddLocation.Name = "btnAddLocation";
            this.btnAddLocation.Size = new System.Drawing.Size(89, 23);
            this.btnAddLocation.TabIndex = 10;
            this.btnAddLocation.Text = "Add location";
            this.btnAddLocation.UseVisualStyleBackColor = true;
            this.btnAddLocation.Click += new System.EventHandler(this.btnAddLocation_Click);
            // 
            // lblMaxGuests
            // 
            this.lblMaxGuests.AutoSize = true;
            this.lblMaxGuests.Location = new System.Drawing.Point(354, 124);
            this.lblMaxGuests.Name = "lblMaxGuests";
            this.lblMaxGuests.Size = new System.Drawing.Size(68, 13);
            this.lblMaxGuests.TabIndex = 10;
            this.lblMaxGuests.Text = "max. Guests:";
            // 
            // numMaxGuests
            // 
            this.numMaxGuests.Location = new System.Drawing.Point(450, 122);
            this.numMaxGuests.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numMaxGuests.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMaxGuests.Name = "numMaxGuests";
            this.numMaxGuests.Size = new System.Drawing.Size(89, 20);
            this.numMaxGuests.TabIndex = 6;
            this.numMaxGuests.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tbMaxVisitors
            // 
            this.tbMaxVisitors.Location = new System.Drawing.Point(97, 146);
            this.tbMaxVisitors.Name = "tbMaxVisitors";
            this.tbMaxVisitors.ReadOnly = true;
            this.tbMaxVisitors.Size = new System.Drawing.Size(130, 20);
            this.tbMaxVisitors.TabIndex = 1;
            // 
            // btnDeleteCamping
            // 
            this.btnDeleteCamping.Location = new System.Drawing.Point(12, 202);
            this.btnDeleteCamping.Name = "btnDeleteCamping";
            this.btnDeleteCamping.Size = new System.Drawing.Size(101, 23);
            this.btnDeleteCamping.TabIndex = 3;
            this.btnDeleteCamping.Text = "Delete selected";
            this.btnDeleteCamping.UseVisualStyleBackColor = true;
            this.btnDeleteCamping.Click += new System.EventHandler(this.btnDeleteCamping_Click);
            // 
            // lbEvents
            // 
            this.lbEvents.FormattingEnabled = true;
            this.lbEvents.Location = new System.Drawing.Point(270, 277);
            this.lbEvents.Name = "lbEvents";
            this.lbEvents.Size = new System.Drawing.Size(341, 212);
            this.lbEvents.TabIndex = 16;
            // 
            // lblCamping
            // 
            this.lblCamping.AutoSize = true;
            this.lblCamping.Location = new System.Drawing.Point(14, 11);
            this.lblCamping.Name = "lblCamping";
            this.lblCamping.Size = new System.Drawing.Size(56, 13);
            this.lblCamping.TabIndex = 17;
            this.lblCamping.Text = "Campings:";
            // 
            // lblLocations
            // 
            this.lblLocations.AutoSize = true;
            this.lblLocations.Location = new System.Drawing.Point(270, 11);
            this.lblLocations.Name = "lblLocations";
            this.lblLocations.Size = new System.Drawing.Size(56, 13);
            this.lblLocations.TabIndex = 18;
            this.lblLocations.Text = "Locations:";
            // 
            // btnDeleteLocation
            // 
            this.btnDeleteLocation.Location = new System.Drawing.Point(357, 201);
            this.btnDeleteLocation.Name = "btnDeleteLocation";
            this.btnDeleteLocation.Size = new System.Drawing.Size(90, 23);
            this.btnDeleteLocation.TabIndex = 9;
            this.btnDeleteLocation.Text = "Delete Location";
            this.btnDeleteLocation.UseVisualStyleBackColor = true;
            this.btnDeleteLocation.Click += new System.EventHandler(this.btnDeleteLocation_Click);
            // 
            // lblEvents
            // 
            this.lblEvents.AutoSize = true;
            this.lblEvents.Location = new System.Drawing.Point(270, 261);
            this.lblEvents.Name = "lblEvents";
            this.lblEvents.Size = new System.Drawing.Size(43, 13);
            this.lblEvents.TabIndex = 20;
            this.lblEvents.Text = "Events:";
            // 
            // dateTimePickerStartingDate
            // 
            this.dateTimePickerStartingDate.Location = new System.Drawing.Point(9, 277);
            this.dateTimePickerStartingDate.Name = "dateTimePickerStartingDate";
            this.dateTimePickerStartingDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerStartingDate.TabIndex = 11;
            // 
            // lblStartingDate
            // 
            this.lblStartingDate.AutoSize = true;
            this.lblStartingDate.Location = new System.Drawing.Point(6, 261);
            this.lblStartingDate.Name = "lblStartingDate";
            this.lblStartingDate.Size = new System.Drawing.Size(72, 13);
            this.lblStartingDate.TabIndex = 22;
            this.lblStartingDate.Text = "Starting Date:";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(6, 300);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(69, 13);
            this.lblEndDate.TabIndex = 24;
            this.lblEndDate.Text = "Ending Date:";
            // 
            // dateTimePickerEndingDate
            // 
            this.dateTimePickerEndingDate.Location = new System.Drawing.Point(9, 316);
            this.dateTimePickerEndingDate.Name = "dateTimePickerEndingDate";
            this.dateTimePickerEndingDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerEndingDate.TabIndex = 12;
            // 
            // btnCreateEvent
            // 
            this.btnCreateEvent.Location = new System.Drawing.Point(12, 420);
            this.btnCreateEvent.Name = "btnCreateEvent";
            this.btnCreateEvent.Size = new System.Drawing.Size(200, 60);
            this.btnCreateEvent.TabIndex = 15;
            this.btnCreateEvent.Text = "Create event";
            this.btnCreateEvent.UseVisualStyleBackColor = true;
            this.btnCreateEvent.Click += new System.EventHandler(this.btnCreateEvent_Click);
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(450, 148);
            this.cbType.MaxDropDownItems = 20;
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(89, 21);
            this.cbType.TabIndex = 7;
            // 
            // lblLocationType
            // 
            this.lblLocationType.AutoSize = true;
            this.lblLocationType.Location = new System.Drawing.Point(354, 151);
            this.lblLocationType.Name = "lblLocationType";
            this.lblLocationType.Size = new System.Drawing.Size(74, 13);
            this.lblLocationType.TabIndex = 27;
            this.lblLocationType.Text = "Location type:";
            // 
            // numPrice
            // 
            this.numPrice.Location = new System.Drawing.Point(450, 175);
            this.numPrice.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numPrice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(89, 20);
            this.numPrice.TabIndex = 8;
            this.numPrice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(354, 177);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(34, 13);
            this.lblPrice.TabIndex = 29;
            this.lblPrice.Text = "Price:";
            // 
            // lblmap
            // 
            this.lblmap.AutoSize = true;
            this.lblmap.Location = new System.Drawing.Point(14, 176);
            this.lblmap.Name = "lblmap";
            this.lblmap.Size = new System.Drawing.Size(55, 13);
            this.lblmap.TabIndex = 30;
            this.lblmap.Text = "Map path:";
            // 
            // tbMapPath
            // 
            this.tbMapPath.Location = new System.Drawing.Point(97, 173);
            this.tbMapPath.Name = "tbMapPath";
            this.tbMapPath.ReadOnly = true;
            this.tbMapPath.Size = new System.Drawing.Size(130, 20);
            this.tbMapPath.TabIndex = 2;
            // 
            // tbEventName
            // 
            this.tbEventName.Location = new System.Drawing.Point(12, 355);
            this.tbEventName.Name = "tbEventName";
            this.tbEventName.Size = new System.Drawing.Size(197, 20);
            this.tbEventName.TabIndex = 13;
            this.tbEventName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress_LettersAndDigits);
            // 
            // lblEventName
            // 
            this.lblEventName.AutoSize = true;
            this.lblEventName.Location = new System.Drawing.Point(9, 339);
            this.lblEventName.Name = "lblEventName";
            this.lblEventName.Size = new System.Drawing.Size(69, 13);
            this.lblEventName.TabIndex = 34;
            this.lblEventName.Text = "Event Name:";
            // 
            // lblDesctiption
            // 
            this.lblDesctiption.AutoSize = true;
            this.lblDesctiption.Location = new System.Drawing.Point(11, 378);
            this.lblDesctiption.Name = "lblDesctiption";
            this.lblDesctiption.Size = new System.Drawing.Size(63, 13);
            this.lblDesctiption.TabIndex = 35;
            this.lblDesctiption.Text = "Description:";
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(12, 394);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(197, 20);
            this.tbDescription.TabIndex = 14;
            this.tbDescription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress_LettersAndDigits);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(233, 173);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(52, 23);
            this.btnBrowse.TabIndex = 36;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // EventManagementSystemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 502);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.lblDesctiption);
            this.Controls.Add(this.lblEventName);
            this.Controls.Add(this.tbEventName);
            this.Controls.Add(this.tbMapPath);
            this.Controls.Add(this.lblmap);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.numPrice);
            this.Controls.Add(this.lblLocationType);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.btnCreateEvent);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.dateTimePickerEndingDate);
            this.Controls.Add(this.lblStartingDate);
            this.Controls.Add(this.dateTimePickerStartingDate);
            this.Controls.Add(this.lblEvents);
            this.Controls.Add(this.btnDeleteLocation);
            this.Controls.Add(this.lblLocations);
            this.Controls.Add(this.lblCamping);
            this.Controls.Add(this.lbEvents);
            this.Controls.Add(this.btnDeleteCamping);
            this.Controls.Add(this.tbMaxVisitors);
            this.Controls.Add(this.numMaxGuests);
            this.Controls.Add(this.btnAddLocation);
            this.Controls.Add(this.lblMaxGuests);
            this.Controls.Add(this.lbLocations);
            this.Controls.Add(this.tbCampingName);
            this.Controls.Add(this.lblCampingName);
            this.Controls.Add(this.lbCampings);
            this.Controls.Add(this.btnNewCamping);
            this.Controls.Add(this.lblMaxVisitors);
            this.Name = "EventManagementSystemForm";
            this.Text = "Management System";
            ((System.ComponentModel.ISupportInitialize)(this.numMaxGuests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewCamping;
        private System.Windows.Forms.Label lblMaxVisitors;
        private System.Windows.Forms.ListBox lbCampings;
        private System.Windows.Forms.Label lblCampingName;
        private System.Windows.Forms.TextBox tbCampingName;
        private System.Windows.Forms.ListBox lbLocations;
        private System.Windows.Forms.Button btnAddLocation;
        private System.Windows.Forms.Label lblMaxGuests;
        private System.Windows.Forms.NumericUpDown numMaxGuests;
        private System.Windows.Forms.TextBox tbMaxVisitors;
        private System.Windows.Forms.Button btnDeleteCamping;
        private System.Windows.Forms.ListBox lbEvents;
        private System.Windows.Forms.Label lblCamping;
        private System.Windows.Forms.Label lblLocations;
        private System.Windows.Forms.Button btnDeleteLocation;
        private System.Windows.Forms.Label lblEvents;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartingDate;
        private System.Windows.Forms.Label lblStartingDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndingDate;
        private System.Windows.Forms.Button btnCreateEvent;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label lblLocationType;
        private System.Windows.Forms.NumericUpDown numPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblmap;
        private System.Windows.Forms.TextBox tbMapPath;
        private System.Windows.Forms.TextBox tbEventName;
        private System.Windows.Forms.Label lblEventName;
        private System.Windows.Forms.Label lblDesctiption;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Button btnBrowse;

    }
}