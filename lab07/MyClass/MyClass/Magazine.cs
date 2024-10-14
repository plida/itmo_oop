using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass
{
    internal class Magazine : Item
    {
        private String volume;
        private int number;
        private String title;
        private int year;

        public Magazine(string volume, int number, string title, 
            int year, long invNumber, bool taken) : base(invNumber, taken)
        {
            this.volume = volume;
            this.number = number;
            this.title = title;
            this.year = year;
        }
        public Magazine() { }

        public override void Show()
        {
            Console.WriteLine("\nЖурнал:\n Том: {0}\n Номер: {1}\n Название: " +
                "{2}\n Год выпуска: {3}", volume, number, title, year);
            base.Show();
        }

        public override void Return()
        {
            taken = true;
        }
    }
}
