using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Binder.Tabs
{
    public partial class AboutTab : UserControl
    {
        public AboutTab()
        {
            InitializeComponent();
        }
        private void byvox_Click(object sender, EventArgs e)
        {
            string urlToOpen = "https://github.com/VoxDroid/";
            Process.Start(urlToOpen);
        }

        private void imagebinderlabel_Click(object sender, EventArgs e)
        {
            string urlToOpen = "https://github.com/VoxDroid/Image-Binder";
            Process.Start(urlToOpen);
        }

        private void ToolTips()
        {
            tooltip.SetToolTip(imagebinderlabel, "Click this to open the github repository page.");
            tooltip.SetToolTip(byvox, "Click this to open my github page.");
        }

        private void RemoveAllToolTips()
        {
            foreach (Control control in this.Controls)
            {
                tooltip.SetToolTip(control, string.Empty);
            }
        }

        private void AboutTab_Enter(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.ShowToolTips == true)
            {
                ToolTips();
            }
            else
            {
                RemoveAllToolTips();
            }
        }
    }
}
