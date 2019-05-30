using System;

namespace Итоговый_тест_Типы_данных
{
    class Program
    {
        static void Main()
        {
            /*гипотенуза треугольника с заданными катетами*/
            #region
            /*
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            */

            double a = 3;
            double b = 4;

            double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

            Console.WriteLine(c);
            #endregion
            /*нахождение сотен числа*/
            #region
            /*
             int a1 = Convert.ToInt32(Console.ReadLine());
            */

            int a1 = 321;

            a1 = (a1 / 100)%10;
            
            Console.WriteLine(a1);
            #endregion
            /*n-й член арифметической прогрессии*/
            #region
            int aa = Convert.ToInt32(Console.ReadLine());
            double d = Convert.ToDouble(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());

            aa = aa + (int)(Math.Round(d) * (n - 1));

            Console.WriteLine($"{aa}");
            #endregion
            /*дележ яблок 3*/
            int n = Convert.ToInt32(Console.ReadLine());
            int k = Convert.ToInt32(Console.ReadLine());
            int s = (n - k % n) % n;

            Console.WriteLine($"{s}");

            Console.ReadKey();
        }
    }
}
