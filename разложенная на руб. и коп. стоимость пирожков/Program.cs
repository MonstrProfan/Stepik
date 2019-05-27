using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace разложенная_на_руб.и_коп.стоимость_пирожков
    {
    class Program
        {
        static void Main ()
            {
            /*
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());
            */

            int a = 5;
            int b = 50;
            int n = 2;

            a = a * n + (b * n / 100);
            b = b * n % 100;

            Console.WriteLine($"{a} {b}");

            Console.ReadKey();
            }
        }
    }
