using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Largest_palindrome_product
{
    class Program
    {
        static bool ispalin(int num)
        {
            string rev = string.Join("", num.ToString().Reverse());
            return rev == num.ToString();
        }

        //static int max(int[] input)
        //{
        //    int res = 0;
        //    foreach (int n in input)
        //        res = Math.Max(res, n);
        //    return res;
        //}

        static void Main(string[] args)
        {
            int res = 0;

            List<int> list = new List<int>();
            for (int y = 999; y >= 100; y--)
            {
                for (int x = y; x >= 100; x--)
                {
                    int i = y * x;
                    if (ispalin(i))
                        if (i > res)
                        {
                            res = i;
                        }
                        else
                        {
                            break;
                        }
                }
            }
            Console.WriteLine(res);
            Console.Read();
        }
    }
}
