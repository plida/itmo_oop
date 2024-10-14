using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleClass
{
    internal class Triangle
    {
        private double a;
        private double b;
        private double c;

        public Triangle()
        {}

        public Triangle(double a, double b, double c) 
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public void Show()
        {
            Console.WriteLine("\nТреугольник: ");
            Console.WriteLine(" Стороны треугольника: a = {0:F2} b = {1:F2} c = {2:F2}", a, b, c);
            if (DoesExist()) {
                Console.WriteLine(" Треугольник существует.");
                Console.WriteLine(" Периметр треугольника: {0:F2}", CalcPerimeter());
                Console.WriteLine(" Площадь треугольника: {0:F2}", CalcArea());
            } 
            else Console.WriteLine(" Треугольник не существует.");
            
        }

        public double CalcPerimeter()
        {
            double P = a + b + c;
            return P;
        }

        public double CalcArea()
        {
            double p = CalcPerimeter() / 2;
            double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return S;
        }

        public bool DoesExist()
        {
            if (a + b <= c || b + c <= a || a + c <= b ) 
                return false;
            return true;
        }
    }
}
