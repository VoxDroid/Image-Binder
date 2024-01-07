using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using PdfSharp.Drawing;
using PdfSharp.Pdf;

namespace Binder.Tabs
{
    public partial class Home : UserControl
    {
        private BindingList<ImageInfo> selectedImages = new BindingList<ImageInfo>();
        private BackgroundWorker backgroundWorker;
        private CancellationTokenSource cancellationTokenSource;

        public Home()
        {
            InitializeComponent();
            ConfigureDataGridView();
            InitializeBackgroundWorker();
        }

        private void UpdateTotalImagesProgressBarText()
        {
            progressBar.Text = $"Total Images to Bind: {selectedImages.Count}";
        }

        private void InitializeBackgroundWorker()
        {
            backgroundWorker = new BackgroundWorker
            {
                WorkerReportsProgress = true,
                WorkerSupportsCancellation = true
            };

            backgroundWorker.DoWork += BackgroundWorker_DoWork;
            backgroundWorker.ProgressChanged += BackgroundWorker_ProgressChanged;
            backgroundWorker.RunWorkerCompleted += BackgroundWorker_RunWorkerCompleted;
        }

        private void SelectFoldersButton_Click(object sender, EventArgs e)
        {
            using (var folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.Description = "Select Folders";
                folderBrowserDialog.ShowNewFolderButton = false;

                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFolder = folderBrowserDialog.SelectedPath;

                    string[] imagePaths = Directory.GetFiles(selectedFolder, "*.*", SearchOption.AllDirectories)
                                    .Where(s => s.EndsWith(".png", StringComparison.OrdinalIgnoreCase) ||
                                                s.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase) ||
                                                s.EndsWith(".jpeg", StringComparison.OrdinalIgnoreCase))
                                    .Select(s => s.ToLower())
                                    .ToArray();

                    ProcessImages(imagePaths);
                }
            }
        }

        private void SelectFilesButton_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Multiselect = true;
                openFileDialog.Filter = "Image files|*.png;*.jpg;*.jpeg";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string[] imagePaths = openFileDialog.FileNames;

                    ProcessImages(imagePaths);
                }
            }
        }

        private void ProcessImages(string[] imagePaths)
        {
            foreach (string imagePath in imagePaths)
            {
                FileInfo fileInfo = new FileInfo(imagePath);
                string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(fileInfo.Name);

                if (fileNameWithoutExtension.Contains('.'))
                {
                    DialogResult result = MessageBox.Show($"The base file name '{fileNameWithoutExtension}' contains multiple dots. Do you want to rename the file?", "Rename File", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        RenameFileAndAddToList(imagePath);
                    }
                    else
                    {
                        MessageBox.Show($"Skipping file '{fileInfo.Name}'.", "Skipped File", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    AddFileToList(imagePath);
                }
            }
            SortImages();
            UpdateTotalImagesProgressBarText();
            UpdateDataGridView();
        }

        private void SortImages()
        {
            switch (currentSortOption)
            {
                case SortOption.ImageId:
                    selectedImages = new BindingList<ImageInfo>(selectedImages.OrderBy(img => img.ImageId).ToList());
                    break;

                case SortOption.ImageName:
                    selectedImages = new BindingList<ImageInfo>(selectedImages.OrderBy(img => img.ImageName).ToList());
                    break;


                default:
                    break;
            }
        }

        private SortOption currentSortOption = SortOption.ImageId;
        private enum SortOption
        {
            ImageId,
            ImageName
        }

        private void AddFileToList(string imagePath)
        {
            FileInfo fileInfo = new FileInfo(imagePath);
            ImageInfo imageInfo = new ImageInfo
            {
                ImageId = selectedImages.Count + 1,
                ImageName = fileInfo.Name,
                ImageExtension = fileInfo.Extension,
                ImageSize = fileInfo.Length,
                ImagePath = imagePath
            };

            selectedImages.Add(imageInfo);
        }

        private void RenameFileAndAddToList(string imagePath)
        {
            try
            {
                string directory = Path.GetDirectoryName(imagePath);
                string fileNameWithoutDots = Path.GetFileNameWithoutExtension(imagePath).Replace(".", string.Empty);
                string newFileName = fileNameWithoutDots + Path.GetExtension(imagePath);

                string newPath = Path.Combine(directory, newFileName);

                selectedImages = new BindingList<ImageInfo>(selectedImages.Where(img => img.ImageName != Path.GetFileName(imagePath)).ToList()); 

                File.Move(imagePath, newPath);

                AddFileToList(newPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error renaming file '{imagePath}': {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteSelectedFilesButton_Click(object sender, EventArgs e)
        {
            if (imagelist.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to remove the selected files from the list?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    DeleteSelectedFiles();
                }
            }
            else
            {
                MessageBox.Show("No files selected for removal.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void ClearDataGridViewButton_Click(object sender, EventArgs e)
        {
            if (selectedImages.Any())
            {
                DialogResult result = MessageBox.Show("Are you sure you want to clear the list?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    ClearDataGridView();
                }
            }
            else
            {
                MessageBox.Show("No images to clear.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ClearDataGridView()
        {
            selectedImages.Clear();
            UpdateDataGridView();
            ShowDefaultImage();
            UpdateTotalImagesProgressBarText();
        }

        private void DeleteSelectedFiles()
        {
            foreach (DataGridViewRow row in imagelist.SelectedRows)
            {
                if (row.Cells["ImageId"].Value is int imageId)
                {
                    selectedImages = new BindingList<ImageInfo>(selectedImages.Where(image => image.ImageId != imageId).ToList());
                }
            }

            UpdateTotalImagesProgressBarText();
            UpdateDataGridView();



            if (selectedImages.Count == 0)
            {
                ShowDefaultImage();
            }
        }

        private void BindToPdfButton_Click(object sender, EventArgs e)
        {
            if (selectedImages.Any())
            {
                if (backgroundWorker.IsBusy)
                {
                    MessageBox.Show("A process is already running. Please wait for it to complete or abort it.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                using (var saveDialog = new SaveFileDialog())
                {
                    saveDialog.Filter = "PDF files|*.pdf";
                    saveDialog.Title = "Save PDF File";

                    saveDialog.FileName = $"binder_{DateTime.Now:yyyyMMdd_HHmmss}_{selectedImages.Count}";

                    if (saveDialog.ShowDialog() == DialogResult.OK)
                    {
                        string outputPdfPath = saveDialog.FileName;

                        DisableButtons();

                        progressBar.Minimum = 0;
                        progressBar.Maximum = 100;
                        progressBar.Value = 0;

                        string[] imagePaths;

                        if (bo1.Checked)
                        {
                            SortImagesByImageId();
                        }
                        else if (bo2.Checked)
                        {
                            SortImagesByImageName();
                        }

                        imagePaths = selectedImages.Select(img => img.ImagePath).ToArray();

                        cancellationTokenSource = new CancellationTokenSource();

                        backgroundWorker.RunWorkerAsync(new Tuple<string[], string, CancellationToken>(imagePaths, outputPdfPath, cancellationTokenSource.Token));
                    }
                }
            }
            else
            {
                MessageBox.Show("No images selected. Please select images first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SortImagesByImageId()
        {
            selectedImages = new BindingList<ImageInfo>(selectedImages.OrderBy(img => img.ImageId).ToList());
            UpdateDataGridView();
        }

        private void SortImagesByImageName()
        {
            selectedImages = new BindingList<ImageInfo>(selectedImages.OrderBy(img => img.ImageName).ToList());
            UpdateDataGridView();
        }

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            Tuple<string[], string, CancellationToken> arguments = e.Argument as Tuple<string[], string, CancellationToken>;

            string[] imagePaths = arguments.Item1;
            string outputPdfPath = arguments.Item2;
            CancellationToken cancellationToken = arguments.Item3;

            ConvertImagesToPdf(selectedImages.ToList(), outputPdfPath, worker, e, cancellationToken);
        }

        private void BackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;

            if (e.UserState is string progressText)
            {
                progressBar.Text = progressText;
            }
        }

        private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {

            }
            else if (e.Error != null)
            {
                MessageBox.Show($"Error during processing: {e.Error.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("PDF created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            progressBar.Value = 0;
            EnableButtons();
            UpdateTotalImagesProgressBarText();
        }

        private void DisableButtons()
        {
            sfolder.Enabled = false;
            sf.Enabled = false;
            dsf.Enabled = false;
            cl.Enabled = false;
            bind.Enabled = false;
            bo1.Enabled = false;
            bo2.Enabled = false;
            abort.Enabled = true;
        }

        private void EnableButtons()
        {
            sfolder.Enabled = true;
            sf.Enabled = true;
            dsf.Enabled = true;
            cl.Enabled = true;
            bind.Enabled = true;
            bo1.Enabled = true;
            bo2.Enabled = true;
            abort.Enabled = false;
        }

        private void UpdateDataGridView()
        {
            imagelist.DataSource = null;
            imagelist.DataSource = selectedImages;
            imagelist.Columns["ImagePath"].Visible = false;
        }


        private void imagelist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (imagelist.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection != SortOrder.None)
                {
                    return;
                }

                DataGridViewRow selectedRow = imagelist.Rows[e.RowIndex];
                if (selectedRow.Cells["ImagePath"].Value is string imagePath)
                {
                    ResizeImageAndShowPreview(imagePath);
                    currentlyDisplayedImagePath = imagePath;
                }
            }
            else
            {
                ShowDefaultImage();
            }
        }

        private string currentlyDisplayedImagePath;

        private void ShowDefaultImage()
        {
            currentlyDisplayedImagePath = null;

            preview.BackgroundImageLayout = ImageLayout.Stretch;
            preview.BackgroundImage = Properties.Resources.stripes;
        }

        private void ResizeImageAndShowPreview(string imagePath)
        {
            ShowImagePreview(imagePath);
            UpdateDataGridView();
        }

        private void ShowImagePreview(string imagePath)
        {
            try
            {
                System.Drawing.Image image;

                if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                {
                    image = System.Drawing.Image.FromFile(imagePath);
                }
                else
                {
                    preview.BackgroundImageLayout = ImageLayout.Stretch;
                    image = Properties.Resources.stripes;
                }

                preview.BackgroundImageLayout = ImageLayout.Zoom;
                preview.BackgroundImage = image;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConvertImagesToPdf(List<ImageInfo> images, string outputPdfPath, BackgroundWorker worker, DoWorkEventArgs e, CancellationToken cancellationToken)
        {
            using (PdfDocument pdf = new PdfDocument())
            {

                int totalImages = images.Count;

                for (int i = 0; i < totalImages; i++)
                {
                    ImageInfo imageInfo = images[i];
                    string imageName = Path.GetFileName(imageInfo.ImagePath);

                    try
                    {
                        string lowerCaseExtension = imageInfo.ImageExtension.ToLower();
                        imageInfo.ImagePath = Path.ChangeExtension(imageInfo.ImagePath, lowerCaseExtension);

                        using (XImage image = GetImage(imageInfo.ImagePath))
                        {
                            if (image != null)  
                            {
                                PdfPage page = pdf.AddPage();
                                page.Width = image.PointWidth;
                                page.Height = image.PointHeight;

                                XGraphics gfx = XGraphics.FromPdfPage(page);
                                gfx.DrawImage(image, 0, 0);
                            }

                            if (cancellationToken.IsCancellationRequested)
                            {
                                e.Cancel = true;
                                return;
                            }
                        }

                        Thread.Sleep(50);

                        int progressPercentage = (i + 1) * 100 / totalImages;
                        string progressText = $"{imageName} {i + 1}/{totalImages}";

                        worker.ReportProgress(progressPercentage, progressText);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error processing image '{imageName}': {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                worker.ReportProgress(100, $"Completed {totalImages}/{totalImages}");

                if (!worker.CancellationPending)
                {
                    pdf.Save(outputPdfPath);
                }
            }
        }

        private XImage GetImage(string imagePath)
        {
            try
            {
                using (FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                {
                    return XImage.FromStream(fs);
                }
            }
            catch (InvalidOperationException ex)
            {
                throw new ApplicationException($"Error loading image '{imagePath}': {ex.Message}", ex);
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Error loading image '{imagePath}': {ex.Message}", ex);
            }
        }

        private void ConfigureDataGridView()
        {
            imagelist.AutoGenerateColumns = false;

            imagelist.Columns["ImageId"].DataPropertyName = "ImageId";
            imagelist.Columns["ImageName"].DataPropertyName = "ImageName";
            imagelist.Columns["ImageExtension"].DataPropertyName = "ImageExtension";
            imagelist.Columns["ImageSize"].DataPropertyName = "ImageSize";
            imagelist.Columns["ImagePath"].DataPropertyName = "ImagePath";

            foreach (DataGridViewColumn column in imagelist.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Automatic;
            }

            imagelist.DataSource = selectedImages;

            imagelist.CellClick += imagelist_CellClick;
        }

        private void imagelist_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == imagelist.Columns["ImageSize"].Index)
            {
                long fileSize = (long)e.Value;
                string fileSizeFormatted = FormatFileSize(fileSize);
                e.Value = fileSizeFormatted;
                e.FormattingApplied = true;
            }
        }

        private string FormatFileSize(long fileSizeInBytes)
        {
            const long KB = 1024;
            double fileSizeInKB = (double)fileSizeInBytes / KB;
            return $"{fileSizeInKB:F2} KB";
        }

        public class ImageInfo
        {
            public int ImageId { get; set; }
            public string ImageName { get; set; }
            public string ImageExtension { get; set; }
            public long ImageSize { get; set; }
            public string ActionButton { get; set; }
            public string ImagePath { get; set; }
        }

        private void bo2_CheckedChanged(object sender, EventArgs e)
        {
            if (bo2.Checked)
            {
                currentSortOption = SortOption.ImageName;
                SortImages();
                UpdateDataGridView();
            }
        }

        private void bo1_CheckedChanged(object sender, EventArgs e)
        {
            if (bo1.Checked)
            {
                currentSortOption = SortOption.ImageId;
                SortImages();
                UpdateDataGridView();
            }
        }

        private void abort_Click(object sender, EventArgs e)
        {
            if (backgroundWorker.IsBusy)
            {
                DialogResult result = MessageBox.Show("Do you want to abort the current process?", "Abort Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    cancellationTokenSource?.Cancel();
                }
            }
        }

        private void bindoption1_Click(object sender, EventArgs e)
        {
            bo1.Checked = true;
        }

        private void bindoption2_Click(object sender, EventArgs e)
        {
            bo2.Checked = true;
        }

        private void preview_DoubleClick(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentlyDisplayedImagePath) && imagelist.SelectedRows.Count > 0)
            {
                if (imagelist.SelectedRows[0].Cells["ImagePath"].Value is string selectedImagePath)
                {
                    if (currentlyDisplayedImagePath == selectedImagePath)
                    {
                        if (!IsDefaultImage(currentlyDisplayedImagePath))
                        {
                            ShowOriginalImage(currentlyDisplayedImagePath);
                        }
                    }
                }
            }
        }


        private void ShowOriginalImage(string imagePath)
        {
            try
            {
                if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                {
                    System.Diagnostics.Process.Start(imagePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening original image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsDefaultImage(string imagePath)
        {
            return imagePath == null || !File.Exists(imagePath) || Path.GetFileName(imagePath) == "stripes";
        }
    }
}