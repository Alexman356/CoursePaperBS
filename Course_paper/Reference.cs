using System;
using System.Windows.Forms;

namespace CoursePaper
{
    public partial class Reference : Form
    {
        MainForm mainForm;

        public Reference(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            mainForm.Enabled = false;
        }

        private void BtnBackClick(object sender, EventArgs e)
        {
            Close();
        }

        private void ReferenceFormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.Enabled = true;
        }
    }
}
