namespace MediaSharingGuest
{
    partial class ViewReports
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
            this.lbReports = new System.Windows.Forms.ListBox();
            this.lbHotReports = new System.Windows.Forms.ListBox();
            this.lblHotReports = new System.Windows.Forms.Label();
            this.lblReports = new System.Windows.Forms.Label();
            this.nudThreshold = new System.Windows.Forms.NumericUpDown();
            this.lblThreshold = new System.Windows.Forms.Label();
            this.chbAutoClean = new System.Windows.Forms.CheckBox();
            this.timerDeleteReports = new System.Windows.Forms.Timer(this.components);
            this.timerUpdate = new System.Windows.Forms.Timer(this.components);
            this.btnLogOut = new System.Windows.Forms.Button();
            this.tbRfid = new System.Windows.Forms.TextBox();
            this.lblRfidCode = new System.Windows.Forms.Label();
            this.btnUnban = new System.Windows.Forms.Button();
            this.btnBan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudThreshold)).BeginInit();
            this.SuspendLayout();
            // 
            // lbReports
            // 
            this.lbReports.FormattingEnabled = true;
            this.lbReports.ItemHeight = 16;
            this.lbReports.Location = new System.Drawing.Point(8, 28);
            this.lbReports.Margin = new System.Windows.Forms.Padding(4);
            this.lbReports.Name = "lbReports";
            this.lbReports.Size = new System.Drawing.Size(232, 260);
            this.lbReports.TabIndex = 0;
            this.lbReports.SelectedIndexChanged += new System.EventHandler(this.lbReports_SelectedIndexChanged);
            // 
            // lbHotReports
            // 
            this.lbHotReports.FormattingEnabled = true;
            this.lbHotReports.ItemHeight = 16;
            this.lbHotReports.Location = new System.Drawing.Point(248, 28);
            this.lbHotReports.Margin = new System.Windows.Forms.Padding(4);
            this.lbHotReports.Name = "lbHotReports";
            this.lbHotReports.Size = new System.Drawing.Size(232, 260);
            this.lbHotReports.TabIndex = 1;
            this.lbHotReports.SelectedIndexChanged += new System.EventHandler(this.lbHotReports_SelectedIndexChanged);
            // 
            // lblHotReports
            // 
            this.lblHotReports.AutoSize = true;
            this.lblHotReports.Location = new System.Drawing.Point(245, 7);
            this.lblHotReports.Name = "lblHotReports";
            this.lblHotReports.Size = new System.Drawing.Size(84, 17);
            this.lblHotReports.TabIndex = 2;
            this.lblHotReports.Text = "Hot Reports";
            // 
            // lblReports
            // 
            this.lblReports.AutoSize = true;
            this.lblReports.Location = new System.Drawing.Point(5, 7);
            this.lblReports.Name = "lblReports";
            this.lblReports.Size = new System.Drawing.Size(58, 17);
            this.lblReports.TabIndex = 3;
            this.lblReports.Text = "Reports";
            // 
            // nudThreshold
            // 
            this.nudThreshold.Location = new System.Drawing.Point(361, 295);
            this.nudThreshold.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudThreshold.Name = "nudThreshold";
            this.nudThreshold.Size = new System.Drawing.Size(120, 22);
            this.nudThreshold.TabIndex = 4;
            this.nudThreshold.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudThreshold.ValueChanged += new System.EventHandler(this.nudThreshold_ValueChanged);
            // 
            // lblThreshold
            // 
            this.lblThreshold.AutoSize = true;
            this.lblThreshold.Location = new System.Drawing.Point(279, 300);
            this.lblThreshold.Name = "lblThreshold";
            this.lblThreshold.Size = new System.Drawing.Size(76, 17);
            this.lblThreshold.TabIndex = 5;
            this.lblThreshold.Text = "Threshold:";
            // 
            // chbAutoClean
            // 
            this.chbAutoClean.AutoSize = true;
            this.chbAutoClean.Location = new System.Drawing.Point(282, 320);
            this.chbAutoClean.Name = "chbAutoClean";
            this.chbAutoClean.Size = new System.Drawing.Size(95, 21);
            this.chbAutoClean.TabIndex = 7;
            this.chbAutoClean.Text = "AutoClean";
            this.chbAutoClean.UseVisualStyleBackColor = true;
            this.chbAutoClean.CheckedChanged += new System.EventHandler(this.chbAutoClean_CheckedChanged);
            // 
            // timerDeleteReports
            // 
            this.timerDeleteReports.Interval = 10000;
            this.timerDeleteReports.Tick += new System.EventHandler(this.timerDeleteReports_Tick);
            // 
            // timerUpdate
            // 
            this.timerUpdate.Interval = 10000;
            this.timerUpdate.Tick += new System.EventHandler(this.timerUpdate_Tick);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(751, 389);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(86, 34);
            this.btnLogOut.TabIndex = 8;
            this.btnLogOut.Text = "Logout";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // tbRfid
            // 
            this.tbRfid.Location = new System.Drawing.Point(645, 28);
            this.tbRfid.Name = "tbRfid";
            this.tbRfid.Size = new System.Drawing.Size(167, 22);
            this.tbRfid.TabIndex = 9;
            // 
            // lblRfidCode
            // 
            this.lblRfidCode.AutoSize = true;
            this.lblRfidCode.Location = new System.Drawing.Point(553, 31);
            this.lblRfidCode.Name = "lblRfidCode";
            this.lblRfidCode.Size = new System.Drawing.Size(86, 17);
            this.lblRfidCode.TabIndex = 10;
            this.lblRfidCode.Text = "RFID CODE:";
            // 
            // btnUnban
            // 
            this.btnUnban.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnUnban.Location = new System.Drawing.Point(645, 85);
            this.btnUnban.Name = "btnUnban";
            this.btnUnban.Size = new System.Drawing.Size(167, 23);
            this.btnUnban.TabIndex = 11;
            this.btnUnban.Text = "UNBAN USER";
            this.btnUnban.UseVisualStyleBackColor = true;
            this.btnUnban.Click += new System.EventHandler(this.btnUnban_Click);
            // 
            // btnBan
            // 
            this.btnBan.ForeColor = System.Drawing.Color.Maroon;
            this.btnBan.Location = new System.Drawing.Point(645, 56);
            this.btnBan.Name = "btnBan";
            this.btnBan.Size = new System.Drawing.Size(167, 23);
            this.btnBan.TabIndex = 12;
            this.btnBan.Text = "BAN USER";
            this.btnBan.UseVisualStyleBackColor = true;
            this.btnBan.Click += new System.EventHandler(this.btnBan_Click);
            // 
            // ViewReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 435);
            this.Controls.Add(this.btnBan);
            this.Controls.Add(this.btnUnban);
            this.Controls.Add(this.lblRfidCode);
            this.Controls.Add(this.tbRfid);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.chbAutoClean);
            this.Controls.Add(this.lblThreshold);
            this.Controls.Add(this.nudThreshold);
            this.Controls.Add(this.lblReports);
            this.Controls.Add(this.lblHotReports);
            this.Controls.Add(this.lbHotReports);
            this.Controls.Add(this.lbReports);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ViewReports";
            this.Text = "Reports";
            ((System.ComponentModel.ISupportInitialize)(this.nudThreshold)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbReports;
        private System.Windows.Forms.ListBox lbHotReports;
        private System.Windows.Forms.Label lblHotReports;
        private System.Windows.Forms.Label lblReports;
        private System.Windows.Forms.NumericUpDown nudThreshold;
        private System.Windows.Forms.Label lblThreshold;
        private System.Windows.Forms.CheckBox chbAutoClean;
        private System.Windows.Forms.Timer timerDeleteReports;
        private System.Windows.Forms.Timer timerUpdate;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.TextBox tbRfid;
        private System.Windows.Forms.Label lblRfidCode;
        private System.Windows.Forms.Button btnUnban;
        private System.Windows.Forms.Button btnBan;
    }
}