using System;
using BenchmarkDotNet.Running;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region == 1.Background ==
            //# 1) 멤버 초기화(Member initialization) vs. 할당(Assignment)
            //# 2) 멤버 초기화 구문의 실행 순서
            //var product = new Product("Monitor", 50.0);
            //var keyboard = new Keyboard();
            //Console.WriteLine($"Name:{keyboard.Name}, Price:{keyboard.Price}");
            #endregion

            #region == 2.할당 구문 ==
            //# 1) 객체를 0 또는 1로 초기화 하는 경우
            //# 2) 동일객체를 반복해서 초기화 하는 경우(CreateDuplicateObject)
            //# 3) 초기화시 예외처리가 필요한 경우
            var failObject = new CreateDuplicateObject(null, 0);
            #endregion

            #region == 3.멤버 초기화 구문 ==
            //# 1) 여러개의 생성자가 있는 경우
            #endregion

            Console.ReadLine();
        }
    }
}
