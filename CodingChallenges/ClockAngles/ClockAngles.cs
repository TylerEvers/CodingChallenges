using System;

namespace CodingChallenges.ClockAngles
{
    internal class Program
    {
        internal static void ClockAngles()
        {
            //Collect inputs
            Console.WriteLine("Enter hours:");
            int hours = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter minutes: ");
            int minutes = Convert.ToInt16(Console.ReadLine());

            //Calculate hand values - base 360
            var hourHand = ((hours % 12) * 30) + ((double)minutes/(double)60*30);
            var minuteHand = minutes * 6;

            //Calculate shorter angle
            var diff = Math.Abs(minuteHand - hourHand);
            if (diff > 180)
            {
                diff = 360 - diff;
            }
            var angle = diff;

            Console.WriteLine("The angle between the hands is: " + angle);
        }
    }
}