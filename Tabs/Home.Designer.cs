namespace Binder.Tabs
{
    partial class Home
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.preview = new Guna.UI2.WinForms.Guna2Panel();
            this.cl = new Guna.UI2.WinForms.Guna2Button();
            this.sf = new Guna.UI2.WinForms.Guna2Button();
            this.dsf = new Guna.UI2.WinForms.Guna2Button();
            this.bind = new Guna.UI2.WinForms.Guna2Button();
            this.drag = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.sfolder = new Guna.UI2.WinForms.Guna2Button();
            this.borderlessform = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.bo1 = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.bindoption1 = new System.Windows.Forms.Label();
            this.bindoption2 = new System.Windows.Forms.Label();
            this.bo2 = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.progressBar = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.abort = new Guna.UI2.WinForms.Guna2Button();
            this.imagepath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagesize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageextension = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagelist = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2VScrollBar1 = new Guna.UI2.WinForms.Guna2VScrollBar();
            ((System.ComponentModel.ISupportInitialize)(this.imagelist)).BeginInit();
            this.SuspendLayout();
            // 
            // preview
            // 
            this.preview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.preview.BackColor = System.Drawing.Color.Transparent;
            this.preview.BackgroundImage = global::Binder.Properties.Resources.stripes;
            this.preview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.preview.Location = new System.Drawing.Point(11, 40);
            this.preview.Name = "preview";
            this.preview.Size = new System.Drawing.Size(1093, 371);
            this.preview.TabIndex = 21;
            this.preview.UseTransparentBackground = true;
            this.preview.DoubleClick += new System.EventHandler(this.preview_DoubleClick);
            // 
            // cl
            // 
            this.cl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cl.Animated = true;
            this.cl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cl.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cl.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cl.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cl.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cl.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cl.Font = new System.Drawing.Font("Poppins", 10F);
            this.cl.ForeColor = System.Drawing.Color.White;
            this.cl.Location = new System.Drawing.Point(774, 581);
            this.cl.Name = "cl";
            this.cl.Size = new System.Drawing.Size(162, 45);
            this.cl.TabIndex = 20;
            this.cl.Text = "Clear List";
            this.cl.Click += new System.EventHandler(this.ClearDataGridViewButton_Click);
            // 
            // sf
            // 
            this.sf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sf.Animated = true;
            this.sf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sf.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.sf.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.sf.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.sf.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.sf.FillColor = System.Drawing.Color.Teal;
            this.sf.Font = new System.Drawing.Font("Poppins", 10F);
            this.sf.ForeColor = System.Drawing.Color.White;
            this.sf.Location = new System.Drawing.Point(942, 530);
            this.sf.Name = "sf";
            this.sf.Size = new System.Drawing.Size(162, 45);
            this.sf.TabIndex = 19;
            this.sf.Text = "Select Files";
            this.sf.Click += new System.EventHandler(this.SelectFilesButton_Click);
            // 
            // dsf
            // 
            this.dsf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dsf.Animated = true;
            this.dsf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dsf.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.dsf.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.dsf.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.dsf.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.dsf.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dsf.Font = new System.Drawing.Font("Poppins", 10F);
            this.dsf.ForeColor = System.Drawing.Color.White;
            this.dsf.Location = new System.Drawing.Point(942, 581);
            this.dsf.Name = "dsf";
            this.dsf.Size = new System.Drawing.Size(162, 45);
            this.dsf.TabIndex = 18;
            this.dsf.Text = "Remove Selected";
            this.dsf.Click += new System.EventHandler(this.DeleteSelectedFilesButton_Click);
            // 
            // bind
            // 
            this.bind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bind.Animated = true;
            this.bind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bind.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bind.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bind.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bind.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bind.FillColor = System.Drawing.Color.Green;
            this.bind.Font = new System.Drawing.Font("Poppins", 10F);
            this.bind.ForeColor = System.Drawing.Color.White;
            this.bind.Location = new System.Drawing.Point(774, 632);
            this.bind.Name = "bind";
            this.bind.Size = new System.Drawing.Size(162, 45);
            this.bind.TabIndex = 17;
            this.bind.Text = "Bind";
            this.bind.Click += new System.EventHandler(this.BindToPdfButton_Click);
            // 
            // drag
            // 
            this.drag.DockIndicatorTransparencyValue = 0.6D;
            this.drag.UseTransparentDrag = true;
            // 
            // sfolder
            // 
            this.sfolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sfolder.Animated = true;
            this.sfolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sfolder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.sfolder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.sfolder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.sfolder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.sfolder.FillColor = System.Drawing.Color.Teal;
            this.sfolder.Font = new System.Drawing.Font("Poppins", 10F);
            this.sfolder.ForeColor = System.Drawing.Color.White;
            this.sfolder.Location = new System.Drawing.Point(774, 530);
            this.sfolder.Name = "sfolder";
            this.sfolder.Size = new System.Drawing.Size(162, 45);
            this.sfolder.TabIndex = 22;
            this.sfolder.Text = "Select Directory";
            this.sfolder.Click += new System.EventHandler(this.SelectFoldersButton_Click);
            // 
            // borderlessform
            // 
            this.borderlessform.AnimateWindow = true;
            this.borderlessform.ContainerControl = this;
            this.borderlessform.DockForm = false;
            this.borderlessform.DockIndicatorTransparencyValue = 0.6D;
            this.borderlessform.ResizeForm = false;
            this.borderlessform.TransparentWhileDrag = true;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Poppins", 15F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1117, 37);
            this.label1.TabIndex = 24;
            this.label1.Text = "Image Preview";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bo1
            // 
            this.bo1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bo1.Animated = true;
            this.bo1.Checked = true;
            this.bo1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bo1.CheckedState.BorderThickness = 0;
            this.bo1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bo1.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bo1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bo1.Location = new System.Drawing.Point(786, 493);
            this.bo1.Name = "bo1";
            this.bo1.Size = new System.Drawing.Size(20, 20);
            this.bo1.TabIndex = 25;
            this.bo1.Text = "guna2CustomRadioButton1";
            this.bo1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bo1.UncheckedState.BorderThickness = 2;
            this.bo1.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.bo1.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.bo1.CheckedChanged += new System.EventHandler(this.bo1_CheckedChanged);
            // 
            // bindoption1
            // 
            this.bindoption1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bindoption1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bindoption1.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bindoption1.Location = new System.Drawing.Point(812, 493);
            this.bindoption1.Name = "bindoption1";
            this.bindoption1.Size = new System.Drawing.Size(124, 20);
            this.bindoption1.TabIndex = 26;
            this.bindoption1.Text = "Bind Order by ID";
            this.bindoption1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bindoption1.Click += new System.EventHandler(this.bindoption1_Click);
            // 
            // bindoption2
            // 
            this.bindoption2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bindoption2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bindoption2.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bindoption2.Location = new System.Drawing.Point(980, 493);
            this.bindoption2.Name = "bindoption2";
            this.bindoption2.Size = new System.Drawing.Size(124, 20);
            this.bindoption2.TabIndex = 28;
            this.bindoption2.Text = "Bind Order by Name";
            this.bindoption2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bindoption2.Click += new System.EventHandler(this.bindoption2_Click);
            // 
            // bo2
            // 
            this.bo2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bo2.Animated = true;
            this.bo2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bo2.CheckedState.BorderThickness = 0;
            this.bo2.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bo2.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bo2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bo2.Location = new System.Drawing.Point(954, 493);
            this.bo2.Name = "bo2";
            this.bo2.Size = new System.Drawing.Size(20, 20);
            this.bo2.TabIndex = 27;
            this.bo2.Text = "guna2CustomRadioButton2";
            this.bo2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bo2.UncheckedState.BorderThickness = 2;
            this.bo2.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.bo2.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.bo2.CheckedChanged += new System.EventHandler(this.bo2_CheckedChanged);
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.BackColor = System.Drawing.Color.Transparent;
            this.progressBar.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressBar.ForeColor = System.Drawing.Color.Black;
            this.progressBar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.progressBar.Location = new System.Drawing.Point(774, 435);
            this.progressBar.Name = "progressBar";
            this.progressBar.ProgressColor = System.Drawing.Color.Silver;
            this.progressBar.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.progressBar.ShowText = true;
            this.progressBar.Size = new System.Drawing.Size(330, 38);
            this.progressBar.TabIndex = 29;
            this.progressBar.Text = "Total Images to Bind: 0";
            this.progressBar.TextMode = Guna.UI2.WinForms.Enums.ProgressBarTextMode.Custom;
            this.progressBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.progressBar.UseTransparentBackground = true;
            // 
            // abort
            // 
            this.abort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.abort.Animated = true;
            this.abort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.abort.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.abort.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.abort.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.abort.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.abort.Enabled = false;
            this.abort.FillColor = System.Drawing.Color.Maroon;
            this.abort.Font = new System.Drawing.Font("Poppins", 10F);
            this.abort.ForeColor = System.Drawing.Color.White;
            this.abort.Location = new System.Drawing.Point(942, 632);
            this.abort.Name = "abort";
            this.abort.Size = new System.Drawing.Size(162, 45);
            this.abort.TabIndex = 30;
            this.abort.Text = "Abort";
            this.abort.Click += new System.EventHandler(this.abort_Click);
            // 
            // imagepath
            // 
            this.imagepath.HeaderText = "Image Path";
            this.imagepath.Name = "imagepath";
            this.imagepath.ReadOnly = true;
            this.imagepath.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.imagepath.Visible = false;
            // 
            // imagesize
            // 
            this.imagesize.FillWeight = 187.183F;
            this.imagesize.HeaderText = "Image Size";
            this.imagesize.Name = "imagesize";
            this.imagesize.ReadOnly = true;
            this.imagesize.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // imageextension
            // 
            this.imageextension.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.imageextension.FillWeight = 12.69035F;
            this.imageextension.HeaderText = "Extension";
            this.imageextension.Name = "imageextension";
            this.imageextension.ReadOnly = true;
            this.imageextension.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.imageextension.Width = 109;
            // 
            // imagename
            // 
            this.imagename.FillWeight = 187.183F;
            this.imagename.HeaderText = "Image Name";
            this.imagename.Name = "imagename";
            this.imagename.ReadOnly = true;
            this.imagename.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // imageid
            // 
            this.imageid.FillWeight = 51.51824F;
            this.imageid.HeaderText = "ID";
            this.imageid.MinimumWidth = 10;
            this.imageid.Name = "imageid";
            this.imageid.ReadOnly = true;
            this.imageid.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // imagelist
            // 
            this.imagelist.AllowUserToAddRows = false;
            this.imagelist.AllowUserToDeleteRows = false;
            this.imagelist.AllowUserToResizeColumns = false;
            this.imagelist.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.imagelist.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.imagelist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imagelist.BackgroundColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.imagelist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.imagelist.ColumnHeadersHeight = 28;
            this.imagelist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imageid,
            this.imagename,
            this.imageextension,
            this.imagesize,
            this.imagepath});
            this.imagelist.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.imagelist.DefaultCellStyle = dataGridViewCellStyle15;
            this.imagelist.GridColor = System.Drawing.Color.DarkGray;
            this.imagelist.Location = new System.Drawing.Point(11, 435);
            this.imagelist.Name = "imagelist";
            this.imagelist.ReadOnly = true;
            this.imagelist.RowHeadersVisible = false;
            this.imagelist.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.imagelist.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.DarkGray;
            this.imagelist.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.imagelist.Size = new System.Drawing.Size(757, 242);
            this.imagelist.TabIndex = 16;
            this.imagelist.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.imagelist.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.imagelist.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.imagelist.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.imagelist.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.imagelist.ThemeStyle.BackColor = System.Drawing.Color.DarkGray;
            this.imagelist.ThemeStyle.GridColor = System.Drawing.Color.DarkGray;
            this.imagelist.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.imagelist.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.imagelist.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imagelist.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.imagelist.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.imagelist.ThemeStyle.HeaderStyle.Height = 28;
            this.imagelist.ThemeStyle.ReadOnly = true;
            this.imagelist.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.imagelist.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.imagelist.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imagelist.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.imagelist.ThemeStyle.RowsStyle.Height = 22;
            this.imagelist.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.imagelist.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.imagelist.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.imagelist_CellClick);
            this.imagelist.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.imagelist_CellFormatting);
            // 
            // guna2VScrollBar1
            // 
            this.guna2VScrollBar1.BackColor = System.Drawing.Color.Transparent;
            this.guna2VScrollBar1.BindingContainer = this.imagelist;
            this.guna2VScrollBar1.FillColor = System.Drawing.Color.Transparent;
            this.guna2VScrollBar1.InUpdate = false;
            this.guna2VScrollBar1.LargeChange = 10;
            this.guna2VScrollBar1.Location = new System.Drawing.Point(758, 435);
            this.guna2VScrollBar1.Minimum = 1;
            this.guna2VScrollBar1.Name = "guna2VScrollBar1";
            this.guna2VScrollBar1.ScrollbarSize = 10;
            this.guna2VScrollBar1.Size = new System.Drawing.Size(10, 242);
            this.guna2VScrollBar1.TabIndex = 31;
            this.guna2VScrollBar1.ThumbColor = System.Drawing.Color.Gray;
            this.guna2VScrollBar1.ThumbSize = 5F;
            this.guna2VScrollBar1.Value = 1;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.guna2VScrollBar1);
            this.Controls.Add(this.abort);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.bindoption2);
            this.Controls.Add(this.bo2);
            this.Controls.Add(this.bindoption1);
            this.Controls.Add(this.bo1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.preview);
            this.Controls.Add(this.cl);
            this.Controls.Add(this.sf);
            this.Controls.Add(this.dsf);
            this.Controls.Add(this.bind);
            this.Controls.Add(this.imagelist);
            this.Controls.Add(this.sfolder);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(1117, 688);
            ((System.ComponentModel.ISupportInitialize)(this.imagelist)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel preview;
        private Guna.UI2.WinForms.Guna2Button cl;
        private Guna.UI2.WinForms.Guna2Button sf;
        private Guna.UI2.WinForms.Guna2Button dsf;
        private Guna.UI2.WinForms.Guna2Button bind;
        private Guna.UI2.WinForms.Guna2DragControl drag;
        private Guna.UI2.WinForms.Guna2Button sfolder;
        private Guna.UI2.WinForms.Guna2BorderlessForm borderlessform;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CustomRadioButton bo1;
        private System.Windows.Forms.Label bindoption1;
        private System.Windows.Forms.Label bindoption2;
        private Guna.UI2.WinForms.Guna2CustomRadioButton bo2;
        private Guna.UI2.WinForms.Guna2ProgressBar progressBar;
        private Guna.UI2.WinForms.Guna2Button abort;
        private Guna.UI2.WinForms.Guna2DataGridView imagelist;
        private System.Windows.Forms.DataGridViewTextBoxColumn imageid;
        private System.Windows.Forms.DataGridViewTextBoxColumn imagename;
        private System.Windows.Forms.DataGridViewTextBoxColumn imageextension;
        private System.Windows.Forms.DataGridViewTextBoxColumn imagesize;
        private System.Windows.Forms.DataGridViewTextBoxColumn imagepath;
        private Guna.UI2.WinForms.Guna2VScrollBar guna2VScrollBar1;
    }
}
