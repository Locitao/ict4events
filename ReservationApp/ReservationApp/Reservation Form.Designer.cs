namespace ReservationApp
{
    partial class ReservationForm
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbPostal = new System.Windows.Forms.TextBox();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.lbLocations = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nmLocId = new System.Windows.Forms.NumericUpDown();
            this.btnCreateRes = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cbEvent = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.nmPeople = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.pbLocations = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmLocId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPeople)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLocations)).BeginInit();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(150, 28);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(135, 20);
            this.tbName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Full name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Postal Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "City";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Phone number";
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(150, 72);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(135, 20);
            this.tbAddress.TabIndex = 7;
            // 
            // tbPostal
            // 
            this.tbPostal.Location = new System.Drawing.Point(150, 109);
            this.tbPostal.Name = "tbPostal";
            this.tbPostal.Size = new System.Drawing.Size(135, 20);
            this.tbPostal.TabIndex = 8;
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(150, 143);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(135, 20);
            this.tbCity.TabIndex = 9;
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(150, 178);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(135, 20);
            this.tbPhone.TabIndex = 10;
            // 
            // lbLocations
            // 
            this.lbLocations.FormattingEnabled = true;
            this.lbLocations.Location = new System.Drawing.Point(328, 28);
            this.lbLocations.Name = "lbLocations";
            this.lbLocations.Size = new System.Drawing.Size(481, 290);
            this.lbLocations.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Location ID you want to reserve:";
            // 
            // nmLocId
            // 
            this.nmLocId.Location = new System.Drawing.Point(199, 217);
            this.nmLocId.Name = "nmLocId";
            this.nmLocId.Size = new System.Drawing.Size(86, 20);
            this.nmLocId.TabIndex = 14;
            this.nmLocId.ValueChanged += new System.EventHandler(this.nmLocId_ValueChanged);
            // 
            // btnCreateRes
            // 
            this.btnCreateRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateRes.Location = new System.Drawing.Point(85, 316);
            this.btnCreateRes.Name = "btnCreateRes";
            this.btnCreateRes.Size = new System.Drawing.Size(119, 45);
            this.btnCreateRes.TabIndex = 15;
            this.btnCreateRes.Text = "Create reservation";
            this.btnCreateRes.UseVisualStyleBackColor = true;
            this.btnCreateRes.Click += new System.EventHandler(this.btnCreateRes_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Select event";
            // 
            // cbEvent
            // 
            this.cbEvent.FormattingEnabled = true;
            this.cbEvent.Location = new System.Drawing.Point(150, 253);
            this.cbEvent.Name = "cbEvent";
            this.cbEvent.Size = new System.Drawing.Size(135, 21);
            this.cbEvent.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 286);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Amount of people";
            // 
            // nmPeople
            // 
            this.nmPeople.Location = new System.Drawing.Point(199, 290);
            this.nmPeople.Name = "nmPeople";
            this.nmPeople.Size = new System.Drawing.Size(86, 20);
            this.nmPeople.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(339, 321);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(470, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Location ID\'s correspond to numbers of the locations on the map.";
            // 
            // pbLocations
            // 
            this.pbLocations.Image = global::ReservationApp.Properties.Resources.Locations;
            this.pbLocations.InitialImage = global::ReservationApp.Properties.Resources.Locations;
            this.pbLocations.Location = new System.Drawing.Point(328, 360);
            this.pbLocations.Name = "pbLocations";
            this.pbLocations.Size = new System.Drawing.Size(494, 339);
            this.pbLocations.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLocations.TabIndex = 21;
            this.pbLocations.TabStop = false;
            this.pbLocations.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pbLocations_MouseDoubleClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(339, 341);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(325, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "Double click image to open it in your browser.";
            // 
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 711);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pbLocations);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.nmPeople);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbEvent);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCreateRes);
            this.Controls.Add(this.nmLocId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbLocations);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.tbCity);
            this.Controls.Add(this.tbPostal);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbName);
            this.Name = "ReservationForm";
            this.Text = "New Reservation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmLocId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPeople)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLocations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbPostal;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.ListBox lbLocations;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nmLocId;
        private System.Windows.Forms.Button btnCreateRes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbEvent;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nmPeople;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pbLocations;
        private System.Windows.Forms.Label label10;
    }
}

