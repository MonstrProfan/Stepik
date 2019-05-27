using System;

namespace Целые_числа
    {
    class Program
        {
        /// <summary>
        /// сумма переменных
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        static int Sum (int a, int b, int c)
            {
            return a + b + c;
            }

        /// <summary>
        /// Произведение целых переменных
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        static int Proiz (int a, int b, int c)
            {
            return a * b * c;
            }

        /// <summary>
        /// Целое колличество яблок на 1 школьника
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static int CIpol (int a, int b)
            {
            return b / a;
            }

        /// <summary>
        /// нахождение неделимого остатка
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static int OIpol (int a, int b)
            {
            return b % a;
            }

        static void Main ()
            {

            /*
            int x = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            */

            int a = 2;
            int x = 3;
            int b = 7;
            int c = 10;

            Console.WriteLine($"{Sum(a, b, c)} {Proiz(a, b, c)}");
            Console.WriteLine($"{CIpol(a, b)}");
            Console.WriteLine($"{OIpol(a, b)}");

            int a = x * x;
            int b = a * a;
            int c = a * b;

            Console.WriteLine(c);

            Console.ReadKey();
            }
        }
    }
