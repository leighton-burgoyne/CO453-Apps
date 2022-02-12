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
        private const int MileInFeet = 5280; // 1 Mile in Feet used for Calculating.
        private const double MileInMetres = 1; // 1 Mile in Metres for Calculating.

        private double feet; // Feet Variable
        private double metres; // Metres Variable
        private double miles; // Miles Variable

        private DistanceUnits fromUnit; // Unit to convert from
        private DistanceUnits toUnit; // Unit to convert to

        /// <summary>
        ///
        /// </summary>
        public void Run()
        {
            InputFromUnit();
            InputToUnit();
            ///InputMiles();
            ///CalculateFeet();
            ///OutputFeet();
        }

        /// <summary>
        ///
        /// </summary>
        public void InputFromUnit()
        {
            Console.WriteLine("Select Unit to Convert From:");
            Console.WriteLine();
            Console.WriteLine("1. Feet");
            Console.WriteLine("2. Metres");
            Console.WriteLine("3. Miles");
            Console.WriteLine();
            Console.Write("Enter Unit to convert from > ");
            string FromUnitInput = Console.ReadLine(); // Read the User Input from the Console
            
            switch (FromUnitInput)
            {
                case "1": // From Unit: Feet
                    Console.WriteLine("Converting from: Feet");
                    fromUnit = DistanceUnits.Feet;
                    break;

                case "2": // From Unit: Metres
                    Console.WriteLine("Converting from: Metres");
                    fromUnit = DistanceUnits.Metres;
                    break;

                case "3": // From Unit: Miles
                    Console.WriteLine("Converting from: Miles");
                    fromUnit = DistanceUnits.Miles;
                    break;

                default: // Invalid Input
                    Console.WriteLine("Invalid Input: Please specify an option from above.");
                    break;
            }
                
        }

        /// <summary>
        ///
        /// </summary>
        public void InputToUnit()
        {
            Console.WriteLine("Select Unit to Convert to:");
            Console.WriteLine();
            Console.WriteLine("1. Feet");
            Console.WriteLine("2. Metres");
            Console.WriteLine("3. Miles");
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

                case "2": // To Unit: Metres
                    Console.WriteLine("Converting to: Metres");
                    toUnit = DistanceUnits.Metres;
                    ConvertDistance();
                    break;

                case "3": // To Unit: Miles
                    Console.WriteLine("Converting to: Miles");
                    toUnit = DistanceUnits.Miles;
                    ConvertDistance();
                    break;

                default: // Invalid Input
                    Console.WriteLine("Invalid Input: Please specify an option from above.");
                    break;
            }

        }

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
        /// 
        /// </summary>
        private void ConvertDistance()
        {
            OutputHeading();
            Console.Write("Enter " + fromUnit + " value to convert from > ");
            string fromValue = Console.ReadLine();

            ///if (fromValue = DistanceUnits.Feet) && (toUnit = DistanceUnits.Metres)
            ///{
                ///Console.WriteLine("test");
            ///}

        }
        /// <summary>
        /// 
        /// </summary>
        private void InputMiles()
        {
            OutputHeading();
            Console.Write("Enter Number of Miles > ");
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
