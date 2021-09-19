using System;
using System.Windows.Forms;

namespace Sample
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            selectDirectoryDialog.DirectoryName = textBoxDirectoryName.Text;
            DialogResult result = selectDirectoryDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                textBoxDirectoryName.Text = selectDirectoryDialog.DirectoryName;
            }
        }

        private void formClosing(object sender, FormClosingEventArgs e)
        {
            selectDirectoryDialog.Dispose();
        }
    }
}
