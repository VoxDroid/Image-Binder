using Binder.Tabs;
using System;
using System.Windows.Forms;

namespace Binder
{
    public partial class BinderWindow : Form
    {
        private static BinderWindow instance;

        public static BinderWindow Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new BinderWindow();
                }
                return instance;
            }
        }

        public BinderWindow()
        {
            InitializeComponent();

            var settingsTab = new SettingsTab();

            instance = this;
            this.TopMost = Properties.Settings.Default.AlwaysOnTop;
        }


        private void homebutton_Click(object sender, EventArgs e)
        {
            tabs.SelectedTab = hometab;
        }

        private void settingsbutton_Click(object sender, EventArgs e)
        {
            tabs.SelectedTab = settingstab;
        }

        private void aboutbutton_Click(object sender, EventArgs e)
        {
            tabs.SelectedTab = abouttab;
        }

        private void appbar_Click(object sender, EventArgs e)
        {
            appbar.Focus();
        }

        private void BinderWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
        }
    }
}