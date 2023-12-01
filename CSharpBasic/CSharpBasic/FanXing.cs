using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic
{
    internal class FanXing
    {
        public T Max<T>(T a,T b)
        {
            return (dynamic)a > b ? a : b;
        }

        public void TestList()
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
        }
       
        
    }
}
