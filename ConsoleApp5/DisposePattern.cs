using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    #region == DisposePattern class ==
    public class DisposePattern : IDisposable
    {
        private static readonly string FileName = "ReadMe.txt";
        private readonly StreamReader reader;
        private readonly IntPtr handle;
        private bool isDisposed;

        public DisposePattern()
        {
            reader = new StreamReader(FileName);
            handle = Marshal.StringToHGlobalAnsi(FileName);
        }

        /// <summary>
        /// Finalizer
        /// </summary>
        ~DisposePattern()
        {
            this.Dispose(false);
        }

        public virtual string ReadAllLine()
        {
            if (isDisposed)
                throw new ObjectDisposedException(this.GetType().Name);

            string line;
            var builder = new StringBuilder();
            while ((line = reader.ReadLine()) != null)
                builder.Append(line + Environment.NewLine);
            builder.Append(Marshal.PtrToStringAnsi(handle));

            return builder.ToString();
        }

        #region == Implement member of the IDisposable interface ==
        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (isDisposed)
                return;

            Marshal.FreeHGlobal(handle);
            if (disposing && reader != null)
                reader.Dispose();

            isDisposed = true;
        }
        #endregion
    }
    #endregion

    #region == DerivedDisposePattern class ==
    public class DerivedDisposePattern : DisposePattern
    {
        private static readonly string FileName = "ReadMeEx.txt";
        private readonly StreamReader reader;
        private readonly IntPtr handle;
        private bool isDisposed;

        public DerivedDisposePattern()
        {
            reader = new StreamReader(FileName);
            handle = Marshal.StringToHGlobalAnsi(FileName);
        }

        ~DerivedDisposePattern()
        {
            this.Dispose(false);
        }

        public override string ReadAllLine()
        {
            if (isDisposed)
                throw new ObjectDisposedException(this.GetType().Name);

            string line;
            var builder = new StringBuilder();
            while ((line = reader.ReadLine()) != null)
                builder.Append(line + Environment.NewLine);
            builder.Append(Marshal.PtrToStringAnsi(handle));

            return builder.ToString();
        }

        #region == Override member of the base class ==
        protected override void Dispose(bool disposing)
        {
            if (isDisposed)
                return;

            base.Dispose(disposing);

            Marshal.FreeHGlobal(handle);
            if (disposing && reader != null)
                reader.Dispose();

            isDisposed = true;
        }
        #endregion
    } 
    #endregion
}
