using System;
using System.Runtime.InteropServices;

namespace Win32Api
{
    public static partial class User32
    {
        #region Public Methods

        [DllImport(AssemblyName)]
        public static extern IntPtr GetActiveWindow();

        #endregion
    }
}
