using System;

namespace CodingChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            //Animal Actions
            Console.WriteLine("Beginning Animal Actions: " + DateTime.Now);
            AnimalActions.Program.AnimalActions();
            Console.WriteLine("Ending Animal Actions: " + DateTime.Now + "\x0A");
            
            //Clock Angles
            Console.WriteLine("Beginning Clock Angles: " + DateTime.Now);
            ClockAngles.Program.ClockAngles();
            Console.WriteLine("Beginning Clock Angles: " + DateTime.Now + "\x0A");

            //Binary Search
            Console.WriteLine("Beginning Binary Search: " + DateTime.Now);
            BinarySearch.Program.BinarySearch();
            Console.WriteLine("Beginning Binary Search: " + DateTime.Now + "\x0A");
        }
    }
}
