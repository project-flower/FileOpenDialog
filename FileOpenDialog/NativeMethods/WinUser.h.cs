using System;
using System.Runtime.InteropServices;

namespace NativeMethods
{
    internal static partial class User32
    {
        #region Public Methods

        [DllImport(AssemblyName)]
        public static extern IntPtr GetActiveWindow();

        #endregion
    }
}
