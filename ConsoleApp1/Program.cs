using System;
using System.Collections.Generic;
using BenchmarkDotNet.Running;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region == #1.Boxing, Unboxing ==
            //int index = 100;

            ////# Boxing
            //object referenceType = index;
            //Console.WriteLine($"referenceType={referenceType}");

            ////# Unboxing
            //int copiedIndex = (int)referenceType;
            //Console.WriteLine($"copyIndex={copiedIndex}");

            ////# Question #1)
            //index = 200;
            //Console.WriteLine($"referenceType={referenceType}");
            //Console.WriteLine($"copyIndex={copiedIndex}");

            ////# Question #2)
            //copiedIndex = 200;
            //Console.WriteLine($"referenceType={referenceType}");
            //Console.WriteLine($"index={index}");
            #endregion

            #region == #2.Performance #1) ==
            //BenchmarkRunner.Run<BoxingUnboxingBenchmark>();
            #endregion

            #region == #3.Performance #2) ==
            //BenchmarkRunner.Run<CustomerSortBenchmark>();
            #endregion

            Console.ReadLine();
        }
    }
}
