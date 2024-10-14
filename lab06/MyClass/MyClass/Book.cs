using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass
{
    internal class Book
    {
        private String author;      // автор
        private String title;       // название
        private String publisher;   // издательство
        private int pages;          // кол-во страниц
        private int year;           // год издания

        private static double price = 9;  // стоимость аренды

        static Book()
        {
            price = 10;
        }

        public Book()
        {}

        public Book(String author, String title)
        {
            this.author = author;
            this.title = title;
        }

        public Book(String author, String title, String publisher, int pages, int year)
        {
            this.author = author;
            this.title = title;
            this.publisher = publisher;
            this.pages = pages;
            this.year = year;
        }

        public void SetBook(String author, String title, String publisher, int pages, int year)
        {
            this.author = author;
            this.title = title;
            this.publisher = publisher;
            this.pages = pages;
            this.year = year;
        }

        public static void SetPrice(double price)
        {
            Book.price = price;
        }

        public void Show()
        {
            Console.WriteLine("\nКнига:\n Автор: {0}\n Название: {1}\n Год издания: {2}\n {3} стр." +
                "\n Стоимость аренды: {4}", author, title, year, pages, Book.price);

        }

        public double PriceBook(int s)
        {
            double cust = s * price;
            return cust;
        }
    }
}
