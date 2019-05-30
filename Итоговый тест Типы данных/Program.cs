using System;

namespace Итоговый_тест_Типы_данных
{
    class Program
    {
        static void Main()
        {
            /*гипотенуза треугольника с заданными катетами*/

            /*
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            */

            double a = 3;
            double b = 4;

            double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

            Console.WriteLine(c);

            /*нахождение сотен числа*/

            /*
             int a1 = Convert.ToInt32(Console.ReadLine());
            */

            int a1 = 321;

            a1 = (a1 / 100)%10;
            
            Console.WriteLine(a1);

            Console.ReadKey();
        }
    }
}
