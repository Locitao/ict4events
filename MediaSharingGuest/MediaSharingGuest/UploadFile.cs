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
        public UploadFile(MediaSharingSystem ms)
        {
            InitializeComponent();
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
            title = tbTitel.Text;
            description = tbDesciption.Text;
            location = tbLocation.Text;

            //INSERT statement

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
