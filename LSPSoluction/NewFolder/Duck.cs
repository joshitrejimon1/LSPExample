using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace LSPSolutionApp.Model
{
    internal class Duck:IBird,INonFlyable,ISwimmable
    {
        public string BodyColor { get; set; }

        public Duck(string bodyColor)
        {
            BodyColor = bodyColor;
        }

        public void Walk()
        {
            Console.WriteLine("Duck can walk");
        }
        public void Swim()
        {
            Console.WriteLine("Duck can swim");
        }

    }
}
