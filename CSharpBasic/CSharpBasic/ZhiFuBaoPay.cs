﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic
{
    internal class ZhiFuBaoPay : IPay
    {
        public void Pay()
        {
            Console.WriteLine("this is zhifubao pay");
        }
    }
}
