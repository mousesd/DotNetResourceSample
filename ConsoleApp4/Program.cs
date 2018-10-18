using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region == 베이스 클래스의 생성자에서 가상멤버를 호출하는 경우 ==
            var derived = new Derived("Message in Main class");
            derived.PrintMessage();
            #endregion

            Console.ReadLine();
        }
    }
}
