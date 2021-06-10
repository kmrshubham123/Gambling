using System;

namespace Gambling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****Weclome to Gambling****");
            Gambler gambler = new Gambler();
            gambler.playGame();
        }
    }
}
