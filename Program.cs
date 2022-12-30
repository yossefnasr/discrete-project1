// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOS
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.Write("Enter a number: ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("\n");
            for (int i = 2; i < n; i++)
            {
                int j;
                for (j = 2; j < i; j++)
                {
                    if (i % j == 0) break;
                }
                if (j == i) Console.Write("{0}, ", i);
            }

            Console.ReadKey();
        }
    }
}