using AnimalActionsChallenge;
using System;

namespace CodingChallenges.AnimalActions
{
    internal class Program
    {
        internal static void AnimalActions()
        {
            //Animal Actions Challenge
            Parrot parrot = new Parrot();

            Console.WriteLine("Parrot");
            parrot.OutputEat();
            parrot.OutputFly();
            parrot.OutputSwim();
            parrot.OutputSound();

            Penguin penguin = new Penguin();

            Console.WriteLine("Penguin");
            penguin.OutputEat();
            penguin.OutputFly();
            penguin.OutputSwim();
            penguin.OutputSound();

            Pterodactyl pterodactyl = new Pterodactyl();

            Console.WriteLine("Pterodactyl");
            pterodactyl.OutputEat();
            pterodactyl.OutputFly();
            pterodactyl.OutputSwim();
            pterodactyl.OutputSound();

            Duck duck = new Duck();

            Console.WriteLine("Duck");
            duck.OutputEat();
            duck.OutputFly();
            duck.OutputSwim();
            duck.OutputSound();
        }
    }
}
