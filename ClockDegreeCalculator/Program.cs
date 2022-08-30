using System;

namespace ClockDegreeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter hours");
            decimal hours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter minutes");
            decimal minutes = Convert.ToInt32(Console.ReadLine());


            // Validate data for analog clock
            if (minutes > 60) { Console.WriteLine($"Minutes must be less or equal to 60. You entered: {minutes}."); return; }
            if(hours > 12) hours = hours - 12;
            if(hours == 12) hours = 0;

            decimal hdeg = hours * (360 / 12) + (minutes * 360 / 12 / 60); // Hour arrow position by minutes
            decimal mdeg = minutes * (360 / 60);

            decimal degrees = Math.Abs(hdeg - mdeg);

            // Return lesser angle
            if(degrees > 180) Console.WriteLine(360 - degrees);

            Console.WriteLine(degrees);

        }
    }
}