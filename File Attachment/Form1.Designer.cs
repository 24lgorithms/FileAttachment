namespace File_Attachment
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            groupBox1 = new GroupBox();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            filePath = new DataGridViewTextBoxColumn();
            fileName = new DataGridViewTextBoxColumn();
            fileType = new DataGridViewTextBoxColumn();
            fileSize = new DataGridViewTextBoxColumn();
            createdDate = new DataGridViewTextBoxColumn();
            view = new DataGridViewButtonColumn();
            change = new DataGridViewButtonColumn();
            panel1 = new Panel();
            textBox3 = new TextBox();
            button2 = new Button();
            label4 = new Label();
            flowLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 0, 64);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(150, 26);
            label1.TabIndex = 0;
            label1.Text = "File Attachment";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(10, 10);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(828, 38);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Dock = DockStyle.Top;
            flowLayoutPanel2.Location = new Point(10, 48);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(828, 38);
            flowLayoutPanel2.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel2);
            groupBox1.Controls.Add(panel1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.FromArgb(0, 0, 64);
            groupBox1.Location = new Point(10, 86);
            groupBox1.Margin = new Padding(10);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(10);
            groupBox1.Size = new Size(828, 412);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Attached Files";
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(10, 51);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(0, 10, 0, 0);
            panel2.Size = new Size(808, 351);
            panel2.TabIndex = 6;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowDrop = true;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, filePath, fileName, fileType, fileSize, createdDate, view, change });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.GridColor = Color.LightGray;
            dataGridView1.Location = new Point(0, 10);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(808, 341);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            dataGridView1.CellMouseEnter += dataGridView1_CellMouseEnter;
            dataGridView1.CellMouseLeave += dataGridView1_CellMouseLeave;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Visible = false;
            ID.Width = 5;
            // 
            // filePath
            // 
            filePath.HeaderText = "File Path";
            filePath.Name = "filePath";
            filePath.ReadOnly = true;
            filePath.Visible = false;
            // 
            // fileName
            // 
            fileName.HeaderText = "FileName";
            fileName.Name = "fileName";
            fileName.ReadOnly = true;
            // 
            // fileType
            // 
            fileType.HeaderText = "File Type";
            fileType.Name = "fileType";
            fileType.ReadOnly = true;
            // 
            // fileSize
            // 
            fileSize.HeaderText = "File Size";
            fileSize.Name = "fileSize";
            fileSize.ReadOnly = true;
            // 
            // createdDate
            // 
            createdDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            createdDate.HeaderText = "Date Attached";
            createdDate.Name = "createdDate";
            createdDate.ReadOnly = true;
            createdDate.Width = 113;
            // 
            // view
            // 
            view.HeaderText = "View";
            view.Name = "view";
            view.ReadOnly = true;
            // 
            // change
            // 
            change.HeaderText = "Change";
            change.Name = "change";
            change.ReadOnly = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(10, 26);
            panel1.Name = "panel1";
            panel1.Size = new Size(808, 25);
            panel1.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Dock = DockStyle.Left;
            textBox3.Location = new Point(49, 0);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(132, 23);
            textBox3.TabIndex = 6;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Right;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(711, 0);
            button2.Name = "button2";
            button2.Size = new Size(97, 25);
            button2.TabIndex = 5;
            button2.Text = "Attach File";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Left;
            label4.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 0, 64);
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(49, 25);
            label4.TabIndex = 7;
            label4.Text = "Search";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(848, 508);
            Controls.Add(groupBox1);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Name = "Form1";
            Padding = new Padding(10);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sample File Attachment";
            Load += Form1_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private GroupBox groupBox1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Panel panel1;
        private TextBox textBox3;
        private Button button2;
        private Label label4;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn filePath;
        private DataGridViewTextBoxColumn fileName;
        private DataGridViewTextBoxColumn fileType;
        private DataGridViewTextBoxColumn fileSize;
        private DataGridViewTextBoxColumn createdDate;
        private DataGridViewButtonColumn view;
        private DataGridViewButtonColumn change;
    }
}
