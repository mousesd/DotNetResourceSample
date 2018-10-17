using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    public class Base
    {
        protected Base()
        {
            this.PrintMessage();
        }

        public virtual void PrintMessage()
        {
            Console.WriteLine("VirtualMethod in Base class");
        }
    }

    public class Derived : Base
    {
        private readonly string message = "Readonly message";
        public Derived(string message)
        {
            this.message = message;
        }

        public override void PrintMessage()
        {
            Console.WriteLine(message);
        }
    }
}
