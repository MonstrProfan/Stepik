using System;

namespace Среднее_арифметическое_целых_чисел
    {
    class Program
        {
        static void Main ()
            {
            /*вывод дробной части числа*/

            /*
            double x = Convert.ToDouble(Console.ReadLine());
            */

            double x = 5.8;

            double n = x % 1;

            Console.WriteLine(n);
            Console.ReadKey();
            }
        }
    }
