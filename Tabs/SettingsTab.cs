using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Binder.Tabs
{
    public partial class SettingsTab : UserControl
    {
        public SettingsTab()
        {
            InitializeComponent();
        }

        private void alwaysontopcb_CheckedChanged(object sender, EventArgs e)
        {
            if (alwaysontopcb.Checked)
            {
                BinderWindow.Instance.TopMost = true;
                Properties.Settings.Default["AlwaysOnTop"] = true;
            }
            else
            {
                BinderWindow.Instance.TopMost = false;
                Properties.Settings.Default["AlwaysOnTop"] = false;
            }
            Properties.Settings.Default.Save();
        }

        private void alwaysontoplabel_Click(object sender, EventArgs e)
        {
            switch (alwaysontopcb.Checked)
            {
                case true:
                    alwaysontopcb.Checked = false; break;
                case false:
                    alwaysontopcb.Checked = true; break;
            }
        }

        private void showtooltipscb_CheckedChanged(object sender, EventArgs e)
        {
            if (showtooltipscb.Checked)
            {
                Properties.Settings.Default["ShowToolTips"] = true;
            }
            else
            {
                Properties.Settings.Default["ShowToolTips"] = false;
            }
            Properties.Settings.Default.Save();
        }

        private void showtooltipslabel_Click_1(object sender, EventArgs e)
        {
            switch (showtooltipscb.Checked)
            {
                case true:
                    showtooltipscb.Checked = false; break;
                case false:
                    showtooltipscb.Checked = true; break;
            }
        }

        private void SettingsTab_Enter(object sender, EventArgs e)
        {
            alwaysontopcb.Checked = Properties.Settings.Default.AlwaysOnTop;
            showtooltipscb.Checked = Properties.Settings.Default.ShowToolTips;
        }
    }
}