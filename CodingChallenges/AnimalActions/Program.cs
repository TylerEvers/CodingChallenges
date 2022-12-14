using AnimalActionsChallenge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges.AnimalActions
{
    internal class Program
    {
        internal static void AnimalActions()
        {
            //Animal Actions Challenge
            Parrot parrot = new();

            Console.WriteLine("Parrot");
            parrot.OutputEat();
            parrot.OutputFly();
            parrot.OutputSwim();
            parrot.OutputSound();

            Penguin penguin = new();

            Console.WriteLine("Penguin");
            penguin.OutputEat();
            penguin.OutputFly();
            penguin.OutputSwim();
            penguin.OutputSound();

            Pterodactyl pterodactyl = new();

            Console.WriteLine("Pterodactyl");
            pterodactyl.OutputEat();
            pterodactyl.OutputFly();
            pterodactyl.OutputSwim();
            pterodactyl.OutputSound();

            Duck duck = new();

            Console.WriteLine("Duck");
            duck.OutputEat();
            duck.OutputFly();
            duck.OutputSwim();
            duck.OutputSound();
        }
    }
}
