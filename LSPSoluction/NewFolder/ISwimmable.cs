using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPSolutionApp.Model
{
    internal interface ISwimmable:IBird
    {
        void Swim();
        void Walk();
    }
}
