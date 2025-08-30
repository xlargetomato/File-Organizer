using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;

namespace FileNameOrganizer
{
    public partial class Form1 : Form
    {
        private List<(string Source, string Destination)> history = new List<(string, string)>();

        public Form1()
        {
            InitializeComponent();
            SetupUI();
        }

        private void SetupUI()
        {
            SetupButtonHoverEffects();
            ConfigureDataGridView();
            UpdateStatusLabel("Ready to organize files");
            UpdatePreviewCount(0);

            SetStyle(ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.UserPaint |
                     ControlStyles.DoubleBuffer, true);
        }

        private void SetupButtonHoverEffects()
        {
            btnPreview.MouseEnter += (s, e) => { btnPreview.BackColor = Color.FromArgb(41, 128, 185); };
            btnPreview.MouseLeave += (s, e) => { btnPreview.BackColor = Color.FromArgb(52, 152, 219); };

            btnRun.MouseEnter += (s, e) => {
                if (btnRun.Enabled)
                {
                    btnRun.BackColor = chkDryRun.Checked ?
                        Color.FromArgb(39, 174, 96) :
                        Color.FromArgb(192, 57, 43);
                }
            };
            btnRun.MouseLeave += (s, e) => {
                if (btnRun.Enabled)
                {
                    btnRun.BackColor = chkDryRun.Checked ?
                        Color.FromArgb(46, 204, 113) :
                        Color.FromArgb(231, 76, 60);
                }
            };

            btnUndo.MouseEnter += (s, e) => { btnUndo.BackColor = Color.FromArgb(211, 84, 0); };
            btnUndo.MouseLeave += (s, e) => { btnUndo.BackColor = Color.FromArgb(230, 126, 34); };

            btnBrowseSource.MouseEnter += (s, e) => { btnBrowseSource.BackColor = Color.FromArgb(41, 128, 185); };
            btnBrowseSource.MouseLeave += (s, e) => { btnBrowseSource.BackColor = Color.FromArgb(52, 152, 219); };

            btnBrowseDestination.MouseEnter += (s, e) => {
                if (btnBrowseDestination.Enabled)
                    btnBrowseDestination.BackColor = Color.FromArgb(41, 128, 185);
            };
            btnBrowseDestination.MouseLeave += (s, e) => {
                if (btnBrowseDestination.Enabled)
                    btnBrowseDestination.BackColor = Color.FromArgb(52, 152, 219);
            };
        }

        private void ConfigureDataGridView()
        {
            dgvPreview.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 249, 250);
            dgvPreview.RowTemplate.Height = 28;
            dgvPreview.DefaultCellStyle.Padding = new Padding(5, 3, 5, 3);
            dgvPreview.DefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dgvPreview.DefaultCellStyle.SelectionForeColor = Color.White;
        }

        private void UpdateStatusLabel(string message, bool isError = false)
        {
            toolStripStatusLabel.Text = message;
            toolStripStatusLabel.ForeColor = isError ?
                Color.FromArgb(231, 76, 60) :
                Color.FromArgb(73, 80, 87);
        }

        private void ShowProgress(bool show, int value = 0, int maximum = 100)
        {
            progressBar.Visible = show;
            toolStripProgressBar.Visible = show;

            if (show)
            {
                progressBar.Value = Math.Min(value, maximum);
                progressBar.Maximum = maximum;
                toolStripProgressBar.Value = Math.Min(value, maximum);
                toolStripProgressBar.Maximum = maximum;
            }
        }

        private void UpdatePreviewCount(int count)
        {
            lblPreviewCount.Text = count == 0 ? "0 files to process" :
                                  count == 1 ? "1 file to process" :
                                  $"{count:N0} files to process";

            lblPreviewCount.ForeColor = count > 0 ?
                Color.FromArgb(46, 204, 113) :
                Color.FromArgb(149, 165, 166);
        }

        private void ClearPreview()
        {
            dgvPreview.DataSource = null;
            dgvPreview.Rows.Clear();
            UpdatePreviewCount(0);
            btnRun.Enabled = false;
            UpdateStatusLabel("Preview cleared");
        }

