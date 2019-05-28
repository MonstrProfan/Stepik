using System;

namespace Последняя_цифра_числа
    {
    class Program
        {
        static void Main ()
            {
            // int a = Convert.ToInt32(Console.ReadLine());
            int a = 10;
            a = a % 10;
            Console.WriteLine(a);

            /*число десятков числа*/

            // int b = Convert.ToInt32(Console.ReadLine());

            int b = 1024;
            b = (b % 100) / 10;

            Console.WriteLine($"{b}");

            /*сумма цифр 3-х значного числа*/

            // int с = Convert.ToInt32(Console.ReadLine());

            int c = 125;

            int c1 = c / 100;
            int c2 = (c / 10) % 10;
            int c3 = c % 10;

            c = c1 + c2 + c3;

            Console.WriteLine($"{c} {c1} {c2} {c3}");

            /*перевернуть число на оборот*/

            // int с = Convert.ToInt32(Console.ReadLine());

            int c = 125;

            int c1 = c / 100;
            int c2 = (c / 10) % 10;
            int c3 = c % 10;

            Console.WriteLine($"{c} {c3}{c2}{c1}");


            Console.ReadLine();

            }
        }
    }
