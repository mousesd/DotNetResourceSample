using System;
using System.Collections.Generic;
using System.Text;
using BenchmarkDotNet.Attributes;

namespace ConsoleApp2
{
    #region == Question ==
    public class CreateDuplicateObject
    {
        private List<string> labels = new List<string>();

        public CreateDuplicateObject() { }

        public CreateDuplicateObject(int capacity)
        {
            labels = new List<string>(capacity);
        }
    }
    #endregion

    #region == Answer ==
    public class CreateDuplicateObjectEx
    {
        private List<string> labels;

        public CreateDuplicateObjectEx()
        {
            labels = new List<string>();
        }

        public CreateDuplicateObjectEx(int capacity)
        {
            labels = new List<string>(capacity);
        }
    } 
    #endregion
}
