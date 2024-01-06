namespace Binder
{
    partial class BinderWindow
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Utilities.BunifuPages.BunifuAnimatorNS.Animation animation1 = new Utilities.BunifuPages.BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BinderWindow));
            this.borderlessform = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.appbar = new System.Windows.Forms.Label();
            this.drag = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.tabs = new Bunifu.UI.WinForms.BunifuPages();
            this.home = new System.Windows.Forms.TabPage();
            this.home1 = new Binder.Tabs.Home();
            this.homebutton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.tabs.SuspendLayout();
            this.home.SuspendLayout();
            this.SuspendLayout();
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
            // appbar
            // 
            this.appbar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.appbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.appbar.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appbar.ForeColor = System.Drawing.Color.White;
            this.appbar.Location = new System.Drawing.Point(-3, -1);
            this.appbar.Name = "appbar";
            this.appbar.Padding = new System.Windows.Forms.Padding(25, 15, 0, 0);
            this.appbar.Size = new System.Drawing.Size(1149, 56);
            this.appbar.TabIndex = 0;
            this.appbar.Text = "Binder";
            // 
            // drag
            // 
            this.drag.DockIndicatorTransparencyValue = 0.6D;
            this.drag.TargetControl = this.appbar;
            this.drag.UseTransparentDrag = true;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1084, 12);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 1;
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2ControlBox3.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox3.Location = new System.Drawing.Point(1033, 12);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox3.TabIndex = 3;
            // 
            // tabs
            // 
            this.tabs.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabs.AllowTransitions = true;
            this.tabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabs.Controls.Add(this.home);
            this.tabs.Location = new System.Drawing.Point(2, 89);
            this.tabs.Multiline = true;
            this.tabs.Name = "tabs";
            this.tabs.Page = this.home;
            this.tabs.PageIndex = 0;
            this.tabs.PageName = "home";
            this.tabs.PageTitle = "Home";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(1137, 721);
            this.tabs.TabIndex = 4;
            animation1.AnimateOnlyDifferences = false;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.tabs.Transition = animation1;
            this.tabs.TransitionType = Utilities.BunifuPages.BunifuAnimatorNS.AnimationType.Custom;
            // 
            // home
            // 
            this.home.Controls.Add(this.home1);
            this.home.Location = new System.Drawing.Point(4, 4);
            this.home.Name = "home";
            this.home.Padding = new System.Windows.Forms.Padding(3);
            this.home.Size = new System.Drawing.Size(1129, 695);
            this.home.TabIndex = 0;
            this.home.Text = "Home";
            this.home.UseVisualStyleBackColor = true;
            // 
            // home1
            // 
            this.home1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.home1.Location = new System.Drawing.Point(3, 3);
            this.home1.Name = "home1";
            this.home1.Size = new System.Drawing.Size(1123, 689);
            this.home1.TabIndex = 0;
            // 
            // homebutton
            // 
            this.homebutton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.homebutton.Checked = true;
            this.homebutton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.homebutton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.homebutton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.homebutton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.homebutton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.homebutton.ForeColor = System.Drawing.Color.White;
            this.homebutton.Location = new System.Drawing.Point(6, 58);
            this.homebutton.Name = "homebutton";
            this.homebutton.Size = new System.Drawing.Size(108, 29);
            this.homebutton.TabIndex = 5;
            this.homebutton.Text = "Home";
            this.homebutton.Click += new System.EventHandler(this.homebutton_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(120, 58);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(108, 29);
            this.guna2Button2.TabIndex = 6;
            this.guna2Button2.Text = "Other Tabs";
            // 
            // guna2Button3
            // 
            this.guna2Button3.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.Location = new System.Drawing.Point(234, 58);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(108, 29);
            this.guna2Button3.TabIndex = 7;
            this.guna2Button3.Text = "Other Tabs";
            // 
            // guna2Button4
            // 
            this.guna2Button4.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.Location = new System.Drawing.Point(348, 58);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.Size = new System.Drawing.Size(108, 29);
            this.guna2Button4.TabIndex = 8;
            this.guna2Button4.Text = "Other Tabs";
            // 
            // BinderWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 812);
            this.ControlBox = false;
            this.Controls.Add(this.guna2Button4);
            this.Controls.Add(this.guna2Button3);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.homebutton);
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.guna2ControlBox3);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.appbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BinderWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Binder";
            this.TopMost = true;
            this.tabs.ResumeLayout(false);
            this.home.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm borderlessform;
        private System.Windows.Forms.Label appbar;
        private Guna.UI2.WinForms.Guna2DragControl drag;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Bunifu.UI.WinForms.BunifuPages tabs;
        private System.Windows.Forms.TabPage home;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button homebutton;
        private Tabs.Home home1;
    }
}

