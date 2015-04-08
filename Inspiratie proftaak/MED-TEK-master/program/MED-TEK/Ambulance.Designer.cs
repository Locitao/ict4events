namespace MED_TEK
{
    partial class Ambulance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ambulance));
            this.panel1 = new System.Windows.Forms.Panel();
            this.llPatientAfmelden = new System.Windows.Forms.LinkLabel();
            this.llAfmelden = new System.Windows.Forms.LinkLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbMedicatie = new System.Windows.Forms.ListBox();
            this.lbZiektes = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbPasfoto = new System.Windows.Forms.PictureBox();
            this.tbBloedgroep = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDoB = new System.Windows.Forms.DateTimePicker();
            this.tbAchternaam = new System.Windows.Forms.TextBox();
            this.tbVoornamen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPasfoto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.llPatientAfmelden);
            this.panel1.Controls.Add(this.llAfmelden);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(9, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(964, 741);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // llPatientAfmelden
            // 
            this.llPatientAfmelden.AutoSize = true;
            this.llPatientAfmelden.Location = new System.Drawing.Point(34, 468);
            this.llPatientAfmelden.Name = "llPatientAfmelden";
            this.llPatientAfmelden.Size = new System.Drawing.Size(86, 13);
            this.llPatientAfmelden.TabIndex = 4;
            this.llPatientAfmelden.TabStop = true;
            this.llPatientAfmelden.Text = "Patient afmelden";
            this.llPatientAfmelden.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llPatientAfmelden_LinkClicked);
            // 
            // llAfmelden
            // 
            this.llAfmelden.AutoSize = true;
            this.llAfmelden.Location = new System.Drawing.Point(146, 468);
            this.llAfmelden.Name = "llAfmelden";
            this.llAfmelden.Size = new System.Drawing.Size(119, 13);
            this.llAfmelden.TabIndex = 3;
            this.llAfmelden.TabStop = true;
            this.llAfmelden.Text = "Afmelden bij programma";
            this.llAfmelden.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llAfmelden_LinkClicked);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbMedicatie);
            this.groupBox2.Controls.Add(this.lbZiektes);
            this.groupBox2.Location = new System.Drawing.Point(432, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(369, 416);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ziekte Patient";
            // 
            // lbMedicatie
            // 
            this.lbMedicatie.FormattingEnabled = true;
            this.lbMedicatie.Location = new System.Drawing.Point(7, 130);
            this.lbMedicatie.Name = "lbMedicatie";
            this.lbMedicatie.Size = new System.Drawing.Size(356, 134);
            this.lbMedicatie.TabIndex = 1;
            // 
            // lbZiektes
            // 
            this.lbZiektes.FormattingEnabled = true;
            this.lbZiektes.Location = new System.Drawing.Point(6, 25);
            this.lbZiektes.Name = "lbZiektes";
            this.lbZiektes.Size = new System.Drawing.Size(357, 95);
            this.lbZiektes.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pbPasfoto);
            this.groupBox1.Controls.Add(this.tbBloedgroep);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpDoB);
            this.groupBox1.Controls.Add(this.tbAchternaam);
            this.groupBox1.Controls.Add(this.tbVoornamen);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(22, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 416);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patient Gegevens";
            // 
            // pbPasfoto
            // 
            this.pbPasfoto.Location = new System.Drawing.Point(9, 148);
            this.pbPasfoto.Name = "pbPasfoto";
            this.pbPasfoto.Size = new System.Drawing.Size(321, 262);
            this.pbPasfoto.TabIndex = 8;
            this.pbPasfoto.TabStop = false;
            // 
            // tbBloedgroep
            // 
            this.tbBloedgroep.Location = new System.Drawing.Point(112, 112);
            this.tbBloedgroep.Name = "tbBloedgroep";
            this.tbBloedgroep.Size = new System.Drawing.Size(220, 20);
            this.tbBloedgroep.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Bloedgroep";
            // 
            // dtpDoB
            // 
            this.dtpDoB.Location = new System.Drawing.Point(112, 77);
            this.dtpDoB.Name = "dtpDoB";
            this.dtpDoB.Size = new System.Drawing.Size(220, 20);
            this.dtpDoB.TabIndex = 5;
            // 
            // tbAchternaam
            // 
            this.tbAchternaam.Location = new System.Drawing.Point(112, 51);
            this.tbAchternaam.Name = "tbAchternaam";
            this.tbAchternaam.Size = new System.Drawing.Size(220, 20);
            this.tbAchternaam.TabIndex = 4;
            // 
            // tbVoornamen
            // 
            this.tbVoornamen.Location = new System.Drawing.Point(112, 25);
            this.tbVoornamen.Name = "tbVoornamen";
            this.tbVoornamen.Size = new System.Drawing.Size(220, 20);
            this.tbVoornamen.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Geboortedatum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Achternaam";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Voornamen";
            // 
            // Ambulance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(984, 762);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Ambulance";
            this.Text = "Ambulance - Smart Patient";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Ambulance_FormClosed);
            this.Load += new System.EventHandler(this.Ambulance_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPasfoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pbPasfoto;
        private System.Windows.Forms.TextBox tbBloedgroep;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDoB;
        private System.Windows.Forms.TextBox tbAchternaam;
        private System.Windows.Forms.TextBox tbVoornamen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbMedicatie;
        private System.Windows.Forms.ListBox lbZiektes;
        private System.Windows.Forms.LinkLabel llAfmelden;
        private System.Windows.Forms.LinkLabel llPatientAfmelden;
    }
}