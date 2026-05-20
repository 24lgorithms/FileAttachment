using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Text;

namespace File_Attachment
{
    internal class UIHelper
    {
        public static void StyleDataGridView(DataGridView dgv)
        {
            // 1. Background + Border
            dgv.BorderStyle = BorderStyle.None;
            dgv.BackgroundColor = Color.White;
            dgv.GridColor = Color.LightGray;

            // 2. Header Design
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);

            // 3. Row Style
            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(245, 245, 245);
            dgv.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(52, 152, 219);
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;

            // 4. Font + Height
            dgv.RowTemplate.Height = 35;
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 10);

            // 5. Auto resize
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // 6. Behavior
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AllowUserToAddRows = false;
            dgv.ReadOnly = true;


        }
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse);

        public static void MakeRounded(Form form, int radius)
        {
            form.FormBorderStyle = FormBorderStyle.None;

            form.Region = Region.FromHrgn(
                CreateRoundRectRgn(0, 0, form.Width, form.Height, radius, radius)
            );

            form.Resize += (s, e) =>
            {
                form.Region = Region.FromHrgn(
                    CreateRoundRectRgn(0, 0, form.Width, form.Height, radius, radius)
                );
            };
        }

        public static void MakePictureBoxCircle(PictureBox pic)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, pic.Width, pic.Height);
            pic.Region = new Region(path);
        }
    }
}
