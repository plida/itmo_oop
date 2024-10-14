using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Item item1 = new Item();
            // item1.Show();

            /*Book b2 = new Book("Толстой Л.Н.", "Война и мир",
                "Наука и жизнь", 1234, 2013, 101, true);
            b2.TakeItem();
            b2.Show();

            Magazine mag1 = new Magazine("О природе",
                5, "Земля и мы", 2014, 1235, true);
            mag1.Show();

            Console.WriteLine("\n Тестирование полиморфизма");
            Item it;

            it = b2;
            it.TakeItem();
            it.Return();
            it.Show();

            it = mag1;
            it.TakeItem();
            it.Return();
            it.Show();*/

            Book b4 = new Book("Толстой Л.Н.", "Анна Каренина", "Знание",
                1204, 2014, 103, true);
            Book b5 = new Book("Неш Т", "Программирование для профессионалов", "Вильямс",
                1200, 2014, 108, true);

            
            b4.ReturnSrok = true;
            b5.ReturnSrok = true;

            System.Console.WriteLine("\nКниги возвращены в срок: ");
            b4.ProcessPaperbackBooks(Operation.PrintTitle);
            b5.ProcessPaperbackBooks(Operation.PrintTitle);
        }
    }
}
