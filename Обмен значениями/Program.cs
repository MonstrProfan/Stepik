using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Обмен_значениями
    {
    class Program
        {
        static void Main ()
            {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c;

            c = a;
            a = b;
            b = c;

            Console.WriteLine($"{a} {b}");

            Console.ReadKey();
            }
        }
    }
