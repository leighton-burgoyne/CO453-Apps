﻿using ConsoleAppProject.App03;
using ConsoleAppProject.Helpers;
using System;

namespace ConsoleAppProject
{
    /// <summary>
    /// The main method in this class is called first
    /// when the application is started.  It will be used
    /// to start Apps 01 to 05 for CO453 CW1
    /// 
    /// This Project has been modified by:
    /// Derek Peacock 14/12/2020
    /// Leighton Burgoyne 06/02/2022
    /// </summary>
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("BNU CO453 Applications Programming 2021-2022");
            Console.WriteLine("Created by Leighton Burgoyne");
            Menu();
        }

        public static void Menu() // Menu Navigation
        {
            Console.WriteLine("Please select a Program to Run:"); // User Prompt
            Console.WriteLine("1. App01: Distance Converter"); // Distance Converter
            Console.WriteLine("2. App02: BMI Calculator"); // BMI Calculator
            Console.WriteLine("3. App03: Student Marks"); // Student Marks
            Console.WriteLine("4. App04: Social Network"); // Social Network
            Console.WriteLine("5. App05: RPS Game"); // RPS Game

            string SelectedApp = Console.ReadLine(); // Read the User Input from the Console

            switch (SelectedApp) // Switch and Case Method for Option Selection
            {
                case "1": // App01: Distance Converter
                    Console.WriteLine("Loading App01: Distance Converter");
                    // Run Function
                    break;
                case "2": // App02: BMI Calculator
                    Console.WriteLine("Loading App02: BMI Calculator");
                    // Run Function
                    break;
                case "3": // App03: Student Marks
                    Console.WriteLine("Loading App03: Student Marks");
                    // Run Function
                    break;
                case "4": // App04: Social Network
                    Console.WriteLine("Loading App04: Social Network");
                    // Run Function
                    break;
                case "5": // App05: RPS Game
                    Console.WriteLine("Loading App05: RPS Game");
                    // Run Function
                    break;
                default: // Invalid Input
                    Console.WriteLine("Invalid Input: Please specify an option from the list above");
                    // Run Function
                    break;
            }
        }
    }
}
