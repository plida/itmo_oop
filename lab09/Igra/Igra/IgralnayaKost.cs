using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Igra
{
    internal class IgralnayaKost
    {
        Random r;
        public delegate void ProcessKostDelegate();
        public static event ProcessKostDelegate MaxScore;
        public IgralnayaKost()
        {
            r = new Random();
        }

        public int random()
        {
            int res = r.Next(6) + 1;
            if (res == 6) MaxScore();
            return res;
        }
    }
}
