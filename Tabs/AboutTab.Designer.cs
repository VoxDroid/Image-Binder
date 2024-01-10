namespace Binder.Tabs
{
    partial class AboutTab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutTab));
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.imagebinderlabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.byvox = new System.Windows.Forms.Label();
            this.tooltip = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.ErrorImage = global::Binder.Properties.Resources.IMAGE_BINDER___ABOUT;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::Binder.Properties.Resources.IMAGE_BINDER___ABOUT;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.InitialImage = global::Binder.Properties.Resources.IMAGE_BINDER___ABOUT;
            this.guna2PictureBox1.Location = new System.Drawing.Point(18, 167);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(375, 375);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // imagebinderlabel
            // 
            this.imagebinderlabel.BackColor = System.Drawing.Color.Silver;
            this.imagebinderlabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imagebinderlabel.Font = new System.Drawing.Font("Poppins", 20F);
            this.imagebinderlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.imagebinderlabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.imagebinderlabel.Location = new System.Drawing.Point(420, 17);
            this.imagebinderlabel.Name = "imagebinderlabel";
            this.imagebinderlabel.Size = new System.Drawing.Size(282, 52);
            this.imagebinderlabel.TabIndex = 26;
            this.imagebinderlabel.Text = "Image Binder v1.0.0";
            this.imagebinderlabel.Click += new System.EventHandler(this.imagebinderlabel_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Poppins", 10F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(423, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(691, 619);
            this.label1.TabIndex = 27;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // byvox
            // 
            this.byvox.AutoSize = true;
            this.byvox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.byvox.Font = new System.Drawing.Font("Poppins", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.byvox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.byvox.Location = new System.Drawing.Point(708, 26);
            this.byvox.Name = "byvox";
            this.byvox.Size = new System.Drawing.Size(128, 34);
            this.byvox.TabIndex = 28;
            this.byvox.Text = "by VoxDroid";
            this.byvox.Click += new System.EventHandler(this.byvox_Click);
            // 
            // tooltip
            // 
            this.tooltip.AllowLinksHandling = true;
            this.tooltip.AutoPopDelay = 500000000;
            this.tooltip.BorderColor = System.Drawing.Color.White;
            this.tooltip.Font = new System.Drawing.Font("Poppins", 12F);
            this.tooltip.ForeColor = System.Drawing.Color.Teal;
            this.tooltip.InitialDelay = 500;
            this.tooltip.MaximumSize = new System.Drawing.Size(0, 0);
            this.tooltip.ReshowDelay = 100;
            this.tooltip.ShowAlways = true;
            this.tooltip.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.tooltip.TitleFont = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold);
            this.tooltip.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tooltip.ToolTipTitle = "Image Binder";
            this.tooltip.UseGdiPlusTextRendering = true;
            // 
            // AboutTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.byvox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imagebinderlabel);
            this.Controls.Add(this.guna2PictureBox1);
            this.DoubleBuffered = true;
            this.Name = "AboutTab";
            this.Size = new System.Drawing.Size(1117, 688);
            this.Enter += new System.EventHandler(this.AboutTab_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label imagebinderlabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label byvox;
        private Guna.UI2.WinForms.Guna2HtmlToolTip tooltip;
    }
}
