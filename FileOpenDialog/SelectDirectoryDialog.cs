using System.ComponentModel;

namespace System.Windows.Forms
{
    [DesignerCategory("Code")]
    public class SelectDirectoryDialog : FileOpenDialog
    {
        #region Public Properties

        [Category("データ")]
        public string DirectoryName
        {
            get { return DisplayName; }
            set { DisplayName = value; }
        }

        #endregion

        #region Public Methods

        public SelectDirectoryDialog() :
            this(false)
        {
        }

        public SelectDirectoryDialog(bool reusable) :
            base(FileOpenDialogOptions.PickFolders, reusable)
        {
        }

        #endregion
    }
}
