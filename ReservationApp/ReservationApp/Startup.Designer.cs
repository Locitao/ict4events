namespace ReservationApp
{
    partial class Startup
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
            this.btnOnlyAcc = new System.Windows.Forms.Button();
            this.btnAccReserve = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOnlyAcc
            // 
            this.btnOnlyAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOnlyAcc.Location = new System.Drawing.Point(0, 0);
            this.btnOnlyAcc.Name = "btnOnlyAcc";
            this.btnOnlyAcc.Size = new System.Drawing.Size(125, 125);
            this.btnOnlyAcc.TabIndex = 0;
            this.btnOnlyAcc.Text = "Create an account (if a friend has already reserved).";
            this.btnOnlyAcc.UseVisualStyleBackColor = true;
            this.btnOnlyAcc.Click += new System.EventHandler(this.btnOnlyAcc_Click);
            // 
            // btnAccReserve
            // 
            this.btnAccReserve.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccReserve.Location = new System.Drawing.Point(157, 0);
            this.btnAccReserve.Name = "btnAccReserve";
            this.btnAccReserve.Size = new System.Drawing.Size(125, 125);
            this.btnAccReserve.TabIndex = 1;
            this.btnAccReserve.Text = "Create an account and a reservation.";
            this.btnAccReserve.UseVisualStyleBackColor = true;
            // 
            // Startup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 132);
            this.Controls.Add(this.btnAccReserve);
            this.Controls.Add(this.btnOnlyAcc);
            this.Name = "Startup";
            this.Text = "Startup";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOnlyAcc;
        private System.Windows.Forms.Button btnAccReserve;
    }
}