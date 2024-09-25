using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distance
{
    public struct Distance
    {
        public int feet;
        public int inches;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Distance dist1, dist2, dist3;

                Console.Write("Введите значение футов первой переменной: ");
                dist1.feet = int.Parse(Console.ReadLine());
                Console.Write("Введите значение дюймов первой переменной: ");
                dist1.inches = int.Parse(Console.ReadLine());

                Console.Write("Введите значение футов второй переменной: ");
                dist2.feet = int.Parse(Console.ReadLine());
                Console.Write("Введите значение дюймов второй переменной: ");
                dist2.inches = int.Parse(Console.ReadLine());

                dist3.inches = dist1.inches + dist2.inches;
                dist3.feet = dist1.feet + dist2.feet;

                dist3.feet += (int)(dist3.inches / 12);
                dist3.inches = dist3.inches % 12;

                Console.WriteLine("Сумма переменных: {0} '- {1}''", dist3.feet, dist3.inches);
            }
            catch (Exception e)
            {
                Console.WriteLine("An exception was thrown: {0}", e);
            }
            
        }
    }
}
