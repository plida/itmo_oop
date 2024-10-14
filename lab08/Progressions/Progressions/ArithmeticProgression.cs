using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progressions
{
    internal class ArithmeticProgression : IProgression
    {
        public int diff { set; get; }
        public int start { set; get; }

        public ArithmeticProgression(){}

        public ArithmeticProgression(int start, int diff){
            this.start = start;
            this.diff = diff;
        }

        public int GetElement(int k)
        {
            int elem = start + (k - 1) * diff;
            return elem;
        }

        public void PrintElement(int k)
        {
            Console.WriteLine("{0}-й элемент арифметической прогрессии: {1}", k, GetElement(k));
        }

        public void Show()
        {
            Console.WriteLine("\nАрифметическая прогрессия: a1 = {0}, d = {1}", start, diff);
        }
    }
}
