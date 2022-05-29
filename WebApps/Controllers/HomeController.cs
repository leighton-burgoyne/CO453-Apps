using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApps.Models;
using ConsoleAppProject.App02;

namespace WebApps.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() // Index Page View
        {
            return View();
        }

        public IActionResult DistanceConverter() // Distance Converter Page View
        {
            return View();
        }

        [HttpGet]
        public IActionResult BMICalculator() // BMI Calculator Page View
        {
            return View();
        }

        [HttpPost]
        public IActionResult BMICalculator(BMICalculatorWeb calculator) // BMI Calculator with BMI Page View
        {
            if (calculator.Centimetres > 140)
            {
                calculator.CalculateMetric();
            }
            else if (calculator.Feet > 4 && calculator.Stones > 6)
            {
                calculator.CalculateImperial();
            }
            else
            {
                ViewBag.Error = "Values too small";
                return View();
            }

            double bmiValue = calculator.Bmi;
  
            return RedirectToAction("HealthMessage", new { bmiValue }); 
        }

        public IActionResult HealthMessage(double bmiValue) // BMI Calculator Health Message Page View
        {
            return View(bmiValue);
        }

        public IActionResult StudentMarks() // Student Marks Page View
        {
            return View();
        }
        public IActionResult SocialNetwork() // Social Network Page View
        {
            return View();
        }

        public IActionResult MonoGame() // MonoGame Page View
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() // Error Handling
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
