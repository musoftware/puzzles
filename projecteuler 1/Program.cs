using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projecteuler_1
{
    class Program
    {
        //https://projecteuler.net/problem=1
        static uint target = 10;

        static uint sumfrom1(uint n)
        {
            uint p = (target - 1) / n;
            return n * (p * (p + 1)) / 2;
        }

        static void Main(string[] args)
        {
            uint res = sumfrom1(3) + sumfrom1(5) - sumfrom1(15);
            Console.WriteLine(res);
            Console.Read();
        }
    }
}
