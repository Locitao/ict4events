namespace AccessControl
{
    partial class AccessControlForm
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
            this.tbRFIDSearsh = new System.Windows.Forms.TextBox();
            this.lbRFIDCodes = new System.Windows.Forms.ListBox();
            this.BttnPayed = new System.Windows.Forms.Button();
            this.bttnPresence = new System.Windows.Forms.Button();
            this.bttnCancel = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblSearsh = new System.Windows.Forms.Label();
            this.bttnSearsh = new System.Windows.Forms.Button();
            this.bttnRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbRFIDSearsh
            // 
            this.tbRFIDSearsh.Location = new System.Drawing.Point(12, 34);
            this.tbRFIDSearsh.Name = "tbRFIDSearsh";
            this.tbRFIDSearsh.Size = new System.Drawing.Size(423, 20);
            this.tbRFIDSearsh.TabIndex = 0;
            // 
            // lbRFIDCodes
            // 
            this.lbRFIDCodes.FormattingEnabled = true;
            this.lbRFIDCodes.Location = new System.Drawing.Point(13, 61);
            this.lbRFIDCodes.Name = "lbRFIDCodes";
            this.lbRFIDCodes.Size = new System.Drawing.Size(509, 173);
            this.lbRFIDCodes.TabIndex = 1;
            // 
            // BttnPayed
            // 
            this.BttnPayed.Location = new System.Drawing.Point(13, 240);
            this.BttnPayed.Name = "BttnPayed";
            this.BttnPayed.Size = new System.Drawing.Size(119, 23);
            this.BttnPayed.TabIndex = 2;
            this.BttnPayed.Text = "Toggle payed";
            this.BttnPayed.UseVisualStyleBackColor = true;
            this.BttnPayed.Click += new System.EventHandler(this.BttnPayed_Click);
            // 
            // bttnPresence
            // 
            this.bttnPresence.Location = new System.Drawing.Point(278, 240);
            this.bttnPresence.Name = "bttnPresence";
            this.bttnPresence.Size = new System.Drawing.Size(119, 23);
            this.bttnPresence.TabIndex = 3;
            this.bttnPresence.Text = "Toggle presence";
            this.bttnPresence.UseVisualStyleBackColor = true;
            // 
            // bttnCancel
            // 
            this.bttnCancel.Location = new System.Drawing.Point(138, 240);
            this.bttnCancel.Name = "bttnCancel";
            this.bttnCancel.Size = new System.Drawing.Size(119, 23);
            this.bttnCancel.TabIndex = 4;
            this.bttnCancel.Text = "Cancel reserve";
            this.bttnCancel.UseVisualStyleBackColor = true;
            this.bttnCancel.Click += new System.EventHandler(this.bttnCancel_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(54, 280);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(12, 280);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(36, 13);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "Date: ";
            // 
            // lblSearsh
            // 
            this.lblSearsh.AutoSize = true;
            this.lblSearsh.Location = new System.Drawing.Point(10, 9);
            this.lblSearsh.Name = "lblSearsh";
            this.lblSearsh.Size = new System.Drawing.Size(110, 13);
            this.lblSearsh.TabIndex = 7;
            this.lblSearsh.Text = "Searsh on RFID code";
            // 
            // bttnSearsh
            // 
            this.bttnSearsh.Location = new System.Drawing.Point(441, 32);
            this.bttnSearsh.Name = "bttnSearsh";
            this.bttnSearsh.Size = new System.Drawing.Size(81, 23);
            this.bttnSearsh.TabIndex = 8;
            this.bttnSearsh.Text = "Searsh";
            this.bttnSearsh.UseVisualStyleBackColor = true;
            this.bttnSearsh.Click += new System.EventHandler(this.bttnSearsh_Click);
            // 
            // bttnRefresh
            // 
            this.bttnRefresh.Location = new System.Drawing.Point(403, 240);
            this.bttnRefresh.Name = "bttnRefresh";
            this.bttnRefresh.Size = new System.Drawing.Size(119, 23);
            this.bttnRefresh.TabIndex = 9;
            this.bttnRefresh.Text = "Refresh";
            this.bttnRefresh.UseVisualStyleBackColor = true;
            this.bttnRefresh.Click += new System.EventHandler(this.bttnRefresh_Click);
            // 
            // AccessControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 330);
            this.Controls.Add(this.bttnRefresh);
            this.Controls.Add(this.bttnSearsh);
            this.Controls.Add(this.lblSearsh);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.bttnCancel);
            this.Controls.Add(this.bttnPresence);
            this.Controls.Add(this.BttnPayed);
            this.Controls.Add(this.lbRFIDCodes);
            this.Controls.Add(this.tbRFIDSearsh);
            this.Name = "AccessControlForm";
            this.Text = "Access Control";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbRFIDSearsh;
        private System.Windows.Forms.ListBox lbRFIDCodes;
        private System.Windows.Forms.Button BttnPayed;
        private System.Windows.Forms.Button bttnPresence;
        private System.Windows.Forms.Button bttnCancel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblSearsh;
        private System.Windows.Forms.Button bttnSearsh;
        private System.Windows.Forms.Button bttnRefresh;
    }
}

