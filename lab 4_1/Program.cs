using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите целое положительное число");
            int n = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            int w = 1;
            for (int a=0; i <= n; i++)
            {
                w = (2 * i - 1);
                a = a + w;
                Console.WriteLine("Квадрат числа {0} равен {1}", i, a);
            }
            Console.ReadKey();
        }
    }
}
