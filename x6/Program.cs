using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace x6
    {
    class Program
        {
        static void Main ()
            {
            /* int x = Convert.ToInt32(Console.ReadLine());*/

            int x = 2;

            int a = x * x;
            int b = a * a;
            int c = a * b;

            Console.WriteLine($"{c} проверка {Math.Pow(x,6)}");

            Console.ReadKey();
            }
        }
    }
