using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaSharingGuest
{
    /// <summary>
    /// This Form handles the uploading of Files.
    /// </summary>
    public partial class UploadFile : Form
    {
        //Fields----------------------------------------------
        MediaSharingSystem medias;
        Protection protection = new Protection();
        Connection connection = new Connection();
        Insert insert = new Insert();
        private string filePath = "";
        private string title = "";
        private string description = "";
        private string location = "";

        //Properties------------------------------------------
        public int uploadCategoryId { get; set; }

        //Constructor-----------------------------------------
        public UploadFile(MediaSharingSystem medias, int category)
        {
            InitializeComponent();
            this.medias = medias;
            uploadCategoryId = category;
        }

        //Events---------------------------------------------

        //Opens filebrowser and sets some values.
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog fDialog = new OpenFileDialog();
            fDialog.Title = "Upload File";
            fDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";

            if (fDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = fDialog.FileName.ToString();
                tbPath.Text = filePath;
                pbImage.ImageLocation = @filePath;
                pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        //Uploads a file to the database.
        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (filePath == "")
            {
                MessageBox.Show("No file selected!");
            }

            title = protection.ProtectAgainstSQLInjection(tbTitel.Text);
            description = protection.ProtectAgainstSQLInjection(tbDesciption.Text);
            location = protection.ProtectAgainstSQLInjection(tbLocation.Text);
            string creatorRfid = medias.RfidCode;

            Media newMediaItem = new Media(title, filePath, description, creatorRfid, location, uploadCategoryId, '0');
            connection.SQLQueryNoOutput(insert.InsertImage(uploadCategoryId, title, location, description, medias.RfidCode));

            this.Close();
        }

        //Closes the window.
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
