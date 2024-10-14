using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangle t1 = new Triangle(12, 1, 1);
            t1.Show();
            Triangle t2 = new Triangle(3, 4, 5);
            t2.Show();
            Triangle t3 = new Triangle(3, 3, 3);
            t3.Show();
            Triangle t4 = new Triangle();
            t4.Show();
        }
    }
}