        private bool ValidateSettings()
        {
            if (string.IsNullOrWhiteSpace(txtSource.Text))
            {
                MessageBox.Show("Please select a source folder.", "Validation Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSource.Focus();
                return false;
            }

            if (!Directory.Exists(txtSource.Text))
            {
                MessageBox.Show("Source folder does not exist.", "Validation Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSource.Focus();
                return false;
            }

            if (chkUseSeparateDestination.Checked)
            {
                if (string.IsNullOrWhiteSpace(txtDestination.Text))
                {
                    MessageBox.Show("Please select a destination folder.", "Validation Error",
                                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDestination.Focus();
                    return false;
                }

                if (!Directory.Exists(txtDestination.Text))
                {
                    MessageBox.Show("Destination folder does not exist.", "Validation Error",
                                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDestination.Focus();
                    return false;
                }
            }

            return true;
        }

        private void SetControlEnabled(Control control, bool enabled)
        {
            control.Enabled = enabled;

            if (enabled)
            {
                control.ForeColor = SystemColors.ControlText;
                if (control is Button btn)
                {
                    btn.BackColor = Color.FromArgb(52, 152, 219);
                    btn.ForeColor = Color.White;
                }
            }
            else
            {
                control.ForeColor = SystemColors.GrayText;
                if (control is Button btn)
                {
                    btn.BackColor = Color.FromArgb(189, 195, 199);
                    btn.ForeColor = Color.FromArgb(127, 140, 141);
                }
            }
        }

        private string GetTargetPath(FileInfo fileInfo)
        {
            string baseDestination = chkUseSeparateDestination.Checked ?
                txtDestination.Text :
                txtSource.Text;

            if (rbByType.Checked)
            {
                string extension = fileInfo.Extension.TrimStart('.');
                if (string.IsNullOrEmpty(extension))
                    extension = "No Extension";
                return Path.Combine(baseDestination, extension.ToUpper());
            }
            else if (rbByDate.Checked)
            {
                return Path.Combine(baseDestination, fileInfo.LastWriteTime.ToString("yyyy-MM"));
            }
            else if (rbBySize.Checked)
            {
                string sizeCategory = GetSizeCategory(fileInfo.Length);
                return Path.Combine(baseDestination, sizeCategory);
            }

            return baseDestination;
        }

        private string GetSizeCategory(long bytes)
        {
            const long KB = 1024;
            const long MB = KB * 1024;
            const long GB = MB * 1024;

            if (bytes < MB)
                return "Small (< 1 MB)";
            else if (bytes < 100 * MB)
                return "Medium (1-100 MB)";
            else if (bytes < GB)
                return "Large (100 MB - 1 GB)";
            else
                return "Very Large (> 1 GB)";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (dgvPreview.Columns.Count == 0)
            {
                dgvPreview.Columns.Add("FileName", "File Name");
                dgvPreview.Columns.Add("SourcePath", "Source Path");
                dgvPreview.Columns.Add("TargetFolder", "Target Folder");
                dgvPreview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dgvPreview.Columns[0].FillWeight = 30;
                dgvPreview.Columns[1].FillWeight = 40;
                dgvPreview.Columns[2].FillWeight = 30;
            }

            SetupUI();
            UpdateStatusLabel("Ready to organize files");
        }

        private void btnBrowseSource_Click(object sender, EventArgs e)
        {
            folderBrowser.Description = "Select the source folder containing files to organize:";
            folderBrowser.ShowNewFolderButton = false;

            if (!string.IsNullOrWhiteSpace(txtSource.Text) && Directory.Exists(txtSource.Text))
            {
                folderBrowser.SelectedPath = txtSource.Text;
            }

            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                txtSource.Text = folderBrowser.SelectedPath;
                UpdateStatusLabel($"Source selected: {Path.GetFileName(folderBrowser.SelectedPath)}");
                ClearPreview();
            }
        }

        private void btnBrowseDestination_Click(object sender, EventArgs e)
        {
            folderBrowser.Description = "Select the destination folder for organized files:";
            folderBrowser.ShowNewFolderButton = true;

            if (!string.IsNullOrWhiteSpace(txtDestination.Text) && Directory.Exists(txtDestination.Text))
            {
                folderBrowser.SelectedPath = txtDestination.Text;
            }

            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                txtDestination.Text = folderBrowser.SelectedPath;
                UpdateStatusLabel($"Destination selected: {Path.GetFileName(folderBrowser.SelectedPath)}");
                ClearPreview();
            }
        }

        private void chkUseSeparateDestination_CheckedChanged(object sender, EventArgs e)
        {
            bool useCustomDestination = chkUseSeparateDestination.Checked;

            SetControlEnabled(lblDestination, useCustomDestination);
            SetControlEnabled(txtDestination, useCustomDestination);
            SetControlEnabled(btnBrowseDestination, useCustomDestination);

            if (!useCustomDestination)
            {
                txtDestination.Clear();
            }

            UpdateStatusLabel(useCustomDestination ?
                "Custom destination enabled" :
                "Using source folder as destination");

            ClearPreview();
        }

        private void chkDryRun_CheckedChanged(object sender, EventArgs e)
        {
            bool isDryRun = chkDryRun.Checked;

            btnRun.Text = isDryRun ? "Execute Preview" : "Execute (LIVE)";
            btnRun.BackColor = isDryRun ?
                Color.FromArgb(46, 204, 113) :
                Color.FromArgb(231, 76, 60);

            UpdateStatusLabel(isDryRun ?
                "Safe mode: Preview only" :
                "LIVE mode: Changes will be made!");
        }

        private void chkIncludeSubfolders_CheckedChanged(object sender, EventArgs e)
        {
            UpdateStatusLabel(chkIncludeSubfolders.Checked ?
                "Including subfolders in search" :
                "Searching top-level folder only");

            ClearPreview();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (!ValidateSettings()) return;

            UpdateStatusLabel("Scanning files...");
            ShowProgress(true, 0, 100);
            dgvPreview.Rows.Clear();

            try
            {
                string[] files = Directory.GetFiles(
                    txtSource.Text,
                    "*",
                    chkIncludeSubfolders.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly
                );

                ShowProgress(true, 25, 100);
                UpdateStatusLabel($"Found {files.Length} files. Analyzing organization...");

                var groupedFiles = new Dictionary<string, List<FileInfo>>();
                var processedFiles = new List<(FileInfo file, string targetFolder)>();

                for (int i = 0; i < files.Length; i++)
                {
                    FileInfo fi = new FileInfo(files[i]);
                    string targetFolder = GetTargetPath(fi);

                    processedFiles.Add((fi, targetFolder));

                    if (!groupedFiles.ContainsKey(targetFolder))
                        groupedFiles[targetFolder] = new List<FileInfo>();
                    groupedFiles[targetFolder].Add(fi);

                    if (i % 10 == 0)
                    {
                        int progress = 25 + (int)((double)i / files.Length * 50);
                        ShowProgress(true, progress, 100);
                        Application.DoEvents();
                    }
                }

                ShowProgress(true, 75, 100);
                UpdateStatusLabel("Populating preview...");

                foreach (var (file, targetFolder) in processedFiles)
                {
                    var row = dgvPreview.Rows.Add(file.Name, file.FullName, targetFolder);

                    if (file.Length > 100 * 1024 * 1024)
                    {
                        dgvPreview.Rows[row].DefaultCellStyle.BackColor = Color.FromArgb(255, 248, 220);
                    }
                }

                ShowProgress(true, 100, 100);

                string summary = $"Found {files.Length} files";
                if (groupedFiles.Count > 0)
                {
                    summary += $" -> Will create {groupedFiles.Count} folder(s)";
                }

                UpdateStatusLabel(summary);
                UpdatePreviewCount(files.Length);
                btnRun.Enabled = files.Length > 0;

                ShowProgress(false);
            }
            catch (Exception ex)
            {
                ShowProgress(false);
                UpdateStatusLabel($"Error during preview: {ex.Message}", true);
                MessageBox.Show($"Error scanning files: {ex.Message}", "Preview Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (!ValidateSettings()) return;

            if (!chkDryRun.Checked)
            {
                var result = MessageBox.Show(
                    $"This will {(chkCopyInsteadOfMove.Checked ? "copy" : "move")} {dgvPreview.Rows.Count} files to organized folders.\n\n" +
                    "Are you sure you want to continue?",
                    "Confirm File Organization",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result != DialogResult.Yes) return;
            }

            history.Clear();
            int processedCount = 0;
            int errorCount = 0;

            UpdateStatusLabel(chkDryRun.Checked ? "Simulating organization..." : "Organizing files...");
            ShowProgress(true, 0, dgvPreview.Rows.Count);

            foreach (DataGridViewRow row in dgvPreview.Rows)
            {
                if (row.IsNewRow) continue;

                string sourcePath = row.Cells[1].Value.ToString();
                string targetFolder = row.Cells[2].Value.ToString();
                string fileName = row.Cells[0].Value.ToString();
                string targetPath = Path.Combine(targetFolder, fileName);

                try
                {
                    if (!chkDryRun.Checked && !Directory.Exists(targetFolder))
                        Directory.CreateDirectory(targetFolder);

                    if (chkDryRun.Checked)
                    {
                        row.DefaultCellStyle.BackColor = Color.FromArgb(212, 237, 218);
                        processedCount++;
                    }
                    else
                    {
                        if (chkCopyInsteadOfMove.Checked)
                        {
                            File.Copy(sourcePath, targetPath, true);
                            history.Add((targetPath, sourcePath));
                            row.DefaultCellStyle.BackColor = Color.FromArgb(217, 237, 247);
                        }
                        else
                        {
                            File.Move(sourcePath, targetPath);
                            history.Add((targetPath, sourcePath));
                            row.DefaultCellStyle.BackColor = Color.FromArgb(212, 237, 218);
                        }
                        processedCount++;
                    }
                }
                catch (Exception ex)
                {
                    errorCount++;
                    row.DefaultCellStyle.BackColor = Color.FromArgb(248, 215, 218);
                    UpdateStatusLabel($"Error processing {fileName}: {ex.Message}", true);
                    MessageBox.Show($"Error processing file {fileName}: {ex.Message}", "Processing Error",
                                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                ShowProgress(true, processedCount + errorCount, dgvPreview.Rows.Count);
                Application.DoEvents();
            }

            ShowProgress(false);

            string resultMessage = chkDryRun.Checked ?
                $"Preview completed: {processedCount} files would be organized" :
                $"Operation completed: {processedCount} files organized";

            if (errorCount > 0)
                resultMessage += $", {errorCount} errors";

            UpdateStatusLabel(resultMessage, errorCount > 0);
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            if (history.Count == 0)
            {
                UpdateStatusLabel("Nothing to undo", true);
                MessageBox.Show("Nothing to undo.", "Undo Operation",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var result = MessageBox.Show(
                $"This will restore {history.Count} files to their original locations.\n\n" +
                "Are you sure you want to continue?",
                "Confirm Undo Operation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes) return;

            UpdateStatusLabel("Undoing last operation...");
            ShowProgress(true, 0, history.Count);

            int undoCount = 0;
            int errorCount = 0;

            foreach (var entry in history)
            {
                try
                {
                    if (chkCopyInsteadOfMove.Checked)
                    {
                        if (File.Exists(entry.Source))
                        {
                            File.Delete(entry.Source);
                            undoCount++;
                        }
                    }
                    else
                    {
                        if (File.Exists(entry.Source))
                        {
                            string folder = Path.GetDirectoryName(entry.Destination);
                            if (!Directory.Exists(folder))
                                Directory.CreateDirectory(folder);

                            File.Move(entry.Source, entry.Destination);
                            undoCount++;
                        }
                    }
                }
                catch (Exception ex)
                {
                    errorCount++;
                    UpdateStatusLabel($"Undo failed for {Path.GetFileName(entry.Source)}: {ex.Message}", true);
                }

                ShowProgress(true, undoCount + errorCount, history.Count);
                Application.DoEvents();
            }

            history.Clear();
            ShowProgress(false);
            ClearPreview();

            string undoMessage = $"Undo completed: {undoCount} files restored";
            if (errorCount > 0)
                undoMessage += $", {errorCount} errors";

            UpdateStatusLabel(undoMessage, errorCount > 0);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearPreview();
            txtSource.Clear();
            if (chkUseSeparateDestination.Checked)
                txtDestination.Clear();

            UpdateStatusLabel("Form cleared - Ready for new operation");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var aboutForm = new AboutForm())
            {
                aboutForm.ShowDialog(this);
            }
        }

        private void dgvPreview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string path = dgvPreview.Rows[e.RowIndex].Cells[1].Value?.ToString();
                if (!string.IsNullOrEmpty(path) && File.Exists(path))
                {
                    try
                    {
                        System.Diagnostics.Process.Start("explorer.exe", $"/select,\"{path}\"");
                        UpdateStatusLabel($"Opened location for: {Path.GetFileName(path)}");
                    }
                    catch (Exception ex)
                    {
                        UpdateStatusLabel($"Could not open file location: {ex.Message}", true);
                    }
                }
            }
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            string detailedStatus = $"Current Status: {toolStripStatusLabel.Text}\n" +
                                   $"Files in Preview: {dgvPreview.Rows.Count}\n" +
                                   $"History Entries: {history.Count}\n" +
                                   $"Dry Run Mode: {(chkDryRun.Checked ? "Enabled" : "Disabled")}";

            MessageBox.Show(detailedStatus, "Status Information",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void a_CheckedChanged(object sender, EventArgs e)
        {
            ClearPreview();

            if (rbByDate.Checked)
                UpdateStatusLabel("Organizing by date (YYYY-MM format)");
            else if (rbByType.Checked)
                UpdateStatusLabel("Organizing by file type");
            else if (rbBySize.Checked)
                UpdateStatusLabel("Organizing by file size categories");
        }

        private void progressBar_Click(object sender, EventArgs e)
        {
            if (progressBar.Visible)
            {
                MessageBox.Show($"Progress: {progressBar.Value}/{progressBar.Maximum} " +
                               $"({(double)progressBar.Value / progressBar.Maximum * 100:F1}%)",
                               "Progress Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}