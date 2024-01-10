using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using PdfSharp.Drawing;
using System.Drawing.Imaging;
using ImageMagick;
using iText.Kernel.Pdf;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Binder.Tabs
{
    public partial class Home : UserControl
    {
        private BindingList<ImageInfo> selectedImages = new BindingList<ImageInfo>();
        private BackgroundWorker backgroundWorker;
        private CancellationTokenSource cancellationTokenSource;
        private bool isBindingInProgress = false;
        private bool isLosslessMode = false;

        public Home()
        {
            InitializeComponent();
            ConfigureDataGridView();
            InitializeBackgroundWorker();
            InitializeQualityControls();

            isBindingInProgress = false;
            imagelist.AllowDrop = true;

            if (oql.Checked)
            {
                qualityTrackBar.Enabled = false;
                isLosslessMode = true;
                qualityLabel.Text = $"Image Compression Quality: Off";
                trackbarhigh.Enabled = false;
                trackbarlow.Enabled = false;
            }
        }

        private void InitializeQualityControls()
        {
            qualityTrackBar.Minimum = 1;
            qualityTrackBar.Maximum = 100;
            qualityTrackBar.Value = 80; 
            qualityTrackBar.Name = "qualityTrackBar";
            qualityTrackBar.Scroll += qualityTrackBar_Scroll;
            oql.CheckedChanged += oql_CheckedChanged;

            qualityLabel.Text = $"Image Compression Quality: {qualityTrackBar.Value}%";
            qualityLabel.Name = "qualityLabel";
        }

        private void qualityTrackBar_Scroll(object sender, EventArgs e)
        {
            qualityLabel.Text = $"Image Compression Quality: {qualityTrackBar.Value}%";

            if (!string.IsNullOrEmpty(currentlyDisplayedImagePath))
            {
                ResizeImageAndShowPreview(currentlyDisplayedImagePath, qualityTrackBar.Value);
            }
        }

        private void ResizeImageAndShowPreview(string imagePath, int quality)
        {
            ShowImagePreview(imagePath, quality);
            UpdateDataGridView();
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
            bool performInvalidCharacterCheck = true;

            foreach (string imagePath in imagePaths)
            {
                if (File.Exists(imagePath))
                {
                    FileInfo fileInfo = new FileInfo(imagePath);
                    string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(fileInfo.Name);

                    if (performInvalidCharacterCheck && fileNameWithoutExtension.Contains('.'))
                    {
                        DialogResult result = MessageBox.Show($"The base file name '{fileNameWithoutExtension}' contains an invalid character that might affect the binding process. Do you want to rename all detected invalid files automatically?\n\nYES = Rename All\nNO = Rename Current File\nCANCEL = Skip and Bypass (Default)", "Rename Files", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            RenameAllFilesAndAddToList(imagePaths);
                            return;
                        }
                        else if (result == DialogResult.Cancel)
                        {
                            performInvalidCharacterCheck = false;
                            AddFileToList(imagePath);
                        }
                        else
                        {
                            RenameFileAndAddToList(imagePath);
                        }
                    }
                    else if (IsImageFileValid(imagePath))
                    {
                        AddFileToList(imagePath);
                    }
                    else
                    {
                        MessageBox.Show($"Skipping file '{fileInfo.Name}' due to an invalid image extension.", "Skipped File", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (Directory.Exists(imagePath))
                {
                    string[] directoryImagePaths = Directory.GetFiles(imagePath, "*.*", SearchOption.AllDirectories)
                        .Where(s => IsImageFileValid(s))
                        .Select(s => s.ToLower())
                        .ToArray();

                    ProcessImages(directoryImagePaths);
                }
            }

            SortImages();
            UpdateTotalImagesProgressBarText();
            UpdateDataGridView();
        }

        private void RenameAllFilesAndAddToList(string[] imagePaths)
        {
            foreach (string imagePath in imagePaths)
            {
                RenameFileAndAddToList(imagePath);
            }
        }

        private bool IsImageFileValid(string filePath)
        {
            string extension = Path.GetExtension(filePath)?.ToLower();

            return extension == ".png" || extension == ".jpg" || extension == ".jpeg";
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

        private string FileNameX;

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
                    FileNameX = saveDialog.FileName;

                    if (saveDialog.ShowDialog() == DialogResult.OK)
                    {
                        string outputPdfPath = saveDialog.FileName;

                        isBindingInProgress = true;
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

                        if (isLosslessMode)
                        {
                            backgroundWorker.RunWorkerAsync(new Tuple<string[], string, CancellationToken, bool>(imagePaths, outputPdfPath, cancellationTokenSource.Token, true));
                        }
                        else
                        {
                            backgroundWorker.RunWorkerAsync(new Tuple<string[], string, CancellationToken, bool>(imagePaths, outputPdfPath, cancellationTokenSource.Token, false));
                        }
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
            Tuple<string[], string, CancellationToken, bool> arguments = e.Argument as Tuple<string[], string, CancellationToken, bool>;

            string[] imagePaths = arguments.Item1;
            string outputPdfPath = arguments.Item2;
            CancellationToken cancellationToken = arguments.Item3;
            bool losslessMode = arguments.Item4;

            ConvertImagesToPdf(selectedImages.ToList(), outputPdfPath, worker, e, cancellationToken, losslessMode);
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
                MessageBox.Show($"File: {FileNameX} created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            progressBar.Value = 0;
            EnableButtons();
            UpdateTotalImagesProgressBarText();
            isBindingInProgress = false;
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
            qualityTrackBar.Enabled = false;
            trackbarlow.Enabled = false;
            trackbarhigh.Enabled = false;
            bindoption1.Enabled = false;
            bindoption2.Enabled = false;
            titletb.Enabled = false;
            authortb.Enabled = false;
            subjecttb.Enabled = false;
            keywordstb.Enabled = false;
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
            if (oql.Checked)
            {
                qualityTrackBar.Enabled = false ;
                trackbarlow.Enabled = false;
                trackbarhigh.Enabled = false;
            }
            else
            {
                qualityTrackBar.Enabled = true;
                trackbarlow.Enabled = true;
                trackbarhigh.Enabled = true;
            }
            bindoption1.Enabled = true;
            bindoption2.Enabled = true;

            titletb.Enabled = true;
            authortb.Enabled = true;
            subjecttb.Enabled = true;
            keywordstb.Enabled = true;
        }

        private void imagelist_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = isBindingInProgress ? DragDropEffects.None : (e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.Copy : DragDropEffects.None);
        }

        private void imagelist_DragDrop(object sender, DragEventArgs e)
        {
            if (!isBindingInProgress)
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

                if (files != null)
                {
                    ProcessImages(files);
                }
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
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (imagelist.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection != SortOrder.None)
                {
                    return;
                }

                DataGridViewRow selectedRow = imagelist.Rows[e.RowIndex];
                if (selectedRow.Cells["ImagePath"].Value is string imagePath)
                {
                    if (File.Exists(imagePath))
                    {

                        if (isLosslessMode)
                        {
                            LastTBV = qualityTrackBar.Value;
                            qualityTrackBar.Value = 100;
                        }

                        ShowImagePreview(imagePath, qualityTrackBar.Value);
                        currentlyDisplayedImagePath = imagePath;
                        qualityTrackBar.Value = LastTBV;
                    }
                    else
                    {
                        MessageBox.Show($"Original image not found: {imagePath}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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




        private void ShowImagePreview(string imagePath, int quality)
        {
            try
            {
                System.Drawing.Image image;

                if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                {
                    image = ResizeImageWithQuality(imagePath, quality);
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

        private System.Drawing.Image ResizeImageWithQuality(string imagePath, int quality)
        {
            using (FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
            {
                Image originalImage = System.Drawing.Image.FromStream(fs);
                ImageFormat originalFormat = originalImage.RawFormat;

                Image resizedImage;

                if (originalFormat.Equals(ImageFormat.Jpeg))
                {
                    resizedImage = ResizeJpegImage(originalImage, quality);
                }
                else
                {
                    resizedImage = ResizeImage(originalImage);
                }

                return resizedImage;
            }
        }

        private Image ResizeJpegImage(Image originalImage, int quality)
        {
            EncoderParameters encoderParameters = new EncoderParameters(1);
            encoderParameters.Param[0] = new EncoderParameter(Encoder.Quality, quality);

            ImageCodecInfo jpegCodec = GetEncoderInfo("image/jpeg");

            using (MemoryStream ms = new MemoryStream())
            {
                originalImage.Save(ms, jpegCodec, encoderParameters);
                return Image.FromStream(ms);
            }
        }

        private Image ResizeImage(Image originalImage)
        {
            int selectedQuality = qualityTrackBar.Value;
            EncoderParameters encoderParameters = new EncoderParameters(1);
            encoderParameters.Param[0] = new EncoderParameter(Encoder.Quality, selectedQuality);

            ImageCodecInfo jpegCodec = GetEncoderInfo("image/jpeg");

            using (MemoryStream ms = new MemoryStream())
            {
                originalImage.Save(ms, jpegCodec, encoderParameters);
                return Image.FromStream(ms);
            }
        }

        private ImageCodecInfo GetEncoderInfo(string mimeType)
        {
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();
            return codecs.FirstOrDefault(codec => codec.MimeType == mimeType);
        }


        private void ConvertImagesToPdf(List<ImageInfo> images, string outputPdfPath, BackgroundWorker worker, DoWorkEventArgs e, CancellationToken cancellationToken, bool losslessMode)
        {
            string tempJpegFolder = Path.Combine(Path.GetTempPath(), "BinderTempJpegFiles");
            Directory.CreateDirectory(tempJpegFolder);

            using (MagickImageCollection imageCollection = new MagickImageCollection())
            {
                int totalImages = images.Count;

                for (int i = 0; i < totalImages; i++)
                {
                    ImageInfo imageInfo = images[i];
                    string imageName = Path.GetFileName(imageInfo.ImagePath);

                    try
                    {
                        if (imageInfo.ImagePath.EndsWith(".png", StringComparison.OrdinalIgnoreCase))
                        {
                            if (losslessMode)
                            {
                                imageCollection.Add(new MagickImage(imageInfo.ImagePath));
                            }
                            else
                            {
                                string tempJpegPath = ConvertPngToJpeg(imageInfo.ImagePath, tempJpegFolder);
                                imageCollection.Add(new MagickImage(tempJpegPath));
                            }
                        }
                        else
                        {
                            imageCollection.Add(new MagickImage(imageInfo.ImagePath));
                        }

                        if (cancellationToken.IsCancellationRequested)
                        {
                            e.Cancel = true;
                            return;
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

                worker.ReportProgress(100, $"Completed {totalImages}/{totalImages}: Now Processing File...");

                if (!worker.CancellationPending)
                {
                    string tempPdfPath = Path.Combine(Path.GetTempPath(), "tempPdf.pdf");

                    using (var pdfDocument = new PdfSharp.Pdf.PdfDocument())
                    {
                        foreach (var image in imageCollection)
                        {
                            var pdfPage = pdfDocument.AddPage();
                            pdfPage.Width = XUnit.FromPoint(image.Width);
                            pdfPage.Height = XUnit.FromPoint(image.Height);
                            XGraphics pdfGraphics = XGraphics.FromPdfPage(pdfPage);

                            byte[] imageBytes = image.ToByteArray(MagickFormat.Jpeg);

                            using (MemoryStream ms = new MemoryStream(imageBytes))
                            {
                                var xImage = XImage.FromStream(ms);
                                pdfGraphics.DrawImage(xImage, 0, 0, pdfPage.Width, pdfPage.Height);
                            }
                        }

                        pdfDocument.Save(tempPdfPath);
                    }

                    using (var pdfDocument = new iText.Kernel.Pdf.PdfDocument(new PdfReader(tempPdfPath), new PdfWriter(outputPdfPath)))
                    {
                        var pdfMetadata = pdfDocument.GetDocumentInfo();

                        pdfMetadata.SetTitle(titletb.Text);
                        pdfMetadata.SetSubject(subjecttb.Text);

                        pdfMetadata.SetAuthor(authortb.Text);
                        pdfMetadata.SetKeywords(keywordstb.Text);
                        pdfMetadata.SetCreator("Image Binder");

                        pdfDocument.Close();
                    }

                    File.Delete(tempPdfPath);

                    CleanUpTempJpegFiles(tempJpegFolder);
                }
            }
        }

        private string ConvertPngToJpeg(string pngImagePath, string tempJpegFolder)
        {
            using (MagickImage pngImage = new MagickImage(pngImagePath))
            {
                string tempJpegPath = Path.Combine(tempJpegFolder, Path.GetFileNameWithoutExtension(pngImagePath) + ".jpg");

                pngImage.Quality = qualityTrackBar.Value;

                pngImage.Write(tempJpegPath, MagickFormat.Jpeg);

                return tempJpegPath;
            }
        }

        private void CleanUpTempJpegFiles(string tempJpegFolder)
        {
            try
            {
                Directory.GetFiles(tempJpegFolder, "*.jpg").ToList().ForEach(File.Delete);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error cleaning up temporary JPEG files: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void trackbarlow_Click(object sender, EventArgs e)
        {
            qualityTrackBar.Value = 1;
            qualityLabel.Text = $"Image Compression Quality: {qualityTrackBar.Value}%";
        }

        private void trackbarhigh_Click(object sender, EventArgs e)
        {
            qualityTrackBar.Value = 100;
            qualityLabel.Text = $"Image Compression Quality: {qualityTrackBar.Value}%";
        }

        private void qualityTrackBar_ValueChanged(object sender, EventArgs e)
        {

            if (!isLosslessMode)
            {
                qualityLabel.Text = $"Image Compression Quality: {qualityTrackBar.Value}%";
            }
        }

        private int LastTBV = 80;

        private void oql_CheckedChanged(object sender, EventArgs e)
        {
            if (oql.Checked)
            {
                qualityTrackBar.Enabled = false;
                isLosslessMode = true;
                qualityLabel.Text = $"Image Compression Quality: Off";
                trackbarhigh.Enabled = false;
                trackbarlow.Enabled = false;
                LastTBV = qualityTrackBar.Value;
                qualityTrackBar.Value = 100;
            }
            else
            {
                qualityTrackBar.Enabled = true;
                isLosslessMode = false;
                qualityLabel.Text = $"Image Compression Quality: {qualityTrackBar.Value}%";
                trackbarhigh.Enabled = true;
                trackbarlow.Enabled = true;
            }
            ResizeImageAndShowPreview(currentlyDisplayedImagePath, qualityTrackBar.Value);
            qualityTrackBar.Value = LastTBV;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (oql.Checked)
            {
                oql.Checked = false;
            }
            else
            {
                oql.Checked = true;
            }
        }

        private void titleC_Click(object sender, EventArgs e)
        {
            titletb.Focus();
        }

        private void authorC_Click(object sender, EventArgs e)
        {
            authortb.Focus();
        }

        private void subjectC_Click(object sender, EventArgs e)
        {
            subjecttb.Focus();
        }

        private void keywordsC_Click(object sender, EventArgs e)
        {
            keywordstb.Focus();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            titletb.Text = string.Empty;
            authortb.Text = string.Empty;
            subjecttb.Text = string.Empty;
            keywordstb.Text = string.Empty;
        }

        private void imagelist_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < imagelist.Rows.Count)
            {
                DataGridViewRow selectedRow = imagelist.Rows[e.RowIndex];
                string filePath = selectedRow.Cells["ImagePath"].Value.ToString();

                string directoryPath = System.IO.Path.GetDirectoryName(filePath);

                try
                {
                    System.Diagnostics.Process.Start("explorer.exe", $"/select,\"{filePath}\"");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error opening directory: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void TextBoxHover_MouseHover(object sender, EventArgs e)
        {
            if (sender is Guna.UI2.WinForms.Guna2TextBox textBox)
            {
                textBox.PlaceholderForeColor = Color.FromArgb(0, 192, 192);
            }
        }

        private void TextBoxHover_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Guna.UI2.WinForms.Guna2TextBox textBox)
            {
                textBox.PlaceholderForeColor = Color.FromArgb(193, 200, 207);
            }
        }
    }
}