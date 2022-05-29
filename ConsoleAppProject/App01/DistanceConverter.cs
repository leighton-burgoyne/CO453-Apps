﻿using ConsoleAppProject.Helpers;
using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This program converts Distance Measurements to different units, such as between Miles and Feet - it then outputs the result of the conversion to the user.
    /// </summary>
    /// <author>
    /// Leighton Burgoyne Version 0.2 (Refactored)
    /// </author>
    public class DistanceConverter
    {
        // Constants
        private const int MileInFeet = 5280; // 1 Mile in Feet used for calculating the Results.
        private const double MileInMetres = 1609.34; // 1 Mile in Metres used for calculating the Results.
        public const double FeetInMetres = 3.28084; // 1 Foot in Metres used for calculating the Results.

        // Variables
        public double FromDistance { get; set; } // From Distance Variable
        public double ToDistance { get; set; } // To Distance Variable

        // Enumerations
        public DistanceUnits FromUnit { get; set; } // Unit to convert from
        public DistanceUnits ToUnit { get; set; } // Unit to convert to

        // Constructor (Temp Web Use)
        public DistanceConverter()
        {
            FromUnit = DistanceUnits.Miles;
            ToUnit = DistanceUnits.Feet;
            FromDistance = 0;
        }
        /// <summary>
        /// Runs the required functions in the correct order, allowing for the program to operate correctly.
        /// </summary>
        public void Run()
        {
            InputUnits();
            InputValue();
            ConvertDistance();
            OutputDistance();
        }

        /// <summary>
        /// Allows the User to enter the unit they wish to convert from.
        /// </summary>
        public void InputUnits()
        {
            FromUnit = SelectUnit("Enter the unit you wish to convert from:");
            ToUnit = SelectUnit("Enter the unit you wish to convert to:");
        }

        public DistanceUnits SelectUnit(string prompt)
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
                Console.WriteLine($"Selected: {DistanceUnits.Feet}");
                return DistanceUnits.Feet;
            }

            else if (choice == "2")
            {
                Console.WriteLine($"Selected: {DistanceUnits.Miles}");
                return DistanceUnits.Miles;
            }

            else if (choice == "3")
            {
                Console.WriteLine($"Selected: {DistanceUnits.Metres}");
                return DistanceUnits.Metres;
            }
            else
            {
                Console.WriteLine("ERROR: Input Invalid");
                return DistanceUnits.NoUnit;
            }
        }

        /// <summary>
        /// Allows the User to input the number to be converted.
        /// </summary>
        public void InputValue()
        {
            FromDistance = ConsoleHelper.InputNumber($"Enter number of {FromUnit} > ");
        }

        /// <summary>
        /// Determines the Formula to be used for calculating the converted values, and performs the calculation.
        /// </summary>
        public void ConvertDistance()
        {
            if (FromUnit == DistanceUnits.Miles && ToUnit == DistanceUnits.Feet) // Miles to Feet
            {
                ToDistance = FromDistance * MileInFeet;
            }
            else if (FromUnit == DistanceUnits.Feet && ToUnit == DistanceUnits.Miles) // Feet to Miles
            {
                ToDistance = FromDistance / MileInFeet;
            }
            else if (FromUnit == DistanceUnits.Miles && ToUnit == DistanceUnits.Metres) // Miles to Metres
            {
                ToDistance = FromDistance * MileInMetres;
            }
            else if (FromUnit == DistanceUnits.Metres && ToUnit == DistanceUnits.Miles) // Metres to Miles
            {
                ToDistance = FromDistance / MileInMetres;
            }
            else if (FromUnit == DistanceUnits.Metres && ToUnit == DistanceUnits.Feet) // Metres to Feet
            {
                ToDistance = FromDistance * FeetInMetres;
            }
            else if (FromUnit == DistanceUnits.Feet && ToUnit == DistanceUnits.Metres) // Feet to Metres
            {
                ToDistance = FromDistance / FeetInMetres;
            }
            else // Other Combinations
            {
                Console.WriteLine("ERROR: Conversion Invalid");
            }

        }

        /// <summary>
        /// Outputs the result determined from the formula calculation to the user, with the program heading.
        /// </summary>
        public void OutputDistance()
        {
            ConsoleHelper.OutputHeading("Distance Converter");
            Console.WriteLine(FromDistance + " " + FromUnit + " converted to " + ToUnit + "\nEquals: " + ToDistance);
        }
    }
}
