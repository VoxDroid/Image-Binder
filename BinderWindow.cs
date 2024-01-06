using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using PdfSharp.Drawing;
using PdfSharp.Pdf;

namespace Binder
{
    public partial class BinderWindow : Form
    {

        public BinderWindow()
        {
            InitializeComponent();
        }

        private void homebutton_Click(object sender, EventArgs e)
        {
            tabs.SelectedTab = home;
        }
    }
}