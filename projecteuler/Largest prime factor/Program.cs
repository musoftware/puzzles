using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Largest_prime_factor
{
    class Program
    {

        static bool isprime(ulong input)
        {
            if (input < 2) return false;
            bool isprime = true;
            for (ulong i = 2; i <= input / 2; i++)
                if (input % i == 0)
                {
                    isprime = false;
                    break;
                }
            return isprime;
        }

        static int max(ulong[] input)
        {
            int res = 0;
            foreach (int n in input)
                res = Math.Max(res, n);
            return res;
        }

        static void Main(string[] args)
        {
            ulong input = 600851475143;
            ulong t = input;

            List<ulong> list = new List<ulong>();
            for (ulong i = 3; i <= t; i++)
            {
                if (isprime(i) & (t % i == 0))
                {
                    t /= i;
                    list.Add(i);
                }
            }
            Console.WriteLine(max(list.ToArray()));
            Console.Read();
        }
    }
}
