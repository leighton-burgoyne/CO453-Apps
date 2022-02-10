using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// 
    /// </summary>
    /// <author>
    /// Leighton Burgoyne Version 0.1
    /// </author>
    public class DistanceConverter
    {
        private const int MileInFeet = 5280; // 1 Mile in Feet
        private double miles; // Miles Variable
        private double feet; // Feet Variable

        /// <summary>
        ///
        /// </summary>
        public void Run()
        {
            InputMiles();
            CalculateFeet();
            OutputFeet();
        }

        public void OutputHeading()
        {
            Console.WriteLine();
            Console.WriteLine("--------------------------");
            Console.WriteLine("App01: Distance Converter ");
            Console.WriteLine("   Convert Miles to Feet  ");
            Console.WriteLine("   by Leighton Burgoyne   ");
            Console.WriteLine("--------------------------");
            Console.WriteLine();
        }

        /// <summary>
        /// 
        /// </summary>
        private void InputMiles()
        {
            OutputHeading();
            Console.Write("Enter Number of Miles: ");
            string input = Console.ReadLine();
            miles = Convert.ToDouble(input);
        }

        /// <summary>
        /// 
        /// </summary>
        private void CalculateFeet()
        {
            feet = miles * MileInFeet;
        }

        /// <summary>
        /// 
        /// </summary>
        private void OutputFeet()
        {
            Console.WriteLine(miles + " miles is " + feet + " feet.");
        }
    }
}
