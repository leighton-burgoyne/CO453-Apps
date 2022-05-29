using ConsoleAppProject.Helpers;
using System;
using System.Text;

namespace ConsoleAppProject.App02
{
    /// <summary>
    /// This program calculates a user's BMI (Body Mass Index) from their Weight and Height, it then assigns a Weight Status Category derived from the World Health Organisation.
    /// </summary>
    /// <author>
    /// Leighton Burgoyne Version 0.1
    /// </author>
    public class BMICalculatorWeb
    {
        // Variables

        public double Bmi { get; set; }
        // Metric
        public double Kilograms { get; set; }
        public int Centimetres { get; set; }
        private double metres;

        // Imperial
        public int Stones { get; set; } 
        public int Pounds { get; set; }
        
        public int Feet { get; set; }
        public int Inches { get; set; }

        // Constants
        public const int InchesInFeet = 12;
        public const int PoundsInStones = 14;

        public const double Underweight = 0.00;
        public const double Normal = 18.50;
        public const double Overweight = 25.00;
        public const double ObeseClass1 = 30.00;
        public const double ObeseClass2 = 35.00;
        public const double ObeseClass3 = 40.00;


        // Enumerations
        public MeasurementSystems Unit { get => default; } // Measurement System to use (Metric or Imperial)

        /// <summary>
        /// Runs the required functions in the correct order, allowing for the program to operate correctly.
        /// </summary>
        public void Run()
        {
            CalculateBMI();
        }

        /// <summary>
        /// 
        /// </summary>
        public void CalculateBMI()
        {
            if (Unit == MeasurementSystems.Metric)
            {
                CalculateMetric();
            }
            else if (Unit == MeasurementSystems.Imperial)
            {
                CalculateImperial();
            }
            else
            {
                Console.WriteLine("ERROR: Please select a valid unit");
            }

            Console.WriteLine(GetHealthMessage());
        }
        /// <summary>
        /// Calculates the Weight Status from the user inputted Weight and Height measurements using boundaries from WHO.
        /// </summary>
        public void CalculateMetric()
        {
            Centimetres = (int)ConsoleHelper.InputNumber("Enter Height in Centimetres > ");
            Kilograms = ConsoleHelper.InputNumber("Enter Weight in Kg > ");
            metres = (double)Centimetres / 100;
            Bmi = Kilograms / (Centimetres * Centimetres);
        }

        /// <summary>
        /// 
        /// </summary>
        public void CalculateImperial()
        {
            Console.WriteLine("Enter your Height in Feet and Inches");
            Feet = (int)ConsoleHelper.InputNumber("Feet > ");
            Inches = (int)ConsoleHelper.InputNumber("Inches > ");
            
            Console.WriteLine();
            
            Console.WriteLine("Enter your Weight in Stones and Pounds");
            Pounds = (int)ConsoleHelper.InputNumber("Stones > ");
            Pounds = (int)ConsoleHelper.InputNumber("Pounds > ");
            
            Inches += Feet * InchesInFeet;
            Pounds += Stones * PoundsInStones;
            Bmi = (double)Pounds * 703 / (Inches * Inches);
        }

        /// <summary>
        /// 
        /// </summary>
        public string GetHealthMessage()
        {
            StringBuilder message = new StringBuilder();
            if (Bmi < Underweight) // Underweight Range
            {
                message.Append($" Your BMI is {Bmi:0.00}, " +$"You are in the Underweight BMI Range.");
            }

            else if (Bmi <= Normal) // Normal Range
            {
                message.Append($" Your BMI is {Bmi:0.00}, " +$"You are in the Normal BMI Range.");
            }

            else if (Bmi <= Overweight) // Overweight Range
            {
                message.Append($" Your BMI is {Bmi:0.00}, " +$"You are in the Overweight BMI Range.");
            }

            else if (Bmi <= ObeseClass1) // Obese (Class I) Range
            {
                message.Append($" Your BMI is {Bmi:0.00}, " +$"You are in the Obese (Class I) BMI Range.");
            }

            else if (Bmi <= ObeseClass2) // Obese (Class II) Range
            {
                message.Append($" Your BMI is {Bmi:0.00}, " +$"You are in the Obese (Class II) BMI Range.");
            }

            else if (Bmi <= ObeseClass3) // Obese (Class III) Range
            {
                message.Append($" Your BMI is {Bmi:0.00}, " +$"You are in the Obese Class (III) BMI Range.");
            }

            return message.ToString();
        }

        /// <summary>
        /// Outputs a Heading showing the Program Name and the Author.
        /// </summary>
        public void OutputHeading()
        {
            Console.WriteLine();
            Console.WriteLine("--------------------------");
            Console.WriteLine("  App02: BMI Calculator   ");
            Console.WriteLine("   by Leighton Burgoyne   ");
            Console.WriteLine("--------------------------");
            Console.WriteLine();
            Console.WriteLine("What is BMI?");
            Console.WriteLine();
            Console.WriteLine("BMI (Body Mass Index) is a measure of your weight compared to your height,\nwhich allows us to work out which WHO Weight Status Category you fit into,\ngiving you an idea of how healthy you are. ");
            Console.WriteLine();
        }
    }
}
