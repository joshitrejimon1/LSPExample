using LSPSolutionApp.Model;
using System;

namespace LSPSolutionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Pigeon pigeon = new Pigeon("Gray");


            Console.WriteLine($"Pigeon's Body Color: {pigeon.BodyColor}");

            pigeon.Fly();


        }
    }
}