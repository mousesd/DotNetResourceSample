using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;

namespace ConsoleApp1
{
    public struct Customer : IComparable
    {
        #region == Fields & Constructors ==
        private readonly string name;
        public string Name
        {
            get { return name; }
        }

        public Customer(string name)
        {
            this.name = name;
        }
        #endregion

        //# Question 3) 몇번의 Boxing, Unboxing이 발생?
        public int CompareTo(object obj)
        {
            if (!(obj is Customer))
                throw new ArgumentException("Argument is not a customer", nameof(obj));

            Customer other = (Customer)obj;
            return string.Compare(this.name, other.name, StringComparison.Ordinal);
        }
    }

    public struct CustomerEx : IComparable<CustomerEx>
    {
        #region == Fields & Constructors ==
        private readonly string name;
        public string Name
        {
            get { return name; }
        }

        public CustomerEx(string name)
        {
            this.name = name;
        }
        #endregion

        public int CompareTo(CustomerEx other)
        {
            return string.Compare(this.name, other.name, StringComparison.Ordinal);
        }
    }

    [MemoryDiagnoser]
    public class CustomerSortBenchmark
    {
        [Benchmark]
        public void PerformCustomerSort()
        {
            var random = new Random();
            var customers = new List<Customer>();
            for (int count = 0; count < 1000; count++)
                customers.Add(new Customer($"Customer{random.Next(1000)}"));

            customers.Sort();
        }

        [Benchmark(Baseline = true)]
        public void PerformCustomerExSort()
        {
            var random = new Random();
            var customers = new List<CustomerEx>();
            for (int count = 0; count < 1000; count++)
                customers.Add(new CustomerEx($"Customer{random.Next(1000)}"));

            customers.Sort();
        }
    }
}
