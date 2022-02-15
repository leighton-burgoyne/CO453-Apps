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
        //private const double MileInMetres = 1609.34; // 1 Mile in Metres for calculating the Results.

        private double fromValue; // From Value Variable
        private double toValue; // To Value Variable

        private DistanceUnits fromUnit; // Unit to convert from
        private DistanceUnits toUnit; // Unit to convert to

        /// <summary>
        /// Runs the required functions in the correct order, allowing for the program to operate correctly.
        /// </summary>
        public void Run()
        {
            InputFromUnit();
            InputToUnit();
            InputValue();
            ConvertDistance();
            OutputDistance();
        }

        /// <summary>
        /// Allows the User to enter the unit they wish to convert from.
        /// </summary>
        public void InputFromUnit()
        {
            Console.WriteLine("Convert From:");
            Console.WriteLine();
            Console.WriteLine("1. Feet");
            Console.WriteLine("2. Miles");
            Console.WriteLine();
            Console.Write("Enter Unit to convert from > ");
            string FromUnitInput = Console.ReadLine(); // Read the User Input from the Console
            
            switch (FromUnitInput)
            {
                case "1": // From Unit: Feet
                    Console.WriteLine("Converting from: Feet");
                    fromUnit = DistanceUnits.Feet;
                    break;

                case "2": // From Unit: Miles
                    Console.WriteLine("Converting from: Miles");
                    fromUnit = DistanceUnits.Miles;
                    break;

                default: // Invalid Input
                    Console.WriteLine("Invalid Input: Please specify a valid option listed above.");
                    break;
            }
                
        }

        /// <summary>
        /// Allows the User to enter the unit they wish to convert to.
        /// </summary>
        public void InputToUnit()
        {
            Console.WriteLine("Convert To:");
            Console.WriteLine();
            Console.WriteLine("1. Feet");
            Console.WriteLine("2. Miles");
            Console.WriteLine();
            Console.Write("Enter Unit to convert to > ");
            string ToUnitInput = Console.ReadLine(); // Read the User Input from the Console

            switch (ToUnitInput)
            {
                case "1": // To Unit: Feet
                    Console.WriteLine("Converting to: Feet");
                    toUnit = DistanceUnits.Feet;
                    ConvertDistance();
                    break;

                case "2": // To Unit: Miles
                    Console.WriteLine("Converting to: Miles");
                    toUnit = DistanceUnits.Miles;
                    ConvertDistance();
                    break;

                default: // Invalid Input
                    Console.WriteLine("Invalid Input: Please specify a valid option listed above.");
                    break;
            }

        }

        /// <summary>
        /// Allows the User to input the number to be converted.
        /// </summary>
        public void InputValue()
        {
            Console.Write("Enter " + fromUnit + " value to be converted to " +toUnit + " > ");
            string fromValueInput = Console.ReadLine();
            fromValue = Convert.ToDouble(fromValueInput);
        }

        /// <summary>
        /// Outputs a Heading showing the Program Name and the Author.
        /// </summary>
        public void OutputHeading()
        {
            Console.WriteLine();
            Console.WriteLine("--------------------------");
            Console.WriteLine("App01: Distance Converter ");
            Console.WriteLine("   by Leighton Burgoyne   ");
            Console.WriteLine("--------------------------");
            Console.WriteLine();
        }

        /// <summary>
        /// Determines the Formula to be used for calculating the converted values, and performs the calculation.
        /// </summary>
        private void ConvertDistance()
        {
            if (fromUnit == DistanceUnits.Miles && toUnit == DistanceUnits.Feet)
            {
                toValue = fromValue * MileInFeet;
            }
            else if (fromUnit == DistanceUnits.Feet && toUnit == DistanceUnits.Miles)
            {
                toValue = fromValue / MileInFeet;
            }
            //else if (fromUnit == DistanceUnits.Miles && toUnit == DistanceUnits.Metres)
            //{
                //toValue = fromValue * MileInMetres;
            //}
            //else if (fromUnit == DistanceUnits.Metres && toUnit == DistanceUnits.Miles)
            //{
                //toValue = fromValue / MileInMetres;
            //}

        }

        /// <summary>
        /// Outputs the result determined from the formula calculation to the user, with the program heading.
        /// </summary>
        private void OutputDistance()
        {
            OutputHeading();
            Console.WriteLine(fromValue + " " + fromUnit + " converted to " + toUnit + "\nEquals: " + toValue);
        }
    }
}
