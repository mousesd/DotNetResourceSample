using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class Product
    {
        private string name;
        private double price;
        private string companyName;

        public Product() : this(string.Empty, 0.0) { }

        public Product(string name, double price) : this(string.Empty, 0.0, string.Empty)
        {
        }

        public Product(string name, double price, string companyName)
        {
            this.name = name;
            this.price = price;
            this.companyName = companyName;
        }
    }

    public class Keyboard : Product
    {
        private bool isTenkeyless = true;

        public Keyboard() : base("Keyboard", 18.0)
        {

        }
    }
}
