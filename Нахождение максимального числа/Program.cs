using System;

namespace Нахождение_максимального_числа
{
    class Program
    {
        static void Main()
        {
            /*нахождение максимального числа*/
            /*
              int a = Convert.ToInt32(Console.ReadLine());
              int b = Convert.ToInt32(Console.ReadLine());
            */
            int a = 313;
            int b = 3;

            if (a == b)
            {
                Console.WriteLine(a);
            }
            else
            {
                if (a > b)
                {
                    Console.WriteLine(a);
                }
                else
                {
                    Console.WriteLine(b);
                }
            }

            /*знак числа*/

            if (a == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                if (a > 0)
                {
                    Console.WriteLine(1);
                }
                else
                {
                    Console.WriteLine(-1);
                }
            }

            /* определение четного числа*/

            if (a % 2 == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

            /* проверка деления на цело*/

            double c = (double)a / b;

            if (c % 1 == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

            //Console.WriteLine(c);


            /*определение различности цифр в разрядах числа*/

            int a1 = a / 100;
            int a2 = (a - a1 * 100)/10;
            int a3 = a % 10;

            if (a1 != a2 && a2 != a3 && a1 != a3)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

            //Console.WriteLine($"{a}\t {a1}\t {a2}\t {a3}");

            /*определение счастливого билета*/

            int x = Convert.ToInt32(Console.ReadLine());
            int b = (int)Math.Abs(x);
            int x1 = b / 100000;

            int x2 = (b - x1 * 100000) / 10000;
            int x22 = b - x1 * 100000;

            int x3 = x2 * 10000;
            int x33 = x22 - x3;
            x3 = x33 / 1000;

            int x4 = x3 * 1000;
            int x44 = x33 - x4;
            x4 = x44 / 100;

            int x5 = x4 * 100;
            int x55 = x44 - x5;
            x5 = x55 / 10;

            int x6 = b % 10;

            if (x1 + x2 + x3 == x4 + x5 + x6)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

            /*зона ладьи*/

            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());

            if (y1 == y2 || x1 == x2)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

            /*зона слона*/

            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());

            if ((x1 + y1 == x2 + y2) || (x1 - y1 == y2 - y2))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");

            }


            Console.ReadKey();
        }
    }
}
