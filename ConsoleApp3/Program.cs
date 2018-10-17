using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region == 1.생성자 체인 ==
            //# Question) 문제점은?
            //# 1) 
            //# 2) 
            //var product = new Product("PHONE_01", "iPhone6s", new DateTime(2014, 1, 1));
            //Console.WriteLine(product);
            #endregion

            #region == 2.기본값 파라메터를 사용하는 생성자 ==
            //# Question) 문제점은?
            var product = new ProductWithDefaultValueParams(name: "iPhone6s");
            #endregion

            #region == 3.Builder pattern ==
            #endregion

            Console.ReadLine();
        }
    }
}
