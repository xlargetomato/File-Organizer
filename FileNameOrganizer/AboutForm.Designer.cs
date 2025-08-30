namespace FileNameOrganizer
{
    partial class AboutForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            lblAppName = new Label();
            lblVersion = new Label();
            picIcon = new PictureBox();
            pnlContent = new Panel();
            lblDescription = new Label();
            lblDeveloper = new Label();
            linkGitHub = new LinkLabel();
            lblCopyright = new Label();
            lblTechnologies = new Label();
            pnlFooter = new Panel();
            btnClose = new Button();
            label1 = new Label();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picIcon).BeginInit();
            pnlContent.SuspendLayout();
            pnlFooter.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(52, 73, 94);
            pnlHeader.Controls.Add(lblAppName);
            pnlHeader.Controls.Add(lblVersion);
            pnlHeader.Controls.Add(picIcon);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Padding = new Padding(20);
            pnlHeader.Size = new Size(480, 120);
            pnlHeader.TabIndex = 0;
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblAppName.ForeColor = Color.White;
            lblAppName.Location = new Point(100, 25);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(243, 46);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "File Organizer";
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.Font = new Font("Segoe UI", 10F);
            lblVersion.ForeColor = Color.FromArgb(189, 195, 199);
            lblVersion.Location = new Point(100, 75);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(111, 23);
            lblVersion.TabIndex = 1;
            lblVersion.Text = "Version 0.001";
            // 
            // picIcon
            // 
            picIcon.BackColor = Color.FromArgb(41, 128, 185);
            picIcon.Location = new Point(20, 25);
            picIcon.Name = "picIcon";
            picIcon.Size = new Size(64, 64);
            picIcon.TabIndex = 2;
            picIcon.TabStop = false;
            picIcon.Paint += picIcon_Paint;
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.White;
            pnlContent.Controls.Add(label1);
            pnlContent.Controls.Add(lblDescription);
            pnlContent.Controls.Add(lblDeveloper);
            pnlContent.Controls.Add(linkGitHub);
            pnlContent.Controls.Add(lblCopyright);
            pnlContent.Controls.Add(lblTechnologies);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(0, 120);
            pnlContent.Name = "pnlContent";
            pnlContent.Padding = new Padding(30, 20, 30, 20);
            pnlContent.Size = new Size(480, 260);
            pnlContent.TabIndex = 1;
            // 
            // lblDescription
            // 
            lblDescription.Font = new Font("Segoe UI", 10F);
            lblDescription.ForeColor = Color.FromArgb(73, 80, 87);
            lblDescription.Location = new Point(30, 20);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(420, 60);
            lblDescription.TabIndex = 0;
            lblDescription.Text = "A powerful and intuitive file organization tool that helps you sort and manage your files efficiently. Organize files by type, date, or size with preview functionality.";
            // 
            // lblDeveloper
            // 
            lblDeveloper.AutoSize = true;
            lblDeveloper.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDeveloper.ForeColor = Color.FromArgb(52, 73, 94);
            lblDeveloper.Location = new Point(30, 90);
            lblDeveloper.Name = "lblDeveloper";
            lblDeveloper.Size = new Size(248, 23);
            lblDeveloper.TabIndex = 1;
            lblDeveloper.Text = "Developed by Ahmed Hegazy";
            // 
            // linkGitHub
            // 
            linkGitHub.AutoSize = true;
            linkGitHub.Font = new Font("Segoe UI", 9F);
            linkGitHub.LinkColor = Color.FromArgb(52, 152, 219);
            linkGitHub.Location = new Point(30, 120);
            linkGitHub.Name = "linkGitHub";
            linkGitHub.Size = new Size(228, 20);
            linkGitHub.TabIndex = 2;
            linkGitHub.TabStop = true;
            linkGitHub.Text = "https://github.com/xlargetomato";
            linkGitHub.LinkClicked += linkGitHub_LinkClicked;
            // 
            // lblCopyright
            // 
            lblCopyright.AutoSize = true;
            lblCopyright.Font = new Font("Segoe UI", 9F);
            lblCopyright.ForeColor = Color.FromArgb(149, 165, 166);
            lblCopyright.Location = new Point(30, 160);
            lblCopyright.Name = "lblCopyright";
            lblCopyright.Size = new Size(293, 20);
            lblCopyright.TabIndex = 3;
            lblCopyright.Text = "© 2024 Ahmed Hegazy. All rights reserved.";
            // 
            // lblTechnologies
            // 
            lblTechnologies.Font = new Font("Segoe UI", 9F);
            lblTechnologies.ForeColor = Color.FromArgb(149, 165, 166);
            lblTechnologies.Location = new Point(30, 190);
            lblTechnologies.Name = "lblTechnologies";
            lblTechnologies.Size = new Size(420, 40);
            lblTechnologies.TabIndex = 4;
            lblTechnologies.Text = "Built with C# and Windows Forms\nFeatures: File organization, Preview mode, Undo functionality";
            // 
            // pnlFooter
            // 
            pnlFooter.BackColor = Color.FromArgb(248, 249, 250);
            pnlFooter.Controls.Add(btnClose);
            pnlFooter.Dock = DockStyle.Bottom;
            pnlFooter.Location = new Point(0, 380);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Padding = new Padding(20);
            pnlFooter.Size = new Size(480, 70);
            pnlFooter.TabIndex = 2;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnClose.BackColor = Color.FromArgb(52, 152, 219);
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(357, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(100, 35);
            btnClose.TabIndex = 0;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.Window;
            label1.Font = new Font("Segoe UI", 9F);
            label1.ForeColor = Color.RosyBrown;
            label1.Location = new Point(30, 230);
            label1.Name = "label1";
            label1.Size = new Size(420, 40);
            label1.TabIndex = 5;
            label1.Text = "Design (UI/UX) assistance: Claude Sonnet 4 (AI)";
            // 
            // AboutForm
            // 
            AcceptButton = btnClose;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 450);
            Controls.Add(pnlContent);
            Controls.Add(pnlHeader);
            Controls.Add(pnlFooter);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AboutForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "About File Organizer";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picIcon).EndInit();
            pnlContent.ResumeLayout(false);
            pnlContent.PerformLayout();
            pnlFooter.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Panel pnlHeader;
        private Label lblAppName;
        private Label lblVersion;
        private PictureBox picIcon;
        private Panel pnlContent;
        private Label lblDescription;
        private Label lblDeveloper;
        private LinkLabel linkGitHub;
        private Label lblCopyright;
        private Label lblTechnologies;
        private Panel pnlFooter;
        private Button btnClose;
        private Label label1;
    }
}