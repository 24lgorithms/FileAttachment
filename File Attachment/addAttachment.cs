using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace File_Attachment
{
    public partial class addAttachment : Form
    {

        Form1 mainForm;
        public addAttachment(Form1 form)
        {
            InitializeComponent();
            mainForm = form;
         //   UIHelper.MakeRounded(this, 20);
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(2);
        }

        private void addAttachment_Load(object sender, EventArgs e)
        {
            //  UIHelper.MakeRounded(this, 30);

            UIHelper.MakePictureBoxCircle(pictureBox1);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Title = "Select File";
            ofd.Filter = "All Files|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string filePath = ofd.FileName;

                FileInfo fi = new FileInfo(filePath);

                // File Name
                lblFileName.Text = fi.Name;

                // File Type (extension)
                lblFileType.Text = fi.Extension;

                // File Size (KB)
                lblFileSize.Text = (fi.Length / 1024).ToString() + " KB";

                // Full Path
                lblFilePath.Text = fi.FullName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblFilePath.Text))
            {
                MessageBox.Show("Walang file na selected!");
                return;
            }

            string sourcePath = lblFilePath.Text;

            string restrictedFolder =
                Path.Combine(Environment.GetFolderPath(
                Environment.SpecialFolder.Desktop),
                "Attachments");

            if (!Directory.Exists(restrictedFolder))
            {
                Directory.CreateDirectory(restrictedFolder);
            }

            FileInfo fi = new FileInfo(sourcePath);

            // optional: unique filename para iwas overwrite
            string uniqueFileName = Guid.NewGuid().ToString() + "_" + fi.Name;

            string destPath = Path.Combine(restrictedFolder, uniqueFileName);
            
            // COPY FILE TO RESTRICTED FOLDER
            File.Copy(sourcePath, destPath, true);

            // RELATIVE PATH (for DB)
            string relativePath = @"Attachments\" + uniqueFileName;

           // Form1 main = new Form1();

            //MessageBox.Show("File Saved Successfully!");
           // Form1 main = new Form1();
            mainForm.AddAttachmentToGrid(destPath, fi.Name,fi.Extension, (fi.Length / 1024).ToString() + " KB", DateTime.Now.ToString("yyyy-MM-dd HH:mm"));
            this.Close();
        }

        // ADD TO DATAGRIDVIEW
        //dataGridView1.Rows.Add(
        //        fi.Name,
        //        fi.Extension,
        //        (fi.Length / 1024).ToString() + " KB",
        //        DateTime.Now.ToString("yyyy-MM-dd HH:mm"),
        //        relativePath // optional hidden column
        //    );

            // SAVE TO DATABASE (sample logic)
            /*
            INSERT INTO attachments
            (fileName, fileType, fileSize, createdDate, filePath)
            VALUES (...)
            */



            //// send to Form1
           
    }
}
