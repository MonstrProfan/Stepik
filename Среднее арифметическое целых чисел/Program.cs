﻿using System;

namespace Среднее_арифметическое_целых_чисел
    {
    class Program
        {
        static void Main ()
            {
            /*среднее арифметическое целых чисел*/

            /*
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            */
            int a = 1;
            int b = 3;

            double c = (double)(a + b) / 2;

            Console.WriteLine(c);

            /*площадь круга*/

            /*
            double r = Convert.ToDouble(Console.ReadLine());
            */

            double r = 2;

            double s = 3.14 * Math.Pow(r, 2);

            Console.WriteLine(s);

            /*перевод байт в Кбайт*/

            /*
            int a = Convert.ToInt32(Console.ReadLine());
           */

            int a1 = 8192;

            double n = a1 / Math.Pow(2, 13);

            Console.WriteLine(n);

            Console.ReadKey();
            }
        }
    }
