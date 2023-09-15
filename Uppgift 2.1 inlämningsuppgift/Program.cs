using System;

namespace Atte
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vad är din favoritbok?");
            string favoritbok = Console.ReadLine();

            Console.WriteLine("Din favoritbok är " + favoritbok + " Det är en bra bok");
        }
    }
}