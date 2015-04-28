namespace Management_System
{
    partial class ControlEmployeeAccountsForm
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
            this.lbEmployeeAccounts = new System.Windows.Forms.ListBox();
            this.lblLoginName = new System.Windows.Forms.Label();
            this.lblAdress = new System.Windows.Forms.Label();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.btnChangeInfo = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.tbLoginName = new System.Windows.Forms.TextBox();
            this.tbEmployeeName = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.lbPhoneNumber = new System.Windows.Forms.Label();
            this.cbRights = new System.Windows.Forms.ComboBox();
            this.lblRights = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbEmployeeAccounts
            // 
            this.lbEmployeeAccounts.FormattingEnabled = true;
            this.lbEmployeeAccounts.Location = new System.Drawing.Point(13, 13);
            this.lbEmployeeAccounts.Name = "lbEmployeeAccounts";
            this.lbEmployeeAccounts.Size = new System.Drawing.Size(330, 212);
            this.lbEmployeeAccounts.TabIndex = 0;
            this.lbEmployeeAccounts.SelectedIndexChanged += new System.EventHandler(this.lbEmployeeAccounts_SelectedIndexChanged);
            // 
            // lblLoginName
            // 
            this.lblLoginName.AutoSize = true;
            this.lblLoginName.Location = new System.Drawing.Point(349, 16);
            this.lblLoginName.Name = "lblLoginName";
            this.lblLoginName.Size = new System.Drawing.Size(68, 13);
            this.lblLoginName.TabIndex = 1;
            this.lblLoginName.Text = "Log in name:";
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
            this.btnDeleteAccount.Location = new System.Drawing.Point(353, 173);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(177, 23);
            this.btnDeleteAccount.TabIndex = 6;
            this.btnDeleteAccount.Text = "Delete Account";
            this.btnDeleteAccount.UseVisualStyleBackColor = true;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            // 
            // btnChangeInfo
            // 
            this.btnChangeInfo.Location = new System.Drawing.Point(353, 144);
            this.btnChangeInfo.Name = "btnChangeInfo";
            this.btnChangeInfo.Size = new System.Drawing.Size(176, 23);
            this.btnChangeInfo.TabIndex = 5;
            this.btnChangeInfo.Text = "Change info";
            this.btnChangeInfo.UseVisualStyleBackColor = true;
            this.btnChangeInfo.Click += new System.EventHandler(this.btnChangeInfo_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(352, 202);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(177, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tbLoginName
            // 
            this.tbLoginName.Location = new System.Drawing.Point(429, 13);
            this.tbLoginName.Name = "tbLoginName";
            this.tbLoginName.Size = new System.Drawing.Size(100, 20);
            this.tbLoginName.TabIndex = 0;
            this.tbLoginName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress_LettersAndDigits);
            // 
            // tbEmployeeName
            // 
            this.tbEmployeeName.Location = new System.Drawing.Point(429, 42);
            this.tbEmployeeName.Name = "tbEmployeeName";
            this.tbEmployeeName.Size = new System.Drawing.Size(100, 20);
            this.tbEmployeeName.TabIndex = 1;
            this.tbEmployeeName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress_LettersDigitsAndSpaces);
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(429, 68);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(100, 20);
            this.tbAddress.TabIndex = 2;
            this.tbAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress_LettersDigitsAndSpaces);
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Location = new System.Drawing.Point(429, 91);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.tbPhoneNumber.TabIndex = 3;
            this.tbPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress_Digits);
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Location = new System.Drawing.Point(350, 42);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(38, 13);
            this.lblEmployeeName.TabIndex = 15;
            this.lblEmployeeName.Text = "Name:";
            // 
            // lbPhoneNumber
            // 
            this.lbPhoneNumber.AutoSize = true;
            this.lbPhoneNumber.Location = new System.Drawing.Point(350, 94);
            this.lbPhoneNumber.Name = "lbPhoneNumber";
            this.lbPhoneNumber.Size = new System.Drawing.Size(79, 13);
            this.lbPhoneNumber.TabIndex = 16;
            this.lbPhoneNumber.Text = "Phone number:";
            // 
            // cbRights
            // 
            this.cbRights.FormattingEnabled = true;
            this.cbRights.Location = new System.Drawing.Point(429, 117);
            this.cbRights.Name = "cbRights";
            this.cbRights.Size = new System.Drawing.Size(100, 21);
            this.cbRights.TabIndex = 4;
            // 
            // lblRights
            // 
            this.lblRights.AutoSize = true;
            this.lblRights.Location = new System.Drawing.Point(349, 120);
            this.lblRights.Name = "lblRights";
            this.lblRights.Size = new System.Drawing.Size(40, 13);
            this.lblRights.TabIndex = 18;
            this.lblRights.Text = "Rights:";
            // 
            // ControlEmployeeAccountsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 242);
            this.Controls.Add(this.lblRights);
            this.Controls.Add(this.cbRights);
            this.Controls.Add(this.lbPhoneNumber);
            this.Controls.Add(this.lblEmployeeName);
            this.Controls.Add(this.tbPhoneNumber);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.tbEmployeeName);
            this.Controls.Add(this.tbLoginName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnChangeInfo);
            this.Controls.Add(this.btnDeleteAccount);
            this.Controls.Add(this.lblAdress);
            this.Controls.Add(this.lblLoginName);
            this.Controls.Add(this.lbEmployeeAccounts);
            this.Name = "ControlEmployeeAccountsForm";
            this.Text = "Manage Employees";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbEmployeeAccounts;
        private System.Windows.Forms.Label lblLoginName;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.Button btnChangeInfo;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox tbLoginName;
        private System.Windows.Forms.TextBox tbEmployeeName;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbPhoneNumber;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Label lbPhoneNumber;
        private System.Windows.Forms.ComboBox cbRights;
        private System.Windows.Forms.Label lblRights;
    }
}