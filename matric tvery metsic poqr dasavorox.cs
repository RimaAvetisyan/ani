using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp36
{
    class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int n);
            Random rnd = new Random();
            int[] a = new int[n];

            for(int i = 0; i <n ; i++)
            {
                a[i] = rnd.Next(-100, 101);
                Console.Write(a[i] + "\t");
            }
            Console.WriteLine();
            int max = -101;
            int index = -1;
            for (int i = 0; i < n; i++)
            {

            
                    if (a[i]>max)
                    {
                    max = a[i];
                    index = i;
                    }
                
            }
            
                Console.WriteLine($"max ={max},index={index}");
            
            Console.ReadKey();
        }
    }
}
