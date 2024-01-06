using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using PdfSharp.Drawing;
using PdfSharp.Pdf;

namespace Binder.Tabs
{
    public partial class Home : UserControl
    {
        private List<ImageInfo> selectedImages = new List<ImageInfo>();
        private BackgroundWorker backgroundWorker;

        public Home()
        {
            InitializeComponent();
            ConfigureDataGridView();
            InitializeBackgroundWorker();
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

            UpdateDataGridView();
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

                selectedImages.RemoveAll(img => img.ImageName == Path.GetFileName(imagePath));

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
            foreach (DataGridViewRow row in imagelist.SelectedRows)
            {
                if (row.Cells["ImageId"].Value is int imageId)
                {
                    selectedImages.RemoveAll(image => image.ImageId == imageId);
                }
            }

            UpdateDataGridView();

            if (selectedImages.Count == 0)
            {
                ShowDefaultImage();
            }
        }

        private void ClearDataGridViewButton_Click(object sender, EventArgs e)
        {
            selectedImages.Clear();
            UpdateDataGridView();
            ShowDefaultImage();
        }

        private void BindToPdfButton_Click(object sender, EventArgs e)
        {
            if (selectedImages.Any())
            {
                using (var saveDialog = new SaveFileDialog())
                {
                    saveDialog.Filter = "PDF files|*.pdf";
                    saveDialog.Title = "Save PDF File";

                    if (saveDialog.ShowDialog() == DialogResult.OK)
                    {
                        string outputPdfPath = saveDialog.FileName;

                        DisableButtons();

                        progressBar.Minimum = 0;
                        progressBar.Maximum = selectedImages.Count;
                        progressBar.Value = 0;

                        string[] imagePaths = selectedImages.Select(img => img.ImagePath).ToArray();

                        backgroundWorker.RunWorkerAsync(new Tuple<string[], string>(imagePaths, outputPdfPath));
                    }
                }
            }
            else
            {
                MessageBox.Show("No images selected. Please select images first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            Tuple<string[], string> arguments = e.Argument as Tuple<string[], string>;

            string[] imagePaths = arguments.Item1;
            string outputPdfPath = arguments.Item2;

            ConvertImagesToPdf(selectedImages, outputPdfPath, worker, e);
        }

        private void BackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
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
        }

        private void DisableButtons()
        {
            sfolder.Enabled = false;
            sf.Enabled = false;
            dsf.Enabled = false;
            cl.Enabled = false;
            bind.Enabled = false;
        }

        private void EnableButtons()
        {
            sfolder.Enabled = true;
            sf.Enabled = true;
            dsf.Enabled = true;
            cl.Enabled = true;
            bind.Enabled = true;
        }

        private void UpdateDataGridView()
        {
            imagelist.DataSource = null;
            imagelist.DataSource = selectedImages;
            imagelist.Columns["ImagePath"].Visible = false;
        }


        private void imagelist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (imagelist.Rows.Count > 0 && e.RowIndex >= 0 && e.RowIndex < imagelist.Rows.Count)
            {
                DataGridViewRow selectedRow = imagelist.Rows[e.RowIndex];
                if (selectedRow.Cells["ImagePath"].Value is string imagePath)
                {
                    ResizeImageAndShowPreview(imagePath);
                }
            }
            else
            {
                ShowDefaultImage();
            }
        }

        private void ShowDefaultImage()
        {
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

        private void ConvertImagesToPdf(List<ImageInfo> images, string outputPdfPath, BackgroundWorker worker, DoWorkEventArgs e)
        {
            using (PdfDocument pdf = new PdfDocument())
            {
                for (int i = 0; i < images.Count; i++)
                {
                    ImageInfo imageInfo = images[i];

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
                        }
                    }
                    catch (Exception ex)
                    {
                        if (ex.Message.Contains("Unsupported file format"))
                        {
                            DialogResult result = MessageBox.Show($"Error processing image '{imageInfo.ImagePath}': {ex.Message}\nDo you want to rename the file and continue?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                            if (result == DialogResult.Yes)
                            {
                                RenameFile(imageInfo.ImagePath);

                                i--;
                                continue;
                            }
                            else
                            {
                                worker.CancelAsync();
                                break;
                            }
                        }
                        else
                        {
                            MessageBox.Show($"Error processing image '{imageInfo.ImagePath}': {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    int progressPercentage = (i + 1) * 100 / images.Count;
                    worker.ReportProgress(progressPercentage);
                }

                if (!worker.CancellationPending)
                {
                    pdf.Save(outputPdfPath);
                }
            }
        }

        private void RenameFile(string imagePath)
        {
            try
            {
                string directory = Path.GetDirectoryName(imagePath);
                string fileNameWithoutDots = Path.GetFileNameWithoutExtension(imagePath).Replace(".", string.Empty);
                string newFileName = fileNameWithoutDots + Path.GetExtension(imagePath);

                string newPath = Path.Combine(directory, newFileName);

                selectedImages.RemoveAll(img => img.ImageName == Path.GetFileName(imagePath));

                File.Move(imagePath, newPath);

                var imageInfo = new ImageInfo
                {
                    ImageId = selectedImages.Count + 1,
                    ImageName = newFileName,
                    ImageExtension = Path.GetExtension(newFileName),
                    ImageSize = new FileInfo(newPath).Length,
                    ImagePath = newPath
                };
                selectedImages.Add(imageInfo);

                UpdateDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error renaming file '{imagePath}': {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}