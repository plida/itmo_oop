using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Igra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gamer g1 = new Gamer("Niko");
            for (int i = 1; i <= 6; i++)
                Console.WriteLine("Выпало количество очков {0} для игрока {1}",
                    g1.SeansGame(), g1.ToString());
        }
    }
}
