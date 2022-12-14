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

            //Calculate hand values - base 60
            TimeSpan startTime = new TimeSpan(hours, minutes, 0);
            var hourHand = startTime.Hours % 12;
            var minuteHand = startTime.Minutes;

            //Calculate shorter angle
            var diff = Math.Abs((minuteHand - (hourHand * 5)));
            if (diff > 30)
            {
                diff = 60 - diff;
            }
            var angle = diff * 6;

            Console.WriteLine("The angle between the hands is: " + angle);
        }
    }
}