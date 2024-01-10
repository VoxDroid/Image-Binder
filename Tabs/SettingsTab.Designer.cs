namespace Binder.Tabs
{
    partial class SettingsTab
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
            this.settingslabel = new System.Windows.Forms.Label();
            this.alwaysontoplabel = new System.Windows.Forms.Label();
            this.alwaysontopcb = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.showtooltipslabel = new System.Windows.Forms.Label();
            this.showtooltipscb = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.SuspendLayout();
            // 
            // settingslabel
            // 
            this.settingslabel.Font = new System.Drawing.Font("Poppins", 15F);
            this.settingslabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.settingslabel.Location = new System.Drawing.Point(3, 11);
            this.settingslabel.Name = "settingslabel";
            this.settingslabel.Size = new System.Drawing.Size(138, 37);
            this.settingslabel.TabIndex = 25;
            this.settingslabel.Text = "Settings";
            this.settingslabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // alwaysontoplabel
            // 
            this.alwaysontoplabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.alwaysontoplabel.AutoSize = true;
            this.alwaysontoplabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.alwaysontoplabel.Font = new System.Drawing.Font("Poppins", 11F);
            this.alwaysontoplabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.alwaysontoplabel.Location = new System.Drawing.Point(66, 68);
            this.alwaysontoplabel.Name = "alwaysontoplabel";
            this.alwaysontoplabel.Size = new System.Drawing.Size(154, 26);
            this.alwaysontoplabel.TabIndex = 40;
            this.alwaysontoplabel.Text = "App Always on Top";
            this.alwaysontoplabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.alwaysontoplabel.Click += new System.EventHandler(this.alwaysontoplabel_Click);
            // 
            // alwaysontopcb
            // 
            this.alwaysontopcb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.alwaysontopcb.Animated = true;
            this.alwaysontopcb.BackColor = System.Drawing.Color.Transparent;
            this.alwaysontopcb.Checked = true;
            this.alwaysontopcb.CheckedState.BorderColor = System.Drawing.Color.Teal;
            this.alwaysontopcb.CheckedState.BorderRadius = 2;
            this.alwaysontopcb.CheckedState.BorderThickness = 0;
            this.alwaysontopcb.CheckedState.FillColor = System.Drawing.Color.Teal;
            this.alwaysontopcb.Location = new System.Drawing.Point(40, 70);
            this.alwaysontopcb.Name = "alwaysontopcb";
            this.alwaysontopcb.Size = new System.Drawing.Size(20, 20);
            this.alwaysontopcb.TabIndex = 39;
            this.alwaysontopcb.Text = "Lossless Mode";
            this.alwaysontopcb.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.alwaysontopcb.UncheckedState.BorderRadius = 2;
            this.alwaysontopcb.UncheckedState.BorderThickness = 0;
            this.alwaysontopcb.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.alwaysontopcb.CheckedChanged += new System.EventHandler(this.alwaysontopcb_CheckedChanged);
            // 
            // showtooltipslabel
            // 
            this.showtooltipslabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.showtooltipslabel.AutoSize = true;
            this.showtooltipslabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showtooltipslabel.Font = new System.Drawing.Font("Poppins", 11F);
            this.showtooltipslabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.showtooltipslabel.Location = new System.Drawing.Point(66, 130);
            this.showtooltipslabel.Name = "showtooltipslabel";
            this.showtooltipslabel.Size = new System.Drawing.Size(116, 26);
            this.showtooltipslabel.TabIndex = 42;
            this.showtooltipslabel.Text = "Show Tooltips";
            this.showtooltipslabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.showtooltipslabel.Click += new System.EventHandler(this.showtooltipslabel_Click_1);
            // 
            // showtooltipscb
            // 
            this.showtooltipscb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.showtooltipscb.Animated = true;
            this.showtooltipscb.BackColor = System.Drawing.Color.Transparent;
            this.showtooltipscb.Checked = true;
            this.showtooltipscb.CheckedState.BorderColor = System.Drawing.Color.Teal;
            this.showtooltipscb.CheckedState.BorderRadius = 2;
            this.showtooltipscb.CheckedState.BorderThickness = 0;
            this.showtooltipscb.CheckedState.FillColor = System.Drawing.Color.Teal;
            this.showtooltipscb.Location = new System.Drawing.Point(40, 132);
            this.showtooltipscb.Name = "showtooltipscb";
            this.showtooltipscb.Size = new System.Drawing.Size(20, 20);
            this.showtooltipscb.TabIndex = 41;
            this.showtooltipscb.Text = "Lossless Mode";
            this.showtooltipscb.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.showtooltipscb.UncheckedState.BorderRadius = 2;
            this.showtooltipscb.UncheckedState.BorderThickness = 0;
            this.showtooltipscb.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.showtooltipscb.CheckedChanged += new System.EventHandler(this.showtooltipscb_CheckedChanged);
            // 
            // SettingsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.showtooltipslabel);
            this.Controls.Add(this.showtooltipscb);
            this.Controls.Add(this.alwaysontoplabel);
            this.Controls.Add(this.alwaysontopcb);
            this.Controls.Add(this.settingslabel);
            this.DoubleBuffered = true;
            this.Name = "SettingsTab";
            this.Size = new System.Drawing.Size(1117, 688);
            this.Enter += new System.EventHandler(this.SettingsTab_Enter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label settingslabel;
        private System.Windows.Forms.Label alwaysontoplabel;
        private Guna.UI2.WinForms.Guna2CustomCheckBox alwaysontopcb;
        private System.Windows.Forms.Label showtooltipslabel;
        private Guna.UI2.WinForms.Guna2CustomCheckBox showtooltipscb;
    }
}
