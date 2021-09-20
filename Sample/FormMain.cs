using System;
using System.Windows.Forms;

namespace Sample
{
    public partial class FormMain : Form
    {
        private readonly SelectDirectoryDialog selectDirectoryDialog2;

        public FormMain()
        {
            InitializeComponent();
            selectDirectoryDialog2 = new SelectDirectoryDialog(true);
        }

        private void buttonSelect1_Click(object sender, EventArgs e)
        {
            selectDirectoryDialog1.DirectoryName = textBoxDirectoryName.Text;
            DialogResult result = selectDirectoryDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                textBoxDirectoryName.Text = selectDirectoryDialog1.DirectoryName;
            }
        }

        private void buttonSelect2_Click(object sender, EventArgs e)
        {
            selectDirectoryDialog2.DirectoryName = textBoxDirectoryName.Text;
            DialogResult result = selectDirectoryDialog2.ShowDialog();

            if (result == DialogResult.OK)
            {
                textBoxDirectoryName.Text = selectDirectoryDialog2.DirectoryName;
            }
        }

        private void formClosing(object sender, FormClosingEventArgs e)
        {
            selectDirectoryDialog2.Dispose();
        }
    }
}
