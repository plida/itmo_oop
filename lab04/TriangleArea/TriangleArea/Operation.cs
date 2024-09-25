using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleArea
{
    internal class Operation
    {
        public static bool CalcArea(double a, double b, double c, out double area)
        {
            try
            {
                if (TriangleExists(a, b, c))
                {
                    double p = (a + b + c) / 2;
                    area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                    return true;
                }
                else throw new Exception("Triangle doesn't exist");
            }
            catch (Exception)
            {
                area = 0;
                return false;
            }
        }
        public static bool CalcArea(double a, out double area)
        {
            try
            {
                double p = (a * 3) / 2;
                area = Math.Sqrt(p * Math.Pow(p - a, 3));
                return true;
            }
            catch (Exception)
            {
                area = 0;
                return false;
            }
        }
        internal static bool TriangleExists(double a, double b, double c)
        {
            bool exists = false;
            if (a + b > c && a + c > b && b + c > a) exists = true;
            return exists;
        }
    }
}
