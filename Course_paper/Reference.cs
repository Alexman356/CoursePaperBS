using System;
using System.Windows.Forms;

namespace Course_paper
{
    public partial class Reference : Form
    {
        MainForm mainform;
        public Reference(MainForm mainform)
        {
            InitializeComponent();
            this.mainform = mainform;
            mainform.Enabled = false;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Reference_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
            mainform.Enabled = true;
        }
    }
}
