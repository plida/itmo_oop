using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArithmeticProgression a1 = new ArithmeticProgression(1, 1);
            GeometricProgression g1 = new GeometricProgression(1, 3);

            a1.Show();
            a1.PrintElement(2);
            a1.PrintElement(4);

            g1.Show();
            g1.PrintElement(3);
            g1.PrintElement(5);

            ArithmeticProgression a2 = new ArithmeticProgression(4, 3);
            GeometricProgression g2 = new GeometricProgression(2, 4);

            a2.Show();
            a2.PrintElement(5);
            a2.PrintElement(7);

            g2.Show();
            g2.PrintElement(2);
            g2.PrintElement(4);
        }

        
    }
}
