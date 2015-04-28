namespace Management_System
{
    partial class ControlGuestAccountsForm
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
            this.lbUserAccounts = new System.Windows.Forms.ListBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblRFIDCode = new System.Windows.Forms.Label();
            this.lblAdress = new System.Windows.Forms.Label();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.btnChangeInfo = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbRFIDCode = new System.Windows.Forms.TextBox();
            this.tbAdress = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbUserAccounts
            // 
            this.lbUserAccounts.FormattingEnabled = true;
            this.lbUserAccounts.Location = new System.Drawing.Point(13, 13);
            this.lbUserAccounts.Name = "lbUserAccounts";
            this.lbUserAccounts.Size = new System.Drawing.Size(330, 160);
            this.lbUserAccounts.TabIndex = 0;
            this.lbUserAccounts.SelectedIndexChanged += new System.EventHandler(this.lbUserAccounts_SelectedIndexChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(349, 16);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // lblRFIDCode
            // 
            this.lblRFIDCode.AutoSize = true;
            this.lblRFIDCode.Location = new System.Drawing.Point(349, 42);
            this.lblRFIDCode.Name = "lblRFIDCode";
            this.lblRFIDCode.Size = new System.Drawing.Size(63, 13);
            this.lblRFIDCode.TabIndex = 2;
            this.lblRFIDCode.Text = "RFID Code:";
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Location = new System.Drawing.Point(350, 68);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(42, 13);
            this.lblAdress.TabIndex = 3;
            this.lblAdress.Text = "Adress:";
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Location = new System.Drawing.Point(353, 124);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(169, 23);
            this.btnDeleteAccount.TabIndex = 7;
            this.btnDeleteAccount.Text = "Delete Account";
            this.btnDeleteAccount.UseVisualStyleBackColor = true;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            // 
            // btnChangeInfo
            // 
            this.btnChangeInfo.Location = new System.Drawing.Point(352, 95);
            this.btnChangeInfo.Name = "btnChangeInfo";
            this.btnChangeInfo.Size = new System.Drawing.Size(168, 23);
            this.btnChangeInfo.TabIndex = 8;
            this.btnChangeInfo.Text = "Change info";
            this.btnChangeInfo.UseVisualStyleBackColor = true;
            this.btnChangeInfo.Click += new System.EventHandler(this.btnChangeInfo_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(352, 153);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(169, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(421, 13);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(100, 20);
            this.tbUserName.TabIndex = 10;
            // 
            // tbRFIDCode
            // 
            this.tbRFIDCode.Location = new System.Drawing.Point(421, 39);
            this.tbRFIDCode.Name = "tbRFIDCode";
            this.tbRFIDCode.Size = new System.Drawing.Size(100, 20);
            this.tbRFIDCode.TabIndex = 11;
            // 
            // tbAdress
            // 
            this.tbAdress.Location = new System.Drawing.Point(421, 65);
            this.tbAdress.Name = "tbAdress";
            this.tbAdress.Size = new System.Drawing.Size(100, 20);
            this.tbAdress.TabIndex = 12;
            // 
            // ControlGuestAccountsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 188);
            this.Controls.Add(this.tbAdress);
            this.Controls.Add(this.tbRFIDCode);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnChangeInfo);
            this.Controls.Add(this.btnDeleteAccount);
            this.Controls.Add(this.lblAdress);
            this.Controls.Add(this.lblRFIDCode);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lbUserAccounts);
            this.Name = "ControlGuestAccountsForm";
            this.Text = "Manage Guests";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbUserAccounts;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblRFIDCode;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.Button btnChangeInfo;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbRFIDCode;
        private System.Windows.Forms.TextBox tbAdress;
    }
}