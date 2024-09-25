using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***ВВЕДИТЕ КОЭФФИЦИЕНТЫ КВАДРАТИЧНОГО УРАВНЕНИЯ***");
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("{0}, {1}, {2}", a, b, c);
            int res = Utils.FindSolution(a, b, c, out double x1, out double x2);
            if (res == 1)
            {
                Console.WriteLine("Корни уравнения с коэффициентами " +
                    "a = {0:F2} b = {1:F2} c = {2:F2} равны x1 = {3:F2} x2 = {4:F2}", a, b, c, x1, x2);
            }
            else if (res == 0)
            {
                Console.WriteLine("Корень уравнения с коэффициентами " +
                    "a = {0:F2} b = {1:F2} c = {2:F2} равен {3:F2}", a, b, c, x1);
            }
            else
            {
                Console.WriteLine("Корней уравнения с коэффициентами " +
                    "a = {0:F2} b = {1:F2} c = {2:F2} не существует", a, b, c);
            }

        }
    }
}
