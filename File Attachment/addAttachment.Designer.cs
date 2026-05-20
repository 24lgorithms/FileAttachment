namespace File_Attachment
{
    partial class addAttachment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addAttachment));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            lblFilePath = new Label();
            lblFileName = new Label();
            lblFileType = new Label();
            lblFileSize = new Label();
            label6 = new Label();
            btnBrowse = new Button();
            button1 = new Button();
            button2 = new Button();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(7, 78, 182);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(433, 33);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(8, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(23, 23);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lblFilePath
            // 
            lblFilePath.BorderStyle = BorderStyle.FixedSingle;
            lblFilePath.ForeColor = Color.Gray;
            lblFilePath.Location = new Point(24, 70);
            lblFilePath.Name = "lblFilePath";
            lblFilePath.Size = new Size(276, 32);
            lblFilePath.TabIndex = 1;
            lblFilePath.Text = "No file selected";
            lblFilePath.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblFileName
            // 
            lblFileName.BorderStyle = BorderStyle.FixedSingle;
            lblFileName.ForeColor = Color.Gray;
            lblFileName.Location = new Point(24, 124);
            lblFileName.Name = "lblFileName";
            lblFileName.Size = new Size(382, 29);
            lblFileName.TabIndex = 2;
            lblFileName.Text = "(file name will appear here)";
            lblFileName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblFileType
            // 
            lblFileType.BorderStyle = BorderStyle.FixedSingle;
            lblFileType.ForeColor = Color.Gray;
            lblFileType.Location = new Point(24, 175);
            lblFileType.Name = "lblFileType";
            lblFileType.Size = new Size(163, 29);
            lblFileType.TabIndex = 3;
            lblFileType.Text = "(file type will appear here)";
            lblFileType.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblFileSize
            // 
            lblFileSize.BorderStyle = BorderStyle.FixedSingle;
            lblFileSize.ForeColor = Color.Gray;
            lblFileSize.Location = new Point(243, 172);
            lblFileSize.Name = "lblFileSize";
            lblFileSize.Size = new Size(163, 29);
            lblFileSize.TabIndex = 4;
            lblFileSize.Text = "(file size will appear here)";
            lblFileSize.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.ForeColor = Color.Gray;
            label6.Location = new Point(24, 226);
            label6.Name = "label6";
            label6.Size = new Size(382, 66);
            label6.TabIndex = 5;
            label6.Text = "Enter notes about this file (optional)  ...";
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(306, 70);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(100, 32);
            btnBrowse.TabIndex = 6;
            btnBrowse.Text = "browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(7, 78, 182);
            button1.ForeColor = Color.White;
            button1.Location = new Point(306, 310);
            button1.Name = "button1";
            button1.Size = new Size(100, 32);
            button1.TabIndex = 7;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(202, 310);
            button2.Name = "button2";
            button2.Size = new Size(100, 32);
            button2.TabIndex = 8;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 0, 64);
            label4.Location = new Point(-5, 48);
            label4.Name = "label4";
            label4.Size = new Size(115, 25);
            label4.TabIndex = 9;
            label4.Text = "Select File";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 0, 64);
            label1.Location = new Point(-6, 103);
            label1.Name = "label1";
            label1.Size = new Size(115, 25);
            label1.TabIndex = 10;
            label1.Text = "File Name";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 0, 64);
            label2.Location = new Point(-9, 154);
            label2.Name = "label2";
            label2.Size = new Size(115, 25);
            label2.TabIndex = 11;
            label2.Text = "File Type";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 0, 64);
            label3.Location = new Point(209, 151);
            label3.Name = "label3";
            label3.Size = new Size(115, 25);
            label3.TabIndex = 12;
            label3.Text = "File Size";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(0, 0, 64);
            label5.Location = new Point(17, 204);
            label5.Name = "label5";
            label5.Size = new Size(115, 25);
            label5.TabIndex = 13;
            label5.Text = "Notes (optional)";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // addAttachment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(433, 350);
            Controls.Add(lblFileName);
            Controls.Add(lblFilePath);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnBrowse);
            Controls.Add(label6);
            Controls.Add(lblFileSize);
            Controls.Add(lblFileType);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label5);
            FormBorderStyle = FormBorderStyle.None;
            Name = "addAttachment";
            StartPosition = FormStartPosition.CenterParent;
            Text = "addAttachment";
            Load += addAttachment_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label lblFilePath;
        private Label lblFileName;
        private Label lblFileType;
        private Label lblFileSize;
        private Label label6;
        private Button btnBrowse;
        private Button button1;
        private Button button2;
        private Label label4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
    }
}