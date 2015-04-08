namespace MED_TEK
{
    partial class Beheer_Delete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Beheer_Delete));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbOverzichtMedicijnen = new System.Windows.Forms.ListBox();
            this.btnVerwijderMedicijn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSelectMedicijn = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbOverzichtAfspraken = new System.Windows.Forms.ListBox();
            this.btnVerwijderAfspraak = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbSelectAfspraak = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnVerwijderZiekte = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbSelectZiekte = new System.Windows.Forms.ComboBox();
            this.lbOverzichtZiekte = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnVerwijderZiektePatient = new System.Windows.Forms.Button();
            this.cbSelecteerZiektePatient = new System.Windows.Forms.ComboBox();
            this.btnZoekZiektePatient = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPascode = new System.Windows.Forms.TextBox();
            this.lbOverzichtZiektePatient = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(557, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "SMART PATIENT - DELETE DATA";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbOverzichtMedicijnen);
            this.groupBox1.Controls.Add(this.btnVerwijderMedicijn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbSelectMedicijn);
            this.groupBox1.Location = new System.Drawing.Point(19, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 428);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Medicijn Verwijderen";
            // 
            // lbOverzichtMedicijnen
            // 
            this.lbOverzichtMedicijnen.FormattingEnabled = true;
            this.lbOverzichtMedicijnen.Location = new System.Drawing.Point(6, 146);
            this.lbOverzichtMedicijnen.Name = "lbOverzichtMedicijnen";
            this.lbOverzichtMedicijnen.Size = new System.Drawing.Size(366, 277);
            this.lbOverzichtMedicijnen.TabIndex = 9;
            // 
            // btnVerwijderMedicijn
            // 
            this.btnVerwijderMedicijn.Location = new System.Drawing.Point(152, 57);
            this.btnVerwijderMedicijn.Name = "btnVerwijderMedicijn";
            this.btnVerwijderMedicijn.Size = new System.Drawing.Size(220, 23);
            this.btnVerwijderMedicijn.TabIndex = 8;
            this.btnVerwijderMedicijn.Text = "Verwijder Medicijn";
            this.btnVerwijderMedicijn.UseVisualStyleBackColor = true;
            this.btnVerwijderMedicijn.Click += new System.EventHandler(this.btnVerwijderMedicijn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Selecteer medicijn";
            // 
            // cbSelectMedicijn
            // 
            this.cbSelectMedicijn.FormattingEnabled = true;
            this.cbSelectMedicijn.Location = new System.Drawing.Point(152, 30);
            this.cbSelectMedicijn.Name = "cbSelectMedicijn";
            this.cbSelectMedicijn.Size = new System.Drawing.Size(220, 21);
            this.cbSelectMedicijn.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbOverzichtAfspraken);
            this.groupBox2.Controls.Add(this.btnVerwijderAfspraak);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cbSelectAfspraak);
            this.groupBox2.Location = new System.Drawing.Point(419, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(378, 428);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Afspraak verwijderen";
            // 
            // lbOverzichtAfspraken
            // 
            this.lbOverzichtAfspraken.FormattingEnabled = true;
            this.lbOverzichtAfspraken.Location = new System.Drawing.Point(6, 146);
            this.lbOverzichtAfspraken.Name = "lbOverzichtAfspraken";
            this.lbOverzichtAfspraken.Size = new System.Drawing.Size(363, 277);
            this.lbOverzichtAfspraken.TabIndex = 12;
            // 
            // btnVerwijderAfspraak
            // 
            this.btnVerwijderAfspraak.Location = new System.Drawing.Point(152, 57);
            this.btnVerwijderAfspraak.Name = "btnVerwijderAfspraak";
            this.btnVerwijderAfspraak.Size = new System.Drawing.Size(220, 23);
            this.btnVerwijderAfspraak.TabIndex = 11;
            this.btnVerwijderAfspraak.Text = "Verwijder afspraak";
            this.btnVerwijderAfspraak.UseVisualStyleBackColor = true;
            this.btnVerwijderAfspraak.Click += new System.EventHandler(this.btnVerwijderAfspraak_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Selecteer afspraak";
            // 
            // cbSelectAfspraak
            // 
            this.cbSelectAfspraak.FormattingEnabled = true;
            this.cbSelectAfspraak.Location = new System.Drawing.Point(152, 30);
            this.cbSelectAfspraak.Name = "cbSelectAfspraak";
            this.cbSelectAfspraak.Size = new System.Drawing.Size(220, 21);
            this.cbSelectAfspraak.TabIndex = 10;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnVerwijderZiekte);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.cbSelectZiekte);
            this.groupBox3.Controls.Add(this.lbOverzichtZiekte);
            this.groupBox3.Location = new System.Drawing.Point(823, 66);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(378, 428);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ziekte verwijderen";
            // 
            // btnVerwijderZiekte
            // 
            this.btnVerwijderZiekte.Location = new System.Drawing.Point(152, 57);
            this.btnVerwijderZiekte.Name = "btnVerwijderZiekte";
            this.btnVerwijderZiekte.Size = new System.Drawing.Size(220, 23);
            this.btnVerwijderZiekte.TabIndex = 3;
            this.btnVerwijderZiekte.Text = "Verwijder ziekte";
            this.btnVerwijderZiekte.UseVisualStyleBackColor = true;
            this.btnVerwijderZiekte.Click += new System.EventHandler(this.btnVerwijderZiekte_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Sekecteer ziekte";
            // 
            // cbSelectZiekte
            // 
            this.cbSelectZiekte.FormattingEnabled = true;
            this.cbSelectZiekte.Location = new System.Drawing.Point(152, 30);
            this.cbSelectZiekte.Name = "cbSelectZiekte";
            this.cbSelectZiekte.Size = new System.Drawing.Size(220, 21);
            this.cbSelectZiekte.TabIndex = 1;
            // 
            // lbOverzichtZiekte
            // 
            this.lbOverzichtZiekte.FormattingEnabled = true;
            this.lbOverzichtZiekte.Location = new System.Drawing.Point(6, 146);
            this.lbOverzichtZiekte.Name = "lbOverzichtZiekte";
            this.lbOverzichtZiekte.Size = new System.Drawing.Size(366, 277);
            this.lbOverzichtZiekte.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnVerwijderZiektePatient);
            this.groupBox4.Controls.Add(this.cbSelecteerZiektePatient);
            this.groupBox4.Controls.Add(this.btnZoekZiektePatient);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.tbPascode);
            this.groupBox4.Controls.Add(this.lbOverzichtZiektePatient);
            this.groupBox4.Location = new System.Drawing.Point(1229, 66);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(378, 428);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ziekte van patient verwijderen";
            // 
            // btnVerwijderZiektePatient
            // 
            this.btnVerwijderZiektePatient.Location = new System.Drawing.Point(152, 113);
            this.btnVerwijderZiektePatient.Name = "btnVerwijderZiektePatient";
            this.btnVerwijderZiektePatient.Size = new System.Drawing.Size(220, 23);
            this.btnVerwijderZiektePatient.TabIndex = 7;
            this.btnVerwijderZiektePatient.Text = "Verwijder ziekte patient";
            this.btnVerwijderZiektePatient.UseVisualStyleBackColor = true;
            this.btnVerwijderZiektePatient.Click += new System.EventHandler(this.btnVerwijderZiektePatient_Click);
            // 
            // cbSelecteerZiektePatient
            // 
            this.cbSelecteerZiektePatient.FormattingEnabled = true;
            this.cbSelecteerZiektePatient.Location = new System.Drawing.Point(152, 86);
            this.cbSelecteerZiektePatient.Name = "cbSelecteerZiektePatient";
            this.cbSelecteerZiektePatient.Size = new System.Drawing.Size(220, 21);
            this.cbSelecteerZiektePatient.TabIndex = 6;
            // 
            // btnZoekZiektePatient
            // 
            this.btnZoekZiektePatient.Location = new System.Drawing.Point(152, 57);
            this.btnZoekZiektePatient.Name = "btnZoekZiektePatient";
            this.btnZoekZiektePatient.Size = new System.Drawing.Size(220, 23);
            this.btnZoekZiektePatient.TabIndex = 3;
            this.btnZoekZiektePatient.Text = "Zoek patientgegevens op";
            this.btnZoekZiektePatient.UseVisualStyleBackColor = true;
            this.btnZoekZiektePatient.Click += new System.EventHandler(this.btnZoekZiektePatient_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Geef pascode op";
            // 
            // tbPascode
            // 
            this.tbPascode.Location = new System.Drawing.Point(152, 30);
            this.tbPascode.Name = "tbPascode";
            this.tbPascode.Size = new System.Drawing.Size(220, 20);
            this.tbPascode.TabIndex = 1;
            // 
            // lbOverzichtZiektePatient
            // 
            this.lbOverzichtZiektePatient.FormattingEnabled = true;
            this.lbOverzichtZiektePatient.Location = new System.Drawing.Point(7, 146);
            this.lbOverzichtZiektePatient.Name = "lbOverzichtZiektePatient";
            this.lbOverzichtZiektePatient.Size = new System.Drawing.Size(365, 277);
            this.lbOverzichtZiektePatient.TabIndex = 0;
            // 
            // Beheer_Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1784, 961);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Beheer_Delete";
            this.Text = "Beheer_Delete";
            this.Load += new System.EventHandler(this.Beheer_Delete_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnVerwijderMedicijn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSelectMedicijn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox lbOverzichtMedicijnen;
        private System.Windows.Forms.ComboBox cbSelectAfspraak;
        private System.Windows.Forms.Button btnVerwijderAfspraak;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbOverzichtAfspraken;
        private System.Windows.Forms.Button btnVerwijderZiekte;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbSelectZiekte;
        private System.Windows.Forms.ListBox lbOverzichtZiekte;
        private System.Windows.Forms.Button btnZoekZiektePatient;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPascode;
        private System.Windows.Forms.ListBox lbOverzichtZiektePatient;
        private System.Windows.Forms.Button btnVerwijderZiektePatient;
        private System.Windows.Forms.ComboBox cbSelecteerZiektePatient;
    }
}