using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPSolutionApp.Model
{
    internal class Sparrow:IBird,IFlyable
    {
        public string BodyColor { get; set; }

        public Sparrow(string bodyColor)
        {
            BodyColor = bodyColor;
        }
        public void Fly()
        {
            Console.WriteLine("Sparrow can fly");
        }
    }
}
