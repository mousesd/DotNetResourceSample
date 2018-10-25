using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    #region == UnmanagedResource class ==
    public class UnmanagedResource
    {
        private static readonly string FileName = "ReadMe.txt";
        private readonly IntPtr handle;

        public UnmanagedResource()
        {
            handle = Marshal.StringToHGlobalAnsi(FileName);
        }

        public string GetFileName()
        {
            return Marshal.PtrToStringAnsi(handle);
        }

        public void Clear()
        {
            Marshal.FreeHGlobal(handle);
        }
    }
    #endregion

    #region == UnmanagedResourceEx class ==
    public class UnmanagedResourceEx
    {
        private static readonly string FileName = "ReadMe.txt";
        private readonly IntPtr handle;

        public UnmanagedResourceEx()
        {
            handle = Marshal.StringToHGlobalAnsi(FileName);
        }

        ~UnmanagedResourceEx()
        {
            this.InternalClear();
        }

        public string GetFileName()
        {
            return Marshal.PtrToStringAnsi(handle);
        }

        public void Clear()
        {
            this.InternalClear();
        }

        private void InternalClear()
        {
            Marshal.FreeHGlobal(handle);
        }
    } 
    #endregion
}
