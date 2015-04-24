using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
        Select select = new Select();
        Insert insert = new Insert();
        private string filePath = "";
        private string savePath = "";
        private string title = "";
        private string description = "";
        private string location = "";
        List<List<string>> output = new List<List<string>>();

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
            fDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png | Video and Audio files (*.wma, *.mwv, *.avi, *.mid, *.mp3) | *.wma; *.mwv; *.avi; *.mid; *.mp3 ";

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
            else if (filePath != "")
            {
                connection.SQLQueryWithOutput(select.GetMaxMedId(), out output);
                int number = 0;

                if (output[0][0] == "")
                {
                    number = 1;
                }
                else
                {
                    number = Convert.ToInt32(output[0][0]);
                }

                string filename = "file" + Convert.ToString(number + 1);

                title = protection.ProtectAgainstSQLInjection(tbTitel.Text);
                description = protection.ProtectAgainstSQLInjection(tbDesciption.Text);
                location = protection.ProtectAgainstSQLInjection(tbLocation.Text);
                string creatorRfid = medias.RfidCode;
                int type;

                string substringPath = filePath.Substring((filePath.Length) - 4);

                if (substringPath.StartsWith("."))
                {
                    substringPath = substringPath.Substring(1);
                }

                

                if (substringPath == "jpg" || substringPath == "jpeg" || substringPath == "jpe" || substringPath == "jfif" || substringPath == "png")
                {
                    type = 0;
                }
                else
                {
                    type = 1;
                }

                //Copy file
                savePath = "../../../../" + filename + "." + substringPath;

                connection.SQLQueryNoOutput(insert.InsertImage(uploadCategoryId, title, location, description, medias.RfidCode, savePath, type));

                File.Copy(filePath, savePath);

                this.Close();
            }
        }

        //Closes the window.
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
