using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPSolutionApp.Model
{
    internal class Pigeon : IBird, IFlyable
    {
        public string BodyColor { get; set; }

        public Pigeon(string bodyColor)
        {
            BodyColor = bodyColor;
        }
        public void Fly()
        {
            Console.WriteLine("Pigeon can fly");
        }
    }
}
