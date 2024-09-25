using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Infralution.Localization;
using System.Windows.Forms;

namespace WinformsLocalizationNetFramework4._6._2Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void romanianToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CultureManager.ApplicationUICulture = new CultureInfo("ro");
        }

        private void italianToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CultureManager.ApplicationUICulture = new CultureInfo("it");
        }

        private void frenchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CultureManager.ApplicationUICulture = new CultureInfo("fr");
        }
    }
}
