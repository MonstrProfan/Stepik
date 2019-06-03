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
            int a = 3;
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

            Console.ReadKey();
        }
    }
}
