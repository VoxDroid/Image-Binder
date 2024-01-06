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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.progressBar = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.preview = new Guna.UI2.WinForms.Guna2Panel();
            this.cl = new Guna.UI2.WinForms.Guna2Button();
            this.sf = new Guna.UI2.WinForms.Guna2Button();
            this.dsf = new Guna.UI2.WinForms.Guna2Button();
            this.bind = new Guna.UI2.WinForms.Guna2Button();
            this.imagepath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagesize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageextension = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagelist = new Guna.UI2.WinForms.Guna2DataGridView();
            this.drag = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.sfolder = new Guna.UI2.WinForms.Guna2Button();
            this.borderlessform = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imagelist)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(774, 435);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(330, 38);
            this.progressBar.TabIndex = 23;
            this.progressBar.Text = "guna2ProgressBar1";
            this.progressBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
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
            // 
            // cl
            // 
            this.cl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cl.Animated = true;
            this.cl.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cl.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cl.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cl.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cl.Font = new System.Drawing.Font("Segoe UI", 9F);
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
            this.sf.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.sf.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.sf.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.sf.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.sf.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.sf.ForeColor = System.Drawing.Color.White;
            this.sf.Location = new System.Drawing.Point(774, 530);
            this.sf.Name = "sf";
            this.sf.Size = new System.Drawing.Size(330, 45);
            this.sf.TabIndex = 19;
            this.sf.Text = "Select Files";
            this.sf.Click += new System.EventHandler(this.SelectFilesButton_Click);
            // 
            // dsf
            // 
            this.dsf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dsf.Animated = true;
            this.dsf.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.dsf.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.dsf.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.dsf.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.dsf.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dsf.ForeColor = System.Drawing.Color.White;
            this.dsf.Location = new System.Drawing.Point(942, 581);
            this.dsf.Name = "dsf";
            this.dsf.Size = new System.Drawing.Size(162, 45);
            this.dsf.TabIndex = 18;
            this.dsf.Text = "Delete Selected File(s)";
            this.dsf.Click += new System.EventHandler(this.DeleteSelectedFilesButton_Click);
            // 
            // bind
            // 
            this.bind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bind.Animated = true;
            this.bind.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bind.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bind.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bind.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bind.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bind.ForeColor = System.Drawing.Color.White;
            this.bind.Location = new System.Drawing.Point(774, 632);
            this.bind.Name = "bind";
            this.bind.Size = new System.Drawing.Size(330, 45);
            this.bind.TabIndex = 17;
            this.bind.Text = "Bind";
            this.bind.Click += new System.EventHandler(this.BindToPdfButton_Click);
            // 
            // imagepath
            // 
            this.imagepath.HeaderText = "Image Path";
            this.imagepath.Name = "imagepath";
            this.imagepath.ReadOnly = true;
            this.imagepath.Visible = false;
            // 
            // imagesize
            // 
            this.imagesize.FillWeight = 187.183F;
            this.imagesize.HeaderText = "Image Size";
            this.imagesize.Name = "imagesize";
            this.imagesize.ReadOnly = true;
            // 
            // imageextension
            // 
            this.imageextension.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.imageextension.FillWeight = 12.69035F;
            this.imageextension.HeaderText = "Extension";
            this.imageextension.Name = "imageextension";
            this.imageextension.ReadOnly = true;
            this.imageextension.Width = 76;
            // 
            // imagename
            // 
            this.imagename.FillWeight = 187.183F;
            this.imagename.HeaderText = "Image Name";
            this.imagename.Name = "imagename";
            this.imagename.ReadOnly = true;
            // 
            // imageid
            // 
            this.imageid.FillWeight = 51.51824F;
            this.imageid.HeaderText = "ID";
            this.imageid.MinimumWidth = 10;
            this.imageid.Name = "imageid";
            this.imageid.ReadOnly = true;
            // 
            // imagelist
            // 
            this.imagelist.AllowUserToAddRows = false;
            this.imagelist.AllowUserToDeleteRows = false;
            this.imagelist.AllowUserToResizeColumns = false;
            this.imagelist.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.imagelist.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.imagelist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.imagelist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.imagelist.ColumnHeadersHeight = 28;
            this.imagelist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.imagelist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imageid,
            this.imagename,
            this.imageextension,
            this.imagesize,
            this.imagepath});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.imagelist.DefaultCellStyle = dataGridViewCellStyle3;
            this.imagelist.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.imagelist.Location = new System.Drawing.Point(11, 435);
            this.imagelist.Name = "imagelist";
            this.imagelist.ReadOnly = true;
            this.imagelist.RowHeadersVisible = false;
            this.imagelist.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.imagelist.Size = new System.Drawing.Size(757, 242);
            this.imagelist.TabIndex = 16;
            this.imagelist.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.imagelist.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.imagelist.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.imagelist.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.imagelist.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.imagelist.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.imagelist.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.imagelist.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.imagelist.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.imagelist.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imagelist.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.imagelist.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
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
            // drag
            // 
            this.drag.DockIndicatorTransparencyValue = 0.6D;
            this.drag.UseTransparentDrag = true;
            // 
            // sfolder
            // 
            this.sfolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sfolder.Animated = true;
            this.sfolder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.sfolder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.sfolder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.sfolder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.sfolder.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.sfolder.ForeColor = System.Drawing.Color.White;
            this.sfolder.Location = new System.Drawing.Point(774, 479);
            this.sfolder.Name = "sfolder";
            this.sfolder.Size = new System.Drawing.Size(330, 45);
            this.sfolder.TabIndex = 22;
            this.sfolder.Text = "Select Folder(s)";
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
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1117, 37);
            this.label1.TabIndex = 24;
            this.label1.Text = "Image Preview";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar);
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

        private Guna.UI2.WinForms.Guna2ProgressBar progressBar;
        private Guna.UI2.WinForms.Guna2Panel preview;
        private Guna.UI2.WinForms.Guna2Button cl;
        private Guna.UI2.WinForms.Guna2Button sf;
        private Guna.UI2.WinForms.Guna2Button dsf;
        private Guna.UI2.WinForms.Guna2Button bind;
        private System.Windows.Forms.DataGridViewTextBoxColumn imagepath;
        private System.Windows.Forms.DataGridViewTextBoxColumn imagesize;
        private System.Windows.Forms.DataGridViewTextBoxColumn imageextension;
        private System.Windows.Forms.DataGridViewTextBoxColumn imagename;
        private System.Windows.Forms.DataGridViewTextBoxColumn imageid;
        private Guna.UI2.WinForms.Guna2DataGridView imagelist;
        private Guna.UI2.WinForms.Guna2DragControl drag;
        private Guna.UI2.WinForms.Guna2Button sfolder;
        private Guna.UI2.WinForms.Guna2BorderlessForm borderlessform;
        private System.Windows.Forms.Label label1;
    }
}
