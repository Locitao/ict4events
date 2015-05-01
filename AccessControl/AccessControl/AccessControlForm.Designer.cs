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
            this.components = new System.ComponentModel.Container();
            this.tbRFIDSearsh = new System.Windows.Forms.TextBox();
            this.lbRFIDCodes = new System.Windows.Forms.ListBox();
            this.BttnPayed = new System.Windows.Forms.Button();
            this.bttnCancel = new System.Windows.Forms.Button();
            this.lblSearsh = new System.Windows.Forms.Label();
            this.bttnRefresh = new System.Windows.Forms.Button();
            this.tmrRFIDCheck = new System.Windows.Forms.Timer(this.components);
            this.lblRFID = new System.Windows.Forms.Label();
            this.bttnPpleOnTerrain = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbRFIDSearsh
            // 
            this.tbRFIDSearsh.Location = new System.Drawing.Point(12, 34);
            this.tbRFIDSearsh.MaxLength = 10;
            this.tbRFIDSearsh.Name = "tbRFIDSearsh";
            this.tbRFIDSearsh.Size = new System.Drawing.Size(510, 20);
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
            // bttnCancel
            // 
            this.bttnCancel.Location = new System.Drawing.Point(138, 240);
            this.bttnCancel.Name = "bttnCancel";
            this.bttnCancel.Size = new System.Drawing.Size(119, 23);
            this.bttnCancel.TabIndex = 4;
            this.bttnCancel.Text = "Cancel reservation";
            this.bttnCancel.UseVisualStyleBackColor = true;
            this.bttnCancel.Click += new System.EventHandler(this.bttnCancel_Click);
            // 
            // lblSearsh
            // 
            this.lblSearsh.AutoSize = true;
            this.lblSearsh.Location = new System.Drawing.Point(10, 9);
            this.lblSearsh.Name = "lblSearsh";
            this.lblSearsh.Size = new System.Drawing.Size(111, 13);
            this.lblSearsh.TabIndex = 7;
            this.lblSearsh.Text = "Search on RFID code";
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
            // tmrRFIDCheck
            // 
            this.tmrRFIDCheck.Tick += new System.EventHandler(this.tmrRFIDCheck_Tick);
            // 
            // lblRFID
            // 
            this.lblRFID.AutoSize = true;
            this.lblRFID.Location = new System.Drawing.Point(432, 9);
            this.lblRFID.Name = "lblRFID";
            this.lblRFID.Size = new System.Drawing.Size(0, 13);
            this.lblRFID.TabIndex = 11;
            // 
            // bttnPpleOnTerrain
            // 
            this.bttnPpleOnTerrain.Location = new System.Drawing.Point(278, 240);
            this.bttnPpleOnTerrain.Name = "bttnPpleOnTerrain";
            this.bttnPpleOnTerrain.Size = new System.Drawing.Size(119, 23);
            this.bttnPpleOnTerrain.TabIndex = 12;
            this.bttnPpleOnTerrain.Text = "People on terrain list";
            this.bttnPpleOnTerrain.UseVisualStyleBackColor = true;
            this.bttnPpleOnTerrain.Click += new System.EventHandler(this.bttnPpleOnTerrain_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.Red;
            this.lblResult.Location = new System.Drawing.Point(139, 281);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 29);
            this.lblResult.TabIndex = 13;
            // 
            // AccessControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(534, 330);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.bttnPpleOnTerrain);
            this.Controls.Add(this.lblRFID);
            this.Controls.Add(this.bttnRefresh);
            this.Controls.Add(this.lblSearsh);
            this.Controls.Add(this.bttnCancel);
            this.Controls.Add(this.BttnPayed);
            this.Controls.Add(this.lbRFIDCodes);
            this.Controls.Add(this.tbRFIDSearsh);
            this.Name = "AccessControlForm";
            this.ShowIcon = false;
            this.Text = "Access Control";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbRFIDSearsh;
        private System.Windows.Forms.ListBox lbRFIDCodes;
        private System.Windows.Forms.Button BttnPayed;
        private System.Windows.Forms.Button bttnCancel;
        private System.Windows.Forms.Label lblSearsh;
        private System.Windows.Forms.Button bttnRefresh;
        private System.Windows.Forms.Timer tmrRFIDCheck;
        private System.Windows.Forms.Label lblRFID;
        private System.Windows.Forms.Button bttnPpleOnTerrain;
        private System.Windows.Forms.Label lblResult;
    }
}

