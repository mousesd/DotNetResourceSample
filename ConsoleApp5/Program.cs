using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            #region == 1.비관리 리소스 정리 ==
            //# 1.Questions) UnmanagedResource 클래스의 문제점은?
            //# - 개발자가
            //var unmanaged = new UnmanagedResource();
            //Console.WriteLine($"FileName: {unmanaged.GetFileName()}");
            //unmanaged.Clear();

            //# 2.Questions) UnmanagedResourceEx 클래스의 문제점은?
            //# - 메모리에
            //var unmanaged = new UnmanagedResourceEx();
            //Console.WriteLine($"FileName: {unmanaged.GetFileName()}");
            //unmanaged.Clear();
            #endregion

            #region == 2.IDisposeable 구현 및 Dispose pattern ==
            //# 1.
            //var pattern = new DisposePattern();
            //Console.WriteLine(pattern.ReadAllLine());

            //# 2.
            //using (var pattern = new DisposePattern())
            //    Console.WriteLine(pattern.ReadAllLine());

            //# 3.
            //var pattern = new DerivedDisposePattern();
            //Console.WriteLine(pattern.ReadAllLine());

            //# 4.
            //using (var pattern = new DerivedDisposePattern())
            //    Console.WriteLine(pattern.ReadAllLine());
            #endregion

            Console.ReadKey();
        }
    }
}
