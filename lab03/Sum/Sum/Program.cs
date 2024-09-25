using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Правая граница 1ого диапазона = ");
            int k = int.Parse(Console.ReadLine());
            Console.Write("Левая граница 2ого диапазона = ");
            int m = int.Parse(Console.ReadLine());
            int s = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i > k && i < m) continue;
                s += i;
            }
            Console.WriteLine("Сумма чисел от 1 до {0} и от {1} до 100 равна {2}", k, m, s);
        }
    }
}
