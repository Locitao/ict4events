namespace MED_TEK
{
    partial class Beheer_Overview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Beheer_Overview));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAfmelden = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblAfmelden);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnInsert);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(660, 237);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblAfmelden
            // 
            this.lblAfmelden.ActiveLinkColor = System.Drawing.Color.White;
            this.lblAfmelden.AutoSize = true;
            this.lblAfmelden.Location = new System.Drawing.Point(552, 221);
            this.lblAfmelden.Name = "lblAfmelden";
            this.lblAfmelden.Size = new System.Drawing.Size(51, 13);
            this.lblAfmelden.TabIndex = 5;
            this.lblAfmelden.TabStop = true;
            this.lblAfmelden.Text = "Afmelden";
            this.lblAfmelden.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblAfmelden_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::MED_TEK.Properties.Resources.Logo_Smart_Patient_Small;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(555, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 100);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(40, 163);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(200, 20);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Gegevens verwijderen";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(40, 136);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(200, 20);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Gegevens Wijzingen";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kies een van de volgende opties om het volgende scherm te openen.";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(40, 110);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(200, 20);
            this.btnInsert.TabIndex = 0;
            this.btnInsert.Text = "Gegevens Toevoegen";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // Beheer_Overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(684, 261);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Beheer_Overview";
            this.Text = "Beheer Keuze Overzicht";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Beheer_Overview_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Beheer_Overview_FormClosed);
            this.Load += new System.EventHandler(this.Beheer_Overview_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.LinkLabel lblAfmelden;
    }
}