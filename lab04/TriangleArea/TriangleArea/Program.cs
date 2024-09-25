using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** ВЫБЕРИТЕ ТРЕУГОЛЬНИК ***");
            Console.Write("1 - равносторонний, любая другая клавиша - обычный: ");
            string triangle_type = Console.ReadLine();
            if (triangle_type == "1")
            {
                double a, area;
                Console.Write("a = ");
                a = double.Parse(Console.ReadLine());
                if (Operation.CalcArea(a, out area))
                    Console.WriteLine("Площадь равностороннего треугольника со стороной {0:F2} = {1:F2}", a, area);
                else
                    Console.WriteLine("Что-то пошло не так... Перепроверьте ввод данных!");
            }
            else
            {
                double a, b, c, area;
                Console.Write("a = ");
                a = double.Parse(Console.ReadLine());
                Console.Write("b = ");
                b = double.Parse(Console.ReadLine());
                Console.Write("c = ");
                c = double.Parse(Console.ReadLine());
                if (Operation.CalcArea(a, b, c, out area))
                    Console.WriteLine("Площадь треугольника со сторонами {0:F2}, {1:F2}, {2:F2} = {3:F2}", a, b, c, area);
                else
                    Console.WriteLine("Что-то пошло не так... Перепроверьте ввод данных!");

            }

        }
    }
}
