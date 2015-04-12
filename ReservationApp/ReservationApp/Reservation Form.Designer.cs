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
            this.cbPay = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nmLocId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPeople)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLocations)).BeginInit();
            this.SuspendLayout();
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
            this.label6.Location = new System.Drawing.Point(12, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Location ID you want to reserve:";
            // 
            // nmLocId
            // 
            this.nmLocId.Location = new System.Drawing.Point(196, 26);
            this.nmLocId.Name = "nmLocId";
            this.nmLocId.Size = new System.Drawing.Size(86, 20);
            this.nmLocId.TabIndex = 14;
            this.nmLocId.ValueChanged += new System.EventHandler(this.nmLocId_ValueChanged);
            // 
            // btnCreateRes
            // 
            this.btnCreateRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateRes.Location = new System.Drawing.Point(82, 148);
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
            this.label7.Location = new System.Drawing.Point(12, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Select event";
            // 
            // cbEvent
            // 
            this.cbEvent.FormattingEnabled = true;
            this.cbEvent.Location = new System.Drawing.Point(147, 62);
            this.cbEvent.Name = "cbEvent";
            this.cbEvent.Size = new System.Drawing.Size(135, 21);
            this.cbEvent.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Amount of people";
            // 
            // nmPeople
            // 
            this.nmPeople.Location = new System.Drawing.Point(196, 99);
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
            // cbPay
            // 
            this.cbPay.AutoSize = true;
            this.cbPay.Location = new System.Drawing.Point(201, 125);
            this.cbPay.Name = "cbPay";
            this.cbPay.Size = new System.Drawing.Size(67, 17);
            this.cbPay.TabIndex = 23;
            this.cbPay.Text = "Pay now";
            this.cbPay.UseVisualStyleBackColor = true;
            // 
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 711);
            this.Controls.Add(this.cbPay);
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
        private System.Windows.Forms.CheckBox cbPay;
    }
}

