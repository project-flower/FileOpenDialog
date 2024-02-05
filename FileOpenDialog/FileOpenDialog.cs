using NativeMethods;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace System.Windows.Forms
{
    [DesignerCategory("Code")]
    public abstract partial class FileOpenDialog : CommonDialog
    {
        #region Private Fields

        private IFileOpenDialog dialog;
        private readonly FileOpenDialogOptions options;
        private readonly bool reusable;

        #endregion

        #region Public Properties

        protected string DisplayName
        {
            get; set;
        }

        #endregion

        #region Public Methods

        public FileOpenDialog(FileOpenDialogOptions options, bool reusable)
        {
            this.options = options;
            this.reusable = reusable;

            if (reusable)
            {
                GenerateDialog();
            }
        }

        public new void Dispose()
        {
            ReleaseDialog();
            base.Dispose();
        }

        public override void Reset()
        {
            DisplayName = string.Empty;
        }

        #endregion

        #region Protected Methods

        protected override bool RunDialog(IntPtr hwndOwner)
        {
            if (!reusable)
            {
                GenerateDialog();
            }

            try
            {
                IShellItem item;
                IntPtr pidl;
                bool setDirectory;

                if (string.IsNullOrEmpty(DisplayName))
                {
                    setDirectory = (Shell32.SHGetSpecialFolderLocation(IntPtr.Zero, CSIDL.DRIVES, out pidl) == 0);
                }
                else
                {
                    uint rgfInOut = 0;
                    setDirectory = (Shell32.SHILCreateFromPath(DisplayName, out pidl, ref rgfInOut) == 0);
                }

                if (setDirectory)
                {
                    if (Shell32.SHCreateShellItem(IntPtr.Zero, IntPtr.Zero, pidl, out item) == 0)
                    {
                        dialog.SetFolder(item);
                    }

                    Marshal.FreeCoTaskMem(pidl);
                }

                uint result = dialog.Show(hwndOwner);

                if (result != 0)
                {
                    return false;
                }

                dialog.GetResult(out item);
                string directoryName;
                item.GetDisplayName(SIGDN.SIGDN_FILESYSPATH, out directoryName);
                DisplayName = directoryName;
                return true;
            }
            finally
            {
                if (!reusable)
                {
                    ReleaseDialog();
                }
            }
        }

        #endregion

        #region Private Methods

        private void GenerateDialog()
        {
            dialog = new NativeMethods.FileOpenDialog() as IFileOpenDialog;
            dialog.SetOptions((FILEOPENDIALOGOPTIONS)options | FILEOPENDIALOGOPTIONS.FOS_FORCEFILESYSTEM);
        }

        private void ReleaseDialog()
        {
            if (dialog != null)
            {
                Marshal.ReleaseComObject(dialog);
                dialog = null;
            }
        }

        #endregion
    }
}
