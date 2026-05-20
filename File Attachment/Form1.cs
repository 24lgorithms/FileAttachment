using static System.Runtime.InteropServices.JavaScript.JSType;

namespace File_Attachment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Panel overlayPanel;
       
        private void Form1_Load(object sender, EventArgs e)
        {
            UIHelper.StyleDataGridView(dataGridView1);

            LoadAttachments();
          //  hover();
        }

        //hoverpanel
       

        private void ShowOverlay()
        {
            overlayPanel = new Panel();
            overlayPanel.Size = this.ClientSize;
            overlayPanel.BackColor = Color.Black;
            overlayPanel.Location = new Point(0, 0);

            overlayPanel.Anchor = AnchorStyles.Top |
                                  AnchorStyles.Bottom |
                                  AnchorStyles.Left |
                                  AnchorStyles.Right;

            overlayPanel.Enabled = true;

            // transparency effect
            overlayPanel.BackColor = Color.FromArgb(120, Color.Black);

            this.Controls.Add(overlayPanel);
            overlayPanel.BringToFront();
        }

        private void HideOverlay()
        {
            if (overlayPanel != null)
            {
                this.Controls.Remove(overlayPanel);
                overlayPanel.Dispose();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ShowOverlay();

            // dataGridView1.Rows.Add("0", "1", "2", "3", "4", "5");
            addAttachment add = new addAttachment(this);

            add.ShowDialog();
            HideOverlay();
        }

        public void AddAttachmentToGrid(string filePath, string fileName, string fileType, string fileSize, string Date)
        {
            // dataGridView1.Rows.Add("0", "1", "2", "3", "4", "5");
            dataGridView1.Rows.Add("0", filePath, fileName, fileType, fileSize, Date);
        }

        private void LoadAttachments()
        {
            string folderPath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                "Attachments"
            );

            if (!Directory.Exists(folderPath))
                return;

            dataGridView1.Rows.Clear();

            string[] files = Directory.GetFiles(folderPath);

            foreach (string file in files)
            {
                FileInfo fi = new FileInfo(file);

                dataGridView1.Rows.Add(
                    Guid.NewGuid().ToString(),
                    fi.FullName,
                    fi.Name,
                    fi.Extension,
                    (fi.Length / 1024).ToString() + " KB",
                    fi.CreationTime.ToString("yyyy-MM-dd HH:mm")
                );
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string filePath = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

            if (File.Exists(filePath))
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                {
                    FileName = filePath,
                    UseShellExecute = true // 🔥 IMPORTANT: default app
                });
            }
            else
            {
                MessageBox.Show("File not found!");
            }
        }

        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex < 0) return;

            //var row = dataGridView1.Rows[e.RowIndex];

            //lblName.Text = "Name: " + row.Cells[2].Value;
            //lblType.Text = "Type: " + row.Cells[3].Value;
            //lblSize.Text = "Size: " + row.Cells[4].Value;
            //lblDate.Text = "Date: " + row.Cells[5].Value;

            //Point mouse = Control.MousePosition;
            //hoverPanel.Location = this.PointToClient(new Point(mouse.X + 10, mouse.Y + 10));

            //hoverPanel.Visible = true;

        }

        private void dataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            //hoverPanel.Visible = false;
        }
    }
}
