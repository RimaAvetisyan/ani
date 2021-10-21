using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1000;
            int a;
            int b;
            int c;
            int d;

            while (i < 10000)
            {
                a = i / 1000;
                b = i / 100 % 10;
                c = i / 10 % 10;
                d = i % 10;

                if ((a * 10 + b) - (c * 10 + d) == a + b + c + d)
                {
                    Console.WriteLine(i);
                }
                i++;
            }

            Console.ReadKey();
        }
    }
}
