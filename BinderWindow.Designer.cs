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
            this.imagebinderIB = new Guna.UI2.WinForms.Guna2PictureBox();
            this.drag2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.tabs.SuspendLayout();
            this.home.SuspendLayout();
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
            this.tabs.AllowTransitions = true;
            this.tabs.Controls.Add(this.home);
            this.tabs.Multiline = true;
            this.tabs.Name = "tabs";
            this.tabs.Page = this.home;
            this.tabs.PageIndex = 0;
            this.tabs.PageName = "home";
            this.tabs.PageTitle = "Home";
            this.tabs.SelectedIndex = 0;
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
            resources.ApplyResources(this.home, "home");
            this.home.BackColor = System.Drawing.Color.Silver;
            this.home.Controls.Add(this.home1);
            this.home.Name = "home";
            // 
            // home1
            // 
            resources.ApplyResources(this.home1, "home1");
            this.home1.BackColor = System.Drawing.Color.Silver;
            this.home1.Name = "home1";
            // 
            // homebutton
            // 
            resources.ApplyResources(this.homebutton, "homebutton");
            this.homebutton.Animated = true;
            this.homebutton.BackColor = System.Drawing.Color.Transparent;
            this.homebutton.BorderColor = System.Drawing.Color.Gray;
            this.homebutton.BorderThickness = 2;
            this.homebutton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.homebutton.Checked = true;
            this.homebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homebutton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.homebutton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.homebutton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.homebutton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.homebutton.FillColor = System.Drawing.Color.DarkSlateGray;
            this.homebutton.ForeColor = System.Drawing.Color.White;
            this.homebutton.Name = "homebutton";
            this.homebutton.PressedColor = System.Drawing.Color.White;
            this.homebutton.UseTransparentBackground = true;
            this.homebutton.Click += new System.EventHandler(this.homebutton_Click);
            // 
            // guna2Button2
            // 
            resources.ApplyResources(this.guna2Button2, "guna2Button2");
            this.guna2Button2.Animated = true;
            this.guna2Button2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button2.BorderColor = System.Drawing.Color.Gray;
            this.guna2Button2.BorderThickness = 2;
            this.guna2Button2.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.DarkSlateGray;
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.PressedColor = System.Drawing.Color.White;
            this.guna2Button2.UseTransparentBackground = true;
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2Button3
            // 
            resources.ApplyResources(this.guna2Button3, "guna2Button3");
            this.guna2Button3.Animated = true;
            this.guna2Button3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button3.BorderColor = System.Drawing.Color.Gray;
            this.guna2Button3.BorderThickness = 2;
            this.guna2Button3.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.DarkSlateGray;
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.PressedColor = System.Drawing.Color.White;
            this.guna2Button3.UseTransparentBackground = true;
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // guna2Button4
            // 
            resources.ApplyResources(this.guna2Button4, "guna2Button4");
            this.guna2Button4.Animated = true;
            this.guna2Button4.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button4.BorderColor = System.Drawing.Color.Gray;
            this.guna2Button4.BorderThickness = 2;
            this.guna2Button4.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button4.FillColor = System.Drawing.Color.DarkSlateGray;
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.PressedColor = System.Drawing.Color.White;
            this.guna2Button4.UseTransparentBackground = true;
            this.guna2Button4.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // imagebinderIB
            // 
            resources.ApplyResources(this.imagebinderIB, "imagebinderIB");
            this.imagebinderIB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.imagebinderIB.Image = global::Binder.Properties.Resources.IMAGE_BINDER_45x45;
            this.imagebinderIB.ImageRotate = 0F;
            this.imagebinderIB.Name = "imagebinderIB";
            this.imagebinderIB.TabStop = false;
            // 
            // drag2
            // 
            this.drag2.DockIndicatorTransparencyValue = 0.6D;
            this.drag2.TargetControl = this.imagebinderIB;
            this.drag2.UseTransparentDrag = true;
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
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.guna2Button3);
            this.Controls.Add(this.guna2Button4);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BinderWindow";
            this.tabs.ResumeLayout(false);
            this.home.ResumeLayout(false);
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
        private System.Windows.Forms.TabPage home;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button homebutton;
        private Tabs.Home home1;
        private Guna.UI2.WinForms.Guna2PictureBox imagebinderIB;
        private Guna.UI2.WinForms.Guna2DragControl drag2;
    }
}

