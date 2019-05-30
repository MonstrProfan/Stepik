using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            double c = Math.Sqrt(Math.Pow(a,2)+Math.Pow(b,2));

            Console.WriteLine(c);

            Console.ReadKey();
        }
    }
}
