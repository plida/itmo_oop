using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progressions
{
    internal class GeometricProgression : IProgression
    {
        public int diff { set; get; }
        public int start { set; get; }

        public GeometricProgression(){}

        public GeometricProgression(int start, int diff)
        {
            this.start = start;
            this.diff = diff;
        }

        public int GetElement(int k)
        {
            int elem = start * (int)Math.Pow(diff, k - 1);
            return elem;
        }

        public void PrintElement(int k)
        {
            Console.WriteLine("{0}-й элемент геометрической прогрессии: {1}", k, GetElement(k));
        }

        public void Show()
        {
            Console.WriteLine("\nГеометрическая прогрессия: b1 = {0}, q = {1}", start, diff);
        }
    }
}
