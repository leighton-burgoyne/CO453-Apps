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
        private double weight; // User Weight
        private double height; // User Height
        private double rawCalculation; // Raw Calculation before Squared
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
            Console.Write("Enter Weight in Kg > ");
            string weightInput = Console.ReadLine();
            weight = Convert.ToDouble(weightInput);

            Console.Write("Enter Height in Metres > ");
            string heightInput = Console.ReadLine();
            height = Convert.ToDouble(heightInput);
        }

        /// <summary>
        /// Calculates the Weight Status from the user inputted Weight and Height measurements using boundaries from WHO.
        /// </summary>
        public void CalculateBMI()
        {
            rawCalculation = weight / height; // Unsquared Calculation (Raw)
            double Sqr = Math.Pow(rawCalculation, 2); // Squared Calculation (Final)

            if (Sqr < 18.50) // Underweight Range
            {
                weightStatus = "Underweight";
            }

            else if (Sqr > 18.50 && Sqr < 24.9) // Normal Range
            {
                weightStatus = "Normal";
            }

            else if (Sqr > 25.0 && Sqr < 29.9) // Overweight Range
            {
                weightStatus = "Overweight";
            }

            else if (Sqr > 30.0 && Sqr < 34.9) // Obese (Class I) Range
            {
                weightStatus = "Obese (Class I)";
            }

            else if (Sqr > 35.0 && Sqr < 39.9) // Obese (Class II) Range
            {
                weightStatus = "Obese (Class II)";
            }

            else if (Sqr >= 40.0) // Obese (Class III) Range
            {
                weightStatus = "Obese (Class III)";
            }
        }

        /// <summary>
        /// Outputs the result determined from the BMI calculation to the user, with the program heading.
        /// </summary>
        public void OutputBMI()
        {
            OutputHeading();
            Console.WriteLine("Your BMI is: " +rawCalculation);
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
