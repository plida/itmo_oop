using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquation
{
    internal class Utils
    {
        public static int FindSolution(double a, double b, double c, out double x1, out double x2)
        {
            double D = b * b - 4 * a * c;
            if (D > 0)
            {
                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                x2 = (-b - Math.Sqrt(D)) / (2 * a);
                return 1;
            }
            else if (D == 0)
            {
                x1 = x2 = (-b) / (2 * a);
                return 0;
            }
            else
            {
                x1 = x2 = 0;
                return -1;
            }
        }
    }
}

