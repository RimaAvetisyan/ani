﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;

            while (i < 999)
            {


                if (i % 10 == 1 || i % 10 == 5 || i % 10 == 6)
                {
                    Console.WriteLine(i);
                }
                i++;
            }

            Console.ReadKey();
        }
    }
}
