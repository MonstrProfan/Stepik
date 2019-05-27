using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Квадрат_числа
    {
    class Program
        {
        static void Main ()
            {
            // int a = Convert.ToInt32(Console.ReadLine());
            int a = 5;
           
            a = (int)Math.Pow(a, 2);
            Console.WriteLine(a);

            Console.ReadKey();
            }
        }
    }
