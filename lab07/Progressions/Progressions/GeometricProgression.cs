using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progressions
{
    internal class GeometricProgression : Progression
    {
        public GeometricProgression(){}

        public GeometricProgression(int start, int diff) : base(start, diff) { }

        public override int GetElement(int k)
        {
            int elem = start * (int)Math.Pow(diff, k - 1);
            return elem;
        }

        public override void PrintElement(int k)
        {
            Console.WriteLine("{0}-й элемент геометрической прогрессии: {1}", k, GetElement(k));
        }

        public override void Show()
        {
            Console.WriteLine("\nГеометрическая прогрессия: b1 = {0}, q = {1}", start, diff);
        }
    }
}
