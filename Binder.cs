using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using PdfSharp.Drawing;
using PdfSharp.Pdf;

namespace Binder
{
    public partial class Binder : Form
    {
        private List<ImageInfo> selectedImages = new List<ImageInfo>();

        public Binder()
        {
            InitializeComponent();
            ConfigureDataGridView();
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
                                                   .ToArray();

                    foreach (string imagePath in imagePaths)
                    {
                        FileInfo fileInfo = new FileInfo(imagePath);
                        selectedImages.Add(new ImageInfo
                        {
                            ImageId = selectedImages.Count + 1,
                            ImageName = fileInfo.Name,
                            ImageExtension = fileInfo.Extension,
                            ImageSize = fileInfo.Length,
                            ImagePath = imagePath
                        });
                    }

                    UpdateDataGridView();
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
                    foreach (string filePath in openFileDialog.FileNames)
                    {
                        FileInfo fileInfo = new FileInfo(filePath);
                        selectedImages.Add(new ImageInfo
                        {
                            ImageId = selectedImages.Count + 1,
                            ImageName = fileInfo.Name,
                            ImageExtension = fileInfo.Extension,
                            ImageSize = fileInfo.Length,
                            ImagePath = filePath
                        });
                    }

                    UpdateDataGridView();
                }
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
        }

        private void ClearDataGridViewButton_Click(object sender, EventArgs e)
        {
            selectedImages.Clear();
            UpdateDataGridView();
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

                        progressBar.Minimum = 0;
                        progressBar.Maximum = selectedImages.Count;
                        progressBar.Value = 0;

                        ConvertImagesToPdf(selectedImages, outputPdfPath);

                        MessageBox.Show("PDF created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        progressBar.Value = 0;
                    }
                }
            }
            else
            {
                MessageBox.Show("No images selected. Please select images first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UpdateDataGridView()
        {
            imagelist.DataSource = null;
            imagelist.DataSource = selectedImages;
            imagelist.Columns["ImagePath"].Visible = false;
        }

        private void imagelist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < imagelist.Rows.Count)
            {
                DataGridViewRow selectedRow = imagelist.Rows[e.RowIndex];
                if (selectedRow.Cells["ImagePath"].Value is string imagePath)
                {
                    ResizeImageAndShowPreview(imagePath);
                }
            }


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
                System.Drawing.Image image = System.Drawing.Image.FromFile(imagePath);
                preview.BackgroundImageLayout = ImageLayout.Zoom;
                preview.BackgroundImage = image;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ConvertImagesToPdf(List<ImageInfo> images, string outputPdfPath)
        {
            using (PdfDocument pdf = new PdfDocument())
            {
                for (int i = 0; i < images.Count; i++)
                {
                    ImageInfo imageInfo = images[i];

                    try
                    {
                        using (XImage image = XImage.FromFile(imageInfo.ImagePath))
                        {
                            PdfPage page = pdf.AddPage();
                            page.Width = image.PointWidth;
                            page.Height = image.PointHeight;

                            XGraphics gfx = XGraphics.FromPdfPage(page);
                            gfx.DrawImage(image, 0, 0);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error processing image: {ex.Message}", "Error", MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }

                    progressBar.Value = i + 1;
                    Application.DoEvents();
                }

                pdf.Save(outputPdfPath);
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
