namespace FileNameOrganizer
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip = new MenuStrip();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            pnlHeader = new Panel();
            lblTitle = new Label();
            lblSubtitle = new Label();
            pnlConfiguration = new Panel();
            grpFolders = new GroupBox();
            lblSource = new Label();
            txtSource = new TextBox();
            btnBrowseSource = new Button();
            lblDestination = new Label();
            txtDestination = new TextBox();
            btnBrowseDestination = new Button();
            chkUseSeparateDestination = new CheckBox();
            grpOptions = new GroupBox();
            chkIncludeSubfolders = new CheckBox();
            chkCopyInsteadOfMove = new CheckBox();
            chkDryRun = new CheckBox();
            grpOrganizeBy = new GroupBox();
            rbByType = new RadioButton();
            rbByDate = new RadioButton();
            rbBySize = new RadioButton();
            pnlActions = new Panel();
            btnPreview = new Button();
            btnRun = new Button();
            btnUndo = new Button();
            btnClear = new Button();
            pnlPreview = new Panel();
            lblPreviewTitle = new Label();
            lblPreviewCount = new Label();
            dgvPreview = new DataGridView();
            pnlStatus = new Panel();
            progressBar = new ProgressBar();
            statusStrip = new StatusStrip();
            toolStripStatusLabel = new ToolStripStatusLabel();
            toolStripProgressBar = new ToolStripProgressBar();
            folderBrowser = new FolderBrowserDialog();
            toolTip = new ToolTip(components);
            menuStrip.SuspendLayout();
            pnlHeader.SuspendLayout();
            pnlConfiguration.SuspendLayout();
            grpFolders.SuspendLayout();
            grpOptions.SuspendLayout();
            grpOrganizeBy.SuspendLayout();
            pnlActions.SuspendLayout();
            pnlPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPreview).BeginInit();
            pnlStatus.SuspendLayout();
            statusStrip.SuspendLayout();
            SuspendLayout();

            // menuStrip
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { helpToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(1200, 28);
            menuStrip.TabIndex = 5;
            menuStrip.Text = "menuStrip";

            // helpToolStripMenuItem
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(55, 24);
            helpToolStripMenuItem.Text = "Help";

            // aboutToolStripMenuItem
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(133, 26);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;

            // pnlHeader
            pnlHeader.BackColor = Color.FromArgb(52, 73, 94);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(lblSubtitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 28);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Padding = new Padding(20);
            pnlHeader.Size = new Size(1200, 80);
            pnlHeader.TabIndex = 0;

            // lblTitle
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 6);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(215, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "File Organizer";

            // lblSubtitle
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.FromArgb(189, 195, 199);
            lblSubtitle.Location = new Point(20, 47);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(391, 23);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Organize your files efficiently by type, date, or size";

            // pnlConfiguration
            pnlConfiguration.BackColor = Color.White;
            pnlConfiguration.Controls.Add(grpFolders);
            pnlConfiguration.Controls.Add(grpOptions);
            pnlConfiguration.Controls.Add(grpOrganizeBy);
            pnlConfiguration.Dock = DockStyle.Top;
            pnlConfiguration.Location = new Point(0, 108);
            pnlConfiguration.Name = "pnlConfiguration";
            pnlConfiguration.Padding = new Padding(20);
            pnlConfiguration.Size = new Size(1200, 200);
            pnlConfiguration.TabIndex = 1;

            // grpFolders
            grpFolders.Controls.Add(lblSource);
            grpFolders.Controls.Add(txtSource);
            grpFolders.Controls.Add(btnBrowseSource);
            grpFolders.Controls.Add(lblDestination);
            grpFolders.Controls.Add(txtDestination);
            grpFolders.Controls.Add(btnBrowseDestination);
            grpFolders.Controls.Add(chkUseSeparateDestination);
            grpFolders.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpFolders.ForeColor = Color.FromArgb(52, 73, 94);
            grpFolders.Location = new Point(20, 10);
            grpFolders.Name = "grpFolders";
            grpFolders.Padding = new Padding(15);
            grpFolders.Size = new Size(580, 120);
            grpFolders.TabIndex = 0;
            grpFolders.TabStop = false;
            grpFolders.Text = "Folder Configuration";

            // lblSource
            lblSource.AutoSize = true;
            lblSource.Font = new Font("Segoe UI", 9F);
            lblSource.ForeColor = Color.FromArgb(73, 80, 87);
            lblSource.Location = new Point(15, 35);
            lblSource.Name = "lblSource";
            lblSource.Size = new Size(103, 20);
            lblSource.TabIndex = 0;
            lblSource.Text = "Source Folder:";

            // txtSource
            txtSource.BorderStyle = BorderStyle.FixedSingle;
            txtSource.Font = new Font("Segoe UI", 9F);
            txtSource.Location = new Point(120, 32);
            txtSource.Name = "txtSource";
            txtSource.Size = new Size(350, 27);
            txtSource.TabIndex = 1;

            // btnBrowseSource
            btnBrowseSource.BackColor = Color.FromArgb(52, 152, 219);
            btnBrowseSource.FlatAppearance.BorderSize = 0;
            btnBrowseSource.FlatStyle = FlatStyle.Flat;
            btnBrowseSource.Font = new Font("Segoe UI", 9F);
            btnBrowseSource.ForeColor = Color.White;
            btnBrowseSource.Location = new Point(480, 31);
            btnBrowseSource.Name = "btnBrowseSource";
            btnBrowseSource.Size = new Size(80, 25);
            btnBrowseSource.TabIndex = 2;
            btnBrowseSource.Text = "Browse...";
            btnBrowseSource.UseVisualStyleBackColor = false;
            btnBrowseSource.Click += btnBrowseSource_Click;

            // lblDestination
            lblDestination.AutoSize = true;
            lblDestination.Font = new Font("Segoe UI", 9F);
            lblDestination.ForeColor = Color.FromArgb(73, 80, 87);
            lblDestination.Location = new Point(15, 65);
            lblDestination.Name = "lblDestination";
            lblDestination.Size = new Size(88, 20);
            lblDestination.TabIndex = 3;
            lblDestination.Text = "Destination:";

            // txtDestination
            txtDestination.BorderStyle = BorderStyle.FixedSingle;
            txtDestination.Enabled = false;
            txtDestination.Font = new Font("Segoe UI", 9F);
            txtDestination.Location = new Point(120, 62);
            txtDestination.Name = "txtDestination";
            txtDestination.Size = new Size(350, 27);
            txtDestination.TabIndex = 3;

            // btnBrowseDestination
            btnBrowseDestination.BackColor = Color.FromArgb(52, 152, 219);
            btnBrowseDestination.Enabled = false;
            btnBrowseDestination.FlatAppearance.BorderSize = 0;
            btnBrowseDestination.FlatStyle = FlatStyle.Flat;
            btnBrowseDestination.Font = new Font("Segoe UI", 9F);
            btnBrowseDestination.ForeColor = Color.White;
            btnBrowseDestination.Location = new Point(480, 61);
            btnBrowseDestination.Name = "btnBrowseDestination";
            btnBrowseDestination.Size = new Size(80, 25);
            btnBrowseDestination.TabIndex = 4;
            btnBrowseDestination.Text = "Browse...";
            btnBrowseDestination.UseVisualStyleBackColor = false;
            btnBrowseDestination.Click += btnBrowseDestination_Click;

            // chkUseSeparateDestination
            chkUseSeparateDestination.AutoSize = true;
            chkUseSeparateDestination.Font = new Font("Segoe UI", 9F);
            chkUseSeparateDestination.ForeColor = Color.FromArgb(73, 80, 87);
            chkUseSeparateDestination.Location = new Point(120, 92);
            chkUseSeparateDestination.Name = "chkUseSeparateDestination";
            chkUseSeparateDestination.Size = new Size(238, 24);
            chkUseSeparateDestination.TabIndex = 5;
            chkUseSeparateDestination.Text = "Use different destination folder";
            chkUseSeparateDestination.UseVisualStyleBackColor = true;
            chkUseSeparateDestination.CheckedChanged += chkUseSeparateDestination_CheckedChanged;

            // grpOptions
            grpOptions.Controls.Add(chkIncludeSubfolders);
            grpOptions.Controls.Add(chkCopyInsteadOfMove);
            grpOptions.Controls.Add(chkDryRun);
            grpOptions.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpOptions.ForeColor = Color.FromArgb(52, 73, 94);
            grpOptions.Location = new Point(620, 10);
            grpOptions.Name = "grpOptions";
            grpOptions.Padding = new Padding(15);
            grpOptions.Size = new Size(280, 120);
            grpOptions.TabIndex = 1;
            grpOptions.TabStop = false;
            grpOptions.Text = "Options";

            // chkIncludeSubfolders
            chkIncludeSubfolders.AutoSize = true;
            chkIncludeSubfolders.Font = new Font("Segoe UI", 9F);
            chkIncludeSubfolders.ForeColor = Color.FromArgb(73, 80, 87);
            chkIncludeSubfolders.Location = new Point(15, 30);
            chkIncludeSubfolders.Name = "chkIncludeSubfolders";
            chkIncludeSubfolders.Size = new Size(152, 24);
            chkIncludeSubfolders.TabIndex = 0;
            chkIncludeSubfolders.Text = "Include subfolders";
            chkIncludeSubfolders.UseVisualStyleBackColor = true;
            chkIncludeSubfolders.CheckedChanged += chkIncludeSubfolders_CheckedChanged;

            // chkCopyInsteadOfMove
            chkCopyInsteadOfMove.AutoSize = true;
            chkCopyInsteadOfMove.Font = new Font("Segoe UI", 9F);
            chkCopyInsteadOfMove.ForeColor = Color.FromArgb(73, 80, 87);
            chkCopyInsteadOfMove.Location = new Point(15, 55);
            chkCopyInsteadOfMove.Name = "chkCopyInsteadOfMove";
            chkCopyInsteadOfMove.Size = new Size(176, 24);
            chkCopyInsteadOfMove.TabIndex = 1;
            chkCopyInsteadOfMove.Text = "Copy instead of move";
            chkCopyInsteadOfMove.UseVisualStyleBackColor = true;

            // chkDryRun
            chkDryRun.AutoSize = true;
            chkDryRun.Checked = true;
            chkDryRun.CheckState = CheckState.Checked;
            chkDryRun.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            chkDryRun.ForeColor = Color.FromArgb(231, 76, 60);
            chkDryRun.Location = new Point(15, 80);
            chkDryRun.Name = "chkDryRun";
            chkDryRun.Size = new Size(190, 24);
            chkDryRun.TabIndex = 2;
            chkDryRun.Text = "Preview only (Safe mode)";
            chkDryRun.UseVisualStyleBackColor = true;
            chkDryRun.CheckedChanged += chkDryRun_CheckedChanged;

            // grpOrganizeBy
            grpOrganizeBy.Controls.Add(rbByType);
            grpOrganizeBy.Controls.Add(rbByDate);
            grpOrganizeBy.Controls.Add(rbBySize);
            grpOrganizeBy.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpOrganizeBy.ForeColor = Color.FromArgb(52, 73, 94);
            grpOrganizeBy.Location = new Point(920, 10);
            grpOrganizeBy.Name = "grpOrganizeBy";
            grpOrganizeBy.Padding = new Padding(15);
            grpOrganizeBy.Size = new Size(260, 120);
            grpOrganizeBy.TabIndex = 2;
            grpOrganizeBy.TabStop = false;
            grpOrganizeBy.Text = "Organize By";

            // rbByType
            rbByType.AutoSize = true;
            rbByType.Checked = true;
            rbByType.Font = new Font("Segoe UI", 9F);
            rbByType.ForeColor = Color.FromArgb(73, 80, 87);
            rbByType.Location = new Point(15, 30);
            rbByType.Name = "rbByType";
            rbByType.Size = new Size(88, 24);
            rbByType.TabIndex = 0;
            rbByType.TabStop = true;
            rbByType.Text = "File Type";
            rbByType.UseVisualStyleBackColor = true;

            // rbByDate
            rbByDate.AutoSize = true;
            rbByDate.Font = new Font("Segoe UI", 9F);
            rbByDate.ForeColor = Color.FromArgb(73, 80, 87);
            rbByDate.Location = new Point(15, 55);
            rbByDate.Name = "rbByDate";
            rbByDate.Size = new Size(140, 24);
            rbByDate.TabIndex = 1;
            rbByDate.Text = "Date (YYYY-MM)";
            rbByDate.UseVisualStyleBackColor = true;
            rbByDate.CheckedChanged += a_CheckedChanged;

            // rbBySize
            rbBySize.AutoSize = true;
            rbBySize.Font = new Font("Segoe UI", 9F);
            rbBySize.ForeColor = Color.FromArgb(73, 80, 87);
            rbBySize.Location = new Point(15, 80);
            rbBySize.Name = "rbBySize";
            rbBySize.Size = new Size(84, 24);
            rbBySize.TabIndex = 2;
            rbBySize.Text = "File Size";
            rbBySize.UseVisualStyleBackColor = true;

            // pnlActions
            pnlActions.BackColor = Color.FromArgb(236, 240, 241);
            pnlActions.Controls.Add(btnPreview);
            pnlActions.Controls.Add(btnRun);
            pnlActions.Controls.Add(btnUndo);
            pnlActions.Controls.Add(btnClear);
            pnlActions.Dock = DockStyle.Top;
            pnlActions.Location = new Point(0, 308);
            pnlActions.Name = "pnlActions";
            pnlActions.Padding = new Padding(20, 15, 20, 15);
            pnlActions.Size = new Size(1200, 70);
            pnlActions.TabIndex = 2;

            // btnPreview
            btnPreview.BackColor = Color.FromArgb(52, 152, 219);
            btnPreview.FlatAppearance.BorderSize = 0;
            btnPreview.FlatStyle = FlatStyle.Flat;
            btnPreview.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnPreview.ForeColor = Color.White;
            btnPreview.Location = new Point(20, 15);
            btnPreview.Name = "btnPreview";
            btnPreview.Size = new Size(120, 40);
            btnPreview.TabIndex = 0;
            btnPreview.Text = "Preview";
            btnPreview.UseVisualStyleBackColor = false;
            btnPreview.Click += btnPreview_Click;

            // btnRun
            btnRun.BackColor = Color.FromArgb(46, 204, 113);
            btnRun.Enabled = false;
            btnRun.FlatAppearance.BorderSize = 0;
            btnRun.FlatStyle = FlatStyle.Flat;
            btnRun.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRun.ForeColor = Color.White;
            btnRun.Location = new Point(160, 15);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(120, 40);
            btnRun.TabIndex = 1;
            btnRun.Text = "Execute";
            btnRun.UseVisualStyleBackColor = false;
            btnRun.Click += btnRun_Click;

            // btnUndo
            btnUndo.BackColor = Color.FromArgb(230, 126, 34);
            btnUndo.FlatAppearance.BorderSize = 0;
            btnUndo.FlatStyle = FlatStyle.Flat;
            btnUndo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnUndo.ForeColor = Color.White;
            btnUndo.Location = new Point(300, 15);
            btnUndo.Name = "btnUndo";
            btnUndo.Size = new Size(120, 40);
            btnUndo.TabIndex = 2;
            btnUndo.Text = "Undo";
            btnUndo.UseVisualStyleBackColor = false;
            btnUndo.Click += btnUndo_Click;

            // btnClear
            btnClear.BackColor = Color.FromArgb(149, 165, 166);
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 10F);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(440, 15);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(100, 40);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;

            // pnlPreview
            pnlPreview.BackColor = Color.White;
            pnlPreview.Controls.Add(lblPreviewTitle);
            pnlPreview.Controls.Add(lblPreviewCount);
            pnlPreview.Controls.Add(dgvPreview);
            pnlPreview.Dock = DockStyle.Fill;
            pnlPreview.Location = new Point(0, 378);
            pnlPreview.Name = "pnlPreview";
            pnlPreview.Padding = new Padding(20);
            pnlPreview.Size = new Size(1200, 372);
            pnlPreview.TabIndex = 3;

            // lblPreviewTitle
            lblPreviewTitle.AutoSize = true;
            lblPreviewTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPreviewTitle.ForeColor = Color.FromArgb(52, 73, 94);
            lblPreviewTitle.Location = new Point(20, 10);
            lblPreviewTitle.Name = "lblPreviewTitle";
            lblPreviewTitle.Size = new Size(145, 28);
            lblPreviewTitle.TabIndex = 0;
            lblPreviewTitle.Text = "Preview Results";

            // lblPreviewCount
            lblPreviewCount.AutoSize = true;
            lblPreviewCount.Font = new Font("Segoe UI", 9F);
            lblPreviewCount.ForeColor = Color.FromArgb(149, 165, 166);
            lblPreviewCount.Location = new Point(180, 14);
            lblPreviewCount.Name = "lblPreviewCount";
            lblPreviewCount.Size = new Size(120, 20);
            lblPreviewCount.TabIndex = 1;
            lblPreviewCount.Text = "0 files to process";

            // dgvPreview
            dgvPreview.AllowUserToAddRows = false;
            dgvPreview.AllowUserToDeleteRows = false;
            dgvPreview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPreview.BackgroundColor = Color.White;
            dgvPreview.BorderStyle = BorderStyle.None;
            dgvPreview.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvPreview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPreview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPreview.EnableHeadersVisualStyles = false;
            dgvPreview.GridColor = Color.FromArgb(236, 240, 241);
            dgvPreview.Location = new Point(20, 40);
            dgvPreview.Name = "dgvPreview";
            dgvPreview.ReadOnly = true;
            dgvPreview.RowHeadersVisible = false;
            dgvPreview.RowHeadersWidth = 51;
            dgvPreview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPreview.Size = new Size(1160, 292);
            dgvPreview.TabIndex = 0;
            dgvPreview.CellContentClick += dgvPreview_CellContentClick;

            // pnlStatus
            pnlStatus.BackColor = Color.FromArgb(248, 249, 250);
            pnlStatus.Controls.Add(progressBar);
            pnlStatus.Controls.Add(statusStrip);
            pnlStatus.Dock = DockStyle.Bottom;
            pnlStatus.Location = new Point(0, 750);
            pnlStatus.Name = "pnlStatus";
            pnlStatus.Size = new Size(1200, 50);
            pnlStatus.TabIndex = 4;

            // progressBar
            progressBar.Location = new Point(20, 10);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(300, 20);
            progressBar.Style = ProgressBarStyle.Continuous;
            progressBar.TabIndex = 0;
            progressBar.Visible = false;
            progressBar.Click += progressBar_Click;

            // statusStrip
            statusStrip.BackColor = Color.FromArgb(248, 249, 250);
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel, toolStripProgressBar });
            statusStrip.Location = new Point(0, 24);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(1200, 26);
            statusStrip.TabIndex = 1;

            // toolStripStatusLabel
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new Size(50, 20);
            toolStripStatusLabel.Text = "Ready";
            toolStripStatusLabel.Click += toolStripStatusLabel1_Click;

            // toolStripProgressBar
            toolStripProgressBar.Name = "toolStripProgressBar";
            toolStripProgressBar.Size = new Size(200, 18);
            toolStripProgressBar.Visible = false;

            // Form1
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            ClientSize = new Size(1200, 800);
            Controls.Add(pnlPreview);
            Controls.Add(pnlActions);
            Controls.Add(pnlConfiguration);
            Controls.Add(pnlHeader);
            Controls.Add(pnlStatus);
            Controls.Add(menuStrip);
            Font = new Font("Segoe UI", 9F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip;
            MinimumSize = new Size(1000, 600);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "File Organizer";
            Load += Form1_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlConfiguration.ResumeLayout(false);
            grpFolders.ResumeLayout(false);
            grpFolders.PerformLayout();
            grpOptions.ResumeLayout(false);
            grpOptions.PerformLayout();
            grpOrganizeBy.ResumeLayout(false);
            grpOrganizeBy.PerformLayout();
            pnlActions.ResumeLayout(false);
            pnlPreview.ResumeLayout(false);
            pnlPreview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPreview).EndInit();
            pnlStatus.ResumeLayout(false);
            pnlStatus.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void SetupTooltips()
        {
            toolTip.SetToolTip(chkIncludeSubfolders, "Process files in all subdirectories recursively");
            toolTip.SetToolTip(chkCopyInsteadOfMove, "Create copies of files instead of moving them");
            toolTip.SetToolTip(chkDryRun, "Show what would happen without making actual changes");
            toolTip.SetToolTip(rbByType, "Organize files into folders based on their file extension");
            toolTip.SetToolTip(rbByDate, "Organize files into YYYY-MM date folders based on creation/modification date");
            toolTip.SetToolTip(rbBySize, "Organize files into size categories (Small, Medium, Large)");
            toolTip.SetToolTip(btnPreview, "Generate a preview of the organization without making changes");
            toolTip.SetToolTip(btnRun, "Execute the file organization with current settings");
            toolTip.SetToolTip(btnUndo, "Restore files to their original locations from the last operation");
        }

        private MenuStrip menuStrip;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Panel pnlHeader;
        private Label lblTitle;
        private Label lblSubtitle;
        private Panel pnlConfiguration;
        private GroupBox grpFolders;
        private Label lblSource;
        private TextBox txtSource;
        private Button btnBrowseSource;
        private Label lblDestination;
        private TextBox txtDestination;
        private Button btnBrowseDestination;
        private CheckBox chkUseSeparateDestination;
        private GroupBox grpOptions;
        private CheckBox chkIncludeSubfolders;
        private CheckBox chkCopyInsteadOfMove;
        private CheckBox chkDryRun;
        private GroupBox grpOrganizeBy;
        private RadioButton rbByType;
        private RadioButton rbByDate;
        private RadioButton rbBySize;
        private Panel pnlActions;
        private Button btnPreview;
        private Button btnRun;
        private Button btnUndo;
        private Button btnClear;
        private Panel pnlPreview;
        private Label lblPreviewTitle;
        private Label lblPreviewCount;
        private DataGridView dgvPreview;
        private Panel pnlStatus;
        private ProgressBar progressBar;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel toolStripStatusLabel;
        private ToolStripProgressBar toolStripProgressBar;
        private FolderBrowserDialog folderBrowser;
        private ToolTip toolTip;
    }
}