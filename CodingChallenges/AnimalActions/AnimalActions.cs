using System;

namespace AnimalActionsChallenge
{
    internal static class AnimalActions //Action Class
    {
        public static void Eat(Animal animal)
        {
            animal.OutputEat();
        }

        public static void Swim(Animal animal)
        {
            animal.OutputSwim();
        }

        public static void Fly(Animal animal)
        {
            animal.OutputFly();
        }

        public static void GetAnimalSound(Animal animal)
        {
            animal.OutputSound();
        }
    }

    class Animal //Base Animal Class
    {
        public virtual void OutputEat()
        {
            Console.WriteLine("All animals eat, I think");
        }

        public virtual void OutputSwim()
        {
            Console.WriteLine("This animal doesn't swim");
        }

        public virtual void OutputFly()
        {
            Console.WriteLine("This animal doesn't fly");
        }

        public virtual void OutputSound()
        {
            Console.WriteLine("This animal is silent");
        }
    }

    class Parrot : Animal
    {
        public override void OutputFly()
        {
            Console.WriteLine("Flaps wings and takes off from the canopy");
        }

        public override void OutputSound()
        {
            Console.WriteLine("SQUAWK");
        }
    }

    class Penguin : Animal
    {
        public override void OutputSwim()
        {
            Console.WriteLine("Dives into the icy waters");
        }

        public override void OutputSound()
        {
            Console.WriteLine("HONK");
        }
    }

    class Pterodactyl : Animal
    {
        public override void OutputFly()
        {
            Console.WriteLine("Flaps wings and glides through the sky");
        }

        public override void OutputSound()
        {
            Console.WriteLine("KWAAAAA");
        }
    }

    class Duck : Animal
    {
        public override void OutputSwim()
        {
            Console.WriteLine("Floats around on the pond");
        }

        public override void OutputSound()
        {
            Console.WriteLine("QUACK");
        }
    }
}

