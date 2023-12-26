using System;

namespace MontyHall
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                GameSimulator gameSimulator = new GameSimulator();
                gameSimulator.SimulateGame();

                Console.WriteLine($"\nPress any key to run again");
                Console.ReadLine();
            } while (true);
        }
    }
}
