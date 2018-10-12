using BenchmarkDotNet.Attributes;

namespace ConsoleApp1
{
    [MemoryDiagnoser]
    public class BoxingUnboxingBenchmark
    {
        [Benchmark]
        public void MaximizeBoxingUnboxing()
        {
            for (int index = 0; index < 1000; index++)
            {
                object temp = "Index=" + index;
                //object temp = $"Index={index}";
            }
        }

        [Benchmark(Baseline = true)]
        public void MinimizeBoxingUnboxing()
        {
            for (int index = 0; index < 1000; index++)
            {
                object temp = $"Index={index.ToString()}";
            }
        }
    }
}
