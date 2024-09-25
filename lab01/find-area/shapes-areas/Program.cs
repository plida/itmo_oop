using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes_areas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите периметр треугольника: ");
                double P = double.Parse(Console.ReadLine());
                double side = P / 3;
                double p = P / 2;
                double area = Math.Sqrt(p * Math.Pow((p - side), 3.00));
                Console.WriteLine($"Сторона Площадь");
                Console.WriteLine("{0,-7:F2} {1,-7:F2}", side, area);
            }
            catch (FormatException e)
            {
                Console.WriteLine("An format exception was thrown: { 0}", e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("An exception was thrown: {0}", e.Message);
            }
        }
    }
}
