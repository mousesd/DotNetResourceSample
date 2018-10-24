using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class DisposePattern
    {
        private static readonly string FileName = "ReadMe.txt";
        private readonly StreamReader reader;
        private readonly IntPtr handle;

        public DisposePattern()
        {
            reader = new StreamReader(FileName);
            handle = Marshal.StringToHGlobalAnsi(FileName);
        }

        public virtual string ReadAllLine()
        {
            string line;
            var builder = new StringBuilder();
            while ((line = reader.ReadLine()) != null)
                builder.Append(line + Environment.NewLine);
            builder.Append(Marshal.PtrToStringAnsi(handle));

            return builder.ToString();
        }
    }

    public class DerivedDisposePattern : DisposePattern
    {
        private static readonly string FileName = "ReadMeEx.txt";
        private readonly StreamReader reader;
        private readonly IntPtr handle;

        public DerivedDisposePattern()
        {
            reader = new StreamReader(FileName);
            handle = Marshal.StringToHGlobalAnsi(FileName);
        }

        public override string ReadAllLine()
        {
            string line;
            var builder = new StringBuilder();
            while ((line = reader.ReadLine()) != null)
                builder.Append(line + Environment.NewLine);
            builder.Append(Marshal.PtrToStringAnsi(handle));

            return builder.ToString();
        }
    }
}
