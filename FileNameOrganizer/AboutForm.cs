using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace FileNameOrganizer
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            SetupHoverEffects();
        }

        private void SetupHoverEffects()
        {
            btnClose.MouseEnter += (s, e) => {
                btnClose.BackColor = Color.FromArgb(41, 128, 185);
            };
            btnClose.MouseLeave += (s, e) => {
                btnClose.BackColor = Color.FromArgb(52, 152, 219);
            };
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = "https://github.com/xlargetomato",
                    UseShellExecute = true
                });
            }
            catch
            {
                MessageBox.Show("Unable to open the GitHub link. Please visit:\nhttps://github.com/xlargetomato",
                               "Link Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void picIcon_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            var rect = new Rectangle(8, 8, 48, 48);

            using (var brush = new LinearGradientBrush(rect,
                Color.FromArgb(52, 152, 219), Color.FromArgb(41, 128, 185),
                LinearGradientMode.Vertical))
            {
                g.FillEllipse(brush, rect);
            }

            using (var pen = new Pen(Color.White, 3))
            {
                g.DrawLine(pen, 20, 20, 40, 20);
                g.DrawLine(pen, 20, 28, 44, 28);
                g.DrawLine(pen, 20, 36, 38, 36);
                g.DrawLine(pen, 20, 44, 42, 44);
            }
        }
    }
}