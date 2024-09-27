using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // lab05
            int i;
            int[] myArray = { 100, 1, 32, 3, 14, 25, 6, 17, 8, 99 };
            for (i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] % 2 == 0) myArray[i] = 0;
                Console.Write(myArray[i] + " ");
            }

            // user input
            Console.Write("\nArray Length: ");
            int[] MyArray;
            int n = int.Parse(Console.ReadLine());
            MyArray = new int[n];
            for (i = 0; i < MyArray.Length; ++i)
            {
                Console.Write("a[{0}] = ", i);
                MyArray[i] = int.Parse(Console.ReadLine());
            }
            foreach (int elem in MyArray) Console.Write("{0} ", elem);

            // lab03
            Console.Write("\nn = ");
            n = int.Parse(Console.ReadLine());
            // while:
            Console.Write("\nwhile: \t\t");
            i = 1;
            while (i <= n)
            {
                Console.Write(" " + i);
                i += 2;
            }
            // do while:
            Console.Write("\ndo while: \t");
            i = 1;
            do
            {
                Console.Write(" " + i);
                i += 2;
            }
            while (i <= n);
            // for
            Console.Write("\nFor: \t\t");
            for (i = 1; i <= n; i += 2)
            {
                Console.Write(" " + i);
            }
            Console.WriteLine("\n");

            // Таблица синусов, постусловие

            double x, y;
            Console.Write("x1 = ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("x2 = ");
            double x2 = double.Parse(Console.ReadLine());

            x = x1;
            Console.WriteLine("x \t sin(x) \t");
            do
            {
                y = Math.Sin(x);
                Console.WriteLine("{0} \t {1:F3}", x, y);
                x = x + 0.01;
            }
            while (x <= x2);

            Console.WriteLine("\n");

            // Алгоритм Евклида, предусловие

            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            int temp;
            temp = a;
            while (temp != b)
            {
                a = temp;
                if (a < b)
                {
                    temp = a;
                    a = b;
                    b = temp;
                }
                temp = a - b;
                a = b;
            }
            Console.WriteLine("НОД заданных чисел = {0}", a);

            Console.WriteLine("\n");

            // Таблица синусов, предусловие

            Console.Write("x1 = ");
            x1 = double.Parse(Console.ReadLine());
            Console.Write("x2 = ");
            x2 = double.Parse(Console.ReadLine());

            x = x1;
            Console.WriteLine("x \t sin(x) \t");
            while (x <= x2)
            {
                y = Math.Sin(x);
                Console.WriteLine("{0} \t {1:F3}", x, y);
                x = x + 0.01;
            }

            Console.WriteLine("\n");

            // Алгоритм Евклида, постусловие
            Console.Write("a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = int.Parse(Console.ReadLine());
            temp = a;
            do
            {
                a = temp;
                if (a < b)
                {
                    temp = a;
                    a = b;
                    b = temp;
                }
                temp = a - b;
                a = b;
            }
            while (temp != b);
            Console.WriteLine("НОД заданных чисел = {0}", a);
        }
    }
}
