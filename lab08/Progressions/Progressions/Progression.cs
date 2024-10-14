using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progressions
{
    abstract class Progression
    {
        public Progression() {}

        abstract public int GetElement(int k);

        abstract public void PrintElement(int k);

        abstract public void Show();
    }
}
