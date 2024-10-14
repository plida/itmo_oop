using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progressions
{
    internal class ArithmeticProgression : Progression
    {
        public ArithmeticProgression(){}

        public ArithmeticProgression(int start, int diff) : base(start, diff) { }

        public override int GetElement(int k)
        {
            int elem = start + (k - 1) * diff;
            return elem;
        }

        public override void PrintElement(int k)
        {
            Console.WriteLine("{0}-й элемент арифметической прогрессии: {1}", k, GetElement(k));
        }

        public override void Show()
        {
            Console.WriteLine("\nАрифметическая прогрессия: a1 = {0}, d = {1}", start, diff);
        }
    }
}
