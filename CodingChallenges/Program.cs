using System;
using AnimalActionsChallenge;

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
        }
    }
}
