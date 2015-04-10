namespace Toegangscontrole
{
    partial class ToegangsControle
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
            this.lbReserves = new System.Windows.Forms.ListBox();
            this.tbRFIDCode = new System.Windows.Forms.TextBox();
            this.bttnPayed = new System.Windows.Forms.Button();
            this.bttnCancel = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lbReserves
            // 
            this.lbReserves.FormattingEnabled = true;
            this.lbReserves.Location = new System.Drawing.Point(13, 39);
            this.lbReserves.Name = "lbReserves";
            this.lbReserves.Size = new System.Drawing.Size(436, 212);
            this.lbReserves.TabIndex = 0;
            // 
            // tbRFIDCode
            // 
            this.tbRFIDCode.Location = new System.Drawing.Point(13, 13);
            this.tbRFIDCode.Name = "tbRFIDCode";
            this.tbRFIDCode.Size = new System.Drawing.Size(436, 20);
            this.tbRFIDCode.TabIndex = 1;
            // 
            // bttnPayed
            // 
            this.bttnPayed.Location = new System.Drawing.Point(12, 272);
            this.bttnPayed.Name = "bttnPayed";
            this.bttnPayed.Size = new System.Drawing.Size(113, 23);
            this.bttnPayed.TabIndex = 2;
            this.bttnPayed.Text = "Betaald";
            this.bttnPayed.UseVisualStyleBackColor = true;
            // 
            // bttnCancel
            // 
            this.bttnCancel.Location = new System.Drawing.Point(131, 272);
            this.bttnCancel.Name = "bttnCancel";
            this.bttnCancel.Size = new System.Drawing.Size(112, 23);
            this.bttnCancel.TabIndex = 3;
            this.bttnCancel.Text = "Cancel reservering";
            this.bttnCancel.UseVisualStyleBackColor = true;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(249, 272);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 307);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.bttnCancel);
            this.Controls.Add(this.bttnPayed);
            this.Controls.Add(this.tbRFIDCode);
            this.Controls.Add(this.lbReserves);
            this.Name = "Form1";
            this.Text = "Toegangs controle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbReserves;
        private System.Windows.Forms.TextBox tbRFIDCode;
        private System.Windows.Forms.Button bttnPayed;
        private System.Windows.Forms.Button bttnCancel;
        private System.Windows.Forms.DateTimePicker dtpDate;
    }
}

