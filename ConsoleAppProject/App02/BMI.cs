using ConsoleAppProject.Helpers;
using System;

namespace ConsoleAppProject.App02
{
    /// <summary>
    /// This program calculates a user's BMI (Body Mass Index) from their Weight and Height, it then assigns a Weight Status Category derived from the World Health Organisation.
    /// </summary>
    /// <author>
    /// Leighton Burgoyne Version 0.1
    /// </author>
    public class BMICalculator
    {
        // Variables
        private double weight; // User Weight
        private double height; // User Height
        private double bmi;
        private string weightStatus; // Assigned Weight Status (derived from WHO)

        /// <summary>
        /// Runs the required functions in the correct order, allowing for the program to operate correctly.
        /// </summary>
        public void Run()
        {
            InputValue();
            CalculateBMI();
            OutputBMI();
        }


        /// <summary>
        /// Allows the User to input the weight and height in a Kg and Metres (kg/m2).
        /// </summary>
        public void InputValue()
        {
            height = ConsoleHelper.InputNumber("Enter Height in Metres > ");
            weight = ConsoleHelper.InputNumber("Enter Weight in Kg > ");
        }

        /// <summary>
        /// Calculates the Weight Status from the user inputted Weight and Height measurements using boundaries from WHO.
        /// </summary>
        public void CalculateBMI()
        {
            double heightSqr = Math.Pow(height, 2);

            bmi = Math.Round(weight / heightSqr, 2);

            if (bmi < 18.50) // Underweight Range
            {
                weightStatus = "Underweight";
            }

            else if (bmi > 18.50 && bmi < 24.99) // Normal Range
            {
                weightStatus = "Normal";
            }

            else if (bmi > 25.00 && bmi < 29.99) // Overweight Range
            {
                weightStatus = "Overweight";
            }

            else if (bmi > 30.00 && bmi < 34.99) // Obese (Class I) Range
            {
                weightStatus = "Obese (Class I)";
            }

            else if (bmi > 35.00 && bmi < 39.99) // Obese (Class II) Range
            {
                weightStatus = "Obese (Class II)";
            }

            else if (bmi >= 40.00) // Obese (Class III) Range
            {
                weightStatus = "Obese (Class III)";
            }
            else
            {
                weightStatus = "No Status Assigned";
            }
        }

        /// <summary>
        /// Outputs the result determined from the BMI calculation to the user, with the program heading.
        /// </summary>
        public void OutputBMI()
        {
            OutputHeading();
            Console.WriteLine("Your BMI is: " +bmi);
            Console.WriteLine("This places you into the " +weightStatus + " category");
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
