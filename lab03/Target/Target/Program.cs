using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Target
{
    public struct Dot
    {
        public double x;
        public double y;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Выбор мишени
            Console.Write("Выберите тип мишени (1/2): ");
            string target_type = Console.ReadLine();
            if (target_type != "2" && target_type != "1")
            {
                Console.WriteLine("Мишень не была выбрана.");
                return;
            }

            // Центр мишени
            Random rnd = new Random();
            Dot target_center;
            target_center.x = (rnd.NextDouble() * 2 - 1);
            target_center.y = (rnd.NextDouble() * 2 - 1);
            Console.WriteLine("Секретная информация: центр мишени {0} {1}", target_center.x, target_center.y);

            // Количество выстрелов
            Console.Write("Укажите количество выстрелов: ");
            int n = int.Parse(Console.ReadLine());

            // Выстрелы
            int count = 0;
            double x, y;
            for (int i = 0; i < n; i++)
            {
                // Выстрел
                Console.Write("x = ");
                x = double.Parse(Console.ReadLine()) + (rnd.NextDouble() * 2 - 1) / 5;
                Console.Write("y = ");
                y = double.Parse(Console.ReadLine()) + (rnd.NextDouble() * 2 - 1) / 5;
                Console.WriteLine("Координаты выстрела: x = {0}, y = {1}", x, y);
                double shot_at = Math.Pow(x - target_center.x, 2) + Math.Pow(y - target_center.y, 2);

                // Проверка
                if (target_type == "1")
                {
                    if (shot_at <= 1)
                    {
                        count = count + 10;
                    }
                    else if (shot_at <= 4)
                    {
                        count = count + 5;
                    }
                }
                else if (target_type == "2")
                {
                    if (shot_at <= 1)
                    {
                        count = count + 10;
                    }
                    else if (shot_at <= 4)
                    {
                        count = count + 5;
                    }
                    else if (shot_at <= 9)
                    {
                        count = count + 1;
                    }
                }
                Console.WriteLine("Текущая сумма очков: {0}", count);
            }
            Console.WriteLine(" ");
            Console.WriteLine("Итоговая сумма очков: {0}", count);
        }
    }
}
