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
            this.hometab = new System.Windows.Forms.TabPage();
            this.settingstab = new System.Windows.Forms.TabPage();
            this.abouttab = new System.Windows.Forms.TabPage();
            this.homebutton = new Guna.UI2.WinForms.Guna2Button();
            this.settingsbutton = new Guna.UI2.WinForms.Guna2Button();
            this.aboutbutton = new Guna.UI2.WinForms.Guna2Button();
            this.imagebinderIB = new Guna.UI2.WinForms.Guna2PictureBox();
            this.drag2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.home1 = new Binder.Tabs.Home();
            this.settingsTab2 = new Binder.Tabs.SettingsTab();
            this.aboutTab1 = new Binder.Tabs.AboutTab();
            this.tabs.SuspendLayout();
            this.hometab.SuspendLayout();
            this.settingstab.SuspendLayout();
            this.abouttab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagebinderIB)).BeginInit();
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
            resources.ApplyResources(this.appbar, "appbar");
            this.appbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.appbar.Cursor = System.Windows.Forms.Cursors.Default;
            this.appbar.ForeColor = System.Drawing.Color.White;
            this.appbar.Name = "appbar";
            this.appbar.Click += new System.EventHandler(this.appbar_Click);
            // 
            // drag
            // 
            this.drag.DockIndicatorTransparencyValue = 0.6D;
            this.drag.TargetControl = this.appbar;
            this.drag.UseTransparentDrag = true;
            // 
            // guna2ControlBox1
            // 
            resources.ApplyResources(this.guna2ControlBox1, "guna2ControlBox1");
            this.guna2ControlBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2ControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            // 
            // guna2ControlBox3
            // 
            resources.ApplyResources(this.guna2ControlBox3, "guna2ControlBox3");
            this.guna2ControlBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ControlBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2ControlBox3.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            // 
            // tabs
            // 
            resources.ApplyResources(this.tabs, "tabs");
            this.tabs.AllowTransitions = false;
            this.tabs.Controls.Add(this.hometab);
            this.tabs.Controls.Add(this.settingstab);
            this.tabs.Controls.Add(this.abouttab);
            this.tabs.Multiline = true;
            this.tabs.Name = "tabs";
            this.tabs.Page = this.hometab;
            this.tabs.PageIndex = 0;
            this.tabs.PageName = "hometab";
            this.tabs.PageTitle = "Home";
            this.tabs.SelectedIndex = 0;
            this.tabs.TabStop = false;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.tabs.Transition = animation1;
            this.tabs.TransitionType = Utilities.BunifuPages.BunifuAnimatorNS.AnimationType.Transparent;
            // 
            // hometab
            // 
            this.hometab.BackColor = System.Drawing.Color.Silver;
            this.hometab.Controls.Add(this.home1);
            resources.ApplyResources(this.hometab, "hometab");
            this.hometab.Name = "hometab";
            // 
            // settingstab
            // 
            this.settingstab.BackColor = System.Drawing.Color.Silver;
            this.settingstab.Controls.Add(this.settingsTab2);
            resources.ApplyResources(this.settingstab, "settingstab");
            this.settingstab.Name = "settingstab";
            // 
            // abouttab
            // 
            this.abouttab.BackColor = System.Drawing.Color.Silver;
            this.abouttab.Controls.Add(this.aboutTab1);
            resources.ApplyResources(this.abouttab, "abouttab");
            this.abouttab.Name = "abouttab";
            // 
            // homebutton
            // 
            this.homebutton.Animated = true;
            this.homebutton.BackColor = System.Drawing.Color.Transparent;
            this.homebutton.BorderColor = System.Drawing.Color.Gray;
            this.homebutton.BorderThickness = 2;
            this.homebutton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.homebutton.Checked = true;
            this.homebutton.CheckedState.ForeColor = System.Drawing.Color.Aqua;
            this.homebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homebutton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.homebutton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.homebutton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.homebutton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.homebutton.FillColor = System.Drawing.Color.DarkSlateGray;
            resources.ApplyResources(this.homebutton, "homebutton");
            this.homebutton.ForeColor = System.Drawing.Color.White;
            this.homebutton.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.homebutton.Name = "homebutton";
            this.homebutton.PressedColor = System.Drawing.Color.White;
            this.homebutton.UseTransparentBackground = true;
            this.homebutton.Click += new System.EventHandler(this.homebutton_Click);
            // 
            // settingsbutton
            // 
            this.settingsbutton.Animated = true;
            this.settingsbutton.BackColor = System.Drawing.Color.Transparent;
            this.settingsbutton.BorderColor = System.Drawing.Color.Gray;
            this.settingsbutton.BorderThickness = 2;
            this.settingsbutton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.settingsbutton.CheckedState.ForeColor = System.Drawing.Color.Aqua;
            this.settingsbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingsbutton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.settingsbutton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.settingsbutton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.settingsbutton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.settingsbutton.FillColor = System.Drawing.Color.DarkSlateGray;
            resources.ApplyResources(this.settingsbutton, "settingsbutton");
            this.settingsbutton.ForeColor = System.Drawing.Color.White;
            this.settingsbutton.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.settingsbutton.Name = "settingsbutton";
            this.settingsbutton.PressedColor = System.Drawing.Color.White;
            this.settingsbutton.UseTransparentBackground = true;
            this.settingsbutton.Click += new System.EventHandler(this.settingsbutton_Click);
            // 
            // aboutbutton
            // 
            this.aboutbutton.Animated = true;
            this.aboutbutton.BackColor = System.Drawing.Color.Transparent;
            this.aboutbutton.BorderColor = System.Drawing.Color.Gray;
            this.aboutbutton.BorderThickness = 2;
            this.aboutbutton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.aboutbutton.CheckedState.ForeColor = System.Drawing.Color.Aqua;
            this.aboutbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aboutbutton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.aboutbutton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.aboutbutton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.aboutbutton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.aboutbutton.FillColor = System.Drawing.Color.DarkSlateGray;
            resources.ApplyResources(this.aboutbutton, "aboutbutton");
            this.aboutbutton.ForeColor = System.Drawing.Color.White;
            this.aboutbutton.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.aboutbutton.Name = "aboutbutton";
            this.aboutbutton.PressedColor = System.Drawing.Color.White;
            this.aboutbutton.UseTransparentBackground = true;
            this.aboutbutton.Click += new System.EventHandler(this.aboutbutton_Click);
            // 
            // imagebinderIB
            // 
            this.imagebinderIB.BackColor = System.Drawing.Color.Transparent;
            this.imagebinderIB.ErrorImage = global::Binder.Properties.Resources.IMAGE_BINDER_45x45;
            this.imagebinderIB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.imagebinderIB.Image = global::Binder.Properties.Resources.IMAGE_BINDER_45x45;
            this.imagebinderIB.ImageRotate = 0F;
            resources.ApplyResources(this.imagebinderIB, "imagebinderIB");
            this.imagebinderIB.InitialImage = global::Binder.Properties.Resources.IMAGE_BINDER_45x45;
            this.imagebinderIB.Name = "imagebinderIB";
            this.imagebinderIB.TabStop = false;
            this.imagebinderIB.UseTransparentBackground = true;
            // 
            // drag2
            // 
            this.drag2.DockIndicatorTransparencyValue = 0.6D;
            this.drag2.TargetControl = this.imagebinderIB;
            this.drag2.UseTransparentDrag = true;
            // 
            // home1
            // 
            this.home1.BackColor = System.Drawing.Color.Silver;
            resources.ApplyResources(this.home1, "home1");
            this.home1.Name = "home1";
            // 
            // settingsTab2
            // 
            this.settingsTab2.BackColor = System.Drawing.Color.Silver;
            resources.ApplyResources(this.settingsTab2, "settingsTab2");
            this.settingsTab2.Name = "settingsTab2";
            // 
            // aboutTab1
            // 
            this.aboutTab1.BackColor = System.Drawing.Color.Silver;
            resources.ApplyResources(this.aboutTab1, "aboutTab1");
            this.aboutTab1.Name = "aboutTab1";
            // 
            // BinderWindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ControlBox = false;
            this.Controls.Add(this.imagebinderIB);
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.guna2ControlBox3);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.appbar);
            this.Controls.Add(this.homebutton);
            this.Controls.Add(this.settingsbutton);
            this.Controls.Add(this.aboutbutton);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BinderWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BinderWindow_FormClosing);
            this.tabs.ResumeLayout(false);
            this.hometab.ResumeLayout(false);
            this.settingstab.ResumeLayout(false);
            this.abouttab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imagebinderIB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm borderlessform;
        private System.Windows.Forms.Label appbar;
        private Guna.UI2.WinForms.Guna2DragControl drag;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Bunifu.UI.WinForms.BunifuPages tabs;
        private System.Windows.Forms.TabPage hometab;
        private Guna.UI2.WinForms.Guna2Button aboutbutton;
        private Guna.UI2.WinForms.Guna2Button settingsbutton;
        private Guna.UI2.WinForms.Guna2Button homebutton;
        private Tabs.Home home1;
        private Guna.UI2.WinForms.Guna2PictureBox imagebinderIB;
        private Guna.UI2.WinForms.Guna2DragControl drag2;
        private System.Windows.Forms.TabPage abouttab;
        private Tabs.SettingsTab settingsTab1;
        private Tabs.AboutTab aboutTab1;
        private System.Windows.Forms.TabPage settingstab;
        private Tabs.SettingsTab settingsTab2;
    }
}

