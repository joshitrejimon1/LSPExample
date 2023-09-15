using LSPSolutionApp.Model;
{
    static void Main(string[] args)
    {
        Random random = new Random();

        IFlyable[] birds = {
                new Sparrow("Brown"),
                new Pigeon("White"),
            };

        INonFlyable[] nonFlyableBirds = {
                new Ostrich("Brown"),
                new Duck("White"),
            };

        foreach (var bird in birds)
        {
            Console.WriteLine($"This bird color is {bird.BodyColor}...");
            if (random.Next(2) == 0)
            {
                bird.Fly();
            }
            else
            {
                Console.WriteLine($"{bird.GetType().Name} (color: {bird.BodyColor}) does not fly.");
            }
            Console.WriteLine("--------------------------------------");
        }

        foreach (var bird in nonFlyableBirds)
        {
            Console.WriteLine($"This bird color is {bird.BodyColor}...");
            bird.Walk();
            Console.WriteLine("--------------------------------------");
        }
    }
}