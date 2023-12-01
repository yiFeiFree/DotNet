using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic
{
    internal class MyEnum
    {
        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }

        enum Sex
        {
            Man,
            Women,
        }
        public void Test()
        {
            Sex sex = Sex.Man;
            switch (sex)
            {
                case Sex.Man:
                    break;
                case Sex.Women:
                    break;
                default:
                    break;
            }
            string a = "Man";
            Sex s = (Sex)Enum.Parse(typeof(Sex), a);
            Console.WriteLine(s);
        }
    }
}
