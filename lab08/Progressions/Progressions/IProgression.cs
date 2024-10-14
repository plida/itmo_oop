using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progressions
{
    internal interface IProgression
    {
        int diff { get; set; }
        int start { get; set; }

        int GetElement(int k);

        void PrintElement(int k);

        void Show();
    }
}
