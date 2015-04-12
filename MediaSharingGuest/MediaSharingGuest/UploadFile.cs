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
    public partial class UploadFile : Form
    {
        MediaSharingSystem medias;
        Category category;

        public UploadFile(MediaSharingSystem medias, Category category)
        {
            InitializeComponent();
            this.medias = medias;
            this.category = category;
        }
        private string filePath = "";
        private string title = "";
        private string description = "";
        private string location = "";

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

        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (filePath == "")
            {
                MessageBox.Show("No file selected!");
            }

            title = tbTitel.Text;
            description = tbDesciption.Text;
            location = tbLocation.Text;
            string creatorRfid = medias.MediaUser.RFIDcode;

            Media newMediaItem = new Media(title, filePath, description, creatorRfid, location, category.CategoryId);

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            filePath = "";
            title = "";
            description = "";
            location = "";
            this.Close();
        }
    }
}
