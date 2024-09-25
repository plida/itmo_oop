using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapeifelse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x=");
            float x = float.Parse(Console.ReadLine());
            Console.Write("y=");
            float y = float.Parse(Console.ReadLine());
            Console.WriteLine("Где точка?");
            if (x * x + y * y < 9 && y > 0)
            {
                Console.WriteLine("Внутри области");
            }
            else if (x * x + y * y > 9 || y < 0)
            {
                Console.WriteLine("Вне области");
            }
            else
            {
                Console.WriteLine("На границе области");
            }
        }
    }
}
