using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 1;
            int t = 0;
            int res =0;
            while (b < 4000000)
            {
                t = b; b += a; a = t;
                if (t % 2 == 0)
                    res += t;
            }
            Console.WriteLine(res);
            Console.Read();
        }
    }
}
