using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace LSPSolutionApp.Model
{
    internal class Ostrich : IBird, INonFlyable
    {
        public string BodyColor { get; set; }

        public Ostrich(string bodyColor)
        {
            BodyColor = bodyColor;
        }

        public void Walk()
        {
            Console.WriteLine("Ostrich cannot fly");
        }
    }
}
