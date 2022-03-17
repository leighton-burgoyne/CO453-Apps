using ConsoleAppProject.Helpers; // Uses Helper Classes
using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This program converts Distance Measurements to different units, such as between Miles and Feet - it then outputs the result of the conversion to the user.
    /// </summary>
    /// <author>
    /// Leighton Burgoyne Version 0.1
    /// </author>
    public class DistanceConverter
    {
        private const int MileInFeet = 5280; // 1 Mile in Feet used for calculating the Results.
        private const double MileInMetres = 1609.34; // 1 Mile in Metres for calculating the Results.

        private double fromValue; // From Value Variable
        private double toValue; // To Value Variable

        private DistanceUnits fromUnit; // Unit to convert from
        private DistanceUnits toUnit; // Unit to convert to

        /// <summary>
        /// Runs the required functions in the correct order, allowing for the program to operate correctly.
        /// </summary>
        public void Run()
        {
            InputUnits();
            ConvertDistance();
            OutputDistance();
            InputValue();
        }

        /// <summary>
        /// Allows the User to enter the unit they wish to convert from.
        /// </summary>
        public void InputUnits()
        {
            fromUnit = SelectUnit("Enter the unit you wish to convert from:");
            toUnit = SelectUnit("Enter the unit you wish to convert to:"); 
        }

        private DistanceUnits SelectUnit(string prompt)
        {
            Console.WriteLine(prompt);
            Console.WriteLine();

            Console.WriteLine($" 1. {DistanceUnits.Feet}");
            Console.WriteLine($" 2. {DistanceUnits.Miles}");
            Console.WriteLine($" 3. {DistanceUnits.Metres}");
            Console.WriteLine();

            Console.Write("Please enter choice > ");

            string choice = Console.ReadLine();
            Console.WriteLine();

            if (choice == "1")
            {
                Console.WriteLine($"Converting from: {DistanceUnits.Feet}");
                return DistanceUnits.Feet;
            }

            else if (choice == "2")
            {
                Console.WriteLine($"Converting from: {DistanceUnits.Miles}");
                return DistanceUnits.Miles;
            }

            else if (choice == "3")
            {
                Console.WriteLine($"Converting from: {DistanceUnits.Metres}");
                return DistanceUnits.Metres;
            }
            else
            {
                Console.WriteLine($"ERROR: Input Invalid");
                return DistanceUnits.NoUnit;
            }
        }
 
        /// <summary>
        /// Allows the User to input the number to be converted.
        /// </summary>
        public void InputValue()
        {
            fromValue = ConsoleHelper.InputNumber("Enter value to convert to > ");
        }

        /// <summary>
        /// Determines the Formula to be used for calculating the converted values, and performs the calculation.
        /// </summary>
        private void ConvertDistance()
        {
            if (fromUnit == DistanceUnits.Miles && toUnit == DistanceUnits.Feet) // Miles to Feet
            {
                toValue = fromValue * MileInFeet;
            }
            else if (fromUnit == DistanceUnits.Feet && toUnit == DistanceUnits.Miles) // Feet to Miles
            {
                toValue = fromValue / MileInFeet;
            }
            else if (fromUnit == DistanceUnits.Miles && toUnit == DistanceUnits.Metres) // Miles to Metres
            {
                toValue = fromValue * MileInMetres;
            }
            else if (fromUnit == DistanceUnits.Metres && toUnit == DistanceUnits.Miles) // Metres to Miles
            {
                toValue = fromValue / MileInMetres;
            }
            else // Other Combinations
            {
                Console.WriteLine("ERROR: Conversion Invalid");
            }

        }

        /// <summary>
        /// Outputs the result determined from the formula calculation to the user, with the program heading.
        /// </summary>
        private void OutputDistance()
        {
            ConsoleHelper.OutputHeading("Distance Converter");
            Console.WriteLine(fromValue + " " + fromUnit + " converted to " + toUnit + "\nEquals: " + toValue);
        }
    }
}
