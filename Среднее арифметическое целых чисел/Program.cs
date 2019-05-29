using System;

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

            /*периметр прямоугольного треугольника*/

            double a1 = Convert.ToDouble(Console.ReadLine());
            double b1 = Convert.ToDouble(Console.ReadLine());
            double P = a1 + b1 + (Math.Sqrt(Math.Pow(a1, 2) + Math.Pow(b1, 2)));
            Console.WriteLine("{0:#.##}", P);

            /*расстояние между точками*/

            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());

            double l = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));

            Console.WriteLine($"{l}");

            Console.ReadKey();
            }
        }
    }
